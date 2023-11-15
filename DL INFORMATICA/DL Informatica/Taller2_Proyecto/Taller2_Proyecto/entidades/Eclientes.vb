Public Class Eclientes

    Private _dni_cliente As Integer
    Private _id_provincia As Integer
    Private _apellido, _nombre, _telefono, _direccion, _email, _sexo As String

    Private _fecha_alta As Date
    Private _estado_cliente As Boolean

#Region "Metodos get y set"
    'declarancion de los metodos get y set de cada atributo
    Property DniCliente As Integer
        Get
            Return _dni_cliente

        End Get
        Set(value As Integer)
            _dni_cliente = value
        End Set
    End Property

    Property Apellido As String
        Get
            Return _apellido

        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Property Direccion As String
        Get
            Return _direccion

        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Property Telefono As String
        Get
            Return _telefono

        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Property Email As String
        Get
            Return _email

        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Property Fecha_alta As Date
        Get
            Return _fecha_alta

        End Get
        Set(value As Date)
            _fecha_alta = value

        End Set
    End Property

    Property Estado_cliente As Boolean
        Get
            Return _estado_cliente

        End Get
        Set(value As Boolean)
            _estado_cliente = value
        End Set
    End Property

    Property Id_Provincia As Integer
        Get
            Return _id_provincia

        End Get
        Set(value As Integer)
            _id_provincia = value

        End Set
    End Property

    Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property
#End Region


#Region "Constructores"
    'declaracion de contructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal _dni_cliente As Integer, ByVal _apellido As String, ByVal _nombre As String, ByVal _direccion As String, ByVal _telefono As String, ByVal _email As String, ByVal _fecha_alta As Date, ByVal _estado_cliente As Boolean, ByVal _id_provincia As Integer, ByVal _sexo As String)
        'se asigna cada valor parametro a cada set
        DniCliente = _dni_cliente
        Apellido = _apellido
        Nombre = _nombre
        Direccion = _direccion
        Telefono = _telefono
        Email = _email
        Fecha_alta = _fecha_alta
        Estado_cliente = _estado_cliente
        Id_Provincia = _id_provincia
        Sexo = _sexo

    End Sub

    'constructor para cuando se quiere activar a un cliente
    Public Sub New(ByVal _estado_cliente As Boolean)
        'se asigna cada valor parametro a cada set

        Estado_cliente = _estado_cliente

    End Sub


#End Region

