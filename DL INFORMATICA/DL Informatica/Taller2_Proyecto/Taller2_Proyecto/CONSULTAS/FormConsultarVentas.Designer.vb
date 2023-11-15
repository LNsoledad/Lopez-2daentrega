<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultarVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgLISTAFACTURAS = New System.Windows.Forms.DataGridView()
        Me.NumFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteApeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniempleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorApeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorNomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Taller2_Proyecto.DataSetProyecto()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBfecha = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBUSCAR_FECHA = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.RBdniVendedor = New System.Windows.Forms.RadioButton()
        Me.RBdniCliente = New System.Windows.Forms.RadioButton()
        Me.RBNumFact = New System.Windows.Forms.RadioButton()
        Me.txt_BuscarDniVendedor = New System.Windows.Forms.TextBox()
        Me.txt_BucarDniCliente = New System.Windows.Forms.TextBox()
        Me.txt_BuscaFact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.VerFacturasTableAdapter = New Taller2_Proyecto.DataSetProyectoTableAdapters.VerFacturasTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtgLISTAFACTURAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgLISTAFACTURAS
        '
        Me.dtgLISTAFACTURAS.AllowUserToAddRows = False
        Me.dtgLISTAFACTURAS.AllowUserToDeleteRows = False
        Me.dtgLISTAFACTURAS.AllowUserToResizeColumns = False
        Me.dtgLISTAFACTURAS.AllowUserToResizeRows = False
        Me.dtgLISTAFACTURAS.AutoGenerateColumns = False
        Me.dtgLISTAFACTURAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgLISTAFACTURAS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgLISTAFACTURAS.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.dtgLISTAFACTURAS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgLISTAFACTURAS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLISTAFACTURAS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgLISTAFACTURAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLISTAFACTURAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ClienteDniDataGridViewTextBoxColumn, Me.ClienteApeDataGridViewTextBoxColumn, Me.ClienteNomDataGridViewTextBoxColumn, Me.DniempleadoDataGridViewTextBoxColumn, Me.VendedorApeDataGridViewTextBoxColumn, Me.VendedorNomDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dtgLISTAFACTURAS.DataSource = Me.VerFacturasBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgLISTAFACTURAS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgLISTAFACTURAS.GridColor = System.Drawing.Color.Black
        Me.dtgLISTAFACTURAS.Location = New System.Drawing.Point(12, 266)
        Me.dtgLISTAFACTURAS.Name = "dtgLISTAFACTURAS"
        Me.dtgLISTAFACTURAS.ReadOnly = True
        Me.dtgLISTAFACTURAS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgLISTAFACTURAS.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgLISTAFACTURAS.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgLISTAFACTURAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgLISTAFACTURAS.Size = New System.Drawing.Size(994, 213)
        Me.dtgLISTAFACTURAS.TabIndex = 50
        '
        'NumFacturaDataGridViewTextBoxColumn
        '
        Me.NumFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumFactura"
        Me.NumFacturaDataGridViewTextBoxColumn.HeaderText = "NumFactura"
        Me.NumFacturaDataGridViewTextBoxColumn.Name = "NumFacturaDataGridViewTextBoxColumn"
        Me.NumFacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumFacturaDataGridViewTextBoxColumn.Width = 125
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 79
        '
        'ClienteDniDataGridViewTextBoxColumn
        '
        Me.ClienteDniDataGridViewTextBoxColumn.DataPropertyName = "ClienteDni"
        Me.ClienteDniDataGridViewTextBoxColumn.HeaderText = "Dni_Cliente"
        Me.ClienteDniDataGridViewTextBoxColumn.Name = "ClienteDniDataGridViewTextBoxColumn"
        Me.ClienteDniDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDniDataGridViewTextBoxColumn.Width = 119
        '
        'ClienteApeDataGridViewTextBoxColumn
        '
        Me.ClienteApeDataGridViewTextBoxColumn.DataPropertyName = "ClienteApe"
        Me.ClienteApeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ClienteApeDataGridViewTextBoxColumn.Name = "ClienteApeDataGridViewTextBoxColumn"
        Me.ClienteApeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteApeDataGridViewTextBoxColumn.Width = 92
        '
        'ClienteNomDataGridViewTextBoxColumn
        '
        Me.ClienteNomDataGridViewTextBoxColumn.DataPropertyName = "ClienteNom"
        Me.ClienteNomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.ClienteNomDataGridViewTextBoxColumn.Name = "ClienteNomDataGridViewTextBoxColumn"
        Me.ClienteNomDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteNomDataGridViewTextBoxColumn.Width = 93
        '
        'DniempleadoDataGridViewTextBoxColumn
        '
        Me.DniempleadoDataGridViewTextBoxColumn.DataPropertyName = "dni_empleado"
        Me.DniempleadoDataGridViewTextBoxColumn.HeaderText = "Dni_Vendedor"
        Me.DniempleadoDataGridViewTextBoxColumn.Name = "DniempleadoDataGridViewTextBoxColumn"
        Me.DniempleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DniempleadoDataGridViewTextBoxColumn.Width = 138
        '
        'VendedorApeDataGridViewTextBoxColumn
        '
        Me.VendedorApeDataGridViewTextBoxColumn.DataPropertyName = "VendedorApe"
        Me.VendedorApeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.VendedorApeDataGridViewTextBoxColumn.Name = "VendedorApeDataGridViewTextBoxColumn"
        Me.VendedorApeDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendedorApeDataGridViewTextBoxColumn.Width = 92
        '
        'VendedorNomDataGridViewTextBoxColumn
        '
        Me.VendedorNomDataGridViewTextBoxColumn.DataPropertyName = "VendedorNom"
        Me.VendedorNomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.VendedorNomDataGridViewTextBoxColumn.Name = "VendedorNomDataGridViewTextBoxColumn"
        Me.VendedorNomDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendedorNomDataGridViewTextBoxColumn.Width = 93
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total_Factura"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalDataGridViewTextBoxColumn.Width = 137
        '
        'VerFacturasBindingSource
        '
        Me.VerFacturasBindingSource.DataMember = "VerFacturas"
        Me.VerFacturasBindingSource.DataSource = Me.DataSetProyecto
        '
        'DataSetProyecto
        '
        Me.DataSetProyecto.DataSetName = "DataSetProyecto"
        Me.DataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.SlateGray
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.groupBox1.Controls.Add(Me.RBfecha)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.btnBUSCAR_FECHA)
        Me.groupBox1.Controls.Add(Me.dtpHasta)
        Me.groupBox1.Controls.Add(Me.dtpDesde)
        Me.groupBox1.Controls.Add(Me.RBdniVendedor)
        Me.groupBox1.Controls.Add(Me.RBdniCliente)
        Me.groupBox1.Controls.Add(Me.RBNumFact)
        Me.groupBox1.Controls.Add(Me.txt_BuscarDniVendedor)
        Me.groupBox1.Controls.Add(Me.txt_BucarDniCliente)
        Me.groupBox1.Controls.Add(Me.txt_BuscaFact)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(62, 102)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(890, 118)
        Me.groupBox1.TabIndex = 49
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "B  U  S  C  A  R"
        '
        'RBfecha
        '
        Me.RBfecha.AutoSize = True
        Me.RBfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfecha.ForeColor = System.Drawing.Color.White
        Me.RBfecha.Location = New System.Drawing.Point(667, 22)
        Me.RBfecha.Name = "RBfecha"
        Me.RBfecha.Size = New System.Drawing.Size(97, 20)
        Me.RBfecha.TabIndex = 42
        Me.RBfecha.TabStop = True
        Me.RBfecha.Text = "Por Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBfecha.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(603, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(599, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Desde"
        '
        'btnBUSCAR_FECHA
        '
        Me.btnBUSCAR_FECHA.BackColor = System.Drawing.Color.Silver
        Me.btnBUSCAR_FECHA.Enabled = False
        Me.btnBUSCAR_FECHA.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBUSCAR_FECHA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBUSCAR_FECHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUSCAR_FECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR_FECHA.Location = New System.Drawing.Point(792, 64)
        Me.btnBUSCAR_FECHA.Name = "btnBUSCAR_FECHA"
        Me.btnBUSCAR_FECHA.Size = New System.Drawing.Size(82, 27)
        Me.btnBUSCAR_FECHA.TabIndex = 40
        Me.btnBUSCAR_FECHA.Text = "Buscar"
        Me.btnBUSCAR_FECHA.UseVisualStyleBackColor = False
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(653, 84)
        Me.dtpHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpHasta.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpHasta.TabIndex = 39
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(653, 53)
        Me.dtpDesde.MaxDate = New Date(2090, 12, 31, 0, 0, 0, 0)
        Me.dtpDesde.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpDesde.TabIndex = 38
        '
        'RBdniVendedor
        '
        Me.RBdniVendedor.AutoSize = True
        Me.RBdniVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBdniVendedor.Location = New System.Drawing.Point(389, 37)
        Me.RBdniVendedor.Name = "RBdniVendedor"
        Me.RBdniVendedor.Size = New System.Drawing.Size(152, 20)
        Me.RBdniVendedor.TabIndex = 36
        Me.RBdniVendedor.TabStop = True
        Me.RBdniVendedor.Text = "Por DNI Vendedor"
        Me.RBdniVendedor.UseVisualStyleBackColor = True
        '
        'RBdniCliente
        '
        Me.RBdniCliente.AutoSize = True
        Me.RBdniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBdniCliente.Location = New System.Drawing.Point(196, 35)
        Me.RBdniCliente.Name = "RBdniCliente"
        Me.RBdniCliente.Size = New System.Drawing.Size(132, 20)
        Me.RBdniCliente.TabIndex = 35
        Me.RBdniCliente.TabStop = True
        Me.RBdniCliente.Text = "Por DNI Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBdniCliente.UseVisualStyleBackColor = True
        '
        'RBNumFact
        '
        Me.RBNumFact.AutoSize = True
        Me.RBNumFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNumFact.Location = New System.Drawing.Point(9, 37)
        Me.RBNumFact.Name = "RBNumFact"
        Me.RBNumFact.Size = New System.Drawing.Size(133, 20)
        Me.RBNumFact.TabIndex = 34
        Me.RBNumFact.TabStop = True
        Me.RBNumFact.Text = "Nro. de Factura"
        Me.RBNumFact.UseVisualStyleBackColor = True
        '
        'txt_BuscarDniVendedor
        '
        Me.txt_BuscarDniVendedor.Enabled = False
        Me.txt_BuscarDniVendedor.Location = New System.Drawing.Point(389, 64)
        Me.txt_BuscarDniVendedor.MaxLength = 8
        Me.txt_BuscarDniVendedor.Name = "txt_BuscarDniVendedor"
        Me.txt_BuscarDniVendedor.Size = New System.Drawing.Size(128, 23)
        Me.txt_BuscarDniVendedor.TabIndex = 33
        '
        'txt_BucarDniCliente
        '
        Me.txt_BucarDniCliente.Enabled = False
        Me.txt_BucarDniCliente.Location = New System.Drawing.Point(195, 62)
        Me.txt_BucarDniCliente.MaxLength = 8
        Me.txt_BucarDniCliente.Name = "txt_BucarDniCliente"
        Me.txt_BucarDniCliente.Size = New System.Drawing.Size(126, 23)
        Me.txt_BucarDniCliente.TabIndex = 32
        '
        'txt_BuscaFact
        '
        Me.txt_BuscaFact.Enabled = False
        Me.txt_BuscaFact.Location = New System.Drawing.Point(9, 62)
        Me.txt_BuscaFact.Name = "txt_BuscaFact"
        Me.txt_BuscaFact.Size = New System.Drawing.Size(118, 23)
        Me.txt_BuscaFact.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(312, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 33)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "VENTAS / FACTURAS"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(421, 223)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(102, 25)
        Me.lblTitulo.TabIndex = 46
        Me.lblTitulo.Text = "VENTAS"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.Label8)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1018, 40)
        Me.panel2.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(22, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(388, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Consulta de Ventas Realizadas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(982, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(163, 370)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(602, 25)
        Me.Linfo.TabIndex = 91
        Me.Linfo.Text = "Disculpe,No hay Ventas realizadas en la base de datos "
        Me.Linfo.Visible = False
        '
        'VerFacturasTableAdapter
        '
        Me.VerFacturasTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(164, 496)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(696, 24)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Haciendo doble clic en cualquier fila podra ver la factura correspondiente"
        '
        'FormConsultarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1018, 529)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Linfo)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.dtgLISTAFACTURAS)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConsultarVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Ventas"
        CType(Me.dtgLISTAFACTURAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtgLISTAFACTURAS As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents txt_BuscarDniVendedor As TextBox
    Friend WithEvents txt_BucarDniCliente As TextBox
    Friend WithEvents txt_BuscaFact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitulo As Label
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents Linfo As Label
    Friend WithEvents RBdniVendedor As RadioButton
    Friend WithEvents RBdniCliente As RadioButton
    Friend WithEvents RBNumFact As RadioButton
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents VerFacturasBindingSource As BindingSource
    Friend WithEvents VerFacturasTableAdapter As DataSetProyectoTableAdapters.VerFacturasTableAdapter
    Friend WithEvents NumFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteApeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniempleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorApeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorNomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RBfecha As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBUSCAR_FECHA As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
