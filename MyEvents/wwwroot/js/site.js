// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Tillfällig lösning för att meddela att man har joinat event!
const successPop = document.querySelector('#join');

successPop.addEventListener("click", function () {
    alert("You have sucessfully joined this event");
})