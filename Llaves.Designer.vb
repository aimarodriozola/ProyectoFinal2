<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Llaves
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
        Me.Funcionalidad = New System.Windows.Forms.GroupBox()
        Me.rbNo = New System.Windows.Forms.RadioButton()
        Me.rbSi = New System.Windows.Forms.RadioButton()
        Me.lblILave = New System.Windows.Forms.Label()
        Me.cbIdLave = New System.Windows.Forms.ComboBox()
        Me.lblIdInmobiliario = New System.Windows.Forms.Label()
        Me.cbIdInmobiliario = New System.Windows.Forms.ComboBox()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnAñadirCliente = New System.Windows.Forms.Button()
        Me.Funcionalidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Funcionalidad
        '
        Me.Funcionalidad.Controls.Add(Me.rbNo)
        Me.Funcionalidad.Controls.Add(Me.rbSi)
        Me.Funcionalidad.Location = New System.Drawing.Point(28, 177)
        Me.Funcionalidad.Name = "Funcionalidad"
        Me.Funcionalidad.Size = New System.Drawing.Size(451, 59)
        Me.Funcionalidad.TabIndex = 8
        Me.Funcionalidad.TabStop = False
        Me.Funcionalidad.Text = "Funcionalidad"
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
        'lblILave
        '
        Me.lblILave.AutoSize = True
        Me.lblILave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblILave.Location = New System.Drawing.Point(40, 30)
        Me.lblILave.Name = "lblILave"
        Me.lblILave.Size = New System.Drawing.Size(26, 20)
        Me.lblILave.TabIndex = 10
        Me.lblILave.Text = "ID"
        '
        'cbIdLave
        '
        Me.cbIdLave.FormattingEnabled = True
        Me.cbIdLave.Location = New System.Drawing.Point(122, 30)
        Me.cbIdLave.Name = "cbIdLave"
        Me.cbIdLave.Size = New System.Drawing.Size(39, 21)
        Me.cbIdLave.TabIndex = 9
        '
        'lblIdInmobiliario
        '
        Me.lblIdInmobiliario.AutoSize = True
        Me.lblIdInmobiliario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdInmobiliario.Location = New System.Drawing.Point(40, 101)
        Me.lblIdInmobiliario.Name = "lblIdInmobiliario"
        Me.lblIdInmobiliario.Size = New System.Drawing.Size(106, 20)
        Me.lblIdInmobiliario.TabIndex = 12
        Me.lblIdInmobiliario.Text = "IDInmobiliario"
        '
        'cbIdInmobiliario
        '
        Me.cbIdInmobiliario.FormattingEnabled = True
        Me.cbIdInmobiliario.Location = New System.Drawing.Point(198, 100)
        Me.cbIdInmobiliario.Name = "cbIdInmobiliario"
        Me.cbIdInmobiliario.Size = New System.Drawing.Size(39, 21)
        Me.cbIdInmobiliario.TabIndex = 11
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(550, 177)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(222, 44)
        Me.btnEliminarCliente.TabIndex = 14
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        '
        'btnAñadirCliente
        '
        Me.btnAñadirCliente.Location = New System.Drawing.Point(550, 66)
        Me.btnAñadirCliente.Name = "btnAñadirCliente"
        Me.btnAñadirCliente.Size = New System.Drawing.Size(222, 44)
        Me.btnAñadirCliente.TabIndex = 13
        Me.btnAñadirCliente.Text = "Añadir"
        Me.btnAñadirCliente.UseVisualStyleBackColor = True
        '
        'Llaves
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnAñadirCliente)
        Me.Controls.Add(Me.lblIdInmobiliario)
        Me.Controls.Add(Me.cbIdInmobiliario)
        Me.Controls.Add(Me.lblILave)
        Me.Controls.Add(Me.cbIdLave)
        Me.Controls.Add(Me.Funcionalidad)
        Me.Name = "Llaves"
        Me.Text = "Llaves"
        Me.Funcionalidad.ResumeLayout(False)
        Me.Funcionalidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Funcionalidad As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents lblILave As Label
    Friend WithEvents cbIdLave As ComboBox
    Friend WithEvents lblIdInmobiliario As Label
    Friend WithEvents cbIdInmobiliario As ComboBox
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnAñadirCliente As Button
End Class
