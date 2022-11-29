var visorImg;
var visorFormacionAcademica;
var visorCurriculum;

window.onload = function () {
    var fecha = new Date(); //Fecha actual
    var mes = fecha.getMonth() + 1; //obteniendo mes
    var dia = fecha.getDate(); //obteniendo dia
    var ano = fecha.getFullYear(); //obteniendo año
    if (dia < 10)
        dia = '0' + dia; //agrega cero si el menor de 10
    if (mes < 10)
        mes = '0' + mes //agrega cero si el menor de 10
    //document.getElementById('TxtFechaDesde').value = ano + "-" + mes + "-" + dia;
    //document.getElementById('TxtFechaHasta').value = ano + "-" + mes + "-" + dia;
}

function desactivarHasta() {
    var control = document.getElementById("ChkActivo");

    if (control.checked) {
        document.getElementById("TxtFechaHasta").disabled = true
        document.getElementById("TxtFechaHasta").value = '';
    }
    else {
        document.getElementById("TxtFechaHasta").disabled = false
    }
}

//ALERTAS
function AlertaUno() {
    $(document).on('click', '#BtnDatosDeContacto', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se modificaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });

    $(document).on('click', '#BtnDatosPersonles', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se modificaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });

    $(document).on('click', '#BtnRefLab', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se modificaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            location.href = "FrmMiPerfil.aspx";
        }, 2000);
    });
}

function Alert() {
    $(document).on('click', '#BtnAgregarGrupoFam', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se Agregaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });
}

function Alert() {
    $(document).on('click', '#BtnAgregarGrupoFam', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se Agregaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });
    $(document).on('click', '#BtnFormacionAca', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se Agregaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });
}

function AlertCursos() {
    $(document).on('click', '#BtnAgregarCurso', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se Agregaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });
}

function AlertCursos() {
    $(document).on('click', '#BtnAgregarAntSalud', function (e) {
        swal(
            'Felicitaciones!',
            'Tus datos se Agregaron con Éxito!',
            'success'
        )
        window.setTimeout(function () {
            //location.href = "FrmLogin.aspx";
        }, 6000);
    });
}

//READS URLS
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#ImgPersonal')
                .attr('src', e.target.result)
                .width(150)
                .height(150);
        };
        reader.readAsDataURL(input.files[0]);
        visorImg = reader;
        //console.log(visorImg);
    }
}

