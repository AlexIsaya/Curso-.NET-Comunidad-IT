$(document).ready(
	function() { 
		$("#btnCargar").click(
			function(){btnCargarAlumnos_click();
		});
	}
);

function btnCargarAlumnos_click()
{
//AGREGAR OBJETOS JSON Con propiedades DNI Y NOMBRE
var arrAlumnos = [ 
	{"DNI":280255415,"Nombre":"Agustin Soria"},
	{"DNI":40700587,"Nombre":"Alex Isaya"},
	{"DNI":280255415,"Nombre":"Joaquin Bautista"},
	{"DNI":280255415,"Nombre":"Seba Luján"},
	{"DNI":280255415,"Nombre":"Rocio Mercedes"},
	{"DNI":280255415,"Nombre":"Alejandro Villa"},
	{"DNI":280255415,"Nombre":"Ezequiel Barrios"},
	{"DNI":280255415,"Nombre":"Pablo Romero"},
	{"DNI":280255415,"Nombre":"Cristian B.G"},
	{"DNI":280255415,"Nombre":"Julieta Colque"},
	{"DNI":280255415,"Nombre":"Gustavo Cardozo"},
	{"DNI":280255415,"Nombre":"Andru Castellanos Katsini"},
	{"DNI":280255415,"Nombre":"Alfredo Cruz"}
 ];

/*La instriccion $.each indica que para el arreglo 
se debe iterar y por cada elemento de devuelve itemPersona
*/
$.each(arrAlumnos,function(key,  itemPersona)
	{
		$('#cbAlumnos').append('<option value="' + itemPersona.DNI + '">' + itemPersona.Nombre + '</option>');
	});
	
	setTimeout(
		function(){ 
			/*COLOCAR UN INSTRCCION Jquyer que 
				cambie el estilo del puntero del mouse normal*/
		}
		, 4000);

}


