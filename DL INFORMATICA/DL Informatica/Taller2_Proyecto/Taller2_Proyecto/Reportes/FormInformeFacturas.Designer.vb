<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInformeFacturas
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Taller2_Proyecto.DataSetProyecto()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FacturasTableAdapter = New Taller2_Proyecto.DataSetProyectoTableAdapters.FacturasTableAdapter()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBfecha = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBUSCAR_FECHA = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.RBdniVendedor = New System.Windows.Forms.RadioButton()
        Me.RBdniCliente = New System.Windows.Forms.RadioButton()
        Me.RBNumFact = New System.Windows.Forms.RadioButton()
        Me.txt_BuscarDniVendedor = New System.Windows.Forms.TextBox()
        Me.txt_BucarDniCliente = New System.Windows.Forms.TextBox()
        Me.txt_BuscaFact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.DataSetProyecto
        '
        'DataSetProyecto
        '
        Me.DataSetProyecto.DataSetName = "DataSetProyecto"
        Me.DataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSetFacturas"
        ReportDataSource2.Value = Me.FacturasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Taller2_Proyecto.ReporteInformeFacturas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 232)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1248, 488)
        Me.ReportViewer1.TabIndex = 0
        '
        'FacturasTableAdapter
        '
        Me.FacturasTableAdapter.ClearBeforeFill = True
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.RBfecha)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.btnBUSCAR_FECHA)
        Me.groupBox1.Controls.Add(Me.dtpHasta)
        Me.groupBox1.Controls.Add(Me.dtpDesde)
        Me.groupBox1.Controls.Add(Me.RBdniVendedor)
        Me.groupBox1.Controls.Add(Me.RBdniCliente)
        Me.groupBox1.Controls.Add(Me.RBNumFact)
        Me.groupBox1.Controls.Add(Me.txt_BuscarDniVendedor)
        Me.groupBox1.Controls.Add(Me.txt_BucarDniCliente)
        Me.groupBox1.Controls.Add(Me.txt_BuscaFact)
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(171, 92)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(890, 118)
        Me.groupBox1.TabIndex = 51
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "B  U  S  C  A  R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(10, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(485, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "En todos los campos ingrese el dato y aprete enter"
        '
        'RBfecha
        '
        Me.RBfecha.AutoSize = True
        Me.RBfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBfecha.ForeColor = System.Drawing.Color.White
        Me.RBfecha.Location = New System.Drawing.Point(667, 22)
        Me.RBfecha.Name = "RBfecha"
        Me.RBfecha.Size = New System.Drawing.Size(97, 20)
        Me.RBfecha.TabIndex = 42
        Me.RBfecha.TabStop = True
        Me.RBfecha.Text = "Por Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBfecha.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(603, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Hasta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(599, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Desde"
        '
        'btnBUSCAR_FECHA
        '
        Me.btnBUSCAR_FECHA.BackColor = System.Drawing.Color.Silver
        Me.btnBUSCAR_FECHA.Enabled = False
        Me.btnBUSCAR_FECHA.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBUSCAR_FECHA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBUSCAR_FECHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUSCAR_FECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR_FECHA.Location = New System.Drawing.Point(792, 64)
        Me.btnBUSCAR_FECHA.Name = "btnBUSCAR_FECHA"
        Me.btnBUSCAR_FECHA.Size = New System.Drawing.Size(82, 27)
        Me.btnBUSCAR_FECHA.TabIndex = 40
        Me.btnBUSCAR_FECHA.Text = "Buscar"
        Me.btnBUSCAR_FECHA.UseVisualStyleBackColor = False
        '
        'dtpHasta
        '
        Me.dtpHasta.Enabled = False
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(653, 84)
        Me.dtpHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpHasta.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpHasta.TabIndex = 39
        '
        'dtpDesde
        '
        Me.dtpDesde.Enabled = False
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(653, 53)
        Me.dtpDesde.MaxDate = New Date(2090, 12, 31, 0, 0, 0, 0)
        Me.dtpDesde.MinDate = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpDesde.TabIndex = 38
        '
        'RBdniVendedor
        '
        Me.RBdniVendedor.AutoSize = True
        Me.RBdniVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBdniVendedor.Location = New System.Drawing.Point(389, 60)
        Me.RBdniVendedor.Name = "RBdniVendedor"
        Me.RBdniVendedor.Size = New System.Drawing.Size(152, 20)
        Me.RBdniVendedor.TabIndex = 36
        Me.RBdniVendedor.TabStop = True
        Me.RBdniVendedor.Text = "Por DNI Vendedor"
        Me.RBdniVendedor.UseVisualStyleBackColor = True
        '
        'RBdniCliente
        '
        Me.RBdniCliente.AutoSize = True
        Me.RBdniCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBdniCliente.Location = New System.Drawing.Point(196, 58)
        Me.RBdniCliente.Name = "RBdniCliente"
        Me.RBdniCliente.Size = New System.Drawing.Size(132, 20)
        Me.RBdniCliente.TabIndex = 35
        Me.RBdniCliente.TabStop = True
        Me.RBdniCliente.Text = "Por DNI Cliente" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RBdniCliente.UseVisualStyleBackColor = True
        '
        'RBNumFact
        '
        Me.RBNumFact.AutoSize = True
        Me.RBNumFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNumFact.Location = New System.Drawing.Point(9, 60)
        Me.RBNumFact.Name = "RBNumFact"
        Me.RBNumFact.Size = New System.Drawing.Size(133, 20)
        Me.RBNumFact.TabIndex = 34
        Me.RBNumFact.TabStop = True
        Me.RBNumFact.Text = "Nro. de Factura"
        Me.RBNumFact.UseVisualStyleBackColor = True
        '
        'txt_BuscarDniVendedor
        '
        Me.txt_BuscarDniVendedor.Enabled = False
        Me.txt_BuscarDniVendedor.Location = New System.Drawing.Point(389, 87)
        Me.txt_BuscarDniVendedor.MaxLength = 8
        Me.txt_BuscarDniVendedor.Name = "txt_BuscarDniVendedor"
        Me.txt_BuscarDniVendedor.Size = New System.Drawing.Size(128, 23)
        Me.txt_BuscarDniVendedor.TabIndex = 33
        '
        'txt_BucarDniCliente
        '
        Me.txt_BucarDniCliente.Enabled = False
        Me.txt_BucarDniCliente.Location = New System.Drawing.Point(195, 85)
        Me.txt_BucarDniCliente.MaxLength = 8
        Me.txt_BucarDniCliente.Name = "txt_BucarDniCliente"
        Me.txt_BucarDniCliente.Size = New System.Drawing.Size(126, 23)
        Me.txt_BucarDniCliente.TabIndex = 32
        '
        'txt_BuscaFact
        '
        Me.txt_BuscaFact.Enabled = False
        Me.txt_BuscaFact.Location = New System.Drawing.Point(9, 85)
        Me.txt_BuscaFact.Name = "txt_BuscaFact"
        Me.txt_BuscaFact.Size = New System.Drawing.Size(118, 23)
        Me.txt_BuscaFact.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(382, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 33)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "VENTAS / FACTURAS"
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
        Me.panel2.Size = New System.Drawing.Size(1272, 40)
        Me.panel2.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(396, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "INFORME DE FACTURAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(1236, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'FormInformeFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1272, 732)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormInformeFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormInformeFacturas"
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents FacturasTableAdapter As DataSetProyectoTableAdapters.FacturasTableAdapter
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents RBfecha As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnBUSCAR_FECHA As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents RBdniVendedor As RadioButton
    Friend WithEvents RBdniCliente As RadioButton
    Friend WithEvents RBNumFact As RadioButton
    Friend WithEvents txt_BuscarDniVendedor As TextBox
    Friend WithEvents txt_BucarDniCliente As TextBox
    Friend WithEvents txt_BuscaFact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
End Class
