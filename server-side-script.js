const express = require('express');
const app = express();
const mysql = require('mysql2/promise');
const bodyParser = require('body-parser');
const urlencodedParser = bodyParser.urlencoded({ extended: false })
const config = require('./config');
const ls = require('local-storage');
//порт для подключения
const PORT = process.env.PORT || 3000;
//используем шаблонизатор ejs
app.set('view engine', 'ejs');
app.use('/public', express.static('public'));


//ссылка на страницу '/' и '/main'
app.get('/', (req, res)=>{
    (async function (){
        //получаем данные из бд
        const rowsFromTable = await executeQuery(config, 'SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID')

        //console.log(rowsFromTable);
        const cakes = {
            rows: rowsFromTable
        }
        //console.log(cakes);
        //отображаем данные в шаблоне main
        res.render('main', {content: cakes});
    })();
});
//сортировка по категориям  и по цене
app.get('/main', (req, res)=>{
    let category = req.query.category;
    let sort = req.query.sortDirection;
    if (category == '' || category == undefined){category = '0'}
    console.log(sort);
    console.log(category);
    //console.log(req.body);
//сортировка по возрастанию цены
    if (sort == 'asc'){
        if(category <= 4 && category >= 0){
            (async function (){
                let rowsFromTable = '';
                //сортировка по категориям
                if (category == 0){
                    rowsFromTable = await executeQuery(config, 'SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID ORDER BY cakes.price ASC')
                }else{
                    rowsFromTable = await executeQuery(config, `SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID WHERE categories.categoryID = ${category} ORDER BY cakes.price ASC`)
                }
                //console.log(rowsFromTable);
                const cakes = {
                    rows: rowsFromTable,
                    category: category
                }
                //console.log(cakes);
                res.render('main', {content: cakes});
            })();
        }
        else{
            res.render('error', {});
        }
    }
    //сортировка по убыванию цены
    else if(sort == 'desc'){
        if(category <= 4 && category >= 0){
            (async function (){
                let rowsFromTable = '';
                //сортировка по категориям
                if (category == 0){
                    rowsFromTable = await executeQuery(config, 'SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID ORDER BY cakes.price DESC')
                }else{
                    rowsFromTable = await executeQuery(config, `SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID WHERE categories.categoryID = ${category} ORDER BY cakes.price DESC`)
                }
                //console.log(rowsFromTable);
                const cakes = {
                    rows: rowsFromTable,
                    category: category
                }
                //console.log(cakes);
                res.render('main', {content: cakes});
            })();
        }
        else if(category > 4 || category <= 0){
            res.render('error', {});
        }
    }
    //сортировка по умолчанию
    else if(sort == undefined){
        if(category <= 4 && category >= 0){
            (async function (){
                let rowsFromTable = '';
                if (category == 0){
                    rowsFromTable = await executeQuery(config, 'SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID')
                }else{
                    rowsFromTable = await executeQuery(config, `SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID WHERE categories.categoryID = ${category}`)
                }
                //console.log(rowsFromTable);
                const cakes = {
                    rows: rowsFromTable,
                    category: category
                }
                //console.log(cakes);
                res.render('main', {content: cakes});
            })();
        }
        else if(category > 4 || category <= 0){
            res.render('error', {});
        }
    }
    else {
        res.render('error', {});
    }
});
/*app.post('/main', (req, res)=>{
    let category = req.query.category;
    console.log(req.body);
    (async function (){
        if(category <= 4 && category > 0){
            let rowsFromTable = '';
            if (category == null){
                rowsFromTable = await executeQuery(config, 'SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID')
            }else{
                rowsFromTable = await executeQuery(config, `SELECT cakes.ID, cakes.name, cakes.discription, cakes.composition, cakes.price, cakes.weight, cakes.image, categories.name AS \'category\' FROM cakes INNER JOIN categories ON cakes.categoryID = categories.categoryID WHERE categories.categoryID = ${category}`)
            }
            //console.log(rowsFromTable);
            const cakes = {
                rows: rowsFromTable
            }
            //console.log(cakes);
            res.render('main', {content: cakes});
        }
        else if(category > 4 && category <= 0){
            res.render('error', {});
        }
    })();
});*/
//страницы "контакты", "доставка", "корзина"
app.get('/contact', (req, res)=>{
    res.render('contact', {});
});
app.get('/deliver', (req, res)=>{
    res.render('deliver', {});
});
app.get('/cart', (req, res)=>{
    const cartElems = ls.get('cartElements');
    res.render('cart', {cart: cartElems});
});

app.listen(PORT);

//функция для выполнения запроса
async function executeQuery(config, query){
    const conn = await mysql.createConnection(config);

    const [rows, fields] = await conn.execute(query);
    //console.log(fields);
    return rows;
}
