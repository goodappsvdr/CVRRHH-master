﻿Imports System.IO
Imports System.Net.Mail
Imports System.Web.Script.Serialization
Imports System.Web.Script.Services
Imports System.Web.Services
Imports AD

Public Class FrmMiPerfil
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim GalletaEmail As HttpCookie
        GalletaEmail = Request.Cookies("datos")

        If User.Identity.IsAuthenticated = False Then
            'Response.Redirect("FrmInicio.aspx")
        End If

        If GalletaEmail Is Nothing Then
            Response.Redirect("FrmInicio.aspx")
        End If

        If Page.IsPostBack = False Then
            Dim email As String = GalletaEmail.Values("nombre")
            txtEmail.Text = email

            CargarLocalidades()
            CargarTipoDNI()
            CargarCboNivelFormacion()
            CargarCboEstadosCiviles()
            CargarCboNacionalidades()
            CargarCboSexos()
            CargarCboParentezco()
            BuscarAntecedentesSalud()
            CargarCurriculum()

            Dim PruebaGalleta As HttpCookie
            PruebaGalleta = Request.Cookies("datos")

            'aca valido si hay cookies
            If PruebaGalleta Is Nothing Then

            Else
                PruebaGalleta.Expires = Date.Now

                Dim ods As New DataSet
                Dim Objeto As New PersonalLegajos

                'aca obtengo los datos de las cookies que traigo de FrmIngreso
                Dim Galleta As HttpCookie
                Galleta = Request.Cookies("datos")

                Dim name As String = Galleta.Values("nombre")
                Dim IdUser As String = Galleta.Values("userid")
                ods = Objeto.BuscarDatosDeUsuarioPorEmail(name)
                If ods.Tables(0).Rows.Count > 0 Then
                    Dim Nombre As String = ods.Tables(0).Rows(0).Item("Nombre").ToString
                    Dim Apellido As String = ods.Tables(0).Rows(0).Item("Apellido").ToString
                    Dim ID_PersonalLegajo As Integer = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString
                End If
            End If

        End If
    End Sub

#Region "COMBOS"
    Public Sub CargarLocalidades()
        Dim Ods As New DataSet
        Dim Objeto As New Localidaes

        Ods = Objeto.BuscarTodos
        CboLocalidad.DataSource = Ods.Tables(0)
        CboLocalidad.DataTextField = "descripcion"
        CboLocalidad.DataValueField = "id_localidad"
        CboLocalidad.DataBind()
    End Sub

    Private Sub CargarTipoDNI()
        Dim ods As New DataSet
        Dim OCategoriaTipo As New Categorias

        ods = OCategoriaTipo.BuscarPorCategoriatipo("DNITIPO")
        CboTipoDoc.DataSource = ods.Tables(0)
        CboTipoDoc.DataTextField = "NOMBRE"
        CboTipoDoc.DataValueField = "ID_CATEGORIA"
        CboTipoDoc.DataBind()
    End Sub

    Private Sub CargarCboNivelFormacion()
        Dim ods As New DataSet
        Dim OCategoriaTipo As New Categorias

        ods = OCategoriaTipo.BuscarPorCategoriatipo("NIVELFORMACION")
        CboNivelFormacion.DataSource = ods.Tables(1)
        CboNivelFormacion.DataTextField = "NOMBRE"
        CboNivelFormacion.DataValueField = "ID_CATEGORIA"
        CboNivelFormacion.DataBind()
    End Sub

    Private Sub CargarCboEstadosCiviles()
        Dim ods As New DataSet
        Dim OCategoriaTipo As New Categorias

        ods = OCategoriaTipo.BuscarPorCategoriatipo("ESTADOCIVIL")
        CboEstadoCivil.DataSource = ods.Tables(1)
        CboEstadoCivil.DataTextField = "NOMBRE"
        CboEstadoCivil.DataValueField = "ID_CATEGORIA"
        CboEstadoCivil.DataBind()
    End Sub

    Private Sub CargarCboNacionalidades()
        Dim ods As New DataSet
        Dim OCategoriaTipo As New Categorias

        ods = OCategoriaTipo.BuscarPorCategoriatipo("NACIONALIDADES")
        CboNacionalidad.DataSource = ods.Tables(0)
        CboNacionalidad.DataTextField = "NOMBRE"
        CboNacionalidad.DataValueField = "ID_CATEGORIA"
        CboNacionalidad.DataBind()
    End Sub

    Private Sub CargarCboSexos()
        Dim ods As New DataSet
        Dim OCategoriaTipo As New Categorias

        ods = OCategoriaTipo.BuscarPorCategoriatipo("SEXOTIPO")
        CboSexo.DataSource = ods.Tables(1)
        CboSexo.DataTextField = "NOMBRE"
        CboSexo.DataValueField = "ID_CATEGORIA"
        CboSexo.DataBind()
    End Sub


    Private Sub CargarCboParentezco()
        Dim ods As New DataSet
        Dim OCategoriaTipo As New Categorias

        ods = OCategoriaTipo.BuscarPorCategoriatipo("FAMILIARTIPO")
        ComboPrentezco.DataSource = ods.Tables(0)
        ComboPrentezco.DataTextField = "NOMBRE"
        ComboPrentezco.DataValueField = "ID_CATEGORIA"
        ComboPrentezco.DataBind()
    End Sub
