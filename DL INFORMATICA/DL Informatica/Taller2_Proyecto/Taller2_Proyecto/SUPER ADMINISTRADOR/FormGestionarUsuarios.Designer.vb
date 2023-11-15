<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGestionarUsuarios
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNOM = New System.Windows.Forms.TextBox()
        Me.txtAPE = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblTIPO = New System.Windows.Forms.Label()
        Me.cbxUsuario = New System.Windows.Forms.ComboBox()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.txtCLAVE = New System.Windows.Forms.TextBox()
        Me.lblCLAVE = New System.Windows.Forms.Label()
        Me.btnMODIFICAR = New System.Windows.Forms.Button()
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.dtgUSUARIOS = New System.Windows.Forms.DataGridView()
        Me.gbxBusqEmpleados = New System.Windows.Forms.GroupBox()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.BtnAyudaEmpleado = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgEMPLEADOS = New System.Windows.Forms.DataGridView()
        Me.tbxBUSCADNI = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.tbxBUSCAAPE = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscarDNI = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuscarApe = New System.Windows.Forms.TextBox()
        Me.LinfoUsuario = New System.Windows.Forms.Label()
        Me.BtnAyudaUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgUSUARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBusqEmpleados.SuspendLayout()
        CType(Me.dtgEMPLEADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNOM)
        Me.GroupBox1.Controls.Add(Me.txtAPE)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.lblTIPO)
        Me.GroupBox1.Controls.Add(Me.cbxUsuario)
        Me.GroupBox1.Controls.Add(Me.btnAGREGAR)
        Me.GroupBox1.Controls.Add(Me.txtCLAVE)
        Me.GroupBox1.Controls.Add(Me.lblCLAVE)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(7, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 284)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Usuario"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnLimpiar.Enabled = False
        Me.BtnLimpiar.FlatAppearance.BorderSize = 0
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiar.Image = Global.Taller2_Proyecto.My.Resources.Resources.escoba
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(194, 197)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(90, 41)
        Me.BtnLimpiar.TabIndex = 58
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(16, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "APELLIDO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(23, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "NOMBRE:"
        '
        'txtNOM
        '
        Me.txtNOM.Enabled = False
        Me.txtNOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOM.Location = New System.Drawing.Point(106, 83)
        Me.txtNOM.MaxLength = 8
        Me.txtNOM.Name = "txtNOM"
        Me.txtNOM.Size = New System.Drawing.Size(178, 22)
        Me.txtNOM.TabIndex = 54
        '
        'txtAPE
        '
        Me.txtAPE.Enabled = False
        Me.txtAPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPE.Location = New System.Drawing.Point(106, 54)
        Me.txtAPE.MaxLength = 8
        Me.txtAPE.Name = "txtAPE"
        Me.txtAPE.Size = New System.Drawing.Size(178, 22)
        Me.txtAPE.TabIndex = 53
        '
        'txtDNI
        '
        Me.txtDNI.Enabled = False
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(106, 26)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(178, 22)
        Me.txtDNI.TabIndex = 33
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.BackColor = System.Drawing.Color.Transparent
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDni.Location = New System.Drawing.Point(62, 32)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(38, 16)
        Me.lblDni.TabIndex = 32
        Me.lblDni.Text = "DNI:"
        '
        'lblTIPO
        '
        Me.lblTIPO.AutoSize = True
        Me.lblTIPO.BackColor = System.Drawing.Color.Transparent
        Me.lblTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIPO.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTIPO.Location = New System.Drawing.Point(41, 149)
        Me.lblTIPO.Name = "lblTIPO"
        Me.lblTIPO.Size = New System.Drawing.Size(57, 16)
        Me.lblTIPO.TabIndex = 43
        Me.lblTIPO.Text = "* TIPO:"
        '
        'cbxUsuario
        '
        Me.cbxUsuario.DisplayMember = "descripcion"
        Me.cbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUsuario.Enabled = False
        Me.cbxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUsuario.FormattingEnabled = True
        Me.cbxUsuario.Items.AddRange(New Object() {"Seleccione....."})
        Me.cbxUsuario.Location = New System.Drawing.Point(104, 144)
        Me.cbxUsuario.Name = "cbxUsuario"
        Me.cbxUsuario.Size = New System.Drawing.Size(181, 24)
        Me.cbxUsuario.TabIndex = 42
        Me.cbxUsuario.ValueMember = "id_tipoUsu"
        '
        'btnAGREGAR
        '
        Me.btnAGREGAR.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAGREGAR.Enabled = False
        Me.btnAGREGAR.FlatAppearance.BorderSize = 0
        Me.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAGREGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAGREGAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAGREGAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.AgregarCli32
        Me.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAGREGAR.Location = New System.Drawing.Point(91, 197)
        Me.btnAGREGAR.Name = "btnAGREGAR"
        Me.btnAGREGAR.Size = New System.Drawing.Size(97, 41)
        Me.btnAGREGAR.TabIndex = 36
        Me.btnAGREGAR.Text = "Agregar"
        Me.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAGREGAR.UseVisualStyleBackColor = False
        '
        'txtCLAVE
        '
        Me.txtCLAVE.Enabled = False
        Me.txtCLAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLAVE.Location = New System.Drawing.Point(106, 115)
        Me.txtCLAVE.MaxLength = 15
        Me.txtCLAVE.Name = "txtCLAVE"
        Me.txtCLAVE.Size = New System.Drawing.Size(178, 22)
        Me.txtCLAVE.TabIndex = 35
        '
        'lblCLAVE
        '
        Me.lblCLAVE.AutoSize = True
        Me.lblCLAVE.BackColor = System.Drawing.Color.Transparent
        Me.lblCLAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCLAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCLAVE.Location = New System.Drawing.Point(24, 121)
        Me.lblCLAVE.Name = "lblCLAVE"
        Me.lblCLAVE.Size = New System.Drawing.Size(70, 16)
        Me.lblCLAVE.TabIndex = 34
        Me.lblCLAVE.Text = "* CLAVE:"
        '
        'btnMODIFICAR
        '
        Me.btnMODIFICAR.BackColor = System.Drawing.Color.LimeGreen
        Me.btnMODIFICAR.Enabled = False
        Me.btnMODIFICAR.FlatAppearance.BorderSize = 0
        Me.btnMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMODIFICAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMODIFICAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.ModifCli32
        Me.btnMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMODIFICAR.Location = New System.Drawing.Point(590, 109)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(108, 41)
        Me.btnMODIFICAR.TabIndex = 74
        Me.btnMODIFICAR.Text = "Modificar"
        Me.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMODIFICAR.UseVisualStyleBackColor = False
        '
        'btnELIMINAR
        '
        Me.btnELIMINAR.BackColor = System.Drawing.Color.LimeGreen
        Me.btnELIMINAR.Enabled = False
        Me.btnELIMINAR.FlatAppearance.BorderSize = 0
        Me.btnELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnELIMINAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnELIMINAR.Image = Global.Taller2_Proyecto.My.Resources.Resources.check_box_empty
        Me.btnELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnELIMINAR.Location = New System.Drawing.Point(590, 159)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(108, 37)
        Me.btnELIMINAR.TabIndex = 73
        Me.btnELIMINAR.Text = "Dar de Baja"
        Me.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnELIMINAR.UseVisualStyleBackColor = False
        '
        'dtgUSUARIOS
        '
        Me.dtgUSUARIOS.AllowUserToAddRows = False
        Me.dtgUSUARIOS.AllowUserToDeleteRows = False
        Me.dtgUSUARIOS.AllowUserToResizeColumns = False
        Me.dtgUSUARIOS.AllowUserToResizeRows = False
        Me.dtgUSUARIOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgUSUARIOS.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.dtgUSUARIOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgUSUARIOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgUSUARIOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUSUARIOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgUSUARIOS.Location = New System.Drawing.Point(19, 76)
        Me.dtgUSUARIOS.MultiSelect = False
        Me.dtgUSUARIOS.Name = "dtgUSUARIOS"
        Me.dtgUSUARIOS.ReadOnly = True
        Me.dtgUSUARIOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgUSUARIOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgUSUARIOS.RowHeadersVisible = False
        Me.dtgUSUARIOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgUSUARIOS.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dtgUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgUSUARIOS.Size = New System.Drawing.Size(551, 177)
        Me.dtgUSUARIOS.TabIndex = 72
        '
        'gbxBusqEmpleados
        '
        Me.gbxBusqEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.gbxBusqEmpleados.Controls.Add(Me.Linfo)
        Me.gbxBusqEmpleados.Controls.Add(Me.BtnAyudaEmpleado)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label4)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label1)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label6)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label5)
        Me.gbxBusqEmpleados.Controls.Add(Me.dtgEMPLEADOS)
        Me.gbxBusqEmpleados.Controls.Add(Me.tbxBUSCADNI)
        Me.gbxBusqEmpleados.Controls.Add(Me.lblBuscar)
        Me.gbxBusqEmpleados.Controls.Add(Me.tbxBUSCAAPE)
        Me.gbxBusqEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBusqEmpleados.ForeColor = System.Drawing.Color.Black
        Me.gbxBusqEmpleados.Location = New System.Drawing.Point(6, 343)
        Me.gbxBusqEmpleados.Name = "gbxBusqEmpleados"
        Me.gbxBusqEmpleados.Size = New System.Drawing.Size(1054, 295)
        Me.gbxBusqEmpleados.TabIndex = 75
        Me.gbxBusqEmpleados.TabStop = False
        Me.gbxBusqEmpleados.Text = "Buscar Empleados"
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(-2, 163)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(1064, 35)
        Me.Linfo.TabIndex = 88
        Me.Linfo.Text = "Disculpe,No hay empleados en la base de datos o estan todos inactivos"
        Me.Linfo.Visible = False
        '
        'BtnAyudaEmpleado
        '
        Me.BtnAyudaEmpleado.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAyudaEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAyudaEmpleado.Cursor = System.Windows.Forms.Cursors.Help
        Me.BtnAyudaEmpleado.FlatAppearance.BorderSize = 0
        Me.BtnAyudaEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAyudaEmpleado.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnAyudaEmpleado.Image = Global.Taller2_Proyecto.My.Resources.Resources.customer_service1
        Me.BtnAyudaEmpleado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAyudaEmpleado.Location = New System.Drawing.Point(965, 21)
        Me.BtnAyudaEmpleado.Name = "BtnAyudaEmpleado"
        Me.BtnAyudaEmpleado.Size = New System.Drawing.Size(71, 60)
        Me.BtnAyudaEmpleado.TabIndex = 87
        Me.BtnAyudaEmpleado.Text = "Ayuda"
        Me.BtnAyudaEmpleado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnAyudaEmpleado.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(287, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(481, 58)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "La lista de empleados que estan Activos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(128, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Para que un empleado sea un usuario , debe hacer doble clic en la lista y luego e" &
    "n el boton agregar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(621, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Por DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(382, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Por Apellido"
        '
        'dtgEMPLEADOS
        '
        Me.dtgEMPLEADOS.AllowUserToAddRows = False
        Me.dtgEMPLEADOS.AllowUserToDeleteRows = False
        Me.dtgEMPLEADOS.AllowUserToResizeColumns = False
        Me.dtgEMPLEADOS.AllowUserToResizeRows = False
        Me.dtgEMPLEADOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgEMPLEADOS.BackgroundColor = System.Drawing.Color.PowderBlue
        Me.dtgEMPLEADOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgEMPLEADOS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEMPLEADOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dtgEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEMPLEADOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgEMPLEADOS.Location = New System.Drawing.Point(258, 98)
        Me.dtgEMPLEADOS.MultiSelect = False
        Me.dtgEMPLEADOS.Name = "dtgEMPLEADOS"
        Me.dtgEMPLEADOS.ReadOnly = True
        Me.dtgEMPLEADOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgEMPLEADOS.RowHeadersVisible = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgEMPLEADOS.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dtgEMPLEADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgEMPLEADOS.Size = New System.Drawing.Size(537, 157)
        Me.dtgEMPLEADOS.TabIndex = 66
        '
        'tbxBUSCADNI
        '
        Me.tbxBUSCADNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCADNI.Location = New System.Drawing.Point(552, 25)
        Me.tbxBUSCADNI.MaxLength = 8
        Me.tbxBUSCADNI.Name = "tbxBUSCADNI"
        Me.tbxBUSCADNI.Size = New System.Drawing.Size(200, 21)
        Me.tbxBUSCADNI.TabIndex = 46
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBuscar.Location = New System.Drawing.Point(229, 27)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(56, 16)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Buscar"
        '
        'tbxBUSCAAPE
        '
        Me.tbxBUSCAAPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCAAPE.Location = New System.Drawing.Point(293, 25)
        Me.tbxBUSCAAPE.MaxLength = 50
        Me.tbxBUSCAAPE.Name = "tbxBUSCAAPE"
        Me.tbxBUSCAAPE.Size = New System.Drawing.Size(246, 21)
        Me.tbxBUSCAAPE.TabIndex = 44
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtBuscarDNI)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtBuscarApe)
        Me.GroupBox2.Controls.Add(Me.LinfoUsuario)
        Me.GroupBox2.Controls.Add(Me.BtnAyudaUsuario)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.BtnActivar)
        Me.GroupBox2.Controls.Add(Me.btnMODIFICAR)
        Me.GroupBox2.Controls.Add(Me.btnELIMINAR)
        Me.GroupBox2.Controls.Add(Me.dtgUSUARIOS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(344, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(716, 284)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USUARIOS DEL SISTEMA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(397, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Por DNI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(157, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Por Apellido"
        '
        'txtBuscarDNI
        '
        Me.txtBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarDNI.Location = New System.Drawing.Point(364, 27)
        Me.txtBuscarDNI.MaxLength = 8
        Me.txtBuscarDNI.Name = "txtBuscarDNI"
        Me.txtBuscarDNI.Size = New System.Drawing.Size(128, 21)
        Me.txtBuscarDNI.TabIndex = 92
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(59, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 91
        Me.Label11.Text = "Buscar"
        '
        'txtBuscarApe
        '
        Me.txtBuscarApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarApe.Location = New System.Drawing.Point(123, 27)
        Me.txtBuscarApe.MaxLength = 50
        Me.txtBuscarApe.Name = "txtBuscarApe"
        Me.txtBuscarApe.Size = New System.Drawing.Size(186, 21)
        Me.txtBuscarApe.TabIndex = 90
        '
        'LinfoUsuario
        '
        Me.LinfoUsuario.AutoSize = True
        Me.LinfoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinfoUsuario.ForeColor = System.Drawing.Color.DarkBlue
        Me.LinfoUsuario.Location = New System.Drawing.Point(14, 149)
        Me.LinfoUsuario.Name = "LinfoUsuario"
        Me.LinfoUsuario.Size = New System.Drawing.Size(556, 29)
        Me.LinfoUsuario.TabIndex = 89
        Me.LinfoUsuario.Text = "Disculpe,No hay Usuarios en la base de datos "
        Me.LinfoUsuario.Visible = False
        '
        'BtnAyudaUsuario
        '
        Me.BtnAyudaUsuario.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAyudaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAyudaUsuario.Cursor = System.Windows.Forms.Cursors.Help
        Me.BtnAyudaUsuario.FlatAppearance.BorderSize = 0
        Me.BtnAyudaUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAyudaUsuario.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnAyudaUsuario.Image = Global.Taller2_Proyecto.My.Resources.Resources.customer_service1
        Me.BtnAyudaUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAyudaUsuario.Location = New System.Drawing.Point(613, 15)
        Me.BtnAyudaUsuario.Name = "BtnAyudaUsuario"
        Me.BtnAyudaUsuario.Size = New System.Drawing.Size(97, 42)
        Me.BtnAyudaUsuario.TabIndex = 88
        Me.BtnAyudaUsuario.Text = "Ayuda"
        Me.BtnAyudaUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAyudaUsuario.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(70, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(447, 48)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "La lista de usuarios que estan Activos/Inactivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnActivar
        '
        Me.BtnActivar.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnActivar.Enabled = False
        Me.BtnActivar.FlatAppearance.BorderSize = 0
        Me.BtnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActivar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnActivar.Image = Global.Taller2_Proyecto.My.Resources.Resources.checked_1_
        Me.BtnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActivar.Location = New System.Drawing.Point(590, 206)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(108, 37)
        Me.BtnActivar.TabIndex = 75
        Me.BtnActivar.Text = "Dar de Alta"
        Me.BtnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnActivar.UseVisualStyleBackColor = False
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
        Me.panel2.Size = New System.Drawing.Size(1086, 40)
        Me.panel2.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(314, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(364, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Administración  de  Usuarios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1050, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'FormGestionarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1086, 636)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxBusqEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGestionarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgUSUARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBusqEmpleados.ResumeLayout(False)
        Me.gbxBusqEmpleados.PerformLayout()
        CType(Me.dtgEMPLEADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNOM As TextBox
    Friend WithEvents txtAPE As TextBox
    Friend WithEvents lblTIPO As Label
    Friend WithEvents cbxUsuario As ComboBox
    Friend WithEvents btnAGREGAR As Button
    Friend WithEvents txtCLAVE As TextBox
    Friend WithEvents lblCLAVE As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents btnMODIFICAR As Button
    Friend WithEvents btnELIMINAR As Button
    Friend WithEvents dtgUSUARIOS As DataGridView
    Friend WithEvents gbxBusqEmpleados As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtgEMPLEADOS As DataGridView
    Friend WithEvents tbxBUSCADNI As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents tbxBUSCAAPE As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnActivar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents Label7 As Label
    Private WithEvents BtnAyudaEmpleado As Button
    Private WithEvents BtnAyudaUsuario As Button
    Friend WithEvents Linfo As Label
    Friend WithEvents LinfoUsuario As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscarDNI As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuscarApe As TextBox
End Class