function readURL3(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#Recibos')
                .attr('src', e.target.result)
                .width(200)
                .height(200);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

function validarExt2() {
    var archivoInput = document.getElementById('SubirRecibo');
    var archivoRuta = archivoInput.value;
    var extPermitidas = /(.PDF|.pdf|.jpg|.png|.jpeg)$/i;
    if (!extPermitidas.exec(archivoRuta)) {
        alert('Asegurese de haber seleccionado un archivo permitido');
        archivoInput.value = '';
        return false;
    }
    else {
        //PRevio del PDF
        if (archivoInput.files && archivoInput.files[0]) {
            var visor = new FileReader();
            visor.onload = function (e) {
                document.getElementById('visorArchivo').innerHTML =
                    '<embed src="' + e.target.result + '" width="400" height="440" />';
            };
            visor.readAsDataURL(archivoInput.files[0]);
            visorFormacionAcademica = visor;
        }
    }
}

function validarExt3() {
    var archivoInput = document.getElementById('SubirCurriculum');
    var archivoRuta = archivoInput.value;
    var extPermitidas = /(.PDF|.pdf)$/i;
    if (!extPermitidas.exec(archivoRuta)) {
        alert('Asegurese de haber seleccionado un archivo permitido');
        archivoInput.value = '';
        return false;
    }
    else {
        //PRevio del PDF
        if (archivoInput.files && archivoInput.files[0]) {
            var visor = new FileReader();
            visor.onload = function (e) {
                document.getElementById('contentArchivo').style.display = "none";
                document.getElementById('visorArchivoC').innerHTML =
                    '<embed src="' + e.target.result + '" width="400" height="440" />';
            };
            visor.readAsDataURL(archivoInput.files[0]);
            visorCurriculum = visor;
        }
    }
}
//DATOS PERSONALES
function guardarDatPers() {
    var tipoDoc = $("#CboTipoDoc").val();
    var nroDoc = $("#TxtNumeroDoc").val();
    var sexo = $("#CboSexo").val();
    var sexoText = $("#CboSexo option:selected").text();
    var fechaNac = $("#TxtFechaNac").val();
    var estadoCivil = $("#CboEstadoCivil").val();
    var estadoCivilText = $("#CboEstadoCivil option:selected").text();
    var nacionalidad = $("#CboNacionalidad").val();
    var nivelFormacion = $("#CboNivelFormacion").val();
    var nivelFormacionText = $("#CboNivelFormacion option:selected").text();
    var cuil = $("#TxtCuil").val();
    var email = $("#txtEmail").val();

    //ver si el legajo es mayor de 18 años
    var hoy = new Date();
    var cumpleanos = new Date(fechaNac);
    var edad = hoy.getFullYear() - cumpleanos.getFullYear();
    var m = hoy.getMonth() - cumpleanos.getMonth();
    if (m < 0 || (m === 0 && hoy.getDate() < cumpleanos.getDate())) {
        edad--;
    }

    if (edad < 18) {
        swal('', 'Debes ser mayor de 18 años para poder cargar tus datos', 'info')
    } else if (nroDoc == '') {
        swal('', 'Escribe tu nro de documento', 'info')
    } else if (fechaNac == '') {
        swal('', 'Escribe tu fecha de nacimiento', 'info')
    } else if (cuil == '') {
        swal('', 'Escribe tu cuil', 'info')
    } else if (sexoText == 'SELECCIONAR') {
        swal('', 'Selecciona tu sexo', 'info')
    } else if (estadoCivilText == 'SELECCIONAR') {
        swal('', 'Selecciona tu estado civil', 'info')
    } else if (nivelFormacionText == 'SELECCIONAR') {
        swal('', 'Selecciona tu nivel de formación', 'info')
    } else {
        var archivoInput = document.getElementById('btnSubirImgEmpleado');
        var archivoRuta = archivoInput.value;
        var extPermitidas = /(.jpg|.png|.jpeg|.JPG|.PNG|.JPEG)$/i;
        if (!extPermitidas.exec(archivoRuta)) {
            if (srcFoto.innerHTML == "") {
                swal("", "Seleccione una foto para subir", "info");
            } else {
                var par = { TipoDocumento: tipoDoc, NroDocumento: nroDoc, FechaNacimiento: fechaNac, Sexo: sexo, EstadoCivil: estadoCivil, Nacionalidad: nacionalidad, NivelFormacion: nivelFormacion, Cuil: cuil, Imagen: "", Email: email };
                var payload = { cadena: JSON.stringify(par) };

                $.ajax({
                    type: "POST",
                    "url": "FrmMiPerfil.aspx/GuardarDatosPersonales",
                    data: JSON.stringify(payload),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (data) {

                        var json = $.parseJSON(data.d);
                        var status = json.Status;

                        if (status == 200) {
                            swal('',
                                'Datos personales guardados con éxito',
                                'success',
                                'CONTINUAR',
                            ).then(function () {
                                window.location.href = 'FrmMiPerfil.aspx'
                            })
                        } else if (status = 401) {
                            swal('', 'Ocurrió un error', 'warning');
                        }
                    },
                    error: function (xmlHttpRequest, textStatus, errorThrown) {
                        console.log(xmlHttpRequest.responseText);
                        console.log(textStatus);
                        console.log(errorThrown);
                    },
                    beforeSend: function () {
                        //$('#ImagenloaderM').show();
                    },
                    complete: function () {
                        $(".se-pre-con").fadeOut("slow");;
                    }
                })
            }
        } else {
            var nombreImg = visorImg.result;

            var par = { TipoDocumento: tipoDoc, NroDocumento: nroDoc, FechaNacimiento: fechaNac, Sexo: sexo, EstadoCivil: estadoCivil, Nacionalidad: nacionalidad, NivelFormacion: nivelFormacion, Cuil: cuil, Imagen: nombreImg, Email: email };
            var payload = { cadena: JSON.stringify(par) };

            $.ajax({
                type: "POST",
                "url": "FrmMiPerfil.aspx/GuardarDatosPersonales",
                data: JSON.stringify(payload),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {

                    var json = $.parseJSON(data.d);
                    var status = json.Status;

                    if (status == 200) {
                        swal('',
                            'Datos personales guardados con éxito',
                            'success',
                            'CONTINUAR',
                        ).then(function () {
                            window.location.href = 'FrmMiPerfil.aspx'
                        })
                    } else if (status = 401) {
                        swal('', 'Ocurrió un error', 'warning');
                    }
                },
                error: function (xmlHttpRequest, textStatus, errorThrown) {
                    console.log(xmlHttpRequest.responseText);
                    console.log(textStatus);
                    console.log(errorThrown);
                },
                beforeSend: function () {
                    //$('#ImagenloaderM').show();
                },
                complete: function () {
                    $(".se-pre-con").fadeOut("slow");;
                }
            })
        }
    }
}


//DATOS DE CONTACTO
function agregarDatCont() {
    var calle = $("#TxtCalle").val();
    var nroCalle = $("#TxtNumeroCalle").val();
    var piso = $("#TxtPiso").val();
    var depto = $("#TxtDepto").val();
    var telFijo = $("#TxtTelefonoFijo").val();
    var telMovil = $("#TxtTelefonMovil").val();
    var localidad = $("#CboLocalidad").val();
    var email = $("#txtEmail").val();

    if (calle == '') {
        swal('', 'El campo calle no puede estar vacío', 'info')
    } else if (nroCalle == '') {
        swal('', 'El campo nro de calle no puede estar vacío', 'info')
    } else if (telMovil == '') {
        swal('', 'El campo teléfono móvil no puede estar vacío', 'info')
    } else if (localidad == '') {
        swal('', 'Escribe tu localidad', 'info')
    } else {

        //swal("", "Seleccione una foto para subir", "info");
        var par = { Calle: calle, NroCalle: nroCalle, Piso: piso, Depto: depto, TelefonoFijo: telFijo, TelefonoMovil: telMovil, Localidad: localidad, Email: email };
        var payload = { cadena: JSON.stringify(par) };

        $.ajax({
            type: "POST",
            "url": "FrmMiPerfil.aspx/GuardarDatosContacto",
            data: JSON.stringify(payload),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var json = $.parseJSON(data.d);
                var status = json.Status;

                if (status == 200) {
                    swal('',
                        'Datos del contacto guardados con éxito',
                        'success',
                        'CONTINUAR',
                    ).then(function () {
                        window.location.href = 'FrmMiPerfil.aspx'
                    })
                } else if (status = 401) {
                    swal('', 'Ocurrió un error', 'warning');
                }
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                console.log(xmlHttpRequest.responseText);
                console.log(textStatus);
                console.log(errorThrown);
            },
            beforeSend: function () {
                //$('#ImagenloaderM').show();
            },
            complete: function () {
                $(".se-pre-con").fadeOut("slow");;
            }
        })
    }
}


