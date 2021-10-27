$(document).ready(() =>{
    const ArrayPacientes = [];
    const ArrayRiesgo = [];

    $("#registrar").click(function(){
        function Paciente(dni,prov,fecNac){
            this.dni = dni;
            this.prov = prov;
            this.fecNac = fecNac;
        }
        const dni = $("#dni").val();
        const prov = $("#prov").val();
        const fecNac = $("#fecNac").val();

        const anioNacimiento = new Date(fecNac).getFullYear();
        const anioActual = new Date().getFullYear();
        const edadPaciente = anioActual - anioNacimiento;
        
        const paciente = new Paciente(dni,prov,fecNac);
        (ArrayPacientes.length <= 20) && agregarPaciente(paciente);
        (edadPaciente >= 60) && ArrayRiesgo.push(paciente);
    });

    const agregarPaciente = (paciente) =>{
        ArrayPacientes.push(paciente);
        const {dni,prov,fecNac} = paciente;
        $("#tabla1").append(`<tr><td>${dni}</td><td>${prov}</td><td>${fecNac}</td></tr>`);
    }

    $("#procesar").click(function(){
        alert("A continuación se muestra una tabla con los pacientes de riesgo (mayores de 60) ingresados");
        document.getElementById("tabla2").style.display = "table";
        document.getElementById("registrar").disabled = true;
        document.getElementById("procesar").disabled = true;
        document.getElementById("reiniciar").style.display = "block";
        ($("#cantidad60").append(`<h3><mark>Cantidad de pacientes en grupo de riesgo: ${ArrayRiesgo.length}</mark></h3>`));

        $.each(ArrayPacientes,(i,paciente) =>{
            const {dni,prov,fecNac} = paciente;
            const anioNacimiento = new Date(fecNac).getFullYear();
            const anioActual = new Date().getFullYear();
            const edadPaciente = anioActual - anioNacimiento;
            (edadPaciente >= 60) && ($("#tabla2").append(`<tr><td>${dni}</td><td>${prov}</td><td>${edadPaciente}</td></tr>`));
        });
    });

})