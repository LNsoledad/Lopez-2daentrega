<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionarProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextPrecioCosto = New System.Windows.Forms.TextBox()
        Me.ComboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboOrigen = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.lblCODIGO = New System.Windows.Forms.Label()
        Me.txtCODIGO = New System.Windows.Forms.TextBox()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.cbxMARCA = New System.Windows.Forms.ComboBox()
        Me.lblSTOCK = New System.Windows.Forms.Label()
        Me.txtDESCRIPCION = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblCATEGORIA = New System.Windows.Forms.Label()
        Me.lblPRECIO = New System.Windows.Forms.Label()
        Me.lblDESCRIPCION = New System.Windows.Forms.Label()
        Me.txtPRECIO = New System.Windows.Forms.TextBox()
        Me.txtSTOCK = New System.Windows.Forms.TextBox()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.gbxARTICULOS = New System.Windows.Forms.GroupBox()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.dtgPRODUCTOS = New System.Windows.Forms.DataGridView()
        Me.lblPorCodigo = New System.Windows.Forms.Label()
        Me.lblPorDescripcion = New System.Windows.Forms.Label()
        Me.tbxBUSCACodigo = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.tbxBUSCADescripcion = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbxARTICULOS.SuspendLayout()
        CType(Me.dtgPRODUCTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextPrecioCosto)
        Me.GroupBox1.Controls.Add(Me.ComboProveedor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboOrigen)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnLIMPIAR)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lblCODIGO)
        Me.GroupBox1.Controls.Add(Me.txtCODIGO)
        Me.GroupBox1.Controls.Add(Me.cbxCategoria)
        Me.GroupBox1.Controls.Add(Me.cbxMARCA)
        Me.GroupBox1.Controls.Add(Me.lblSTOCK)
        Me.GroupBox1.Controls.Add(Me.txtDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.lblMarca)
        Me.GroupBox1.Controls.Add(Me.lblCATEGORIA)
        Me.GroupBox1.Controls.Add(Me.lblPRECIO)
        Me.GroupBox1.Controls.Add(Me.lblDESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.txtPRECIO)
        Me.GroupBox1.Controls.Add(Me.txtSTOCK)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(94, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1061, 364)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(4, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 16)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Precio costo: $"
        '
        'TextPrecioCosto
        '
        Me.TextPrecioCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPrecioCosto.Location = New System.Drawing.Point(115, 298)
        Me.TextPrecioCosto.MaxLength = 8
        Me.TextPrecioCosto.Name = "TextPrecioCosto"
        Me.TextPrecioCosto.Size = New System.Drawing.Size(80, 22)
        Me.TextPrecioCosto.TabIndex = 8
        '
        'ComboProveedor
        '
        Me.ComboProveedor.DisplayMember = "descripcion"
        Me.ComboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboProveedor.FormattingEnabled = True
        Me.ComboProveedor.Location = New System.Drawing.Point(114, 242)
        Me.ComboProveedor.Name = "ComboProveedor"
        Me.ComboProveedor.Size = New System.Drawing.Size(201, 24)
        Me.ComboProveedor.TabIndex = 6
        Me.ComboProveedor.ValueMember = "id_categoria"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(35, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Proveedor:"
        '
        'ComboOrigen
        '
        Me.ComboOrigen.DisplayMember = "descripcion"
        Me.ComboOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboOrigen.FormattingEnabled = True
        Me.ComboOrigen.Location = New System.Drawing.Point(114, 212)
        Me.ComboOrigen.Name = "ComboOrigen"
        Me.ComboOrigen.Size = New System.Drawing.Size(201, 24)
        Me.ComboOrigen.TabIndex = 5
        Me.ComboOrigen.ValueMember = "id_categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(54, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Origen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "(Utilice la coma como punto decimal)"
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
        Me.btnLIMPIAR.Location = New System.Drawing.Point(337, 264)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(108, 53)
        Me.btnLIMPIAR.TabIndex = 14
        Me.btnLIMPIAR.Text = "      Limpiar"
        Me.btnLIMPIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnActivar)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnEliminar)
        Me.GroupBox3.Controls.Add(Me.BtnAgregar)
        Me.GroupBox3.Controls.Add(Me.BtnModificar)
        Me.GroupBox3.Location = New System.Drawing.Point(337, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(673, 226)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elija la opcion que desea realizar"
        '
        'BtnActivar
        '
        Me.BtnActivar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnActivar.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.activar
        Me.BtnActivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActivar.Enabled = False
        Me.BtnActivar.FlatAppearance.BorderSize = 0
        Me.BtnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivar.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BtnActivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActivar.Location = New System.Drawing.Point(502, 30)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(153, 150)
        Me.BtnActivar.TabIndex = 13
        Me.BtnActivar.Text = "Dar de Alta"
        Me.BtnActivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "(para Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "debe completar todos los campos)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnEliminar.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.icono_eliminar
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(334, 31)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(153, 150)
        Me.BtnEliminar.TabIndex = 12
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAgregar.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.icono_agregar
        Me.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(6, 30)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(153, 150)
        Me.BtnAgregar.TabIndex = 10
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.UseVisualStyleBackColor = False
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
        Me.BtnModificar.Location = New System.Drawing.Point(170, 31)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(153, 150)
        Me.BtnModificar.TabIndex = 11
        Me.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'lblCODIGO
        '
        Me.lblCODIGO.AutoSize = True
        Me.lblCODIGO.BackColor = System.Drawing.Color.Transparent
        Me.lblCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCODIGO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCODIGO.Location = New System.Drawing.Point(47, 33)
        Me.lblCODIGO.Name = "lblCODIGO"
        Me.lblCODIGO.Size = New System.Drawing.Size(62, 16)
        Me.lblCODIGO.TabIndex = 45
        Me.lblCODIGO.Text = "Código:"
        '
        'txtCODIGO
        '
        Me.txtCODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCODIGO.Location = New System.Drawing.Point(115, 30)
        Me.txtCODIGO.MaxLength = 8
        Me.txtCODIGO.Name = "txtCODIGO"
        Me.txtCODIGO.Size = New System.Drawing.Size(201, 22)
        Me.txtCODIGO.TabIndex = 1
        '
        'cbxCategoria
        '
        Me.cbxCategoria.DisplayMember = "descripcion"
        Me.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(115, 152)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(201, 24)
        Me.cbxCategoria.TabIndex = 3
        Me.cbxCategoria.ValueMember = "id_categoria"
        '
        'cbxMARCA
        '
        Me.cbxMARCA.DisplayMember = "descripcion"
        Me.cbxMARCA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMARCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMARCA.FormattingEnabled = True
        Me.cbxMARCA.Location = New System.Drawing.Point(115, 182)
        Me.cbxMARCA.Name = "cbxMARCA"
        Me.cbxMARCA.Size = New System.Drawing.Size(200, 24)
        Me.cbxMARCA.TabIndex = 4
        Me.cbxMARCA.ValueMember = "id_marca"
        '
        'lblSTOCK
        '
        Me.lblSTOCK.AutoSize = True
        Me.lblSTOCK.BackColor = System.Drawing.Color.Transparent
        Me.lblSTOCK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTOCK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSTOCK.Location = New System.Drawing.Point(61, 275)
        Me.lblSTOCK.Name = "lblSTOCK"
        Me.lblSTOCK.Size = New System.Drawing.Size(51, 16)
        Me.lblSTOCK.TabIndex = 33
        Me.lblSTOCK.Text = "Stock:"
        '
        'txtDESCRIPCION
        '
        Me.txtDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESCRIPCION.Location = New System.Drawing.Point(115, 58)
        Me.txtDESCRIPCION.MaxLength = 250
        Me.txtDESCRIPCION.Multiline = True
        Me.txtDESCRIPCION.Name = "txtDESCRIPCION"
        Me.txtDESCRIPCION.Size = New System.Drawing.Size(201, 88)
        Me.txtDESCRIPCION.TabIndex = 2
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMarca.Location = New System.Drawing.Point(61, 185)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(55, 16)
        Me.lblMarca.TabIndex = 30
        Me.lblMarca.Text = "Marca:"
        '
        'lblCATEGORIA
        '
        Me.lblCATEGORIA.AutoSize = True
        Me.lblCATEGORIA.BackColor = System.Drawing.Color.Transparent
        Me.lblCATEGORIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCATEGORIA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCATEGORIA.Location = New System.Drawing.Point(36, 160)
        Me.lblCATEGORIA.Name = "lblCATEGORIA"
        Me.lblCATEGORIA.Size = New System.Drawing.Size(80, 16)
        Me.lblCATEGORIA.TabIndex = 29
        Me.lblCATEGORIA.Text = "Categoría:"
        '
        'lblPRECIO
        '
        Me.lblPRECIO.AutoSize = True
        Me.lblPRECIO.BackColor = System.Drawing.Color.Transparent
        Me.lblPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPRECIO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPRECIO.Location = New System.Drawing.Point(3, 327)
        Me.lblPRECIO.Name = "lblPRECIO"
        Me.lblPRECIO.Size = New System.Drawing.Size(111, 16)
        Me.lblPRECIO.TabIndex = 28
        Me.lblPRECIO.Text = "Precio venta: $"
        '
        'lblDESCRIPCION
        '
        Me.lblDESCRIPCION.AutoSize = True
        Me.lblDESCRIPCION.BackColor = System.Drawing.Color.Transparent
        Me.lblDESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDESCRIPCION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDESCRIPCION.Location = New System.Drawing.Point(21, 61)
        Me.lblDESCRIPCION.Name = "lblDESCRIPCION"
        Me.lblDESCRIPCION.Size = New System.Drawing.Size(95, 16)
        Me.lblDESCRIPCION.TabIndex = 27
        Me.lblDESCRIPCION.Text = "Descripción:"
        '
        'txtPRECIO
        '
        Me.txtPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRECIO.Location = New System.Drawing.Point(114, 323)
        Me.txtPRECIO.MaxLength = 6
        Me.txtPRECIO.Name = "txtPRECIO"
        Me.txtPRECIO.Size = New System.Drawing.Size(80, 22)
        Me.txtPRECIO.TabIndex = 9
        '
        'txtSTOCK
        '
        Me.txtSTOCK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSTOCK.Location = New System.Drawing.Point(115, 272)
        Me.txtSTOCK.MaxLength = 8
        Me.txtSTOCK.Name = "txtSTOCK"
        Me.txtSTOCK.Size = New System.Drawing.Size(80, 22)
        Me.txtSTOCK.TabIndex = 7
        '
        'BtnAyuda
        '
        Me.BtnAyuda.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.BtnAyuda.FlatAppearance.BorderSize = 0
        Me.BtnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAyuda.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnAyuda.Image = Global.Taller2_Proyecto.My.Resources.Resources.customer_service1
        Me.BtnAyuda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAyuda.Location = New System.Drawing.Point(1256, 22)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(71, 60)
        Me.BtnAyuda.TabIndex = 77
        Me.BtnAyuda.Text = "Ayuda"
        Me.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAyuda.UseVisualStyleBackColor = False
        '
        'gbxARTICULOS
        '
        Me.gbxARTICULOS.BackColor = System.Drawing.Color.Transparent
        Me.gbxARTICULOS.Controls.Add(Me.Linfo)
        Me.gbxARTICULOS.Controls.Add(Me.dtgPRODUCTOS)
        Me.gbxARTICULOS.Controls.Add(Me.lblPorCodigo)
        Me.gbxARTICULOS.Controls.Add(Me.lblPorDescripcion)
        Me.gbxARTICULOS.Controls.Add(Me.tbxBUSCACodigo)
        Me.gbxARTICULOS.Controls.Add(Me.lblBuscar)
        Me.gbxARTICULOS.Controls.Add(Me.BtnAyuda)
        Me.gbxARTICULOS.Controls.Add(Me.tbxBUSCADescripcion)
        Me.gbxARTICULOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxARTICULOS.ForeColor = System.Drawing.Color.Black
        Me.gbxARTICULOS.Location = New System.Drawing.Point(12, 433)
        Me.gbxARTICULOS.Name = "gbxARTICULOS"
        Me.gbxARTICULOS.Size = New System.Drawing.Size(1336, 269)
        Me.gbxARTICULOS.TabIndex = 69
        Me.gbxARTICULOS.TabStop = False
        Me.gbxARTICULOS.Text = "Lista de Productos"
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(47, 145)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(1096, 55)
        Me.Linfo.TabIndex = 90
        Me.Linfo.Text = "Disculpe,No hay Productos en la base de datos "
        Me.Linfo.Visible = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPRODUCTOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgPRODUCTOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgPRODUCTOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgPRODUCTOS.Location = New System.Drawing.Point(12, 88)
        Me.dtgPRODUCTOS.MultiSelect = False
        Me.dtgPRODUCTOS.Name = "dtgPRODUCTOS"
        Me.dtgPRODUCTOS.ReadOnly = True
        Me.dtgPRODUCTOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgPRODUCTOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgPRODUCTOS.RowHeadersVisible = False
        Me.dtgPRODUCTOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgPRODUCTOS.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgPRODUCTOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgPRODUCTOS.Size = New System.Drawing.Size(1318, 159)
        Me.dtgPRODUCTOS.TabIndex = 73
        '
        'lblPorCodigo
        '
        Me.lblPorCodigo.AutoSize = True
        Me.lblPorCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblPorCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPorCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPorCodigo.Location = New System.Drawing.Point(688, 50)
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
        Me.lblPorDescripcion.Location = New System.Drawing.Point(486, 50)
        Me.lblPorDescripcion.Name = "lblPorDescripcion"
        Me.lblPorDescripcion.Size = New System.Drawing.Size(119, 16)
        Me.lblPorDescripcion.TabIndex = 54
        Me.lblPorDescripcion.Text = "Por Descripción"
        '
        'tbxBUSCACodigo
        '
        Me.tbxBUSCACodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCACodigo.Location = New System.Drawing.Point(656, 26)
        Me.tbxBUSCACodigo.MaxLength = 8
        Me.tbxBUSCACodigo.Name = "tbxBUSCACodigo"
        Me.tbxBUSCACodigo.Size = New System.Drawing.Size(143, 21)
        Me.tbxBUSCACodigo.TabIndex = 16
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBuscar.Location = New System.Drawing.Point(336, 29)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(105, 16)
        Me.lblBuscar.TabIndex = 49
        Me.lblBuscar.Text = "Búsqueda por"
        '
        'tbxBUSCADescripcion
        '
        Me.tbxBUSCADescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCADescripcion.Location = New System.Drawing.Point(458, 26)
        Me.tbxBUSCADescripcion.MaxLength = 50
        Me.tbxBUSCADescripcion.Name = "tbxBUSCADescripcion"
        Me.tbxBUSCADescripcion.Size = New System.Drawing.Size(167, 21)
        Me.tbxBUSCADescripcion.TabIndex = 15
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.Label3)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1351, 40)
        Me.panel2.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(231, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(864, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Administracion de Productos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1315, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(231, 705)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(890, 58)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Este listado es de todos los Productos que se encuentran  Activos/Inactivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormGestionarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1351, 754)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxARTICULOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGestionarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbxARTICULOS.ResumeLayout(False)
        Me.gbxARTICULOS.PerformLayout()
        CType(Me.dtgPRODUCTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCODIGO As Label
    Friend WithEvents txtCODIGO As TextBox
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents cbxMARCA As ComboBox
    Friend WithEvents lblSTOCK As Label
    Friend WithEvents txtDESCRIPCION As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblCATEGORIA As Label
    Friend WithEvents lblPRECIO As Label
    Friend WithEvents lblDESCRIPCION As Label
    Friend WithEvents txtPRECIO As TextBox
    Friend WithEvents txtSTOCK As TextBox
    Friend WithEvents gbxARTICULOS As GroupBox
    Friend WithEvents lblPorCodigo As Label
    Friend WithEvents lblPorDescripcion As Label
    Friend WithEvents tbxBUSCACodigo As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents tbxBUSCADescripcion As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents BtnActivar As Button
    Friend WithEvents dtgPRODUCTOS As DataGridView
    Friend WithEvents Label2 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents Label3 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents Label9 As Label
    Private WithEvents BtnAyuda As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextPrecioCosto As TextBox
    Friend WithEvents ComboProveedor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboOrigen As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Linfo As Label
End Class