//REFERENCIAS LABORALES
function agregarRefLab() {
    var fechaDesde = $("#TxtFechaDesde").val();
    var activo = $('#ChkActivo').prop('checked')
    var fechaHasta = $("#TxtFechaHasta").val();
    var empresa = $("#TxtEmpresa").val();
    var puesto = $("#TxtPuesto").val();
    var area = $("#Combo").val();
    var descripcionTareas = $("#TxtDescrip").val();
    var datosReferentes = $("#TxtDatosRef").val();
    var refCoov = $("#TxtRefCoov").val();
    var seccCoov = $("#cboSecciones").val();
    var email = $("#txtEmail").val();

    if (fechaDesde == '') {
        swal('', 'El campo fecha desde no puede estar vacío', 'info')
    } else if (empresa == '') {
        swal('', 'El campo empresa no puede estar vacío', 'info')
    } else if (puesto == '') {
        swal('', 'El campo puesto no puede estar vacío', 'info')
    } else if (area == 'SELECCIONAR') {
        swal('', 'Debes seleccionar un área', 'info')
    } else if (descripcionTareas == '') {
        swal('', 'El campo descripción de las tareas no puede estar vacío', 'info')
    } else if (datosReferentes == '') {
        swal('', 'El campo datos referentes no puede estar vacío', 'info')
    } else if (seccCoov == 'SELECCIONAR') {
        swal('', 'Debes seleccionar una sección', 'info')
    } else {
        var par = { FechaDesde: fechaDesde, Activo: activo, FechaHasta: fechaHasta, Empresa: empresa, Puesto: puesto, Area: area, Descripcion: descripcionTareas, DatosReferentes: datosReferentes, RefCoov: refCoov, SeccionCoov: seccCoov, Email: email };
        var payload = { cadena: JSON.stringify(par) };

        $.ajax({
            type: "POST",
            "url": "FrmMiPerfil.aspx/GuardarReferenciasLaborales",
            data: JSON.stringify(payload),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var json = $.parseJSON(data.d);
                var status = json.Status;

                if (status == 200) {
                    swal('',
                        'Referencias laborales guardadas con éxito',
                        'success',
                        'CONTINUAR',
                    ).then(function () {
                        window.location.href = 'FrmMiPerfil.aspx'
                        //ActualizarCampos()
                    })
                } else if (status = 401) {
                    swal('', 'Ocurrió un error', 'warning');
                }
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                console.log(xmlHttpRequest.responseText);
                console.log(textStatus);
                console.log(errorThrown);
            },
            beforeSend: function () {
                //$('#ImagenloaderM').show();
            },
            complete: function () {
                $(".se-pre-con").fadeOut("slow");;
            }
        })
    }
}


