Imports System.Data.SqlClient

Public Class FormBusquedaVentas

    Private connectionString As String

    Public Sub New(ByVal connectionString As String)
        InitializeComponent()
        Me.connectionString = connectionString
    End Sub

    Private Sub FormBusquedaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarDataGridView()
        CargarVentas()
        RadioButtonVCliente.Checked = True
    End Sub

    Private Sub ConfigurarDataGridView()
        ' Configurar las columnas del DataGridView
        DataGridViewVentasDone.Columns.Clear()
        DataGridViewVentasDone.AutoGenerateColumns = False

        ' Agregar columnas necesarias (ejemplo: IdCliente, Nombre, Direccion)
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "ID"
        colId.DataPropertyName = "ID"
        colId.HeaderText = "ID"
        colId.Width = 50
        DataGridViewVentasDone.Columns.Add(colId)

        Dim colCliente As New DataGridViewTextBoxColumn()
        colCliente.Name = "IDCliente"
        colCliente.DataPropertyName = "IDCliente"
        colCliente.HeaderText = "IDCliente"
        colCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentasDone.Columns.Add(colCliente)

        Dim colFecha As New DataGridViewTextBoxColumn()
        colFecha.Name = "Fecha"
        colFecha.DataPropertyName = "Fecha"
        colFecha.HeaderText = "Fecha"
        colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentasDone.Columns.Add(colFecha)

        Dim colTotal As New DataGridViewTextBoxColumn()
        colTotal.Name = "Total"
        colTotal.DataPropertyName = "Total"
        colTotal.HeaderText = "Total"
        colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentasDone.Columns.Add(colTotal)
    End Sub

    Private Sub CargarVentas()
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT ID, IDCliente, Fecha, Total FROM Ventas"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridViewVentasDone.DataSource = dataTable
        End Using
    End Sub

    Private Sub DataGridViewVentasDone_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewVentasDone.SelectionChanged
        ' Manejar la selección de producto en el DataGridView
        If DataGridViewVentasDone.SelectedRows.Count > 0 Then
            Dim idProducto As Integer = Convert.ToInt32(DataGridViewVentasDone.SelectedRows(0).Cells("ID").Value)
            Dim nombreCliente As String = DataGridViewVentasDone.SelectedRows(0).Cells("IDCliente").Value.ToString()

            ' Puedes utilizar el ID o el nombre del producto seleccionado como necesites
            MessageBox.Show($"Producto seleccionado: {idProducto} - {nombreCliente}")
        End If
    End Sub

    Private Function GetQuery() As String
        If RadioButtonVCliente.Checked Then
            Return "SELECT ID, IDCliente, Fecha, Total FROM Ventas WHERE IDCliente LIKE '%' + @filtro + '%'"
        ElseIf RadioButtonVFecha.Checked Then
            Return "SELECT ID, IDCliente, Fecha, Total FROM Ventas WHERE Fecha LIKE '%' + @filtro + '%'"
        ElseIf RadioButtonVTotal.Checked Then
            Return "SELECT ID, IDCliente, Fecha, Total FROM Ventas WHERE Total LIKE '%' + @filtro + '%'"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub ButtonBuscarVenta_Click(sender As Object, e As EventArgs) Handles ButtonBuscarVenta.Click

        DataGridViewVentasDone.DataSource = Nothing
        ' Realizar la búsqueda de clientes según el filtro ingresado
        Dim filtro As String = TextBox1.Text.Trim()

        ' Consulta SQL para buscar clientes basados en el filtro
        Dim query As String = GetQuery()

        If String.IsNullOrEmpty(query) Then
            MessageBox.Show("Por favor seleccione un criterio de búsqueda.")
            Return
        End If

        ' Crear una conexión a la base de datos
        Using connection As New SqlConnection(connectionString)
            ' Abrir la conexión
            connection.Open()

            ' Crear un comando SQL con la consulta y la conexión asociada
            Using command As New SqlCommand(query, connection)
                ' Añadir parámetro para el filtro (utilizando LIKE para búsqueda parcial)
                command.Parameters.AddWithValue("@filtro", "%" & filtro & "%")

                ' Crear un adaptador de datos para ejecutar el comando y llenar un DataTable con los resultados
                Dim dataTable As New DataTable()
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using

                ' Mostrar los resultados en el DataGridView
                DataGridViewVentasDone.DataSource = dataTable
            End Using
        End Using
    End Sub

End Class