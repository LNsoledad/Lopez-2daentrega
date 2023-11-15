Public Class Eusuarios
    Private _id_usuario As Integer
    Private _dni_empelado As Integer
    Private _contraseña As String
    Private _id_tipoUsuario As Integer
    Private _estado As Boolean

#Region "SET y GET"
    Property IdUsuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property

    Property DniEmpleado As Integer
        Get
            Return _dni_empelado
        End Get
        Set(value As Integer)
            _dni_empelado = value
        End Set
    End Property

    Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Property Id_tipoUsuario As Integer
        Get
            Return _id_tipoUsuario
        End Get
        Set(value As Integer)
            _id_tipoUsuario = value
        End Set
    End Property

    Property Estado As Boolean
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

    Public Sub New(ByVal _dni_empleado As Integer, ByVal _contraseña As String, ByVal _id_tipoUsuario As Integer, ByVal _estado As Boolean)
        DniEmpleado = _dni_empleado
        Contraseña = _contraseña
        Id_tipoUsuario = _id_tipoUsuario
        Estado = _estado
    End Sub
#End Region

#Region "METODOS"
    'se genera una instancia de mi contexto(global)
    Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities


    'para consultar los clientes en la base de datos
    Public Sub getUsuariosAll(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarUsuarios = (From p In ctx.Usuarios
                              Order By p.dni_Empleados Descending
                              Select id_Usuario = p.id_usuario, Dni = p.Empleados.Dni_empleados, Apellido = p.Empleados.apellido, Nombre = p.Empleados.nombre, Rol = p.tipoUsuario.descripcion, Estado = p.Estado_usuario, Clave = p.contraseña).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los usuarios que se encuentran en la base de datos

        grid.DataSource = listarUsuarios

    End Sub


    'para consultar los clientes en la base de datos
    Public Sub getUsuariosActivos(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarUsuarios = (From p In ctx.Usuarios
                              Where p.Estado_usuario = True
                              Order By p.id_usuario
                              Select Dni_Empleado = p.dni_Empleados, Apellido = p.Empleados.apellido, Nombre = p.Empleados.nombre, Rol = p.tipoUsuario.descripcion, Estado = p.Estado_usuario, Clave = p.contraseña).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los usuarios que se encuentran en la base de datos

        grid.DataSource = listarUsuarios

    End Sub

    'para insertar a la base de datos en la tabla Usuarios
    'guadarUsuario devuelve verdadero o falso si se pudo agregar o no, no se debe mostrar mensaje solo en la vista
    Function guardarUsuario() As Boolean
        Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

        Dim eUsuario As Usuarios = New Usuarios

        With eUsuario
            'los nombres de los campos de la tabla se asignan los valores de la clase usuario
            .dni_Empleados = DniEmpleado      'dni_cliente es nombre de la tabla= Codigo son de los get
            .contraseña = Contraseña
            .id_tipoUsuario = Id_tipoUsuario
            .Estado_usuario = Estado



        End With

        Try
            ctx.Usuarios.Add(eUsuario)
            'se asigna nada mas
            ctx.SaveChanges()        'se guarda en la tabla
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Sub FiltrarUsuariosApellidos(ByVal grid As DataGridView, ByVal textApellido As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarUsuarios = (From p In ctx.Usuarios
                              Where (p.Empleados.apellido.StartsWith(textApellido))
                              Order By p.id_usuario
                              Select id_Usuario = p.id_usuario, Dni = p.dni_Empleados, Apellido = p.Empleados.apellido, Nombre = p.Empleados.nombre, Rol = p.tipoUsuario.descripcion, Estado = p.Estado_usuario, Clave = p.contraseña).ToList
        'Codigo en el select es el encabezado del datagrid
        'Apellido = p.Empelados.apellido  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarUsuarios

    End Sub

    Public Sub FiltrarUsuariosApellidosActivos(ByVal grid As DataGridView, ByVal textApellido As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarUsuarios = (From p In ctx.Usuarios
                              Where (p.Empleados.apellido.StartsWith(textApellido) And p.Estado_usuario = True)
                              Order By p.id_usuario
                              Select Dni_Empleado = p.dni_Empleados, Apellido = p.Empleados.apellido, Nombre = p.Empleados.nombre, Rol = p.tipoUsuario.descripcion, Estado = p.Estado_usuario).ToList
        'Codigo en el select es el encabezado del datagrid
        'Apellido = p.Empelados.apellido  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarUsuarios

    End Sub

    Public Sub FiltrarUsuarioDNI(ByVal grid As DataGridView, ByVal Num_dni As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarUsuarios = (From p In ctx.Usuarios
                              Where (p.Empleados.Dni_empleados.ToString.StartsWith(Num_dni))
                              Select id_Usuario = p.id_usuario, Dni = p.dni_Empleados, Apellido = p.Empleados.apellido, Nombre = p.Empleados.nombre, Rol = p.tipoUsuario.descripcion, Estado = p.Estado_usuario, Clave = p.contraseña).ToList
        'Dni_Empleado en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarUsuarios

    End Sub

    Public Sub FiltrarUsuarioDNIActivos(ByVal grid As DataGridView, ByVal Num_dni As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarUsuarios = (From p In ctx.Usuarios
                              Where (p.Empleados.Dni_empleados.ToString.StartsWith(Num_dni) And p.Estado_usuario = True)
                              Select Dni_Empleado = p.dni_Empleados, Apellido = p.Empleados.apellido, Nombre = p.Empleados.nombre, Rol = p.tipoUsuario.descripcion, Estado = p.Estado_usuario).ToList
        'Dni_Empleado en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarUsuarios

    End Sub

    Function VerificarUsuarioContraseña() As Boolean
        Return True
    End Function

#End Region

#Region "Actualizar,Baja,Alta"
    'para modificar un usuario del datagrid y grabarlo en la base datos
    Public Sub actualizarUsuario(ByVal p_Usuario As Usuarios)
        Using entidad = New Prueba_ProyectoEntities
            'La sig linea pide un cliente a base de datos usando una expresion lambda. 
            'el motodo FirstOrDefault trae el primer match que encuentra haciendo un select segun dni_cliente
            Dim usuarioExistente = entidad.Usuarios.FirstOrDefault(Function(x) x.id_usuario = p_Usuario.id_usuario)
            'Los datos del cliente recuperado se actualizan con los nuevos pasados en el parametro p_Cliente
            'Una entidad en estado modificado se refiere a que la entidad en cuestion se prepara
            'para recibir datos de otra
            entidad.Entry(usuarioExistente).State = System.Data.Entity.EntityState.Modified
            'Se setean o actualizan los valores con los datos nuevos
            entidad.Entry(usuarioExistente).CurrentValues.SetValues(p_Usuario)
            entidad.SaveChanges()
        End Using
    End Sub

    Public Sub eliminarUsuario(ByVal p_dniEmpleado As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim usuarioExistente = entidad.Usuarios.FirstOrDefault(Function(x) x.dni_Empleados = p_dniEmpleado)
            usuarioExistente.Estado_usuario = False
            entidad.Entry(usuarioExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub



    Public Sub DarDeAltaUsuario(ByVal p_dniEmpleado As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim usuarioExistente = entidad.Usuarios.FirstOrDefault(Function(x) x.dni_Empleados = p_dniEmpleado)
            usuarioExistente.Estado_usuario = True
            entidad.Entry(usuarioExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub
#End Region

#Region "Existe Usuario"
    Function existeUsuario(num_dni As String) As Boolean


        Dim objUsuario As Eusuarios = New Eusuarios

        'If objUsuario.buscarUsuario(num_dni) Is Nothing Then

        Return False

        'Else

        Return True
        'End If


    End Function

    Function buscarUsuario(ByVal num_dni As Integer) As Integer
        '  MsgBox("hola 2")


        Using ctx = New Prueba_ProyectoEntities

            '//Con una consulta a base de datos, traigo un empleado(Where num_dni = u.dni_empleado)
            Dim consulta = (From u In ctx.Usuarios
                            Where u.dni_Empleados = num_dni Select u).Count

            '
            Return consulta

        End Using
        '//Fin metodo obtenerUnUsuario
    End Function



    Function dbuscarUsuario(ByVal num_dni As Integer) As Usuarios
        '    MsgBox("hola 3")


        Using ctx = New Prueba_ProyectoEntities

            '//Con una consulta a base de datos, traigo un empleado(Where num_dni = u.dni_empleado)
            Dim consulta = (From u In ctx.Usuarios
                            Where u.dni_Empleados = num_dni Select u).First

            '
            Return consulta

        End Using
        '//Fin metodo obtenerUnUsuario
    End Function


    Friend Function coincideClave(ByVal p_usuario As Usuarios, ByVal p_contraseña As String) As Boolean
        ' If Funciones.DesEncriptar(p_usuario.contraseña) = p_contraseña Then
        If p_usuario.contraseña = p_contraseña Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

End Class

Public Class Usuarios
End Class