//ANTECEDENTES LABORALES
function agregarFormAcademica() {
    var fechaDesde = $("#TxtDesdeFA").val();
    var fechaHasta = $("#TxtHastaFA").val();
    var nivelAcademico = $("#ComboFA").val();
    var especialidad = $("#ComboEspecilidad").val();
    var titulo = $("#TxtTitulo").val();
    var email = $("#txtEmail").val();

    var txtInstitucion = $("#TxtInstitucion").val();
    var cboInstitucion = $("#CboInstitucion").val();
    var institucion = "";

    if (txtInstitucion == "" && cboInstitucion != "SELECCIONAR") {
        institucion = cboInstitucion;
    } else if (txtInstitucion != "" && cboInstitucion == "SELECCIONAR") {
        institucion = txtInstitucion;
    } else {
        swal('', 'Debes seleccionar una institución', 'info')
        return;
    }

    if (fechaDesde == '') {
        swal('', 'Debes seleccionar una fecha desde', 'info');
    } else if (fechaHasta == '') {
        swal('', 'Debes seleccionar una fecha hasta', 'info');
    } else if (nivelAcademico == '') {
        swal('', 'Debes seleccionar tu nivel académico', 'info');
    } else if (especialidad == '') {
        swal('', 'Debes seleccionar tu especialidad', 'info');
    } else if (titulo == '') {
        swal('', 'Escribe tu título', 'info');
    } else if (institucion == '') {
        swal('', 'Debes seleccionar una institución', 'info');
    } else {
        var archivoInput = document.getElementById('SubirRecibo');
        var archivoRuta = archivoInput.value;
        var extPermitidas = /(.jpg|.png|.jpeg|.JPG|.PNG|.JPEG|.pdf|.PDF)$/i;
        if (!extPermitidas.exec(archivoRuta)) {
            //if (srcFoto.innerHTML == "") {
                swal("", "Seleccione un documento para subir", "info");
                return;
            //}
        } else {
            var pdfFA = visorFormacionAcademica.result;

            var par = { FechaDesde: fechaDesde, FechaHasta: fechaHasta, NivelAcademico: nivelAcademico, Especialidad: especialidad, Titulo: titulo, Institucion: institucion, Archivo: pdfFA, Email: email };
            var payload = { cadena: JSON.stringify(par) };

            $.ajax({
                type: "POST",
                "url": "FrmMiPerfil.aspx/GuardarFormacionAcademica",
                data: JSON.stringify(payload),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {

                    var json = $.parseJSON(data.d);
                    var status = json.Status;

                    if (status == 200) {
                        swal('',
                            'Formación académica guardada con éxito',
                            'success',
                            'CONTINUAR',
                        ).then(function () {
                            window.location.href = 'FrmMiPerfil.aspx'
                        })
                    } else if (status = 401) {
                        swal('', 'Ocurrió un error', 'warning');
                    }
                },
                error: function (xmlHttpRequest, textStatus, errorThrown) {
                    console.log(xmlHttpRequest.responseText);
                    console.log(textStatus);
                    console.log(errorThrown);
                },
                beforeSend: function () {
                    //$('#ImagenloaderM').show();
                },
                complete: function () {
                    $(".se-pre-con").fadeOut("slow");;
                }
            })
        }
    }
}


