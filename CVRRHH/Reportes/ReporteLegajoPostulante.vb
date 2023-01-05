Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Web.Script.Serialization
Imports AD
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.Web.UI.PivotGrid.Core

Partial Public Class ReporteLegajoPostulante
    Inherits Telerik.Reporting.Report
    Public Sub New(ID_PersonalLegajo)
        InitializeComponent()

        Dim oRecibo As New PersonalLegajos
        Dim ods As New DataSet

        ods = oRecibo.GenerarReporteLegajo(ID_PersonalLegajo)

        If ods.Tables(1).Rows(0).Item("Foto").ToString() = "" Then

        Else
            Dim imagenBD = ods.Tables(1).Rows(0).Item("Foto").ToString()
            Dim imgExt As String = ""

            Dim path__1 As [String] = HttpContext.Current.Server.MapPath("../ImagenesPersonal/")
            Dim img As String

            If ods.Tables(1).Rows(0).Item("Foto").ToString().Length > 52 Then
                imgExt = Right(imagenBD, 11)
            Else
                imgExt = ID_PersonalLegajo + ".png"
            End If
            img = path__1 + imgExt

            imgEmpleado.Value = img
        End If

        txtNombre.Value = ods.Tables(1).Rows(0).Item("Nombre").ToString()
        txtApellido.Value = ods.Tables(1).Rows(0).Item("Apellido").ToString()
        txtEmail.Value = ods.Tables(1).Rows(0).Item("Email").ToString()

        txtTipoDoc.Value = ods.Tables(1).Rows(0).Item("DocumentoTipo").ToString()
        txtNroDoc.Value = ods.Tables(1).Rows(0).Item("NroDocumento").ToString()
        txtCuit.Value = ods.Tables(1).Rows(0).Item("CUIL").ToString()
        txtSexo.Value = ods.Tables(1).Rows(0).Item("Sexo").ToString()
        txtNacionalidad.Value = ods.Tables(1).Rows(0).Item("Nacionalidad").ToString()
        txtLocalidad.Value = ods.Tables(1).Rows(0).Item("NombreLocalidad").ToString()
        txtCalle.Value = ods.Tables(1).Rows(0).Item("Calle").ToString()
        txtNroCalle.Value = ods.Tables(1).Rows(0).Item("Nro").ToString()
        txtPiso.Value = ods.Tables(1).Rows(0).Item("Piso").ToString()
        txtDepto.Value = ods.Tables(1).Rows(0).Item("Depto").ToString()
        txtCelular.Value = ods.Tables(1).Rows(0).Item("Movil").ToString()
        txtTelefono.Value = ods.Tables(1).Rows(0).Item("Telefono").ToString()
        txtFechaNac.Value = ods.Tables(1).Rows(0).Item("Nacimiento").ToString()
        txtEstadoCivil.Value = ods.Tables(1).Rows(0).Item("EstadoCivil").ToString()
        txtEstado.Value = ods.Tables(1).Rows(0).Item("Estado").ToString()
        txtNivelFormacion.Value = ods.Tables(1).Rows(0).Item("NivelFormacion").ToString()
        txtObservaciones.Value = ods.Tables(1).Rows(0).Item("Observaciones").ToString()

    End Sub

    Public Shared Function ImageToByteArray(ByVal img As Image) As Byte()
        Using stream = New MemoryStream()
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
            Return stream.ToArray()
        End Using
    End Function

End Class
