Partial Class RptCursos

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.5000001192092896R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox3, Me.TextBox4, Me.TextBox2, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10})
        Me.detail.Name = "detail"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997995376586914R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox1.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Value = "Fecha hasta:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.50029969215393066R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997992992401123R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Value = "= Fields.Hasta"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Conn2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ID_PersonalLegajo", System.Data.DbType.Int32, "=Parameters.ID_PersonalLegajo.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.Cursos_GenerarReporte"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.50019979476928711R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997997760772705R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox4.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Value = "= Fields.Desde"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2000007629394531R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Value = "Fecha desde:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.50029969215393066R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox5.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox5.Value = "= Fields.NombreCurso"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997995376586914R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox6.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Value = "Nombre:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997995376586914R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox7.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Value = "Area:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.59999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.50029969215393066R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9999990463256836R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox8.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Value = "= Fields.Area"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(0.52424931526184082R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0000007152557373R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox9.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Value = "= Fields.Institucion"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.799999237060547R), Telerik.Reporting.Drawing.Unit.Cm(0.024049727246165276R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1997995376586914R), Telerik.Reporting.Drawing.Unit.Cm(0.4999997615814209R))
        Me.TextBox10.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.Value = "Institución:"
        '
        'RptCursos
        '
        Me.DataSource = Me.SqlDataSource1
        Me.DocumentName = ""
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail})
        Me.Name = "RptGrupoFamiliar"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Mm(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Mm(5.4000000953674316R), Telerik.Reporting.Drawing.Unit.Mm(5.4000000953674316R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "ID_PersonalLegajo"
        ReportParameter1.Text = "ID_PersonalLegajo"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "10"
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(14.899999618530273R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Private WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
End Class