#End Region

    Protected Sub CerrarSesion(sender As Object, e As EventArgs)
        Dim Galleta As HttpCookie
        Galleta = Request.Cookies("datos")
        Galleta.Expires = DateTime.Now.AddDays(-1)
        Response.Cookies.Add(Galleta)

        Session.Clear()

        FormsAuthentication.SignOut()
        Roles.DeleteCookie()
        'Session.Abandon()
        Response.Redirect("FrmInicio.aspx")
    End Sub

    Public Sub ModificarDatosReferenciasLaborales()

        Dim PruebaGalleta As HttpCookie
        PruebaGalleta = Request.Cookies("datos")

        'aca valido si hay cookies
        If PruebaGalleta Is Nothing Then

        Else
            Dim Galleta As HttpCookie
            Galleta = Request.Cookies("datos")

            Dim ods2 As New DataSet
            Dim Objeto2 As New PersonalLegajos

            Dim name As String = Galleta.Values("nombre")
            Dim IdUser As String = Galleta.Values("userid")
            ods2 = Objeto2.BuscarDatosDeUsuarioPorEmail(name)

            Dim ID_PersonalLegajo As Integer = ods2.Tables(1).Rows(0).Item("ID_PersonalLegajo").ToString
            Dim ID_AntecedentesLaborales As Integer = ods2.Tables(1).Rows(0).Item("ID_AntecedentesLaborales").ToString
            Dim Activo As Integer

            If ChkActivo.Checked = True Then
                Activo = 1
            Else
                Activo = 0
            End If

            ods2 = Objeto2.Modificar_AntecedentesLaborales(ID_AntecedentesLaborales, ID_PersonalLegajo, TxtFechaDesde.Text, Activo, TxtFechaHasta.Text, TxtEmpresa.Text, TxtPuesto.Value, Combo.Value, TxtDescrip.Value, TxtDatosRef.Value, TxtRefCoov.Value)
        End If
    End Sub

    Public Sub ModificarDatosAntecedentesSalud()
        Dim PruebaGalleta As HttpCookie
        PruebaGalleta = Request.Cookies("datos")

        'aca valido si hay cookies
        If PruebaGalleta Is Nothing Then

        Else
            Dim Galleta As HttpCookie
            Galleta = Request.Cookies("datos")

            Dim ods2 As New DataSet
            Dim Objeto2 As New PersonalLegajos

            Dim name As String = Galleta.Values("nombre")
            'Dim pass As String = Galleta.Values("pass")
            Dim IdUser As String = Galleta.Values("userid")
            ods2 = Objeto2.BuscarDatosDeUsuarioPorEmail(name)

            Dim Nombre As String = ods2.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods2.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods2.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            Dim ods As New DataSet
            Dim oObjeto As New AntecedentesSalud
            Dim ID_Resultado As Integer
            Dim Enfermedad As String
            Dim Cirugia As String

            If TxtAltura.Text <> "" And TxtPeso.Text <> "" Then
                Dim ods3 As New DataSet
                Dim oObjeto3 As New PersonalLegajos

                ods3 = oObjeto3.BuscarDatosDeUsuarioPorEmail(name)

                'BUSCO EL ID
                Dim ID As String = ods3.Tables(5).Rows(0).Item("ID_AntecedentesSalud").ToString
                ods = oObjeto.Modificar(ID, ID_PersonalLegajo, TxtAltura.Text, TxtPeso.Text, Enfermedad, TxtTratamiento.Text, Cirugia, TxtCirugia.Text)

                Response.Redirect("FrmMiPerfil.aspx")
            End If
        End If
    End Sub

    Public Sub BuscarAntecedentesSalud()
        Dim ods2 As New DataSet
        Dim Objeto2 As New PersonalLegajos

        Dim PruebaGalleta As HttpCookie
        PruebaGalleta = Request.Cookies("datos")

        'aca valido si hay cookies
        If PruebaGalleta Is Nothing Then

        Else
            Dim Galleta As HttpCookie
            Galleta = Request.Cookies("datos")

            Dim ods3 As New DataSet
            Dim oobjeto3 As New PersonalLegajos

            Dim name As String = Galleta.Values("nombre")
            'Dim pass As String = Galleta.Values("pass")
            Dim IdUser As String = Galleta.Values("userid")

            ods3 = oobjeto3.BuscarDatosDeUsuarioPorEmail(name)

            If ods3.Tables(0).Rows.Count > 0 Then
                Dim Nombre As String = ods3.Tables(0).Rows(0).Item("Nombre").ToString
                Dim Apellido As String = ods3.Tables(0).Rows(0).Item("Apellido").ToString
                Dim ID_PersonalLegajo As Integer = ods3.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

                Dim ods As New DataSet
                Dim oObjeto As New PersonalLegajos

                ods = oObjeto.BuscarDatosDeUsuarioPorEmail(name)

                If ods.Tables(5).Rows.Count > 0 Then
                    h3AntecedeSalud.InnerHtml = "MODIFICAR DATOS ANTECEDENTES SALUD"
                    TxtAltura.Text = ods.Tables(5).Rows(0).Item("Altura").ToString
                    TxtPeso.Text = ods.Tables(5).Rows(0).Item("Peso").ToString
                    RbtTratSi.Checked = ods.Tables(5).Rows(0).Item("Enfermedad").ToString
                    TxtTratamiento.Text = ods.Tables(5).Rows(0).Item("DescripcionEnfermedad").ToString
                    RbtCirSi.Checked = ods.Tables(5).Rows(0).Item("Cirugias").ToString
                    TxtCirugia.Text = ods.Tables(5).Rows(0).Item("DescripcionCirugias").ToString
                    'BtnAgregarAntSalud.Value = "MODIFICAR DATOS"
                Else
                    h3AntecedeSalud.InnerHtml = "AGREGAR ANTECEDENTES SALUD"
                    'BtnAgregarAntSalud.Value = "AGREGAR DATOS"
                End If
            Else
                Galleta = Request.Cookies("datos")
                Galleta.Expires = DateTime.Now.AddDays(-1)
                Response.Cookies.Add(Galleta)
                Session.Clear()
                FormsAuthentication.SignOut()
                Roles.DeleteCookie()
                Response.Redirect("FrmIngreso.aspx")
            End If
        End If
    End Sub

    Public Sub CargarCurriculum()
        Dim PruebaGalleta As HttpCookie
        PruebaGalleta = Request.Cookies("datos")

        'aca valido si hay cookies
        If PruebaGalleta Is Nothing Then

        Else
            Dim Galleta As HttpCookie
            Galleta = Request.Cookies("datos")

            Dim ods As New DataSet
            Dim oobjeto As New PersonalLegajos

            Dim name As String = Galleta.Values("nombre")
            Dim IdUser As String = Galleta.Values("userid")
            ods = oobjeto.BuscarDatosDeUsuarioPorEmail(name)

            If ods.Tables(0).Rows.Count > 0 Then
                Dim Nombre As String = ods.Tables(0).Rows(0).Item("Nombre").ToString
                Dim Apellido As String = ods.Tables(0).Rows(0).Item("Apellido").ToString
                Dim ID_PersonalLegajo As Integer = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

                Dim ods2 As New DataSet
                Dim Obj2 As New Curriculum
                ods2 = Obj2.BuscarPorId_PL(ID_PersonalLegajo)

                If ods2.Tables(0).Rows.Count > 0 Then
                    srcArchivo.Src = ods2.Tables(0).Rows(0).Item("Archivo").ToString
                    srcCurriculum.InnerHtml = ods2.Tables(0).Rows(0).Item("Archivo").ToString
                    aCurriculum.Visible = True
                    aCurriculum.Attributes("href") = ods2.Tables(0).Rows(0).Item("Archivo").ToString
                Else
                    aCurriculum.Visible = False
                End If
            End If

        End If
    End Sub

    Private Sub irAPerfil_ServerClick(sender As Object, e As System.EventArgs) Handles irAPerfil.ServerClick
        Dim PruebaGalleta As HttpCookie
        PruebaGalleta = Request.Cookies("datos")

        'aca valido si hay cookies
        If PruebaGalleta Is Nothing Then

        Else
            Dim ods2 As New DataSet
            Dim Objeto2 As New PersonalLegajos

            Dim Galleta As HttpCookie
            Galleta = Request.Cookies("datos")

            Dim ods3 As New DataSet
            Dim oobjeto3 As New PersonalLegajos

            Dim name As String = Galleta.Values("nombre")
            'Dim pass As String = Galleta.Values("pass")
            Dim IdUser As String = Galleta.Values("userid")
            ods3 = oobjeto3.BuscarDatosDeUsuarioPorEmail(name)

            Dim Nombre As String = ods3.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods3.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods3.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString
            Dim UserID As String = ods3.Tables(0).Rows(0).Item("Userid").ToString

            Response.Redirect("VerMiPerfil.aspx?Token=" & UserID)
        End If
    End Sub

    'WEB METHODS
