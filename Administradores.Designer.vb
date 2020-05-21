<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administradores
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
        Me.lblAdministradores = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnDomicilios = New System.Windows.Forms.Button()
        Me.btnLlaves = New System.Windows.Forms.Button()
        Me.Trabajadores = New System.Windows.Forms.Button()
        Me.btnOficios = New System.Windows.Forms.Button()
        Me.btnFabricas = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAdministradores
        '
        Me.lblAdministradores.AutoSize = True
        Me.lblAdministradores.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdministradores.Location = New System.Drawing.Point(209, 10)
        Me.lblAdministradores.Name = "lblAdministradores"
        Me.lblAdministradores.Size = New System.Drawing.Size(282, 42)
        Me.lblAdministradores.TabIndex = 0
        Me.lblAdministradores.Text = "Administradores"
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(107, 67)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(233, 59)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnDomicilios
        '
        Me.btnDomicilios.Location = New System.Drawing.Point(107, 165)
        Me.btnDomicilios.Name = "btnDomicilios"
        Me.btnDomicilios.Size = New System.Drawing.Size(233, 59)
        Me.btnDomicilios.TabIndex = 4
        Me.btnDomicilios.Text = "Domicilios"
        Me.btnDomicilios.UseVisualStyleBackColor = True
        '
        'btnLlaves
        '
        Me.btnLlaves.Location = New System.Drawing.Point(107, 251)
        Me.btnLlaves.Name = "btnLlaves"
        Me.btnLlaves.Size = New System.Drawing.Size(233, 59)
        Me.btnLlaves.TabIndex = 6
        Me.btnLlaves.Text = "Llaves"
        Me.btnLlaves.UseVisualStyleBackColor = True
        '
        'Trabajadores
        '
        Me.Trabajadores.Location = New System.Drawing.Point(107, 338)
        Me.Trabajadores.Name = "Trabajadores"
        Me.Trabajadores.Size = New System.Drawing.Size(233, 59)
        Me.Trabajadores.TabIndex = 8
        Me.Trabajadores.Text = "Trabajadores"
        Me.Trabajadores.UseVisualStyleBackColor = True
        '
        'btnOficios
        '
        Me.btnOficios.Location = New System.Drawing.Point(453, 67)
        Me.btnOficios.Name = "btnOficios"
        Me.btnOficios.Size = New System.Drawing.Size(233, 59)
        Me.btnOficios.TabIndex = 9
        Me.btnOficios.Text = "Oficios"
        Me.btnOficios.UseVisualStyleBackColor = True
        '
        'btnFabricas
        '
        Me.btnFabricas.Location = New System.Drawing.Point(453, 165)
        Me.btnFabricas.Name = "btnFabricas"
        Me.btnFabricas.Size = New System.Drawing.Size(233, 59)
        Me.btnFabricas.TabIndex = 10
        Me.btnFabricas.Text = "Fabricas"
        Me.btnFabricas.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Location = New System.Drawing.Point(453, 265)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(233, 59)
        Me.btnProveedores.TabIndex = 11
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'Administradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnFabricas)
        Me.Controls.Add(Me.btnOficios)
        Me.Controls.Add(Me.Trabajadores)
        Me.Controls.Add(Me.btnLlaves)
        Me.Controls.Add(Me.btnDomicilios)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.lblAdministradores)
        Me.Name = "Administradores"
        Me.Text = "Administradores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAdministradores As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnDomicilios As Button
    Friend WithEvents btnLlaves As Button
    Friend WithEvents Trabajadores As Button
    Friend WithEvents btnOficios As Button
    Friend WithEvents btnFabricas As Button
    Friend WithEvents btnProveedores As Button
End Class
