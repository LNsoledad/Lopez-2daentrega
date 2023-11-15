<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEliminarCliente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.TextFecha = New System.Windows.Forms.TextBox()
        Me.comboPROVINCIA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEMAIL = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTELEFONO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextDNI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtDIRECCION = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.txtAPELLIDO = New System.Windows.Forms.TextBox()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.ListadoClientes = New System.Windows.Forms.GroupBox()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.LAlta = New System.Windows.Forms.Label()
        Me.LEliminar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtgCLIENTES = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxBUSCADNI = New System.Windows.Forms.TextBox()
        Me.tbxBUSCAAPE = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.LabelLista = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ListadoClientes.SuspendLayout()
        CType(Me.dtgCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboSexo)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.btnLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.TextFecha)
        Me.GroupBox2.Controls.Add(Me.comboPROVINCIA)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblEMAIL)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtTELEFONO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextDNI)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblDireccion)
        Me.GroupBox2.Controls.Add(Me.lblTelefono)
        Me.GroupBox2.Controls.Add(Me.lblDni)
        Me.GroupBox2.Controls.Add(Me.txtDIRECCION)
        Me.GroupBox2.Controls.Add(Me.txtNOMBRE)
        Me.GroupBox2.Controls.Add(Me.txtAPELLIDO)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 315)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'ComboSexo
        '
        Me.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSexo.Enabled = False
        Me.ComboSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Items.AddRange(New Object() {"", "Masculino", "Femenino"})
        Me.ComboSexo.Location = New System.Drawing.Point(120, 269)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(121, 24)
        Me.ComboSexo.TabIndex = 88
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(70, 273)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 16)
        Me.Label20.TabIndex = 87
        Me.Label20.Text = "Sexo:"
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
        Me.btnLIMPIAR.Location = New System.Drawing.Point(320, 240)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(108, 53)
        Me.btnLIMPIAR.TabIndex = 74
        Me.btnLIMPIAR.Text = "      Limpiar"
        Me.btnLIMPIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnActivar)
        Me.GroupBox1.Controls.Add(Me.btnELIMINAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(320, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 191)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elija la opcion que desea realizar"
        '
        'BtnActivar
        '
        Me.BtnActivar.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnActivar.Enabled = False
        Me.BtnActivar.FlatAppearance.BorderSize = 0
        Me.BtnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivar.ForeColor = System.Drawing.Color.White
        Me.BtnActivar.Image = Global.Taller2_Proyecto.My.Resources.Resources.activar
        Me.BtnActivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActivar.Location = New System.Drawing.Point(140, 30)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(124, 155)
        Me.BtnActivar.TabIndex = 72
        Me.BtnActivar.Text = "Dar de Alta"
        Me.BtnActivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.BackColor = System.Drawing.Color.LimeGreen
        Me.btnELIMINAR.Enabled = False
        Me.btnELIMINAR.FlatAppearance.BorderSize = 0
        Me.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.ForeColor = System.Drawing.Color.White
        Me.btnELIMINAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.user_eliminate_12817
        Me.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnELIMINAR.Location = New System.Drawing.Point(6, 28)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(124, 157)
        Me.btnELIMINAR.TabIndex = 60
        Me.btnELIMINAR.Text = "Dar de Baja"
        Me.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnELIMINAR.UseVisualStyleBackColor = False
        '
        'TextFecha
        '
        Me.TextFecha.Enabled = False
        Me.TextFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFecha.Location = New System.Drawing.Point(121, 240)
        Me.TextFecha.Name = "TextFecha"
        Me.TextFecha.Size = New System.Drawing.Size(85, 22)
        Me.TextFecha.TabIndex = 71
        '
        'comboPROVINCIA
        '
        Me.comboPROVINCIA.Enabled = False
        Me.comboPROVINCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboPROVINCIA.FormattingEnabled = True
        Me.comboPROVINCIA.Items.AddRange(New Object() {"", "Chaco", "Corrientes", "Formosa", "Entre Rios", "Misiones"})
        Me.comboPROVINCIA.Location = New System.Drawing.Point(122, 150)
        Me.comboPROVINCIA.Name = "comboPROVINCIA"
        Me.comboPROVINCIA.Size = New System.Drawing.Size(166, 24)
        Me.comboPROVINCIA.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Fecha Alta"
        '
        'lblEMAIL
        '
        Me.lblEMAIL.AutoSize = True
        Me.lblEMAIL.BackColor = System.Drawing.Color.Transparent
        Me.lblEMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEMAIL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEMAIL.Location = New System.Drawing.Point(68, 215)
        Me.lblEMAIL.Name = "lblEMAIL"
        Me.lblEMAIL.Size = New System.Drawing.Size(51, 16)
        Me.lblEMAIL.TabIndex = 37
        Me.lblEMAIL.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(121, 212)
        Me.txtEmail.MaxLength = 20
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(168, 22)
        Me.txtEmail.TabIndex = 8
        '
        'txtTELEFONO
        '
        Me.txtTELEFONO.Enabled = False
        Me.txtTELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO.Location = New System.Drawing.Point(121, 184)
        Me.txtTELEFONO.MaxLength = 10
        Me.txtTELEFONO.Name = "txtTELEFONO"
        Me.txtTELEFONO.Size = New System.Drawing.Size(168, 22)
        Me.txtTELEFONO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(49, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(53, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre:"
        '
        'TextDNI
        '
        Me.TextDNI.Enabled = False
        Me.TextDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDNI.Location = New System.Drawing.Point(120, 32)
        Me.TextDNI.MaxLength = 8
        Me.TextDNI.Name = "TextDNI"
        Me.TextDNI.Size = New System.Drawing.Size(169, 22)
        Me.TextDNI.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(50, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Apellido:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDireccion.Location = New System.Drawing.Point(42, 121)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(78, 16)
        Me.lblDireccion.TabIndex = 29
        Me.lblDireccion.Text = "Dirección:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTelefono.Location = New System.Drawing.Point(45, 154)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(77, 16)
        Me.lblTelefono.TabIndex = 28
        Me.lblTelefono.Text = "Provincia:"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.Color.Transparent
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDni.Location = New System.Drawing.Point(79, 34)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(38, 16)
        Me.lblDni.TabIndex = 27
        Me.lblDni.Text = "DNI:"
        '
        'txtDIRECCION
        '
        Me.txtDIRECCION.Enabled = False
        Me.txtDIRECCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIRECCION.Location = New System.Drawing.Point(120, 118)
        Me.txtDIRECCION.MaxLength = 50
        Me.txtDIRECCION.Multiline = True
        Me.txtDIRECCION.Name = "txtDIRECCION"
        Me.txtDIRECCION.Size = New System.Drawing.Size(169, 25)
        Me.txtDIRECCION.TabIndex = 4
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Enabled = False
        Me.txtNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE.Location = New System.Drawing.Point(121, 90)
        Me.txtNOMBRE.MaxLength = 50
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(168, 22)
        Me.txtNOMBRE.TabIndex = 3
        '
        'txtAPELLIDO
        '
        Me.txtAPELLIDO.Enabled = False
        Me.txtAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPELLIDO.Location = New System.Drawing.Point(120, 60)
        Me.txtAPELLIDO.MaxLength = 50
        Me.txtAPELLIDO.Name = "txtAPELLIDO"
        Me.txtAPELLIDO.Size = New System.Drawing.Size(169, 22)
        Me.txtAPELLIDO.TabIndex = 2
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
        Me.BtnAyuda.Location = New System.Drawing.Point(567, 12)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(71, 60)
        Me.BtnAyuda.TabIndex = 86
        Me.BtnAyuda.Text = "INFO"
        Me.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAyuda.UseVisualStyleBackColor = False
        '
        'ListadoClientes
        '
        Me.ListadoClientes.BackColor = System.Drawing.Color.Transparent
        Me.ListadoClientes.Controls.Add(Me.Linfo)
        Me.ListadoClientes.Controls.Add(Me.LAlta)
        Me.ListadoClientes.Controls.Add(Me.BtnAyuda)
        Me.ListadoClientes.Controls.Add(Me.LEliminar)
        Me.ListadoClientes.Controls.Add(Me.Label3)
        Me.ListadoClientes.Controls.Add(Me.Label7)
        Me.ListadoClientes.Controls.Add(Me.dtgCLIENTES)
        Me.ListadoClientes.Controls.Add(Me.Label6)
        Me.ListadoClientes.Controls.Add(Me.tbxBUSCADNI)
        Me.ListadoClientes.Controls.Add(Me.tbxBUSCAAPE)
        Me.ListadoClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListadoClientes.Location = New System.Drawing.Point(16, 376)
        Me.ListadoClientes.Name = "ListadoClientes"
        Me.ListadoClientes.Size = New System.Drawing.Size(644, 339)
        Me.ListadoClientes.TabIndex = 80
        Me.ListadoClientes.TabStop = False
        Me.ListadoClientes.Text = "Busqueda de Clientes"
        Me.ListadoClientes.Visible = False
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(-4, 220)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(656, 33)
        Me.Linfo.TabIndex = 90
        Me.Linfo.Text = "Disculpe,No hay Clientes en la base de datos "
        Me.Linfo.Visible = False
        '
        'LAlta
        '
        Me.LAlta.AutoSize = True
        Me.LAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAlta.ForeColor = System.Drawing.Color.DarkRed
        Me.LAlta.Location = New System.Drawing.Point(44, 115)
        Me.LAlta.Name = "LAlta"
        Me.LAlta.Size = New System.Drawing.Size(569, 16)
        Me.LAlta.TabIndex = 75
        Me.LAlta.Text = "Para Dar de alta, haga doble clic en la lista y luego presione el boton Dar de al" &
    "ta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LEliminar
        '
        Me.LEliminar.AutoSize = True
        Me.LEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEliminar.ForeColor = System.Drawing.Color.DarkRed
        Me.LEliminar.Location = New System.Drawing.Point(44, 92)
        Me.LEliminar.Name = "LEliminar"
        Me.LEliminar.Size = New System.Drawing.Size(579, 16)
        Me.LEliminar.TabIndex = 74
        Me.LEliminar.Text = "Para Dar de baja, haga doble clic en la lista y luego presione el boton Dar de ba" &
    "ja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(42, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = " Búsqueda por"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(415, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Por DNI"
        '
        'dtgCLIENTES
        '
        Me.dtgCLIENTES.AllowUserToAddRows = False
        Me.dtgCLIENTES.AllowUserToDeleteRows = False
        Me.dtgCLIENTES.AllowUserToResizeColumns = False
        Me.dtgCLIENTES.AllowUserToResizeRows = False
        Me.dtgCLIENTES.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCLIENTES.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.dtgCLIENTES.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgCLIENTES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCLIENTES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgCLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCLIENTES.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgCLIENTES.Location = New System.Drawing.Point(122, 147)
        Me.dtgCLIENTES.MultiSelect = False
        Me.dtgCLIENTES.Name = "dtgCLIENTES"
        Me.dtgCLIENTES.ReadOnly = True
        Me.dtgCLIENTES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCLIENTES.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgCLIENTES.RowHeadersVisible = False
        Me.dtgCLIENTES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgCLIENTES.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgCLIENTES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgCLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCLIENTES.Size = New System.Drawing.Size(384, 175)
        Me.dtgCLIENTES.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(204, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Por Apellido"
        '
        'tbxBUSCADNI
        '
        Me.tbxBUSCADNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCADNI.Location = New System.Drawing.Point(391, 30)
        Me.tbxBUSCADNI.Name = "tbxBUSCADNI"
        Me.tbxBUSCADNI.Size = New System.Drawing.Size(130, 22)
        Me.tbxBUSCADNI.TabIndex = 50
        '
        'tbxBUSCAAPE
        '
        Me.tbxBUSCAAPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCAAPE.Location = New System.Drawing.Point(169, 29)
        Me.tbxBUSCAAPE.Name = "tbxBUSCAAPE"
        Me.tbxBUSCAAPE.Size = New System.Drawing.Size(172, 22)
        Me.tbxBUSCAAPE.TabIndex = 49
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
        Me.panel2.Size = New System.Drawing.Size(679, 40)
        Me.panel2.TabIndex = 83
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(169, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Alta/Baja  de Clientes"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(643, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'LabelLista
        '
        Me.LabelLista.AutoSize = True
        Me.LabelLista.BackColor = System.Drawing.Color.Transparent
        Me.LabelLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLista.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelLista.Location = New System.Drawing.Point(44, 718)
        Me.LabelLista.Name = "LabelLista"
        Me.LabelLista.Size = New System.Drawing.Size(565, 36)
        Me.LabelLista.TabIndex = 85
        Me.LabelLista.Text = "Este listado es de todos los Clientes que se encuentran  Activos/Inactivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormEliminarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(679, 762)
        Me.Controls.Add(Me.LabelLista)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListadoClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEliminarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ALTA/BAJA  de Cliente"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ListadoClientes.ResumeLayout(False)
        Me.ListadoClientes.PerformLayout()
        CType(Me.dtgCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnELIMINAR As Button
    Friend WithEvents TextFecha As TextBox
    Friend WithEvents comboPROVINCIA As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEMAIL As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTELEFONO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextDNI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txtDIRECCION As TextBox
    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents txtAPELLIDO As TextBox
    Friend WithEvents ListadoClientes As GroupBox
    Friend WithEvents LEliminar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtgCLIENTES As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxBUSCADNI As TextBox
    Friend WithEvents tbxBUSCAAPE As TextBox
    Friend WithEvents BtnActivar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLIMPIAR As Button
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents LAlta As Label
    Friend WithEvents LabelLista As Label
    Private WithEvents BtnAyuda As Button
    Friend WithEvents ComboSexo As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Linfo As Label
End Class