#Region "BUSCAR DATOS DEL USUARIO + GRAFICO"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function CargarDatosUsuario(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of DatosPersonalesWs))("[" & cadena & "]")

            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos

            ods = oObjeto.BuscarDatosDeUsuarioPorEmail(Email)

            If ods.Tables(0).Rows.Count > 0 Then
                Dim Nombre As String = ods.Tables(0).Rows(0).Item("Nombre").ToString
                Dim Apellido As String = ods.Tables(0).Rows(0).Item("Apellido").ToString
                Dim ID_PersonalLegajo As Integer = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString
                Dim UserId As String = ods.Tables(0).Rows(0).Item("Userid").ToString

                Dim ods2 As New DataSet
                Dim Obj2 As New PersonalLegajos
                ods2 = Obj2.Postulantes_BuscarDatosCargadosParaProgressBar(ID_PersonalLegajo)

                'CARGO VALORES PARA EL GRAFICO DE PORCENTAJES
                'Dim TotalRedes As Integer = ods2.Tables(0).Rows.Count
                Dim TotalAntLab As Integer = ods2.Tables(1).Rows.Count
                Dim TotalNumDoc As Integer = ods2.Tables(2).Rows(0).Item("NroDocumento")
                Dim TotalFoto As Integer = ods2.Tables(3).Rows(0).Item("Foto")
                Dim TotalFormAca As Integer = ods2.Tables(4).Rows.Count
                Dim TotalCurso As Integer = ods2.Tables(5).Rows.Count
                Dim TotalAntecedentes As Integer = ods2.Tables(6).Rows.Count
                Dim TotalCurriculum As Integer = ods2.Tables(7).Rows.Count

                If TotalNumDoc = 0 Then
                    TotalNumDoc = 0
                Else
                    TotalNumDoc = ods2.Tables(2).Rows.Count
                End If
                If TotalFoto = 0 Then
                    TotalFoto = 0
                Else
                    TotalFoto = ods2.Tables(3).Rows.Count
                End If

                Dim TotalAlcanzado As Integer = TotalAntLab + TotalNumDoc + TotalFoto + TotalFormAca + TotalCurso + TotalAntecedentes + TotalCurriculum
                Dim TotalPermitido As Integer = 7
                Dim Resultado As Integer = TotalAlcanzado * 100 / TotalPermitido
                Dim Grafico As String
                If TotalAlcanzado < 1 Then
                    Grafico = "<span style='font-weight:600;font-size:20px !important'>Hola " & Nombre & "!</span><p class='quitarpuntolista'> Completá los datos requeridos(*) por favor</p>"
                Else
                    Grafico = "<span style='font-weight:600;font-size:20px !important'>Hola " & Nombre & "!</span><p class='quitarpuntolista'> Tu CV está cargado al </p>"
                End If

                Dim Porcentaje = Resultado & "%"
                Dim PorcentajeClass = "c100 p" & Resultado

                'AHORA CARGO LOS CAMPOS DE LOS INPUTS
                Dim TituloPaginaWeb = "CV " & Nombre & " " & Apellido
                Dim srcFoto = ods.Tables(0).Rows(0).Item("Foto").ToString
                Dim ImgPersonal = ods.Tables(0).Rows(0).Item("Foto").ToString
                Dim TxtCalle = ods.Tables(0).Rows(0).Item("Calle").ToString
                Dim TxtCuil = ods.Tables(0).Rows(0).Item("Cuil").ToString
                Dim TxtDepto = ods.Tables(0).Rows(0).Item("Depto").ToString
                Dim TxtNumeroCalle = ods.Tables(0).Rows(0).Item("Nro").ToString
                Dim TxtPiso = ods.Tables(0).Rows(0).Item("Piso").ToString
                Dim TxtTelefonoFijo = ods.Tables(0).Rows(0).Item("Telefono").ToString
                Dim TxtTelefonMovil = ods.Tables(0).Rows(0).Item("Movil").ToString
                Dim CboTipoDoc = ods.Tables(0).Rows(0).Item("ID_DocumentoTipo").ToString
                Dim CboNivelFormacion = ods.Tables(0).Rows(0).Item("ID_NivelFormacion").ToString
                Dim TxtFechaNac = ods.Tables(0).Rows(0).Item("Nacimiento").ToString
                Dim CboNacionalidad = ods.Tables(0).Rows(0).Item("ID_Nacionalidad").ToString
                Dim CboLocalidad = ods.Tables(0).Rows(0).Item("ID_Localidad").ToString
                Dim TxtNumeroDoc = ods.Tables(0).Rows(0).Item("NroDocumento").ToString
                Dim CboEstadoCivil = ods.Tables(0).Rows(0).Item("ID_EstadoCivil").ToString
                Dim CboSexo = ods.Tables(0).Rows(0).Item("Sexo").ToString

                Dim ods3 As New DataSet
                Dim obj3 As New SeccionTrabajar
                Dim SeccionTrabajar As String
                ods3 = obj3.BuscarPorId_Legajo(ID_PersonalLegajo)
                If ods3.Tables(0).Rows.Count > 0 Then
                    SeccionTrabajar = ods3.Tables(0).Rows(0).Item("Descripcion").ToString
                Else
                End If

                Dim data = New With {
                    Key .Status = "200",
                    Key .Grafico = Grafico,
                    Key .Porcentaje = Porcentaje,
                    Key .PorcentajeClass = PorcentajeClass,
                    Key .Resultado = Resultado,
                    Key .srcFoto = srcFoto,
                    Key .ImgPersonal = ImgPersonal,
                    Key .TxtCalle = TxtCalle,
                    Key .TxtCuil = TxtCuil,
                    Key .TxtDepto = TxtDepto,
                    Key .TxtNumeroCalle = TxtNumeroCalle,
                    Key .TxtPiso = TxtPiso,
                    Key .TxtTelefonoFijo = TxtTelefonoFijo,
                    Key .TxtTelefonMovil = TxtTelefonMovil,
                    Key .CboTipoDoc = CboTipoDoc,
                    Key .CboNivelFormacion = CboNivelFormacion,
                    Key .TxtFechaNac = TxtFechaNac,
                    Key .CboNacionalidad = CboNacionalidad,
                    Key .CboLocalidad = CboLocalidad,
                    Key .TxtNumeroDoc = TxtNumeroDoc,
                    Key .CboEstadoCivil = CboEstadoCivil,
                    Key .CboSexo = CboSexo,
                    Key .SeccionTrabajar = SeccionTrabajar
                }

                Dim serializer = New JavaScriptSerializer()
                Dim json = serializer.Serialize(data)
                Return New JavaScriptSerializer().Serialize(data)
            Else
                Return Error401()
            End If

        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function BuscarDatosFaltantes(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of DatosPersonalesWs))("[" & cadena & "]")

            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos

            ods = oObjeto.BuscarDatosDeUsuarioPorEmail(Email)

            If ods.Tables(0).Rows.Count > 0 Then
                Dim ID_PersonalLegajo As String = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString
                Dim UserId As String = ods.Tables(0).Rows(0).Item("Userid").ToString

                Dim ods2 As New DataSet
                ods2 = oObjeto.Postulantes_BuscarDatosCargadosParaProgressBar(ID_PersonalLegajo)

                'Dim TotalRedes As Integer = ods2.Tables(0).Rows.Count
                Dim TotalAntLab As Integer = ods2.Tables(1).Rows.Count
                Dim TotalNumDoc As Integer = ods2.Tables(2).Rows(0).Item("NroDocumento")
                Dim TotalFoto As Integer = ods2.Tables(3).Rows(0).Item("Foto")
                Dim TotalFormAca As Integer = ods2.Tables(4).Rows.Count
                Dim TotalCurso As Integer = ods2.Tables(5).Rows.Count
                Dim TotalAntecedentes As Integer = ods2.Tables(6).Rows.Count
                Dim TotalCurriculum As Integer = ods2.Tables(7).Rows.Count
                If TotalNumDoc = 0 Then
                    TotalNumDoc = 0
                Else
                    TotalNumDoc = ods2.Tables(2).Rows.Count
                End If
                If TotalFoto = 0 Then
                    TotalFoto = 0
                Else
                    TotalFoto = ods2.Tables(3).Rows.Count
                End If

                Dim contenido As String = "<p style='font-weight: bold;'>Te faltan cargar datos en los siguientes módulos:</p>"
                If TotalNumDoc = 0 And TotalFoto = 0 Then
                    contenido += "<p>Datos personales</p>"
                ElseIf TotalNumDoc = 0 Then
                    contenido += "<p>Datos personales</p>"
                ElseIf TotalFoto = 0 Then
                    contenido += "<p>Datos personales</p>"
                End If
                'If TotalRedes = 0 Then
                '    contenido += "<p>Redes sociales</p>"
                'End If
                If TotalAntLab = 0 Then
                    contenido += "<p>Antecedentes laborales</p>"
                End If

                If TotalFormAca = 0 Then
                    contenido += "<p>Formación academica</p>"
                End If
                If TotalCurso = 0 Then
                    contenido += "<p>Cursos y seminarios</p>"
                End If
                If TotalAntecedentes = 0 Then
                    contenido += "<p>Antecedentes de salud</p>"
                End If
                If TotalCurriculum = 0 Then
                    contenido += "<p>Curriculum</p>"
                End If

                Dim data = New With {
                    Key .Status = "200",
                    Key .UserId = UserId,
                    Key .Contenido = contenido
                }

                Dim serializer = New JavaScriptSerializer()
                Dim json = serializer.Serialize(data)
                Return New JavaScriptSerializer().Serialize(data)
            Else
                Return Error401()
            End If

        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region


