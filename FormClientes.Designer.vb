<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.ButtonActualizar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.Size = New System.Drawing.Size(776, 339)
        Me.DataGridViewClientes.TabIndex = 0
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.Location = New System.Drawing.Point(113, 362)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(203, 20)
        Me.TextBoxCliente.TabIndex = 1
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(113, 418)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(203, 20)
        Me.TextBoxCorreo.TabIndex = 2
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCliente.Location = New System.Drawing.Point(59, 366)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(46, 13)
        Me.LabelCliente.TabIndex = 3
        Me.LabelCliente.Text = "Cliente"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCorreo.Location = New System.Drawing.Point(59, 420)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(44, 13)
        Me.LabelCorreo.TabIndex = 4
        Me.LabelCorreo.Text = "Correo"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Location = New System.Drawing.Point(322, 362)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonAgregar.TabIndex = 5
        Me.ButtonAgregar.Text = "Agregar Cliente"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Location = New System.Drawing.Point(440, 362)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonActualizar.TabIndex = 6
        Me.ButtonActualizar.Text = "Actualizar Cliente"
        Me.ButtonActualizar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(558, 362)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonEliminar.TabIndex = 7
        Me.ButtonEliminar.Text = "Eliminar Cliente"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(676, 362)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(103, 50)
        Me.ButtonBuscar.TabIndex = 8
        Me.ButtonBuscar.Text = "Buscar Clientes"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefono.Location = New System.Drawing.Point(52, 393)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(57, 13)
        Me.LabelTelefono.TabIndex = 10
        Me.LabelTelefono.Text = "Telefono"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(113, 390)
        Me.MaskedTextBox1.Mask = "(999)0000-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(203, 20)
        Me.MaskedTextBox1.TabIndex = 11
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonAgregar)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.LabelCliente)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.TextBoxCliente)
        Me.Controls.Add(Me.DataGridViewClientes)
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents LabelCliente As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents ButtonActualizar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
