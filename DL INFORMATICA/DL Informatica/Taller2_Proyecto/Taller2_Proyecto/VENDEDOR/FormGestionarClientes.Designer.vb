<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionarClientes
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
        Me.ListadoClientes = New System.Windows.Forms.GroupBox()
        Me.LDarAlta = New System.Windows.Forms.Label()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtgCLIENTES = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxBUSCADNI = New System.Windows.Forms.TextBox()
        Me.tbxBUSCAAPE = New System.Windows.Forms.TextBox()
        Me.txtAPELLIDO = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.txtDIRECCION = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTELEFONO = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEMAIL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.lblMSJ = New System.Windows.Forms.Label()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.btnMODIFICAR = New System.Windows.Forms.Button()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextFecha = New System.Windows.Forms.TextBox()
        Me.ComboPROVINCIA = New System.Windows.Forms.ComboBox()
        Me.Llistado = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.ListadoClientes.SuspendLayout()
        CType(Me.dtgCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListadoClientes
        '
        Me.ListadoClientes.BackColor = System.Drawing.Color.Transparent
        Me.ListadoClientes.Controls.Add(Me.LDarAlta)
        Me.ListadoClientes.Controls.Add(Me.Linfo)
        Me.ListadoClientes.Controls.Add(Me.BtnAyuda)
        Me.ListadoClientes.Controls.Add(Me.LModificar)
        Me.ListadoClientes.Controls.Add(Me.Label3)
        Me.ListadoClientes.Controls.Add(Me.Label7)
        Me.ListadoClientes.Controls.Add(Me.dtgCLIENTES)
        Me.ListadoClientes.Controls.Add(Me.Label6)
        Me.ListadoClientes.Controls.Add(Me.tbxBUSCADNI)
        Me.ListadoClientes.Controls.Add(Me.tbxBUSCAAPE)
        Me.ListadoClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoClientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListadoClientes.Location = New System.Drawing.Point(13, 365)
        Me.ListadoClientes.Name = "ListadoClientes"
        Me.ListadoClientes.Size = New System.Drawing.Size(1025, 311)
        Me.ListadoClientes.TabIndex = 77
        Me.ListadoClientes.TabStop = False
        Me.ListadoClientes.Text = "Busqueda de Clientes"
        '
        'LDarAlta
        '
        Me.LDarAlta.AutoSize = True
        Me.LDarAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDarAlta.ForeColor = System.Drawing.Color.DarkRed
        Me.LDarAlta.Location = New System.Drawing.Point(6, 109)
        Me.LDarAlta.Name = "LDarAlta"
        Me.LDarAlta.Size = New System.Drawing.Size(709, 18)
        Me.LDarAlta.TabIndex = 91
        Me.LDarAlta.Text = "Para dar de alta , haga doble clic en el cliente de la lista y luego presione el " &
    "boton Dar de alta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(22, 190)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(990, 52)
        Me.Linfo.TabIndex = 90
        Me.Linfo.Text = "Disculpe,No hay Clientes en la base de datos "
        Me.Linfo.Visible = False
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
        Me.BtnAyuda.Location = New System.Drawing.Point(948, 21)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(71, 61)
        Me.BtnAyuda.TabIndex = 73
        Me.BtnAyuda.Text = "Ayuda"
        Me.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAyuda.UseVisualStyleBackColor = False
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.DarkRed
        Me.LModificar.Location = New System.Drawing.Point(7, 82)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(688, 18)
        Me.LModificar.TabIndex = 73
        Me.LModificar.Text = "Para modificar , haga doble clic en el cliente de la lista y luego presione el bo" &
    "ton Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(87, 32)
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
        Me.Label7.Location = New System.Drawing.Point(572, 54)
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgCLIENTES.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgCLIENTES.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgCLIENTES.Location = New System.Drawing.Point(6, 138)
        Me.dtgCLIENTES.MultiSelect = False
        Me.dtgCLIENTES.Name = "dtgCLIENTES"
        Me.dtgCLIENTES.ReadOnly = True
        Me.dtgCLIENTES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgCLIENTES.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgCLIENTES.RowHeadersVisible = False
        Me.dtgCLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCLIENTES.Size = New System.Drawing.Size(1013, 156)
        Me.dtgCLIENTES.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(286, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Por Apellido"
        '
        'tbxBUSCADNI
        '
        Me.tbxBUSCADNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCADNI.Location = New System.Drawing.Point(486, 29)
        Me.tbxBUSCADNI.Name = "tbxBUSCADNI"
        Me.tbxBUSCADNI.Size = New System.Drawing.Size(222, 22)
        Me.tbxBUSCADNI.TabIndex = 15
        '
        'tbxBUSCAAPE
        '
        Me.tbxBUSCAAPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCAAPE.Location = New System.Drawing.Point(214, 29)
        Me.tbxBUSCAAPE.Name = "tbxBUSCAAPE"
        Me.tbxBUSCAAPE.Size = New System.Drawing.Size(238, 22)
        Me.tbxBUSCAAPE.TabIndex = 14
        '
        'txtAPELLIDO
        '
        Me.txtAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPELLIDO.Location = New System.Drawing.Point(120, 60)
        Me.txtAPELLIDO.MaxLength = 50
        Me.txtAPELLIDO.Name = "txtAPELLIDO"
        Me.txtAPELLIDO.Size = New System.Drawing.Size(169, 22)
        Me.txtAPELLIDO.TabIndex = 2
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE.Location = New System.Drawing.Point(121, 90)
        Me.txtNOMBRE.MaxLength = 50
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(168, 22)
        Me.txtNOMBRE.TabIndex = 3
        '
        'txtDIRECCION
        '
        Me.txtDIRECCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIRECCION.Location = New System.Drawing.Point(120, 118)
        Me.txtDIRECCION.MaxLength = 50
        Me.txtDIRECCION.Multiline = True
        Me.txtDIRECCION.Name = "txtDIRECCION"
        Me.txtDIRECCION.Size = New System.Drawing.Size(169, 25)
        Me.txtDIRECCION.TabIndex = 4
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
        'TextDNI
        '
        Me.TextDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDNI.Location = New System.Drawing.Point(120, 32)
        Me.TextDNI.MaxLength = 8
        Me.TextDNI.Name = "TextDNI"
        Me.TextDNI.Size = New System.Drawing.Size(169, 22)
        Me.TextDNI.TabIndex = 1
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
        'txtTELEFONO
        '
        Me.txtTELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO.Location = New System.Drawing.Point(121, 184)
        Me.txtTELEFONO.MaxLength = 10
        Me.txtTELEFONO.Name = "txtTELEFONO"
        Me.txtTELEFONO.Size = New System.Drawing.Size(168, 22)
        Me.txtTELEFONO.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(121, 212)
        Me.txtEmail.MaxLength = 20
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(168, 22)
        Me.txtEmail.TabIndex = 7
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnActivar)
        Me.GroupBox3.Controls.Add(Me.lblMSJ)
        Me.GroupBox3.Controls.Add(Me.btnAGREGAR)
        Me.GroupBox3.Controls.Add(Me.btnMODIFICAR)
        Me.GroupBox3.Location = New System.Drawing.Point(348, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(472, 225)
        Me.GroupBox3.TabIndex = 62
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elija la opcion que desea realizar"
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
        Me.BtnActivar.Location = New System.Drawing.Point(318, 25)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(124, 157)
        Me.BtnActivar.TabIndex = 12
        Me.BtnActivar.Text = "Dar de Alta"
        Me.BtnActivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'lblMSJ
        '
        Me.lblMSJ.AutoSize = True
        Me.lblMSJ.BackColor = System.Drawing.Color.Transparent
        Me.lblMSJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSJ.ForeColor = System.Drawing.Color.Black
        Me.lblMSJ.Location = New System.Drawing.Point(6, 187)
        Me.lblMSJ.Name = "lblMSJ"
        Me.lblMSJ.Size = New System.Drawing.Size(168, 26)
        Me.lblMSJ.TabIndex = 46
        Me.lblMSJ.Text = "(para Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "debe completar todos los campos)"
        Me.lblMSJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAGREGAR.FlatAppearance.BorderSize = 0
        Me.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.ForeColor = System.Drawing.Color.White
        Me.btnAGREGAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.agregar_cliente
        Me.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAGREGAR.Location = New System.Drawing.Point(37, 27)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(124, 157)
        Me.btnAGREGAR.TabIndex = 10
        Me.btnAGREGAR.Text = "Agregar"
        Me.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAGREGAR.UseVisualStyleBackColor = False
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.BackColor = System.Drawing.Color.LimeGreen
        Me.btnMODIFICAR.Enabled = False
        Me.btnMODIFICAR.FlatAppearance.BorderSize = 0
        Me.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAR.ForeColor = System.Drawing.Color.White
        Me.btnMODIFICAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.editar_cliente
        Me.btnMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMODIFICAR.Location = New System.Drawing.Point(175, 26)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(124, 157)
        Me.btnMODIFICAR.TabIndex = 11
        Me.btnMODIFICAR.Text = "Modificar"
        Me.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMODIFICAR.UseVisualStyleBackColor = False
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
        Me.btnLIMPIAR.Location = New System.Drawing.Point(348, 257)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(108, 53)
        Me.btnLIMPIAR.TabIndex = 13
        Me.btnLIMPIAR.Text = "      Limpiar"
        Me.btnLIMPIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboSexo)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TextFecha)
        Me.GroupBox2.Controls.Add(Me.ComboPROVINCIA)
        Me.GroupBox2.Controls.Add(Me.btnLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox2.Location = New System.Drawing.Point(17, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1021, 316)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'ComboSexo
        '
        Me.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Items.AddRange(New Object() {"", "Masculino", "Femenino"})
        Me.ComboSexo.Location = New System.Drawing.Point(120, 272)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(121, 24)
        Me.ComboSexo.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(70, 276)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 16)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Sexo:"
        '
        'TextFecha
        '
        Me.TextFecha.Enabled = False
        Me.TextFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFecha.Location = New System.Drawing.Point(121, 240)
        Me.TextFecha.Name = "TextFecha"
        Me.TextFecha.Size = New System.Drawing.Size(85, 22)
        Me.TextFecha.TabIndex = 8
        '
        'ComboPROVINCIA
        '
        Me.ComboPROVINCIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPROVINCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboPROVINCIA.FormattingEnabled = True
        Me.ComboPROVINCIA.Items.AddRange(New Object() {"", "Chaco", "Corrientes", "Formosa", "Entre Rios", "Misiones"})
        Me.ComboPROVINCIA.Location = New System.Drawing.Point(122, 150)
        Me.ComboPROVINCIA.Name = "ComboPROVINCIA"
        Me.ComboPROVINCIA.Size = New System.Drawing.Size(166, 24)
        Me.ComboPROVINCIA.TabIndex = 5
        '
        'Llistado
        '
        Me.Llistado.AutoSize = True
        Me.Llistado.BackColor = System.Drawing.Color.Transparent
        Me.Llistado.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llistado.ForeColor = System.Drawing.Color.DarkRed
        Me.Llistado.Location = New System.Drawing.Point(94, 679)
        Me.Llistado.Name = "Llistado"
        Me.Llistado.Size = New System.Drawing.Size(868, 58)
        Me.Llistado.TabIndex = 84
        Me.Llistado.Text = "Este listado es de todos los Clientes que se encuentran  Activos/Inactivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.panel2.Size = New System.Drawing.Size(1050, 40)
        Me.panel2.TabIndex = 85
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(325, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Administración  de  Clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1014, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'FormGestionarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 711)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.Llistado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListadoClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGestionarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Clientes"
        Me.ListadoClientes.ResumeLayout(False)
        Me.ListadoClientes.PerformLayout()
        CType(Me.dtgCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListadoClientes As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtgCLIENTES As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxBUSCADNI As TextBox
    Friend WithEvents tbxBUSCAAPE As TextBox
    Friend WithEvents LModificar As Label
    Friend WithEvents txtAPELLIDO As TextBox
    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents txtDIRECCION As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTELEFONO As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEMAIL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMSJ As Label
    Friend WithEvents btnAGREGAR As Button
    Friend WithEvents btnMODIFICAR As Button
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboPROVINCIA As ComboBox
    Friend WithEvents TextFecha As TextBox
    Friend WithEvents BtnActivar As Button
    Private WithEvents BtnAyuda As Button
    Friend WithEvents Llistado As Label
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents ComboSexo As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Linfo As Label
    Friend WithEvents LDarAlta As Label
End Class
