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

Partial Public Class Facturas
    Public Property id_factura As Integer
    Public Property id_usuario As Nullable(Of Integer)
    Public Property Dni_cliente As Nullable(Of Integer)
    Public Property fecha_factura As Nullable(Of Date)
    Public Property Total_factura As Decimal
    Public Property estado_factura As Nullable(Of Boolean)

    Public Overridable Property Clientes As Clientes
    Public Overridable Property DetalleFacturas As ICollection(Of DetalleFacturas) = New HashSet(Of DetalleFacturas)
    Public Overridable Property Usuarios As Usuarios

End Class
