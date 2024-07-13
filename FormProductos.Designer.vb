<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelPrecio = New System.Windows.Forms.Label()
        Me.LabelCategoria = New System.Windows.Forms.Label()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonBuscarProducto = New System.Windows.Forms.Button()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.Size = New System.Drawing.Size(776, 310)
        Me.DataGridViewProductos.TabIndex = 0
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(161, 340)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 1
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(161, 377)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrecio.TabIndex = 2
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(161, 418)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCategoria.TabIndex = 3
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNombre.Location = New System.Drawing.Point(67, 340)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(50, 13)
        Me.LabelNombre.TabIndex = 4
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelPrecio
        '
        Me.LabelPrecio.AutoSize = True
        Me.LabelPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelPrecio.Location = New System.Drawing.Point(67, 383)
        Me.LabelPrecio.Name = "LabelPrecio"
        Me.LabelPrecio.Size = New System.Drawing.Size(43, 13)
        Me.LabelPrecio.TabIndex = 5
        Me.LabelPrecio.Text = "Precio"
        '
        'LabelCategoria
        '
        Me.LabelCategoria.AutoSize = True
        Me.LabelCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCategoria.Location = New System.Drawing.Point(67, 418)
        Me.LabelCategoria.Name = "LabelCategoria"
        Me.LabelCategoria.Size = New System.Drawing.Size(61, 13)
        Me.LabelCategoria.TabIndex = 6
        Me.LabelCategoria.Text = "Categoria"
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonEliminar.Location = New System.Drawing.Point(547, 361)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonEliminar.TabIndex = 10
        Me.ButtonEliminar.Text = "Eliminar Producto"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonActualizar.Location = New System.Drawing.Point(425, 361)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonActualizar.TabIndex = 9
        Me.ButtonActualizar.Text = "Actualizar Producto"
        Me.ButtonActualizar.UseVisualStyleBackColor = False
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonAgregar.Location = New System.Drawing.Point(303, 361)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonAgregar.TabIndex = 8
        Me.ButtonAgregar.Text = "Agregar Producto"
        Me.ButtonAgregar.UseVisualStyleBackColor = False
        '
        'ButtonBuscarProducto
        '
        Me.ButtonBuscarProducto.Location = New System.Drawing.Point(669, 361)
        Me.ButtonBuscarProducto.Name = "ButtonBuscarProducto"
        Me.ButtonBuscarProducto.Size = New System.Drawing.Size(103, 50)
        Me.ButtonBuscarProducto.TabIndex = 11
        Me.ButtonBuscarProducto.Text = "Buscar Productos"
        Me.ButtonBuscarProducto.UseVisualStyleBackColor = True
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonBuscarProducto)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.LabelCategoria)
        Me.Controls.Add(Me.LabelPrecio)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TextBoxCategoria)
        Me.Controls.Add(Me.TextBoxPrecio)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProductos"
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelPrecio As Label
    Friend WithEvents LabelCategoria As Label
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ButtonBuscarProducto As Button
End Class
