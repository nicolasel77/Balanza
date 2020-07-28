<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSucs = New System.Windows.Forms.ListBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.cmdOfertas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grdOfertas = New Grilla2.SpeedGrilla()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdVerPrecios = New Grilla2.SpeedGrilla()
        Me.grdPrecios = New Grilla2.SpeedGrilla()
        Me.cmdCargarPrecios = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdMail = New System.Windows.Forms.Button()
        Me.lstRelleno = New System.Windows.Forms.ListBox()
        Me.tiMail = New System.Windows.Forms.Timer(Me.components)
        Me.chADB = New System.Windows.Forms.CheckBox()
        Me.chReloj = New System.Windows.Forms.CheckBox()
        Me.mntFecha = New System.Windows.Forms.MonthCalendar()
        Me.dtHora = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmdAgregaro = New System.Windows.Forms.Button()
        Me.txtSistema = New System.Windows.Forms.TextBox()
        Me.txtBalanza = New System.Windows.Forms.TextBox()
        Me.txtMulti = New System.Windows.Forms.TextBox()
        Me.chPesable = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New System.Windows.Forms.Button()
        Me.grdAlias = New Grilla2.SpeedGrilla()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstSucs
        '
        Me.lstSucs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstSucs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSucs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSucs.ForeColor = System.Drawing.Color.DimGray
        Me.lstSucs.FormattingEnabled = True
        Me.lstSucs.ItemHeight = 16
        Me.lstSucs.Location = New System.Drawing.Point(12, 35)
        Me.lstSucs.Name = "lstSucs"
        Me.lstSucs.Size = New System.Drawing.Size(218, 160)
        Me.lstSucs.TabIndex = 1
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(340, 647)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdCrear
        '
        Me.cmdCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdCrear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmdCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCrear.Location = New System.Drawing.Point(259, 646)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 23)
        Me.cmdCrear.TabIndex = 3
        Me.cmdCrear.Text = "Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'cmdOfertas
        '
        Me.cmdOfertas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOfertas.Location = New System.Drawing.Point(1055, 645)
        Me.cmdOfertas.Name = "cmdOfertas"
        Me.cmdOfertas.Size = New System.Drawing.Size(78, 23)
        Me.cmdOfertas.TabIndex = 11
        Me.cmdOfertas.Text = "Insertar"
        Me.cmdOfertas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(792, 647)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBuscador
        '
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscador.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBuscador.Location = New System.Drawing.Point(0, 0)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(440, 13)
        Me.txtBuscador.TabIndex = 0
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEjecutar.Location = New System.Drawing.Point(1153, 645)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(67, 23)
        Me.cmdEjecutar.TabIndex = 16
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(236, 9)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBuscador)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdPrecios)
        Me.SplitContainer1.Size = New System.Drawing.Size(984, 587)
        Me.SplitContainer1.SplitterDistance = 440
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 16
        '
        'grdOfertas
        '
        Me.grdOfertas.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdOfertas.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdOfertas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdOfertas.AutoResize = False
        Me.grdOfertas.bColor = System.Drawing.SystemColors.Window
        Me.grdOfertas.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdOfertas.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdOfertas.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdOfertas.Col = 0
        Me.grdOfertas.Cols = 10
        Me.grdOfertas.DataMember = ""
        Me.grdOfertas.DataSource = Nothing
        Me.grdOfertas.EnableEdicion = True
        Me.grdOfertas.Encabezado = ""
        Me.grdOfertas.fColor = System.Drawing.SystemColors.Control
        Me.grdOfertas.FixCols = 0
        Me.grdOfertas.FixRows = 0
        Me.grdOfertas.FuenteEncabezado = Nothing
        Me.grdOfertas.FuentePieDePagina = Nothing
        Me.grdOfertas.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdOfertas.Location = New System.Drawing.Point(3, 21)
        Me.grdOfertas.MenuActivado = False
        Me.grdOfertas.Name = "grdOfertas"
        Me.grdOfertas.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdOfertas.PintarFilaSel = True
        Me.grdOfertas.Redraw = True
        Me.grdOfertas.Row = -2
        Me.grdOfertas.Rows = 0
        Me.grdOfertas.Size = New System.Drawing.Size(434, 155)
        Me.grdOfertas.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Ofertas Cargadas"
        '
        'grdVerPrecios
        '
        Me.grdVerPrecios.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdVerPrecios.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdVerPrecios.AutoResize = False
        Me.grdVerPrecios.bColor = System.Drawing.SystemColors.Window
        Me.grdVerPrecios.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdVerPrecios.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdVerPrecios.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdVerPrecios.Col = 0
        Me.grdVerPrecios.Cols = 10
        Me.grdVerPrecios.DataMember = ""
        Me.grdVerPrecios.DataSource = Nothing
        Me.grdVerPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVerPrecios.EnableEdicion = True
        Me.grdVerPrecios.Encabezado = ""
        Me.grdVerPrecios.fColor = System.Drawing.SystemColors.Control
        Me.grdVerPrecios.FixCols = 0
        Me.grdVerPrecios.FixRows = 0
        Me.grdVerPrecios.FuenteEncabezado = Nothing
        Me.grdVerPrecios.FuentePieDePagina = Nothing
        Me.grdVerPrecios.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdVerPrecios.Location = New System.Drawing.Point(0, 0)
        Me.grdVerPrecios.MenuActivado = False
        Me.grdVerPrecios.Name = "grdVerPrecios"
        Me.grdVerPrecios.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdVerPrecios.PintarFilaSel = True
        Me.grdVerPrecios.Redraw = True
        Me.grdVerPrecios.Row = 0
        Me.grdVerPrecios.Rows = 50
        Me.grdVerPrecios.Size = New System.Drawing.Size(440, 293)
        Me.grdVerPrecios.TabIndex = 0
        '
        'grdPrecios
        '
        Me.grdPrecios.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdPrecios.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdPrecios.AutoResize = False
        Me.grdPrecios.bColor = System.Drawing.SystemColors.Window
        Me.grdPrecios.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdPrecios.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdPrecios.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdPrecios.Col = 0
        Me.grdPrecios.Cols = 10
        Me.grdPrecios.DataMember = ""
        Me.grdPrecios.DataSource = Nothing
        Me.grdPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPrecios.EnableEdicion = True
        Me.grdPrecios.Encabezado = ""
        Me.grdPrecios.fColor = System.Drawing.SystemColors.Control
        Me.grdPrecios.FixCols = 0
        Me.grdPrecios.FixRows = 0
        Me.grdPrecios.FuenteEncabezado = Nothing
        Me.grdPrecios.FuentePieDePagina = Nothing
        Me.grdPrecios.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdPrecios.Location = New System.Drawing.Point(0, 0)
        Me.grdPrecios.MenuActivado = False
        Me.grdPrecios.Name = "grdPrecios"
        Me.grdPrecios.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdPrecios.PintarFilaSel = True
        Me.grdPrecios.Redraw = True
        Me.grdPrecios.Row = 0
        Me.grdPrecios.Rows = 50
        Me.grdPrecios.Size = New System.Drawing.Size(536, 587)
        Me.grdPrecios.TabIndex = 0
        '
        'cmdCargarPrecios
        '
        Me.cmdCargarPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCargarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCargarPrecios.Location = New System.Drawing.Point(624, 647)
        Me.cmdCargarPrecios.Name = "cmdCargarPrecios"
        Me.cmdCargarPrecios.Size = New System.Drawing.Size(78, 23)
        Me.cmdCargarPrecios.TabIndex = 14
        Me.cmdCargarPrecios.Text = "Precios"
        Me.cmdCargarPrecios.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGuardar.Location = New System.Drawing.Point(708, 647)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(78, 23)
        Me.cmdGuardar.TabIndex = 15
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdMail
        '
        Me.cmdMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdMail.Location = New System.Drawing.Point(421, 647)
        Me.cmdMail.Name = "cmdMail"
        Me.cmdMail.Size = New System.Drawing.Size(75, 23)
        Me.cmdMail.TabIndex = 4
        Me.cmdMail.Text = "Leer Mail"
        Me.cmdMail.UseVisualStyleBackColor = True
        '
        'lstRelleno
        '
        Me.lstRelleno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstRelleno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstRelleno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRelleno.ForeColor = System.Drawing.Color.DimGray
        Me.lstRelleno.FormattingEnabled = True
        Me.lstRelleno.ItemHeight = 20
        Me.lstRelleno.Items.AddRange(New Object() {"OFERTA", "x 2kg", "x 3kg", "x 5kg", "x 10kg", "x 2", "x 3", "x 4", "x GANCHO", "x CAJA", "x PIEZA"})
        Me.lstRelleno.Location = New System.Drawing.Point(12, 201)
        Me.lstRelleno.Name = "lstRelleno"
        Me.lstRelleno.Size = New System.Drawing.Size(218, 240)
        Me.lstRelleno.TabIndex = 2
        '
        'tiMail
        '
        Me.tiMail.Enabled = True
        Me.tiMail.Interval = 50000
        '
        'chADB
        '
        Me.chADB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chADB.AutoSize = True
        Me.chADB.Checked = True
        Me.chADB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chADB.Location = New System.Drawing.Point(998, 650)
        Me.chADB.Name = "chADB"
        Me.chADB.Size = New System.Drawing.Size(51, 17)
        Me.chADB.TabIndex = 17
        Me.chADB.Text = "A DB"
        Me.chADB.UseVisualStyleBackColor = True
        '
        'chReloj
        '
        Me.chReloj.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chReloj.AutoSize = True
        Me.chReloj.Checked = True
        Me.chReloj.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chReloj.Location = New System.Drawing.Point(503, 653)
        Me.chReloj.Name = "chReloj"
        Me.chReloj.Size = New System.Drawing.Size(50, 17)
        Me.chReloj.TabIndex = 12
        Me.chReloj.Text = "Reloj"
        Me.chReloj.UseVisualStyleBackColor = True
        '
        'mntFecha
        '
        Me.mntFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.mntFecha.Location = New System.Drawing.Point(12, 453)
        Me.mntFecha.MaxSelectionCount = 1
        Me.mntFecha.Name = "mntFecha"
        Me.mntFecha.TabIndex = 3
        '
        'dtHora
        '
        Me.dtHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHora.Location = New System.Drawing.Point(20, 627)
        Me.dtHora.Name = "dtHora"
        Me.dtHora.Size = New System.Drawing.Size(122, 20)
        Me.dtHora.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(559, 647)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Reloj"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmdAgregaro
        '
        Me.cmdAgregaro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAgregaro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAgregaro.Location = New System.Drawing.Point(1066, 616)
        Me.cmdAgregaro.Name = "cmdAgregaro"
        Me.cmdAgregaro.Size = New System.Drawing.Size(67, 23)
        Me.cmdAgregaro.TabIndex = 5
        Me.cmdAgregaro.Text = "Agregar"
        Me.cmdAgregaro.UseVisualStyleBackColor = True
        '
        'txtSistema
        '
        Me.txtSistema.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSistema.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSistema.Location = New System.Drawing.Point(744, 624)
        Me.txtSistema.Name = "txtSistema"
        Me.txtSistema.Size = New System.Drawing.Size(74, 13)
        Me.txtSistema.TabIndex = 6
        '
        'txtBalanza
        '
        Me.txtBalanza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBalanza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBalanza.Location = New System.Drawing.Point(824, 624)
        Me.txtBalanza.Name = "txtBalanza"
        Me.txtBalanza.Size = New System.Drawing.Size(74, 13)
        Me.txtBalanza.TabIndex = 7
        '
        'txtMulti
        '
        Me.txtMulti.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMulti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMulti.Location = New System.Drawing.Point(904, 624)
        Me.txtMulti.Name = "txtMulti"
        Me.txtMulti.Size = New System.Drawing.Size(74, 13)
        Me.txtMulti.TabIndex = 8
        Me.txtMulti.Text = "1"
        '
        'chPesable
        '
        Me.chPesable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chPesable.AutoSize = True
        Me.chPesable.Checked = True
        Me.chPesable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chPesable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chPesable.Location = New System.Drawing.Point(984, 622)
        Me.chPesable.Name = "chPesable"
        Me.chPesable.Size = New System.Drawing.Size(62, 17)
        Me.chPesable.TabIndex = 9
        Me.chPesable.Text = "Pesable"
        Me.chPesable.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(741, 602)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Sistema"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(821, 602)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Balanza"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdActualizar.Location = New System.Drawing.Point(1153, 616)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(67, 23)
        Me.cmdActualizar.TabIndex = 5
        Me.cmdActualizar.Text = "Actualizar"
        Me.cmdActualizar.UseVisualStyleBackColor = True
        '
        'grdAlias
        '
        Me.grdAlias.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdAlias.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdAlias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdAlias.AutoResize = False
        Me.grdAlias.bColor = System.Drawing.SystemColors.Window
        Me.grdAlias.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdAlias.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdAlias.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdAlias.Col = 0
        Me.grdAlias.Cols = 10
        Me.grdAlias.DataMember = ""
        Me.grdAlias.DataSource = Nothing
        Me.grdAlias.EnableEdicion = True
        Me.grdAlias.Encabezado = ""
        Me.grdAlias.fColor = System.Drawing.SystemColors.Control
        Me.grdAlias.FixCols = 0
        Me.grdAlias.FixRows = 0
        Me.grdAlias.FuenteEncabezado = Nothing
        Me.grdAlias.FuentePieDePagina = Nothing
        Me.grdAlias.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdAlias.Location = New System.Drawing.Point(3, 19)
        Me.grdAlias.MenuActivado = False
        Me.grdAlias.Name = "grdAlias"
        Me.grdAlias.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdAlias.PintarFilaSel = True
        Me.grdAlias.Redraw = True
        Me.grdAlias.Row = -2
        Me.grdAlias.Rows = 0
        Me.grdAlias.Size = New System.Drawing.Size(428, 75)
        Me.grdAlias.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Alias Cargados"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grdVerPrecios)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grdAlias)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Size = New System.Drawing.Size(440, 391)
        Me.SplitContainer2.SplitterDistance = 293
        Me.SplitContainer2.TabIndex = 21
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 13)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer3.Panel2.Controls.Add(Me.grdOfertas)
        Me.SplitContainer3.Size = New System.Drawing.Size(440, 574)
        Me.SplitContainer3.SplitterDistance = 391
        Me.SplitContainer3.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 676)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chPesable)
        Me.Controls.Add(Me.txtMulti)
        Me.Controls.Add(Me.txtBalanza)
        Me.Controls.Add(Me.txtSistema)
        Me.Controls.Add(Me.dtHora)
        Me.Controls.Add(Me.mntFecha)
        Me.Controls.Add(Me.chReloj)
        Me.Controls.Add(Me.chADB)
        Me.Controls.Add(Me.cmdActualizar)
        Me.Controls.Add(Me.cmdAgregaro)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdCargarPrecios)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.cmdOfertas)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdMail)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.lstRelleno)
        Me.Controls.Add(Me.lstSucs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balanza"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSucs As ListBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdCrear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProd1 As TextBox
    Friend WithEvents cmdOfertas As Button
    Friend WithEvents txtPrecio1 As TextBox
    Friend WithEvents txtProd2 As TextBox
    Friend WithEvents txtPrecio2 As TextBox
    Friend WithEvents txtProd3 As TextBox
    Friend WithEvents txtPrecio3 As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents grdPrecios As Grilla2.SpeedGrilla
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBuscador As TextBox
    Friend WithEvents grdVerPrecios As Grilla2.SpeedGrilla
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdCargarPrecios As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdMail As Button
    Friend WithEvents lstRelleno As ListBox
    Friend WithEvents tiMail As Timer
    Friend WithEvents chADB As CheckBox
    Friend WithEvents chReloj As CheckBox
    Friend WithEvents mntFecha As MonthCalendar
    Friend WithEvents dtHora As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents cmdAgregaro As Button
    Friend WithEvents txtSistema As TextBox
    Friend WithEvents txtBalanza As TextBox
    Friend WithEvents txtMulti As TextBox
    Friend WithEvents chPesable As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grdOfertas As Grilla2.SpeedGrilla
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdActualizar As Button
    Friend WithEvents grdAlias As Grilla2.SpeedGrilla
    Friend WithEvents Label6 As Label
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
End Class
