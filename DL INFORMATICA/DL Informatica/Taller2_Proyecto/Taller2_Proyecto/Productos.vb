'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Productos
    Public Property id_producto As Integer
    Public Property descripcion As String
    Public Property id_categoria As Nullable(Of Integer)
    Public Property id_marca As Nullable(Of Integer)
    Public Property stock As Nullable(Of Integer)
    Public Property precio As Decimal
    Public Property estado As Nullable(Of Boolean)
    Public Property precio_costo As Decimal
    Public Property id_origen As Nullable(Of Integer)
    Public Property id_proveedor As Nullable(Of Integer)

    Public Overridable Property Categorias As Categorias
    Public Overridable Property DetalleFacturas As ICollection(Of DetalleFacturas) = New HashSet(Of DetalleFacturas)
    Public Overridable Property Marcas As Marcas
    Public Overridable Property Origen_Producto As Origen_Producto
    Public Overridable Property Proveedores As Proveedores

End Class
