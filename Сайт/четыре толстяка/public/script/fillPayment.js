window.onload = ()=>{
    const cart = JSON.parse(localStorage.getItem('cart'));
    console.log(cart);
    fillBuyList(cart);
}
function fillBuyList(cart) {
    document.getElementById('cartItems').innerHTML = '';
    let itog = 0;
    cart.forEach((cake)=>{
        if(document.getElementById(cake.id) == null){
            renderCakes(cake);
        }
        else{
            cake.count++;
            renderCakes(cake);
        }
        itog += Number(cake.price.split('тг')[0]) * Number(cake.count);
    });
    document.getElementById('itog').innerHTML = `Итого: ${itog}`
}
function renderCakes(cake) {
    document.getElementById('cartItems').innerHTML += `<div class="card" id="${cake.id}">
            
            <div class="card-body itemsInCart">
            <div class="description">
                <label class="card-text">Название: </label><input type="text" disabled class="form-control" value="${cake.name}" id="itemName${cake.id}" name="itemName${cake.id}">
                <label class="card-text">Количество: </label><input type="text" disabled class="form-control" value="${cake.count}" id="itemCount${cake.id}" name="itemCount${cake.id}">
                <label class="card-text">Цена: </label><input type="text" disabled class="form-control" value="${cake.price}" id="itemPrice${cake.id}" name="itemPrice${cake.id}">
            </div>
            </div>
        </div>`;
}