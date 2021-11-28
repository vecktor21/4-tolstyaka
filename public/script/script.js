
window.onload = ()=>{
    document.getElementById('cart').onclick = toCart;

    const toCartButtons = document.querySelectorAll(".cartBtn");
    for (var i = 0; i < toCartButtons.length; i++) {
        toCartButtons[i].onclick = addToCart;
    }
};


function  addToCart() {
    if (JSON.parse(localStorage.getItem('cart')) == null){
        const cart = [];
        localStorage.setItem('cart', JSON.stringify(cart));
    }else{
        const cart = JSON.parse(localStorage.getItem('cart'));
        console.log(`cake${this.id}`);
        item = document.getElementById(`cake${this.id}`).children[0].children;
        let isNotExist = true;
        cart.forEach(cake=>{
            if (cake.id == `cake${this.id}`){
                alert("Товар добавлен");
                cake.count++;
                isNotExist = false;
            }
        })
        if (isNotExist) {
            const cake = {
                name: item[1].children[0].innerText,
                discription: item[1].children[1].innerText,
                price: item[1].children[2].innerText.split('Цена: ')[1],
                img: item[0].src,
                id: `cake${this.id}`,
                count: 1
            };
            cake.count = prompt("Количество: ", 1);
            cart.push(cake);
        }
        console.log(cart)
        localStorage.setItem('cart', JSON.stringify(cart));
    }

}
function toCart(){
    window.location.href = "/cart";
}


/*
<div class="card" style="width: 18rem;">
    <img src="public/images/cake.jpg" class="card-img-top" alt="cake">
    <div class="card-body">
    <h5 class="card-title">Торт</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
<a href="#" class="btn btn-primary">В корзину <i class="fas fa-cart-plus"></i></a>
</div>
</div>*/