#Region "Metodos"
    'se genera una instancia de mi contexto(global)
    Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities


    'para consultar los clientes en la base de datos
    Public Sub getClientesAll(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarClientes = (From p In ctx.Clientes
                              Order By p.Dni_clientes
                              Select DNI = p.Dni_clientes, Apellido = p.Apellido, Nombre = p.Nombre, Direccion = p.Direccion, Provincia = p.Provincia.Descripcion, Telefono = p.Telefono, Email = p.Email, Fecha_Alta = p.fecha_alta, Estado = p.Estado_cliente, Sexo = p.Sexo).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarClientes

    End Sub

    Public Sub getClientesActivos(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarClientes = (From p In ctx.Clientes
                              Where p.Estado_cliente = True
                              Order By p.Dni_clientes
                              Select DNI = p.Dni_clientes, Apellido = p.Apellido, Nombre = p.Nombre, Direccion = p.Direccion, Provincia = p.Provincia.Descripcion, Telefono = p.Telefono, Email = p.Email, Fecha_Alta = p.fecha_alta, Estado = p.Estado_cliente, Sexo = p.Sexo).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarClientes

    End Sub



    'para insertar a la base de datos en la tabla Clientes
    'guadarCliente devuelve verdadero o falso si se pudo agregar o no, no se debe mostrar mensaje solo en la vista
    Function guardarCliente() As Boolean
        Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

        Dim eCliente As Clientes = New Clientes

        With eCliente
            'los nombres de los campos de la tabla se asignan los valores de la clase cliente
            .Dni_clientes = DniCliente      'dni_cliente es nombre de la tabla= Codigo son de los get
            .apellido = Apellido
            .nombre = Nombre
            .direccion = Direccion
            .telefono = Telefono
            .email = Email
            .fecha_alta = Fecha_alta
            .estado_cliente = Estado_cliente
            .id_provincia = Id_Provincia
            .sexo = Sexo

        End With

        Try
            ctx.Clientes.Add(eCliente)
            'se asigna nada mas
            ctx.SaveChanges()        'se guarda en la tabla
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Sub FiltrarClientesApellidos(ByVal grid As DataGridView, ByVal textApellido As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarClientes = (From p In ctx.Clientes
                              Where (p.Apellido.StartsWith(textApellido))
                              Order By p.Dni_clientes
                              Select DNI = p.Dni_clientes, Apellido = p.Apellido, Nombre = p.Nombre, Direccion = p.Direccion, Provincia = p.Provincia.Descripcion, Telefono = p.Telefono, Email = p.Email, Fecha_Alta = p.fecha_alta, Estado = p.Estado_cliente, Sexo = p.Sexo
                            ).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarClientes

    End Sub

    Public Sub FiltrarClientesApellidosActivos(ByVal grid As DataGridView, ByVal textApellido As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarClientes = (From p In ctx.Clientes
                              Where (p.Apellido.StartsWith(textApellido) And p.Estado_cliente = True)
                              Order By p.Dni_clientes
                              Select DNI = p.Dni_clientes, Apellido = p.Apellido, Nombre = p.Nombre, Direccion = p.Direccion, Provincia = p.Provincia.Descripcion, Telefono = p.Telefono, Email = p.Email, Fecha_Alta = p.fecha_alta, Estado = p.Estado_cliente, Sexo = p.Sexo
                            ).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarClientes

    End Sub

    Public Sub FiltrarClienteDNI(ByVal grid As DataGridView, ByVal Num_dni As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarClientes = (From p In ctx.Clientes
                              Where (p.Dni_clientes.ToString.StartsWith(Num_dni))
                              Select DNI = p.Dni_clientes, Apellido = p.Apellido, Nombre = p.Nombre, Direccion = p.Direccion, Provincia = p.Provincia.Descripcion, Telefono = p.Telefono, Email = p.Email, Fecha_Alta = p.fecha_alta, Estado = p.Estado_cliente, Sexo = p.Sexo
                            ).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarClientes

    End Sub

    Public Sub FiltrarClienteDNIActivos(ByVal grid As DataGridView, ByVal Num_dni As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarClientes = (From p In ctx.Clientes
                              Where (p.Dni_clientes.ToString.StartsWith(Num_dni) And p.Estado_cliente = True)
                              Select DNI = p.Dni_clientes, Apellido = p.Apellido, Nombre = p.Nombre, Direccion = p.Direccion, Provincia = p.Provincia.Descripcion, Telefono = p.Telefono, Email = p.Email, Fecha_Alta = p.fecha_alta, Estado = p.Estado_cliente, Sexo = p.Sexo
                            ).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarClientes

    End Sub

    'otro guardarCliente

    'para insertar a la base de datos en la tabla Clientes
    Function guardarCliente2() As Boolean

        Try
            Using ctx As New Prueba_ProyectoEntities

                Dim eCliente As Clientes = New Clientes

                With eCliente
                    'los nombres de los campos de la tabla se asignan los valores de la clase cliente
                    .Dni_clientes = DniCliente      'dni_cliente es nombre de la tabla= Codigo son de los get
                    .Apellido = Apellido
                    .Nombre = Nombre
                    .Direccion = Direccion
                    .Telefono = Telefono
                    .Email = Email
                    .fecha_alta = Fecha_alta
                    .Estado_cliente = Estado_cliente
                    .id_provincia = Id_Provincia


                End With


                ctx.Clientes.Add(eCliente)
                'se asigna nada mas
                ctx.SaveChanges()        'se guarda en la tabla
                Return True

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function



#End Region

#Region "OTROS METODOS"
    'Metodo Consulta
    'Parametros: Recibe un dato tipo Integer
    'Return: devuelve el cliente que coincide con ese num_dni y que su estado sea activo  
    Public Sub Consulta(ByVal num_dni As Integer)
        Try
            Using ctx As New Prueba_ProyectoEntities
                Dim cliConsul = (From c In ctx.Clientes
                                 Where (c.Dni_clientes = num_dni And c.Estado_cliente = True)
                                 Select c).First
            End Using
        Catch ex As Exception
        End Try
    End Sub

    '    Metodo ModificarCliente.
    '    Parametros: Recibe todos los datos para modificar un cliente.
    Function ModificarCliente(ByVal num_dni As Long, ByVal apellido As String, ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal email As String, ByVal fecha_alta As Date, ByVal estado As Boolean, ByVal id_provincia As Integer, ByVal sexo As String)

        Try
            Using ctx As New Prueba_ProyectoEntities
                Dim modificar = (From c In ctx.Clientes
                                 Where (num_dni = c.Dni_clientes)
                                 Select c).First

                modificar.Dni_clientes = num_dni 'modificar.dni_cliente es atributo = num_dni es parametro
                modificar.Apellido = apellido
                modificar.Nombre = nombre
                modificar.Direccion = direccion
                modificar.Telefono = telefono
                modificar.Email = email
                modificar.fecha_alta = fecha_alta
                modificar.Estado_cliente = estado
                modificar.id_provincia = id_provincia
                modificar.Sexo = sexo


                ctx.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    '--------------------------------------------------------------------------------------------------------------

    'para modificar un cliente del datagrid y grabarlo en la base datos
    Public Sub actualizarCliente(ByVal p_Cliente As Clientes)
        Using entidad = New Prueba_ProyectoEntities
            'La sig linea pide un cliente a base de datos usando una expresion lambda. 
            'el motodo FirstOrDefault trae el primer match que encuentra haciendo un select segun dni_cliente
            Dim clienteExistente = entidad.Clientes.FirstOrDefault(Function(x) x.Dni_clientes = p_Cliente.Dni_clientes)
            'Los datos del cliente recuperado se actualizan con los nuevos pasados en el parametro p_Cliente
            'Una entidad en estado modificado se refiere a que la entidad en cuestion se prepara
            'para recibir datos de otra
            entidad.Entry(clienteExistente).State = System.Data.Entity.EntityState.Modified
            'Se setean o actualizan los valores con los datos nuevos
            entidad.Entry(clienteExistente).CurrentValues.SetValues(p_Cliente)
            entidad.SaveChanges()
        End Using
    End Sub

    Public Sub eliminarCliente(ByVal p_idCliente As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim clienteExistente = entidad.Clientes.FirstOrDefault(Function(x) x.Dni_clientes = p_idCliente)
            clienteExistente.Estado_cliente = False
            entidad.Entry(clienteExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub

    Public Sub DarDeAltaCliente(ByVal p_idCliente As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim clienteExistente = entidad.Clientes.FirstOrDefault(Function(x) x.Dni_clientes = p_idCliente)
            clienteExistente.Estado_cliente = True
            entidad.Entry(clienteExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub

    Function existeCliente(num_dni As Integer) As Boolean


        Dim objCliente As Eclientes = New Eclientes

        If objCliente.obtenerUnCliente(num_dni) Is Nothing Then

            Return False

        Else

            Return True
        End If


    End Function

    Function obtenerUnCliente(p_dniCliente As Integer) As Clientes

        Using ctx = New Prueba_ProyectoEntities

            '//Con una consulta a base de datos, traigo un cliente
            Dim consulta = From c In ctx.Clientes
                           Where p_dniCliente = c.Dni_clientes
                           Select c
            Return consulta.FirstOrDefault()

        End Using
        '//Fin metodo obtenerUnCliente
    End Function


    '---------------------------------------------------------------------------------------------------------------------------


    ' Metodo AltaCliente.
    '  Parametros: Recibe dni cliente, para darlo de alta.
    Public Sub AltaCliente(ByVal num_dni As Integer)
        Try
            Using ctx As New Prueba_ProyectoEntities
                Dim alta = (From c In ctx.Clientes
                            Where (num_dni = c.Dni_clientes And c.Estado_cliente = False)
                            Select c).First
                alta.Estado_cliente = True
                ctx.SaveChanges()
            End Using
        Catch ex As Exception

        End Try
    End Sub

    'Metodo BajaCliente.
    'Parametros: Recibe dni cliente, para darlo de baja.
    Public Sub BajaCliente(ByVal num_dni As Integer)
        Try
            Using ctx As New Prueba_ProyectoEntities
                Dim baja = (From c In ctx.Clientes
                            Where (num_dni = c.Dni_clientes And c.Estado_cliente = True)
                            Select c).First
                baja.Estado_cliente = False
                ctx.SaveChanges()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    'Metodo verificarExistencia.
    'Parametros: Recibe cuil cliente, para comprobar si existe antes de crear uno nuevo.
    Public Function verificarExistencia(ByVal num_dni As Integer, ByVal _apellido As String)
        Try
            Using ctx As New Prueba_ProyectoEntities
                Dim cliConsul = (From c In ctx.Clientes
                                 Where (c.Dni_clientes = num_dni And c.Estado_cliente = True)
                                 Select c.Apellido).First
                _apellido = cliConsul
            End Using
            Return _apellido
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region


End Class
