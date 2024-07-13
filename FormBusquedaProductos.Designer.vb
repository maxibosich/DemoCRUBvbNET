<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusquedaProductos
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
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxFiltro = New System.Windows.Forms.TextBox()
        Me.RadioButtonCatProd = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNomProd = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(12, 81)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.Size = New System.Drawing.Size(776, 357)
        Me.DataGridViewProductos.TabIndex = 0
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(525, 13)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(261, 50)
        Me.ButtonBuscar.TabIndex = 1
        Me.ButtonBuscar.Text = "Buscar Producto"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxFiltro
        '
        Me.TextBoxFiltro.Location = New System.Drawing.Point(15, 28)
        Me.TextBoxFiltro.Name = "TextBoxFiltro"
        Me.TextBoxFiltro.Size = New System.Drawing.Size(398, 20)
        Me.TextBoxFiltro.TabIndex = 2
        '
        'RadioButtonCatProd
        '
        Me.RadioButtonCatProd.AutoSize = True
        Me.RadioButtonCatProd.Location = New System.Drawing.Point(419, 46)
        Me.RadioButtonCatProd.Name = "RadioButtonCatProd"
        Me.RadioButtonCatProd.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonCatProd.TabIndex = 10
        Me.RadioButtonCatProd.TabStop = True
        Me.RadioButtonCatProd.Text = "Por Categoria"
        Me.RadioButtonCatProd.UseVisualStyleBackColor = True
        '
        'RadioButtonNomProd
        '
        Me.RadioButtonNomProd.AutoSize = True
        Me.RadioButtonNomProd.Location = New System.Drawing.Point(419, 13)
        Me.RadioButtonNomProd.Name = "RadioButtonNomProd"
        Me.RadioButtonNomProd.Size = New System.Drawing.Size(87, 17)
        Me.RadioButtonNomProd.TabIndex = 9
        Me.RadioButtonNomProd.TabStop = True
        Me.RadioButtonNomProd.Text = "Por Producto"
        Me.RadioButtonNomProd.UseVisualStyleBackColor = True
        '
        'FormBusquedaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButtonCatProd)
        Me.Controls.Add(Me.RadioButtonNomProd)
        Me.Controls.Add(Me.TextBoxFiltro)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Controls.Add(Me.DataGridViewProductos)
        Me.Name = "FormBusquedaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBusquedaProductos"
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxFiltro As TextBox
    Friend WithEvents RadioButtonCatProd As RadioButton
    Friend WithEvents RadioButtonNomProd As RadioButton
End Class
