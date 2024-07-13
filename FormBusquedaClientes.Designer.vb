<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaClientes
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
        Me.TextBoxFiltro = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.RadioButtonCliente = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTelefono = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCorreo = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxFiltro
        '
        Me.TextBoxFiltro.Location = New System.Drawing.Point(15, 28)
        Me.TextBoxFiltro.Name = "TextBoxFiltro"
        Me.TextBoxFiltro.Size = New System.Drawing.Size(399, 20)
        Me.TextBoxFiltro.TabIndex = 5
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(525, 13)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(261, 50)
        Me.ButtonBuscar.TabIndex = 4
        Me.ButtonBuscar.Text = "Buscar Cliente"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(12, 81)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.Size = New System.Drawing.Size(776, 357)
        Me.DataGridViewClientes.TabIndex = 3
        '
        'RadioButtonCliente
        '
        Me.RadioButtonCliente.AutoSize = True
        Me.RadioButtonCliente.Location = New System.Drawing.Point(420, 13)
        Me.RadioButtonCliente.Name = "RadioButtonCliente"
        Me.RadioButtonCliente.Size = New System.Drawing.Size(81, 17)
        Me.RadioButtonCliente.TabIndex = 6
        Me.RadioButtonCliente.TabStop = True
        Me.RadioButtonCliente.Text = "Por Nombre"
        Me.RadioButtonCliente.UseVisualStyleBackColor = True
        '
        'RadioButtonTelefono
        '
        Me.RadioButtonTelefono.AutoSize = True
        Me.RadioButtonTelefono.Location = New System.Drawing.Point(420, 30)
        Me.RadioButtonTelefono.Name = "RadioButtonTelefono"
        Me.RadioButtonTelefono.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonTelefono.TabIndex = 7
        Me.RadioButtonTelefono.TabStop = True
        Me.RadioButtonTelefono.Text = "Por Telefono"
        Me.RadioButtonTelefono.UseVisualStyleBackColor = True
        '
        'RadioButtonCorreo
        '
        Me.RadioButtonCorreo.AutoSize = True
        Me.RadioButtonCorreo.Location = New System.Drawing.Point(420, 47)
        Me.RadioButtonCorreo.Name = "RadioButtonCorreo"
        Me.RadioButtonCorreo.Size = New System.Drawing.Size(75, 17)
        Me.RadioButtonCorreo.TabIndex = 8
        Me.RadioButtonCorreo.TabStop = True
        Me.RadioButtonCorreo.Text = "Por Correo"
        Me.RadioButtonCorreo.UseVisualStyleBackColor = True
        '
        'FormBusquedaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButtonCorreo)
        Me.Controls.Add(Me.RadioButtonTelefono)
        Me.Controls.Add(Me.RadioButtonCliente)
        Me.Controls.Add(Me.TextBoxFiltro)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Name = "FormBusquedaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBusquedaClientes"
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFiltro As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents RadioButtonCliente As RadioButton
    Friend WithEvents RadioButtonTelefono As RadioButton
    Friend WithEvents RadioButtonCorreo As RadioButton
End Class
