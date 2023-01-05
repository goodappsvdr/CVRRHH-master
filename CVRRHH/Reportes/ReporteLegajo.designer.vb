Imports Telerik.Reporting

Partial Class ReporteLegajo

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteLegajo))
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.TextBox43 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox45 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.txtFechaIng = New Telerik.Reporting.TextBox()
        Me.txtAnt = New Telerik.Reporting.TextBox()
        Me.txtConvenio = New Telerik.Reporting.TextBox()
        Me.txtArt = New Telerik.Reporting.TextBox()
        Me.TextBox51 = New Telerik.Reporting.TextBox()
        Me.TextBox52 = New Telerik.Reporting.TextBox()
        Me.TextBox53 = New Telerik.Reporting.TextBox()
        Me.TextBox54 = New Telerik.Reporting.TextBox()
        Me.txtNroAfiliado = New Telerik.Reporting.TextBox()
        Me.txtBanco = New Telerik.Reporting.TextBox()
        Me.txtNroCajaAhorro = New Telerik.Reporting.TextBox()
        Me.txtCategoria = New Telerik.Reporting.TextBox()
        Me.TextBox59 = New Telerik.Reporting.TextBox()
        Me.TextBox60 = New Telerik.Reporting.TextBox()
        Me.TextBox61 = New Telerik.Reporting.TextBox()
        Me.TextBox62 = New Telerik.Reporting.TextBox()
        Me.txtSeccion = New Telerik.Reporting.TextBox()
        Me.txtPuesto = New Telerik.Reporting.TextBox()
        Me.txtJefe = New Telerik.Reporting.TextBox()
        Me.txtCargo = New Telerik.Reporting.TextBox()
        Me.txtObservaciones = New Telerik.Reporting.TextBox()
        Me.txtNivelFormacion = New Telerik.Reporting.TextBox()
        Me.txtEstado = New Telerik.Reporting.TextBox()
        Me.txtJubilado = New Telerik.Reporting.TextBox()
        Me.TextBox71 = New Telerik.Reporting.TextBox()
        Me.TextBox72 = New Telerik.Reporting.TextBox()
        Me.TextBox73 = New Telerik.Reporting.TextBox()
        Me.TextBox74 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
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
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(7.1986513137817383R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox43, Me.TextBox44, Me.TextBox45, Me.TextBox46, Me.txtFechaIng, Me.txtAnt, Me.txtConvenio, Me.txtArt, Me.TextBox51, Me.TextBox52, Me.TextBox53, Me.TextBox54, Me.txtNroAfiliado, Me.txtBanco, Me.txtNroCajaAhorro, Me.txtCategoria, Me.TextBox59, Me.TextBox60, Me.TextBox61, Me.TextBox62, Me.txtSeccion, Me.txtPuesto, Me.txtJefe, Me.txtCargo, Me.txtObservaciones, Me.txtNivelFormacion, Me.txtEstado, Me.txtJubilado, Me.TextBox71, Me.TextBox72, Me.TextBox73, Me.TextBox74})
        Me.detail.Name = "detail"
        Me.detail.Style.BackgroundColor = System.Drawing.Color.Empty
        Me.detail.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.detail.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox43
        '
        Me.TextBox43.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39697349071502686R), Telerik.Reporting.Drawing.Unit.Cm(0.47645023465156555R))
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox43.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox43.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox43.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox43.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox43.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox43.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox43.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox43.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox43.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox43.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox43.Value = "FECHA DE INGRESO"
        '
        'TextBox44
        '
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(0.47645023465156555R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox44.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox44.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox44.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox44.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox44.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox44.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox44.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox44.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox44.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox44.Value = "ANTIGÜEDAD"
        '
        'TextBox45
        '
        Me.TextBox45.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.52653980255127R), Telerik.Reporting.Drawing.Unit.Cm(0.47645023465156555R))
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox45.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox45.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox45.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox45.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox45.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox45.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox45.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox45.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox45.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox45.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox45.Value = "CONVENIO"
        '
        'TextBox46
        '
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.591326713562012R), Telerik.Reporting.Drawing.Unit.Cm(0.47645023465156555R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox46.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox46.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox46.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox46.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox46.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox46.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox46.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox46.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox46.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox46.Value = "ART"
        '
        'txtFechaIng
        '
        Me.txtFechaIng.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39697349071502686R), Telerik.Reporting.Drawing.Unit.Cm(1.0585335493087769R))
        Me.txtFechaIng.Name = "txtFechaIng"
        Me.txtFechaIng.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtFechaIng.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtFechaIng.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtFechaIng.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtFechaIng.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtFechaIng.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtFechaIng.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtFechaIng.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtFechaIng.Style.Font.Bold = True
        Me.txtFechaIng.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtFechaIng.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtFechaIng.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtFechaIng.Value = "fecha ingreso"
        '
        'txtAnt
        '
        Me.txtAnt.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(1.0585335493087769R))
        Me.txtAnt.Name = "txtAnt"
        Me.txtAnt.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtAnt.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtAnt.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtAnt.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtAnt.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtAnt.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtAnt.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtAnt.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtAnt.Style.Font.Bold = True
        Me.txtAnt.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtAnt.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtAnt.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtAnt.Value = "ant"
        '
        'txtConvenio
        '
        Me.txtConvenio.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.52653980255127R), Telerik.Reporting.Drawing.Unit.Cm(1.0631085634231567R))
        Me.txtConvenio.Name = "txtConvenio"
        Me.txtConvenio.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtConvenio.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtConvenio.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtConvenio.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtConvenio.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtConvenio.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtConvenio.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtConvenio.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtConvenio.Style.Font.Bold = True
        Me.txtConvenio.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtConvenio.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtConvenio.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtConvenio.Value = "convenio"
        '
        'txtArt
        '
        Me.txtArt.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.591324806213379R), Telerik.Reporting.Drawing.Unit.Cm(1.0366501808166504R))
        Me.txtArt.Name = "txtArt"
        Me.txtArt.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.58645832538604736R))
        Me.txtArt.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtArt.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtArt.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtArt.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtArt.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtArt.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtArt.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtArt.Style.Font.Bold = True
        Me.txtArt.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtArt.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtArt.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtArt.Value = "art"
        '
        'TextBox51
        '
        Me.TextBox51.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39697349071502686R), Telerik.Reporting.Drawing.Unit.Cm(2.1433250904083252R))
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox51.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox51.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox51.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox51.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox51.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox51.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox51.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox51.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox51.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox51.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox51.Value = "Nº DE AFILIADO"
        '
        'TextBox52
        '
        Me.TextBox52.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(2.1433250904083252R))
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox52.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox52.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox52.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox52.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox52.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox52.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox52.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox52.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox52.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox52.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox52.Value = "BANCO"
        '
        'TextBox53
        '
        Me.TextBox53.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.52653980255127R), Telerik.Reporting.Drawing.Unit.Cm(2.1433250904083252R))
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox53.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox53.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox53.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox53.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox53.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox53.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox53.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox53.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox53.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox53.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox53.Value = "Nº CAJA DE AHORRO"
        '
        'TextBox54
        '
        Me.TextBox54.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.591324806213379R), Telerik.Reporting.Drawing.Unit.Cm(2.1652085781097412R))
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox54.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox54.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox54.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox54.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox54.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox54.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox54.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox54.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox54.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox54.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox54.Value = "CETEGORÍA"
        '
        'txtNroAfiliado
        '
        Me.txtNroAfiliado.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39697349071502686R), Telerik.Reporting.Drawing.Unit.Cm(2.7254083156585693R))
        Me.txtNroAfiliado.Name = "txtNroAfiliado"
        Me.txtNroAfiliado.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtNroAfiliado.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNroAfiliado.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroAfiliado.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroAfiliado.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroAfiliado.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroAfiliado.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtNroAfiliado.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtNroAfiliado.Style.Font.Bold = True
        Me.txtNroAfiliado.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtNroAfiliado.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNroAfiliado.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNroAfiliado.Value = "n° afiliado"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(2.7254083156585693R))
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtBanco.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtBanco.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtBanco.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtBanco.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtBanco.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtBanco.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtBanco.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtBanco.Style.Font.Bold = True
        Me.txtBanco.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtBanco.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtBanco.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtBanco.Value = "banco"
        '
        'txtNroCajaAhorro
        '
        Me.txtNroCajaAhorro.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.52653980255127R), Telerik.Reporting.Drawing.Unit.Cm(2.7254083156585693R))
        Me.txtNroCajaAhorro.Name = "txtNroCajaAhorro"
        Me.txtNroCajaAhorro.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtNroCajaAhorro.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtNroCajaAhorro.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroCajaAhorro.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtNroCajaAhorro.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroCajaAhorro.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtNroCajaAhorro.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtNroCajaAhorro.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtNroCajaAhorro.Style.Font.Bold = True
        Me.txtNroCajaAhorro.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtNroCajaAhorro.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtNroCajaAhorro.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtNroCajaAhorro.Value = "n° caja de ahorro"
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.591326713562012R), Telerik.Reporting.Drawing.Unit.Cm(2.7254083156585693R))
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtCategoria.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtCategoria.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCategoria.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCategoria.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCategoria.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCategoria.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCategoria.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtCategoria.Style.Font.Bold = True
        Me.txtCategoria.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtCategoria.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCategoria.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCategoria.Value = "categoria"
        '
        'TextBox59
        '
        Me.TextBox59.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39707523584365845R), Telerik.Reporting.Drawing.Unit.Cm(3.8366584777832031R))
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox59.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox59.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox59.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox59.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox59.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox59.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox59.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox59.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox59.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox59.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox59.Value = "SECCIÓN/ÁREA"
        '
        'TextBox60
        '
        Me.TextBox60.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(3.8366584777832031R))
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox60.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox60.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox60.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox60.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox60.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox60.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox60.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox60.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox60.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox60.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox60.Value = "PUESTO"
        '
        'TextBox61
        '
        Me.TextBox61.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.557074546813965R), Telerik.Reporting.Drawing.Unit.Cm(3.8366584777832031R))
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox61.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox61.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox61.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox61.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox61.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox61.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox61.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox61.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox61.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox61.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox61.Value = "JEFE"
        '
        'TextBox62
        '
        Me.TextBox62.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.63707447052002R), Telerik.Reporting.Drawing.Unit.Cm(3.8366584777832031R))
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox62.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox62.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox62.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox62.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox62.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox62.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox62.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox62.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox62.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox62.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox62.Value = "CARGO"
        '
        'txtSeccion
        '
        Me.txtSeccion.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39697349071502686R), Telerik.Reporting.Drawing.Unit.Cm(4.4187407493591309R))
        Me.txtSeccion.Name = "txtSeccion"
        Me.txtSeccion.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtSeccion.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtSeccion.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSeccion.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtSeccion.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtSeccion.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtSeccion.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtSeccion.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtSeccion.Style.Font.Bold = True
        Me.txtSeccion.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtSeccion.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtSeccion.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtSeccion.Value = "seccion"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4770755767822266R), Telerik.Reporting.Drawing.Unit.Cm(4.4187407493591309R))
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8152155876159668R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtPuesto.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtPuesto.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPuesto.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtPuesto.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtPuesto.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtPuesto.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtPuesto.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtPuesto.Style.Font.Bold = True
        Me.txtPuesto.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtPuesto.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtPuesto.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtPuesto.Value = "puesto"
        '
        'txtJefe
        '
        Me.txtJefe.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.557074546813965R), Telerik.Reporting.Drawing.Unit.Cm(4.4187407493591309R))
        Me.txtJefe.Name = "txtJefe"
        Me.txtJefe.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtJefe.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtJefe.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtJefe.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtJefe.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtJefe.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtJefe.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtJefe.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtJefe.Style.Font.Bold = True
        Me.txtJefe.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtJefe.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtJefe.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtJefe.Value = "Jefe"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.63707447052002R), Telerik.Reporting.Drawing.Unit.Cm(4.4187407493591309R))
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.txtCargo.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtCargo.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCargo.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtCargo.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCargo.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtCargo.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtCargo.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtCargo.Style.Font.Bold = True
        Me.txtCargo.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtCargo.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtCargo.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtCargo.Value = "cargo"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.593879699707031R), Telerik.Reporting.Drawing.Unit.Cm(6.0372748374938965R))
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
        Me.txtNivelFormacion.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.52653980255127R), Telerik.Reporting.Drawing.Unit.Cm(6.0372748374938965R))
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
        Me.txtEstado.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(6.0327000617980957R))
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
        'txtJubilado
        '
        Me.txtJubilado.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39707523584365845R), Telerik.Reporting.Drawing.Unit.Cm(6.0591583251953125R))
        Me.txtJubilado.Name = "txtJubilado"
        Me.txtJubilado.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.53354167938232422R))
        Me.txtJubilado.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.txtJubilado.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtJubilado.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtJubilado.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.txtJubilado.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.txtJubilado.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.txtJubilado.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.txtJubilado.Style.Font.Bold = True
        Me.txtJubilado.Style.LineColor = System.Drawing.Color.Transparent
        Me.txtJubilado.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.txtJubilado.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtJubilado.Value = "jubilado"
        '
        'TextBox71
        '
        Me.TextBox71.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.593879699707031R), Telerik.Reporting.Drawing.Unit.Cm(5.4770750999450684R))
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
        Me.TextBox72.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.52653980255127R), Telerik.Reporting.Drawing.Unit.Cm(5.4770750999450684R))
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
        Me.TextBox73.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.4617571830749512R), Telerik.Reporting.Drawing.Unit.Cm(5.4725003242492676R))
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
        'TextBox74
        '
        Me.TextBox74.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.39707523584365845R), Telerik.Reporting.Drawing.Unit.Cm(5.4770750999450684R))
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R), Telerik.Reporting.Drawing.Unit.Cm(0.56000000238418579R))
        Me.TextBox74.Style.BorderColor.Default = System.Drawing.Color.Transparent
        Me.TextBox74.Style.BorderColor.Left = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox74.Style.BorderColor.Right = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBox74.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox74.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox74.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.TextBox74.Style.Color = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TextBox74.Style.LineColor = System.Drawing.Color.Transparent
        Me.TextBox74.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox74.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox74.Value = "JUBILADO"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Conn2"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@ID_PersonalLegajo", System.Data.DbType.Int32, "=Parameters.ID_PersonalLegajo.Value")})
        Me.SqlDataSource1.SelectCommand = "dbo.PersonalLegajos_GenerarReporteNew"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
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
        'ReporteLegajo
        '
        Me.DataSource = Me.SqlDataSource1
        Me.DocumentName = ""
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.ReportHeaderSection1})
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(21.081794738769531R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents TextBox46 As TextBox
    Friend WithEvents txtFechaIng As TextBox
    Friend WithEvents txtAnt As TextBox
    Friend WithEvents txtConvenio As TextBox
    Friend WithEvents txtArt As TextBox
    Friend WithEvents TextBox51 As TextBox
    Friend WithEvents TextBox52 As TextBox
    Friend WithEvents TextBox53 As TextBox
    Friend WithEvents TextBox54 As TextBox
    Friend WithEvents txtNroAfiliado As TextBox
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents txtNroCajaAhorro As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents TextBox59 As TextBox
    Friend WithEvents TextBox60 As TextBox
    Friend WithEvents TextBox61 As TextBox
    Friend WithEvents TextBox62 As TextBox
    Friend WithEvents txtSeccion As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtJefe As TextBox
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtNivelFormacion As TextBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents txtJubilado As TextBox
    Friend WithEvents TextBox71 As TextBox
    Friend WithEvents TextBox72 As TextBox
    Friend WithEvents TextBox73 As TextBox
    Friend WithEvents TextBox74 As TextBox
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
End Class