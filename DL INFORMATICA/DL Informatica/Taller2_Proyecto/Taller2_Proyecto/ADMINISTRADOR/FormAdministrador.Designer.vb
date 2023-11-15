<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrador
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnAltaBaja = New System.Windows.Forms.Button()
        Me.BtnConsultarVentas = New System.Windows.Forms.Button()
        Me.BtnGestionarEmpleados = New System.Windows.Forms.Button()
        Me.BtnConsultarEmpleados = New System.Windows.Forms.Button()
        Me.BtnConsultarClientes = New System.Windows.Forms.Button()
        Me.BtnSolicitarReportes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(0, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1264, 200)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elija la funcion que desea realizar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnAltaBaja)
        Me.Panel3.Controls.Add(Me.BtnConsultarVentas)
        Me.Panel3.Controls.Add(Me.BtnGestionarEmpleados)
        Me.Panel3.Controls.Add(Me.BtnConsultarEmpleados)
        Me.Panel3.Controls.Add(Me.BtnConsultarClientes)
        Me.Panel3.Controls.Add(Me.BtnSolicitarReportes)
        Me.Panel3.Location = New System.Drawing.Point(21, 31)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1231, 169)
        Me.Panel3.TabIndex = 5
        '
        'BtnAltaBaja
        '
        Me.BtnAltaBaja.BackColor = System.Drawing.Color.LightGreen
        Me.BtnAltaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAltaBaja.Image = Global.Taller2_Proyecto.My.Resources.Resources.Clientes
        Me.BtnAltaBaja.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAltaBaja.Location = New System.Drawing.Point(998, 7)
        Me.BtnAltaBaja.Name = "BtnAltaBaja"
        Me.BtnAltaBaja.Size = New System.Drawing.Size(172, 148)
        Me.BtnAltaBaja.TabIndex = 6
        Me.BtnAltaBaja.Text = "Dar de Baja/Alta Clientes"
        Me.BtnAltaBaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAltaBaja.UseVisualStyleBackColor = False
        '
        'BtnConsultarVentas
        '
        Me.BtnConsultarVentas.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarVentas.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarVentas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarVentas.Location = New System.Drawing.Point(602, 7)
        Me.BtnConsultarVentas.Name = "BtnConsultarVentas"
        Me.BtnConsultarVentas.Size = New System.Drawing.Size(192, 151)
        Me.BtnConsultarVentas.TabIndex = 5
        Me.BtnConsultarVentas.Text = "Consultar Ventas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarVentas.UseVisualStyleBackColor = False
        '
        'BtnGestionarEmpleados
        '
        Me.BtnGestionarEmpleados.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGestionarEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarEmpleados.Image = Global.Taller2_Proyecto.My.Resources.Resources.Clientes
        Me.BtnGestionarEmpleados.Location = New System.Drawing.Point(8, 7)
        Me.BtnGestionarEmpleados.Name = "BtnGestionarEmpleados"
        Me.BtnGestionarEmpleados.Size = New System.Drawing.Size(192, 152)
        Me.BtnGestionarEmpleados.TabIndex = 0
        Me.BtnGestionarEmpleados.Text = "Gestionar Empleados"
        Me.BtnGestionarEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGestionarEmpleados.UseVisualStyleBackColor = False
        '
        'BtnConsultarEmpleados
        '
        Me.BtnConsultarEmpleados.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarEmpleados.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarEmpleados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarEmpleados.Location = New System.Drawing.Point(206, 9)
        Me.BtnConsultarEmpleados.Name = "BtnConsultarEmpleados"
        Me.BtnConsultarEmpleados.Size = New System.Drawing.Size(192, 152)
        Me.BtnConsultarEmpleados.TabIndex = 1
        Me.BtnConsultarEmpleados.Text = "Consultar Empleados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarEmpleados.UseVisualStyleBackColor = False
        '
        'BtnConsultarClientes
        '
        Me.BtnConsultarClientes.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarClientes.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarClientes.Location = New System.Drawing.Point(404, 8)
        Me.BtnConsultarClientes.Name = "BtnConsultarClientes"
        Me.BtnConsultarClientes.Size = New System.Drawing.Size(192, 152)
        Me.BtnConsultarClientes.TabIndex = 4
        Me.BtnConsultarClientes.Text = "Consultar Clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarClientes.UseVisualStyleBackColor = False
        '
        'BtnSolicitarReportes
        '
        Me.BtnSolicitarReportes.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSolicitarReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSolicitarReportes.Image = Global.Taller2_Proyecto.My.Resources.Resources.report
        Me.BtnSolicitarReportes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSolicitarReportes.Location = New System.Drawing.Point(800, 7)
        Me.BtnSolicitarReportes.Name = "BtnSolicitarReportes"
        Me.BtnSolicitarReportes.Size = New System.Drawing.Size(192, 151)
        Me.BtnSolicitarReportes.TabIndex = 3
        Me.BtnSolicitarReportes.Text = "Solicitar Reportes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnSolicitarReportes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSolicitarReportes.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Taller2_Proyecto.My.Resources.Resources.administrador1
        Me.PictureBox1.Location = New System.Drawing.Point(29, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.lblhoras)
        Me.panel2.Controls.Add(Me.lbluser)
        Me.panel2.Controls.Add(Me.lblfecha)
        Me.panel2.Controls.Add(Me.btnmin)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1264, 40)
        Me.panel2.TabIndex = 7
        '
        'lblhoras
        '
        Me.lblhoras.BackColor = System.Drawing.Color.Transparent
        Me.lblhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoras.ForeColor = System.Drawing.Color.DarkRed
        Me.lblhoras.Location = New System.Drawing.Point(7, 8)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(150, 20)
        Me.lblhoras.TabIndex = 10
        Me.lblhoras.Text = "Hora: 12:30:00"
        Me.lblhoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbluser
        '
        Me.lbluser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.DarkRed
        Me.lbluser.Location = New System.Drawing.Point(223, 6)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(729, 28)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "Usuario Administrador : "
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.DarkRed
        Me.lblfecha.Location = New System.Drawing.Point(962, 8)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(229, 25)
        Me.lblfecha.TabIndex = 11
        Me.lblfecha.Text = "Fecha: 20/09/2018"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackColor = System.Drawing.Color.Maroon
        Me.btnmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmin.ForeColor = System.Drawing.Color.White
        Me.btnmin.Location = New System.Drawing.Point(1193, 1)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(36, 36)
        Me.btnmin.TabIndex = 1
        Me.btnmin.Text = "--"
        Me.btnmin.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1228, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(15, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = """ Administrador""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LVendedor
        '
        Me.LVendedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.Transparent
        Me.LVendedor.Font = New System.Drawing.Font("Castellar", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.ForeColor = System.Drawing.Color.DarkBlue
        Me.LVendedor.Location = New System.Drawing.Point(24, 55)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(283, 42)
        Me.LVendedor.TabIndex = 8
        Me.LVendedor.Text = "Bienvenido "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Taller2_Proyecto.My.Resources.Resources.presentationThumbnail
        Me.PictureBox2.Location = New System.Drawing.Point(306, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(943, 439)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'FormAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 710)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSolicitarReportes As Button
    Friend WithEvents BtnConsultarEmpleados As Button
    Friend WithEvents BtnGestionarEmpleados As Button
    Friend WithEvents BtnConsultarClientes As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Private WithEvents panel2 As Panel
    Private WithEvents lbluser As Label
    Private WithEvents btnmin As Button
    Private WithEvents btncerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LVendedor As Label
    Friend WithEvents Timer1 As Timer
    Private WithEvents lblhoras As Label
    Private WithEvents lblfecha As Label
    Friend WithEvents BtnConsultarVentas As Button
    Friend WithEvents BtnAltaBaja As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
