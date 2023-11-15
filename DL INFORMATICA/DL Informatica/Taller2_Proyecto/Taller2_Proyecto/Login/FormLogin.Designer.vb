<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.CheckBoxMostrar = New System.Windows.Forms.CheckBox()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.PictureBox()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBoxMostrar
        '
        Me.CheckBoxMostrar.AutoSize = True
        Me.CheckBoxMostrar.BackColor = System.Drawing.Color.Transparent
        Me.CheckBoxMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxMostrar.ForeColor = System.Drawing.Color.DarkCyan
        Me.CheckBoxMostrar.Location = New System.Drawing.Point(187, 282)
        Me.CheckBoxMostrar.Name = "CheckBoxMostrar"
        Me.CheckBoxMostrar.Size = New System.Drawing.Size(79, 20)
        Me.CheckBoxMostrar.TabIndex = 0
        Me.CheckBoxMostrar.Text = "Mostrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBoxMostrar.UseVisualStyleBackColor = False
        '
        'TextUsuario
        '
        Me.TextUsuario.Location = New System.Drawing.Point(190, 211)
        Me.TextUsuario.MaxLength = 8
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.Size = New System.Drawing.Size(172, 20)
        Me.TextUsuario.TabIndex = 1
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(189, 250)
        Me.TextContraseña.MaxLength = 15
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextContraseña.Size = New System.Drawing.Size(174, 20)
        Me.TextContraseña.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(36, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Por favor, complete todos los campos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para continuar presione el boton de INGRESA" &
    "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(439, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SALIR"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.Image = Global.Taller2_Proyecto.My.Resources.Resources.salir1
        Me.BtnSalir.Location = New System.Drawing.Point(442, 383)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(30, 25)
        Me.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(400, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "INGRESAR"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.Image = Global.Taller2_Proyecto.My.Resources.Resources.btn_ingresar_log1
        Me.BtnIngresar.Location = New System.Drawing.Point(410, 211)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(65, 60)
        Me.BtnIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnIngresar.TabIndex = 3
        Me.BtnIngresar.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.InicioSesion2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(513, 449)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.TextContraseña)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.CheckBoxMostrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxMostrar As CheckBox
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnSalir As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnIngresar As PictureBox
End Class
