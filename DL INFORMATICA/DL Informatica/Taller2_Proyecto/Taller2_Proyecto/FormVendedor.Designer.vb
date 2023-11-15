<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVendedor
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
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.BtnConsultarVentas = New System.Windows.Forms.Button()
        Me.BtnRealizarVenta = New System.Windows.Forms.Button()
        Me.BtnConsultarProducto = New System.Windows.Forms.Button()
        Me.BtnConsultarClientes = New System.Windows.Forms.Button()
        Me.BtnGestionarClientes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblhoras = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.LVendedor.Location = New System.Drawing.Point(32, 65)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(283, 42)
        Me.LVendedor.TabIndex = 0
        Me.LVendedor.Text = "Bienvenido "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox1.Controls.Add(Me.panel3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.GroupBox1.Location = New System.Drawing.Point(0, 549)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1130, 200)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elija la funcion que desea realizar"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.Transparent
        Me.panel3.Controls.Add(Me.BtnConsultarVentas)
        Me.panel3.Controls.Add(Me.BtnRealizarVenta)
        Me.panel3.Controls.Add(Me.BtnConsultarProducto)
        Me.panel3.Controls.Add(Me.BtnConsultarClientes)
        Me.panel3.Controls.Add(Me.BtnGestionarClientes)
        Me.panel3.Location = New System.Drawing.Point(19, 25)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1099, 162)
        Me.panel3.TabIndex = 3
        '
        'BtnConsultarVentas
        '
        Me.BtnConsultarVentas.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarVentas.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarVentas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarVentas.Location = New System.Drawing.Point(903, 6)
        Me.BtnConsultarVentas.Name = "BtnConsultarVentas"
        Me.BtnConsultarVentas.Size = New System.Drawing.Size(192, 152)
        Me.BtnConsultarVentas.TabIndex = 5
        Me.BtnConsultarVentas.Text = "Consultar Ventas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarVentas.UseVisualStyleBackColor = False
        '
        'BtnRealizarVenta
        '
        Me.BtnRealizarVenta.BackColor = System.Drawing.Color.LightGreen
        Me.BtnRealizarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRealizarVenta.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnRealizarVenta.Image = Global.Taller2_Proyecto.My.Resources.Resources.ventas
        Me.BtnRealizarVenta.Location = New System.Drawing.Point(228, 7)
        Me.BtnRealizarVenta.Name = "BtnRealizarVenta"
        Me.BtnRealizarVenta.Size = New System.Drawing.Size(192, 152)
        Me.BtnRealizarVenta.TabIndex = 3
        Me.BtnRealizarVenta.Text = "Realizar Venta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnRealizarVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRealizarVenta.UseVisualStyleBackColor = False
        '
        'BtnConsultarProducto
        '
        Me.BtnConsultarProducto.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarProducto.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnConsultarProducto.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarProducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarProducto.Location = New System.Drawing.Point(449, 7)
        Me.BtnConsultarProducto.Name = "BtnConsultarProducto"
        Me.BtnConsultarProducto.Size = New System.Drawing.Size(192, 152)
        Me.BtnConsultarProducto.TabIndex = 2
        Me.BtnConsultarProducto.Text = "Consultar Productos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnConsultarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarProducto.UseVisualStyleBackColor = False
        '
        'BtnConsultarClientes
        '
        Me.BtnConsultarClientes.BackColor = System.Drawing.Color.LightGreen
        Me.BtnConsultarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultarClientes.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnConsultarClientes.Image = Global.Taller2_Proyecto.My.Resources.Resources.Find01_128
        Me.BtnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnConsultarClientes.Location = New System.Drawing.Point(679, 5)
        Me.BtnConsultarClientes.Name = "BtnConsultarClientes"
        Me.BtnConsultarClientes.Size = New System.Drawing.Size(192, 152)
        Me.BtnConsultarClientes.TabIndex = 1
        Me.BtnConsultarClientes.Text = "Consultar Cliente"
        Me.BtnConsultarClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnConsultarClientes.UseVisualStyleBackColor = False
        '
        'BtnGestionarClientes
        '
        Me.BtnGestionarClientes.BackColor = System.Drawing.Color.LightGreen
        Me.BtnGestionarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarClientes.ForeColor = System.Drawing.Color.DarkRed
        Me.BtnGestionarClientes.Image = Global.Taller2_Proyecto.My.Resources.Resources.Clientes
        Me.BtnGestionarClientes.Location = New System.Drawing.Point(12, 7)
        Me.BtnGestionarClientes.Name = "BtnGestionarClientes"
        Me.BtnGestionarClientes.Size = New System.Drawing.Size(192, 152)
        Me.BtnGestionarClientes.TabIndex = 0
        Me.BtnGestionarClientes.Text = "Gestionar Clientes"
        Me.BtnGestionarClientes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGestionarClientes.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Taller2_Proyecto.My.Resources.Resources.vendedor2
        Me.PictureBox1.Location = New System.Drawing.Point(31, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.lbluser)
        Me.panel2.Controls.Add(Me.lblhoras)
        Me.panel2.Controls.Add(Me.lblfecha)
        Me.panel2.Controls.Add(Me.btnmin)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1130, 40)
        Me.panel2.TabIndex = 4
        '
        'lbluser
        '
        Me.lbluser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.DarkRed
        Me.lbluser.Location = New System.Drawing.Point(243, 7)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(595, 28)
        Me.lbluser.TabIndex = 2
        Me.lbluser.Text = "Usuario Vendedor : "
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhoras
        '
        Me.lblhoras.BackColor = System.Drawing.Color.Transparent
        Me.lblhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhoras.ForeColor = System.Drawing.Color.DarkRed
        Me.lblhoras.Location = New System.Drawing.Point(12, 9)
        Me.lblhoras.Name = "lblhoras"
        Me.lblhoras.Size = New System.Drawing.Size(157, 20)
        Me.lblhoras.TabIndex = 0
        Me.lblhoras.Text = "Hora: 12:30:00"
        Me.lblhoras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.DarkRed
        Me.lblfecha.Location = New System.Drawing.Point(817, 7)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(236, 25)
        Me.lblfecha.TabIndex = 2
        Me.lblfecha.Text = "Fecha: 20/09/2018"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnmin
        '
        Me.btnmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmin.BackColor = System.Drawing.Color.Maroon
        Me.btnmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmin.ForeColor = System.Drawing.Color.White
        Me.btnmin.Location = New System.Drawing.Point(1059, 1)
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
        Me.btncerrar.Location = New System.Drawing.Point(1094, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.Label1.Location = New System.Drawing.Point(71, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = """ Vendedor """ & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Taller2_Proyecto.My.Resources.Resources.presentationThumbnail
        Me.PictureBox2.Location = New System.Drawing.Point(321, 65)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(793, 459)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'FormVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1130, 749)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVendedor As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGestionarClientes As Button
    Friend WithEvents BtnConsultarClientes As Button
    Friend WithEvents BtnRealizarVenta As Button
    Friend WithEvents BtnConsultarProducto As Button
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents panel2 As Panel
    Private WithEvents lblfecha As Label
    Private WithEvents btnmin As Button
    Private WithEvents btncerrar As Button
    Private WithEvents panel3 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Private WithEvents lbluser As Label
    Private WithEvents lblhoras As Label
    Friend WithEvents BtnConsultarVentas As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
