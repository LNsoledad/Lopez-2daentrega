<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductosMasVendidosPorMarca
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
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Taller2_Proyecto.DataSetProyecto()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CBmarca = New System.Windows.Forms.ComboBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.btnBUSCAR = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New Taller2_Proyecto.DataSetProyectoTableAdapters.ProductosTableAdapter()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DataSetProyecto
        '
        'DataSetProyecto
        '
        Me.DataSetProyecto.DataSetName = "DataSetProyecto"
        Me.DataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetProductosMasVendidos"
        ReportDataSource1.Value = Me.ProductosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Taller2_Proyecto.ReporteProductosMasVendidosMarca.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 94)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(948, 526)
        Me.ReportViewer1.TabIndex = 0
        '
        'CBmarca
        '
        Me.CBmarca.FormattingEnabled = True
        Me.CBmarca.Items.AddRange(New Object() {"", "Mañana", "Tarde"})
        Me.CBmarca.Location = New System.Drawing.Point(88, 57)
        Me.CBmarca.Name = "CBmarca"
        Me.CBmarca.Size = New System.Drawing.Size(121, 21)
        Me.CBmarca.TabIndex = 38
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.Location = New System.Drawing.Point(12, 58)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(72, 20)
        Me.LCategoria.TabIndex = 37
        Me.LCategoria.Text = "MARCA"
        '
        'btnBUSCAR
        '
        Me.btnBUSCAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBUSCAR.FlatAppearance.BorderSize = 2
        Me.btnBUSCAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUSCAR.Location = New System.Drawing.Point(215, 53)
        Me.btnBUSCAR.Name = "btnBUSCAR"
        Me.btnBUSCAR.Size = New System.Drawing.Size(77, 27)
        Me.btnBUSCAR.TabIndex = 35
        Me.btnBUSCAR.Text = "Buscar"
        Me.btnBUSCAR.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
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
        Me.panel2.Size = New System.Drawing.Size(982, 40)
        Me.panel2.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(33, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(885, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "PRODUCTOS MAS VENDIDOS POR MARCA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(946, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'FormProductosMasVendidosPorMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 632)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.CBmarca)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.btnBUSCAR)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FormProductosMasVendidosPorMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProductosMasVendidosPorMarca"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CBmarca As ComboBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents btnBUSCAR As Button
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents ProductosTableAdapter As DataSetProyectoTableAdapters.ProductosTableAdapter
    Private WithEvents panel2 As Panel
    Private WithEvents Label8 As Label
    Private WithEvents btncerrar As Button
End Class
