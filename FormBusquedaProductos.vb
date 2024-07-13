Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormBusquedaProductos

    Private connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString

    Private Sub FormBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DataGridView con columnas necesarias
        ConfigurarDataGridView()
        RadioButtonNomProd.Checked = True
    End Sub

    Private Sub ConfigurarDataGridView()
        ' Configurar las columnas del DataGridView
        DataGridViewProductos.Columns.Clear()
        DataGridViewProductos.AutoGenerateColumns = False

        ' Agregar columnas necesarias (ejemplo: IdCliente, Nombre, Direccion)
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "ID"
        colId.DataPropertyName = "ID"
        colId.HeaderText = "ID"
        colId.Width = 50
        DataGridViewProductos.Columns.Add(colId)

        Dim colNombre As New DataGridViewTextBoxColumn()
        colNombre.Name = "Nombre"
        colNombre.DataPropertyName = "Nombre"
        colNombre.HeaderText = "Nombre"
        colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewProductos.Columns.Add(colNombre)

        Dim colTelefono As New DataGridViewTextBoxColumn()
        colTelefono.Name = "Precio"
        colTelefono.DataPropertyName = "Precio"
        colTelefono.HeaderText = "Precio"
        colTelefono.Width = 150
        DataGridViewProductos.Columns.Add(colTelefono)

        Dim colCorreo As New DataGridViewTextBoxColumn()
        colCorreo.Name = "Categoria"
        colCorreo.DataPropertyName = "Categoria"
        colCorreo.HeaderText = "Categoria"
        colCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewProductos.Columns.Add(colCorreo)
    End Sub

    Private Function GetQuery() As String
        If RadioButtonNomProd.Checked Then
            Return "SELECT ID, Nombre, Precio, Categoria FROM Productos WHERE Nombre LIKE '%' + @filtro + '%'"
        ElseIf RadioButtonCatProd.Checked Then
            Return "SELECT ID, Nombre, Precio, Categoria FROM Productos WHERE Categoria LIKE '%' + @filtro + '%'"
        Else
            Return String.Empty
        End If
    End Function

    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click

        DataGridViewProductos.DataSource = Nothing

        ' Realizar la búsqueda de productos según el filtro ingresado
        Dim filtro As String = TextBoxFiltro.Text.Trim()

        ' Consulta SQL para buscar productos basados en el filtro
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
                DataGridViewProductos.DataSource = dataTable
            End Using
        End Using

    End Sub

    Private Sub DataGridViewProductos_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewProductos.SelectionChanged
        ' Manejar la selección de producto en el DataGridView
        If DataGridViewProductos.SelectedRows.Count > 0 Then
            Dim idProducto As Integer = Convert.ToInt32(DataGridViewProductos.SelectedRows(0).Cells("ID").Value)
            Dim nombreProducto As String = DataGridViewProductos.SelectedRows(0).Cells("Nombre").Value.ToString()

            ' Puedes utilizar el ID o el nombre del producto seleccionado como necesites
            MessageBox.Show($"Producto seleccionado: {idProducto} - {nombreProducto}")
        End If
    End Sub

End Class
