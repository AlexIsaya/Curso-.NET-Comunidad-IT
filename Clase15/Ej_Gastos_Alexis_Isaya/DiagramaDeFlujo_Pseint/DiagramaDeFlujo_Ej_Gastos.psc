Algoritmo DiagramaDeFlujo_Ej_Gastos
	Dimension dias[7];
	dias[1] = "Lunes";
	dias[2] = "Martes";
	dias[3] = "Miercoles";
	dias[4] = "Jueves";
	dias[5] = "Viernes";
	dias[6] = "Sabado";
	dias[7] = "Domingo";
	Dimension gastos[7];
	Definir suma Como Real
	Definir promedio Como Real
	Para i<-1 Hasta 7 Con Paso 1 Hacer
		Escribir "Ingrese gasto del dia ", dias[i];
		Leer gastos[i];
		suma = suma + gastos[i];
	Fin Para
	Escribir "Total de gastos en la semana: $", suma;
	promedio = suma / 7;
	Escribir "Promedio: ", promedio;
	Para i<-1 Hasta 7 Con Paso 1 Hacer
		Si gastos[i]>2*promedio Entonces
			Escribir "Dia "+dias[i]+": sobrepasó el doble del promedio";
		SiNo
			Escribir "Dia "+dias[i]+": normal";
		Fin Si
	Fin Para
FinAlgoritmo
