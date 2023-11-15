Public Class Efactura
    Private _id_factura As Integer
    Private _id_usuario As Integer
    Private _dni_cliente As Integer
    Private _fecha_factura As Date
    Private _total As Double
    Private _estado As Boolean


#Region "Metodos GET y SET"
    Property IdFactura As Integer
        Get
            Return _id_factura
        End Get
        Set(value As Integer)
            _id_factura = value
        End Set
    End Property

    Property IdUsuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Property DniCliente As Integer
        Get
            Return _dni_cliente
        End Get
        Set(value As Integer)
            _dni_cliente = value
        End Set
    End Property

    Property FechaFactura As Date
        Get
            Return _fecha_factura
        End Get
        Set(value As Date)
            _fecha_factura = value
        End Set
    End Property

    Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property

    Property Estado_factura As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
#End Region

#Region "CONSTRUCTORES"
    Public Sub New()

    End Sub

    Public Sub New(ByVal _id_usuario As Integer, ByVal _dni_cliente As Integer, ByVal _fechaFactura As Date, ByVal _total As Decimal, ByVal _estado As Boolean)
        IdFactura = _id_factura
        IdUsuario = _id_usuario
        DniCliente = _dni_cliente
        FechaFactura = _fechaFactura
        Total = _total
        Estado_factura = _estado
    End Sub
#End Region

#Region "Metodos"
    'se genera una instancia de mi contexto(global)
    Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

    'para insertar a la base de datos en la tabla Facturas
    'guadaFacura devuelve verdadero o falso si se pudo agregar o no, no se debe mostrar mensaje solo en la vista
    'Function GuardarFactura(ByVal oFactura As Facturas) As Boolean
    '    MsgBox("hola 2")

    '    Dim ctx As InformaticaEntities1 = New InformaticaEntities1

    '    'Dim eFactura As Facturas = New Facturas

    '    'With eFactura
    '    '    'los nombres de los campos de la tabla se asignan los valores de la clase cliente
    '    '    .id_factura = IdFactura    'id_factura es nombre de la tabla= IdFactura son de los get
    '    '    .id_usuario = IdUsuario
    '    '    .Dni_cliente = DniCliente
    '    '    .fecha_factura = FechaFactura
    '    '    .Total_factura = Total
    '    '    .estado_factura = True
    '    'End With

    '    Try
    '        ctx.Facturas.Add(oFactura)
    '        'se asigna nada mas
    '        ctx.SaveChanges()        'se guarda en la tabla
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message)

    '        Return False
    '    End Try

    'End Function

    'dado en clase
    Function GuardarFactura(ByVal encabezado As Facturas) As Boolean
        '  MsgBox("hola 3")

        Try
            ctx.Facturas.Add(encabezado)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False

        End Try
    End Function
    '-------------------------------------------
#End Region

    'para obtener la ultima factura que se realizo
    Public Function ObtenerUltimaFactura() As Integer


        Dim ultimo = (From f In ctx.Facturas
                              Select f.id_factura).Max

        Return ultimo

    End Function



    'Trae todos las facturas'
    Public Sub MostrarTodasFacturas(ByVal data As DataGridView)
        Try
            Using ctx
                Dim consulta = (From f In ctx.Facturas
                                Order By f.id_factura Descending
                                Select N_Factura = f.id_factura, Dni_Cliente = f.dni_cliente, DNI_Vendedor = f.id_usuario, Fecha = f.fecha_factura, Monto = f.total_factura).ToList
                data.DataSource = consulta
            End Using
        Catch ex As Exception
        End Try
    End Sub


    Public Sub insertarFactura(p_Factura As Facturas)

        '//El using facilita operaciones de apertura y cierre, por ejemplo
        '//de bases de datos

        Dim entidad As Prueba_ProyectoEntities = New Prueba_ProyectoEntities
        Using entidad
            '//Prueba_ProyectoEntities  es el contexto por medio del cual se accede a base de datos
            '//Ahora se invoca dentro del contexto, a una entidad del mismo tipo
            ' //del cual queremos insertar el objeto recibido como parametro
            entidad.Facturas.Add(p_Factura)
            '//Esto adiciona el objeto por medio de Entity Framework
            ' //pero es necesario salvar los cambios
            entidad.SaveChanges()

        End Using
    End Sub '//Fin metodo insertar


    Public Function ultimaVenta() As List(Of DetalleFacturas)
        Using entidad = New Prueba_ProyectoEntities
            Dim idUltimaFactura As Integer = Me.ObtenerUltimaFactura()
            Dim consulta = From df In entidad.DetalleFacturas Join f In entidad.Facturas On df.id_factura Equals f.id_factura Where df.id_factura = idUltimaFactura Select df
            Return consulta.ToList()
        End Using
    End Function


