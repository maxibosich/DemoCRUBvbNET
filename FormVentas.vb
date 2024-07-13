Imports System.Configuration
Imports System.Data.SqlClient

Public Class FormVentas

    Private connectionString As String
    Private ventaId As Integer = 0

    Public Sub New(ByVal connectionString As String)
        InitializeComponent()
        Me.connectionString = connectionString
    End Sub

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarDataGridView()
    End Sub

    Private Sub ConfigurarDataGridView()
        ' Configurar las columnas del DataGridView
        DataGridViewVentas.Columns.Clear()
        DataGridViewVentas.AutoGenerateColumns = False

        ' Agregar columnas necesarias (ejemplo: IdCliente, Nombre, Direccion)

        Dim colProducto As New DataGridViewTextBoxColumn()
        colProducto.Name = "Producto"
        colProducto.DataPropertyName = "Producto"
        colProducto.HeaderText = "Producto"
        colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentas.Columns.Add(colProducto)

        Dim colCant As New DataGridViewTextBoxColumn()
        colCant.Name = "Cantidad"
        colCant.DataPropertyName = "Cantidad"
        colCant.HeaderText = "Cantidad"
        colCant.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentas.Columns.Add(colCant)

        Dim colPU As New DataGridViewTextBoxColumn()
        colPU.Name = "Precio Unitario"
        colPU.DataPropertyName = "Precio Unitario"
        colPU.HeaderText = "Precio Unitario"
        colPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentas.Columns.Add(colPU)

        Dim colPrecioTotal As New DataGridViewTextBoxColumn()
        colPrecioTotal.Name = "Precio Total"
        colPrecioTotal.DataPropertyName = "Precio Total"
        colPrecioTotal.HeaderText = "Precio Total"
        colPrecioTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewVentas.Columns.Add(colPrecioTotal)
    End Sub

    Private Sub ButtonAgregarItem_Click(sender As Object, e As EventArgs) Handles ButtonAgregarItem.Click
        ' Agregar nuevo ítem de venta
        Dim cantidad As Integer
        Dim precioUnitario As Decimal = MaskedTextBoxPU.Text.Trim()
        Dim precioTotal As Decimal
        Dim producto As String = TextBoxCargarProducto.Text

        If String.IsNullOrWhiteSpace(MaskedTBCantidad.Text) Then
            MessageBox.Show("La cantidad no puede estar vacía.")
            Return
        End If

        If Integer.TryParse(MaskedTBCantidad.Text.Trim(), cantidad) AndAlso
           Decimal.TryParse(MaskedTextBoxPU.Text.Trim(), precioUnitario) Then

            precioTotal = cantidad * precioUnitario
            MaskedTextBoxPrecioTotal.Text = precioTotal.ToString()

            DataGridViewVentas.Rows.Add(producto, cantidad, precioUnitario, precioTotal)

            LimpiarCampos()
            ActualizarTotalGeneral()
        Else
            MessageBox.Show("Por favor ingrese una cantidad y un precio unitario válidos.")
        End If
    End Sub

    Private Sub ButtonModificarItem_Click(sender As Object, e As EventArgs) Handles ButtonModificarItem.Click
        ' Modificar ítem de venta seleccionado
        If DataGridViewVentas.SelectedRows.Count > 0 Then
            Dim cantidad As Integer
            Dim precioUnitario As Decimal
            Dim precioTotal As Decimal
            Dim producto As String = "Producto"

            If Integer.TryParse(MaskedTBCantidad.Text.Trim(), cantidad) AndAlso
               Decimal.TryParse(MaskedTextBoxPU.Text.Trim(), precioUnitario) Then

                precioTotal = cantidad * precioUnitario

                Dim row As DataGridViewRow = DataGridViewVentas.SelectedRows(0)
                row.Cells("Producto").Value = producto
                row.Cells("Cantidad").Value = cantidad
                row.Cells("Precio Unitario").Value = precioUnitario
                row.Cells("Precio Total").Value = precioTotal

                LimpiarCampos()
                ActualizarTotalGeneral()
            Else
                MessageBox.Show("Por favor ingrese una cantidad y un precio unitario válidos.")
            End If
        Else
            MessageBox.Show("Por favor seleccione un ítem para modificar.")
        End If
    End Sub

    Private Sub ButtonEliminarItem_Click(sender As Object, e As EventArgs) Handles ButtonEliminarItem.Click
        ' Eliminar ítem de venta seleccionado
        If DataGridViewVentas.SelectedRows.Count > 0 Then
            DataGridViewVentas.Rows.Remove(DataGridViewVentas.SelectedRows(0))
            LimpiarCampos()
            ActualizarTotalGeneral()
        Else
            MessageBox.Show("Por favor seleccione un ítem para eliminar.")
        End If
    End Sub

    Private Sub DataGridViewVentas_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridViewVentas.SelectionChanged
        ' Mostrar datos del ítem seleccionado en los TextBoxes
        If DataGridViewVentas.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridViewVentas.SelectedRows(0)
            MaskedTBCantidad.Text = row.Cells("Cantidad").Value.ToString()
            MaskedTextBoxPU.Text = row.Cells("Precio Unitario").Value.ToString()
            MaskedTextBoxPrecioTotal.Text = row.Cells("Precio Total").Value.ToString()
        End If
    End Sub

    Private Sub ActualizarTotalGeneral()
        ' Calcular y mostrar el Total General
        Dim totalGeneral As Decimal = 0

        For Each row As DataGridViewRow In DataGridViewVentas.Rows
            totalGeneral += Convert.ToDecimal(row.Cells("Precio Total").Value)
        Next

        TextBoxTotalGeneral.Text = totalGeneral.ToString()
    End Sub

    Private Sub LimpiarCampos()
        ' Limpiar los campos de entrada de datos
        MaskedTextBoxPU.Clear()
        MaskedTBCantidad.Clear()
        MaskedTextBoxPrecioTotal.Clear()
        TextBoxTotalGeneral.Clear()
    End Sub

    Private Sub ButtonCargarProd_Click(sender As Object, e As EventArgs) Handles ButtonCargarProd.Click
        Dim formProductos As New FormProductos(connectionString)
        AddHandler formProductos.ProductoSeleccionado, AddressOf ProductoSeleccionadoHandler
        formProductos.ShowDialog()
    End Sub

    Private Sub ProductoSeleccionadoHandler(nombre As String, precio As Decimal)
        TextBoxCargarProducto.Text = nombre
        MaskedTextBoxPU.Text = precio.ToString()
    End Sub

    Private Sub ButtonBuscarVentas_Click(sender As Object, e As EventArgs) Handles ButtonBuscarVentas.Click
        Dim formBusquedaVentas As New FormBusquedaVentas(connectionString)
        formBusquedaVentas.ShowDialog()
    End Sub

    Private Sub MaskedTBCantidad_TextChanged(sender As Object, e As EventArgs) Handles MaskedTBCantidad.TextChanged
        ActualizarPrecioTotal()
    End Sub

    Private Sub MaskedTextBoxPU_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxPU.TextChanged
        ActualizarPrecioTotal()
    End Sub

    Private Sub ActualizarPrecioTotal()
        Dim cantidad As Integer
        Dim precioUnitario As Decimal
        Dim precioTotal As Decimal

        If Integer.TryParse(MaskedTBCantidad.Text.Trim(), cantidad) AndAlso
       Decimal.TryParse(MaskedTextBoxPU.Text.Trim(), precioUnitario) Then

            precioTotal = cantidad * precioUnitario
            MaskedTextBoxPrecioTotal.Text = precioTotal.ToString()
        Else
            MaskedTextBoxPrecioTotal.Text = String.Empty
        End If
    End Sub

    Private Sub ButtonVenta_Click(sender As Object, e As EventArgs) Handles ButtonVenta.Click
        If DataGridViewVentas.Rows.Count = 0 Then
            MessageBox.Show("No hay ítems para la venta.")
            Return
        End If

        If TextBoxClienteCargado.Text.Trim() = "" Then
            MessageBox.Show("No hay un cliente cargado.")
            Return
        End If

        Dim totalVenta As Decimal
        If Not Decimal.TryParse(TextBoxTotalGeneral.Text.Trim(), totalVenta) Then
            MessageBox.Show("El total de la venta no tiene un formato correcto.")
            Return
        End If

        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Iniciar una transacción
            Dim transaction As SqlTransaction = connection.BeginTransaction()

            Try
                ' Insertar en la tabla VENTAS
                Dim clienteID As Integer = ObtenerClienteID(TextBoxClienteCargado.Text.Trim())
                Dim fecha As DateTime = DateTime.Now

                Dim queryVentas As String = "INSERT INTO VENTAS (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total); SELECT SCOPE_IDENTITY();"
                Dim commandVentas As New SqlCommand(queryVentas, connection, transaction)
                commandVentas.Parameters.AddWithValue("@IDCliente", clienteID)
                commandVentas.Parameters.AddWithValue("@Fecha", fecha)
                commandVentas.Parameters.AddWithValue("@Total", totalVenta)

                Dim ventaID As Integer = Convert.ToInt32(commandVentas.ExecuteScalar())

                ' Insertar en la tabla VENTASITEMS
                For Each row As DataGridViewRow In DataGridViewVentas.Rows
                    If Not row.IsNewRow Then
                        Dim productoID As Integer = ObtenerProductoID(row.Cells("Producto").Value.ToString())
                        Dim cantidad As Integer = Convert.ToInt32(row.Cells("Cantidad").Value)
                        Dim precioUnitario As Decimal = Convert.ToDecimal(row.Cells("Precio Unitario").Value)
                        Dim precioTotal As Decimal = Convert.ToDecimal(row.Cells("Precio Total").Value)

                        Dim queryVentasItems As String = "INSERT INTO VENTASITEMS (IDVenta, IDProducto, Cantidad, PrecioUnitario, PrecioTotal) VALUES (@IDVenta, @IDProducto, @Cantidad, @PrecioUnitario, @PrecioTotal)"
                        Dim commandVentasItems As New SqlCommand(queryVentasItems, connection, transaction)
                        commandVentasItems.Parameters.AddWithValue("@IDVenta", ventaID)
                        commandVentasItems.Parameters.AddWithValue("@IDProducto", productoID)
                        commandVentasItems.Parameters.AddWithValue("@Cantidad", cantidad)
                        commandVentasItems.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
                        commandVentasItems.Parameters.AddWithValue("@PrecioTotal", precioTotal)

                        commandVentasItems.ExecuteNonQuery()
                    End If
                Next

                ' Confirmar la transacción
                transaction.Commit()

                MessageBox.Show("Venta registrada exitosamente.")
                LimpiarCampos()
                LimpiarDataGridView()
                ActualizarTotalGeneral()

            Catch ex As Exception
                ' Revertir la transacción en caso de error
                transaction.Rollback()
                MessageBox.Show("Error al registrar la venta: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function ObtenerClienteID(nombreCliente As String) As Integer
        ' Lógica para obtener el ID del cliente a partir del nombre
        ' Esto puede variar dependiendo de cómo estés almacenando los datos de clientes
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID FROM Clientes WHERE Cliente = @NombreCliente"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NombreCliente", nombreCliente)

            Dim clienteID As Object = command.ExecuteScalar()
            If clienteID IsNot Nothing Then
                Return Convert.ToInt32(clienteID)
            Else
                Throw New Exception("Cliente no encontrado.")
            End If
        End Using
    End Function

    Private Function ObtenerProductoID(nombreProducto As String) As Integer
        ' Lógica para obtener el ID del producto a partir del nombre
        ' Esto puede variar dependiendo de cómo estés almacenando los datos de productos
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT ID FROM Productos WHERE Nombre = @NombreProducto"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@NombreProducto", nombreProducto)

            Dim productoID As Object = command.ExecuteScalar()
            If productoID IsNot Nothing Then
                Return Convert.ToInt32(productoID)
            Else
                Throw New Exception("Producto no encontrado.")
            End If
        End Using
    End Function

    Private Sub ButtonCargarCliente_Click(sender As Object, e As EventArgs) Handles ButtonCargarCliente.Click
        Dim formClientes As New FormClientes(connectionString)
        AddHandler formClientes.ClienteSeleccionado, AddressOf CargarClienteSeleccionado
        formClientes.ShowDialog()
    End Sub

    Private Sub CargarClienteSeleccionado(nombreCliente As String)
        TextBoxClienteCargado.Text = nombreCliente
        TextBoxClienteCargado.ReadOnly = True ' Hacer que el TextBox no sea editable
    End Sub

    Private Sub LimpiarDataGridView()
        ' Lógica para limpiar el DataGridView después de la venta
        DataGridViewVentas.Rows.Clear()
    End Sub

End Class
