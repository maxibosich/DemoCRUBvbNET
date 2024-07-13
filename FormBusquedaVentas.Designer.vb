<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaVentas
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
        Me.DataGridViewVentasDone = New System.Windows.Forms.DataGridView()
        Me.ButtonBuscarVenta = New System.Windows.Forms.Button()
        Me.RadioButtonVCliente = New System.Windows.Forms.RadioButton()
        Me.RadioButtonVFecha = New System.Windows.Forms.RadioButton()
        Me.RadioButtonVTotal = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewVentasDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewVentasDone
        '
        Me.DataGridViewVentasDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVentasDone.Location = New System.Drawing.Point(12, 136)
        Me.DataGridViewVentasDone.Name = "DataGridViewVentasDone"
        Me.DataGridViewVentasDone.Size = New System.Drawing.Size(776, 302)
        Me.DataGridViewVentasDone.TabIndex = 0
        '
        'ButtonBuscarVenta
        '
        Me.ButtonBuscarVenta.Location = New System.Drawing.Point(649, 27)
        Me.ButtonBuscarVenta.Name = "ButtonBuscarVenta"
        Me.ButtonBuscarVenta.Size = New System.Drawing.Size(139, 64)
        Me.ButtonBuscarVenta.TabIndex = 1
        Me.ButtonBuscarVenta.Text = "Buscar Venta"
        Me.ButtonBuscarVenta.UseVisualStyleBackColor = True
        '
        'RadioButtonVCliente
        '
        Me.RadioButtonVCliente.AutoSize = True
        Me.RadioButtonVCliente.Location = New System.Drawing.Point(528, 27)
        Me.RadioButtonVCliente.Name = "RadioButtonVCliente"
        Me.RadioButtonVCliente.Size = New System.Drawing.Size(76, 17)
        Me.RadioButtonVCliente.TabIndex = 2
        Me.RadioButtonVCliente.TabStop = True
        Me.RadioButtonVCliente.Text = "Por Cliente"
        Me.RadioButtonVCliente.UseVisualStyleBackColor = True
        '
        'RadioButtonVFecha
        '
        Me.RadioButtonVFecha.AutoSize = True
        Me.RadioButtonVFecha.Location = New System.Drawing.Point(528, 60)
        Me.RadioButtonVFecha.Name = "RadioButtonVFecha"
        Me.RadioButtonVFecha.Size = New System.Drawing.Size(74, 17)
        Me.RadioButtonVFecha.TabIndex = 3
        Me.RadioButtonVFecha.TabStop = True
        Me.RadioButtonVFecha.Text = "Por Fecha"
        Me.RadioButtonVFecha.UseVisualStyleBackColor = True
        '
        'RadioButtonVTotal
        '
        Me.RadioButtonVTotal.AutoSize = True
        Me.RadioButtonVTotal.Location = New System.Drawing.Point(528, 93)
        Me.RadioButtonVTotal.Name = "RadioButtonVTotal"
        Me.RadioButtonVTotal.Size = New System.Drawing.Size(106, 17)
        Me.RadioButtonVTotal.TabIndex = 4
        Me.RadioButtonVTotal.TabStop = True
        Me.RadioButtonVTotal.Text = "Por Importe Total"
        Me.RadioButtonVTotal.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(509, 20)
        Me.TextBox1.TabIndex = 5
        '
        'FormBusquedaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButtonVTotal)
        Me.Controls.Add(Me.RadioButtonVFecha)
        Me.Controls.Add(Me.RadioButtonVCliente)
        Me.Controls.Add(Me.ButtonBuscarVenta)
        Me.Controls.Add(Me.DataGridViewVentasDone)
        Me.Name = "FormBusquedaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBusquedaVentas"
        CType(Me.DataGridViewVentasDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewVentasDone As DataGridView
    Friend WithEvents ButtonBuscarVenta As Button
    Friend WithEvents RadioButtonVCliente As RadioButton
    Friend WithEvents RadioButtonVFecha As RadioButton
    Friend WithEvents RadioButtonVTotal As RadioButton
    Friend WithEvents TextBox1 As TextBox
End Class
