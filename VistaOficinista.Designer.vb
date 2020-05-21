<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaOficinista
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.brnVerTrabajadores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OFICINISTA"
        '
        'btnVerClientes
        '
        Me.btnVerClientes.Location = New System.Drawing.Point(81, 84)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(233, 59)
        Me.btnVerClientes.TabIndex = 1
        Me.btnVerClientes.Text = "Ver Clientes"
        Me.btnVerClientes.UseVisualStyleBackColor = True
        '
        'brnVerTrabajadores
        '
        Me.brnVerTrabajadores.Location = New System.Drawing.Point(72, 245)
        Me.brnVerTrabajadores.Name = "brnVerTrabajadores"
        Me.brnVerTrabajadores.Size = New System.Drawing.Size(242, 79)
        Me.brnVerTrabajadores.TabIndex = 2
        Me.brnVerTrabajadores.Text = "Ver Trabajadores"
        Me.brnVerTrabajadores.UseVisualStyleBackColor = True
        '
        'VistaOficinista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.brnVerTrabajadores)
        Me.Controls.Add(Me.btnVerClientes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VistaOficinista"
        Me.Text = "VistaOficinista"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVerClientes As Button
    Friend WithEvents brnVerTrabajadores As Button
End Class
