Public Class Eproductos

    Private _id_producto As Integer
    Private _id_origen As Integer
    Private _id_proveedor As Integer
    Private _precioCosto As Double
    Private _descripcion As String
    Private _id_categoria As Integer
    Private _id_marca As Integer
    Private _stock As Integer
    Private _precio As Double
    Private _estado_producto As Integer



#Region "Metodo GET y SET"
    'definir metodos get y set
    Property IdProducto As Integer
        'retorna un valor
        Get
            Return _id_producto
        End Get
        'actualiza el valor del atributo _id_producto
        Set(value As Integer)
            _id_producto = value
        End Set
    End Property

    Property IdOrigen As Integer
        'retorna un valor
        Get
            Return _id_origen
        End Get
        'actualiza el valor del atributo _id_producto
        Set(value As Integer)
            _id_origen = value
        End Set
    End Property

    Property IdProveedor As Integer
        'retorna un valor
        Get
            Return _id_proveedor
        End Get
        'actualiza el valor del atributo _id_producto
        Set(value As Integer)
            _id_proveedor = value
        End Set
    End Property

    Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Property IdCategoria As Integer
        Get
            Return _id_categoria

        End Get
        Set(value As Integer)
            _id_categoria = value
        End Set
    End Property

    Property IdMarca As Integer
        Get
            Return _id_marca
        End Get
        Set(value As Integer)
            _id_marca = value
        End Set
    End Property

    Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
        End Set
    End Property

    Property Precio As Double
        Get
            Return _precio
        End Get
        Set(value As Double)
            _precio = value
        End Set
    End Property

    Property PrecioCosto As Double
        Get
            Return _precioCosto
        End Get
        Set(value As Double)
            _precioCosto = value
        End Set
    End Property

    Property Estado As Boolean
        Get
            Return _estado_producto
        End Get
        Set(value As Boolean)
            _estado_producto = value
        End Set
    End Property

#End Region

#Region "Constructores"
    'declaracion de contructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal _id_producto As Integer, ByVal _descripcion As String, ByVal _id_categoria As Integer, ByVal _id_marca As Integer,
                    ByVal _stock As Integer, ByVal _precio As Double, ByVal _estado_producto As Integer,
                   ByVal _id_origen As Integer, ByVal _id_proveedor As Integer, ByVal _precioCosto As Double)

        'se asigna cada valor parametro a cada set
        IdProducto = _id_producto
        Descripcion = _descripcion
        IdCategoria = _id_categoria
        IdMarca = _id_marca
        Stock = _stock
        Precio = _precio
        Estado = _estado_producto
        IdOrigen = _id_origen
        IdProveedor = _id_proveedor
        PrecioCosto = _precioCosto


    End Sub

#End Region

    'se genera una instancia de mi contexto(global)
    Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities


