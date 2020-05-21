<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirEliminarClientes
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.tbId = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.btnAñadirCliente = New System.Windows.Forms.Button()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(53, 54)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(31, 29)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(53, 118)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(83, 29)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(53, 187)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(92, 29)
        Me.lblApellidos.TabIndex = 2
        Me.lblApellidos.Text = "Apellidos"
        '
        'tbId
        '
        Me.tbId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbId.Location = New System.Drawing.Point(169, 54)
        Me.tbId.Name = "tbId"
        Me.tbId.Size = New System.Drawing.Size(63, 31)
        Me.tbId.TabIndex = 3
        '
        'tbNombres
        '
        Me.tbNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombres.Location = New System.Drawing.Point(169, 116)
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(120, 31)
        Me.tbNombres.TabIndex = 4
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(169, 185)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(235, 31)
        Me.tbApellidos.TabIndex = 5
        '
        'btnAñadirCliente
        '
        Me.btnAñadirCliente.Location = New System.Drawing.Point(533, 52)
        Me.btnAñadirCliente.Name = "btnAñadirCliente"
        Me.btnAñadirCliente.Size = New System.Drawing.Size(222, 44)
        Me.btnAñadirCliente.TabIndex = 6
        Me.btnAñadirCliente.Text = "Añadir"
        Me.btnAñadirCliente.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(533, 163)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(222, 44)
        Me.btnEliminarCliente.TabIndex = 7
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'AñadirEliminarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnAñadirCliente)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.tbNombres)
        Me.Controls.Add(Me.tbId)
        Me.Controls.Add(Me.lblApellidos)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblId)
        Me.Name = "AñadirEliminarClientes"
        Me.Text = "Añadir Eliminar Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidos As Label
    Friend WithEvents tbId As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents btnAñadirCliente As Button
    Friend WithEvents btnEliminarCliente As Button
End Class
