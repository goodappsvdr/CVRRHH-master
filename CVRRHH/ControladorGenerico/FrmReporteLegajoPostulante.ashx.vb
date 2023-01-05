Imports System.Web
Imports System.Web.Services
Imports Telerik.Reporting
Imports Telerik.Reporting.Processing

Public Class FrmReporteLegajoPostulante
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim ID As String = context.Request.QueryString("ID")
        ExportToPDF(New ReporteLegajoPostulante(ID), context, ID)

    End Sub

    Sub ExportToPDF(ByVal reportToExport As Telerik.Reporting.Report, context As HttpContext, ByVal ID As String)

        Dim reportProcessor As New ReportProcessor()
        Dim instanceReportSource As New InstanceReportSource()
        instanceReportSource.Parameters.Add("ID_PersonalLegajo", ID)
        instanceReportSource.ReportDocument = reportToExport
        Dim result As RenderingResult = reportProcessor.RenderReport("PDF", instanceReportSource, Nothing)

        Dim fileName As String = result.DocumentName + "." + result.Extension
        context.Response.Clear()
        context.Response.ContentType = result.MimeType
        context.Response.Cache.SetCacheability(HttpCacheability.Private)
        context.Response.Expires = -1
        context.Response.Buffer = True

        'SI COMENTO ACA CREA SIN DESCARGAR
        'context.Response.AddHeader("Content-Disposition", String.Format("{0};FileName=""{1}""", "attachment", fileName))

        context.Response.BinaryWrite(result.DocumentBytes)
        context.Response.AddHeader("FileName", ID)
        context.Response.End()

    End Sub

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class