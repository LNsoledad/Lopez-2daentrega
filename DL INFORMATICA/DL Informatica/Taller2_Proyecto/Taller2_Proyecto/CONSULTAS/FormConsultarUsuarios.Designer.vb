<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormConsultarUsuarios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgUSUARIOS = New System.Windows.Forms.DataGridView()
        Me.gbxBusqEmpleados = New System.Windows.Forms.GroupBox()
        Me.LinfoUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscarDNI = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarApe = New System.Windows.Forms.TextBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.dtgUSUARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxBusqEmpleados.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgUSUARIOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUSUARIOS.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgUSUARIOS.Location = New System.Drawing.Point(12, 98)
        Me.dtgUSUARIOS.MultiSelect = False
        Me.dtgUSUARIOS.Name = "dtgUSUARIOS"
        Me.dtgUSUARIOS.ReadOnly = True
        Me.dtgUSUARIOS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dtgUSUARIOS.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.dtgUSUARIOS.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgUSUARIOS.Size = New System.Drawing.Size(543, 168)
        Me.dtgUSUARIOS.TabIndex = 78
        '
        'gbxBusqEmpleados
        '
        Me.gbxBusqEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.gbxBusqEmpleados.Controls.Add(Me.LinfoUsuario)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label2)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label6)
        Me.gbxBusqEmpleados.Controls.Add(Me.dtgUSUARIOS)
        Me.gbxBusqEmpleados.Controls.Add(Me.Label5)
        Me.gbxBusqEmpleados.Controls.Add(Me.txtBuscarDNI)
        Me.gbxBusqEmpleados.Controls.Add(Me.lblBuscar)
        Me.gbxBusqEmpleados.Controls.Add(Me.txtBuscarApe)
        Me.gbxBusqEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxBusqEmpleados.ForeColor = System.Drawing.Color.Black
        Me.gbxBusqEmpleados.Location = New System.Drawing.Point(12, 72)
        Me.gbxBusqEmpleados.Name = "gbxBusqEmpleados"
        Me.gbxBusqEmpleados.Size = New System.Drawing.Size(570, 301)
        Me.gbxBusqEmpleados.TabIndex = 80
        Me.gbxBusqEmpleados.TabStop = False
        Me.gbxBusqEmpleados.Text = "Buscar Usuarios"
        '
        'LinfoUsuario
        '
        Me.LinfoUsuario.AutoSize = True
        Me.LinfoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinfoUsuario.ForeColor = System.Drawing.Color.DarkBlue
        Me.LinfoUsuario.Location = New System.Drawing.Point(6, 153)
        Me.LinfoUsuario.Name = "LinfoUsuario"
        Me.LinfoUsuario.Size = New System.Drawing.Size(556, 58)
        Me.LinfoUsuario.TabIndex = 90
        Me.LinfoUsuario.Text = "Disculpe,No hay Usuarios en la base de datos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " o no hay Usuario Activos"
        Me.LinfoUsuario.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(18, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(533, 25)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Listado de todos los usuarios del sistema Activos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(368, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Por DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(128, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Por Apellido"
        '
        'txtBuscarDNI
        '
        Me.txtBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarDNI.Location = New System.Drawing.Point(335, 40)
        Me.txtBuscarDNI.MaxLength = 8
        Me.txtBuscarDNI.Name = "txtBuscarDNI"
        Me.txtBuscarDNI.Size = New System.Drawing.Size(128, 21)
        Me.txtBuscarDNI.TabIndex = 46
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBuscar.Location = New System.Drawing.Point(30, 42)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(56, 16)
        Me.lblBuscar.TabIndex = 45
        Me.lblBuscar.Text = "Buscar"
        '
        'txtBuscarApe
        '
        Me.txtBuscarApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarApe.Location = New System.Drawing.Point(92, 39)
        Me.txtBuscarApe.MaxLength = 50
        Me.txtBuscarApe.Name = "txtBuscarApe"
        Me.txtBuscarApe.Size = New System.Drawing.Size(168, 21)
        Me.txtBuscarApe.TabIndex = 44
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightGreen
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Controls.Add(Me.btncerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(600, 40)
        Me.panel2.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(90, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 28)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Consulta de Usuarios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(564, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'FormConsultarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.gbxBusqEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormConsultarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Usuarios"
        CType(Me.dtgUSUARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxBusqEmpleados.ResumeLayout(False)
        Me.gbxBusqEmpleados.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxBusqEmpleados As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBuscarDNI As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarApe As TextBox
    Private WithEvents panel2 As Panel
    Private WithEvents btncerrar As Button
    Private WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtgUSUARIOS As DataGridView
    Friend WithEvents LinfoUsuario As Label
End Class