#Region "Metodos"



    'para consultar los productos en la base de datos
    Public Sub getProductosAll(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProductos = (From p In ctx.Productos
                               Order By p.id_producto
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Categoria = p.Categorias.descripcion, Marca = p.Marcas.descripcion, Stock = p.stock, PCosto = p.precio_costo, PVenta = p.precio, Estado = p.estado, Origen = p.Origen_Producto.descripcion, Proveedor = p.Proveedores.razon_social).ToList
        'Codigo en el select es el encabezado del datagrid
        'Descripcion= es como un join , lo que trae va a ser el nombre de la categoria a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos


    End Sub


    'para consultar los productos en la base de datos que tengan un stock mayor a cero y esten activos
    Public Sub getProductosActivosConStock(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProductos = (From p In ctx.Productos
                               Where p.stock > 0 And p.estado = True
                               Order By p.id_producto
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Marca = p.Marcas.descripcion, Stock = p.stock, Precio = p.precio).ToList
        'Codigo en el select es el encabezado del datagrid
        'Descripcion= es como un join , lo que trae va a ser el nombre de la categoria a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos


    End Sub


    'para consultar los productos en la base de datos que t esten activos
    Public Sub getProductosActivos(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProductos = (From p In ctx.Productos
                               Where p.estado = True
                               Order By p.id_producto
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Categoria = p.Categorias.descripcion, Marca = p.Marcas.descripcion, Origen = p.Origen_Producto.descripcion, Stock = p.stock, Costo = p.precio_costo, P_Venta = p.precio, Proveedores = p.Proveedores.razon_social).ToList



        'Codigo en el select es el encabezado del datagrid
        'Descripcion= es como un join , lo que trae va a ser el nombre de la categoria a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos


    End Sub

    'insertamos los productos en la tabla Productos
    Function guardarproducto() As Boolean
        'dim ctx as prueba_proyectoentities = new prueba_proyectoentities

        Dim eproducto As Productos = New Productos

        With eproducto
            'los nombres de los campos de la tabla se asignan los valores de la clase producto
            .id_producto = IdProducto     'id_producto es nombre de la tabla= codigo son de los get
            .descripcion = Descripcion
            .id_categoria = IdCategoria
            .id_marca = IdMarca
            .stock = Stock
            .precio = Precio
            .estado = Estado
            .id_origen = IdOrigen
            .id_proveedor = IdProveedor
            .precio_costo = PrecioCosto
        End With

        Try
            ctx.Productos.Add(eproducto)
            'se asigna nada mas
            ctx.SaveChanges()        'se guarda en la tabla
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


    Public Sub FiltrarProductosDescripcion(ByVal grid As DataGridView, ByVal textDescripcion As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProductos = (From p In ctx.Productos
                               Where (p.descripcion.StartsWith(textDescripcion))
                               Order By p.id_producto
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Categoria = p.Categorias.descripcion, Marca = p.Marcas.descripcion, Stock = p.stock, PCosto = p.precio_costo, PVenta = p.precio, Estado = p.estado, Origen = p.Origen_Producto.descripcion, Proveedor = p.Proveedores.razon_social
                            ).ToList
        'Codigo en el select es el encabezado del datagrid
        'Categorias = p.Categorias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos

    End Sub

    Public Sub FiltrarProductosDescripcionActivos(ByVal grid As DataGridView, ByVal textDescripcion As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProductos = (From p In ctx.Productos
                               Where (p.descripcion.StartsWith(textDescripcion) And p.estado = True)
                               Order By p.id_producto
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Categoria = p.Categorias.descripcion, Marca = p.Marcas.descripcion, Origen = p.Origen_Producto.descripcion, Stock = p.stock, Costo = p.precio_costo, P_Venta = p.precio, Proveedores = p.Proveedores.razon_social
                            ).ToList
        'Codigo en el select es el encabezado del datagrid
        'Categorias = p.Categorias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos

    End Sub
    Public Sub FiltrarProductosCodigo(ByVal grid As DataGridView, ByVal num_codigo As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarProductos = (From p In ctx.Productos
                               Where (p.id_producto.ToString.StartsWith(num_codigo))
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Categoria = p.Categorias.descripcion, Marca = p.Marcas.descripcion, Stock = p.stock, PCosto = p.precio_costo, PVenta = p.precio, Estado = p.estado, Origen = p.Origen_Producto.descripcion, Proveedor = p.Proveedores.razon_social
                            ).ToList
        'codigo en el select es el encabezado del datagrid
        'Categorias= p.Categorias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos

    End Sub

    Public Sub FiltrarProductosCodigoActivos(ByVal grid As DataGridView, ByVal num_codigo As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarProductos = (From p In ctx.Productos
                               Where (p.id_producto.ToString.StartsWith(num_codigo) And p.estado = True)
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Categoria = p.Categorias.descripcion, Marca = p.Marcas.descripcion, Origen = p.Origen_Producto.descripcion, Stock = p.stock, Costo = p.precio_costo, P_Venta = p.precio, Proveedores = p.Proveedores.razon_social
                            ).ToList
        'codigo en el select es el encabezado del datagrid
        'Categorias= p.Categorias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos

    End Sub

    '-------------------------------------------Buscar en facturacion--------------------------------------------------------------------------------
    Public Sub FiltrarProductosDescripcion1(ByVal grid As DataGridView, ByVal textDescripcion As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProductos = (From p In ctx.Productos
                               Where (p.descripcion.StartsWith(textDescripcion))
                               Order By p.id_producto
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Marca = p.Marcas.descripcion, Stock = p.stock, Precio = p.precio
                            ).ToList
        'Codigo en el select es el encabezado del datagrid
        'Categorias = p.Categorias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos

    End Sub

    Public Sub FiltrarProductosCodigo1(ByVal grid As DataGridView, ByVal num_codigo As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarProductos = (From p In ctx.Productos
                               Where (p.id_producto.ToString.StartsWith(num_codigo))
                               Select Codigo = p.id_producto, Descripcion = p.descripcion, Marca = p.Marcas.descripcion, Stock = p.stock, Precio = p.precio
                            ).ToList
        'codigo en el select es el encabezado del datagrid
        'Categorias= p.Categorias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los productos que se encuentran en la base de datos

        grid.DataSource = listarProductos

    End Sub


#End Region


#Region "Cargar box"
    '---------------------------------------------------------------------------------------------------------------------------------------------------------

    Public Sub cargarBoxCategorias(ByVal combo As ComboBox)
        'leemos todas las categorias

        Dim listaCategorias = (From c In ctx.Categorias
                               Select c).ToList

        With combo
            .DataSource = listaCategorias  ' carga la fuente de datos al combo box
            .DisplayMember = "descripcion"  'lo que se quiere mostrar
            .ValueMember = "id_categoria"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 '(-1)para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With


    End Sub

    Public Sub cargarBoxMarcas(ByVal combo As ComboBox)
        'leemos todas las Marcas

        Dim listaMarcas = (From c In ctx.Marcas
                           Select c).ToList

        With combo
            .DataSource = listaMarcas  ' carga la fuente de datos al combo box
            .DisplayMember = "descripcion"  'lo que se quiere mostrar
            .ValueMember = "id_marca"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 '(-1)para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With


    End Sub

    Public Sub cargarBoxOrigen(ByVal combo As ComboBox)
        'leemos todas las Marcas

        Dim listaMarcas = (From c In ctx.Origen_Producto
                           Select c).ToList

        With combo
            .DataSource = listaMarcas  ' carga la fuente de datos al combo box
            .DisplayMember = "descripcion"  'lo que se quiere mostrar
            .ValueMember = "id_origen"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 '(-1)para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With


    End Sub

    Public Sub cargarBoxProveedores(ByVal combo As ComboBox)
        'leemos todas las Marcas

        Dim listaMarcas = (From c In ctx.Proveedores
                           Select c).ToList

        With combo
            .DataSource = listaMarcas  ' carga la fuente de datos al combo box
            .DisplayMember = "razon_social"  'lo que se quiere mostrar
            .ValueMember = "id_proveedor"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 '(-1)para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With


    End Sub

#End Region


#Region "Actualizar,Baja,Alta"
    '--------------------------------------------------------------------------------------------------------------

    'para modificar un producto del datagrid y grabarlo en la base datos
    Public Sub actualizarProducto(ByVal p_Producto As Productos)
        Using entidad = New Prueba_ProyectoEntities
            'La sig linea pide un cliente a base de datos usando una expresion lambda. 
            'el motodo FirstOrDefault trae el primer match que encuentra haciendo un select segun id_producto
            Dim productoExistente = entidad.Productos.FirstOrDefault(Function(x) x.id_producto = p_Producto.id_producto)
            'Los datos del cliente recuperado se actualizan con los nuevos pasados en el parametro p_Cliente
            'Una entidad en estado modificado se refiere a que la entidad en cuestion se prepara
            'para recibir datos de otra
            entidad.Entry(productoExistente).State = System.Data.Entity.EntityState.Modified
            'Se setean o actualizan los valores con los datos nuevos
            entidad.Entry(productoExistente).CurrentValues.SetValues(p_Producto)
            entidad.SaveChanges()
        End Using
    End Sub

    'de la clase
    'una forma de generar es pasar los parametros para seleccionar el producto y luego hacer comparacion con los parametros

    'Function actualizar_producto(ByVal num_producto As Integer, Byval nom as String,Byval prec as Decimal,Byval id_categoria as integer) as boolean
    'Dim prod = (From p In ctx.Productos
    '            Where p.id_producto = num_producto
    '            Select p).First

    'asignamos lo que esta en la base de datos que sea igual a cada parametro pasado
    'prod.nombre=nom
    'prod.precio=prec
    'prod.categoria=id_categoria

    'Try
    '   ctx.savechanges()
    '   Return True
    'Catch ex As Exception
    'Return False
    'End Try

    'End Function

    'dim producto as Eproductos=new Eproductos(id_producto,.......) es la funcion principal usando el constructor
    'otra forma es generar antes un objeto de tipo Eproductos y llamar a actualizar_producto() pero sin pasarle parametros, pero utilizando los getters para comparar

    'Function actualizar_producto() as boolean
    'Dim prod = (From p In ctx.Productos
    '            Where p.id_producto = Id_producto(getters)
    '            Select p).First

    'asignamos lo que esta en la base de datos que sea igual a cada getters
    'prod.nombre=Nombre
    'prod.precio=Precio
    'prod.categoria=Id_categoria

    'Try
    '   ctx.savechanges()
    '   Return True
    'Catch ex As Exception
    'Return False
    'End Try

    'End Function

    Public Sub eliminarProducto(ByVal p_idProducto As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim productoExistente = entidad.Productos.FirstOrDefault(Function(x) x.id_producto = p_idProducto)
            productoExistente.estado = False
            entidad.Entry(productoExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub

    'de la clase
    'Function eliminar_Producto(ByVal num_cod As Integer) As Boolean
    'Dim prod = (From p In ctx.Productos
    '            Where p.id_producto = num_cod
    '            Select p).First

    'se modifica el estado a cero, inactivo
    'prod.estado=0


    'Try
    '   ctx.savechanges()
    '   Return True
    'Catch ex As Exception
    'Return False
    'End Try
    'End Function


    Public Sub DarDeAltaProducto(ByVal p_idProducto As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim productoExistente = entidad.Productos.FirstOrDefault(Function(x) x.id_producto = p_idProducto)
            productoExistente.estado = True
            entidad.Entry(productoExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub

    'de la clase
    'Function Activar_Producto(ByVal num_cod As Integer) As Boolean
    'Dim prod = (From p In ctx.Productos
    '            Where p.id_producto = num_cod
    '            Select p).First

    'se modifica el estado a uno, activo
    'prod.estado=1


    'Try
    '   ctx.savechanges()
    '   Return True
    'Catch ex As Exception
    'Return False
    'End Try
    'End Function
#End Region


#Region "Otros Metodos"
    'El parametro p_stock es la nueva cantidad del producto asignada arbitrariamente por el usuario habilitado
    Public Sub modificarStock(p_producto As Productos, p_stock As Integer)

        p_producto.stock = p_stock
        actualizarProducto(p_producto)
    End Sub

    'este metodo, actualiza el stock de un producto vendido, segun la cantidad vendida
    Public Sub descontarStock(p_producto As Productos, p_cantidadVendida As Integer)

        Try

            p_producto.stock = p_producto.stock - p_cantidadVendida
            actualizarProducto(p_producto)

        Catch ex As Exception

            Validacion.AccionErronea("Intento fallido de descontar mayor stock del que existe\n\n Por favor, revise el stock")
        End Try

    End Sub


    Public Function obtenerUnProducto(ByVal p_idProducto As Integer) As Productos
        Using entidad = New Prueba_ProyectoEntities
            Dim consulta = From p In entidad.Productos
                           Where p_idProducto = p.id_producto AndAlso p.estado = True
                           Select p
            Return consulta.FirstOrDefault()
        End Using
    End Function

    'dado en clase --------------------------------------------------------------------
    Public Sub ActualizarStock(ByVal codigo As Integer, ByVal cantidad As Integer)


        Dim prod = (From p In ctx.Productos
                    Where p.id_producto = codigo
                    Select p).First

        prod.stock = prod.stock - cantidad
        ctx.SaveChanges()


    End Sub
    '---------------------------------------------------------------------------
#End Region

End Class
