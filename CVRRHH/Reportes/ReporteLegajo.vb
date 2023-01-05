Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Web.Script.Serialization
Imports AD
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports Telerik.Web.UI.PivotGrid.Core

Partial Public Class ReporteLegajo
    Inherits Telerik.Reporting.Report
    Public Sub New(ID_PersonalLegajo)
        InitializeComponent()

        Dim oRecibo As New PersonalLegajos
        Dim ods As New DataSet

        ods = oRecibo.GenerarReporteLegajo(ID_PersonalLegajo)

        'If ods.Tables(0).Rows(0).Item("Foto").ToString() = "" Then

        'Else
        '    Dim imagenBD = ods.Tables(0).Rows(0).Item("Foto").ToString()
        '    Dim imgExt As String = ""

        '    Dim path__1 As [String] = HttpContext.Current.Server.MapPath("../ImagenesPersonal/")
        '    Dim img As String

        '    If imagenBD.Contains("Admin") Then
        '        If ods.Tables(0).Rows(0).Item("Foto").ToString().Length > 55 Then
        '            imgExt = Right(imagenBD, 12)
        '        Else
        '            imgExt = ID_PersonalLegajo + ".png"
        '        End If
        '        img = path__1 + imagenBD
        '    Else
        '        If ods.Tables(0).Rows(0).Item("Foto").ToString().Length > 50 Then
        '            imgExt = Right(imagenBD, 12)
        '        Else
        '            imgExt = ID_PersonalLegajo + ".png"
        '        End If
        '        img = path__1.Replace("Admin", "") + imagenBD
        '    End If

        '    imgEmpleado.Value = img 'ods.Tables(0).Rows(0).Item("Foto").ToString()
        'End If

        txtNombre.Value = ods.Tables(0).Rows(0).Item("Nombre").ToString()
        txtApellido.Value = ods.Tables(0).Rows(0).Item("Apellido").ToString()
        txtEmail.Value = ods.Tables(0).Rows(0).Item("Email").ToString()

        txtTipoDoc.Value = ods.Tables(0).Rows(0).Item("DocumentoTipo").ToString()
        txtNroDoc.Value = ods.Tables(0).Rows(0).Item("NroDocumento").ToString()
        txtCuit.Value = ods.Tables(0).Rows(0).Item("CUIL").ToString()
        txtSexo.Value = ods.Tables(0).Rows(0).Item("Sexo").ToString()
        txtNacionalidad.Value = ods.Tables(0).Rows(0).Item("Nacionalidad").ToString()
        txtLocalidad.Value = ods.Tables(0).Rows(0).Item("NombreLocalidad").ToString()
        txtCalle.Value = ods.Tables(0).Rows(0).Item("Calle").ToString()
        txtNroCalle.Value = ods.Tables(0).Rows(0).Item("Nro").ToString()
        txtPiso.Value = ods.Tables(0).Rows(0).Item("Piso").ToString()
        txtDepto.Value = ods.Tables(0).Rows(0).Item("Depto").ToString()
        txtCelular.Value = ods.Tables(0).Rows(0).Item("Movil").ToString()
        txtTelefono.Value = ods.Tables(0).Rows(0).Item("Telefono").ToString()
        txtFechaNac.Value = ods.Tables(0).Rows(0).Item("Nacimiento").ToString()
        txtEstadoCivil.Value = ods.Tables(0).Rows(0).Item("EstadoCivil").ToString()

        txtFechaIng.Value = ods.Tables(0).Rows(0).Item("Ingreso").ToString()
        'txtAnt.Value = ods.Tables(0).Rows(0).Item("MesesAntiguedadReconocida").ToString()
        txtConvenio.Value = ods.Tables(0).Rows(0).Item("Convenio").ToString()
        txtArt.Value = ods.Tables(0).Rows(0).Item("Articulo").ToString()
        txtNroAfiliado.Value = ods.Tables(0).Rows(0).Item("NroAfiliado").ToString()
        txtBanco.Value = ods.Tables(0).Rows(0).Item("Banco").ToString()
        txtNroCajaAhorro.Value = ods.Tables(0).Rows(0).Item("NroCajaAhorro").ToString()
        txtCategoria.Value = ods.Tables(0).Rows(0).Item("Categoria").ToString()
        txtSeccion.Value = ods.Tables(0).Rows(0).Item("Seccion").ToString()
        txtPuesto.Value = ods.Tables(0).Rows(0).Item("Puesto").ToString()
        'txtJefe.Value = ods.Tables(0).Rows(0).Item("Jefe").ToString()
        txtCargo.Value = ods.Tables(0).Rows(0).Item("Tipo").ToString()
        txtJubilado.Value = ods.Tables(0).Rows(0).Item("Jubilado").ToString()
        txtEstado.Value = ods.Tables(0).Rows(0).Item("Estado").ToString()
        txtNivelFormacion.Value = ods.Tables(0).Rows(0).Item("NivelFormacion").ToString()
        txtObservaciones.Value = ods.Tables(0).Rows(0).Item("Observaciones").ToString()

        'antiguedad
        Dim fechaIngresoBD As Date = ods.Tables(0).Rows(0).Item("Ingreso").ToString
        Dim fechaEgresoBD As Date = ods.Tables(0).Rows(0).Item("Egreso").ToString
        Dim ods2 As New DataSet
        ods2 = oRecibo.ObtenerAntiguedad(ID_PersonalLegajo, fechaIngresoBD.ToString("yyyy-MM-dd"), fechaEgresoBD.ToString("yyyy-MM-dd"))
        Dim Antiguedad = ods2.Tables(0).Rows(0).Item("Años") & " " & "Años" & " " & ods2.Tables(0).Rows(0).Item("Meses") & " " & "Meses" & " " & ods2.Tables(0).Rows(0).Item("Días") & " " & "Días"
        txtAnt.Value = Antiguedad.ToString()

        'jefe
        txtJefe.Value = ods.Tables(0).Rows(0).Item("Jefe").ToString()

    End Sub

    Public Shared Function ImageToByteArray(ByVal img As Image) As Byte()
        Using stream = New MemoryStream()
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
            Return stream.ToArray()
        End Using
    End Function

End Class
