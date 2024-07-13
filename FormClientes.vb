Imports System.Data.SqlClient

Public Class FormClientes

    Private connectionString As String

    Public Event ClienteSeleccionado As Action(Of String) ' Evento para pasar el nombre del cliente

    Public Sub New(ByVal connectionString As String)
        InitializeComponent()
        Me.connectionString = connectionString
    End Sub

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load initial data or perform setup tasks
        CargarClientes()
    End Sub

    Private Sub CargarClientes()
        ' Cargar la lista de clientes en un DataGridView
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ID, Cliente, Telefono, Correo FROM Clientes"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridViewClientes.DataSource = dataTable
        End Using
    End Sub

    Private Sub LimpiarCampos()
        ' Limpiar los campos de entrada de datos
        TextBoxCliente.Clear()
        TextBoxCorreo.Clear()
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        ' Agregar nuevo cliente
        Dim cliente As String = TextBoxCliente.Text.Trim()
        Dim telefono As String = MaskedTextBox1.Text.Trim()
        Dim correo As String = TextBoxCorreo.Text.Trim()

        If cliente <> "" AndAlso telefono <> "" AndAlso correo <> "" Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO Clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cliente", cliente)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@Correo", correo)

                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiarCampos()
            CargarClientes()
        Else
            MessageBox.Show("Por favor ingrese nombre, telefono y dirección de correo del cliente.")
        End If
    End Sub

    Private Sub ButtonActualizar_Click(sender As Object, e As EventArgs) Handles ButtonActualizar.Click
        ' Actualizar cliente seleccionado
        Dim idCliente As Integer = Convert.ToInt32(DataGridViewClientes.CurrentRow.Cells("ID").Value)
        Dim cliente As String = TextBoxCliente.Text.Trim()
        Dim telefono As String = MaskedTextBox1.Text.Trim()
        Dim correo As String = TextBoxCorreo.Text.Trim()

        If cliente <> "" AndAlso telefono <> "" AndAlso correo <> "" Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "UPDATE Clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Cliente", cliente)
                command.Parameters.AddWithValue("@Telefono", telefono)
                command.Parameters.AddWithValue("@Correo", correo)
                command.Parameters.AddWithValue("@ID", idCliente)

                connection.Open()
                command.ExecuteNonQuery()
            End Using

            LimpiarCampos()
            CargarClientes()
        Else
            MessageBox.Show("Por favor seleccione un cliente para actualizar.")
        End If
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        ' Eliminar cliente seleccionado
        Dim idCliente As Integer = Convert.ToInt32(DataGridViewClientes.CurrentRow.Cells("ID").Value)

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "DELETE FROM Clientes WHERE ID = @ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", idCliente)

            connection.Open()
            command.ExecuteNonQuery()
        End Using

        LimpiarCampos()
        CargarClientes()
    End Sub

    Private Sub DataGridViewClientes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewClientes.SelectionChanged
        ' Mostrar datos del cliente seleccionado en los TextBoxes
        If DataGridViewClientes.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewClientes.SelectedRows(0)
            TextBoxCliente.Text = row.Cells("Cliente").Value.ToString()
            MaskedTextBox1.Text = row.Cells("Telefono").Value.ToString()
            TextBoxCorreo.Text = row.Cells("Correo").Value.ToString()
        End If
    End Sub

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim formBusquedaClientes As New FormBusquedaClientes()
        formBusquedaClientes.Show()
    End Sub

    Private Sub DataGridViewClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewClientes.CellDoubleClick
        ' Manejar el doble clic en una fila del DataGridView
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridViewClientes.Rows.Count Then
            Dim nombreCliente As String = DataGridViewClientes.Rows(e.RowIndex).Cells("Cliente").Value.ToString()
            RaiseEvent ClienteSeleccionado(nombreCliente) ' Disparar el evento para pasar el nombre del cliente
            Me.Close() ' Cerrar el formulario de búsqueda de clientes
        End If
    End Sub

End Class

