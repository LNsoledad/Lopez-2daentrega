<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportes
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
        Me.components = New System.ComponentModel.Container()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.BtnVentaDiaria = New System.Windows.Forms.Button()
        Me.btnMOV_ANUAL_ART = New System.Windows.Forms.Button()
        Me.btnClientesMonto = New System.Windows.Forms.Button()
        Me.btnProdMasVendFecha = New System.Windows.Forms.Button()
        Me.btnProdMasVendMarca = New System.Windows.Forms.Button()
        Me.btnProdMasVendCat = New System.Windows.Forms.Button()
        Me.BtnProductoNoVendido = New System.Windows.Forms.Button()
        Me.BtnMejorVendFecha = New System.Windows.Forms.Button()
        Me.btnIFactura = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnMejorVendTurno = New System.Windows.Forms.Button()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.panel2.Size = New System.Drawing.Size(812, 40)
        Me.panel2.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(51, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(677, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Consultar Reportes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncerrar
        '
        Me.btncerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncerrar.BackColor = System.Drawing.Color.Maroon
        Me.btncerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.ForeColor = System.Drawing.Color.White
        Me.btncerrar.Location = New System.Drawing.Point(776, 1)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(36, 36)
        Me.btncerrar.TabIndex = 2
        Me.btncerrar.Text = "X"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'BtnVentaDiaria
        '
        Me.BtnVentaDiaria.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnVentaDiaria.FlatAppearance.BorderSize = 0
        Me.BtnVentaDiaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentaDiaria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentaDiaria.Location = New System.Drawing.Point(290, 265)
        Me.BtnVentaDiaria.Name = "BtnVentaDiaria"
        Me.BtnVentaDiaria.Size = New System.Drawing.Size(223, 40)
        Me.BtnVentaDiaria.TabIndex = 99
        Me.BtnVentaDiaria.Text = "Resumen de Venta Diaria"
        Me.BtnVentaDiaria.UseVisualStyleBackColor = False
        '
        'btnMOV_ANUAL_ART
        '
        Me.btnMOV_ANUAL_ART.BackColor = System.Drawing.Color.PaleGreen
        Me.btnMOV_ANUAL_ART.FlatAppearance.BorderSize = 0
        Me.btnMOV_ANUAL_ART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMOV_ANUAL_ART.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMOV_ANUAL_ART.Location = New System.Drawing.Point(36, 76)
        Me.btnMOV_ANUAL_ART.Name = "btnMOV_ANUAL_ART"
        Me.btnMOV_ANUAL_ART.Size = New System.Drawing.Size(219, 40)
        Me.btnMOV_ANUAL_ART.TabIndex = 98
        Me.btnMOV_ANUAL_ART.Text = "Comportamiento Anual de Artic."
        Me.btnMOV_ANUAL_ART.UseVisualStyleBackColor = False
        '
        'btnClientesMonto
        '
        Me.btnClientesMonto.BackColor = System.Drawing.Color.PaleGreen
        Me.btnClientesMonto.FlatAppearance.BorderSize = 0
        Me.btnClientesMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientesMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientesMonto.Location = New System.Drawing.Point(547, 76)
        Me.btnClientesMonto.Name = "btnClientesMonto"
        Me.btnClientesMonto.Size = New System.Drawing.Size(223, 40)
        Me.btnClientesMonto.TabIndex = 96
        Me.btnClientesMonto.Text = "Ranking Clientes por Monto Acumulado"
        Me.btnClientesMonto.UseVisualStyleBackColor = False
        '
        'btnProdMasVendFecha
        '
        Me.btnProdMasVendFecha.BackColor = System.Drawing.Color.PaleGreen
        Me.btnProdMasVendFecha.FlatAppearance.BorderSize = 0
        Me.btnProdMasVendFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdMasVendFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMasVendFecha.Location = New System.Drawing.Point(296, 76)
        Me.btnProdMasVendFecha.Name = "btnProdMasVendFecha"
        Me.btnProdMasVendFecha.Size = New System.Drawing.Size(217, 40)
        Me.btnProdMasVendFecha.TabIndex = 94
        Me.btnProdMasVendFecha.Text = "Ranking de productos mas vendidos por fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnProdMasVendFecha.UseVisualStyleBackColor = False
        '
        'btnProdMasVendMarca
        '
        Me.btnProdMasVendMarca.BackColor = System.Drawing.Color.PaleGreen
        Me.btnProdMasVendMarca.FlatAppearance.BorderSize = 0
        Me.btnProdMasVendMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdMasVendMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMasVendMarca.Location = New System.Drawing.Point(296, 203)
        Me.btnProdMasVendMarca.Name = "btnProdMasVendMarca"
        Me.btnProdMasVendMarca.Size = New System.Drawing.Size(217, 40)
        Me.btnProdMasVendMarca.TabIndex = 93
        Me.btnProdMasVendMarca.Text = "Ranking de productos mas vendidos por Marca"
        Me.btnProdMasVendMarca.UseVisualStyleBackColor = False
        '
        'btnProdMasVendCat
        '
        Me.btnProdMasVendCat.BackColor = System.Drawing.Color.PaleGreen
        Me.btnProdMasVendCat.FlatAppearance.BorderSize = 0
        Me.btnProdMasVendCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdMasVendCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdMasVendCat.Location = New System.Drawing.Point(296, 141)
        Me.btnProdMasVendCat.Name = "btnProdMasVendCat"
        Me.btnProdMasVendCat.Size = New System.Drawing.Size(217, 41)
        Me.btnProdMasVendCat.TabIndex = 92
        Me.btnProdMasVendCat.Text = "Ranking de productos mas vendidos por Categoria"
        Me.btnProdMasVendCat.UseVisualStyleBackColor = False
        '
        'BtnProductoNoVendido
        '
        Me.BtnProductoNoVendido.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnProductoNoVendido.FlatAppearance.BorderSize = 0
        Me.BtnProductoNoVendido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductoNoVendido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductoNoVendido.Location = New System.Drawing.Point(36, 203)
        Me.BtnProductoNoVendido.Name = "BtnProductoNoVendido"
        Me.BtnProductoNoVendido.Size = New System.Drawing.Size(219, 41)
        Me.BtnProductoNoVendido.TabIndex = 91
        Me.BtnProductoNoVendido.Text = "Productos No Vendidos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnProductoNoVendido.UseVisualStyleBackColor = False
        '
        'BtnMejorVendFecha
        '
        Me.BtnMejorVendFecha.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnMejorVendFecha.FlatAppearance.BorderSize = 0
        Me.BtnMejorVendFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMejorVendFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMejorVendFecha.Location = New System.Drawing.Point(547, 202)
        Me.BtnMejorVendFecha.Name = "BtnMejorVendFecha"
        Me.BtnMejorVendFecha.Size = New System.Drawing.Size(223, 41)
        Me.BtnMejorVendFecha.TabIndex = 89
        Me.BtnMejorVendFecha.Text = "Ranking de Vendedores por fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnMejorVendFecha.UseVisualStyleBackColor = False
        '
        'btnIFactura
        '
        Me.btnIFactura.BackColor = System.Drawing.Color.PaleGreen
        Me.btnIFactura.FlatAppearance.BorderSize = 0
        Me.btnIFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIFactura.Location = New System.Drawing.Point(36, 141)
        Me.btnIFactura.Name = "btnIFactura"
        Me.btnIFactura.Size = New System.Drawing.Size(219, 40)
        Me.btnIFactura.TabIndex = 86
        Me.btnIFactura.Text = "Facturas de Ventas"
        Me.btnIFactura.UseVisualStyleBackColor = False
        '
        'BtnMejorVendTurno
        '
        Me.BtnMejorVendTurno.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnMejorVendTurno.FlatAppearance.BorderSize = 0
        Me.BtnMejorVendTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMejorVendTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMejorVendTurno.Location = New System.Drawing.Point(547, 265)
        Me.BtnMejorVendTurno.Name = "BtnMejorVendTurno"
        Me.BtnMejorVendTurno.Size = New System.Drawing.Size(223, 41)
        Me.BtnMejorVendTurno.TabIndex = 100
        Me.BtnMejorVendTurno.Text = "Ranking de Vendedores por turno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnMejorVendTurno.UseVisualStyleBackColor = False
        '
        'FormReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Taller2_Proyecto.My.Resources.Resources.fondo_aplicacion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 339)
        Me.Controls.Add(Me.BtnMejorVendTurno)
        Me.Controls.Add(Me.BtnVentaDiaria)
        Me.Controls.Add(Me.btnMOV_ANUAL_ART)
        Me.Controls.Add(Me.btnClientesMonto)
        Me.Controls.Add(Me.btnProdMasVendFecha)
        Me.Controls.Add(Me.btnProdMasVendMarca)
        Me.Controls.Add(Me.btnProdMasVendCat)
        Me.Controls.Add(Me.BtnProductoNoVendido)
        Me.Controls.Add(Me.BtnMejorVendFecha)
        Me.Controls.Add(Me.btnIFactura)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel2 As Panel
    Private WithEvents Label1 As Label
    Private WithEvents btncerrar As Button
    Friend WithEvents BtnVentaDiaria As Button
    Friend WithEvents btnMOV_ANUAL_ART As Button
    Friend WithEvents btnClientesMonto As Button
    Friend WithEvents btnProdMasVendFecha As Button
    Friend WithEvents btnProdMasVendMarca As Button
    Friend WithEvents btnProdMasVendCat As Button
    Friend WithEvents BtnProductoNoVendido As Button
    Friend WithEvents BtnMejorVendFecha As Button
    Friend WithEvents btnIFactura As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnMejorVendTurno As Button
End Class
