﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class Prueba_ProyectoEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Prueba_ProyectoEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Categorias() As DbSet(Of Categorias)
    Public Overridable Property Clientes() As DbSet(Of Clientes)
    Public Overridable Property DetalleFacturas() As DbSet(Of DetalleFacturas)
    Public Overridable Property Empleados() As DbSet(Of Empleados)
    Public Overridable Property Facturas() As DbSet(Of Facturas)
    Public Overridable Property Marcas() As DbSet(Of Marcas)
    Public Overridable Property Origen_Producto() As DbSet(Of Origen_Producto)
    Public Overridable Property Productos() As DbSet(Of Productos)
    Public Overridable Property Proveedores() As DbSet(Of Proveedores)
    Public Overridable Property Provincia() As DbSet(Of Provincia)
    Public Overridable Property tipoUsuario() As DbSet(Of tipoUsuario)
    Public Overridable Property Usuarios() As DbSet(Of Usuarios)

End Class
