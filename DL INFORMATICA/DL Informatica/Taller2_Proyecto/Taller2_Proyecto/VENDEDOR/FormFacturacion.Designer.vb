<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormFacturacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo_det = New System.Windows.Forms.Label()
        Me.lblNom_cli = New System.Windows.Forms.Label()
        Me.lblApe_cli = New System.Windows.Forms.Label()
        Me.lblDNI_CLI = New System.Windows.Forms.Label()
        Me.btnFACTURAR = New System.Windows.Forms.Button()
        Me.btnCANCELAR = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dtgVentas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHORAS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.dtgPRODUCTOS = New System.Windows.Forms.DataGridView()
        Me.tbxBuscaCod = New System.Windows.Forms.TextBox()
        Me.btnBUSCA_CLI = New System.Windows.Forms.Button()
        Me.tbxCLIENTE_nom = New System.Windows.Forms.TextBox()
        Me.tbxCLIENTE_ape = New System.Windows.Forms.TextBox()
        Me.tbxCLIENTE_cod = New System.Windows.Forms.TextBox()
        Me.tbxDNI_USUARIO = New System.Windows.Forms.TextBox()
        Me.tbxFecha = New System.Windows.Forms.TextBox()
        Me.tbxFACTURA_N = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.BtnBuscarProducto = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxBuscaDesc = New System.Windows.Forms.TextBox()
        Me.lblCant_pro = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDesc_pro = New System.Windows.Forms.Label()
        Me.lblCod_pro = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.btnAGREGAR_PRODUCTO = New System.Windows.Forms.Button()
        Me.txtCANTIDAD = New System.Windows.Forms.TextBox()
        Me.txtPRECIO = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnNUEVO_Cli = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btncerrar1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPRODUCTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo_det
        '
        Me.lblTitulo_det.AutoSize = True
        Me.lblTitulo_det.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo_det.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo_det.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTitulo_det.Location = New System.Drawing.Point(43, 417)
        Me.lblTitulo_det.Name = "lblTitulo_det"
        Me.lblTitulo_det.Size = New System.Drawing.Size(206, 29)
        Me.lblTitulo_det.TabIndex = 70
        Me.lblTitulo_det.Text = "Detalle de Venta"
        '
        'lblNom_cli
        '
        Me.lblNom_cli.AutoSize = True
        Me.lblNom_cli.BackColor = System.Drawing.Color.Transparent
        Me.lblNom_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom_cli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblNom_cli.Location = New System.Drawing.Point(95, 77)
        Me.lblNom_cli.Name = "lblNom_cli"
        Me.lblNom_cli.Size = New System.Drawing.Size(54, 13)
        Me.lblNom_cli.TabIndex = 68
        Me.lblNom_cli.Text = "Nombre:"
        '
        'lblApe_cli
        '
        Me.lblApe_cli.AutoSize = True
        Me.lblApe_cli.BackColor = System.Drawing.Color.Transparent
        Me.lblApe_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApe_cli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblApe_cli.Location = New System.Drawing.Point(95, 46)
        Me.lblApe_cli.Name = "lblApe_cli"
        Me.lblApe_cli.Size = New System.Drawing.Size(53, 13)
        Me.lblApe_cli.TabIndex = 67
        Me.lblApe_cli.Text = "Apelido:"
        '
        'lblDNI_CLI
        '
        Me.lblDNI_CLI.AutoSize = True
        Me.lblDNI_CLI.BackColor = System.Drawing.Color.Transparent
        Me.lblDNI_CLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI_CLI.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblDNI_CLI.Location = New System.Drawing.Point(77, 21)
        Me.lblDNI_CLI.Name = "lblDNI_CLI"
        Me.lblDNI_CLI.Size = New System.Drawing.Size(73, 13)
        Me.lblDNI_CLI.TabIndex = 66
        Me.lblDNI_CLI.Text = "Dni Cliente:"
        '
        'btnFACTURAR
        '
        Me.btnFACTURAR.BackColor = System.Drawing.Color.LightGreen
        Me.btnFACTURAR.Enabled = False
        Me.btnFACTURAR.FlatAppearance.BorderSize = 0
        Me.btnFACTURAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFACTURAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFACTURAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFACTURAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.CarroNegro32
        Me.btnFACTURAR.Location = New System.Drawing.Point(924, 630)
        Me.btnFACTURAR.Name = "btnFACTURAR"
        Me.btnFACTURAR.Size = New System.Drawing.Size(133, 79)
        Me.btnFACTURAR.TabIndex = 65
        Me.btnFACTURAR.Text = "Facturar"
        Me.btnFACTURAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFACTURAR.UseVisualStyleBackColor = False
        '
        'btnCANCELAR
        '
        Me.btnCANCELAR.BackColor = System.Drawing.Color.LightGreen
        Me.btnCANCELAR.Enabled = False
        Me.btnCANCELAR.FlatAppearance.BorderSize = 0
        Me.btnCANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCELAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.CancelarVenta24
        Me.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCANCELAR.Location = New System.Drawing.Point(924, 569)
        Me.btnCANCELAR.Name = "btnCANCELAR"
        Me.btnCANCELAR.Size = New System.Drawing.Size(133, 53)
        Me.btnCANCELAR.TabIndex = 64
        Me.btnCANCELAR.Text = "Cancelar Venta"
        Me.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCANCELAR.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.LightGreen
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.Taller2_Proyecto.My.Resources.Resources.Eliminar24_2
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(924, 450)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(133, 53)
        Me.btnEliminar.TabIndex = 63
        Me.btnEliminar.Text = "Eliminar Detalle"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dtgVentas
        '
        Me.dtgVentas.AllowUserToAddRows = False
        Me.dtgVentas.AllowUserToDeleteRows = False
        Me.dtgVentas.AllowUserToResizeColumns = False
        Me.dtgVentas.AllowUserToResizeRows = False
        Me.dtgVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgVentas.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.dtgVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.descripcion, Me.cantidad, Me.precio, Me.subtot})
        Me.dtgVentas.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgVentas.Location = New System.Drawing.Point(48, 450)
        Me.dtgVentas.MultiSelect = False
        Me.dtgVentas.Name = "dtgVentas"
        Me.dtgVentas.ReadOnly = True
        Me.dtgVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgVentas.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgVentas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgVentas.Size = New System.Drawing.Size(837, 259)
        Me.dtgVentas.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Producto"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'precio
        '
        Me.precio.HeaderText = "Precio Unitario"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        '
        'subtot
        '
        Me.subtot.HeaderText = "Subtotal"
        Me.subtot.Name = "subtot"
        Me.subtot.ReadOnly = True
        '
        'lblHORAS
        '
        Me.lblHORAS.AutoSize = True
        Me.lblHORAS.BackColor = System.Drawing.Color.Transparent
        Me.lblHORAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHORAS.ForeColor = System.Drawing.Color.DarkRed
        Me.lblHORAS.Location = New System.Drawing.Point(1155, 4)
        Me.lblHORAS.Name = "lblHORAS"
        Me.lblHORAS.Size = New System.Drawing.Size(92, 31)
        Me.lblHORAS.TabIndex = 61
        Me.lblHORAS.Text = "--:--:--"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(9, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Dni Vendedor/a:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblFecha.Location = New System.Drawing.Point(281, 27)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 13)
        Me.lblFecha.TabIndex = 59
        Me.lblFecha.Text = "Fecha:"
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.BackColor = System.Drawing.Color.Transparent
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblFactura.Location = New System.Drawing.Point(42, 27)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(68, 13)
        Me.lblFactura.TabIndex = 58
        Me.lblFactura.Text = "Factura N°"
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPRODUCTOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPRODUCTOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgPRODUCTOS.Location = New System.Drawing.Point(469, 289)
        Me.dtgPRODUCTOS.MultiSelect = False
        Me.dtgPRODUCTOS.Name = "dtgPRODUCTOS"
        Me.dtgPRODUCTOS.ReadOnly = True
        Me.dtgPRODUCTOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgPRODUCTOS.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgPRODUCTOS.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgPRODUCTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPRODUCTOS.Size = New System.Drawing.Size(852, 98)
        Me.dtgPRODUCTOS.TabIndex = 57
        '
        'tbxBuscaCod
        '
        Me.tbxBuscaCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBuscaCod.Location = New System.Drawing.Point(371, 20)
        Me.tbxBuscaCod.MaxLength = 8
        Me.tbxBuscaCod.Name = "tbxBuscaCod"
        Me.tbxBuscaCod.Size = New System.Drawing.Size(131, 26)
        Me.tbxBuscaCod.TabIndex = 56
        '
        'btnBUSCA_CLI
        '
        Me.btnBUSCA_CLI.BackColor = System.Drawing.Color.LightGreen
        Me.btnBUSCA_CLI.FlatAppearance.BorderSize = 0
        Me.btnBUSCA_CLI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBUSCA_CLI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUSCA_CLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCA_CLI.Image = Global.Taller2_Proyecto.My.Resources.Resources.buscaCli32
        Me.btnBUSCA_CLI.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBUSCA_CLI.Location = New System.Drawing.Point(341, 9)
        Me.btnBUSCA_CLI.Name = "btnBUSCA_CLI"
        Me.btnBUSCA_CLI.Size = New System.Drawing.Size(101, 57)
        Me.btnBUSCA_CLI.TabIndex = 55
        Me.btnBUSCA_CLI.Text = "Buscar Cliente"
        Me.btnBUSCA_CLI.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBUSCA_CLI.UseVisualStyleBackColor = False
        '
        'tbxCLIENTE_nom
        '
        Me.tbxCLIENTE_nom.Enabled = False
        Me.tbxCLIENTE_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCLIENTE_nom.Location = New System.Drawing.Point(151, 74)
        Me.tbxCLIENTE_nom.Name = "tbxCLIENTE_nom"
        Me.tbxCLIENTE_nom.Size = New System.Drawing.Size(143, 21)
        Me.tbxCLIENTE_nom.TabIndex = 54
        '
        'tbxCLIENTE_ape
        '
        Me.tbxCLIENTE_ape.Enabled = False
        Me.tbxCLIENTE_ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCLIENTE_ape.Location = New System.Drawing.Point(151, 43)
        Me.tbxCLIENTE_ape.Name = "tbxCLIENTE_ape"
        Me.tbxCLIENTE_ape.Size = New System.Drawing.Size(143, 21)
        Me.tbxCLIENTE_ape.TabIndex = 53
        '
        'tbxCLIENTE_cod
        '
        Me.tbxCLIENTE_cod.Enabled = False
        Me.tbxCLIENTE_cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCLIENTE_cod.Location = New System.Drawing.Point(151, 16)
        Me.tbxCLIENTE_cod.Name = "tbxCLIENTE_cod"
        Me.tbxCLIENTE_cod.Size = New System.Drawing.Size(143, 21)
        Me.tbxCLIENTE_cod.TabIndex = 52
        '
        'tbxDNI_USUARIO
        '
        Me.tbxDNI_USUARIO.Enabled = False
        Me.tbxDNI_USUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDNI_USUARIO.Location = New System.Drawing.Point(115, 77)
        Me.tbxDNI_USUARIO.Name = "tbxDNI_USUARIO"
        Me.tbxDNI_USUARIO.Size = New System.Drawing.Size(123, 21)
        Me.tbxDNI_USUARIO.TabIndex = 51
        '
        'tbxFecha
        '
        Me.tbxFecha.Enabled = False
        Me.tbxFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFecha.Location = New System.Drawing.Point(329, 22)
        Me.tbxFecha.Name = "tbxFecha"
        Me.tbxFecha.Size = New System.Drawing.Size(100, 21)
        Me.tbxFecha.TabIndex = 50
        '
        'tbxFACTURA_N
        '
        Me.tbxFACTURA_N.Enabled = False
        Me.tbxFACTURA_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxFACTURA_N.Location = New System.Drawing.Point(115, 23)
        Me.tbxFACTURA_N.Name = "tbxFACTURA_N"
        Me.tbxFACTURA_N.Size = New System.Drawing.Size(123, 21)
        Me.tbxFACTURA_N.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PowderBlue
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.lblCant_pro)
        Me.GroupBox1.Controls.Add(Me.lblPrecio)
        Me.GroupBox1.Controls.Add(Me.lblDesc_pro)
        Me.GroupBox1.Controls.Add(Me.lblCod_pro)
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnAGREGAR_PRODUCTO)
        Me.GroupBox1.Controls.Add(Me.txtCANTIDAD)
        Me.GroupBox1.Controls.Add(Me.txtPRECIO)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1339, 196)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Productos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Linfo)
        Me.GroupBox4.Controls.Add(Me.BtnBuscarProducto)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.tbxBuscaDesc)
        Me.GroupBox4.Controls.Add(Me.tbxBuscaCod)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(451, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(871, 170)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Listado de Productos"
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(103, 149)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(656, 36)
        Me.Linfo.TabIndex = 91
        Me.Linfo.Text = "Disculpe,No hay Productos en la base de datos o no hay productos activos con stoc" &
    "k" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        Me.Linfo.Visible = False
        '
        'BtnBuscarProducto
        '
        Me.BtnBuscarProducto.BackColor = System.Drawing.Color.LightGreen
        Me.BtnBuscarProducto.Location = New System.Drawing.Point(660, 18)
        Me.BtnBuscarProducto.Name = "BtnBuscarProducto"
        Me.BtnBuscarProducto.Size = New System.Drawing.Size(163, 27)
        Me.BtnBuscarProducto.TabIndex = 59
        Me.BtnBuscarProducto.Text = "Buscar Producto"
        Me.BtnBuscarProducto.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(269, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Listado de productos activos y con stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(306, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(77, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Descripción"
        '
        'tbxBuscaDesc
        '
        Me.tbxBuscaDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBuscaDesc.Location = New System.Drawing.Point(174, 20)
        Me.tbxBuscaDesc.Name = "tbxBuscaDesc"
        Me.tbxBuscaDesc.Size = New System.Drawing.Size(125, 26)
        Me.tbxBuscaDesc.TabIndex = 16
        '
        'lblCant_pro
        '
        Me.lblCant_pro.AutoSize = True
        Me.lblCant_pro.BackColor = System.Drawing.Color.Transparent
        Me.lblCant_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant_pro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCant_pro.Location = New System.Drawing.Point(23, 152)
        Me.lblCant_pro.Name = "lblCant_pro"
        Me.lblCant_pro.Size = New System.Drawing.Size(61, 13)
        Me.lblCant_pro.TabIndex = 37
        Me.lblCant_pro.Text = "Cantidad:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblPrecio.Location = New System.Drawing.Point(35, 121)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 36
        Me.lblPrecio.Text = "Precio:"
        '
        'lblDesc_pro
        '
        Me.lblDesc_pro.AutoSize = True
        Me.lblDesc_pro.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc_pro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblDesc_pro.Location = New System.Drawing.Point(7, 69)
        Me.lblDesc_pro.Name = "lblDesc_pro"
        Me.lblDesc_pro.Size = New System.Drawing.Size(78, 13)
        Me.lblDesc_pro.TabIndex = 35
        Me.lblDesc_pro.Text = "Descripción:"
        '
        'lblCod_pro
        '
        Me.lblCod_pro.AutoSize = True
        Me.lblCod_pro.BackColor = System.Drawing.Color.Transparent
        Me.lblCod_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod_pro.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblCod_pro.Location = New System.Drawing.Point(33, 38)
        Me.lblCod_pro.Name = "lblCod_pro"
        Me.lblCod_pro.Size = New System.Drawing.Size(50, 13)
        Me.lblCod_pro.TabIndex = 34
        Me.lblCod_pro.Text = "Código:"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnLimpiar.Enabled = False
        Me.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnLimpiar.FlatAppearance.BorderSize = 2
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.Taller2_Proyecto.My.Resources.Resources.escoba
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(325, 38)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(109, 43)
        Me.BtnLimpiar.TabIndex = 30
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'btnAGREGAR_PRODUCTO
        '
        Me.btnAGREGAR_PRODUCTO.BackColor = System.Drawing.Color.LightGreen
        Me.btnAGREGAR_PRODUCTO.Enabled = False
        Me.btnAGREGAR_PRODUCTO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAGREGAR_PRODUCTO.FlatAppearance.BorderSize = 2
        Me.btnAGREGAR_PRODUCTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAGREGAR_PRODUCTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAGREGAR_PRODUCTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR_PRODUCTO.Image = Global.Taller2_Proyecto.My.Resources.Resources.CarroNegroAgregar32
        Me.btnAGREGAR_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAGREGAR_PRODUCTO.Location = New System.Drawing.Point(325, 87)
        Me.btnAGREGAR_PRODUCTO.Name = "btnAGREGAR_PRODUCTO"
        Me.btnAGREGAR_PRODUCTO.Size = New System.Drawing.Size(109, 40)
        Me.btnAGREGAR_PRODUCTO.TabIndex = 29
        Me.btnAGREGAR_PRODUCTO.Text = "Agregar"
        Me.btnAGREGAR_PRODUCTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAGREGAR_PRODUCTO.UseVisualStyleBackColor = False
        '
        'txtCANTIDAD
        '
        Me.txtCANTIDAD.Enabled = False
        Me.txtCANTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCANTIDAD.Location = New System.Drawing.Point(89, 148)
        Me.txtCANTIDAD.Name = "txtCANTIDAD"
        Me.txtCANTIDAD.Size = New System.Drawing.Size(83, 26)
        Me.txtCANTIDAD.TabIndex = 14
        '
        'txtPRECIO
        '
        Me.txtPRECIO.Enabled = False
        Me.txtPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRECIO.Location = New System.Drawing.Point(89, 114)
        Me.txtPRECIO.Name = "txtPRECIO"
        Me.txtPRECIO.Size = New System.Drawing.Size(83, 22)
        Me.txtPRECIO.TabIndex = 13
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(89, 62)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(213, 46)
        Me.txtDescripcion.TabIndex = 12
        '
        'txtCod
        '
        Me.txtCod.Enabled = False
        Me.txtCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(89, 31)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(165, 22)
        Me.txtCod.TabIndex = 11
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.BackColor = System.Drawing.Color.Transparent
        Me.lbltot.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.ForeColor = System.Drawing.Color.White
        Me.lbltot.Location = New System.Drawing.Point(331, 722)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(156, 37)
        Me.lbltot.TabIndex = 74
        Me.lbltot.Text = "TOTAL $"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Silver
        Me.lblTotal.Enabled = False
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTotal.Location = New System.Drawing.Point(492, 712)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(110, 51)
        Me.lblTotal.TabIndex = 73
        Me.lblTotal.Text = "0,00"
        '
        'btnNUEVO_Cli
        '
        Me.btnNUEVO_Cli.BackColor = System.Drawing.Color.LightGreen
        Me.btnNUEVO_Cli.FlatAppearance.BorderSize = 0
        Me.btnNUEVO_Cli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNUEVO_Cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNUEVO_Cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNUEVO_Cli.Image = Global.Taller2_Proyecto.My.Resources.Resources.AgregarCli32
        Me.btnNUEVO_Cli.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNUEVO_Cli.Location = New System.Drawing.Point(341, 72)
        Me.btnNUEVO_Cli.Name = "btnNUEVO_Cli"
        Me.btnNUEVO_Cli.Size = New System.Drawing.Size(99, 55)
        Me.btnNUEVO_Cli.TabIndex = 75
        Me.btnNUEVO_Cli.Text = "Nuevo Cliente"
        Me.btnNUEVO_Cli.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNUEVO_Cli.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PowderBlue
        Me.GroupBox2.Controls.Add(Me.lblNom_cli)
        Me.GroupBox2.Controls.Add(Me.lblApe_cli)
        Me.GroupBox2.Controls.Add(Me.lblDNI_CLI)
        Me.GroupBox2.Controls.Add(Me.btnNUEVO_Cli)
        Me.GroupBox2.Controls.Add(Me.tbxCLIENTE_nom)
        Me.GroupBox2.Controls.Add(Me.tbxCLIENTE_ape)
        Me.GroupBox2.Controls.Add(Me.tbxCLIENTE_cod)
        Me.GroupBox2.Controls.Add(Me.btnBUSCA_CLI)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(875, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 137)
        Me.GroupBox2.TabIndex = 76
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PowderBlue
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtNombre)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblFecha)
        Me.GroupBox3.Controls.Add(Me.lblFactura)
        Me.GroupBox3.Controls.Add(Me.tbxDNI_USUARIO)
        Me.GroupBox3.Controls.Add(Me.tbxFecha)
        Me.GroupBox3.Controls.Add(Me.tbxFACTURA_N)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(531, 137)
        Me.GroupBox3.TabIndex = 77
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Factura "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(271, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Vendedor/a:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(355, 77)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(161, 21)
        Me.TxtNombre.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(1063, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 31)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Hora:"
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnEditar.Enabled = False
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.Taller2_Proyecto.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(924, 510)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(133, 53)
        Me.BtnEditar.TabIndex = 79
        Me.BtnEditar.Text = "Editar Detalle"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.btncerrar1)
        Me.panel2.Controls.Add(Me.Label7)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Controls.Add(Me.Label5)
        Me.panel2.Controls.Add(Me.lblHORAS)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1375, 40)
        Me.panel2.TabIndex = 84
        '
        'btncerrar1
        '
        Me.btncerrar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar1.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar1.ForeColor = System.Drawing.Color.White
        Me.btncerrar1.Location = New System.Drawing.Point(1327, 0)
        Me.btncerrar1.Name = "btncerrar1"
        Me.btncerrar1.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar1.TabIndex = 79
        Me.btncerrar1.Text = "X"
        Me.btncerrar1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(510, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(404, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Facturacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1870, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Taller2_Proyecto.My.Resources.Resources.goods
        Me.PictureBox1.Location = New System.Drawing.Point(577, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Taller2_Proyecto.My.Resources.Resources.time_for_sales
        Me.PictureBox2.Location = New System.Drawing.Point(1123, 456)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(228, 243)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'FormFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1375, 788)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lbltot)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTitulo_det)
        Me.Controls.Add(Me.btnFACTURAR)
        Me.Controls.Add(Me.btnCANCELAR)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dtgVentas)
        Me.Controls.Add(Me.dtgPRODUCTOS)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion"
        CType(Me.dtgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPRODUCTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo_det As Label
    Friend WithEvents lblNom_cli As Label
    Friend WithEvents lblApe_cli As Label
    Friend WithEvents lblDNI_CLI As Label
    Friend WithEvents btnFACTURAR As Button
    Friend WithEvents btnCANCELAR As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dtgVentas As DataGridView
    Friend WithEvents lblHORAS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblFactura As Label
    Friend WithEvents dtgPRODUCTOS As DataGridView
    Friend WithEvents tbxBuscaCod As TextBox
    Friend WithEvents btnBUSCA_CLI As Button
    Friend WithEvents tbxCLIENTE_nom As TextBox
    Friend WithEvents tbxCLIENTE_ape As TextBox
    Friend WithEvents tbxCLIENTE_cod As TextBox
    Friend WithEvents tbxDNI_USUARIO As TextBox
    Friend WithEvents tbxFecha As TextBox
    Friend WithEvents tbxFACTURA_N As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCant_pro As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblDesc_pro As Label
    Friend WithEvents lblCod_pro As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents btnAGREGAR_PRODUCTO As Button
    Friend WithEvents tbxBuscaDesc As TextBox
    Friend WithEvents txtCANTIDAD As TextBox
    Friend WithEvents txtPRECIO As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCod As TextBox
    Friend WithEvents lbltot As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnNUEVO_Cli As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnEditar As Button
    Private WithEvents panel2 As Panel
    Private WithEvents Label7 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents subtot As DataGridViewTextBoxColumn
    Friend WithEvents BtnBuscarProducto As Button
    Friend WithEvents Linfo As Label
    Private WithEvents btncerrar1 As Button
End Class
