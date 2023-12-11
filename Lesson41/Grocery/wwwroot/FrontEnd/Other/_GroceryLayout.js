var cart = document.querySelector('.navbar-cart')

document.querySelector('#shop-cart').onclick = () => {
    cart.classList.toggle('active');
}
document.querySelector('#x').onclick = () => {
    cart.classList.toggle('active');
}
var btns = document.querySelectorAll(".add")
var items = [];
if (JSON.parse(localStorage.getItem('items')) != null) {
    items = JSON.parse(localStorage.getItem('items'))
    //document.getElementById('num').attributes[0].value = JSON.parse(localStorage.getItem('items')).length
}
AddtoCart()
btns.forEach(element => {
    element.addEventListener("click", function () {
        var e = element.parentElement
        item = {
                    n: e.attributes[0].value,
                    image: e.children[0].children[0].attributes[0].value,
                    name: e.children[1].children[0].textContent,
                    price: e.children[1].children[1].textContent,
                    count: 1
                };
        var b = false;
        items.forEach(i => {
            if (i.name == item.name) {
                b = true;
                i.count++
            }
        })
        if (!b) {
            items.push(item)
        }
        localStorage.setItem('items', JSON.stringify(items))
        AddtoCart()
        //document.getElementById('num').attributes['data-count'].value = JSON.parse(localStorage.getItem('items')).length
    });
});

function AddtoCart() {
    var ul = document.getElementById('list')
    var data = ''
    if (JSON.parse(localStorage.getItem('items')) != null) {
        var array = JSON.parse(localStorage.getItem('items'))
        array.forEach(x => {
            data += `
                     <li id="${x.n}">
                         <img src="${x.image}" class="cart-img" alt="">
                         <div class="cart-context">
                             <div class="car-name">${x.name}</div>
                             <div class="cart-price">${x.price}</div>
                         </div> 
                         <div class="count">
                             <div id="c">${x.count}</div>
                
                         </div>
                         <div class="cart-trash"><i class="fa-solid fa-trash"></i></div>
                     </li>
                         `
        })
    }
    ul.innerHTML = data
}
var trashBtns=document.querySelectorAll('.cart-trash');

for (var element of trashBtns) {
    element.addEventListener("click",function() {
            var e = element.parentElement
            console.log(e)
        })
        localStorage.getItem('items')
    }
    for (var item of items){
        console.log(item.n)
    }
// console.log(document.getElementById('5').innerHTML)
// console.log(trashBtns[0])
    var div = document.querySelectorAll(".fa-trash")
    console.log(div)