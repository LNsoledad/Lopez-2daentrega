<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMejoresClientesPorCantComprada
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Taller2_Proyecto.DataSetProyecto()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBUSCAR = New System.Windows.Forms.Button()
        Me.dtpHASTA = New System.Windows.Forms.DateTimePicker()
        Me.dtpDESDE = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ClientesTableAdapter = New Taller2_Proyecto.DataSetProyectoTableAdapters.ClientesTableAdapter()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DataSetProyecto
        '
        'DataSetProyecto
        '
        Me.DataSetProyecto.DataSetName = "DataSetProyecto"
        Me.DataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Desde"
        '
        'btnBUSCAR
        '
        Me.btnBUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBUSCAR.FlatAppearance.BorderSize = 2
        Me.btnBUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR.Location = New System.Drawing.Point(211, 36)
        Me.btnBUSCAR.Name = "btnBUSCAR"
        Me.btnBUSCAR.Size = New System.Drawing.Size(77, 27)
        Me.btnBUSCAR.TabIndex = 15
        Me.btnBUSCAR.Text = "Buscar"
        Me.btnBUSCAR.UseVisualStyleBackColor = True
        '
        'dtpHASTA
        '
        Me.dtpHASTA.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHASTA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHASTA.Location = New System.Drawing.Point(86, 56)
        Me.dtpHASTA.Name = "dtpHASTA"
        Me.dtpHASTA.Size = New System.Drawing.Size(110, 22)
        Me.dtpHASTA.TabIndex = 14
        '
        'dtpDESDE
        '
        Me.dtpDESDE.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDESDE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDESDE.Location = New System.Drawing.Point(86, 19)
        Me.dtpDESDE.Name = "dtpDESDE"
        Me.dtpDESDE.Size = New System.Drawing.Size(110, 22)
        Me.dtpDESDE.TabIndex = 13
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetClientesPorCantidad"
        ReportDataSource1.Value = Me.ClientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Taller2_Proyecto.ReporteMejoresClientesCantComprada.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 139)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(741, 532)
        Me.ReportViewer1.TabIndex = 19
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
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
        Me.panel2.Size = New System.Drawing.Size(778, 40)
        Me.panel2.TabIndex = 91
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(59, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(638, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "INFORME DE MEJORES CLIENTES POR CANTIDAD COMPRADA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(742, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBUSCAR)
        Me.GroupBox1.Controls.Add(Me.dtpHASTA)
        Me.GroupBox1.Controls.Add(Me.dtpDESDE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(238, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 84)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FECHA A CONSULTAR"
        '
        'FormMejoresClientesPorCantComprada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 683)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FormMejoresClientesPorCantComprada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMejoresClientesPorCantComprada"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBUSCAR As Button
    Friend WithEvents dtpHASTA As DateTimePicker
    Friend WithEvents dtpDESDE As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents ClientesTableAdapter As DataSetProyectoTableAdapters.ClientesTableAdapter
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
