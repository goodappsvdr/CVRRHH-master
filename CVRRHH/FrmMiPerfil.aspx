<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmMiPerfil.aspx.vb" Inherits="CVRRHH.FrmMiPerfil" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="es">
<head id="Head1" runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">

    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <link rel="shortcut icon" href="http://www.coovilros.com/Imagenes/favicon16.ico" />
    <title runat="server" id="TituloPaginaWeb">CV Coovilros</title>
    <!-- Bootstrap -->


    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <link href="https://fonts.googleapis.com/css?family=Staatliches" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Exo+2" rel="stylesheet">

    <!--grafico-->
    <link href="css/grafico.css" rel="stylesheet" />

    <!-- alerts -->
    <script type="text/javascript" src="Scripts/Alertas/sweetalert2@9.js"></script>
    <script type="text/javascript" src="Scripts/Alertas/Alertas.js"></script>
    <link href="Scripts/Alertas/sweetalert2.min.css" rel="stylesheet" />
    <script type="text/javascript" src="Scripts/Alertas/sweetalert2.min.js"></script>

    <link href="https://fonts.googleapis.com/icon?family=Material+Icons"
        rel="stylesheet">
</head>

<style>
    body {
        overflow: hidden;
        overflow-y: scroll;
        overflow: -moz-scrollbars-vertica
    }

    ::placeholder { /* Chrome, Firefox, Opera, Safari 10.1+ */
        color: #ffffff;
        opacity: 1; /* Firefox */
    }

    :-ms-input-placeholder { /* Internet Explorer 10-11 */
        color: #ffffff;
    }

    ::-ms-input-placeholder { /* Microsoft Edge */
        color: #ffffff;
    }


    .modal-dialog {
        width: 100%;
        height: 620px;
        margin-left: 0px;
        padding: 20px;
    }

    .modal-content {
        height: 670px;
        border-radius: 0;
    }

    @media (max-width: 600px) {
        #borrarimagenes {
            display: none;
        }

        #imagenresp2 {
            display: block;
        }

        #imagenresp {
            display: block;
        }
    }

    @media (min-width: 600px) {

        #imagenresp2 {
            display: none;
        }

        #imagenresp {
            display: none;
        }
    }

    /*inscripcion*/
    @media only screen and (min-width: 525px) {
        #inscripcion {
            display: none;
        }
    }

    /*inscripcion*/
    @media only screen and (max-width: 825px) {
        #webcon {
            display: none;
        }
    }

    @media only screen and (max-width: 600px) {
        #divsup {
            background-size: cover;
        }
    }

    .modal-dialog {
        width: auto;
        height: auto;
        margin-left: auto;
        padding: 20px;
    }

    .modal-content {
        height: auto;
        border-radius: 10px;
    }

    .contentCabecera {
        margin-bottom: 150px;
    }

    @media only screen and (max-width: 767px) {
        .contentGrafico {
            margin-bottom: 140px;
        }

        .contentCabecera {
            margin-bottom: 0;
        }
    }
</style>

