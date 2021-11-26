window.onload = ()=>{
    const cart = JSON.parse(localStorage.getItem('cart'));
    console.log(cart);
    fillCart(cart);
    const reduceCartButtons = document.querySelectorAll(".reduce");
    const addCartButtons = document.querySelectorAll(".add");
    for (var i = 0; i < reduceCartButtons.length; i++) {
        reduceCartButtons[i].onclick = function () {
            console.log('работает удаление')
            reduceCount(cart, (this.id).split('reduce')[1]);
        }
        addCartButtons[i].onclick = function () {
            console.log('работает добавление')
            addCount(cart, (this.id).split('add')[1]);
        }
        //addCartButtons[i].onclick = addCount;
    }
    document.getElementById('clear').onclick = ()=>{
        localStorage.clear();
        window.location.reload();
    }
    document.getElementById('toPay').onclick = ()=>{window.location.href = '/'}
}
function fillCart(cart) {
    document.getElementById('cartItems').innerHTML = '';
    let itog = 0;
    cart.forEach((cake)=>{
        if(document.getElementById(cake.id) == null){
            renderCakes(cake);
        }
        else{
            /*const childs = document.getElementById('cartItems').children;
            for (let o = 0; i < childs.length; i++){
                if (childs[i].id == cake.id){
                    childs.removeChild(childs[i]);
                }
            }*/
            cake.count++;
            renderCakes(cake);
        }
        itog += Number(cake.price.split('тг')[0]) * Number(cake.count);
    });
    document.getElementById('itog').innerHTML = `Итого: ${itog}`
}
function renderCakes(cake) {
    document.getElementById('cartItems').innerHTML += `<div class="card" id="${cake.id}">
            <h5 class="card-header">${cake.name}</h5>
            <div class="card-body itemsInCart">
            <div>
                <img src="${cake.img}" class="float-end img-fluid" height="200px">
            </div>
            <div class="description">
                <h5>Описание:</h5>
                <p class="card-text">${cake.discription}</p>
                <p class="card-text"><i id="reduce${(cake.id).split('cake')[1]}" class="reduce fas fa-minus"></i>Количество: <span class="countCakes">${cake.count}</span><i id="add${(cake.id).split('cake')[1]}" class="add fas fa-plus"></i></p>
                <p class="card-text">Цена: ${cake.price}</p>
            </div>
            </div>
        </div>`;
}
function reduceCount(cart, id) {
    cart.forEach(cake=>{
        if((cake.id).split('cake')[1] == id){
            cake.count = Number(cake.count)-1;
            if (cake.count <= 0){
                cart.splice(cart.indexOf(cake), 1);
            }
        }
    })
    localStorage.setItem('cart', JSON.stringify(cart));
    //fillCart(cart);
    window.location.reload();
}
function addCount(cart, id) {
    cart.forEach(cake=>{
        if((cake.id).split('cake')[1] == id){
            cake.count = Number(cake.count)+1;
        }
    })
    localStorage.setItem('cart', JSON.stringify(cart));
    //fillCart(cart);
    window.location.reload();
}