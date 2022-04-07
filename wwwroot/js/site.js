// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById("icon").addEventListener("click", (e) => {
    document.querySelector(".navbar").style.display = "block";
    document.getElementById("myMenu").style.display = "flex";
    document.getElementById("icon").style.display = "none";
    document.getElementById("myMenu").style.flexDirection = "column";
    document.getElementById("myMenu").style.gap = "30%";
    document.getElementById("myMenu").style.alignItems = "center";
    document.getElementById("myMenu").style.justifyContent = "flex-end";
});

/*function myFunction() {
    var x = document.getElementById("myMenu");
    if (x.className === "menu") {
        x.className += " responsive";
    } else {
        x.className = "menu";
    }
}
*/