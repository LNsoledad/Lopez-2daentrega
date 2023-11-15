Public Class Emarcas


#Region "Metodos"
    'se genera una instancia de mi contexto(global)
    Public ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

    Public Sub cargarBox(ByVal combo As ComboBox)
        'leemos todas las categorias

        Dim listaMarcas = (From c In ctx.Marcas
                           Select c).ToList

        With combo
            .DataSource = listaMarcas  ' carga la fuente de datos al combo box
            .DisplayMember = "descripcion"  'lo que se quiere mostrar
            .ValueMember = "id_marca"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 'para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With

    End Sub

    'para consultar las marcas en la base de datos
    Public Sub getMarcasAll(ByVal grid As DataGridView) 'grid se paso como parametro
        'primero va el from y por ultimo el select
        Dim listarMarcas = (From p In ctx.Marcas
                            Order By p.id_marca
                            Select Codigo = p.id_marca, Marca = p.descripcion).ToList
        'Codigo en el select es el encabezado del datagrid

        'toList lo transforma en lista lo que devuelve la consulta

        'el datagrid solo permite guardar listas
        'se asigna al data grid los clientes que se encuentran en la base de datos

        grid.DataSource = listarMarcas

    End Sub


#End Region
End Class
