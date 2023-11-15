<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarFacturas
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
        Me.BtnVerTodas = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarID_factura = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxBUSCA_FACTURA = New System.Windows.Forms.TextBox()
        Me.tbxBUSCAAPE_CLI = New System.Windows.Forms.TextBox()
        Me.dtgLISTAFACTURAS = New System.Windows.Forms.DataGridView()
        Me.VerFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetProyecto = New Taller2_Proyecto.DataSetProyecto()
        Me.VerFacturasTableAdapter = New Taller2_Proyecto.DataSetProyectoTableAdapters.VerFacturasTableAdapter()
        Me.NumFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteApeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteNomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDomicilioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteTelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DniempleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorApeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendedorNomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgLISTAFACTURAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnVerTodas)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBuscarID_factura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbxBUSCA_FACTURA)
        Me.GroupBox1.Controls.Add(Me.tbxBUSCAAPE_CLI)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(50, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 106)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de Facturas"
        '
        'BtnVerTodas
        '
        Me.BtnVerTodas.BackColor = System.Drawing.Color.Green
        Me.BtnVerTodas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerTodas.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BtnVerTodas.Location = New System.Drawing.Point(773, 18)
        Me.BtnVerTodas.Name = "BtnVerTodas"
        Me.BtnVerTodas.Size = New System.Drawing.Size(118, 38)
        Me.BtnVerTodas.TabIndex = 66
        Me.BtnVerTodas.Text = "VER TODAS"
        Me.BtnVerTodas.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(524, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "(Ingrese el Número y presione Enter)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(32, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Opciones de Búsqueda"
        '
        'btnBuscarID_factura
        '
        Me.btnBuscarID_factura.BackColor = System.Drawing.Color.Green
        Me.btnBuscarID_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarID_factura.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnBuscarID_factura.Location = New System.Drawing.Point(773, 62)
        Me.btnBuscarID_factura.Name = "btnBuscarID_factura"
        Me.btnBuscarID_factura.Size = New System.Drawing.Size(118, 38)
        Me.btnBuscarID_factura.TabIndex = 54
        Me.btnBuscarID_factura.Text = "BUSCAR"
        Me.btnBuscarID_factura.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(578, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 15)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Por N° de Factura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(255, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 15)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Por Apellido del Cliente"
        '
        'tbxBUSCA_FACTURA
        '
        Me.tbxBUSCA_FACTURA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCA_FACTURA.Location = New System.Drawing.Point(515, 29)
        Me.tbxBUSCA_FACTURA.Name = "tbxBUSCA_FACTURA"
        Me.tbxBUSCA_FACTURA.Size = New System.Drawing.Size(211, 22)
        Me.tbxBUSCA_FACTURA.TabIndex = 50
        '
        'tbxBUSCAAPE_CLI
        '
        Me.tbxBUSCAAPE_CLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBUSCAAPE_CLI.Location = New System.Drawing.Point(214, 29)
        Me.tbxBUSCAAPE_CLI.Name = "tbxBUSCAAPE_CLI"
        Me.tbxBUSCAAPE_CLI.Size = New System.Drawing.Size(238, 22)
        Me.tbxBUSCAAPE_CLI.TabIndex = 49
        '
        'dtgLISTAFACTURAS
        '
        Me.dtgLISTAFACTURAS.AllowUserToAddRows = False
        Me.dtgLISTAFACTURAS.AllowUserToDeleteRows = False
        Me.dtgLISTAFACTURAS.AllowUserToResizeColumns = False
        Me.dtgLISTAFACTURAS.AllowUserToResizeRows = False
        Me.dtgLISTAFACTURAS.AutoGenerateColumns = False
        Me.dtgLISTAFACTURAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgLISTAFACTURAS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgLISTAFACTURAS.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dtgLISTAFACTURAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLISTAFACTURAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumFacturaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ClienteDniDataGridViewTextBoxColumn, Me.ClienteApeDataGridViewTextBoxColumn, Me.ClienteNomDataGridViewTextBoxColumn, Me.ClienteDomicilioDataGridViewTextBoxColumn, Me.ClienteTelDataGridViewTextBoxColumn, Me.DniempleadoDataGridViewTextBoxColumn, Me.VendedorApeDataGridViewTextBoxColumn, Me.VendedorNomDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dtgLISTAFACTURAS.DataSource = Me.VerFacturasBindingSource
        Me.dtgLISTAFACTURAS.Location = New System.Drawing.Point(12, 127)
        Me.dtgLISTAFACTURAS.MultiSelect = False
        Me.dtgLISTAFACTURAS.Name = "dtgLISTAFACTURAS"
        Me.dtgLISTAFACTURAS.ReadOnly = True
        Me.dtgLISTAFACTURAS.RowHeadersVisible = False
        Me.dtgLISTAFACTURAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgLISTAFACTURAS.Size = New System.Drawing.Size(1043, 378)
        Me.dtgLISTAFACTURAS.TabIndex = 58
        '
        'VerFacturasBindingSource
        '
        Me.VerFacturasBindingSource.DataMember = "VerFacturas"
        Me.VerFacturasBindingSource.DataSource = Me.DataSetProyecto
        '
        'DataSetProyecto
        '
        Me.DataSetProyecto.DataSetName = "DataSetProyecto"
        Me.DataSetProyecto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VerFacturasTableAdapter
        '
        Me.VerFacturasTableAdapter.ClearBeforeFill = True
        '
        'NumFacturaDataGridViewTextBoxColumn
        '
        Me.NumFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumFactura"
        Me.NumFacturaDataGridViewTextBoxColumn.HeaderText = "NumFactura"
        Me.NumFacturaDataGridViewTextBoxColumn.Name = "NumFacturaDataGridViewTextBoxColumn"
        Me.NumFacturaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDniDataGridViewTextBoxColumn
        '
        Me.ClienteDniDataGridViewTextBoxColumn.DataPropertyName = "ClienteDni"
        Me.ClienteDniDataGridViewTextBoxColumn.HeaderText = "Dni_Cliente"
        Me.ClienteDniDataGridViewTextBoxColumn.Name = "ClienteDniDataGridViewTextBoxColumn"
        Me.ClienteDniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteApeDataGridViewTextBoxColumn
        '
        Me.ClienteApeDataGridViewTextBoxColumn.DataPropertyName = "ClienteApe"
        Me.ClienteApeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ClienteApeDataGridViewTextBoxColumn.Name = "ClienteApeDataGridViewTextBoxColumn"
        Me.ClienteApeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteNomDataGridViewTextBoxColumn
        '
        Me.ClienteNomDataGridViewTextBoxColumn.DataPropertyName = "ClienteNom"
        Me.ClienteNomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.ClienteNomDataGridViewTextBoxColumn.Name = "ClienteNomDataGridViewTextBoxColumn"
        Me.ClienteNomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteDomicilioDataGridViewTextBoxColumn
        '
        Me.ClienteDomicilioDataGridViewTextBoxColumn.DataPropertyName = "ClienteDomicilio"
        Me.ClienteDomicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio"
        Me.ClienteDomicilioDataGridViewTextBoxColumn.Name = "ClienteDomicilioDataGridViewTextBoxColumn"
        Me.ClienteDomicilioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteTelDataGridViewTextBoxColumn
        '
        Me.ClienteTelDataGridViewTextBoxColumn.DataPropertyName = "ClienteTel"
        Me.ClienteTelDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.ClienteTelDataGridViewTextBoxColumn.Name = "ClienteTelDataGridViewTextBoxColumn"
        Me.ClienteTelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniempleadoDataGridViewTextBoxColumn
        '
        Me.DniempleadoDataGridViewTextBoxColumn.DataPropertyName = "dni_empleado"
        Me.DniempleadoDataGridViewTextBoxColumn.HeaderText = "Dni_Vendedor"
        Me.DniempleadoDataGridViewTextBoxColumn.Name = "DniempleadoDataGridViewTextBoxColumn"
        Me.DniempleadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedorApeDataGridViewTextBoxColumn
        '
        Me.VendedorApeDataGridViewTextBoxColumn.DataPropertyName = "VendedorApe"
        Me.VendedorApeDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.VendedorApeDataGridViewTextBoxColumn.Name = "VendedorApeDataGridViewTextBoxColumn"
        Me.VendedorApeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VendedorNomDataGridViewTextBoxColumn
        '
        Me.VendedorNomDataGridViewTextBoxColumn.DataPropertyName = "VendedorNom"
        Me.VendedorNomDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.VendedorNomDataGridViewTextBoxColumn.Name = "VendedorNomDataGridViewTextBoxColumn"
        Me.VendedorNomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total_factura"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormListarFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1079, 512)
        Me.Controls.Add(Me.dtgLISTAFACTURAS)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FormListarFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormListarFacturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgLISTAFACTURAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarID_factura As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxBUSCA_FACTURA As TextBox
    Friend WithEvents tbxBUSCAAPE_CLI As TextBox
    Friend WithEvents dtgLISTAFACTURAS As DataGridView
    Friend WithEvents DataSetProyecto As DataSetProyecto
    Friend WithEvents VerFacturasBindingSource As BindingSource
    Friend WithEvents VerFacturasTableAdapter As DataSetProyectoTableAdapters.VerFacturasTableAdapter
    Friend WithEvents BtnVerTodas As Button
    Friend WithEvents NumFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteApeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteNomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDomicilioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteTelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DniempleadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorApeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VendedorNomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
