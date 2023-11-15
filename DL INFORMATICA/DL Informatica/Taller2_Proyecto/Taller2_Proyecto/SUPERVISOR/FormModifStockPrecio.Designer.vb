<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModifStockPrecio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxARTICULOS = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPorCodigo = New System.Windows.Forms.Label()
        Me.lblPorDescripcion = New System.Windows.Forms.Label()
        Me.dtgPRODUCTOS = New System.Windows.Forms.DataGridView()
        Me.tbxBUSCACodigo = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.tbxBUSCADescripcion = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.cbxMARCA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCODIGO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPRECIO = New System.Windows.Forms.TextBox()
        Me.txtDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSTOCK = New System.Windows.Forms.TextBox()
        Me.gbxARTICULOS.SuspendLayout()
        CType(Me.dtgPRODUCTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxARTICULOS
        '
        Me.gbxARTICULOS.BackColor = System.Drawing.Color.Transparent
        Me.gbxARTICULOS.Controls.Add(Me.Label2)
        Me.gbxARTICULOS.Controls.Add(Me.lblPorCodigo)
        Me.gbxARTICULOS.Controls.Add(Me.lblPorDescripcion)
        Me.gbxARTICULOS.Controls.Add(Me.dtgPRODUCTOS)
        Me.gbxARTICULOS.Controls.Add(Me.tbxBUSCACodigo)
        Me.gbxARTICULOS.Controls.Add(Me.lblBuscar)
        Me.gbxARTICULOS.Controls.Add(Me.tbxBUSCADescripcion)
        Me.gbxARTICULOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxARTICULOS.ForeColor = System.Drawing.Color.Black
        Me.gbxARTICULOS.Location = New System.Drawing.Point(12, 365)
        Me.gbxARTICULOS.Name = "gbxARTICULOS"
        Me.gbxARTICULOS.Size = New System.Drawing.Size(1200, 293)
        Me.gbxARTICULOS.TabIndex = 70
        Me.gbxARTICULOS.TabStop = False
        Me.gbxARTICULOS.Text = "Lista de Productos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(214, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(668, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Para modificar Precio/Stock, haga doble clic en una fila de la lista y luego en e" &
    "l boton modificar"
        '
        'lblPorCodigo
        '
        Me.lblPorCodigo.AutoSize = True
        Me.lblPorCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblPorCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPorCodigo.Location = New System.Drawing.Point(433, 67)
        Me.lblPorCodigo.Name = "lblPorCodigo"
        Me.lblPorCodigo.Size = New System.Drawing.Size(86, 16)
        Me.lblPorCodigo.TabIndex = 55
        Me.lblPorCodigo.Text = "Por Código"
        '
        'lblPorDescripcion
        '
        Me.lblPorDescripcion.AutoSize = True
        Me.lblPorDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblPorDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPorDescripcion.Location = New System.Drawing.Point(231, 67)
        Me.lblPorDescripcion.Name = "lblPorDescripcion"
        Me.lblPorDescripcion.Size = New System.Drawing.Size(119, 16)
        Me.lblPorDescripcion.TabIndex = 54
        Me.lblPorDescripcion.Text = "Por Descripción"
        '
        'dtgPRODUCTOS
        '
        Me.dtgPRODUCTOS.AllowUserToAddRows = False
        Me.dtgPRODUCTOS.AllowUserToDeleteRows = False
        Me.dtgPRODUCTOS.AllowUserToResizeColumns = False
        Me.dtgPRODUCTOS.AllowUserToResizeRows = False
        Me.dtgPRODUCTOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgPRODUCTOS.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.dtgPRODUCTOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgPRODUCTOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPRODUCTOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPRODUCTOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgPRODUCTOS.Location = New System.Drawing.Point(6, 113)
        Me.dtgPRODUCTOS.MultiSelect = False
        Me.dtgPRODUCTOS.Name = "dtgPRODUCTOS"
        Me.dtgPRODUCTOS.ReadOnly = True
        Me.dtgPRODUCTOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgPRODUCTOS.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dtgPRODUCTOS.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgPRODUCTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPRODUCTOS.Size = New System.Drawing.Size(1174, 174)
        Me.dtgPRODUCTOS.TabIndex = 68
        '
        'tbxBUSCACodigo
        '
        Me.tbxBUSCACodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCACodigo.Location = New System.Drawing.Point(401, 43)
        Me.tbxBUSCACodigo.MaxLength = 8
        Me.tbxBUSCACodigo.Name = "tbxBUSCACodigo"
        Me.tbxBUSCACodigo.Size = New System.Drawing.Size(143, 21)
        Me.tbxBUSCACodigo.TabIndex = 50
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBuscar.Location = New System.Drawing.Point(81, 46)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(105, 16)
        Me.lblBuscar.TabIndex = 49
        Me.lblBuscar.Text = "Búsqueda por"
        '
        'tbxBUSCADescripcion
        '
        Me.tbxBUSCADescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCADescripcion.Location = New System.Drawing.Point(203, 43)
        Me.tbxBUSCADescripcion.MaxLength = 50
        Me.tbxBUSCADescripcion.Name = "tbxBUSCADescripcion"
        Me.tbxBUSCADescripcion.Size = New System.Drawing.Size(167, 21)
        Me.tbxBUSCADescripcion.TabIndex = 48
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1259, 40)
        Me.panel2.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(231, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(772, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Modificar Stock/Precio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1223, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'btnLIMPIAR
        '
        Me.btnLIMPIAR.BackColor = System.Drawing.Color.LimeGreen
        Me.btnLIMPIAR.Enabled = False
        Me.btnLIMPIAR.FlatAppearance.BorderSize = 0
        Me.btnLIMPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLIMPIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLIMPIAR.ForeColor = System.Drawing.Color.White
        Me.btnLIMPIAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.limpiar2
        Me.btnLIMPIAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLIMPIAR.Location = New System.Drawing.Point(575, 192)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(108, 39)
        Me.btnLIMPIAR.TabIndex = 87
        Me.btnLIMPIAR.Text = "      Limpiar"
        Me.btnLIMPIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(445, 658)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 29)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Lista de productos Activos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnModificar.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.icono_modificar
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.FlatAppearance.BorderSize = 0
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.White
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModificar.Location = New System.Drawing.Point(333, 34)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(153, 194)
        Me.BtnModificar.TabIndex = 89
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbxCategoria)
        Me.GroupBox1.Controls.Add(Me.cbxMARCA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.btnLIMPIAR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCODIGO)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPRECIO)
        Me.GroupBox1.Controls.Add(Me.txtDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSTOCK)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(288, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(689, 310)
        Me.GroupBox1.TabIndex = 94
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del producto"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.DisplayMember = "descripcion"
        Me.cbxCategoria.Enabled = False
        Me.cbxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(110, 121)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(158, 24)
        Me.cbxCategoria.TabIndex = 107
        Me.cbxCategoria.ValueMember = "id_categoria"
        '
        'cbxMARCA
        '
        Me.cbxMARCA.DisplayMember = "descripcion"
        Me.cbxMARCA.Enabled = False
        Me.cbxMARCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMARCA.FormattingEnabled = True
        Me.cbxMARCA.Location = New System.Drawing.Point(110, 151)
        Me.cbxMARCA.Name = "cbxMARCA"
        Me.cbxMARCA.Size = New System.Drawing.Size(158, 24)
        Me.cbxMARCA.TabIndex = 108
        Me.cbxMARCA.ValueMember = "id_marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 13)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "(Utilice la coma como punto decimal)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(41, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Código:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(34, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Precio: $"
        '
        'txtCODIGO
        '
        Me.txtCODIGO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCODIGO.Enabled = False
        Me.txtCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO.Location = New System.Drawing.Point(109, 35)
        Me.txtCODIGO.MaxLength = 8
        Me.txtCODIGO.Name = "txtCODIGO"
        Me.txtCODIGO.Size = New System.Drawing.Size(143, 22)
        Me.txtCODIGO.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(30, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "Categoría:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(15, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Descripción:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(55, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Marca:"
        '
        'txtPRECIO
        '
        Me.txtPRECIO.Enabled = False
        Me.txtPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRECIO.Location = New System.Drawing.Point(109, 209)
        Me.txtPRECIO.MaxLength = 6
        Me.txtPRECIO.Name = "txtPRECIO"
        Me.txtPRECIO.Size = New System.Drawing.Size(80, 22)
        Me.txtPRECIO.TabIndex = 99
        '
        'txtDESCRIPCION
        '
        Me.txtDESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESCRIPCION.Enabled = False
        Me.txtDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION.Location = New System.Drawing.Point(110, 63)
        Me.txtDESCRIPCION.MaxLength = 50
        Me.txtDESCRIPCION.Multiline = True
        Me.txtDESCRIPCION.Name = "txtDESCRIPCION"
        Me.txtDESCRIPCION.Size = New System.Drawing.Size(200, 52)
        Me.txtDESCRIPCION.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(55, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Stock:"
        '
        'txtSTOCK
        '
        Me.txtSTOCK.Enabled = False
        Me.txtSTOCK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTOCK.Location = New System.Drawing.Point(109, 181)
        Me.txtSTOCK.MaxLength = 8
        Me.txtSTOCK.Name = "txtSTOCK"
        Me.txtSTOCK.Size = New System.Drawing.Size(80, 22)
        Me.txtSTOCK.TabIndex = 98
        '
        'FormModifStockPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1259, 685)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.gbxARTICULOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormModifStockPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Stock/Precio"
        Me.gbxARTICULOS.ResumeLayout(False)
        Me.gbxARTICULOS.PerformLayout()
        CType(Me.dtgPRODUCTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxARTICULOS As GroupBox
    Friend WithEvents lblPorCodigo As Label
    Friend WithEvents lblPorDescripcion As Label
    Friend WithEvents dtgPRODUCTOS As DataGridView
    Friend WithEvents tbxBUSCACodigo As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents tbxBUSCADescripcion As TextBox
    Private WithEvents panel2 As Panel
    Private WithEvents Label1 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnModificar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCODIGO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDESCRIPCION As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPRECIO As TextBox
    Friend WithEvents txtSTOCK As TextBox
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents cbxMARCA As ComboBox
End Class