//GRUPO FAMILIAR
function agregarGrupoFam() {
    var apellido = $("#TxtApellidoGrupFam").val();
    var nombre = $("#TxtNombreGrupFam").val();
    var parentezco = $("#ComboPrentezco").val();
    var fechaNac = $("#TxtFechaNacGF").val();
    var ocupacion = $("#TxtOcupacion").val();
    var email = $("#txtEmail").val();

    if (apellido == '') {
        swal('', 'El campo apellido no puede estar vacío', 'info')
    } else if (nombre == '') {
        swal('', 'El campo nombre no puede estar vacío', 'info')
    } else if (fechaNac == '') {
        swal('', 'El campo fecha nacimiento no puede estar vacío', 'info')
    } else if (ocupacion == "") {
        swal('', 'El campo ocupacion no puede estar vacío', 'info')
    } else {

        var par = { Apellido: apellido, Nombre: nombre, ID_Parentezco: parentezco, FechaNac: fechaNac, Ocupacion: ocupacion, Email: email };
        var payload = { cadena: JSON.stringify(par) };

        $.ajax({
            type: "POST",
            "url": "FrmMiPerfil.aspx/GuardarGrupoFamiliar",
            data: JSON.stringify(payload),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var json = $.parseJSON(data.d);
                var status = json.Status;

                if (status == 200) {
                    swal('',
                        'Familiar guardado con éxito',
                        'success',
                        'CONTINUAR',
                    ).then(function () {
                        //window.location.href = 'FrmMiPerfil.aspx'
                        cargarGrupoFam();
                    })
                } else if (status = 401) {
                    swal('', 'Ocurrió un error', 'warning');
                }
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                console.log(xmlHttpRequest.responseText);
                console.log(textStatus);
                console.log(errorThrown);
            },
            beforeSend: function () {
                //$('#ImagenloaderM').show();
            },
            complete: function () {
                $(".se-pre-con").fadeOut("slow");;
            }
        })
    }
}

function cargarGrupoFam() {
    var Email = $("#txtEmail").val();

    var parametro = { Email };
    var Json = { cadena: JSON.stringify(parametro) };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/CargarGrupoFam",
        data: JSON.stringify(Json),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {
                $('#DivGF').empty();
                if (json.Data.length > 0) {
                    $('#TituloGF').html("MI GRUPO FAMILIAR");
                    for (var i = 0; i < json.Data.length; i++) {
                        $('#DivGF').append(`<div class= "row" style="margin-bottom: 15px; width: 100%;">
                            <div class= "col-md-3">
                                <span>${json.Data[i].Nombre}</span>
                            </div>
                            <div class="col-md-2">
                                <span>${json.Data[i].Parentezco}</span>
                            </div>
                            <div class="col-md-2">
                                <span>${json.Data[i].FechaNac}</span>
                            </div>
                            <div class="col-md-3">
                                <span>${json.Data[i].Ocupacion}</span>
                            </div>
                            <div class="col-md-2">
                                <button type="button" onclick="ValidarEliminarFamiliar(${json.Data[i].ID_GrupoFamiliar})" class="btn-danger" style="border-radius: 5px; color: #fff; border: 1px solid #dc3545;">
                                Eliminar
                                </button>
                            </div>
                            <hr style="width: 100%;">`
                        );
                    }
                }

            }
        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);

        },
        beforeSend: function () {

        },
        complete: function () {

        }
    })
}

