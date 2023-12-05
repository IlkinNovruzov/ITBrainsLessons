var b = document.querySelectorAll(".add")
var items = [];
if (JSON.parse(localStorage.getItem('items')) != null) {
    items = JSON.parse(localStorage.getItem('items'))
    document.getElementById('num').attributes[0].value = JSON.parse(localStorage.getItem('items')).length
}
AddtoCart()
b.forEach(element => {
    element.addEventListener("click", function () {
        var e = element.parentElement.parentElement
        var item = {
            image: e.children[0].children[0].children[0].children[0].attributes[0].value,
            name: e.children[1].children[0].innerHTML,
            price: e.children[1].children[1].innerHTML,
            count: 1
        }
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
        document.getElementById('num').attributes['data-count'].value = JSON.parse(localStorage.getItem('items')).length
    });
});
function AddtoCart() {
    var tblBody = document.getElementById('tablebody')
    var tr = ''
    if (JSON.parse(localStorage.getItem('items')) != null) {
        var array = JSON.parse(localStorage.getItem('items'))
        array.forEach(i => {
            tr += `<tr>
            <td class="p-4">
              <div class="media align-items-center">
                <img src="${i.image}" class="d-block ui-w-40 ui-bordered mr-4" alt="">
                <div class="media-body">
                  <a href="#" class="d-block text-dark">${i.name}</a>
                </div>
              </div>
            </td>
            <td class="text-right font-weight-semibold align-middle p-4">${i.price}</td>
            <td class="align-middle p-4"><div class="form-control text-center">${i.count}</div></td>
            <td class="text-center align-middle px-0"><a href="#" class="shop-tooltip close float-none text-danger" title="" data-original-title="Remove">×</a></td>
          </tr>`
        })
    }
    tblBody.innerHTML = tr
}
//console.log(JSON.parse(items)[0].name)
// items.forEach(i => {
//     console.log(i)
// });
function Add() {

}