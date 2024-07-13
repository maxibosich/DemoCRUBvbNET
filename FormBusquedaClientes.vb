Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormBusquedaClientes

    Private connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

    Private Sub FormBusquedaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DataGridView con columnas necesarias
        ConfigurarDataGridView()
        RadioButtonCliente.Checked = True
    End Sub

    Private Sub ConfigurarDataGridView()
        ' Configurar las columnas del DataGridView
        DataGridViewClientes.Columns.Clear()
        DataGridViewClientes.AutoGenerateColumns = False

        ' Agregar columnas necesarias (ejemplo: IdCliente, Nombre, Direccion)
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "ID"
        colId.DataPropertyName = "ID"
        colId.HeaderText = "ID"
        colId.Width = 50
        DataGridViewClientes.Columns.Add(colId)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.Name = "Cliente"
        colNombre.DataPropertyName = "Cliente"
        colNombre.HeaderText = "Cliente"
        colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewClientes.Columns.Add(colNombre)

        Dim colTelefono As New DataGridViewTextBoxColumn()
        colTelefono.Name = "Telefono"
        colTelefono.DataPropertyName = "Telefono"
        colTelefono.HeaderText = "Telefono"
        colTelefono.Width = 150
        DataGridViewClientes.Columns.Add(colTelefono)

        Dim colCorreo As New DataGridViewTextBoxColumn()
        colCorreo.Name = "Correo"
        colCorreo.DataPropertyName = "Correo"
        colCorreo.HeaderText = "Correo"
        colCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewClientes.Columns.Add(colCorreo)
    End Sub

    Private Function GetQuery() As String
        If RadioButtonCliente.Checked Then
            Return "SELECT ID, Cliente, Telefono, Correo FROM Clientes WHERE Cliente LIKE '%' + @filtro + '%'"
        ElseIf RadioButtonTelefono.Checked Then
            Return "SELECT ID, Cliente, Telefono, Correo FROM Clientes WHERE Telefono LIKE '%' + @filtro + '%'"
        ElseIf RadioButtonCorreo.Checked Then
            Return "SELECT ID, Cliente, Telefono, Correo FROM Clientes WHERE Correo LIKE '%' + @filtro + '%'"
        Else
            Return String.Empty
        End If
    End Function


    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        DataGridViewClientes.DataSource = Nothing
        ' Realizar la búsqueda de clientes según el filtro ingresado
        Dim filtro As String = TextBoxFiltro.Text.Trim()

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
                DataGridViewClientes.DataSource = dataTable
            End Using
        End Using
    End Sub

    Private Sub DataGridViewClientes_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewClientes.SelectionChanged
        ' Manejar la selección de cliente en el DataGridView
        If DataGridViewClientes.SelectedRows.Count > 0 Then
            Dim idCliente As Integer = Convert.ToInt32(DataGridViewClientes.SelectedRows(0).Cells("ID").Value)
            Dim nombreCliente As String = DataGridViewClientes.SelectedRows(0).Cells("Cliente").Value.ToString()
            Dim telCliente As String = DataGridViewClientes.SelectedRows(0).Cells("Telefono").Value.ToString()
            Dim correoCliente As String = DataGridViewClientes.SelectedRows(0).Cells("Correo").Value.ToString()

            ' Puedes utilizar el ID o el nombre del cliente seleccionado como necesites
            MessageBox.Show($"Cliente seleccionado: {idCliente} - {nombreCliente}")
        End If
    End Sub

End Class