#Region "BUSCAR PARA VER SI COMPLETO TODOS LOS DATOS Y ENVIAR MAIL(POR AHORA NO MANDO)"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function BuscarUserId(ByVal cadena As String) As String
        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of DatosPersonalesWs))("[" & cadena & "]")

            Dim Email As String = Convert.ToString(dict(0).Email)
            Dim Porcentaje As String = Convert.ToString(dict(0).Porcentaje)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos

            ods = oObjeto.BuscarDatosDeUsuarioPorEmail(Email)

            If ods.Tables(0).Rows.Count > 0 Then
                Dim ID_PersonalLegajo As String = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString
                Dim UserId As String = ods.Tables(0).Rows(0).Item("Userid").ToString

                Dim data = New With {
                    Key .Status = "200",
                    Key .UserId = UserId,
                    Key .Resultado = Porcentaje
                }

                Dim serializer = New JavaScriptSerializer()
                Dim json = serializer.Serialize(data)
                Return New JavaScriptSerializer().Serialize(data)
            Else
                Return Error401()
            End If

        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function SendEmail(ByVal cadena As String) As String

        Try
            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of globalWS))("[" & cadena & "]")

            Dim EmailTipo As Integer = Convert.ToInt32(dict(0).EmailTipo)

            '------------------------------mando email--------------------------------------------------
            Dim mail As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage()
            Dim SmtpServer As SmtpClient = New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress("info@novalrhasoc.com.ar", "NOVAL", System.Text.Encoding.UTF8)
            Dim horayuser As String = Date.Now.Year.ToString + Date.Now.Month.ToString + Date.Now.Day.ToString + Date.Now.TimeOfDay.TotalMinutes.ToString
            Dim mu As MembershipUser = Membership.GetUser
            Dim email As String = mu.Email
            mail.[To].Add(email)

            Select Case EmailTipo
                Case 1
                    mail.Subject = "NOVAL"
                    'mail.Body = "Acabas de recibir una nueva Solicitud de Credito"
                    mail.IsBodyHtml = True
                    mail.Body = "<html><head><meta name='viewport' content='initial-scale=1.0, user-scalable=no'><meta charset='utf-8'>" &
            "<title>CLASIFICACIÓN</title></head><body style='background:#fff;'>" &
            "<br><center>" &
            "<div class='row' " &
            "<div style='background:#fff; color:#000;margin-top:-100px;z-index:9999999;width:50%;height:auto;-webkit-box-shadow: 0px 5px 13px 2px rgba(51,49,51,1);'>" &
            "<img src='https://www.novalrhasoc.com.ar/images/logonovalcolor.png' width='200' style='float: left'>" &
            "<br><h2 style='text-align:start;color:#495057;font-family: verdana;font-weight:bold;margin-top:50px'>Felicidades! Has cargado el 40% de tu CV.</h2>" &
            "<h3 style='text-align:start;color:#495057;font-family: verdana;font-weight:500;font-size:19px'>Con la carga de los datos obligatorios, tu perfil ya ingresó al sistema de postulantes de Noval y Asociados. Te recomendamos seguir cargando el resto de datos para enriquecer tu perfil y tener prioridad en las próximas busquedas laborales.</h3>" &
            "<br><a href='https://www.novalrhasoc.com.ar/FrmMiPerfil.aspx'><input type='button' value='IR A MI PERFIL' style='text-align:center;color:#fff;cursor:pointer; font-size:16px; font-weight:bold ; background:linear-gradient(135deg, rgb(37, 184, 175) 0%, rgb(37, 184, 175) 100%);padding: 10px;margin:auto;border:1px;border-radius: 5px;float: left'><br></a><br>" &
            "<br></div><img src='https://www.novalrhasoc.com.ar/images/carga40.png' width='50%' height='50%' style='margin-top:0px;margin-left:0px' ></div> " &
            "<br><br></center></body></html>"

                Case 2

                    mail.Subject = "NOVAL"
                    'mail.Body = "Acabas de recibir una nueva Solicitud de Credito"
                    mail.IsBodyHtml = True
                    mail.Body = "<html><head><meta name='viewport' content='initial-scale=1.0, user-scalable=no'><meta charset='utf-8'>" &
            "<title>CLASIFICACIÓN</title></head><body style='background:#fff;'>" &
            "<br><center>" &
            "<div class='row' " &
            "<div style='background:#fff; color:#000;margin-top:-100px;z-index:9999999;width:50%;height:auto;-webkit-box-shadow: 0px 5px 13px 2px rgba(51,49,51,1);'>" &
            "<img src='https://www.novalrhasoc.com.ar/images/logonovalcolor.png' width='200' style='float: left'>" &
            "<br><h2 style='text-align:start;color:#495057;font-family: verdana;font-weight:bold;margin-top:50px'>Felicidades! Cargaste el 100% de tu CV</h2>" &
            "<h3 style='text-align:start;color:#495057;font-family: verdana;font-weight:500'>Recordá mantener actualizados tus datos, ingresando a nuestra plataforma periodicamente.</h3>" &
            "<br><a href='https://www.novalrhasoc.com.ar/FrmMiPerfil.aspx'><input type='button' value='IR A MI PERFIL' style='text-align:center;color:#fff;cursor:pointer; font-size:16px; font-weight:bold ;background:linear-gradient(135deg, rgb(37, 184, 175) 0%, rgb(37, 184, 175) 100%);padding: 10px;margin:auto;border:1px;border-radius: 5px;float: left'><br></a><br>" &
            "<br></div><img src='https://www.novalrhasoc.com.ar/images/carga100.png' width='50%' height='50%' style='margin-top:0px;margin-left:0px' ></div> " &
            "<br><br></center></body></html>"

            End Select

            mail.BodyEncoding = System.Text.Encoding.UTF8
            mail.SubjectEncoding = System.Text.Encoding.UTF8
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential("logistica.ideastdi@gmail.com", "password.9")
            SmtpServer.EnableSsl = True
            SmtpServer.Send(mail)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "DATOS PERSONALES"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarDatosPersonales(ByVal cadena As String) As String
        Try
            'Main()
            'IniciaTransaccion()

            Dim jss As New JavaScriptSerializer()
            jss.MaxJsonLength = 500000000
            Dim dict = jss.Deserialize(Of List(Of DatosPersonalesWs))("[" & cadena & "]")

            Dim TipoDocumento As String
            TipoDocumento = Convert.ToString(dict(0).TipoDocumento)
            Dim NroDocumento As String
            NroDocumento = Convert.ToString(dict(0).NroDocumento)
            Dim FechaNacimiento As String
            FechaNacimiento = Convert.ToString(dict(0).FechaNacimiento)
            Dim Sexo As String
            Sexo = Convert.ToString(dict(0).Sexo)
            Dim EstadoCivil As String
            EstadoCivil = Convert.ToString(dict(0).EstadoCivil)
            Dim Nacionalidad As String
            Nacionalidad = Convert.ToString(dict(0).Nacionalidad)
            Dim NivelFormacion As String
            NivelFormacion = Convert.ToString(dict(0).NivelFormacion)
            Dim Cuil As String
            Cuil = Convert.ToString(dict(0).Cuil)
            Dim Email As String
            Email = Convert.ToString(dict(0).Email)
            Dim Archivo As String
            Archivo = Convert.ToString(dict(0).Imagen)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos

            ods = oObjeto.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            Dim ArchivoTipo As String = ""

            If Archivo = "" Then
                oObjeto.ModificarDatosPersonales(ID_PersonalLegajo, Apellido, Nombre, TipoDocumento, NroDocumento, NivelFormacion, EstadoCivil, FechaNacimiento, Nacionalidad, Sexo, Cuil)

                Dim data = New With {
                    Key .Status = "200"
                }

                Dim serializer = New JavaScriptSerializer()
                Dim json = serializer.Serialize(data)
                Return New JavaScriptSerializer().Serialize(data)
            Else
                'genero letra random para el nombre de la img
                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                Dim r As New Random
                Dim sb As New StringBuilder
                For i As Integer = 1 To 8
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                Dim letraRandom As String = sb.ToString

                Dim imagenfinal() As String
                Dim img As System.Drawing.Image

                'empiezo a convertir la img
                If Archivo <> Nothing Then
                    imagenfinal = Archivo.Split(",")
                    imagenfinal(1).ToString()

                    ArchivoTipo = imagenfinal(0)

                    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    Dim b64 As String = imagenfinal(1).ToString().Replace(" ", "+")
                    Dim b() As Byte

                    b = Convert.FromBase64String(b64)
                    MS = New System.IO.MemoryStream(b)
                    img = System.Drawing.Image.FromStream(MS)
                    If Archivo <> Nothing Then
                        Dim path__1 As [String] = HttpContext.Current.Server.MapPath("./ImagenesPersonal/")
                        If Not System.IO.Directory.Exists(path__1) Then
                            System.IO.Directory.CreateDirectory(path__1)
                        End If

                        Dim imageName As String = letraRandom & Convert.ToString(".png")

                        Dim imgPath As String = Path.Combine(path__1, imageName)

                        img.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg)

                        Dim oObjeto2 As New PersonalLegajos
                        Dim resultado As Integer
                        Dim imagenUrl As String = "http://coovilros.com/rrhh/ImagenesPersonal/" & imageName

                        oObjeto.ModificarDatosPersonales(ID_PersonalLegajo, Apellido, Nombre, TipoDocumento, NroDocumento, NivelFormacion, EstadoCivil, FechaNacimiento, Nacionalidad, Sexo, Cuil)
                        oObjeto2.ModificarFoto(ID_PersonalLegajo, imagenUrl)
                    End If

                    Dim data = New With {
                        Key .Status = "200"
                    }

                    Dim serializer = New JavaScriptSerializer()
                    Dim json = serializer.Serialize(data)

                    Return New JavaScriptSerializer().Serialize(data)

                Else
                    Return Error401("Error en el tipo de base 64")
                End If
            End If
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "DATOS DE CONTACTO Y REDES"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarDatosContacto(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of DatosContactoWs))("[" & cadena & "]")

            Dim Calle As String
            Calle = Convert.ToString(dict(0).Calle)
            Dim NroCalle As String
            NroCalle = Convert.ToString(dict(0).NroCalle)
            Dim Piso As String
            Piso = Convert.ToString(dict(0).Piso)
            Dim Depto As String
            Depto = Convert.ToString(dict(0).Depto)
            Dim TelefonoFijo As String
            TelefonoFijo = Convert.ToString(dict(0).TelefonoFijo)
            Dim TelefonoMovil As String
            TelefonoMovil = Convert.ToString(dict(0).TelefonoMovil)
            Dim Localidad As String
            Localidad = Convert.ToString(dict(0).Localidad)
            Dim Email As String
            Email = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New Redes

            Dim ods1 As New DataSet
            Dim oObjeto1 As New PersonalLegajos

            ods1 = oObjeto1.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods1.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods1.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods1.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            oObjeto1.ModificarDatosDeContacto(ID_PersonalLegajo, Calle, NroCalle, Piso, Depto, TelefonoFijo, TelefonoMovil, Localidad)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function AgregarRedes(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of RedesWs))("[" & cadena & "]")

            Dim Link As String
            Link = Convert.ToString(dict(0).Link)
            Dim ComboRedes As String
            ComboRedes = Convert.ToString(dict(0).ComboRedes)

            'Dim user = Membership.GetUser()
            Dim user = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New Redes

            Dim ods1 As New DataSet
            Dim oObjeto1 As New PersonalLegajos

            ods1 = oObjeto1.BuscarDatosDeUsuarioPorEmail(user)

            Dim ID_PersonalLegajo As Integer = ods1.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            Dim ID_Redes As Integer

            Dim Url As String = ""

            Select Case ComboRedes
                Case "FACEBOOK"
                    Url = "https://www.coovilros.com/RRHH/Imagenes/facebook.svg"
                Case "INSTAGRAM"
                    Url = "https://www.coovilros.com/RRHH/Imagenes/instagram.svg"
                Case "TWITTER"
                    Url = "https://www.coovilros.com/RRHH/Imagenes/twitter.svg"
                Case "YOUTUBE"
                    Url = "https://www.coovilros.com/RRHH/Imagenes/youtube.svg"
                Case Else

            End Select

            ID_Redes = oObjeto.Agregar(ID_PersonalLegajo, Link, ComboRedes, 1, Url)

            Dim data = New With {
                Key .Status = "200",
                Key .ID_Redes = ID_Redes
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function CargarRedes(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of RedesWs))("[" & cadena & "]")

            Dim username = Convert.ToString(dict(0).Email)

            Dim oRed As New Redes
            Dim ods As New DataSet

            'Dim userId As String = Membership.GetUser().UserName
            'Dim username As String = user

            ods = oRed.RedesSociales_BuscarPorEmail(username)

            Dim e As RedesWs() = New RedesWs(ods.Tables(0).Rows.Count - 1) {}

            For i = 0 To ods.Tables(0).Rows.Count - 1
                Dim ID_Redes As String = ods.Tables(0).Rows(i).Item("ID_Redes").ToString
                e(i) = New RedesWs()
                e(i).ID_Redes = ID_Redes
                e(i).Link = ods.Tables(0).Rows(i).Item("Link").ToString
                e(i).ComboRedes = ods.Tables(0).Rows(i).Item("Nombre").ToString
                e(i).Imagen = ods.Tables(0).Rows(i).Item("Imagen").ToString
            Next

            Dim data = New With {
                         Key .Status = "200",
                         Key .Data = e
                 }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EliminarRedes(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of RedesWs))("[" & cadena & "]")

            Dim ID_Redes As String
            ID_Redes = Convert.ToString(dict(0).ID_Redes)

            Dim ods As New DataSet
            Dim oObjeto As New Redes

            ods = oObjeto.Eliminar(ID_Redes)

            Dim data = New With {
                Key .Status = "200",
                Key .Data = New With {
                    Key .Mensaje = "Ok"
                }
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "REFERENCIAS LABORALES"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarReferenciasLaborales(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ReferenciasLaboralesWs))("[" & cadena & "]")

            Dim FechaDesde As String
            FechaDesde = Convert.ToString(dict(0).FechaDesde)
            Dim Activo As String
            Activo = Convert.ToBoolean(dict(0).Activo)
            Dim FechaHasta As String
            FechaHasta = Convert.ToString(dict(0).FechaHasta)
            Dim Empresa As String
            Empresa = Convert.ToString(dict(0).Empresa)
            Dim Puesto As String
            Puesto = Convert.ToString(dict(0).Puesto)
            Dim Area As String
            Area = Convert.ToString(dict(0).Area)
            Dim Descripcion As String
            Descripcion = Convert.ToString(dict(0).Descripcion)
            Dim DatosReferentes As String
            DatosReferentes = Convert.ToString(dict(0).DatosReferentes)
            Dim RefCoov As String
            RefCoov = Convert.ToString(dict(0).RefCoov)
            Dim SeccionCoov As String
            SeccionCoov = Convert.ToString(dict(0).SeccionCoov)
            Dim Email As String
            Email = Convert.ToString(dict(0).Email)

            Dim ods1 As New DataSet
            Dim oObjeto1 As New PersonalLegajos

            Dim ods2 As New DataSet
            Dim oObjeto2 As New SeccionTrabajar

            Dim act As Integer
            If Activo = True Then
                act = 1
            Else
                act = 0
            End If

            ods1 = oObjeto1.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods1.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods1.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods1.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            'buscar si ya han seleccionado seccion a la que le gustaria trabajar
            ods2 = oObjeto2.BuscarPorId_Legajo(ID_PersonalLegajo)
            If ods2.Tables(0).Rows.Count > 0 Then
            Else
                oObjeto2.Agregar(ID_PersonalLegajo, SeccionCoov)
            End If

            Dim ID_Resultado As Integer
            ID_Resultado = oObjeto1.Agregar_AntecedentesLaborales(ID_PersonalLegajo, FechaDesde, act, FechaHasta, Empresa, Puesto, Area, Descripcion, DatosReferentes, RefCoov)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function CargarRefLab(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ReferenciasLaboralesWs))("[" & cadena & "]")

            Dim username = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oobjeto As New PersonalLegajos

            ods = oobjeto.BuscarDatosDeUsuarioPorEmail(username)

            Dim e As ReferenciasLaboralesWs() = New ReferenciasLaboralesWs(ods.Tables(1).Rows.Count - 1) {}

            For i = 0 To ods.Tables(1).Rows.Count - 1
                e(i) = New ReferenciasLaboralesWs()
                e(i).ID = ods.Tables(1).Rows(i).Item("ID_Ant").ToString
                e(i).Area = ods.Tables(1).Rows(i).Item("Area").ToString
                e(i).Empresa = ods.Tables(1).Rows(i).Item("Empresa").ToString
                e(i).urlMod = ods.Tables(1).Rows(i).Item("urlEditar").ToString
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EliminarRefLab(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of ReferenciasLaboralesWs))("[" & cadena & "]")

            Dim ID_ReferenciaLaboral As String
            ID_ReferenciaLaboral = Convert.ToString(dict(0).ID)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos

            ods = oObjeto.AntecedentesLaborales_EliminarPorID(ID_ReferenciaLaboral)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "FORMACION ACADEMICA"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarFormacionAcademica(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            jss.MaxJsonLength = 900000000
            Dim dict = jss.Deserialize(Of List(Of FormacionAcademicaWs))("[" & cadena & "]")

            Dim FechaDesde As String = Convert.ToString(dict(0).FechaDesde)
            Dim FechaHasta As String = Convert.ToString(dict(0).FechaHasta)
            Dim NivelAcademico As String = Convert.ToString(dict(0).NivelAcademico)
            Dim Especialidad As String = Convert.ToString(dict(0).Especialidad)
            Dim Titulo As String = Convert.ToString(dict(0).Titulo)
            Dim Institucion As String = Convert.ToString(dict(0).Institucion)
            Dim Archivo As String = Convert.ToString(dict(0).Archivo)
            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos
            Dim oObjeto2 As New FormacionAcademica

            ods = oObjeto.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            Dim ArchivoTipo As String = ""

            'genero letra random para el nombre de la img
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 8
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next
            Dim letraRandom As String = sb.ToString

            Dim imagenfinal() As String
            Dim img As System.Drawing.Image

            'empiezo a convertir la img
            If Archivo <> Nothing Then
                imagenfinal = Archivo.Split(",")
                imagenfinal(1).ToString()

                ArchivoTipo = imagenfinal(0)

                If ArchivoTipo = "data:image/jpeg;base64" Or ArchivoTipo = "data:image/jpg;base64" Or ArchivoTipo = "data:image/png;base64" Then
                    Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
                    Dim b64 As String = imagenfinal(1).ToString().Replace(" ", "+")
                    Dim b() As Byte

                    b = Convert.FromBase64String(b64)
                    MS = New System.IO.MemoryStream(b)
                    img = System.Drawing.Image.FromStream(MS)
                    If Archivo <> Nothing Then
                        Dim path__1 As [String] = HttpContext.Current.Server.MapPath("./ArchivoAdjunto//")
                        If Not System.IO.Directory.Exists(path__1) Then
                            System.IO.Directory.CreateDirectory(path__1)
                        End If

                        Dim imageName As String = letraRandom & Convert.ToString(".png")

                        Dim imgPath As String = Path.Combine(path__1, imageName)

                        img.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg)

                        Dim resultado As Integer
                        Dim imagenUrl As String = "http://coovilros.com/rrhh/ArchivoAdjunto/" & imageName

                        oObjeto2.Agregar(ID_PersonalLegajo, FechaDesde, FechaHasta, NivelAcademico, Institucion, Titulo, imagenUrl, Especialidad)
                    End If

                ElseIf ArchivoTipo = "data:application/pdf;base64" Then
                    Dim path__1 As [String] = HttpContext.Current.Server.MapPath("./ArchivoAdjunto/")
                    If Not System.IO.Directory.Exists(path__1) Then
                        System.IO.Directory.CreateDirectory(path__1)
                    End If

                    Dim imageName As String = letraRandom & Convert.ToString(".pdf")

                    Dim imgPath As String = Path.Combine(path__1, imageName)

                    'aca convertir el base 64 a url absoluta
                    Dim fileContents As Byte() = Convert.FromBase64String(imagenfinal(1).ToString()), ruta As String = imgPath
                    Dim fs As IO.FileStream
                    fs = IO.File.Create(ruta)
                    fs.Write(fileContents, 0, fileContents.Length)
                    fs.Close()

                    Dim resultado As Integer
                    Dim imagenUrl As String = "http://coovilros.com/rrhh/ArchivoAdjunto/" & imageName

                    oObjeto2.Agregar(ID_PersonalLegajo, FechaDesde, FechaHasta, NivelAcademico, Institucion, Titulo, imagenUrl, Especialidad)
                End If

                Dim data = New With {
                    Key .Status = "200"
                }

                Dim serializer = New JavaScriptSerializer()
                serializer.MaxJsonLength = 900000000
                Dim json = serializer.Serialize(data)

                Return New JavaScriptSerializer().Serialize(data)

            Else
                Return Error401("Error en el tipo de base 64")
            End If

        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function CargarFormAcademica(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of FormacionAcademicaWs))("[" & cadena & "]")

            Dim username = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oobjeto As New PersonalLegajos

            ods = oobjeto.BuscarDatosDeUsuarioPorEmail(username)

            Dim e As FormacionAcademicaWs() = New FormacionAcademicaWs(ods.Tables(3).Rows.Count - 1) {}

            For i = 0 To ods.Tables(3).Rows.Count - 1
                e(i) = New FormacionAcademicaWs()
                e(i).ID = ods.Tables(3).Rows(i).Item("ID_FormacionAcademica").ToString
                e(i).Titulo = ods.Tables(3).Rows(i).Item("Título").ToString
                e(i).Institucion = ods.Tables(3).Rows(i).Item("Institución").ToString
                e(i).urlMod = ods.Tables(3).Rows(i).Item("urlEditar").ToString
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EliminarFormAcademica(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of FormacionAcademicaWs))("[" & cadena & "]")

            Dim ID_FormacionAcademica As String
            ID_FormacionAcademica = Convert.ToString(dict(0).ID)

            Dim ods As New DataSet
            Dim oObjeto As New FormacionAcademica

            ods = oObjeto.ElimiarPorId(ID_FormacionAcademica)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "GRUPO FAMILIAR"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarGrupoFamiliar(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of GrupoFamiliarWs))("[" & cadena & "]")

            Dim ApellidoGF As String = Convert.ToString(dict(0).Apellido)
            Dim NombreGF As String = Convert.ToString(dict(0).Nombre)
            Dim ID_Parentezco As String = Convert.ToString(dict(0).ID_Parentezco)
            Dim FechaNac As String = Convert.ToString(dict(0).FechaNac)
            Dim Ocupacion As String = Convert.ToString(dict(0).Ocupacion)
            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New Redes

            Dim ods1 As New DataSet
            Dim oObjeto1 As New PersonalLegajos

            ods1 = oObjeto1.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods1.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods1.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods1.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            oObjeto1.Agregar_GrupoFamiliar(ID_PersonalLegajo, ApellidoGF, NombreGF, ID_Parentezco, FechaNac, Ocupacion)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function CargarGrupoFam(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of GrupoFamiliarWs))("[" & cadena & "]")

            Dim username = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oobjeto As New PersonalLegajos

            ods = oobjeto.BuscarDatosDeUsuarioPorEmail(username)

            Dim e As GrupoFamiliarWs() = New GrupoFamiliarWs(ods.Tables(2).Rows.Count - 1) {}

            For i = 0 To ods.Tables(2).Rows.Count - 1
                e(i) = New GrupoFamiliarWs()
                e(i).ID_GrupoFamiliar = ods.Tables(2).Rows(i).Item("ID_PersonalLegajo_GrupoFamiliar").ToString
                e(i).Nombre = ods.Tables(2).Rows(i).Item("NombreApellido").ToString
                e(i).Parentezco = ods.Tables(2).Rows(i).Item("TipoFamiliar").ToString
                e(i).FechaNac = ods.Tables(2).Rows(i).Item("Nacimiento").ToString
                e(i).Ocupacion = ods.Tables(2).Rows(i).Item("Ocupacion").ToString
            Next

            Dim data = New With {
                         Key .Status = "200",
                         Key .Data = e
                 }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EliminarGrupoFam(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of GrupoFamiliarWs))("[" & cadena & "]")

            Dim ID_GrupoFamiliar As String
            ID_GrupoFamiliar = Convert.ToString(dict(0).ID_GrupoFamiliar)

            Dim ods As New DataSet
            Dim oObjeto As New PersonalLegajos

            ods = oObjeto.Eliminar_GrupoFamiliarPorId(ID_GrupoFamiliar)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "CURSOS"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarCurso(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of CursosWs))("[" & cadena & "]")

            Dim Desde As String = Convert.ToString(dict(0).Desde)
            Dim Hasta As String = Convert.ToString(dict(0).Hasta)
            Dim NombreCurso As String = Convert.ToString(dict(0).NombreCurso)
            Dim Areas As String = Convert.ToString(dict(0).Areas)
            Dim Horas As String = Convert.ToString(dict(0).Horas)
            Dim Institución As String = Convert.ToString(dict(0).Institución)
            Dim Comentarios As String = Convert.ToString(dict(0).Comentarios)
            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New Redes

            Dim ods1 As New DataSet
            Dim oObjeto1 As New PersonalLegajos
            Dim oObjeto2 As New Cursos

            ods1 = oObjeto1.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods1.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods1.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods1.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            oObjeto2.Agregar(ID_PersonalLegajo, Desde, Hasta, NombreCurso, Areas, Horas, Institución, Comentarios)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function CargarCurso(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of CursosWs))("[" & cadena & "]")

            Dim username = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oobjeto As New PersonalLegajos

            ods = oobjeto.BuscarDatosDeUsuarioPorEmail(username)

            Dim e As CursosWs() = New CursosWs(ods.Tables(4).Rows.Count - 1) {}

            For i = 0 To ods.Tables(4).Rows.Count - 1
                e(i) = New CursosWs()
                e(i).ID_Curso = ods.Tables(4).Rows(i).Item("ID_Curso").ToString
                e(i).Curso = ods.Tables(4).Rows(i).Item("Curso").ToString
                e(i).Institucion = ods.Tables(4).Rows(i).Item("Institución").ToString
                e(i).urlMod = ods.Tables(4).Rows(i).Item("urlEditar").ToString
            Next

            Dim data = New With {
                Key .Status = "200",
                Key .Data = e
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function

    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function EliminarCurso(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of CursosWs))("[" & cadena & "]")

            Dim ID_Curso As String
            ID_Curso = Convert.ToString(dict(0).ID_Curso)

            Dim ods As New DataSet
            Dim oObjeto As New Cursos

            ods = oObjeto.EliminarPorId(ID_Curso)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "ANTECEDENTE DE SALUD"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarAntecedente(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            Dim dict = jss.Deserialize(Of List(Of AntecedentesSaludWs))("[" & cadena & "]")

            Dim Altura As String = Convert.ToString(dict(0).Altura)
            Dim Peso As String = Convert.ToString(dict(0).Peso)
            Dim Enfermedad As String = Convert.ToString(dict(0).Enfermedad)
            Dim Tratamiento As String = Convert.ToString(dict(0).Tratamiento)
            Dim Cir As String = Convert.ToString(dict(0).Cir)
            Dim Cirujia As String = Convert.ToString(dict(0).Cirugia)
            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim oObjeto As New AntecedentesSalud

            Dim ods1 As New DataSet
            Dim oObjeto1 As New PersonalLegajos

            ods1 = oObjeto1.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods1.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods1.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods1.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            oObjeto.Agregar(ID_PersonalLegajo, Altura, Peso, Enfermedad, Tratamiento, Cir, Cirujia)

            Dim data = New With {
                Key .Status = "200"
            }

            Dim serializer = New JavaScriptSerializer()
            Dim json = serializer.Serialize(data)
            Return New JavaScriptSerializer().Serialize(data)
        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "CURRICULUM"
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json)>
    Public Shared Function GuardarCurriculum(ByVal cadena As String) As String
        Try

            Dim jss As New JavaScriptSerializer()
            jss.MaxJsonLength = 900000000
            Dim dict = jss.Deserialize(Of List(Of CurriculumWs))("[" & cadena & "]")

            Dim Archivo As String = Convert.ToString(dict(0).Archivo)
            Dim Email As String = Convert.ToString(dict(0).Email)

            Dim ods As New DataSet
            Dim ods2 As New DataSet
            Dim oObjeto As New PersonalLegajos
            Dim oObjeto2 As New Curriculum

            ods = oObjeto.BuscarDatosDeUsuarioPorEmail(Email)

            Dim Nombre As String = ods.Tables(0).Rows(0).Item("Nombre").ToString
            Dim Apellido As String = ods.Tables(0).Rows(0).Item("Apellido").ToString
            Dim ID_PersonalLegajo As Integer = ods.Tables(0).Rows(0).Item("ID_PersonalLegajo").ToString

            'busco para ver si existe lo modifico, si no lo agrego
            ods2 = oObjeto2.BuscarPorEmail(Email)

            Dim ArchivoTipo As String = ""
            'genero letra random para el nombre de la img
            Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
            Dim r As New Random
            Dim sb As New StringBuilder
            For i As Integer = 1 To 8
                Dim idx As Integer = r.Next(0, 35)
                sb.Append(s.Substring(idx, 1))
            Next
            Dim letraRandom As String = sb.ToString

            Dim imagenfinal() As String
            Dim img As System.Drawing.Image

            'empiezo a convertir la img
            If Archivo <> Nothing Then
                imagenfinal = Archivo.Split(",")
                imagenfinal(1).ToString()

                ArchivoTipo = imagenfinal(0)

                If ArchivoTipo = "data:application/pdf;base64" Then
                    Dim path__1 As [String] = HttpContext.Current.Server.MapPath("./ArchivoCurriculum/")
                    If Not System.IO.Directory.Exists(path__1) Then
                        System.IO.Directory.CreateDirectory(path__1)
                    End If

                    Dim archivoName As String = letraRandom & Convert.ToString(".pdf")

                    Dim archivoPath As String = Path.Combine(path__1, archivoName)

                    'aca convertir el base 64 a url absoluta
                    Dim fileContents As Byte() = Convert.FromBase64String(imagenfinal(1).ToString()), ruta As String = archivoPath
                    Dim fs As IO.FileStream
                    fs = IO.File.Create(ruta)
                    fs.Write(fileContents, 0, fileContents.Length)
                    fs.Close()

                    Dim archivoUrl As String = "http://coovilros.com/RRHHCV/ArchivoCurriculum/" & archivoName

                    If ods2.Tables(0).Rows.Count > 0 Then
                        oObjeto2.Modificar(ods2.Tables(0).Rows(0).Item("ID_Curriculum"), ID_PersonalLegajo, Email, archivoUrl)
                    Else
                        oObjeto2.Agregar(ID_PersonalLegajo, Email, archivoUrl)
                    End If

                End If

                Dim data = New With {
                    Key .Status = "200"
                }

                Dim serializer = New JavaScriptSerializer()
                serializer.MaxJsonLength = 900000000
                Dim json = serializer.Serialize(data)

                Return New JavaScriptSerializer().Serialize(data)

            Else
                Return Error401("No hay archivos seleccionados")
            End If

        Catch ex As Exception
            Return Error401()
        End Try
    End Function
