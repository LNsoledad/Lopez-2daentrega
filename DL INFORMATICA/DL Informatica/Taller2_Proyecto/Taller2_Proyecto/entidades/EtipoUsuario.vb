Public Class EtipoUsuario
    Private _id_tipoUsuario As Integer
    Private descripcion As String

#Region "Metodos"
    'se genera una instancia de mi contexto(global)
    Public ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

    Public Sub cargarBox(ByVal combo As ComboBox)
        'leemos todas las categorias

        Dim listaTipoUsuarios = (From c In ctx.tipoUsuario
                                 Select c).ToList

        With combo
            .DataSource = listaTipoUsuarios  ' carga la fuente de datos al combo box
            .DisplayMember = "descripcion"  'lo que se quiere mostrar
            .ValueMember = "id_tipoUsuario"   'se asocia a la descripcion se asocia a la categoria y es esto lo que se necesita leer
            .SelectedValue = -1 'para que no muestre ninguna categoria
            '1 para que aparezca siempre la primer categoria
        End With


    End Sub

#End Region


End Class
