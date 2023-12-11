function Plus(id) {
    var x =parseInt(document.getElementById(id).innerHTML)
    x++;
    console.log(x)
    document.getElementById(id).innerHTML = x.toString();
}
function Minus(id) {
    var x = parseInt(document.getElementById(id).innerHTML)
    if (x != 1) {
        x--;
        document.getElementById(id).innerHTML = x.toString();
    }


}