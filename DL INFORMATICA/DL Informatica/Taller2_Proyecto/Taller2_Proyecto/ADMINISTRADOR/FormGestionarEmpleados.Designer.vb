<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionarEmpleados
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
        Me.ComboTurno = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboSexo = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblEMAIL = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.ComboPROVINCIA = New System.Windows.Forms.ComboBox()
        Me.DTPfechaNac = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnELIMINAR = New System.Windows.Forms.Button()
        Me.BtnActivar = New System.Windows.Forms.Button()
        Me.lblMSJ = New System.Windows.Forms.Label()
        Me.btnAGREGAR = New System.Windows.Forms.Button()
        Me.btnMODIFICAR = New System.Windows.Forms.Button()
        Me.TextFecha = New System.Windows.Forms.TextBox()
        Me.btnLIMPIAR = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTELEFONO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtDIRECCION = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.txtAPELLIDO = New System.Windows.Forms.TextBox()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.ListadoEmpleados = New System.Windows.Forms.GroupBox()
        Me.LEliminar = New System.Windows.Forms.Label()
        Me.Linfo = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtgEMPLEADOS = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxBUSCADNI = New System.Windows.Forms.TextBox()
        Me.tbxBUSCAAPE = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ListadoEmpleados.SuspendLayout()
        CType(Me.dtgEMPLEADOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ComboTurno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ComboSexo)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblEMAIL)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.ComboPROVINCIA)
        Me.GroupBox2.Controls.Add(Me.DTPfechaNac)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TextFecha)
        Me.GroupBox2.Controls.Add(Me.btnLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtTELEFONO)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtDni)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblDireccion)
        Me.GroupBox2.Controls.Add(Me.lblTelefono)
        Me.GroupBox2.Controls.Add(Me.lblDni)
        Me.GroupBox2.Controls.Add(Me.txtDIRECCION)
        Me.GroupBox2.Controls.Add(Me.txtNOMBRE)
        Me.GroupBox2.Controls.Add(Me.txtAPELLIDO)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(112, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1129, 352)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Empleado"
        '
        'ComboTurno
        '
        Me.ComboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTurno.FormattingEnabled = True
        Me.ComboTurno.Items.AddRange(New Object() {"", "Mañana", "Tarde"})
        Me.ComboTurno.Location = New System.Drawing.Point(120, 322)
        Me.ComboTurno.Name = "ComboTurno"
        Me.ComboTurno.Size = New System.Drawing.Size(121, 24)
        Me.ComboTurno.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(70, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Turno:"
        '
        'ComboSexo
        '
        Me.ComboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSexo.FormattingEnabled = True
        Me.ComboSexo.Items.AddRange(New Object() {"", "Masculino", "Femenino"})
        Me.ComboSexo.Location = New System.Drawing.Point(120, 235)
        Me.ComboSexo.Name = "ComboSexo"
        Me.ComboSexo.Size = New System.Drawing.Size(121, 24)
        Me.ComboSexo.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(70, 239)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 16)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Sexo:"
        '
        'lblEMAIL
        '
        Me.lblEMAIL.AutoSize = True
        Me.lblEMAIL.BackColor = System.Drawing.Color.Transparent
        Me.lblEMAIL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEMAIL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEMAIL.Location = New System.Drawing.Point(69, 208)
        Me.lblEMAIL.Name = "lblEMAIL"
        Me.lblEMAIL.Size = New System.Drawing.Size(51, 16)
        Me.lblEMAIL.TabIndex = 82
        Me.lblEMAIL.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(120, 205)
        Me.txtEmail.MaxLength = 20
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(168, 22)
        Me.txtEmail.TabIndex = 7
        '
        'ComboPROVINCIA
        '
        Me.ComboPROVINCIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPROVINCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboPROVINCIA.FormattingEnabled = True
        Me.ComboPROVINCIA.Location = New System.Drawing.Point(121, 148)
        Me.ComboPROVINCIA.Name = "ComboPROVINCIA"
        Me.ComboPROVINCIA.Size = New System.Drawing.Size(168, 24)
        Me.ComboPROVINCIA.TabIndex = 5
        '
        'DTPfechaNac
        '
        Me.DTPfechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPfechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPfechaNac.Location = New System.Drawing.Point(120, 265)
        Me.DTPfechaNac.MaxDate = New Date(2209, 12, 31, 0, 0, 0, 0)
        Me.DTPfechaNac.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DTPfechaNac.Name = "DTPfechaNac"
        Me.DTPfechaNac.Size = New System.Drawing.Size(97, 22)
        Me.DTPfechaNac.TabIndex = 9
        Me.DTPfechaNac.Value = New Date(2018, 10, 1, 0, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnELIMINAR)
        Me.GroupBox3.Controls.Add(Me.BtnActivar)
        Me.GroupBox3.Controls.Add(Me.lblMSJ)
        Me.GroupBox3.Controls.Add(Me.btnAGREGAR)
        Me.GroupBox3.Controls.Add(Me.btnMODIFICAR)
        Me.GroupBox3.Location = New System.Drawing.Point(320, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(577, 225)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elija la opcion que desea realizar"
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
        Me.btnELIMINAR.Location = New System.Drawing.Point(310, 26)
        Me.btnELIMINAR.Name = "btnELIMINAR"
        Me.btnELIMINAR.Size = New System.Drawing.Size(124, 157)
        Me.btnELIMINAR.TabIndex = 13
        Me.btnELIMINAR.Text = "Dar de Baja"
        Me.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnELIMINAR.UseVisualStyleBackColor = False
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
        Me.BtnActivar.Location = New System.Drawing.Point(444, 27)
        Me.BtnActivar.Name = "BtnActivar"
        Me.BtnActivar.Size = New System.Drawing.Size(124, 157)
        Me.BtnActivar.TabIndex = 14
        Me.BtnActivar.Text = "Dar de Alta"
        Me.BtnActivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActivar.UseVisualStyleBackColor = False
        '
        'lblMSJ
        '
        Me.lblMSJ.AutoSize = True
        Me.lblMSJ.BackColor = System.Drawing.Color.Transparent
        Me.lblMSJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSJ.ForeColor = System.Drawing.Color.Black
        Me.lblMSJ.Location = New System.Drawing.Point(16, 187)
        Me.lblMSJ.Name = "lblMSJ"
        Me.lblMSJ.Size = New System.Drawing.Size(145, 24)
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
        Me.btnAGREGAR.TabIndex = 11
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
        Me.btnMODIFICAR.Location = New System.Drawing.Point(173, 26)
        Me.btnMODIFICAR.Name = "btnMODIFICAR"
        Me.btnMODIFICAR.Size = New System.Drawing.Size(124, 157)
        Me.btnMODIFICAR.TabIndex = 12
        Me.btnMODIFICAR.Text = "Modificar"
        Me.btnMODIFICAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnMODIFICAR.UseVisualStyleBackColor = False
        '
        'TextFecha
        '
        Me.TextFecha.Enabled = False
        Me.TextFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFecha.Location = New System.Drawing.Point(120, 294)
        Me.TextFecha.Name = "TextFecha"
        Me.TextFecha.Size = New System.Drawing.Size(85, 22)
        Me.TextFecha.TabIndex = 7
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
        Me.btnLIMPIAR.Location = New System.Drawing.Point(324, 257)
        Me.btnLIMPIAR.Name = "btnLIMPIAR"
        Me.btnLIMPIAR.Size = New System.Drawing.Size(108, 53)
        Me.btnLIMPIAR.TabIndex = 15
        Me.btnLIMPIAR.Text = "      Limpiar"
        Me.btnLIMPIAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLIMPIAR.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(-3, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 15)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Fecha Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Fecha ingreso:"
        '
        'txtTELEFONO
        '
        Me.txtTELEFONO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTELEFONO.Location = New System.Drawing.Point(121, 177)
        Me.txtTELEFONO.MaxLength = 10
        Me.txtTELEFONO.Name = "txtTELEFONO"
        Me.txtTELEFONO.Size = New System.Drawing.Size(168, 22)
        Me.txtTELEFONO.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(44, 180)
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
        Me.Label1.Location = New System.Drawing.Point(45, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nombre:"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(120, 32)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(169, 22)
        Me.txtDni.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(44, 66)
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
        Me.lblDireccion.Location = New System.Drawing.Point(39, 121)
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
        Me.lblTelefono.Location = New System.Drawing.Point(40, 152)
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
        Me.lblDni.Location = New System.Drawing.Point(45, 38)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(38, 16)
        Me.lblDni.TabIndex = 27
        Me.lblDni.Text = "DNI:"
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
        'txtNOMBRE
        '
        Me.txtNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNOMBRE.Location = New System.Drawing.Point(121, 90)
        Me.txtNOMBRE.MaxLength = 50
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.Size = New System.Drawing.Size(168, 22)
        Me.txtNOMBRE.TabIndex = 3
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
        'BtnAyuda
        '
        Me.BtnAyuda.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Help
        Me.BtnAyuda.FlatAppearance.BorderSize = 0
        Me.BtnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAyuda.ForeColor = System.Drawing.Color.GhostWhite
        Me.BtnAyuda.Image = Global.Taller2_Proyecto.My.Resources.Resources.customer_service1
        Me.BtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAyuda.Location = New System.Drawing.Point(1227, 21)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(100, 60)
        Me.BtnAyuda.TabIndex = 76
        Me.BtnAyuda.Text = "Ayuda"
        Me.BtnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAyuda.UseVisualStyleBackColor = False
        '
        'ListadoEmpleados
        '
        Me.ListadoEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.ListadoEmpleados.Controls.Add(Me.LEliminar)
        Me.ListadoEmpleados.Controls.Add(Me.Linfo)
        Me.ListadoEmpleados.Controls.Add(Me.LModificar)
        Me.ListadoEmpleados.Controls.Add(Me.Label3)
        Me.ListadoEmpleados.Controls.Add(Me.Label7)
        Me.ListadoEmpleados.Controls.Add(Me.dtgEMPLEADOS)
        Me.ListadoEmpleados.Controls.Add(Me.BtnAyuda)
        Me.ListadoEmpleados.Controls.Add(Me.Label6)
        Me.ListadoEmpleados.Controls.Add(Me.tbxBUSCADNI)
        Me.ListadoEmpleados.Controls.Add(Me.tbxBUSCAAPE)
        Me.ListadoEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListadoEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ListadoEmpleados.Location = New System.Drawing.Point(12, 404)
        Me.ListadoEmpleados.Name = "ListadoEmpleados"
        Me.ListadoEmpleados.Size = New System.Drawing.Size(1333, 319)
        Me.ListadoEmpleados.TabIndex = 77
        Me.ListadoEmpleados.TabStop = False
        Me.ListadoEmpleados.Text = "Busqueda de Empleados"
        '
        'LEliminar
        '
        Me.LEliminar.AutoSize = True
        Me.LEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEliminar.ForeColor = System.Drawing.Color.DarkRed
        Me.LEliminar.Location = New System.Drawing.Point(58, 87)
        Me.LEliminar.Name = "LEliminar"
        Me.LEliminar.Size = New System.Drawing.Size(622, 54)
        Me.LEliminar.TabIndex = 76
        Me.LEliminar.Text = "Para Dar de baja, haga doble clic en la lista y luego presione el boton Dar de Ba" &
    "ja" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para Dar de alta, haga doble clic en la lista y luego presione el boton Dar " &
    "de Alta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Linfo
        '
        Me.Linfo.AutoSize = True
        Me.Linfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Linfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.Linfo.Location = New System.Drawing.Point(79, 191)
        Me.Linfo.Name = "Linfo"
        Me.Linfo.Size = New System.Drawing.Size(1115, 55)
        Me.Linfo.TabIndex = 89
        Me.Linfo.Text = "Disculpe,No hay empleados en la base de datos "
        Me.Linfo.Visible = False
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.DarkRed
        Me.LModificar.Location = New System.Drawing.Point(60, 69)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(593, 18)
        Me.LModificar.TabIndex = 75
        Me.LModificar.Text = "Para modificar , haga doble clic en la lista y luego presione el boton Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(251, 21)
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
        Me.Label7.Location = New System.Drawing.Point(773, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Por DNI"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEMPLEADOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgEMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEMPLEADOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgEMPLEADOS.Location = New System.Drawing.Point(6, 144)
        Me.dtgEMPLEADOS.MultiSelect = False
        Me.dtgEMPLEADOS.Name = "dtgEMPLEADOS"
        Me.dtgEMPLEADOS.ReadOnly = True
        Me.dtgEMPLEADOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgEMPLEADOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgEMPLEADOS.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgEMPLEADOS.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgEMPLEADOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgEMPLEADOS.Size = New System.Drawing.Size(1321, 168)
        Me.dtgEMPLEADOS.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(466, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Por Apellido"
        '
        'tbxBUSCADNI
        '
        Me.tbxBUSCADNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCADNI.Location = New System.Drawing.Point(680, 21)
        Me.tbxBUSCADNI.Name = "tbxBUSCADNI"
        Me.tbxBUSCADNI.Size = New System.Drawing.Size(222, 22)
        Me.tbxBUSCADNI.TabIndex = 17
        '
        'tbxBUSCAAPE
        '
        Me.tbxBUSCAAPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCAAPE.Location = New System.Drawing.Point(379, 21)
        Me.tbxBUSCAAPE.Name = "tbxBUSCAAPE"
        Me.tbxBUSCAAPE.Size = New System.Drawing.Size(238, 22)
        Me.tbxBUSCAAPE.TabIndex = 16
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
        Me.panel2.Size = New System.Drawing.Size(1357, 40)
        Me.panel2.TabIndex = 86
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(272, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(709, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Administración  de  Empleados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1321, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(173, 726)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(904, 58)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "Este listado es de todos los Empleados que se encuentran  Activos/Inactivos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormGestionarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1357, 760)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListadoEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormGestionarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestionar Empleados"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ListadoEmpleados.ResumeLayout(False)
        Me.ListadoEmpleados.PerformLayout()
        CType(Me.dtgEMPLEADOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnLIMPIAR As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTELEFONO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txtDIRECCION As TextBox
    Friend WithEvents txtNOMBRE As TextBox
    Friend WithEvents txtAPELLIDO As TextBox
    Friend WithEvents ListadoEmpleados As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtgEMPLEADOS As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxBUSCADNI As TextBox
    Friend WithEvents tbxBUSCAAPE As TextBox
    Friend WithEvents LEliminar As Label
    Friend WithEvents LModificar As Label
    Friend WithEvents TextFecha As TextBox
    Friend WithEvents DTPfechaNac As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnActivar As Button
    Friend WithEvents lblMSJ As Label
    Friend WithEvents btnAGREGAR As Button
    Friend WithEvents btnMODIFICAR As Button
    Friend WithEvents btnELIMINAR As Button
    Friend WithEvents ComboPROVINCIA As ComboBox
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents Label11 As Label
    Private WithEvents BtnAyuda As Button
    Friend WithEvents ComboSexo As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblEMAIL As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ComboTurno As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Linfo As Label
End Class