function ValidarEliminarFamiliar(ID_GrupoFamiliar) {
    swal({
        title: "¿Estás seguro/a de eliminar el familiar?",
        type: "question",
        showCancelButton: true,
        cancelButtonText: 'CANCELAR',
        reverseButtons: true,
        confirmButtonText: 'ACEPTAR',
        confirmButtonColor: '#E01212',
        closeOnConfirm: false,
        showLoaderOnConfirm: true,
        allowOutsideClick: false,
        preConfirm: function () {
            EliminarFamiliar(ID_GrupoFamiliar);
        }
    });
}

function EliminarFamiliar(ID_GrupoFamiliar) {
    var par = "{\"ID_GrupoFamiliar\":\"" + ID_GrupoFamiliar + "\"}";

    var payload = { cadena: par };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/EliminarGrupoFam",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {
                swal('',
                    'Familiar eliminado con éxito',
                    'success',
                    'CONTINUAR',
                ).then(function () {
                    cargarGrupoFam();
                })
            } else if (status = 401) {
                swal('', 'Ocurrió un error', 'warning');
            }
        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);

        },
        beforeSend: function () {
        },
        complete: function () {
            $(".se-pre-con").fadeOut("slow");
        }
    })
}


//CURSOS
function agregarCurso() {
    var desde = $("#TxtFechaDesdeCurso").val();
    var hasta = $("#TxtFechaHastaCurso").val();
    var nombreCurso = $("#TxtNombredelCurso").val();
    var areas = $("#ComboCursos").val();
    var horas = $("#TxtHoras").val();
    var institución = $("#TxtInstitucionCursos").val();
    var comentarios = $("#TxtComentarios").val();
    var email = $("#txtEmail").val();

    if (desde == '') {
        swal('', 'El campo fecha desde no puede estar vacío', 'info')
    } else if (hasta == '') {
        swal('', 'El campo fecha hasta no puede estar vacío', 'info')
    } else if (nombreCurso == '') {
        swal('', 'El campo nombre del curso no puede estar vacío', 'info')
    } else if (areas == "SELECCIONAR") {
        swal('', 'Debes seleccionar una área', 'info')
    } else if (horas == "") {
        swal('', 'El campo horas no puede estar vacío', 'info')
    } else if (institución == "") {
        swal('', 'El campo institución no puede estar vacío', 'info')
    } else if (comentarios == "") {
        swal('', 'El campo ocupacion no puede estar vacío', 'info')
    } else {

        var par = { Desde: desde, Hasta: hasta, NombreCurso: nombreCurso, Areas: areas, Horas: horas, Institución: institución, Comentarios: comentarios, Email: email };
        var payload = { cadena: JSON.stringify(par) };

        $.ajax({
            type: "POST",
            "url": "FrmMiPerfil.aspx/GuardarCurso",
            data: JSON.stringify(payload),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var json = $.parseJSON(data.d);
                var status = json.Status;

                if (status == 200) {
                    swal('',
                        'Curso guardado con éxito',
                        'success',
                        'CONTINUAR',
                    ).then(function () {
                        window.location.href = 'FrmMiPerfil.aspx'
                    })
                } else if (status = 401) {
                    swal('', 'Ocurrió un error', 'warning');
                }
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                console.log(xmlHttpRequest.responseText);
                console.log(textStatus);
                console.log(errorThrown);
            },
            beforeSend: function () {
                //$('#ImagenloaderM').show();
            },
            complete: function () {
                $(".se-pre-con").fadeOut("slow");;
            }
        })
    }
}


