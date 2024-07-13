<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.ButtonClientes = New System.Windows.Forms.Button()
        Me.ButtonProductos = New System.Windows.Forms.Button()
        Me.ButtonVentas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonClientes
        '
        Me.ButtonClientes.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonClientes.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientes.ForeColor = System.Drawing.Color.Red
        Me.ButtonClientes.Location = New System.Drawing.Point(282, 209)
        Me.ButtonClientes.Name = "ButtonClientes"
        Me.ButtonClientes.Size = New System.Drawing.Size(242, 141)
        Me.ButtonClientes.TabIndex = 0
        Me.ButtonClientes.Text = "Modulo Clientes"
        Me.ButtonClientes.UseVisualStyleBackColor = False
        '
        'ButtonProductos
        '
        Me.ButtonProductos.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ButtonProductos.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductos.ForeColor = System.Drawing.Color.Red
        Me.ButtonProductos.Location = New System.Drawing.Point(554, 209)
        Me.ButtonProductos.Name = "ButtonProductos"
        Me.ButtonProductos.Size = New System.Drawing.Size(242, 141)
        Me.ButtonProductos.TabIndex = 1
        Me.ButtonProductos.Text = "Modulo Productos"
        Me.ButtonProductos.UseVisualStyleBackColor = False
        '
        'ButtonVentas
        '
        Me.ButtonVentas.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVentas.ForeColor = System.Drawing.Color.Red
        Me.ButtonVentas.Location = New System.Drawing.Point(826, 209)
        Me.ButtonVentas.Name = "ButtonVentas"
        Me.ButtonVentas.Size = New System.Drawing.Size(242, 141)
        Me.ButtonVentas.TabIndex = 2
        Me.ButtonVentas.Text = "Modulo Ventas"
        Me.ButtonVentas.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.ButtonVentas)
        Me.Controls.Add(Me.ButtonProductos)
        Me.Controls.Add(Me.ButtonClientes)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonClientes As Button
    Friend WithEvents ButtonProductos As Button
    Friend WithEvents ButtonVentas As Button
End Class
