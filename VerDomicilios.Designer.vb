<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inmobiliario
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
        Me.cbIdInmobiliario = New System.Windows.Forms.ComboBox()
        Me.lblIdInmobiliario = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.btnCiudad = New System.Windows.Forms.Label()
        Me.tbCiudad = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Pagado = New System.Windows.Forms.GroupBox()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnAñadirCliente = New System.Windows.Forms.Button()
        Me.Pagado.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbIdInmobiliario
        '
        Me.cbIdInmobiliario.FormattingEnabled = True
        Me.cbIdInmobiliario.Location = New System.Drawing.Point(124, 36)
        Me.cbIdInmobiliario.Name = "cbIdInmobiliario"
        Me.cbIdInmobiliario.Size = New System.Drawing.Size(39, 21)
        Me.cbIdInmobiliario.TabIndex = 0
        '
        'lblIdInmobiliario
        '
        Me.lblIdInmobiliario.AutoSize = True
        Me.lblIdInmobiliario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdInmobiliario.Location = New System.Drawing.Point(42, 36)
        Me.lblIdInmobiliario.Name = "lblIdInmobiliario"
        Me.lblIdInmobiliario.Size = New System.Drawing.Size(26, 20)
        Me.lblIdInmobiliario.TabIndex = 1
        Me.lblIdInmobiliario.Text = "ID"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(38, 96)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(65, 20)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Direccion"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(136, 100)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(362, 20)
        Me.tbDireccion.TabIndex = 3
        '
        'btnCiudad
        '
        Me.btnCiudad.AutoSize = True
        Me.btnCiudad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCiudad.Location = New System.Drawing.Point(38, 148)
        Me.btnCiudad.Name = "btnCiudad"
        Me.btnCiudad.Size = New System.Drawing.Size(51, 20)
        Me.btnCiudad.TabIndex = 4
        Me.btnCiudad.Text = "Ciudad"
        '
        'tbCiudad
        '
        Me.tbCiudad.Location = New System.Drawing.Point(136, 150)
        Me.tbCiudad.Name = "tbCiudad"
        Me.tbCiudad.Size = New System.Drawing.Size(362, 20)
        Me.tbCiudad.TabIndex = 5
        '
        'Pagado
        '
        Me.Pagado.Controls.Add(Me.rbNo)
        Me.Pagado.Controls.Add(Me.rbSi)
        Me.Pagado.Location = New System.Drawing.Point(46, 211)
        Me.Pagado.Name = "Pagado"
        Me.Pagado.Size = New System.Drawing.Size(451, 59)
        Me.Pagado.TabIndex = 7
        Me.Pagado.TabStop = False
        Me.Pagado.Text = "Pagado"
        '
        'rbSi
        '
        Me.rbSi.AutoSize = True
        Me.rbSi.Checked = True
        Me.rbSi.Location = New System.Drawing.Point(55, 20)
        Me.rbSi.Name = "rbSi"
        Me.rbSi.Size = New System.Drawing.Size(34, 17)
        Me.rbSi.TabIndex = 0
        Me.rbSi.TabStop = True
        Me.rbSi.Text = "Si"
        Me.rbSi.UseVisualStyleBackColor = True
        '
        'rbNo
        '
        Me.rbNo.AutoSize = True
        Me.rbNo.Location = New System.Drawing.Point(159, 20)
        Me.rbNo.Name = "rbNo"
        Me.rbNo.Size = New System.Drawing.Size(39, 17)
        Me.rbNo.TabIndex = 1
        Me.rbNo.Text = "No"
        Me.rbNo.UseVisualStyleBackColor = True
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(554, 171)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(222, 44)
        Me.btnEliminarCliente.TabIndex = 9
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnAñadirCliente
        '
        Me.btnAñadirCliente.Location = New System.Drawing.Point(554, 60)
        Me.btnAñadirCliente.Name = "btnAñadirCliente"
        Me.btnAñadirCliente.Size = New System.Drawing.Size(222, 44)
        Me.btnAñadirCliente.TabIndex = 8
        Me.btnAñadirCliente.Text = "Añadir"
        Me.btnAñadirCliente.UseVisualStyleBackColor = True
        '
        'Inmobiliario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnAñadirCliente)
        Me.Controls.Add(Me.Pagado)
        Me.Controls.Add(Me.tbCiudad)
        Me.Controls.Add(Me.btnCiudad)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblIdInmobiliario)
        Me.Controls.Add(Me.cbIdInmobiliario)
        Me.Name = "Inmobiliario"
        Me.Text = "Inmobiliario"
        Me.Pagado.ResumeLayout(False)
        Me.Pagado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbIdInmobiliario As ComboBox
    Friend WithEvents lblIdInmobiliario As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents btnCiudad As Label
    Friend WithEvents tbCiudad As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Pagado As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnAñadirCliente As Button
End Class
