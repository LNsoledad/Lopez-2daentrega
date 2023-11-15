Public Class Eempleados

    'declaracion de atributos
    Private _dni_empleado, _id_provincia As Integer
    Private _apellido, _nombre, _telefono, _direccion, _email, _sexo, _turno As String

    Private _fecha_ingreso, _fecha_Nacimiento As Date
    Private _estado_empleado As Boolean


#Region "Metodos get y set"
    'declarancion de los metodos get y set de cada atributo
    Property DniEmpleado As Integer
        Get
            Return _dni_empleado

        End Get
        Set(value As Integer)
            _dni_empleado = value
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


    Property Fecha_ingreso As Date
        Get
            Return _fecha_ingreso

        End Get
        Set(value As Date)
            _fecha_ingreso = value

        End Set
    End Property

    Property Fecha_Nacimiento As Date
        Get
            Return _fecha_Nacimiento

        End Get
        Set(value As Date)
            _fecha_Nacimiento = value

        End Set
    End Property

    Property Estado_empleado As Boolean
        Get
            Return _estado_empleado

        End Get
        Set(value As Boolean)
            _estado_empleado = value
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

    Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
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

    Property Turno As String
        Get
            Return _turno
        End Get
        Set(value As String)
            _turno = value
        End Set
    End Property

#End Region


#Region "Constructores"
    'declaracion de contructores
    Public Sub New()

    End Sub

    Public Sub New(ByVal _dni_empleado As Integer, ByVal _apellido As String, ByVal _nombre As String, ByVal _direccion As String, ByVal _telefono As String, ByVal _fecha_ingreso As Date, ByVal _fecha_nacimiento As Date, ByVal _estado_empleado As Boolean, ByVal _id_provincia As Integer, ByVal _email As String, ByVal _sexo As String, ByVal _turno As String)
        'se asigna cada valor parametro a cada set
        DniEmpleado = _dni_empleado
        Apellido = _apellido
        Nombre = _nombre
        Direccion = _direccion
        Telefono = _telefono
        Fecha_ingreso = _fecha_ingreso
        Fecha_Nacimiento = _fecha_nacimiento
        Estado_empleado = _estado_empleado
        Id_Provincia = _id_provincia
        Email = _email
        Sexo = _sexo
        Turno = _turno
    End Sub

    'constructor para cuando se quiere activar a un cliente
    Public Sub New(ByVal _estado_empleado As Boolean)
        'se asigna cada valor parametro a cada set

        Estado_empleado = _estado_empleado

    End Sub


#End Region


