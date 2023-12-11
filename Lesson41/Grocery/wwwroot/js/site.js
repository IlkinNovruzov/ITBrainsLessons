// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var x = 0;
function Add(id) {
    x++;
    document.getElementById("h").innerHTML = "hello";
    localStorage.setItem(x.toString(), id)
}