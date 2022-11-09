var ID_Redes;
var add = 0;

//agregar
function AgregarRedes() {

    //var calle = $("#TxtCalle").val();
    //var nroCalle = $("#TxtNumeroCalle").val();
    //var telMovil = $("#TxtTelefonMovil").val();
    //var localidad = $("#CboLocalidad").val();

    //if (calle == '') {
    //    swal('', 'El campo calle no puede estar vacío', 'info')
    //} else if (nroCalle == '') {
    //    swal('', 'El campo nro de calle no puede estar vacío', 'info')
    //} else if (telMovil == '') {
    //    swal('', 'El campo teléfono móvil no puede estar vacío', 'info')
    //} else if (localidad == '') {
    //    swal('', 'Escribe tu localidad', 'info')
    //} else {

    //}


    var Email = $("#txtEmail").val();
    var Link = $('#TxtLinkRedsocial').val();
    var ComboRedes = $('#ComboRedes').val();

    if (Link == '') {
        swal("", "Por favor complete el campo link para agregar", "info");
        return;
    }

    if ($('#ComboRedes').val() == 1) {
        swal("", "Por favor seleccione una red para agregar", "info");
        return;
    }

    var parametro = { Link, ComboRedes, Email };
    var Json = { cadena: JSON.stringify(parametro) };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/AgregarRedes",
        data: JSON.stringify(Json),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;
            if (status == 200) {

                CargarRedes()
                $('#TxtLinkRedsocial').val("");
                $('#ComboRedes').val("SELECCIONE...");

            } else {

                swal("Error", "No se pudo agregar la red", "warning");

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

//cargar
function CargarRedes() {

    var Email = $("#txtEmail").val();

    var parametro = { Email };
    var Json = { cadena: JSON.stringify(parametro) };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/CargarRedes",
        data: JSON.stringify(Json),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                $('#TxtLinkRedsocial').val("");
                $('#ComboRedes').val(1);
                $('#DivRedes').empty();

                for (var i = 0; i < json.Data.length; i++) {
                    $('#DivRedes').append(`<div class= "row" style="margin-bottom: 15px;">
                 <div class= "col-md-2">
                 <img src="${json.Data[i].Imagen}" width="50px">
                 </div>
 
                 <div class="col-md-4">
                 <span>${json.Data[i].Link}</span>
                 </div>

                 <div class="col-md-1">
                 <button type="button" href="" onclick="Eliminar(${json.Data[i].ID_Redes})" class="float" style="background: red; border: 1px solid red; border-radius: 10px; color: #fff; cursor: ponter;">
                 Eliminar
                 </button>
                 </div>
                 <hr/>`
                    );
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

//function ValidarEliminar(ID_Redes) {
//    swal({
//        title: "¿Estás seguro/a de eliminar la red?",
//        type: "question",
//        showCancelButton: true,
//        cancelButtonText: 'CANCELAR',
//        reverseButtons: true,
//        confirmButtonText: 'ACEPTAR',
//        confirmButtonColor: '#E01212',
//        closeOnConfirm: false,
//        showLoaderOnConfirm: true,
//        allowOutsideClick: false,
//        preConfirm: function () {
//            Eliminar(ID_Redes);
//        }
//    });
//}


function Eliminar(ID_Redes) {
    var par = "{\"ID_Redes\":\"" + ID_Redes + "\"}";

    var payload = { cadena: par };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/EliminarRedes",
        data: JSON.stringify(payload),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {
                CargarRedes();
                $('#TxtLinkRedsocial').val("");
                $('#ComboRedes').val(1);
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
            $(".se-pre-con").fadeOut("slow");
        }
    })
}



//POR AHORA NO SE USAN
function ModificarRedes(ID) {

    var Link = $('#TxtLinkRedsocial').val();
    var ComboRedes = $('#ComboRedes').val(1);

    if (Link == '') {
        swal("Error", "Por favor complete el campo link para agregar", "warning");
        return;
    }

    var parametro = { ID_Redes: ID, Link, ComboRedes };
    var Json = { cadena: JSON.stringify(parametro) };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/ModificarRedes",
        data: JSON.stringify(Json),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                swal("", "Red modificada correctamente", "success");

            } else {
                swal("Error", "No se pudo modificar la red", "warning");
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

function RedesBuscarPorId(ID) {

    var parametro = { ID_Redes: ID };
    var Json = { cadena: JSON.stringify(parametro) };

    $.ajax({
        type: "POST",
        "url": "FrmMiPerfil.aspx/RedesBuscarPorId",
        data: JSON.stringify(Json),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var json = $.parseJSON(data.d);
            var status = json.Status;

            if (status == 200) {

                var Link = json.Data.Link;
                var ComboRedes = json.Data.Nombre;

                $('#TxtLinkRedsocial').val(Link);
                $('#ComboRedes').val(1);
                $('#ComboRedes').val(ComboRedes);

                $('#btnGuardar').attr('onclick', 'ModificarRedes(' + ID + ')')

            } else {
                swal("Error", "No se encontró la red", "warning");
            }
        },
        error: function (xmlHttpRequest, textStatus, errorThrown) {
            console.log(xmlHttpRequest.responseText);


            console.log(textStatus);
            console.log(errorThrown);
        },
        beforeSend: function () {
            //$(".se-pre-con").fadeIn("slow");;
        },
        complete: function () {
            $(".se-pre-con").fadeOut("slow");;
        }
    })

}