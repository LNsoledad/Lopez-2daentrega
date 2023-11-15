<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupervisor
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
        Me.BtnConsultarVentas = New System.Windows.Forms.Button()
        Me.BtnModPrecioStock = New System.Windows.Forms.Button()
        Me.BtnConsultarEmpleados = New System.Windows.Forms.Button()
        Me.BtnConsultarProductos = New System.Windows.Forms.Button()
        Me.BtnGestionarProductos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 549)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1101, 213)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elija la funcion que desea realizar"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnConsultarVentas)
        Me.Panel3.Controls.Add(Me.BtnModPrecioStock)
        Me.Panel3.Controls.Add(Me.BtnConsultarEmpleados)
        Me.Panel3.Controls.Add(Me.BtnConsultarProductos)
        Me.Panel3.Controls.Add(Me.BtnGestionarProductos)
        Me.Panel3.Location = New System.Drawing.Point(31, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1058, 182)
        Me.Panel3.TabIndex = 3
        '
        'BtnConsultarVentas
        '
        Me.BtnConsultarVentas.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarVentas.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarVentas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarVentas.Location = New System.Drawing.Point(872, 8)
        Me.BtnConsultarVentas.Name = "BtnConsultarVentas"
        Me.BtnConsultarVentas.Size = New System.Drawing.Size(192, 168)
        Me.BtnConsultarVentas.TabIndex = 4
        Me.BtnConsultarVentas.Text = "Consultar Ventas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarVentas.UseVisualStyleBackColor = False
        '
        'BtnModPrecioStock
        '
        Me.BtnModPrecioStock.BackColor = System.Drawing.Color.LightGreen
        Me.BtnModPrecioStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModPrecioStock.Image = Global.Taller2_Proyecto.My.Resources.Resources.edit_1_
        Me.BtnModPrecioStock.Location = New System.Drawing.Point(659, 8)
        Me.BtnModPrecioStock.Name = "BtnModPrecioStock"
        Me.BtnModPrecioStock.Size = New System.Drawing.Size(192, 168)
        Me.BtnModPrecioStock.TabIndex = 3
        Me.BtnModPrecioStock.Text = "Modificar Precio/Stock"
        Me.BtnModPrecioStock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnModPrecioStock.UseVisualStyleBackColor = False
        '
        'BtnConsultarEmpleados
        '
        Me.BtnConsultarEmpleados.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarEmpleados.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarEmpleados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarEmpleados.Location = New System.Drawing.Point(233, 8)
        Me.BtnConsultarEmpleados.Name = "BtnConsultarEmpleados"
        Me.BtnConsultarEmpleados.Size = New System.Drawing.Size(192, 168)
        Me.BtnConsultarEmpleados.TabIndex = 2
        Me.BtnConsultarEmpleados.Text = "Consultar Empleados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarEmpleados.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarEmpleados.UseVisualStyleBackColor = False
        '
        'BtnConsultarProductos
        '
        Me.BtnConsultarProductos.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarProductos.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarProductos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarProductos.Location = New System.Drawing.Point(447, 8)
        Me.BtnConsultarProductos.Name = "BtnConsultarProductos"
        Me.BtnConsultarProductos.Size = New System.Drawing.Size(192, 168)
        Me.BtnConsultarProductos.TabIndex = 1
        Me.BtnConsultarProductos.Text = "Consultar Productos"
        Me.BtnConsultarProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarProductos.UseVisualStyleBackColor = False
        '
        'BtnGestionarProductos
        '
        Me.BtnGestionarProductos.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGestionarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarProductos.Image = Global.Taller2_Proyecto.My.Resources.Resources.Clientes
        Me.BtnGestionarProductos.Location = New System.Drawing.Point(25, 8)
        Me.BtnGestionarProductos.Name = "BtnGestionarProductos"
        Me.BtnGestionarProductos.Size = New System.Drawing.Size(192, 168)
        Me.BtnGestionarProductos.TabIndex = 0
        Me.BtnGestionarProductos.Text = "Gestionar Productos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnGestionarProductos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGestionarProductos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Taller2_Proyecto.My.Resources.Resources.Supervisor_icon
        Me.PictureBox1.Location = New System.Drawing.Point(31, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.lblhoras)
        Me.panel2.Controls.Add(Me.lblfecha)
        Me.panel2.Controls.Add(Me.lbluser)
        Me.panel2.Controls.Add(Me.btnmin)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1101, 40)
        Me.panel2.TabIndex = 9
        '
        'lblhoras
        '
        Me.lblhoras.BackColor = System.Drawing.Color.Transparent
        Me.lblhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoras.ForeColor = System.Drawing.Color.DarkRed
        Me.lblhoras.Location = New System.Drawing.Point(13, 10)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(157, 20)
        Me.lblhoras.TabIndex = 3
        Me.lblhoras.Text = "Hora: 12:30:00"
        Me.lblhoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.DarkRed
        Me.lblfecha.Location = New System.Drawing.Point(789, 8)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(236, 25)
        Me.lblfecha.TabIndex = 4
        Me.lblfecha.Text = "Fecha: 20/09/2018"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lbluser.Size = New System.Drawing.Size(566, 28)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "Usuario Supervisor : Nicolas"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackColor = System.Drawing.Color.Maroon
        Me.btnmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmin.ForeColor = System.Drawing.Color.White
        Me.btnmin.Location = New System.Drawing.Point(1030, 1)
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
        Me.btncerrar.Location = New System.Drawing.Point(1065, 1)
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
        Me.Label1.Location = New System.Drawing.Point(47, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 34)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = """ Supervisor """
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
        Me.LVendedor.TabIndex = 10
        Me.LVendedor.Text = "Bienvenido "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Taller2_Proyecto.My.Resources.Resources.presentationThumbnail
        Me.PictureBox2.Location = New System.Drawing.Point(313, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(753, 458)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'FormSupervisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1101, 762)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSupervisor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supervisor"
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
    Friend WithEvents BtnConsultarProductos As Button
    Friend WithEvents BtnGestionarProductos As Button
    Friend WithEvents BtnConsultarEmpleados As Button
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents panel2 As Panel
    Private WithEvents lbluser As Label
    Private WithEvents btnmin As Button
    Private WithEvents btncerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LVendedor As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Private WithEvents lblhoras As Label
    Private WithEvents lblfecha As Label
    Friend WithEvents BtnModPrecioStock As Button
    Friend WithEvents BtnConsultarVentas As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
