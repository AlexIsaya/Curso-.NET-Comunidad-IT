$(document).ready(
    function()
    {
        alert('document cargado');
        $("#btnCambiarcolor").click(
            function(){btnCambiarcolor_click();
        });
    }
);

function btnCambiarcolor_click(){
    $(".divUno").css("background-color", "yellow");
}