#End Region

#Region "Manejo de Status"
    Public Shared Function Error401()

        Dim data = New With {
                         Key .Status = "401"
                     }
        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)

        Return New JavaScriptSerializer().Serialize(data)
    End Function

    Public Function Status200()
        Dim data = New With {
                   Key .Status = "200"}

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)

        Return New JavaScriptSerializer().Serialize(data)

    End Function

    Public Function ErrorLogin(ByVal Mensaje As String)
        Dim data = New With {
                     Key .Status = "401",
                     Key .Data = New With {
                     Key .Message = Mensaje
                   }
                 }

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)




        Return New JavaScriptSerializer().Serialize(data)
    End Function

    Private Function StatusReclamos(ByVal NroStatus As String, ByVal Mensaje As String)
        Dim data = New With {
                  Key .Status = NroStatus,
                  Key .Data = New With {
                  Key .Message = Mensaje
                }
              }

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)
        Return New JavaScriptSerializer().Serialize(data)
    End Function

    Private Function StatusCambioPAss(ByVal NroStatus As String, ByVal Mensaje As String)
        Dim data = New With {
                  Key .Status = NroStatus,
                  Key .Data = New With {
                  Key .Message = Mensaje
                }
              }

        Dim serializer = New JavaScriptSerializer()
        Dim json = serializer.Serialize(data)
        Return New JavaScriptSerializer().Serialize(data)
    End Function
#End Region

End Class