//ANTECEDENTES DE SALUD
function agregarAntecedentesDeSalud() {
    var altura = $("#TxtAltura").val();
    var peso = $("#TxtPeso").val();
    var tratSi = $("#RbtTratSi").is(':checked');
    var tratNo = $("#RbtTratNo").is(':checked');
    var tratamiento = $("#TxtTratamiento").val();
    var cirSi = $("#RbtCirSi").is(':checked');
    var cirNo = $("#RbtCirNo").is(':checked');
    var cirugia = $("#TxtCirugia").val();
    var email = $("#txtEmail").val();

    var enfermedad;
    if (tratSi == true) {
        enfermedad = "1"
    } else {
        enfermedad = "0"
    }
    var cir;
    if (cirSi == true) {
        cir = "1"
    } else {
        cir = "0"
    }

    if (altura == '') {
        swal('', 'El campo altura no puede estar vacío', 'info')
    } else if (peso == '') {
        swal('', 'El campo peso no puede estar vacío', 'info')
    } else if (tratSi == true && tratamiento == "") {
        swal('', 'El campo tratamiento no puede estar vacío', 'info')
    } else if (cirSi == true && cirugia == "") {
        swal('', 'El campo cirujia no puede estar vacío', 'info')
    } else {

        var par = { Altura: altura, Peso: peso, Enfermedad: enfermedad, Tratamiento: tratamiento, Cir: cir, Cirugia: cirugia, Email: email };
        var payload = { cadena: JSON.stringify(par) };

        $.ajax({
            type: "POST",
            "url": "FrmMiPerfil.aspx/GuardarAntecedente",
            data: JSON.stringify(payload),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var json = $.parseJSON(data.d);
                var status = json.Status;

                if (status == 200) {
                    swal('',
                        'Familiar guardado con éxito',
                        'success',
                        'CONTINUAR',
                    ).then(function () {
                        window.location.href = 'FrmMiPerfil.aspx'
                    })
                } else if (status = 401) {
                    swal('', 'Ocurrió un error', 'warning');
                }
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                console.log(xmlHttpRequest.responseText);
                console.log(textStatus);
                console.log(errorThrown);
            },
            beforeSend: function () {
                //$('#ImagenloaderM').show();
            },
            complete: function () {
                $(".se-pre-con").fadeOut("slow");;
            }
        })
    }
}


//CURRICULUM
function agregarCurriculum() {
    var email = $("#txtEmail").val();
    var archivoInput = document.getElementById('SubirCurriculum');
    var archivoRuta = archivoInput.value;
    var extPermitidas = /(.PDF|.pdf)$/i;
    if (!extPermitidas.exec(archivoRuta)) {
        if (srcCurriculum.innerHTML == "") {
            swal("", "Seleccione un documento para subir", "info");
            return;
        }
    } else {
        var pdfCurriculum = visorCurriculum.result;

        var par = { Archivo: pdfCurriculum, Email: email };
        var payload = { cadena: JSON.stringify(par) };

        $.ajax({
            type: "POST",
            "url": "FrmMiPerfil.aspx/GuardarCurriculum",
            data: JSON.stringify(payload),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {

                var json = $.parseJSON(data.d);
                var status = json.Status;

                if (status == 200) {
                    swal('',
                        'Curriculum guardado con éxito',
                        'success',
                        'CONTINUAR',
                    ).then(function () {
                        window.location.href = 'FrmMiPerfil.aspx'
                    })
                } else if (status = 401) {
                    swal('', 'Ocurrió un error', 'warning');
                }
            },
            error: function (xmlHttpRequest, textStatus, errorThrown) {
                console.log(xmlHttpRequest.responseText);
                console.log(textStatus);
                console.log(errorThrown);
            },
            beforeSend: function () {
            },
            complete: function () {
                $(".se-pre-con").fadeOut("slow");;
            }
        })
    }

}


