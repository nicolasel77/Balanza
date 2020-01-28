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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstSucs = New System.Windows.Forms.ListBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdCrear = New System.Windows.Forms.Button()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmdOfertas = New System.Windows.Forms.Button()
        Me.grdPrecios = New Grilla2.SpeedGrilla()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscador = New System.Windows.Forms.TextBox()
        Me.lblBuscador = New System.Windows.Forms.Label()
        Me.grdVerPrecios = New Grilla2.SpeedGrilla()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cmdCargarPrecios = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.cmdMail = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.lstSucs.Size = New System.Drawing.Size(218, 720)
        Me.lstSucs.TabIndex = 1
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSalir.Location = New System.Drawing.Point(192, 782)
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
        Me.cmdCrear.Location = New System.Drawing.Point(111, 781)
        Me.cmdCrear.Name = "cmdCrear"
        Me.cmdCrear.Size = New System.Drawing.Size(75, 23)
        Me.cmdCrear.TabIndex = 3
        Me.cmdCrear.Text = "Crear"
        Me.cmdCrear.UseVisualStyleBackColor = False
        '
        'dtFecha
        '
        Me.dtFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(12, 781)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(93, 20)
        Me.dtFecha.TabIndex = 2
        '
        'cmdOfertas
        '
        Me.cmdOfertas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOfertas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOfertas.Location = New System.Drawing.Point(1267, 782)
        Me.cmdOfertas.Name = "cmdOfertas"
        Me.cmdOfertas.Size = New System.Drawing.Size(78, 23)
        Me.cmdOfertas.TabIndex = 11
        Me.cmdOfertas.Text = "Actualizar"
        Me.cmdOfertas.UseVisualStyleBackColor = True
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
        Me.grdPrecios.Size = New System.Drawing.Size(652, 760)
        Me.grdPrecios.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(1147, 782)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBuscador
        '
        Me.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscador.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtBuscador.Location = New System.Drawing.Point(0, 0)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(536, 13)
        Me.txtBuscador.TabIndex = 13
        '
        'lblBuscador
        '
        Me.lblBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBuscador.Location = New System.Drawing.Point(826, 787)
        Me.lblBuscador.Name = "lblBuscador"
        Me.lblBuscador.Size = New System.Drawing.Size(382, 18)
        Me.lblBuscador.TabIndex = 14
        '
        'grdVerPrecios
        '
        Me.grdVerPrecios.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdVerPrecios.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdVerPrecios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdVerPrecios.AutoResize = False
        Me.grdVerPrecios.bColor = System.Drawing.SystemColors.Window
        Me.grdVerPrecios.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdVerPrecios.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdVerPrecios.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdVerPrecios.Col = 0
        Me.grdVerPrecios.Cols = 10
        Me.grdVerPrecios.DataMember = ""
        Me.grdVerPrecios.DataSource = Nothing
        Me.grdVerPrecios.EnableEdicion = True
        Me.grdVerPrecios.Encabezado = ""
        Me.grdVerPrecios.fColor = System.Drawing.SystemColors.Control
        Me.grdVerPrecios.FixCols = 0
        Me.grdVerPrecios.FixRows = 0
        Me.grdVerPrecios.FuenteEncabezado = Nothing
        Me.grdVerPrecios.FuentePieDePagina = Nothing
        Me.grdVerPrecios.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdVerPrecios.Location = New System.Drawing.Point(3, 19)
        Me.grdVerPrecios.MenuActivado = False
        Me.grdVerPrecios.Name = "grdVerPrecios"
        Me.grdVerPrecios.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdVerPrecios.PintarFilaSel = True
        Me.grdVerPrecios.Redraw = True
        Me.grdVerPrecios.Row = 0
        Me.grdVerPrecios.Rows = 50
        Me.grdVerPrecios.Size = New System.Drawing.Size(530, 741)
        Me.grdVerPrecios.TabIndex = 15
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdEjecutar.Location = New System.Drawing.Point(1365, 782)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(67, 23)
        Me.cmdEjecutar.TabIndex = 11
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBuscador)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdVerPrecios)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdPrecios)
        Me.SplitContainer1.Size = New System.Drawing.Size(1196, 760)
        Me.SplitContainer1.SplitterDistance = 536
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 16
        '
        'cmdCargarPrecios
        '
        Me.cmdCargarPrecios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCargarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCargarPrecios.Location = New System.Drawing.Point(780, 782)
        Me.cmdCargarPrecios.Name = "cmdCargarPrecios"
        Me.cmdCargarPrecios.Size = New System.Drawing.Size(78, 23)
        Me.cmdCargarPrecios.TabIndex = 11
        Me.cmdCargarPrecios.Text = "Precios"
        Me.cmdCargarPrecios.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGuardar.Location = New System.Drawing.Point(864, 782)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(78, 23)
        Me.cmdGuardar.TabIndex = 11
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'cmdMail
        '
        Me.cmdMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdMail.Location = New System.Drawing.Point(273, 782)
        Me.cmdMail.Name = "cmdMail"
        Me.cmdMail.Size = New System.Drawing.Size(75, 23)
        Me.cmdMail.TabIndex = 4
        Me.cmdMail.Text = "Leer Mail"
        Me.cmdMail.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 813)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdCargarPrecios)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblBuscador)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.cmdOfertas)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.cmdCrear)
        Me.Controls.Add(Me.cmdMail)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.lstSucs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear archivo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstSucs As ListBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdCrear As Button
    Friend WithEvents dtFecha As DateTimePicker
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
    Friend WithEvents lblBuscador As Label
    Friend WithEvents grdVerPrecios As Grilla2.SpeedGrilla
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents cmdCargarPrecios As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents cmdMail As Button
End Class