#Region "Busqueda"

    Public Sub buscarPorNumeroFactura(ByVal numFactura As Integer, ByVal data As DataGridView)
        Try
            Using ctx
                Dim busqueda = (From f In ctx.Facturas
                                Order By f.id_factura Descending
                                Where (numFactura = f.id_factura)
                                Select N_Factura = f.id_factura, Dni_Cliente = f.dni_cliente, DNI_Vendedor = f.id_usuario, Fecha = f.fecha_factura, Monto = f.total_factura).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub
    Public Sub buscarPorCliente(ByVal num_dni As Long, ByVal data As DataGridView)
        Try
            Using ctx
                Dim busqueda = (From f In ctx.Facturas
                                Order By f.id_factura Descending
                                Where (num_dni = f.dni_cliente)
                                Select N_Factura = f.id_factura, Dni_Cliente = f.dni_cliente, DNI_Vendedor = f.id_usuario, Fecha = f.fecha_factura, Monto = f.total_factura).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub buscarPorDniVendedor(ByVal num_dni As Long, ByVal data As DataGridView)
        Try
            Using ctx
                Dim busqueda = (From f In ctx.Facturas
                                Order By f.id_factura Descending
                                Where (num_dni = f.id_usuario)
                                Select N_Factura = f.id_factura, Dni_Cliente = f.dni_cliente, DNI_Vendedor = f.id_usuario, Fecha = f.fecha_factura, Monto = f.total_factura).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Public Sub mostrarPorFecha(ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal data As DataGridView)
        Try
            Using ctx
                Dim busqueda = (From f In ctx.Facturas
                                Order By f.id_factura Descending
                                Where (fechaDesde > f.fecha_factura And fechaHasta < f.fecha_factura)
                                Select N_Factura = f.id_factura, Dni_Cliente = f.dni_cliente, DNI_Vendedor = f.id_usuario, Fecha = f.fecha_factura, Monto = f.total_factura).ToList()
                data.DataSource = busqueda
            End Using
        Catch ex As Exception
        End Try
    End Sub

#End Region


#Region "cargar y filtrar"


    Public Sub MostrarFacturas(ByVal p_dni_empleado As Integer, ByVal p_datagrid As DataGridView)
        Try
            Dim listarFactura = (From p In ctx.Facturas
                                 Where p.estado_factura = True And p.Usuarios.dni_Empleados = p_dni_empleado
                                 Select IDFACTURA = p.id_factura,
                                       IMPORTE = p.Total_factura, FECHA = p.fecha_factura, CLIENTE = p.Clientes.Apellido & " " & p.Clientes.Nombre,
                                       ESTADO = p.estado_factura).ToList

            p_datagrid.DataSource = listarFactura
        Catch ex As Exception

        End Try
    End Sub

    Public Sub MostrarFacturas1(ByVal p_datagrid As DataGridView)
        Try
            Dim listarFactura = (From p In ctx.Facturas
                                 Where p.estado_factura = True
                                 Select IDFACTURA = p.id_factura,
                                       IMPORTE = p.total_factura, FECHA = p.fecha_factura, CLIENTE = p.Clientes.apellido & " " & p.Clientes.nombre,
                                       ESTADO = p.estado_factura).ToList

            p_datagrid.DataSource = listarFactura
        Catch ex As Exception

        End Try
    End Sub


#End Region
End Class