#Region "Metodos"
    'se genera una instancia de mi contexto(global)
    Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities


    'para consultar los empleados en la base de datos
    Public Sub getEmpleadosAll(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarEmpleados = (From p In ctx.Empleados
                               Order By p.Dni_empleados
                               Select DNI = p.Dni_empleados, Apellido = p.apellido, Nombre = p.nombre, Direccion = p.direccion, Fecha_Nacimiento = p.fecha_Nacimiento, Provincia = p.Provincia.Descripcion, Fecha_Alta = p.fecha_ingreso, Telefono = p.telefono, Estado = p.estado_emplead, Email = p.Email, Sexo = p.Sexo, Turno = p.turno).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarEmpleados

    End Sub

    'para consultar los empleados en la base de datos
    Public Sub getEmpleadosActivos(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarEmpleados = (From p In ctx.Empleados
                               Where p.estado_emplead = True
                               Order By p.Dni_empleados
                               Select DNI = p.Dni_empleados, Apellido = p.apellido, Nombre = p.nombre, Direccion = p.direccion, Fecha_Nacimiento = p.fecha_Nacimiento, Provincia = p.Provincia.Descripcion, Fecha_Alta = p.fecha_ingreso, Telefono = p.telefono, Estado = p.estado_emplead, Email = p.Email, Turno = p.turno).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarEmpleados

    End Sub

    'para insertar a la base de datos en la tabla Empleados
    'guadarEmpleados devuelve verdadero o falso si se pudo agregar o no, no se debe mostrar mensaje solo en la vista
    Function guardarEmpleado() As Boolean
        Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

        Dim eEmpleado As Empleados = New Empleados

        With eEmpleado
            'los nombres de los campos de la tabla se asignan los valores de la clase cliente
            .Dni_empleados = DniEmpleado    'dni_empleado es nombre de la tabla= DniEmpleado son de los get
            .apellido = Apellido
            .nombre = Nombre
            .direccion = Direccion
            .telefono = Telefono
            .fecha_Nacimiento = Fecha_Nacimiento
            .fecha_ingreso = Fecha_ingreso
            .estado_emplead = Estado_empleado
            .id_provincia = Id_Provincia
            .email = Email
            .sexo = Sexo
            .turno = Turno

        End With

        Try
            ctx.Empleados.Add(eEmpleado)
            'se asigna nada mas
            ctx.SaveChanges()        'se guarda en la tabla
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Sub FiltrarEmpleadosApellidos(ByVal grid As DataGridView, ByVal textApellido As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarEmpleados = (From p In ctx.Empleados
                               Where (p.apellido.StartsWith(textApellido))
                               Order By p.Dni_empleados
                               Select DNI = p.Dni_empleados, Apellido = p.apellido, Nombre = p.nombre, Direccion = p.direccion, Fecha_Nacimiento = p.fecha_Nacimiento, Provincia = p.Provincia.Descripcion, Fecha_Alta = p.fecha_ingreso, Telefono = p.telefono, Estado = p.estado_emplead, Email = p.Email, Sexo = p.Sexo, Turno = p.turno).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los empleados que se encuentran en la base de datos

        grid.DataSource = listarEmpleados

    End Sub

    Public Sub FiltrarEmpleadosApellidosActivos(ByVal grid As DataGridView, ByVal textApellido As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarEmpleados = (From p In ctx.Empleados
                               Where (p.apellido.StartsWith(textApellido) And p.estado_emplead = True)
                               Order By p.Dni_empleados
                               Select DNI = p.Dni_empleados, Apellido = p.apellido, Nombre = p.nombre, Direccion = p.direccion, Fecha_Nacimiento = p.fecha_Nacimiento, Provincia = p.Provincia.Descripcion, Fecha_Alta = p.fecha_ingreso, Telefono = p.telefono, Estado = p.estado_emplead, Email = p.Email, Turno = p.turno).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los empleados que se encuentran en la base de datos

        grid.DataSource = listarEmpleados

    End Sub
    Public Sub FiltrarEmpleadoDNI(ByVal grid As DataGridView, ByVal Num_dni As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarEmpleados = (From p In ctx.Empleados
                               Where (p.Dni_empleados.ToString.StartsWith(Num_dni))
                               Select DNI = p.Dni_empleados, Apellido = p.apellido, Nombre = p.nombre, Direccion = p.direccion, Fecha_Nacimiento = p.fecha_Nacimiento, Provincia = p.Provincia.Descripcion, Fecha_Alta = p.fecha_ingreso, Telefono = p.telefono, Estado = p.estado_emplead, Email = p.Email, Sexo = p.Sexo, Turno = p.turno).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los empleados que se encuentran en la base de datos

        grid.DataSource = listarEmpleados

    End Sub


    Public Sub FiltrarEmpleadoDNIActivos(ByVal grid As DataGridView, ByVal Num_dni As String) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        'MsgBox("estoy aca")
        Dim listarEmpleados = (From p In ctx.Empleados
                               Where (p.Dni_empleados.ToString.StartsWith(Num_dni) And p.estado_emplead = True)
                               Select DNI = p.Dni_empleados, Apellido = p.apellido, Nombre = p.nombre, Direccion = p.direccion, Fecha_Nacimiento = p.fecha_Nacimiento, Provincia = p.Provincia.Descripcion, Fecha_Alta = p.fecha_ingreso, Telefono = p.telefono, Estado = p.estado_emplead, Email = p.Email, Turno = p.turno).ToList
        'DNI en el select es el encabezado del datagrid
        'Provincia = p.Provincias.descripcion  es como un join , lo que trae va a ser el nombre de la provincia a traves de la propiedad de navegacion
        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los empleados que se encuentran en la base de datos

        grid.DataSource = listarEmpleados

    End Sub

    'otro guardarEmpleado

    'para insertar a la base de datos en la tabla Empleados
    Function guardarEmpleado2() As Boolean

        Try
            Using ctx As New Prueba_ProyectoEntities

                Dim eEmpleado As Empleados = New Empleados

                With eEmpleado
                    'los nombres de los campos de la tabla se asignan los valores de la clase cliente
                    .dni_empleados = DniEmpleado    'dni_cliente es nombre de la tabla= Codigo son de los get
                    .apellido = Apellido
                    .nombre = Nombre
                    .direccion = Direccion
                    .telefono = Telefono
                    .fecha_Nacimiento = Fecha_Nacimiento
                    .fecha_ingreso = Fecha_ingreso
                    .estado_emplead = Estado_empleado
                    .id_provincia = Id_Provincia


                End With



                ctx.Empleados.Add(eEmpleado)
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

#Region "Otros metodos"

    'para modificar un empleado del datagrid y grabarlo en la base datos
    Public Sub actualizarEmpleado(ByVal p_Empleado As Empleados)
        Using entidad = New Prueba_ProyectoEntities
            'La sig linea pide un cliente a base de datos usando una expresion lambda. 
            'el motodo FirstOrDefault trae el primer match que encuentra haciendo un select segun dni_cliente
            Dim empleadoExistente = entidad.Empleados.FirstOrDefault(Function(x) x.dni_empleados = p_Empleado.dni_empleados)
            'Los datos del cliente recuperado se actualizan con los nuevos pasados en el parametro p_Cliente
            'Una entidad en estado modificado se refiere a que la entidad en cuestion se prepara
            'para recibir datos de otra
            entidad.Entry(empleadoExistente).State = System.Data.Entity.EntityState.Modified
            'Se setean o actualizan los valores con los datos nuevos
            entidad.Entry(empleadoExistente).CurrentValues.SetValues(p_Empleado)
            entidad.SaveChanges()
        End Using
    End Sub

    Public Sub eliminarEmpleado(ByVal p_dniEmpleado As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim empleadoExistente = entidad.Empleados.FirstOrDefault(Function(x) x.dni_empleados = p_dniEmpleado)
            empleadoExistente.estado_emplead = False
            entidad.Entry(empleadoExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub

    Public Sub DarDeAltaEmpleado(ByVal p_dniEmpleado As Integer)
        Using entidad = New Prueba_ProyectoEntities
            Dim empleadoExistente = entidad.Empleados.FirstOrDefault(Function(x) x.dni_empleados = p_dniEmpleado)
            empleadoExistente.estado_emplead = True
            entidad.Entry(empleadoExistente).State = System.Data.Entity.EntityState.Modified
            entidad.SaveChanges()
        End Using
    End Sub


    Function buscarEmpleado(num_dni As Integer) As Empleados

        Using ctx = New Prueba_ProyectoEntities

            '//Con una consulta a base de datos, traigo un empleado(Where num_dni = u.dni_empleado)
            Dim consulta = From e In ctx.Empleados
                           Where e.dni_empleados.ToString.StartsWith(num_dni)
                           Select e

            Return consulta.FirstOrDefault()

        End Using
        '//Fin metodo obtenerUnUsuario
    End Function
#End Region

End Class