<body>

    <!--Start of Tawk.to Script-->
    <script type="text/javascript">
        var Tawk_API = Tawk_API || {}, Tawk_LoadStart = new Date();
        (function () {
            var s1 = document.createElement("script"), s0 = document.getElementsByTagName("script")[0];
            s1.async = true;
            s1.src = 'https://embed.tawk.to/5e31ab8c8e78b86ed8abac7c/default';
            s1.charset = 'UTF-8';
            s1.setAttribute('crossorigin', '*');
            s0.parentNode.insertBefore(s1, s0);
        })();
    </script>
    <!--End of Tawk.to Script-->

    <form runat="server" id="form1">
        <nav class="navbar navbar-default navbar-fixed-top" style="height: 120px; background-color: #187C45;">
            <img src="https://www.coovilros.com/RRHHAdmin/Imagenes/Isologotipo_Coovilros_horizontal_blanco_total.png" runat="server" id="imagenresp" style="width: 220px; height: auto; max-height: 60px; margin-top: 10px;" alt="">
            <p id="imagenresp2" style="font-family: 'Bitter',serif; margin-top: -30px">
                <a href="" runat="server" id="iraperfilmovil"><i class="material-icons" style="margin-top: 30px; color: #fff; cursor: pointer; font-size: 40px; margin-left: 35px" data-toggle="tooltip" title="Ver Mi Perfil">assignment
                </i></a>
            </p>
            <div class="container">
                <div class="row" id="borrarimagenes">
                    <div class="col-md-4">
                        <img src="https://www.coovilros.com/RRHHAdmin/Imagenes/Isologotipo_Coovilros_horizontal_blanco_total.png" runat="server" id="ImagenLogo" style="width: 220px; height: auto; max-height: 60px; margin-top: 10px" alt="">
                    </div>
                    <div class="col-md-7">
                        <p id="webcon" style="float: right; margin-left: 800px; font-family: 'Bitter',serif; margin-top: -30px">
                            <a onserverclick="CerrarSesion" runat="server"><i class="material-icons" style="margin-top: 30px; color: #fff; cursor: pointer; font-size: 40px; margin-left: 35px" data-toggle="tooltip" title="Cerrar Sesión">power_settings_new
                            </i></a>
                        </p>
                    </div>
                    <div class="col-md-1">
                        <p id="P1" style="float: right; margin-left: 800px; font-family: 'Bitter',serif; margin-top: -30px">
                            <a href="" runat="server" id="irAPerfil">
                                <i class="material-icons" style="margin-top: 30px; color: #fff; cursor: pointer; font-size: 40px; margin-left: 35px" data-toggle="tooltip" title="Ver Mi Perfil">assignment
                                </i></a>
                        </p>
                    </div>
                </div>
            </div>
            <br />
        </nav>

        <script type="text/javascript">
            $(document).ready(function () {
                $('[data-toggle="tooltip"]').tooltip();
            });
        </script>

        <br />
        <br />

        <div style="width: 100%; height: auto; background: #fff">

            <div style="display: none;" class="col-md-4">
                <asp:TextBox ID="txtEmail" type="text" runat="server" ForeColor="#495057"
                    class="form-control" Height="40px" Width="100%" Style=""></asp:TextBox>
                <asp:TextBox ID="txtPorcentaje" type="text" runat="server" ForeColor="#495057"
                    class="form-control" Height="40px" Width="100%" Style=""></asp:TextBox>
            </div>


            <div class="container" id="up">
                <%--<center>
                    <h4 id="UserPerfil" runat="server"></h4>
                    <p class="card-text" style="padding: 10px; margin: 30px; font-size: 20px">
                        Recuerda completar los datos Obligatorios, para que podamos encontrarte más rapido. 
                        <br />
                        Y mantene actualizado tu perfil.
                    </p>

                </center>--%>

                <div class="row contentCabecera">

                    <div class="col-md-3 col-sm-12 contentGrafico">
                        <h8 id="UserPerfil" runat="server"></h8>
                        <div id="porcentajeClass" runat="server" class="col-md-4 c100 p40">
                            <span id="porcentaje" runat="server"></span>
                            <div class="slice">
                                <div class="bar"></div>
                                <div class="fill"></div>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6 col-sm-12">
                        <div style="font-size: 13px; line-height: 1.4286 !important">
                        </div>
                    </div>

                    <div class="col-md-3 col-sm-12">
                        <div>
                            <a href="#" onclick="buscarDatosFaltantes()">
                                <input type="button" id="btnModal" runat="server" value="VER DATOS FALTANTES" style="background: #187C45; color: #fff; cursor: pointer; border-radius: 4px; border: none; height: 40px" /></a>
                        </div>
                    </div>

                </div>

                <div class="modal fade" id="modalDatosFaltantes" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered modal-lg" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalCenterTitle">DATOS FALTANTES</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span onclick="cerrarModal()" aria-hidden="true">×</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="row" id="contentModal" style="display: flex; flex-wrap: wrap; flex-direction: column; padding: 10px;">
                                    
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row">

                    <div class="row" id="bienvenida" runat="server">
                        <div class="col-md-12">
                            <div class="card" style="width: 100%;">
                                <div class="card-body">
                                    <center>
                                        <img src="https://crear.net.ar/CLIENTES/EGFOTOGRAFIA/Egfotografia/social4_07-01%20(1).jpg" class="card-img-top" alt="..." style="width: 100%; max-width: 200px; height: auto"></center>
                                    <%--<center><h1>¿Qué es CONSTRUYA YA?</h1></center>--%>
                                    <p class="card-text" style="padding: 10px; margin: 30px; font-size: 20px">
                                        Gracias por registrarte en <b>CV Coovilros</b> Para mejorar tus chances de participar en las búsquedas laborales de la empresa, es necesario que completes tu perfil. Mientras más sepamos de vos, más posibilidades tendrás de ser seleccionado.
                                    </p>


                                </div>
                                <%-- <center><img src="https://crear.net.ar/CLIENTES/EGFOTOGRAFIA/Egfotografia/social4_07-01%20(1).jpg" class="card-img-top" alt="..." style="width:100%;max-width:600px;height:auto"></center>--%>
                            </div>
                        </div>
                    </div>

                    <!------1 ------>

                    <br />



                </div>

                <div class="container">
                    <div class="row">

                        <!--DATOS PERSONALES-->
                        <div class="col-md-4">
                            <a href="#primero" onclick="MostrarSig();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src=" https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/illustration-quality-check-icon-blue-background_53876-8393.jpg" alt="Card image cap">

                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">DATOS PERSONALES</h5>
                                            <p style="color: Red"><b>* CAMPO OBLIGATORIO</b></p>
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--DATOS DEL CONTACTO-->
                        <div class="col-md-4">
                            <a href="#DatosContactoHide" onclick="MostrarDatosContacto();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/auth.png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">DATOS DE CONTACTO</h5>
                                            <p style="color: Red"><b>* CAMPO OBLIGATORIO</b></p>
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--ANTECEDENTES LABORALES-->
                        <div class="col-md-4">
                            <a href="#DatosRefLab" onclick="MostrarRefLab();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/storage.png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">ANTECEDENTES LABORALES</h5>
                                            <p style="color: Red"><b>* CAMPO OBLIGATORIO</b></p>
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--FORMACION ACADEMICA-->
                        <div class="col-md-4">
                            <a href="#DatosForma" onclick="MostrarFromAca();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/SIEMPREBONITA/Siemprebonita/analytics.png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">FORMACION ACADEMICA</h5>
                                            <p style="color: Red"><b>* CAMPO OBLIGATORIO</b></p>
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--GRUPO FAMILIAR-->
                        <div class="col-md-4">
                            <a href="#DatosGrupoFam" onclick="MostrarGrupoFam();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/unnamed%20(2).png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">GRUPO FAMILIAR</h5>
                                            <br />
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--CURSOS-->
                        <div class="col-md-4">
                            <a href="#DatosCursos" onclick="MostrarCursos();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/graf%20(2).png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">CURSOS Y SEMINARIOS</h5>
                                            <br />
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--ANTECEDENTES DE SALUD-->
                        <div class="col-md-4">
                            <a href="#DatosAntSal" onclick="MostrarAntSal();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/experiments.png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">ANTECEDENTES DE SALUD</h5>
                                            <br />
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--CURRICULUM-->
                        <div class="col-md-4">
                            <a href="#DatosCurriculum" onclick="MostrarCurriculum();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/MAGICFLOORS/MagicFloors/experiments.png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">CURRICULUM</h5>
                                            <br />
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                        <!--OTROS CONOCIMIENTOS-->
                        <div class="col-md-4" style="display: none">
                            <a href="#DatosOtrosCon" onclick="MostrarOtrosCon();">
                                <div class="card" style="width: 100%; margin: 10px auto">
                                    <img class="card-img-top" src="https://crear.net.ar/CLIENTES/SIEMPREBONITA/Siemprebonita/mlkit@2x.png" alt="Card image cap">
                                    <div class="card-body">
                                        <center>
                                            <h5 class="card-title">OTROS CONOCIMIENTOS</h5>
                                            <br />
                                            <i class="material-icons" style="margin-top: 30px; color: #000; cursor: pointer; font-size: 40px;" data-toggle="tooltip" title="Modificar mis datos">create
                                            </i>
                                        </center>
                                    </div>
                                </div>
                            </a>
                        </div>

                    </div>

                    <!--DATOS PERSONALES-->
                    <div class="col-md-12" id="primero" style="display: none" name="primero">
                        <div class="card" style="width: 100%;">

                            <div class="card-body">

                                <h3 align="center">DATOS PERSONALES</h3>

                                <div class="row">

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Tipo Documento</label>
                                        <asp:DropDownList ID="CboTipoDoc" runat="server" class="form-control"></asp:DropDownList>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Número Documento</label>
                                        <input type="text" class="form-control" id="TxtNumeroDoc" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Nacimiento</label>
                                        <%--<input type="date" class="form-control"  id="TxtFechaNac" runat="server"/>--%>
                                        <asp:TextBox class="form-control" ID="TxtFechaNac" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Sexo</label>
                                        <asp:DropDownList ID="CboSexo" runat="server" class="form-control"></asp:DropDownList>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Estado Civil</label>
                                        <asp:DropDownList ID="CboEstadoCivil" runat="server" class="form-control"></asp:DropDownList>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Nacionalidad</label>
                                        <asp:DropDownList ID="CboNacionalidad" runat="server" class="form-control"></asp:DropDownList>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Nivel Formación</label>
                                        <asp:DropDownList ID="CboNivelFormacion" runat="server" class="form-control"></asp:DropDownList>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>CUIL</label>
                                        <input type="text" class="form-control" id="TxtCuil" runat="server" />
                                    </div>

                                </div>

                                <center>
                                    <div class="col-md-12" style="margin-bottom: 8px;">
                                        <img id="ImgPersonal" runat="server" style="height: 150px; width: 150px; border: 1.5px solid #203f56; padding: 2px; border-radius: 5%; object-fit: cover;" src="" />
                                    </div>
                                </center>

                                <center>
                                    <div alt="Cargando Imagen..." style="background-image: url('https://crear.net.ar/CLIENTES/PIN/Pin/camara-fotografica.png'); background-size: cover; height: 50px; width: 50px; cursor: pointer; decoration: none;" required="" name="imagen" id="files" type="file" accept="image/*">
                                        <asp:FileUpload Style="opacity: 0; height: 80px; width: 80px; cursor: pointer; margin-top: -5px;" runat="server" ID="btnSubirImgEmpleado" onchange="readURL(this);" runat="server"></asp:FileUpload>
                                    </div>
                                </center>
                            </div>
                            <p id="srcFoto" style="display: none;" runat="server"></p>
                            <%-- <center><a onserverclick="GuardarySeguir" runat="server"><input type="button" value="SIGUIENTE" style="background:#047537; color:#fff;   border:1px solid black; width:300px;height:40px" onmouseup="MostrarSig()"/></a></center><br />--%>
                            <center>
                                <button id="BtnDatosPersonles" onclick="guardarDatPers()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button></center>
                            <br />
                        </div>
                    </div>

                    <br />
                    <br />

                    <!--DATOS DEL CONTACTO-->
                    <div class="col-md-12" id="DatosContactoHide" style="display: none">

                        <div class="card" style="width: 100%;">

                            <div class="card-body">
                                <h3 align="center">DATOS DE CONTACTO</h3>

                                <div class="row">

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Calle</label>
                                        <input type="text" class="form-control" runat="server" id="TxtCalle" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Número</label>
                                        <input type="text" class="form-control" id="TxtNumeroCalle" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Piso</label>
                                        <input type="text" class="form-control" id="TxtPiso" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Depto</label>
                                        <input type="text" class="form-control" id="TxtDepto" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Telefono Fijo</label>
                                        <input type="text" class="form-control" id="TxtTelefonoFijo" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Telefono Móvil</label>
                                        <input type="text" class="form-control" id="TxtTelefonMovil" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Localidad</label>
                                        <asp:DropDownList ID="CboLocalidad" runat="server" class="form-control">
                                        </asp:DropDownList>
                                    </div>

                                </div>

                                <div class="row">

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Redes</label>
                                        <%--<asp:DropDownList ID="ComboRedes" runat="server" class="form-control">
                                            <asp:ListItem>SELECCIONAR</asp:ListItem>
                                            <asp:ListItem>FACEBOOK</asp:ListItem>
                                            <asp:ListItem>INSTAGRAM</asp:ListItem>
                                            <asp:ListItem>TWITTER</asp:ListItem>
                                            <asp:ListItem>YOUTUBE</asp:ListItem>
                                        </asp:DropDownList>--%>
                                        <select id="ComboRedes" name="select" runat="server" class="form-control">
                                            <option id="se" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="face" value="FACEBOOK" class="form-control">FACEBOOK</option>
                                            <option id="insta" value="INSTAGRAM" class="form-control">INSTAGRAM</option>
                                            <option id="tw" value="TWITTER" class="form-control">TWITTER</option>
                                            <option id="youtube" value="YOUTUBE" class="form-control">YOUTUBE</option>
                                        </select>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Link Red Social</label>
                                        <asp:TextBox class="form-control" ID="TxtLinkRedsocial" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <button type="button" id="btnGuardar" onclick="AgregarRedes()" class="float" style="background: #047537; color: #fff; border: 1px solid black; height: 40px; cursor: pointer; margin-top: 30px;">
                                            Agregar redes
                                        </button>
                                    </div>

                                </div>


                                <br />

                                <center>
                                    <button id="BtnDatosDeContacto" onclick="agregarDatCont()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button></center>
                                <br />

                            </div>

                            <div class="card-body" id="DivRedes" style="border: 1px solid #fff; width: 100%; border-radius: 3px">
                                <!---aca las redes--->
                                <%--<asp:Repeater ID="RepeaterRedes" runat="server">
                                    <ItemTemplate>
                                        <div class="row">
                                            <div class="col-md-4">
                                                <img src='<%#Eval("Imagen")%>' width="50px">
                                            </div>

                                            <div class="col-md-8">
                                                <span><%#Eval("Link")%></span>
                                            </div>
                                        </div>
                                        <hr />

                                    </ItemTemplate>
                                </asp:Repeater>--%>
                            </div>

                        </div>
                    </div>

                    <!--REFERENCIAS LABORALES-->
                    <div class="col-md-12" id="DatosRefLab" style="display: none">

                        <div class="card" style="width: 100%;">

                            <div class="card-body">

                                <h3 align="center">AGREGAR REFERENCIAS LABORALES</h3>

                                <div class="row">

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Desde</label>
                                        <asp:TextBox ID="TxtFechaDesde" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" Style="margin-top: -10px"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <div class="row" style="margin-top: 24px; border: 1px solid #CED4DA; border-radius: 2px; padding: 2px;">
                                            <div class="col-md-12" style="display: flex;">
                                                <label style="width: 60%;">Aún Activo en la Empresa</label>
                                                <input style="width: 10%; margin-top: 7px;" onclick="desactivarHasta()" type="checkbox" class="form-control" id="ChkActivo" runat="server" />
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Hasta</label>
                                        <asp:TextBox ID="TxtFechaHasta" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" Style="margin-top: -10px"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Empresa</label>
                                        <asp:TextBox ID="TxtEmpresa" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" Style="margin-top: -1px"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Puesto</label>
                                        <input type="text" class="form-control" id="TxtPuesto" runat="server" />
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Área</label>
                                        <select id="Combo" name="select" runat="server" class="form-control">
                                            <option id="sel" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="Autos" value="ADMINISTRACIÓN" class="form-control">ADMINISTRACIÓN</option>
                                            <option id="Motos" value="COMERCIALIZACIÓN" class="form-control">COMERCIALIZACIÓN</option>
                                            <option id="Option1" value="ELECTROMECANICO" class="form-control">ELECTROMECANICO</option>
                                            <option id="Option2" value="ELECTRONICA" class="form-control">ELECTRONICA</option>
                                            <option id="Option3" value="INFORMATICA" class="form-control">INFORMATICA</option>
                                            <option id="Option4" value="INGENIERIA Y DISEÑO" class="form-control">INGENIERIA Y DISEÑO</option>
                                            <option id="Option5" value="LOGISTICA" class="form-control">LOGISTICA</option>
                                            <option id="Option6" value="MANTENIMIENTO INDUSTRIAL" class="form-control">MANTENIMIENTO INDUSTRIAL</option>
                                            <option id="Option7" value="MANUFACTURA" class="form-control">MANUFACTURA</option>
                                            <option id="Option8" value="MARKETING" class="form-control">MARKETING</option>
                                            <option id="Option9" value="ATENCION AL CLIENTE" class="form-control">ATENCION AL CLIENTE</option>
                                            <option id="Option10" value="RECURSOS HUMANOS" class="form-control">RECURSOS HUMANOS</option>
                                            <option id="Option11" value="SEGURIDAD INDUSTRIAL" class="form-control">SEGURIDAD INDUSTRIAL</option>
                                            <option id="Option12" value="OTRO" class="form-control">OTRO</option>
                                        </select>
                                    </div>

                                    <div class="col-md-6" style="margin-bottom: 20px;">
                                        <label>Descripción de las tareas</label>
                                        <textarea maxlength="100" id="TxtDescrip" runat="server" class="form-control"></textarea>
                                    </div>

                                    <div class="col-md-6" style="margin-bottom: 20px;">
                                        <label>Datos Referentes (Nombre Persona / Tel Contacto)</label>
                                        <textarea id="TxtDatosRef" runat="server" class="form-control"></textarea>
                                    </div>

                                    <div class="col-md-12" style="margin-bottom: 20px;">
                                        <label>Si conoces a una persona que ya está trabajando en Coovilros, agregalo como referencia. Podés cargar nombres, teléfonos, email y direcciones</label>
                                        <textarea id="TxtRefCoov" runat="server" class="form-control"></textarea>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>¿En qué sección de Coovilros te gustaría trabajar?</label>
                                        <select id="cboSecciones" name="select" style="" runat="server" class="form-control">
                                            <option id="Opt11" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="Opt15" value="ADMINISTRACIÓN CONTABLE" class="form-control">ADMINISTRACIÓN CONTABLE</option>
                                            <option id="Opt16" value="SERVICIOS SOCIALES" class="form-control">SERVICIOS SOCIALES</option>
                                            <option id="OpT17" value="CEMENTERIO PARQUE" class="form-control">CEMENTERIO PARQUE</option>
                                            <option id="Opt18" value="COMUNICACIONES E INTERNE" class="form-control">COMUNICACIONES E INTERNE</option>
                                            <option id="Opt19" value="REDES ELÉCTRICAS" class="form-control">REDES ELÉCTRICAS</option>
                                            <option id="Opt20" value="ATENCIÓN AL PUBLICO" class="form-control">ATENCIÓN AL PUBLICO</option>
                                            <option id="Opt23" value="CAJAS Y TESORERÍA" class="form-control">CAJAS Y TESORERÍA</option>
                                            <option id="Opt24" value="MAESTRANZA Y LIMPIEZA" class="form-control">MAESTRANZA Y LIMPIEZA</option>
                                        </select>
                                    </div>

                                </div>

                                <br />
                                <br />

                                <center>
                                    <button id="BtnRefLab" onclick="agregarRefLab()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button>
                                </center>

                                <br />

                            </div>

                        </div>

                        <div class="card-body" style="border: 1px solid #fff; width: 100%; border-radius: 3px">
                            <center>
                                <h4 id="MisReferencias" runat="server"></h4>
                            </center>
                            <asp:GridView ID="Grilla" runat="server" CellPadding="8" ForeColor="#000000"
                                GridLines="none"
                                FooterStyle-BackColor="#6699FF" CellSpacing="8" AllowPaging="False"
                                PageSize="10" HorizontalAlign="Center" BorderColor="#000000">

                                <AlternatingRowStyle BackColor="White" />

                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar">
                                        <ItemTemplate>
                                            <center>
                                                <asp:CheckBox ID="ChkProfesional" runat="server" CssClass="BigCheckBox" Style="height: 40px; margin-top: 20px; font-size: 40px" /></center>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <%--<asp:TextBox ID="" runat="server" class="form-control" ></asp:TextBox>--%>
                                            <asp:Button ID="TxtEliminar" class="btn btn-danger" runat="server" Text="Eliminar" PostBackUrl='<%#Eval("urlEliminar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Modificar">
                                        <ItemTemplate>
                                            <%--<asp:TextBox ID="" runat="server" class="form-control" ></asp:TextBox>--%>
                                            <asp:Button ID="TxtModificar" class="btn btn-success" runat="server" Text="Modificar" PostBackUrl='<%#Eval("urlEditar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>

                            </asp:GridView>
                        </div>
                        <center>
                        </center>
                        <br />

                        <asp:TextBox ID="TxtID" runat="server" Style="display: none"></asp:TextBox><br />
                    </div>


                    <!--GRUPO FAMILIAR-->
                    <div class="col-md-12" id="DatosGrupoFam" style="display: none">

                        <div class="card" style="width: 100%;">

                            <div class="card-body">

                                <h3 align="center">AGREGAR FAMILIAR</h3>

                                <div class="row">

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Apellido</label>
                                        <asp:TextBox ID="TxtApellidoGrupFam" type="text" runat="server" ForeColor="Black"
                                            class="form-control" placeholder="Apellido" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Nombre</label>
                                        <asp:TextBox ID="TxtNombreGrupFam" type="text" runat="server" ForeColor="Black"
                                            class="form-control" placeholder="Nombre" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Parentezco</label>
                                        <select id="ComboPrentezco" name="select" runat="server" class="form-control">
                                        </select>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Nacimiento</label>
                                        <asp:TextBox ID="TxtFechaNacGF" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Ocupación</label>
                                        <asp:TextBox ID="TxtOcupacion" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" placeholder="Ocupación"></asp:TextBox>
                                    </div>
                                </div>

                                <br />
                                <br />

                                <center>
                                    <button id="BtnAgregarGrupoFam" onclick="agregarGrupoFam()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button>
                                </center>
                                <br />

                            </div>

                        </div>
                        <div class="card-body" style="border: 1px solid #fff; width: 100%; border-radius: 3px">
                            <center>
                                <h4 id="TituloGF" runat="server"></h4>
                            </center>
                            <div class="card-body" id="DivGF" style="border: 1px solid #fff; width: 100%; border-radius: 3px">
                            </div>
                            <%--<asp:GridView ID="GrillaGrupoFam" runat="server" CellPadding="8" ForeColor="#000000"
                                GridLines="none"
                                FooterStyle-BackColor="#6699FF" CellSpacing="8" AllowPaging="False"
                                PageSize="10" HorizontalAlign="Center" BorderColor="#000000">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar">
                                        <ItemTemplate>
                                            <center>
                                                <asp:CheckBox ID="ChkProfesional" runat="server" CssClass="BigCheckBox" Style="height: 40px; margin-top: 20px; font-size: 40px" /></center>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <asp:Button ID="TxtEliminar" class="btn btn-danger" runat="server" Text="Eliminar" PostBackUrl='<%#Eval("urlEliminar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Modificar">
                                        <ItemTemplate>
                                            <asp:Button ID="TxtModificar" class="btn btn-success" runat="server" Text="Modificar" PostBackUrl='<%#Eval("urlEditar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>--%>
                        </div>
                        <center>
                        </center>
                        <br />

                        <asp:TextBox ID="TextBox4" runat="server" Style="display: none"></asp:TextBox><br />

                    </div>


                    <div class="col-md-12" id="DatosForma" style="display: none">

                        <div class="card" style="width: 100%;">

                            <div class="card-body">


                                <h3 align="center">AGREGAR FORMACION ACADEMICA</h3>
                                <div class="row">
                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Desde (Aprox.)</label>
                                        <asp:TextBox ID="TxtDesdeFA" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Hasta (Aprox.)</label>
                                        <asp:TextBox ID="TxtHastaFA" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Nivel Académico</label>
                                        <select id="ComboFA" name="select" runat="server" onchange="comboFA()" class="form-control">
                                            <option id="Opt1" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="Option15" value="SECUNDARIO COMPLETO" class="form-control">SECUNDARIO COMPLETO</option>
                                            <option id="Option16" value="SECUNDARIO EN CURSO" class="form-control">SECUNDARIO EN CURSO</option>
                                            <option id="Option32" value="SECUNDARIO INCOMPLETO" class="form-control">SECUNDARIO INCOMPLETO</option>
                                            <option id="Option33" value="TERCIARIO COMPLETO" class="form-control">TERCIARIO COMPLETO</option>
                                            <option id="Option34" value="TERCIARIO EN CURSO" class="form-control">TERCIARIO EN CURSO</option>
                                            <option id="Option35" value="TERCIARIO INCOMPLETO" class="form-control">TERCIARIO INCOMPLETO</option>
                                            <option id="Option36" value="UNIVERSITARIO COMPLETO" class="form-control">UNIVERSITARIO COMPLETO</option>
                                            <option id="Option37" value="UNIVERSITARIO EN CURSO" class="form-control">UNIVERSITARIO EN CURSO</option>
                                            <option id="Option38" value="UNIVERSITARIO INCOMPLETO" class="form-control">UNIVERSITARIO INCOMPLETO</option>
                                        </select>
                                    </div>

                                    <script type="text/javascript">
                                        function comboFA() {
                                            var cboFA = $('#ComboFA').val();
                                            if (cboFA == "SECUNDARIO COMPLETO") {
                                                $('#TxtInstitucion').hide();
                                                $('#CboInstitucion').show();
                                            } else {
                                                $('#TxtInstitucion').show();
                                                $('#CboInstitucion').hide();
                                            }

                                            if (cboFA == "SECUNDARIO EN CURSO" || cboFA == "SECUNDARIO INCOMPLETO") {
                                                swal('', '“Por política interna de esta Cooperativa, solo se receptarán los Curriculums de postulantes que obtengan el nivel secundario COMPLETO(analítico en mano)', 'info')
                                                $("#BtnFormacionAca").hide();
                                            } else {
                                                $("#BtnFormacionAca").show();
                                            }
                                        }

                                        function comboInst() {
                                            var cboInst = $('#CboInstitucion').val();
                                            if (cboInst == "OTRO") {
                                                $('#contentInst').show();
                                            } else {
                                                $('#contentInst').hide();
                                            }
                                        }
                                    </script>


                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Especialidad</label>
                                        <select id="ComboEspecilidad" name="select" runat="server" class="form-control">
                                            <option id="Opt2" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="Option14" value="ADMINISTRACION Y GESTION" class="form-control">ADMINISTRACION Y GESTION</option>
                                            <option id="Option29" value="HUMANIDADES" class="form-control">HUMANIDADES</option>
                                            <option id="Option30" value="AGROTÉCNICO" class="form-control">AGROTÉCNICO</option>
                                            <option id="Option31" value="ELECTRICIDAD" class="form-control">ELECTRICIDAD</option>
                                            <option id="Option22" value="ELECTROMECÁNICA" class="form-control">ELECTROMECANICA</option>
                                            <option id="Option21" value="AUTOMOTORES" class="form-control">AUTOMOTORES</option>
                                            <option id="Option27" value="CARPINTERIA" class="form-control">CARPINTERIA</option>
                                            <option id="Option17" value="OTROS" class="form-control">OTROS</option>
                                        </select>

                                    </div>


                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Institución</label>
                                        <asp:TextBox ID="TxtInstitucion" type="text" placeholder="Institución" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>

                                        <select id="CboInstitucion" name="select" onchange="comboInst()" style="display: none;" runat="server" class="form-control">
                                            <option id="Opt4" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="Opt14" value="IPEM N°148 JOSÉ MARÍA PAZ" class="form-control">IPEM N°148 JOSÉ MARÍA PAZ</option>
                                            <option id="Opt29" value="IBAT SAN JOSE" class="form-control">IBAT SAN JOSE</option>
                                            <option id="OpT30" value="ICMA ADORATRICES" class="form-control">ICMA ADORATRICES</option>
                                            <option id="Opt31" value="IPEM N°55 TECNICO" class="form-control">IPEM N°55 TECNICO</option>
                                            <option id="Opt22" value="CENMA N°186" class="form-control">CENMA N°186</option>
                                            <option id="Opt21" value="OTRO" class="form-control">OTRO</option>
                                        </select>

                                    </div>

                                    <!--habilitar si selecciona otro-->
                                    <div class="col-md-4" id="contentInst" style="margin-bottom: 20px; display: none;">
                                        <label>Nombre de la Institución</label>
                                        <asp:TextBox ID="TxtInstitucion2" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" placeholder="Nombre de la Institución"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Nombre del Título</label>
                                        <asp:TextBox ID="TxtTitulo" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" placeholder="Nombre de Título"></asp:TextBox>
                                    </div>



                                    <div class="col col-md-12" style="margin-bottom: 20px;">

                                        <span style="color: #203f56; font-size: 18px;">Adjuntar Archivo del Título o Analítico (Imagen o PDF)</span>
                                        <br />
                                        <div style="padding-top: 20px; padding-bottom: 20px; margin: 10px; border: 1px solid #E3E3E3; border-radius: 4px;">
                                            <center>

                                                <div alt="Cargando Imagen..." style="background-image: url('https://crear.net.ar/CLIENTES/PIN/Pin/camara-fotografica.png'); background-size: cover; height: 50px; width: 50px; cursor: pointer; decoration: none;" required="" name="imagen" id="Div1" type="file" accept="image/*">
                                                    <center>
                                                        <asp:FileUpload Style="opacity: 0; height: 80px; width: 80px; cursor: pointer; margin-top: -5px;" runat="server" ID="SubirRecibo" accept="application/pdf,image/*" onchange="return validarExt2();" runat="server"></asp:FileUpload></center>
                                                </div>

                                                <div id="visorArchivo">
                                                    <!--Aqui se desplegará el fichero-->
                                                </div>

                                            </center>
                                        </div>

                                    </div>

                                </div>

                                <br />
                                <br />

                                <center>
                                    <button id="BtnFormacionAca" onclick="agregarFormAcademica()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button></center>

                                <br />

                            </div>

                        </div>
                        <div class="card-body" style="border: 1px solid #fff; width: 100%; border-radius: 3px">
                            <center>
                                <h4 id="H1" runat="server"></h4>
                            </center>
                            <asp:GridView ID="GrillaFA" runat="server" CellPadding="8" ForeColor="#000000"
                                GridLines="none"
                                FooterStyle-BackColor="#6699FF" CellSpacing="8" AllowPaging="False"
                                PageSize="10" HorizontalAlign="Center" BorderColor="#000000">

                                <AlternatingRowStyle BackColor="White" />

                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar">
                                        <ItemTemplate>
                                            <center>
                                                <asp:CheckBox ID="ChkProfesional" runat="server" CssClass="BigCheckBox" Style="height: 40px; margin-top: 20px; font-size: 40px" /></center>


                                        </ItemTemplate>

                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <%--<asp:TextBox ID="" runat="server" class="form-control" ></asp:TextBox>--%>
                                            <asp:Button ID="TxtEliminar" class="btn btn-danger" runat="server" Text="Eliminar" PostBackUrl='<%#Eval("urlEliminar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField HeaderText="Modificar">
                                        <ItemTemplate>
                                            <%--<asp:TextBox ID="" runat="server" class="form-control" ></asp:TextBox>--%>
                                            <asp:Button ID="TxtModificar" class="btn btn-success" runat="server" Text="Modificar" PostBackUrl='<%#Eval("urlEditar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>

                            </asp:GridView>
                        </div>
                        <center>
                        </center>
                        <br />




                        <asp:TextBox ID="TextBox6" runat="server" Style="display: none"></asp:TextBox><br />



                    </div>


                    <div class="col-md-12" id="DatosCursos" style="display: none">



                        <div class="card" style="width: 100%;">


                            <div class="card-body">


                                <h3 align="center">AGREGAR CURSOS</h3>
                                <div class="row">
                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Desde (Aprox.)</label>
                                        <asp:TextBox ID="TxtFechaDesdeCurso" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Fecha Hasta (Aprox.)</label>
                                        <asp:TextBox ID="TxtFechaHastaCurso" type="date" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Nombre del Curso</label>
                                        <asp:TextBox ID="TxtNombredelCurso" placeholder="Nombre del curso" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Area</label>
                                        <select id="ComboCursos" name="select" runat="server" class="form-control">
                                            <option id="as" value="SELECCIONAR" class="form-control">SELECCIONAR</option>
                                            <option id="a" value="ADMINISTRACIÓN" class="form-control">ADMINISTRACIÓN</option>
                                            <option id="b" value="COMERCIALIZACIÓN" class="form-control">COMERCIALIZACIÓN</option>
                                            <option id="c" value="ELECTROMECANICO" class="form-control">ELECTROMECANICO</option>
                                            <option id="d" value="ELECTRONICA" class="form-control">ELECTRONICA</option>
                                            <option id="e" value="INFORMATICA" class="form-control">INFORMATICA</option>
                                            <option id="f" value="INGENIERIA Y DISEÑO" class="form-control">INGENIERIA Y DISEÑO</option>
                                            <option id="g" value="LOGISTICA" class="form-control">LOGISTICA</option>
                                            <option id="h" value="MANTENIMIENTO INDUSTRIAL" class="form-control">MANTENIMIENTO INDUSTRIAL</option>
                                            <option id="i" value="MANUFACTURA" class="form-control">MANUFACTURA</option>
                                            <option id="j" value="MARKETING" class="form-control">MARKETING</option>
                                            <option id="k" value="ATENCION AL CLIENTE" class="form-control">ATENCION AL CLIENTE</option>
                                            <option id="l" value="RECURSOS HUMANOS" class="form-control">RECURSOS HUMANOS</option>
                                            <option id="m" value="SEGURIDAD INDUSTRIAL" class="form-control">SEGURIDAD INDUSTRIAL</option>
                                            <option id="n" value="OTRO" class="form-control">OTRO</option>
                                        </select>

                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Horas</label>
                                        <asp:TextBox ID="TxtHoras" type="number" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" placeholder="Horas"></asp:TextBox>
                                    </div>

                                    <div class="col-md-4" style="margin-bottom: 20px;">
                                        <label>Institución</label>
                                        <asp:TextBox ID="TxtInstitucionCursos" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%" placeholder="Institución"></asp:TextBox>
                                    </div>

                                    <div class="col-md-12" style="margin-bottom: 20px;">
                                        <label>Comentarios</label>
                                        <asp:TextBox ID="TxtComentarios" MaxLength="100" type="text" TextMode="MultiLine" runat="server" ForeColor="Black"
                                            class="form-control" Height="80px" Width="100%" placeholder="Comentarios"></asp:TextBox>
                                    </div>


                                </div>

                                <br />
                                <br />

                                <center>
                                    <button id="BtnAgregarCurso" onclick="agregarCurso()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button>
                                </center>
                                <br />

                            </div>

                        </div>
                        <div class="card-body" style="border: 1px solid #fff; width: 100%; border-radius: 3px">
                            <center>
                                <h4 id="H2" runat="server"></h4>
                            </center>
                            <asp:GridView ID="GrillaCurso" runat="server" CellPadding="8" ForeColor="#000000"
                                GridLines="none"
                                FooterStyle-BackColor="#6699FF" CellSpacing="8" AllowPaging="False"
                                PageSize="10" HorizontalAlign="Center" BorderColor="#000000">

                                <AlternatingRowStyle BackColor="White" />

                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar">
                                        <ItemTemplate>
                                            <center>
                                                <asp:CheckBox ID="ChkProfesional" runat="server" CssClass="BigCheckBox" Style="height: 40px; margin-top: 20px; font-size: 40px" /></center>


                                        </ItemTemplate>

                                    </asp:TemplateField>



                                    <asp:TemplateField HeaderText="Eliminar">
                                        <ItemTemplate>
                                            <%--<asp:TextBox ID="" runat="server" class="form-control" ></asp:TextBox>--%>
                                            <asp:Button ID="TxtEliminar" class="btn btn-danger" runat="server" Text="Eliminar" PostBackUrl='<%#Eval("urlEliminar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField HeaderText="Modificar">
                                        <ItemTemplate>
                                            <%--<asp:TextBox ID="" runat="server" class="form-control" ></asp:TextBox>--%>
                                            <asp:Button ID="TxtModificar" class="btn btn-success" runat="server" Text="Modificar" PostBackUrl='<%#Eval("urlEditar").ToString()%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>









                            </asp:GridView>
                        </div>
                        <center>
                        </center>
                        <br />

                        <asp:TextBox ID="TextBox7" runat="server" Style="display: none"></asp:TextBox><br />

                    </div>


                    <div class="col-md-12" id="DatosAntSal" style="display: none">



                        <div class="card" style="width: 100%;">


                            <div class="card-body">


                                <h3 align="center" id="h3AntecedeSalud" runat="server">AGREGAR ANTECEDENTES SALUD</h3>
                                <div class="row">
                                    <div class="col-md-2" style="margin-bottom: 20px;">
                                        <label>Altura</label>
                                        <asp:TextBox ID="TxtAltura" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col-md-2" style="margin-bottom: 20px;">
                                        <label>Peso</label>
                                        <asp:TextBox ID="TxtPeso" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="40px" Width="100%"></asp:TextBox>
                                    </div>

                                    <div class="col col-md-7" style="margin-bottom: 20px;">
                                        <label>¿Padece alguna enfermedad crónica y/o esta bajo tratamiento?</label>
                                        <br />
                                        <input type="Radio" class="radiobtn" id="RbtTratSi" runat="server" name="grupo" style="float: left; cursor: pointer;" onclick="mostrarTrat()" /><label for="RbtTratSi" style="margin-left: 5px; margin-top: -7px; float: left; cursor: pointer;">SI</label>
                                        <br />
                                        <br />
                                        <input type="Radio" class="radiobtn" id="RbtTratNo" runat="server" name="grupo" style="float: left; cursor: pointer; margin-top: -25px;" onclick="mostrarTrat()" /><label for="RbtTratNo" style="margin-left: 18px; margin-top: -31px; float: left; cursor: pointer;">NO</label>
                                    </div>

                                    <div class="col-md-6" id="tratamiento" style="display: none;">
                                        <label>Descripción y detalle tratamiento</label>
                                        <asp:TextBox ID="TxtTratamiento" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="80px" Width="100%" placeholder="Descripcion y detalle tratamiento" TextMode="MultiLine"></asp:TextBox>
                                    </div>

                                    <div class="col col-md-7" style="margin-bottom: 10px;">
                                        <label>¿Tiene intervenciones quirurgicas y/o cirugias?</label>
                                        <br />
                                        <input type="Radio" class="radiobtn2" id="RbtCirSi" runat="server" name="grupo2" style="float: left; cursor: pointer;" onclick="mostrarCir()" /><label for="RbtCirSi" style="margin-left: 5px; margin-top: -7px; float: left; cursor: pointer;">SI</label>
                                        <br />
                                        <br />
                                        <input type="Radio" class="radiobtn2" id="RbtCirNo" runat="server" name="grupo2" style="float: left; cursor: pointer; margin-top: -25px;" onclick="mostrarCir()" /><label for="RbtCirNo" style="margin-left: 18px; margin-top: -31px; float: left; cursor: pointer;">NO</label>
                                    </div>

                                    <div class="col-md-6" id="cirugia" style="display: none">
                                        <label>Descripción y detalle de cirugia/s</label>
                                        <asp:TextBox ID="TxtCirugia" type="text" runat="server" ForeColor="Black"
                                            class="form-control" Height="80px" Width="100%" placeholder="Descripcion y detalle cirugia" TextMode="MultiLine"></asp:TextBox>
                                    </div>

                                </div>

                                <br />
                                <br />

                                <center>
                                    <button id="BtnAgregarAntSalud" onclick="agregarAntecedentesDeSalud()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button></center>
                                <br />

                            </div>
                        </div>
                    </div>

                    <br />


                    <div class="col-md-12" id="DatosCurriculum" style="display: none">
                        <div class="card" style="width: 100%;">
                            <div class="card-body">
                                <h3 align="center" id="h3" runat="server">AGREGAR CURRICULUM</h3>
                                <div class="row">

                                    <div class="col col-md-12" style="margin-bottom: 20px;">
                                        <center><span style="color: #203f56; font-size: 18px;">Adjuntar archivo del curriculum(PDF)</span></center>
                                        <div style="padding-top: 20px; padding-bottom: 20px; margin: 10px; border: 1px solid #E3E3E3; border-radius: 4px;">
                                            <center>
                                                <div alt="Cargando Imagen..." style="background-image: url('https://crear.net.ar/CLIENTES/PIN/Pin/camara-fotografica.png'); background-size: cover; height: 50px; width: 50px; cursor: pointer; decoration: none;" required="" name="imagen" id="Div1" type="file" accept="image/*">
                                                    <asp:FileUpload Style="opacity: 0; height: 80px; width: 80px; cursor: pointer; margin-top: -5px;" runat="server" ID="SubirCurriculum" accept="application/pdf,image/*" onchange="return validarExt3();" runat="server"></asp:FileUpload>
                                                </div>
                                                <p id="srcCurriculum" style="display: none;" runat="server"></p>
                                                <div class="col-md-12" id="contentArchivo" style="margin-bottom: 8px;">
                                                    <embed id="srcArchivo" runat="server" src="" width="400" height="440" />
                                                </div>

                                                <div id="visorArchivoC">
                                                    <!--Aqui se desplegará el fichero-->
                                                </div>

                                            </center>
                                        </div>
                                    </div>

                                </div>

                                <center>
                                    <button id="" onclick="agregarCurriculum()" type="button" style="background: #047537; color: #fff; border: 1px solid black; width: 300px; height: 40px; cursor: pointer;">Guardar</button></center>
                                <br />

                            </div>
                        </div>
                    </div>


                    <asp:TextBox ID="TextBox10" runat="server" Style="display: none"></asp:TextBox><br />

                </div>


            </div>


            <br />



            <br />
            <br />
            <br />
            <br />
            <br />

            <%--<a href="#up">
                <div id="subir" style="display: none; float: right; width: 80px; height: 80px; position: relative">
                    <i class="material-icons" style="font-size: 40px; color: red; cursor: pointer">arrow_upward
                    </i>
                </div>
            </a>--%>

            <footer>
                <!--#footer-->
                <div style="background: #383232; padding: 35px; bottom: 0px; width: 100%">
                    <div class="row">
                        <div class="col-md-6">
                            <center>
                                <img src="https://www.coovilros.com/Imagenes/logo-dark.png" style="height: 40px;" />
                            </center>
                        </div>
                        <div class="col-md-6">
                            <center>
                                <span style="color: White;" runat="server" id="Span8">Copyright © 2020 Todos los Derechos
                        Reservados </span>
                            </center>
                        </div>
                    </div>
                </div>

            </footer>
    </form>

    <script type="text/javascript">
        //function comprobar(checkbox) {
        //    otro = checkbox.parentNode.querySelector("[type=checkbox]:not(#" + checkbox.id + ")");
        //    console.log(checkbox.id);
        //    if (otro.checked) {
        //        otro.checked = false;
        //    }
        //    if (checkbox.id = "EnfermedadSI") {
        //        document.getElementById("tratamiento").style = "display:block";
        //    }
        //}

        //function comprobar2(checkbox) {
        //    otro = checkbox.parentNode.querySelector("[type=checkbox]:not(#" + checkbox.id + ")");
        //    console.log(checkbox.id);
        //    if (otro.checked) {
        //        otro.checked = false;
        //    }
        //    if (checkbox.id = "cirugiaSi") {
        //        document.getElementById("cirugia").style = "display:block";
        //    }
        //}

        function mostrarTrat() {
            if (document.getElementById('RbtTratSi').checked) {
                document.getElementById("tratamiento").style = "display:block";
                document.getElementById("tratamiento").style = "margin-bottom:20px";
            }
            if (document.getElementById('RbtTratNo').checked) {
                document.getElementById("tratamiento").style = "display:none";
            }
        }
        function mostrarCir() {
            if (document.getElementById('RbtCirSi').checked) {
                document.getElementById("cirugia").style = "display:block";
                document.getElementById("cirugia").style = "margin-bottom:20px";
            }
            if (document.getElementById('RbtCirNo').checked) {
                document.getElementById("cirugia").style = "display:none";
            }
        }

        function MostrarSig() {
            document.getElementById("primero").style = "display:block";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarDatosContacto() {
            document.getElementById("DatosContactoHide").style = "display:block";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarRefLab() {
            document.getElementById("DatosRefLab").style = "display:block";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarGrupoFam() {
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:block";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarFromAca() {
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:block";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarCursos() {
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:block";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarAntSal() {
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:block";
            document.getElementById("DatosCurriculum").style = "display:none";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
        function MostrarCurriculum() {
            document.getElementById("DatosRefLab").style = "display:none";
            document.getElementById("DatosContactoHide").style = "display:none";
            document.getElementById("primero").style = "display:none";
            document.getElementById("DatosGrupoFam").style = "display:none";
            document.getElementById("DatosForma").style = "display:none";
            document.getElementById("DatosCursos").style = "display:none";
            document.getElementById("DatosAntSal").style = "display:none";
            document.getElementById("DatosCurriculum").style = "display:block";
            document.getElementById("subir").style = "display:block;float:right; width:80px;height:100px;margin-top:-200px;z-index:999999";
        }
    </script>

    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.js"></script>

    <script type="text/javascript">
        $(function () {
            $('a[href*="#"]:not([href="#"])').click(function () {
                if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') && location.hostname == this.hostname) {
                    var target = $(this.hash);
                    target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
                    if (target.length) {
                        $('html, body').animate({
                            scrollTop: target.offset().top
                        }, 3000);
                        return false;
                    }
                }
            });
        });
    </script>

    <script type="text/javascript" src="Scripts/MiPerfil.js"></script>

    <script type="text/javascript" src="Scripts/Redes.js"></script>

    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script type="text/javascript" src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>

    <script type="text/javascript">
        $(document).ready(function () {
            CargarRedes();
            $('#TxtLinkRedsocial').val("");
            $('#ComboRedes').val("SELECCIONAR").change();
            //$("#ComboRedes").val(0).change();

            cargarGrupoFam();
            mostrarTrat();
            mostrarCir();
            BuscarUserId();
            //setTimeout(() => {
            //    BuscarUserId();
            //}, 1500);
        });

        function cerrarModal() {
            $('#modalDatosFaltantes').modal('toggle');
        }

        function buscarDatosFaltantes() {
            var Email = $('#txtEmail').val();
            var par = { Email: Email };
            var payload = { cadena: JSON.stringify(par) };

            $.ajax({
                type: "POST",
                "url": "FrmMiPerfil.aspx/BuscarDatosFaltantes",
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(payload),
                dataType: "json",
                success: function (data) {

                    var json = $.parseJSON(data.d);
                    var status = json.Status;

                    if (status == 200) {
                        $('#contentModal').empty();
                        $('#contentModal').append(`${json.Contenido}`)
                        $('#modalDatosFaltantes').appendTo("body").modal('show');
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
    </script>

</body>
</html>
