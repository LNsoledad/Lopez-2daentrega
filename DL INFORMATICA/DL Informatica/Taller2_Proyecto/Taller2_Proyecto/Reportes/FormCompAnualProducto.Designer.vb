<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompAnualProducto
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
        Me.COMPORTAMIENTO_ANUAL_ARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Taller2_Proyecto.DataSetProyecto()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.CbxAño = New System.Windows.Forms.ComboBox()
        Me.tbxCOD = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnVerTodos = New System.Windows.Forms.Button()
        Me.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter = New Taller2_Proyecto.DataSetProyectoTableAdapters.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBcodProd = New System.Windows.Forms.RadioButton()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.COMPORTAMIENTO_ANUAL_ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'COMPORTAMIENTO_ANUAL_ARTICULOBindingSource
        '
        Me.COMPORTAMIENTO_ANUAL_ARTICULOBindingSource.DataMember = "COMPORTAMIENTO_ANUAL_ARTICULO"
        Me.COMPORTAMIENTO_ANUAL_ARTICULOBindingSource.DataSource = Me.DataSetProyecto
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
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(54, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Año"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnConsultar.FlatAppearance.BorderSize = 0
        Me.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(324, 51)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(59, 23)
        Me.btnConsultar.TabIndex = 16
        Me.btnConsultar.Text = "Ver Comportamiento"
        Me.btnConsultar.UseVisualStyleBackColor = False
        '
        'CbxAño
        '
        Me.CbxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxAño.FormattingEnabled = True
        Me.CbxAño.Items.AddRange(New Object() {"2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025"})
        Me.CbxAño.Location = New System.Drawing.Point(5, 50)
        Me.CbxAño.Name = "CbxAño"
        Me.CbxAño.Size = New System.Drawing.Size(117, 23)
        Me.CbxAño.TabIndex = 15
        '
        'tbxCOD
        '
        Me.tbxCOD.Enabled = False
        Me.tbxCOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCOD.Location = New System.Drawing.Point(132, 53)
        Me.tbxCOD.Name = "tbxCOD"
        Me.tbxCOD.Size = New System.Drawing.Size(114, 21)
        Me.tbxCOD.TabIndex = 14
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnBuscar.Enabled = False
        Me.BtnBuscar.FlatAppearance.BorderSize = 0
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(252, 50)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(66, 23)
        Me.BtnBuscar.TabIndex = 23
        Me.BtnBuscar.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetComporAnualProd"
        ReportDataSource1.Value = Me.COMPORTAMIENTO_ANUAL_ARTICULOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Taller2_Proyecto.ReporteComportamientoAnualProd.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 152)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(934, 568)
        Me.ReportViewer1.TabIndex = 24
        '
        'BtnVerTodos
        '
        Me.BtnVerTodos.BackColor = System.Drawing.Color.LimeGreen
        Me.BtnVerTodos.FlatAppearance.BorderSize = 0
        Me.BtnVerTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerTodos.Location = New System.Drawing.Point(845, 123)
        Me.BtnVerTodos.Name = "BtnVerTodos"
        Me.BtnVerTodos.Size = New System.Drawing.Size(101, 23)
        Me.BtnVerTodos.TabIndex = 25
        Me.BtnVerTodos.Text = "Ver Todos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnVerTodos.UseVisualStyleBackColor = False
        '
        'COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter
        '
        Me.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBcodProd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbxCOD)
        Me.GroupBox1.Controls.Add(Me.BtnBuscar)
        Me.GroupBox1.Controls.Add(Me.CbxAño)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(261, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 86)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por"
        '
        'RBcodProd
        '
        Me.RBcodProd.AutoSize = True
        Me.RBcodProd.Location = New System.Drawing.Point(144, 26)
        Me.RBcodProd.Name = "RBcodProd"
        Me.RBcodProd.Size = New System.Drawing.Size(111, 19)
        Me.RBcodProd.TabIndex = 19
        Me.RBcodProd.TabStop = True
        Me.RBcodProd.Text = "Cód Producto"
        Me.RBcodProd.UseVisualStyleBackColor = True
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
        Me.panel2.Size = New System.Drawing.Size(976, 40)
        Me.panel2.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(211, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(506, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "COMPORTAMIENTO ANUAL DE ARTICULOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(940, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'FormCompAnualProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(976, 732)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.BtnVerTodos)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCompAnualProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCompAnualProducto"
        CType(Me.COMPORTAMIENTO_ANUAL_ARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents CbxAño As ComboBox
    Friend WithEvents tbxCOD As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents COMPORTAMIENTO_ANUAL_ARTICULOBindingSource As BindingSource
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter As DataSetProyectoTableAdapters.COMPORTAMIENTO_ANUAL_ARTICULOTableAdapter
    Friend WithEvents BtnVerTodos As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBcodProd As RadioButton
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
End Class