//BUSCAR USUARIO Y ENVIAR EMAIL
function BuscarUserId() {
    var Email = $('#txtEmail').val();
    var Porcentaje = $('#txtPorcentaje').val();
    var par = { Email: Email, Porcentaje: Porcentaje };
    var payload = { cadena: JSON.stringify(par) };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/BuscarUserId",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(payload),
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {
                var userId = json.UserId;
                var resultado = json.Resultado;
                if (resultado == "100") {
                    localStorage.setItem("UsuarioId", userId);
                    CheckEmail100()
                }

            } else {
                (status == 400)
            }
        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);
            console.log(textStatus);
            console.log(errorThrown);
        },
        beforeSend: function () {
        },
        complete: function () {
        }
    })
}

function CheckEmail100() {
    //COMENTO SI QUIERO ENVIAR UN EMAIL
    if (localStorage.getItem('Email100')) {
        return;
    }

    var userId = localStorage.getItem("UsuarioId");
    localStorage.setItem('Email100', true);

    swal({
        backdrop: true,
        allowOutsideClick: false,
        title: 'Felicidades! Has completado el 100% de tu CV',
        text: 'Recordá mantener actualizados tus datos, ingresando a nuestra plataforma periodicamente.',
        type: 'success',
        confirmButtonText: 'VER MI PERFIL',
        showCancelButton: true,
        cancelButtonText: "SEGUIR EN PÁGINA ACTUAL"

    }).then(function () {
        window.location.href = 'VerMiperfil.aspx?Token=' + userId;
    })

    //DESCOMENTO SI QUIERO ENVIAR UN EMAIL
    //if (localStorage.getItem('Email100')) {
    //    return;
    //}

    //var par = { EmailTipo: 2 };
    //var payload = { cadena: JSON.stringify(par) }

    //$.ajax({
    //    type: "POST",
    //    "url": "FrmMiPerfil.aspx/SendEmail",
    //    data: JSON.stringify(payload),
    //    contentType: "application/json; charset=utf-8",
    //    dataType: "json",
    //    success: function (data) {

    //        var json = $.parseJSON(data.d);
    //        var status = json.Status;

    //        var userId = localStorage.getItem("UsuarioId");

    //        if (status == 200) {
    //            localStorage.setItem('Email100', true);
    //            swal({
    //                backdrop: true,
    //                allowOutsideClick: false,
    //                title: 'Felicidades! Has completado el 100% de tu CV',
    //                text: 'Recordá mantener actualizados tus datos, ingresando a nuestra plataforma periodicamente.',
    //                type: 'success',
    //                confirmButtonText: 'CONTINUAR',
    //                showCancelButton: true,
    //                cancelButtonText: "VER MI PERFIL"
    //            },
    //                function (isConfirm) {
    //                    if (isConfirm) {
    //                        swal.close()
    //                    } else {
    //                        //swal("Cancelled", "Is safe :)", "success");
    //                        window.location.href = 'VerMiperfil.aspx?Token=' + userId;
    //                    }
    //                });
    //        } else if (status == 401) {
    //            swal("Error", "No se pudo encvier el email", "warning");
    //            console.log('error');
    //        }
    //    },
    //    error: function (xmlHttpRequest, textStatus, errorThrown) {
    //        console.log(xmlHttpRequest.responseText);
    //        console.log(textStatus);
    //        console.log(errorThrown);
    //    },
    //    beforeSend: function () {
    //    },
    //    complete: function () {
    //    }
    //})
}


function ActualizarCampos() {
    $("#TxtFechaDesde").val() = '';
    $('#ChkActivo').prop('checked') = false
    $("#TxtFechaHasta").val() = '';
    $("#TxtEmpresa").val() = '';
    $("#TxtPuesto").val() = '';
    $("#Combo").val() = 'SELECCIONAR';
    $("#TxtDescrip").val() = '';
    $("#TxtDatosRef").val() = '';
    $("#TxtRefCoov").val() = '';
    $("#cboSecciones").val() = 'SELECCIONAR';
}