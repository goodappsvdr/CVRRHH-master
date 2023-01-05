Imports Telerik.Reporting

Partial Class ReporteLegajoPostulante

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteLegajoPostulante))
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource2 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource3 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource4 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource5 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource6 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim InstanceReportSource7 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.RptGrupoFamiliar1 = New CVRRHH.RptGrupoFamiliar()
        Me.RptCursos1 = New CVRRHH.RptCursos()
        Me.RptFormacionAcademica1 = New CVRRHH.RptFormacionAcademica()
        Me.RptAntecedenteLaboral1 = New CVRRHH.RptAntecedenteLaboral()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.txtObservaciones = New Telerik.Reporting.TextBox()
        Me.txtNivelFormacion = New Telerik.Reporting.TextBox()
        Me.txtEstado = New Telerik.Reporting.TextBox()
        Me.TextBox71 = New Telerik.Reporting.TextBox()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.TextBox73 = New Telerik.Reporting.TextBox()
        Me.PictureBox2 = New Telerik.Reporting.PictureBox()
        Me.PictureBox3 = New Telerik.Reporting.PictureBox()
        Me.PictureBox4 = New Telerik.Reporting.PictureBox()
        Me.PictureBox5 = New Telerik.Reporting.PictureBox()
        Me.subReport1 = New Telerik.Reporting.SubReport()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.ReportFooterSection1 = New Telerik.Reporting.ReportFooterSection()
        Me.SubReport3 = New Telerik.Reporting.SubReport()
        Me.SubReport4 = New Telerik.Reporting.SubReport()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.PictureBox6 = New Telerik.Reporting.PictureBox()
        Me.SubReport5 = New Telerik.Reporting.SubReport()
        Me.SubReport2 = New Telerik.Reporting.SubReport()
        Me.SubReport6 = New Telerik.Reporting.SubReport()
        Me.SubReport8 = New Telerik.Reporting.SubReport()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.txtFechaNac = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.txtCelular = New Telerik.Reporting.TextBox()
        Me.txtTelefono = New Telerik.Reporting.TextBox()
        Me.txtDepto = New Telerik.Reporting.TextBox()
        Me.txtPiso = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.txtCalle = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.txtNacionalidad = New Telerik.Reporting.TextBox()
        Me.txtLocalidad = New Telerik.Reporting.TextBox()
        Me.txtNroCalle = New Telerik.Reporting.TextBox()
        Me.txtSexo = New Telerik.Reporting.TextBox()
        Me.txtCuit = New Telerik.Reporting.TextBox()
        Me.txtNroDoc = New Telerik.Reporting.TextBox()
        Me.txtTipoDoc = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.txtEstadoCivil = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.imgEmpleado = New Telerik.Reporting.PictureBox()
        Me.Cont = New Telerik.Reporting.TextBox()
        Me.txtNombre = New Telerik.Reporting.TextBox()
        Me.txtApellido = New Telerik.Reporting.TextBox()
        Me.txtEmail = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        CType(Me.RptGrupoFamiliar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptCursos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptFormacionAcademica1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptAntecedenteLaboral1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'RptGrupoFamiliar1
        '
        Me.RptGrupoFamiliar1.Name = "RptGrupoFamiliar"
        '
        'RptCursos1
        '
        Me.RptCursos1.Name = "RptCursos1"
        '
        'RptFormacionAcademica1
        '
        Me.RptFormacionAcademica1.Name = "RptGrupoFamiliar"
        '
        'RptAntecedenteLaboral1
        '
        Me.RptAntecedenteLaboral1.Name = "RptGrupoFamiliar"
        '
        'detail
        '
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(7.1986513137817383R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtObservaciones, Me.txtNivelFormacion, Me.txtEstado, Me.TextBox71, Me.TextBox72, Me.TextBox73})
        Me.detail.Name = "detail"
        Me.detail.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704326629638672R), Telerik.Reporting.Drawing.Unit.Cm(0.98373353481292725R))
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtObservaciones.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtObservaciones.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtObservaciones.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtObservaciones.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtObservaciones.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtObservaciones.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtObservaciones.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtObservaciones.Style.Font.Bold = True
        Me.txtObservaciones.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtObservaciones.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtObservaciones.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtObservaciones.Value = "observaciones"
        '
        'txtNivelFormacion
        '
        Me.txtNivelFormacion.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6369872093200684R), Telerik.Reporting.Drawing.Unit.Cm(0.98373353481292725R))
        Me.txtNivelFormacion.Name = "txtNivelFormacion"
        Me.txtNivelFormacion.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtNivelFormacion.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNivelFormacion.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNivelFormacion.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNivelFormacion.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNivelFormacion.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNivelFormacion.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtNivelFormacion.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtNivelFormacion.Style.Font.Bold = True
        Me.txtNivelFormacion.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtNivelFormacion.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNivelFormacion.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNivelFormacion.Value = "nivel formacion"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57220423221588135R), Telerik.Reporting.Drawing.Unit.Cm(0.97915858030319214R))
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtEstado.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtEstado.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtEstado.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtEstado.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtEstado.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtEstado.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtEstado.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtEstado.Style.Font.Bold = True
        Me.txtEstado.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtEstado.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtEstado.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtEstado.Value = "estado"
        '
        'TextBox71
        '
        Me.TextBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704326629638672R), Telerik.Reporting.Drawing.Unit.Cm(0.42353355884552R))
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox71.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox71.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox71.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox71.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox71.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox71.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox71.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox71.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox71.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox71.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox71.Value = "OBSERVACIONES"
        '
        'TextBox72
        '
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6369872093200684R), Telerik.Reporting.Drawing.Unit.Cm(0.42353355884552R))
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox72.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox72.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox72.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox72.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox72.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox72.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox72.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox72.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox72.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox72.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox72.Value = "NIVEL DE FORMACIÓN"
        '
        'TextBox73
        '
        Me.TextBox73.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57220423221588135R), Telerik.Reporting.Drawing.Unit.Cm(0.41895857453346252R))
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox73.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox73.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox73.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox73.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox73.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox73.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox73.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox73.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox73.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox73.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox73.Value = "ESTADO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.99000000953674316R), Telerik.Reporting.Drawing.Unit.Cm(2.0154166221618652R))
        Me.PictureBox2.MimeType = "image/png"
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.159907341003418R), Telerik.Reporting.Drawing.Unit.Cm(1.7241666316986084R))
        Me.PictureBox2.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox2.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.PictureBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.800000011920929R)
        Me.PictureBox2.Style.Font.Name = "Verdana"
        Me.PictureBox2.Value = CType(resources.GetObject("PictureBox2.Value"), Object)
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.98827946186065674R), Telerik.Reporting.Drawing.Unit.Cm(5.00489616394043R))
        Me.PictureBox3.MimeType = "image/png"
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1600000858306885R), Telerik.Reporting.Drawing.Unit.Cm(1.7200000286102295R))
        Me.PictureBox3.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox3.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.PictureBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.800000011920929R)
        Me.PictureBox3.Style.Font.Name = "Verdana"
        Me.PictureBox3.Value = CType(resources.GetObject("PictureBox3.Value"), Object)
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.98827946186065674R), Telerik.Reporting.Drawing.Unit.Cm(8.9471874237060547R))
        Me.PictureBox4.MimeType = "image/png"
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1600000858306885R), Telerik.Reporting.Drawing.Unit.Cm(1.7200000286102295R))
        Me.PictureBox4.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox4.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox4.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.PictureBox4.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.800000011920929R)
        Me.PictureBox4.Style.Font.Name = "Verdana"
        Me.PictureBox4.Value = CType(resources.GetObject("PictureBox4.Value"), Object)
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.98827946186065674R), Telerik.Reporting.Drawing.Unit.Cm(12.863020896911621R))
        Me.PictureBox5.MimeType = "image/png"
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1600000858306885R), Telerik.Reporting.Drawing.Unit.Cm(1.7200000286102295R))
        Me.PictureBox5.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox5.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox5.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.PictureBox5.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.800000011920929R)
        Me.PictureBox5.Style.Font.Name = "Verdana"
        Me.PictureBox5.Value = CType(resources.GetObject("PictureBox5.Value"), Object)
        '
        'subReport1
        '
        Me.subReport1.Name = "subReport1"
        InstanceReportSource1.ReportDocument = Nothing
        Me.subReport1.ReportSource = InstanceReportSource1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1501076221466064R), Telerik.Reporting.Drawing.Unit.Cm(2.0109350681304932R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.847381591796875R), Telerik.Reporting.Drawing.Unit.Cm(1.7000000476837158R))
        Me.TextBox2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TextBox2.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox2.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox2.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox2.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox2.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox2.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "GRUPO FAMILIAR"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Conn2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ID_PersonalLegajo", System.Data.DbType.Int32, "=Parameters.ID_PersonalLegajo.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.PersonalLegajos_GenerarReporteNew"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'ReportFooterSection1
        '
        Me.ReportFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(17.075832366943359R)
        Me.ReportFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox5, Me.PictureBox3, Me.PictureBox4, Me.PictureBox2, Me.subReport1, Me.TextBox2, Me.SubReport3, Me.SubReport4, Me.TextBox3, Me.TextBox13, Me.TextBox9, Me.PictureBox6, Me.SubReport5, Me.SubReport2, Me.SubReport6, Me.SubReport8})
        Me.ReportFooterSection1.Name = "ReportFooterSection1"
        '
        'SubReport3
        '
        Me.SubReport3.Name = "SubReport3"
        InstanceReportSource2.ReportDocument = Nothing
        Me.SubReport3.ReportSource = InstanceReportSource2
        '
        'SubReport4
        '
        Me.SubReport4.Name = "SubReport4"
        InstanceReportSource3.ReportDocument = Nothing
        Me.SubReport4.ReportSource = InstanceReportSource3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.148479700088501R), Telerik.Reporting.Drawing.Unit.Cm(5.00489616394043R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.849008560180664R), Telerik.Reporting.Drawing.Unit.Cm(1.7000000476837158R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TextBox3.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox3.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox3.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox3.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox3.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "CURSOS"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.14847993850708R), Telerik.Reporting.Drawing.Unit.Cm(8.94719123840332R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.849006652832031R), Telerik.Reporting.Drawing.Unit.Cm(1.7000000476837158R))
        Me.TextBox13.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TextBox13.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox13.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox13.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox13.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox13.Style.Font.Bold = True
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox13.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox13.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "FORMACIÓN ACADÉMICA"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.14847993850708R), Telerik.Reporting.Drawing.Unit.Cm(12.863024711608887R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.851518630981445R), Telerik.Reporting.Drawing.Unit.Cm(1.7000000476837158R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TextBox9.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox9.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox9.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox9.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox9.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "ANTECEDENTES LABORALES"
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.086281776428223R), Telerik.Reporting.Drawing.Unit.Cm(0.39864328503608704R))
        Me.PictureBox6.MimeType = "image/png"
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9137187004089355R), Telerik.Reporting.Drawing.Unit.Cm(1.2152169942855835R))
        Me.PictureBox6.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox6.Style.Font.Name = "Verdana"
        Me.PictureBox6.Value = CType(resources.GetObject("PictureBox6.Value"), Object)
        '
        'SubReport5
        '
        Me.SubReport5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1501080989837646R), Telerik.Reporting.Drawing.Unit.Cm(3.8720746040344238R))
        Me.SubReport5.Name = "SubReport5"
        InstanceReportSource4.Parameters.Add(New Telerik.Reporting.Parameter("ID_PersonalLegajo", "=Parameters.ID_PersonalLegajo.Value"))
        InstanceReportSource4.ReportDocument = Me.RptGrupoFamiliar1
        Me.SubReport5.ReportSource = InstanceReportSource4
        Me.SubReport5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.853939056396484R), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209R))
        '
        'SubReport2
        '
        Me.SubReport2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1435482501983643R), Telerik.Reporting.Drawing.Unit.Cm(6.8638458251953125R))
        Me.SubReport2.Name = "SubReport2"
        InstanceReportSource5.Parameters.Add(New Telerik.Reporting.Parameter("ID_PersonalLegajo", "=Parameters.ID_PersonalLegajo.Value"))
        InstanceReportSource5.ReportDocument = Me.RptCursos1
        Me.SubReport2.ReportSource = InstanceReportSource5
        Me.SubReport2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.853939056396484R), Telerik.Reporting.Drawing.Unit.Cm(1.7731249332427979R))
        '
        'SubReport6
        '
        Me.SubReport6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1435482501983643R), Telerik.Reporting.Drawing.Unit.Cm(10.806140899658203R))
        Me.SubReport6.Name = "SubReport6"
        InstanceReportSource6.Parameters.Add(New Telerik.Reporting.Parameter("ID_PersonalLegajo", "=Parameters.ID_PersonalLegajo.Value"))
        InstanceReportSource6.ReportDocument = Me.RptFormacionAcademica1
        Me.SubReport6.ReportSource = InstanceReportSource6
        Me.SubReport6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.853939056396484R), Telerik.Reporting.Drawing.Unit.Cm(1.7731249332427979R))
        '
        'SubReport8
        '
        Me.SubReport8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1501080989837646R), Telerik.Reporting.Drawing.Unit.Cm(14.695515632629395R))
        Me.SubReport8.Name = "SubReport8"
        InstanceReportSource7.Parameters.Add(New Telerik.Reporting.Parameter("ID_PersonalLegajo", "=Parameters.ID_PersonalLegajo.Value"))
        InstanceReportSource7.ReportDocument = Me.RptAntecedenteLaboral1
        Me.SubReport8.ReportSource = InstanceReportSource7
        Me.SubReport8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(17.853939056396484R), Telerik.Reporting.Drawing.Unit.Cm(1.7731249332427979R))
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(12.656132698059082R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox36, Me.txtFechaNac, Me.TextBox33, Me.TextBox32, Me.txtCelular, Me.txtTelefono, Me.txtDepto, Me.txtPiso, Me.TextBox27, Me.TextBox26, Me.TextBox25, Me.TextBox16, Me.txtCalle, Me.TextBox22, Me.TextBox21, Me.TextBox20, Me.TextBox19, Me.txtNacionalidad, Me.txtLocalidad, Me.txtNroCalle, Me.txtSexo, Me.txtCuit, Me.txtNroDoc, Me.txtTipoDoc, Me.TextBox11, Me.TextBox10, Me.TextBox8, Me.txtEstadoCivil, Me.PictureBox1, Me.TextBox1, Me.imgEmpleado, Me.Cont, Me.txtNombre, Me.txtApellido, Me.txtEmail, Me.TextBox4, Me.TextBox6, Me.TextBox7})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        Me.ReportHeaderSection1.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.ReportHeaderSection1.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Cm(0R)
        '
        'TextBox36
        '
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(6.2178082466125488R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox36.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox36.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox36.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox36.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox36.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox36.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox36.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox36.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "TIPO DE DOCUMENTO"
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(11.668224334716797R))
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtFechaNac.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtFechaNac.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtFechaNac.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtFechaNac.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtFechaNac.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtFechaNac.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtFechaNac.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtFechaNac.Style.Font.Bold = True
        Me.txtFechaNac.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtFechaNac.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtFechaNac.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtFechaNac.Value = "fecha nac"
        '
        'TextBox33
        '
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(11.086141586303711R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox33.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox33.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox33.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox33.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox33.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox33.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox33.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox33.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "ESTADO CIVIL"
        '
        'TextBox32
        '
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(11.086141586303711R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox32.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox32.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox32.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox32.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox32.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox32.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox32.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "FECHA DE NACIMIENTO"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.769112586975098R), Telerik.Reporting.Drawing.Unit.Cm(10.001350402832031R))
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtCelular.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtCelular.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCelular.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCelular.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCelular.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCelular.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCelular.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtCelular.Style.Font.Bold = True
        Me.txtCelular.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtCelular.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCelular.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCelular.Value = "celular"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704328536987305R), Telerik.Reporting.Drawing.Unit.Cm(10.001350402832031R))
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtTelefono.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtTelefono.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtTelefono.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtTelefono.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtTelefono.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtTelefono.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtTelefono.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtTelefono.Style.Font.Bold = True
        Me.txtTelefono.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtTelefono.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtTelefono.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtTelefono.Value = "telefono"
        '
        'txtDepto
        '
        Me.txtDepto.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(10.001350402832031R))
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtDepto.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtDepto.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtDepto.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtDepto.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtDepto.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtDepto.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtDepto.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtDepto.Style.Font.Bold = True
        Me.txtDepto.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtDepto.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtDepto.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtDepto.Value = "depto"
        '
        'txtPiso
        '
        Me.txtPiso.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(10.001350402832031R))
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtPiso.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtPiso.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPiso.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPiso.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtPiso.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtPiso.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtPiso.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtPiso.Style.Font.Bold = True
        Me.txtPiso.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtPiso.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtPiso.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtPiso.Value = "piso"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.769112586975098R), Telerik.Reporting.Drawing.Unit.Cm(9.4192667007446289R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox27.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox27.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox27.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox27.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox27.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox27.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox27.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "CELULAR"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704328536987305R), Telerik.Reporting.Drawing.Unit.Cm(9.4192667007446289R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox26.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox26.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox26.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox26.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox26.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox26.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox26.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "TELÉFONO FIJO"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(9.4192667007446289R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox25.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox25.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox25.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox25.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox25.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox25.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox25.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "DEPTO. (DIR.)"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(9.4192667007446289R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox16.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox16.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox16.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox16.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox16.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox16.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox16.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "PISO (DIR.)"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704328536987305R), Telerik.Reporting.Drawing.Unit.Cm(8.3609333038330078R))
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtCalle.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtCalle.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCalle.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCalle.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCalle.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCalle.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCalle.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtCalle.Style.Font.Bold = True
        Me.txtCalle.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtCalle.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCalle.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCalle.Value = "calle"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(7.7788500785827637R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox22.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox22.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox22.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox22.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox22.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox22.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "NACIONALIDAD (DIR.)"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(7.7788500785827637R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox21.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox21.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox21.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox21.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox21.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox21.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Value = "LOCALIDAD (DIR.)"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704328536987305R), Telerik.Reporting.Drawing.Unit.Cm(7.7788500785827637R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox20.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox20.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox20.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox20.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox20.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox20.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Value = "CALLE (DIR.)"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.769112586975098R), Telerik.Reporting.Drawing.Unit.Cm(7.7788500785827637R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox19.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox19.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox19.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox19.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox19.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox19.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "NÚMERO (DIR.)"
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(8.3609333038330078R))
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtNacionalidad.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNacionalidad.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNacionalidad.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNacionalidad.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNacionalidad.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNacionalidad.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtNacionalidad.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtNacionalidad.Style.Font.Bold = True
        Me.txtNacionalidad.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtNacionalidad.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNacionalidad.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNacionalidad.Value = "nacionalidad"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(8.3609333038330078R))
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtLocalidad.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtLocalidad.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtLocalidad.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtLocalidad.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtLocalidad.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtLocalidad.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtLocalidad.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtLocalidad.Style.Font.Bold = True
        Me.txtLocalidad.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtLocalidad.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtLocalidad.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtLocalidad.Value = "localidad"
        '
        'txtNroCalle
        '
        Me.txtNroCalle.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.769112586975098R), Telerik.Reporting.Drawing.Unit.Cm(8.3609333038330078R))
        Me.txtNroCalle.Name = "txtNroCalle"
        Me.txtNroCalle.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtNroCalle.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNroCalle.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroCalle.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroCalle.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroCalle.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroCalle.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtNroCalle.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtNroCalle.Style.Font.Bold = True
        Me.txtNroCalle.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtNroCalle.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNroCalle.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNroCalle.Value = "numero calle"
        '
        'txtSexo
        '
        Me.txtSexo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.769112586975098R), Telerik.Reporting.Drawing.Unit.Cm(6.799891471862793R))
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtSexo.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtSexo.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSexo.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSexo.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtSexo.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtSexo.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtSexo.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtSexo.Style.Font.Bold = True
        Me.txtSexo.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtSexo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtSexo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtSexo.Value = "sexo"
        '
        'txtCuit
        '
        Me.txtCuit.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704328536987305R), Telerik.Reporting.Drawing.Unit.Cm(6.7780084609985352R))
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtCuit.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtCuit.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCuit.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCuit.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCuit.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCuit.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCuit.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtCuit.Style.Font.Bold = True
        Me.txtCuit.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtCuit.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCuit.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCuit.Value = "cuit"
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(6.799891471862793R))
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtNroDoc.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNroDoc.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroDoc.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroDoc.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroDoc.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroDoc.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtNroDoc.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtNroDoc.Style.Font.Bold = True
        Me.txtNroDoc.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtNroDoc.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNroDoc.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNroDoc.Value = "numero"
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.57476139068603516R), Telerik.Reporting.Drawing.Unit.Cm(6.799891471862793R))
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtTipoDoc.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtTipoDoc.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtTipoDoc.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtTipoDoc.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtTipoDoc.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtTipoDoc.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtTipoDoc.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtTipoDoc.Style.Font.Bold = True
        Me.txtTipoDoc.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtTipoDoc.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtTipoDoc.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtTipoDoc.Value = "tipo documento"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.769112586975098R), Telerik.Reporting.Drawing.Unit.Cm(6.2178082466125488R))
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox11.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox11.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox11.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox11.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox11.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.Value = "SEXO"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.704328536987305R), Telerik.Reporting.Drawing.Unit.Cm(6.2178082466125488R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox10.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox10.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox10.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox10.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox10.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox10.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.Value = "CUIT"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(6.2178082466125488R))
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox8.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox8.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox8.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox8.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox8.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "NÚMERO"
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.6395459175109863R), Telerik.Reporting.Drawing.Unit.Cm(11.668224334716797R))
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtEstadoCivil.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtEstadoCivil.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtEstadoCivil.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtEstadoCivil.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtEstadoCivil.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtEstadoCivil.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtEstadoCivil.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtEstadoCivil.Style.Font.Bold = True
        Me.txtEstadoCivil.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtEstadoCivil.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtEstadoCivil.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtEstadoCivil.Value = "estado civil"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.086181640625R), Telerik.Reporting.Drawing.Unit.Cm(0.44863539934158325R))
        Me.PictureBox1.MimeType = "image/png"
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.9137187004089355R), Telerik.Reporting.Drawing.Unit.Cm(1.2152169942855835R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.PictureBox1.Style.Font.Name = "Verdana"
        Me.PictureBox1.Value = CType(resources.GetObject("PictureBox1.Value"), Object)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.014110895805060864R), Telerik.Reporting.Drawing.Unit.Cm(3.5425920486450195R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.687815248966217R), Telerik.Reporting.Drawing.Unit.Cm(2.1814582347869873R))
        Me.TextBox1.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.TextBox1.Style.Color = System.Drawing.Color.White
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(35.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = ""
        '
        'imgEmpleado
        '
        Me.imgEmpleado.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.70202755928039551R), Telerik.Reporting.Drawing.Unit.Cm(2.1667587757110596R))
        Me.imgEmpleado.MimeType = "image/png"
        Me.imgEmpleado.Name = "imgEmpleado"
        Me.imgEmpleado.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4797544479370117R), Telerik.Reporting.Drawing.Unit.Cm(3.5572900772094727R))
        Me.imgEmpleado.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.imgEmpleado.Style.BorderWidth.Bottom = Telerik.Reporting.Drawing.Unit.Point(100.0R)
        Me.imgEmpleado.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(100.0R)
        Me.imgEmpleado.Style.BorderWidth.Left = Telerik.Reporting.Drawing.Unit.Point(100.0R)
        Me.imgEmpleado.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(100.0R)
        Me.imgEmpleado.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(100.0R)
        Me.imgEmpleado.Style.Font.Name = "Verdana"
        Me.imgEmpleado.Value = CType(resources.GetObject("imgEmpleado.Value"), Object)
        '
        'Cont
        '
        Me.Cont.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.1819820404052734R), Telerik.Reporting.Drawing.Unit.Cm(2.1667604446411133R))
        Me.Cont.Name = "Cont"
        Me.Cont.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.817916870117188R), Telerik.Reporting.Drawing.Unit.Cm(3.5572900772094727R))
        Me.Cont.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Cont.Style.Color = System.Drawing.Color.White
        Me.Cont.Style.Font.Bold = True
        Me.Cont.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.Cont.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(35.0R)
        Me.Cont.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.Cont.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.Cont.Value = ""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7624998092651367R), Telerik.Reporting.Drawing.Unit.Cm(3.2808332443237305R))
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.008333683013916R), Telerik.Reporting.Drawing.Unit.Cm(0.58819419145584106R))
        Me.txtNombre.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNombre.Style.Color = System.Drawing.Color.White
        Me.txtNombre.Style.Font.Bold = True
        Me.txtNombre.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.txtNombre.Style.LineColor = System.Drawing.Color.Yellow
        Me.txtNombre.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtNombre.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNombre.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNombre.Value = "nombre"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7624998092651367R), Telerik.Reporting.Drawing.Unit.Cm(4.7624998092651367R))
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.008333683013916R), Telerik.Reporting.Drawing.Unit.Cm(0.58819419145584106R))
        Me.txtApellido.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtApellido.Style.Color = System.Drawing.Color.White
        Me.txtApellido.Style.Font.Bold = True
        Me.txtApellido.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.txtApellido.Style.LineColor = System.Drawing.Color.Yellow
        Me.txtApellido.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtApellido.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtApellido.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtApellido.Value = "apellido"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.396610260009766R), Telerik.Reporting.Drawing.Unit.Cm(3.3072915077209473R))
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.1725006103515625R), Telerik.Reporting.Drawing.Unit.Cm(0.58819419145584106R))
        Me.txtEmail.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtEmail.Style.Color = System.Drawing.Color.White
        Me.txtEmail.Style.Font.Bold = True
        Me.txtEmail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        Me.txtEmail.Style.LineColor = System.Drawing.Color.Yellow
        Me.txtEmail.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.txtEmail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtEmail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtEmail.Value = "email"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7624998092651367R), Telerik.Reporting.Drawing.Unit.Cm(4.1539583206176758R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.008333683013916R), Telerik.Reporting.Drawing.Unit.Cm(0.58819419145584106R))
        Me.TextBox4.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox4.Style.Color = System.Drawing.Color.White
        Me.TextBox4.Style.Font.Bold = False
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox4.Style.LineColor = System.Drawing.Color.White
        Me.TextBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox4.Style.Visible = True
        Me.TextBox4.Value = "APELLIDO"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.7624998092651367R), Telerik.Reporting.Drawing.Unit.Cm(2.6987500190734863R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.008333683013916R), Telerik.Reporting.Drawing.Unit.Cm(0.58819419145584106R))
        Me.TextBox6.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox6.Style.Color = System.Drawing.Color.White
        Me.TextBox6.Style.Font.Bold = False
        Me.TextBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox6.Style.LineColor = System.Drawing.Color.White
        Me.TextBox6.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox6.Style.Visible = True
        Me.TextBox6.Value = "NOMBRE"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.396610260009766R), Telerik.Reporting.Drawing.Unit.Cm(2.6987500190734863R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.1725006103515625R), Telerik.Reporting.Drawing.Unit.Cm(0.58819419145584106R))
        Me.TextBox7.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox7.Style.Color = System.Drawing.Color.White
        Me.TextBox7.Style.Font.Bold = False
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox7.Style.LineColor = System.Drawing.Color.White
        Me.TextBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox7.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox7.Style.Visible = True
        Me.TextBox7.Value = "EMAIL"
        '
        'ReporteLegajoPostulante
        '
        Me.DataSource = Me.SqlDataSource1
        Me.DocumentName = ""
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.ReportHeaderSection1, Me.ReportFooterSection1})
        Me.Name = "ReporteLegajo"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.Name = "ID_PersonalLegajo"
        ReportParameter1.Text = "ID_PersonalLegajo"
        ReportParameter1.Type = Telerik.Reporting.ReportParameterType.[Integer]
        ReportParameter1.Value = "1"
        Me.ReportParameters.Add(ReportParameter1)
        Me.Style.BorderWidth.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(21.056962966918945R)
        CType(Me.RptGrupoFamiliar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptCursos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptFormacionAcademica1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptAntecedenteLaboral1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents PictureBox2 As Telerik.Reporting.PictureBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtNivelFormacion As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents TextBox71 As TextBox
    Friend WithEvents TextBox72 As TextBox
    Friend WithEvents TextBox73 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Private WithEvents subReport1 As SubReport
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ReportFooterSection1 As ReportFooterSection
    'Friend WithEvents RptGrupoFamiliar1 As RptGrupoFamiliar
    Private WithEvents SubReport3 As SubReport
    'Friend WithEvents RptAdelanto1 As RptAdelanto
    Private WithEvents SubReport4 As SubReport
    Friend WithEvents ReportHeaderSection1 As ReportHeaderSection
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDepto As TextBox
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents txtNacionalidad As TextBox
    Friend WithEvents txtLocalidad As TextBox
    Friend WithEvents txtNroCalle As TextBox
    Friend WithEvents txtSexo As TextBox
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents txtNroDoc As TextBox
    Friend WithEvents txtTipoDoc As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents txtEstadoCivil As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents imgEmpleado As PictureBox
    Friend WithEvents Cont As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    'Friend WithEvents RptRotaciones1 As RptRotaciones
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents PictureBox6 As PictureBox
    Private WithEvents SubReport5 As SubReport
    Friend WithEvents RptGrupoFamiliar1 As RptGrupoFamiliar
    Private WithEvents SubReport2 As SubReport
    Friend WithEvents RptCursos1 As RptCursos
    Private WithEvents SubReport6 As SubReport
    Friend WithEvents RptFormacionAcademica1 As RptFormacionAcademica
    Private WithEvents SubReport8 As SubReport
    Friend WithEvents RptAntecedenteLaboral1 As RptAntecedenteLaboral
End Class