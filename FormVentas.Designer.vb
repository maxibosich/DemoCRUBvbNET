<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridViewVentas = New System.Windows.Forms.DataGridView()
        Me.LabelTotalGeneral = New System.Windows.Forms.Label()
        Me.TextBoxCargarProducto = New System.Windows.Forms.TextBox()
        Me.ButtonCargarProd = New System.Windows.Forms.Button()
        Me.LabelPrecioUnitario = New System.Windows.Forms.Label()
        Me.LabelPrecioTotal = New System.Windows.Forms.Label()
        Me.ButtonAgregarItem = New System.Windows.Forms.Button()
        Me.ButtonModificarItem = New System.Windows.Forms.Button()
        Me.ButtonEliminarItem = New System.Windows.Forms.Button()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.MaskedTBCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonVenta = New System.Windows.Forms.Button()
        Me.ButtonBuscarVentas = New System.Windows.Forms.Button()
        Me.MaskedTextBoxPrecioTotal = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxPU = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonCargarCliente = New System.Windows.Forms.Button()
        Me.TextBoxClienteCargado = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalGeneral = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewVentas
        '
        Me.DataGridViewVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentas.Location = New System.Drawing.Point(12, 109)
        Me.DataGridViewVentas.Name = "DataGridViewVentas"
        Me.DataGridViewVentas.Size = New System.Drawing.Size(776, 238)
        Me.DataGridViewVentas.TabIndex = 0
        '
        'LabelTotalGeneral
        '
        Me.LabelTotalGeneral.AutoSize = True
        Me.LabelTotalGeneral.Location = New System.Drawing.Point(568, 364)
        Me.LabelTotalGeneral.Name = "LabelTotalGeneral"
        Me.LabelTotalGeneral.Size = New System.Drawing.Size(62, 13)
        Me.LabelTotalGeneral.TabIndex = 2
        Me.LabelTotalGeneral.Text = "Total Venta"
        '
        'TextBoxCargarProducto
        '
        Me.TextBoxCargarProducto.Location = New System.Drawing.Point(23, 79)
        Me.TextBoxCargarProducto.Name = "TextBoxCargarProducto"
        Me.TextBoxCargarProducto.Size = New System.Drawing.Size(169, 20)
        Me.TextBoxCargarProducto.TabIndex = 3
        '
        'ButtonCargarProd
        '
        Me.ButtonCargarProd.Location = New System.Drawing.Point(57, 41)
        Me.ButtonCargarProd.Name = "ButtonCargarProd"
        Me.ButtonCargarProd.Size = New System.Drawing.Size(100, 32)
        Me.ButtonCargarProd.TabIndex = 6
        Me.ButtonCargarProd.Text = "Cargar Producto"
        Me.ButtonCargarProd.UseVisualStyleBackColor = True
        '
        'LabelPrecioUnitario
        '
        Me.LabelPrecioUnitario.AutoSize = True
        Me.LabelPrecioUnitario.Location = New System.Drawing.Point(232, 55)
        Me.LabelPrecioUnitario.Name = "LabelPrecioUnitario"
        Me.LabelPrecioUnitario.Size = New System.Drawing.Size(76, 13)
        Me.LabelPrecioUnitario.TabIndex = 7
        Me.LabelPrecioUnitario.Text = "Precio Unitario"
        '
        'LabelPrecioTotal
        '
        Me.LabelPrecioTotal.AutoSize = True
        Me.LabelPrecioTotal.Location = New System.Drawing.Point(433, 55)
        Me.LabelPrecioTotal.Name = "LabelPrecioTotal"
        Me.LabelPrecioTotal.Size = New System.Drawing.Size(64, 13)
        Me.LabelPrecioTotal.TabIndex = 8
        Me.LabelPrecioTotal.Text = "Precio Total"
        '
        'ButtonAgregarItem
        '
        Me.ButtonAgregarItem.Location = New System.Drawing.Point(645, 9)
        Me.ButtonAgregarItem.Name = "ButtonAgregarItem"
        Me.ButtonAgregarItem.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAgregarItem.TabIndex = 9
        Me.ButtonAgregarItem.Text = "Agregar"
        Me.ButtonAgregarItem.UseVisualStyleBackColor = True
        '
        'ButtonModificarItem
        '
        Me.ButtonModificarItem.Location = New System.Drawing.Point(645, 41)
        Me.ButtonModificarItem.Name = "ButtonModificarItem"
        Me.ButtonModificarItem.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModificarItem.TabIndex = 10
        Me.ButtonModificarItem.Text = "Modificar"
        Me.ButtonModificarItem.UseVisualStyleBackColor = True
        '
        'ButtonEliminarItem
        '
        Me.ButtonEliminarItem.Location = New System.Drawing.Point(645, 73)
        Me.ButtonEliminarItem.Name = "ButtonEliminarItem"
        Me.ButtonEliminarItem.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminarItem.TabIndex = 11
        Me.ButtonEliminarItem.Text = "Eliminar"
        Me.ButtonEliminarItem.UseVisualStyleBackColor = True
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Location = New System.Drawing.Point(343, 55)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LabelCantidad.TabIndex = 12
        Me.LabelCantidad.Text = "Cantidad"
        '
        'MaskedTBCantidad
        '
        Me.MaskedTBCantidad.Location = New System.Drawing.Point(354, 79)
        Me.MaskedTBCantidad.Mask = "999"
        Me.MaskedTBCantidad.Name = "MaskedTBCantidad"
        Me.MaskedTBCantidad.Size = New System.Drawing.Size(26, 20)
        Me.MaskedTBCantidad.TabIndex = 13
        Me.MaskedTBCantidad.ValidatingType = GetType(Integer)
        '
        'ButtonVenta
        '
        Me.ButtonVenta.Location = New System.Drawing.Point(645, 400)
        Me.ButtonVenta.Name = "ButtonVenta"
        Me.ButtonVenta.Size = New System.Drawing.Size(142, 38)
        Me.ButtonVenta.TabIndex = 14
        Me.ButtonVenta.Text = "Realizar Venta"
        Me.ButtonVenta.UseVisualStyleBackColor = True
        '
        'ButtonBuscarVentas
        '
        Me.ButtonBuscarVentas.Location = New System.Drawing.Point(13, 374)
        Me.ButtonBuscarVentas.Name = "ButtonBuscarVentas"
        Me.ButtonBuscarVentas.Size = New System.Drawing.Size(144, 64)
        Me.ButtonBuscarVentas.TabIndex = 15
        Me.ButtonBuscarVentas.Text = "Buscar Ventas Realizadas"
        Me.ButtonBuscarVentas.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxPrecioTotal
        '
        Me.MaskedTextBoxPrecioTotal.Location = New System.Drawing.Point(436, 79)
        Me.MaskedTextBoxPrecioTotal.Mask = "99999"
        Me.MaskedTextBoxPrecioTotal.Name = "MaskedTextBoxPrecioTotal"
        Me.MaskedTextBoxPrecioTotal.Size = New System.Drawing.Size(37, 20)
        Me.MaskedTextBoxPrecioTotal.TabIndex = 16
        Me.MaskedTextBoxPrecioTotal.ValidatingType = GetType(Integer)
        '
        'MaskedTextBoxPU
        '
        Me.MaskedTextBoxPU.Location = New System.Drawing.Point(254, 79)
        Me.MaskedTextBoxPU.Mask = "99999"
        Me.MaskedTextBoxPU.Name = "MaskedTextBoxPU"
        Me.MaskedTextBoxPU.Size = New System.Drawing.Size(37, 20)
        Me.MaskedTextBoxPU.TabIndex = 17
        Me.MaskedTextBoxPU.ValidatingType = GetType(Integer)
        '
        'ButtonCargarCliente
        '
        Me.ButtonCargarCliente.Location = New System.Drawing.Point(57, 3)
        Me.ButtonCargarCliente.Name = "ButtonCargarCliente"
        Me.ButtonCargarCliente.Size = New System.Drawing.Size(100, 32)
        Me.ButtonCargarCliente.TabIndex = 18
        Me.ButtonCargarCliente.Text = "Cargar Cliente"
        Me.ButtonCargarCliente.UseVisualStyleBackColor = True
        '
        'TextBoxClienteCargado
        '
        Me.TextBoxClienteCargado.Location = New System.Drawing.Point(191, 9)
        Me.TextBoxClienteCargado.Name = "TextBoxClienteCargado"
        Me.TextBoxClienteCargado.Size = New System.Drawing.Size(282, 20)
        Me.TextBoxClienteCargado.TabIndex = 19
        '
        'TextBoxTotalGeneral
        '
        Me.TextBoxTotalGeneral.Location = New System.Drawing.Point(645, 356)
        Me.TextBoxTotalGeneral.Mask = "99999"
        Me.TextBoxTotalGeneral.Name = "TextBoxTotalGeneral"
        Me.TextBoxTotalGeneral.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxTotalGeneral.TabIndex = 20
        Me.TextBoxTotalGeneral.ValidatingType = GetType(Integer)
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxTotalGeneral)
        Me.Controls.Add(Me.TextBoxClienteCargado)
        Me.Controls.Add(Me.ButtonCargarCliente)
        Me.Controls.Add(Me.MaskedTextBoxPU)
        Me.Controls.Add(Me.MaskedTextBoxPrecioTotal)
        Me.Controls.Add(Me.ButtonBuscarVentas)
        Me.Controls.Add(Me.ButtonVenta)
        Me.Controls.Add(Me.MaskedTBCantidad)
        Me.Controls.Add(Me.LabelCantidad)
        Me.Controls.Add(Me.ButtonEliminarItem)
        Me.Controls.Add(Me.ButtonModificarItem)
        Me.Controls.Add(Me.ButtonAgregarItem)
        Me.Controls.Add(Me.LabelPrecioTotal)
        Me.Controls.Add(Me.LabelPrecioUnitario)
        Me.Controls.Add(Me.ButtonCargarProd)
        Me.Controls.Add(Me.TextBoxCargarProducto)
        Me.Controls.Add(Me.LabelTotalGeneral)
        Me.Controls.Add(Me.DataGridViewVentas)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormVentas"
        CType(Me.DataGridViewVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewVentas As DataGridView
    Friend WithEvents LabelTotalGeneral As Label
    Friend WithEvents TextBoxCargarProducto As TextBox
    Friend WithEvents ButtonCargarProd As Button
    Friend WithEvents LabelPrecioUnitario As Label
    Friend WithEvents LabelPrecioTotal As Label
    Friend WithEvents ButtonAgregarItem As Button
    Friend WithEvents ButtonModificarItem As Button
    Friend WithEvents ButtonEliminarItem As Button
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents MaskedTBCantidad As MaskedTextBox
    Friend WithEvents ButtonVenta As Button
    Friend WithEvents ButtonBuscarVentas As Button
    Friend WithEvents MaskedTextBoxPrecioTotal As MaskedTextBox
    Friend WithEvents MaskedTextBoxPU As MaskedTextBox
    Friend WithEvents ButtonCargarCliente As Button
    Friend WithEvents TextBoxClienteCargado As TextBox
    Friend WithEvents TextBoxTotalGeneral As MaskedTextBox
End Class
