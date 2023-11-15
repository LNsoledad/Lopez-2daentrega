Public Class Eprovincias
    Private _id_provincia As Integer
    Private _descripcion As String

#Region "SET y GET"
    Property IdProvincias As Integer
        Get
            Return _id_provincia

        End Get
        Set(value As Integer)
            _id_provincia = value

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


#End Region


#Region "Constructores"
    Public Sub New()

    End Sub

    Public Sub New(ByVal _id_provincia As Integer, ByVal _descripcion As String)
        IdProvincias = _id_provincia
        Descripcion = _descripcion
    End Sub

#End Region


    'se genera una instancia de mi contexto(global)
    Public ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

    Public Sub cargarBox(ByVal combo As ComboBox)
        'leemos todas las categorias

        Dim listaProvincias = (From c In ctx.Provincia
                               Select c).ToList

        With combo
            .DataSource = listaProvincias  ' carga la fuente de datos al combo box
            .DisplayMember = "descripcion"  'lo que se quiere mostrar
            .ValueMember = "id_provincia"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 '(-1)para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With


    End Sub


    'para consultar las provincias en la base de datos
    Public Sub getProvinciasAll(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarProvincias = (From p In ctx.Provincia
                                Order By p.Id_provincia
                                Select id = p.Id_provincia, Provincias = p.Descripcion).ToList
        'Provincias en el select es el encabezado del datagrid

        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarProvincias

    End Sub

End Class
