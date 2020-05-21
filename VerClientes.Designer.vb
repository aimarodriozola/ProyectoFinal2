<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerClientes
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
        Me.lbVerCliente = New System.Windows.Forms.Label()
        Me.cbVerCliente = New System.Windows.Forms.ComboBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblApellidosClientes = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblDomicilios = New System.Windows.Forms.Label()
        Me.lbDomiciliosCliente = New System.Windows.Forms.ListBox()
        Me.btnVolverClientesOficina = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbVerCliente
        '
        Me.lbVerCliente.AutoSize = True
        Me.lbVerCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVerCliente.Location = New System.Drawing.Point(358, 9)
        Me.lbVerCliente.Name = "lbVerCliente"
        Me.lbVerCliente.Size = New System.Drawing.Size(153, 42)
        Me.lbVerCliente.TabIndex = 0
        Me.lbVerCliente.Text = "Clientes"
        '
        'cbVerCliente
        '
        Me.cbVerCliente.FormattingEnabled = True
        Me.cbVerCliente.Location = New System.Drawing.Point(51, 63)
        Me.cbVerCliente.Name = "cbVerCliente"
        Me.cbVerCliente.Size = New System.Drawing.Size(273, 21)
        Me.cbVerCliente.TabIndex = 1
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(47, 138)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(88, 24)
        Me.lblNombreCliente.TabIndex = 2
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(184, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(256, 31)
        Me.TextBox1.TabIndex = 3
        '
        'lblApellidosClientes
        '
        Me.lblApellidosClientes.AutoSize = True
        Me.lblApellidosClientes.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosClientes.Location = New System.Drawing.Point(47, 200)
        Me.lblApellidosClientes.Name = "lblApellidosClientes"
        Me.lblApellidosClientes.Size = New System.Drawing.Size(99, 24)
        Me.lblApellidosClientes.TabIndex = 4
        Me.lblApellidosClientes.Text = "Apellidos:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(184, 200)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(527, 26)
        Me.TextBox2.TabIndex = 5
        '
        'lblDomicilios
        '
        Me.lblDomicilios.AutoSize = True
        Me.lblDomicilios.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilios.Location = New System.Drawing.Point(47, 259)
        Me.lblDomicilios.Name = "lblDomicilios"
        Me.lblDomicilios.Size = New System.Drawing.Size(112, 24)
        Me.lblDomicilios.TabIndex = 6
        Me.lblDomicilios.Text = "Domicilios:"
        '
        'lbDomiciliosCliente
        '
        Me.lbDomiciliosCliente.FormattingEnabled = True
        Me.lbDomiciliosCliente.Location = New System.Drawing.Point(184, 259)
        Me.lbDomiciliosCliente.Name = "lbDomiciliosCliente"
        Me.lbDomiciliosCliente.Size = New System.Drawing.Size(521, 108)
        Me.lbDomiciliosCliente.TabIndex = 7
        '
        'btnVolverClientesOficina
        '
        Me.btnVolverClientesOficina.Location = New System.Drawing.Point(266, 373)
        Me.btnVolverClientesOficina.Name = "btnVolverClientesOficina"
        Me.btnVolverClientesOficina.Size = New System.Drawing.Size(214, 65)
        Me.btnVolverClientesOficina.TabIndex = 8
        Me.btnVolverClientesOficina.Text = "Volver"
        Me.btnVolverClientesOficina.UseVisualStyleBackColor = True
        '
        'VerClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolverClientesOficina)
        Me.Controls.Add(Me.lbDomiciliosCliente)
        Me.Controls.Add(Me.lblDomicilios)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblApellidosClientes)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.cbVerCliente)
        Me.Controls.Add(Me.lbVerCliente)
        Me.Name = "VerClientes"
        Me.Text = "Ver Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbVerCliente As Label
    Friend WithEvents cbVerCliente As ComboBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblApellidosClientes As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblDomicilios As Label
    Friend WithEvents lbDomiciliosCliente As ListBox
    Friend WithEvents btnVolverClientesOficina As Button
End Class
