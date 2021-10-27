// Obtener Elemento ventana
var modal = document.getElementById("myModal");

// Boton que abrira la ventana
var btn = document.getElementById("myBtn");

// Haacer que el <span> cierre la vetana
var span = document.getElementsByClassName("close")[0]; 
// Como es Class y puede haber varios ; se refiere a un arreglo

// Cuando cliquea en el boton se muestra la ventana
btn.onclick = function() {
  modal.style.display = "block";
}

// Cuando cliquea el span con la cruz(x), cerrar la ventana
span.onclick = function() {
  modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}