Imports System.Data.SqlClient

Public Class FormProductos

    Private connectionString As String

    Public Sub New(ByVal connectionString As String, Optional ByVal modoSeleccion As Boolean = False)
        InitializeComponent()
        Me.connectionString = connectionString

        If modoSeleccion Then
            ButtonAgregar.Visible = False
            ButtonActualizar.Visible = False
            ButtonEliminar.Visible = False
        End If
    End Sub


    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial data or perform setup tasks
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        ' Cargar la lista de productos en un DataGridView
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ID, Nombre, Precio, Categoria FROM Productos"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridViewProductos.DataSource = dataTable
        End Using
    End Sub

    Private Sub LimpiarCampos()
        ' Limpiar los campos de entrada de datos
        TextBoxNombre.Clear()
        TextBoxPrecio.Clear()
        TextBoxCategoria.Clear()
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        ' Agregar nuevo producto
        Dim nombre As String = TextBoxNombre.Text.Trim()
        Dim precio As Decimal
        Dim categoria As String = TextBoxCategoria.Text.Trim()

        If Decimal.TryParse(TextBoxPrecio.Text.Trim(), precio) AndAlso nombre <> "" Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Precio", precio)
                command.Parameters.AddWithValue("@Categoria", categoria)

                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiarCampos()
            CargarProductos()
        Else
            MessageBox.Show("Por favor ingrese un nombre, precio y categoría válidos para el producto.")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ' Actualizar producto seleccionado
        Dim idProducto As Integer = Convert.ToInt32(DataGridViewProductos.CurrentRow.Cells("ID").Value)
        Dim nombre As String = TextBoxNombre.Text.Trim()
        Dim precio As Decimal
        Dim categoria As String = TextBoxCategoria.Text.Trim()

        If Decimal.TryParse(TextBoxPrecio.Text.Trim(), precio) AndAlso nombre <> "" Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nombre", nombre)
                command.Parameters.AddWithValue("@Precio", precio)
                command.Parameters.AddWithValue("@Categoria", categoria)
                command.Parameters.AddWithValue("@ID", idProducto)

                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiarCampos()
            CargarProductos()
        Else
            MessageBox.Show("Por favor seleccione un producto para actualizar.")
        End If
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        ' Eliminar producto seleccionado
        Dim idProducto As Integer = Convert.ToInt32(DataGridViewProductos.CurrentRow.Cells("ID").Value)

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM Productos WHERE ID = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", idProducto)

            connection.Open()
            command.ExecuteNonQuery()
        End Using

        LimpiarCampos()
        CargarProductos()
    End Sub

    Private Sub DataGridViewProductos_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewProductos.SelectionChanged
        ' Mostrar datos del producto seleccionado en los TextBoxes
        If DataGridViewProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewProductos.SelectedRows(0)
            TextBoxNombre.Text = row.Cells("Nombre").Value.ToString()
            TextBoxPrecio.Text = row.Cells("Precio").Value.ToString()
            TextBoxCategoria.Text = row.Cells("Categoria").Value.ToString()
        End If
    End Sub

    Private Sub ButtonBuscarProducto_Click(sender As Object, e As EventArgs) Handles ButtonBuscarProducto.Click
        Dim formBusquedaProd As New FormBusquedaProductos()
        formBusquedaProd.Show()
    End Sub

    Public Event ProductoSeleccionado(ByVal nombre As String, ByVal precio As Decimal)

    Private Sub DataGridViewProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductos.CellDoubleClick
        If e.RowIndex >= 0 AndAlso DataGridViewProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewProductos.SelectedRows(0)
            Dim nombre As String = row.Cells("Nombre").Value.ToString()
            Dim precio As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)

            RaiseEvent ProductoSeleccionado(nombre, precio)
            Me.Close()
        End If
    End Sub


End Class
