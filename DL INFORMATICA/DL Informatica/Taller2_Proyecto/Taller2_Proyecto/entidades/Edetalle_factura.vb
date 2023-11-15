Public Class Edetalle_factura
    Private id_detalle As Integer
    Private _id_factura As Integer
    Private _id_producto As Integer
    Private _cantidad As Integer
    Private _precio As Double
    Private _subtotal As Double

    Dim ctx As Prueba_ProyectoEntities
    Dim objproducto As New Eproductos


#Region "Metodos GET y SET"
    Property IdFactura As Integer
        Get
            Return _id_factura
        End Get
        Set(value As Integer)
            _id_factura = value
        End Set
    End Property

    Property IdProducto As Integer
        Get
            Return _id_producto
        End Get
        Set(value As Integer)
            _id_producto = value
        End Set
    End Property

    Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
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

    Property Subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
        End Set
    End Property
#End Region

#Region "CONSTRUCTORES"
    Public Sub New()

    End Sub

    Public Sub New(ByVal _id_factura As Integer, ByVal _id_producto As Integer, ByVal _cantidad As Integer, ByVal _precio As Decimal, ByVal _subtotal As Decimal)
        IdFactura = _id_factura
        IdProducto = _id_producto
        Cantidad = _cantidad
        Precio = _precio
        Subtotal = _subtotal
    End Sub
#End Region

#Region "Metodos"
    'Agregar detalle

    'mostrar detalles
#End Region


    'El metodo insertarDetallesFactura recibe como parámetro un objeto de tipo DetallesFacturas
    '  /// e inserta sus atributos en la base de datos en la tabla correspondiente
    Public Sub insertarDetallesFactura(p_DetallesFactura As DetalleFacturas)

        '//El using facilita operaciones de apertura y cierre, por ejemplo
        '//de bases de datos

        Dim entidad As Prueba_ProyectoEntities = New Prueba_ProyectoEntities
        Using entidad
            '//Prueba_ProyectoEntities es el contexto por medio del cual se accede a base de datos
            '//Ahora se invoca dentro del contexto, a una entidad del mismo tipo
            ' //del cual queremos insertar el objeto recibido como parametro
            entidad.DetalleFacturas.Add(p_DetallesFactura)
            ' //Esto adiciona el objeto por medio de Entity Framework
            ' //pero es necesario salvar los cambios
            entidad.SaveChanges()

        End Using
    End Sub '//Fin metodo insertar

    Function guardarDetalle(ByVal detalle As DataGridView, ByVal _id_factura As Integer) As Boolean

        Dim ctx As Prueba_ProyectoEntities = New Prueba_ProyectoEntities

        Dim eDetalle As DetalleFacturas = New DetalleFacturas

        For i As Integer = 0 To detalle.Rows.Count - 1
            eDetalle.id_factura = _id_factura
            eDetalle.id_producto = 2345 '(detalle.Item(0, i).Value)
            eDetalle.cantidad = 1 'CInt(detalle.Item(2, i).Value)
            eDetalle.precio = 10 'CDec(detalle.Item(3, i).Value)
            eDetalle.subtotal = 10 ' CDec(detalle.Item(4, i).Value)

            Try
                ctx.DetalleFacturas.Add(eDetalle)

                'se asigna nada mas

                ctx.SaveChanges()
                Return True

            Catch ex As Exception

                MsgBox(ex.Message)

                Return False
            End Try

        Next







    End Function

    'Function guardarDetalle(ByVal detalle As DetalleFacturas) As Boolean
    '    MsgBox("hola 3")

    '    Try
    '        ctx.DetalleFacturas.Add(detalle)
    '        ctx.SaveChanges()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False

    '    End Try
    'End Function


    'dado en clase
    Public Sub GuardarDetalle(ByVal detalle As DetalleFacturas)

        MsgBox("11")
        MsgBox(detalle.id_factura)
        MsgBox(detalle.id_producto)
        ctx.DetalleFacturas.Add(detalle)
        ctx.SaveChanges()

        objproducto.ActualizarStock(detalle.id_producto, detalle.cantidad)
    End Sub




End Class
