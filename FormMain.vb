Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormMain

    Private Sub ButtonClientes_Click(sender As Object, e As EventArgs) Handles ButtonClientes.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        ' Mostrar el formulario de Clientes
        Dim formClientes As New FormClientes(connectionString)
        formClientes.Show()
    End Sub

    Private Sub ButtonProductos_Click(sender As Object, e As EventArgs) Handles ButtonProductos.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        ' Mostrar el formulario de Productos
        Dim formProductos As New FormProductos(connectionString)
        formProductos.Show()
    End Sub

    Private Sub ButtonVentas_Click(sender As Object, e As EventArgs) Handles ButtonVentas.Click
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        ' Mostrar el formulario de Ventas
        Dim formVentas As New FormVentas(connectionString)
        formVentas.Show()
    End Sub
End Class
