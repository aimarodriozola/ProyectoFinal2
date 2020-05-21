<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicioSesion
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
        Me.lblOdriozola = New System.Windows.Forms.Label()
        Me.lblUsuarioInicio = New System.Windows.Forms.Label()
        Me.tbUsuarioInicio = New System.Windows.Forms.TextBox()
        Me.lblContraseñaInicio = New System.Windows.Forms.Label()
        Me.tbContraseñaInicio = New System.Windows.Forms.TextBox()
        Me.OficioInicio = New System.Windows.Forms.Label()
        Me.cbOficioInicio = New System.Windows.Forms.ComboBox()
        Me.btnAceptarInicio = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOdriozola
        '
        Me.lblOdriozola.AccessibleName = "lblOdriozola"
        Me.lblOdriozola.AutoSize = True
        Me.lblOdriozola.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOdriozola.Location = New System.Drawing.Point(256, 9)
        Me.lblOdriozola.Name = "lblOdriozola"
        Me.lblOdriozola.Size = New System.Drawing.Size(316, 42)
        Me.lblOdriozola.TabIndex = 0
        Me.lblOdriozola.Text = "ODRIOZOLA S.L"
        Me.lblOdriozola.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUsuarioInicio
        '
        Me.lblUsuarioInicio.AutoSize = True
        Me.lblUsuarioInicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioInicio.Location = New System.Drawing.Point(258, 101)
        Me.lblUsuarioInicio.Name = "lblUsuarioInicio"
        Me.lblUsuarioInicio.Size = New System.Drawing.Size(78, 25)
        Me.lblUsuarioInicio.TabIndex = 1
        Me.lblUsuarioInicio.Text = "Usuario:"
        '
        'tbUsuarioInicio
        '
        Me.tbUsuarioInicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsuarioInicio.Location = New System.Drawing.Point(383, 101)
        Me.tbUsuarioInicio.Name = "tbUsuarioInicio"
        Me.tbUsuarioInicio.Size = New System.Drawing.Size(201, 32)
        Me.tbUsuarioInicio.TabIndex = 2
        '
        'lblContraseñaInicio
        '
        Me.lblContraseñaInicio.AutoSize = True
        Me.lblContraseñaInicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseñaInicio.Location = New System.Drawing.Point(258, 179)
        Me.lblContraseñaInicio.Name = "lblContraseñaInicio"
        Me.lblContraseñaInicio.Size = New System.Drawing.Size(109, 25)
        Me.lblContraseñaInicio.TabIndex = 3
        Me.lblContraseñaInicio.Text = "Contraseña:"
        '
        'tbContraseñaInicio
        '
        Me.tbContraseñaInicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContraseñaInicio.Location = New System.Drawing.Point(383, 179)
        Me.tbContraseñaInicio.Name = "tbContraseñaInicio"
        Me.tbContraseñaInicio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContraseñaInicio.Size = New System.Drawing.Size(201, 32)
        Me.tbContraseñaInicio.TabIndex = 4
        '
        'OficioInicio
        '
        Me.OficioInicio.AutoSize = True
        Me.OficioInicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OficioInicio.Location = New System.Drawing.Point(258, 260)
        Me.OficioInicio.Name = "OficioInicio"
        Me.OficioInicio.Size = New System.Drawing.Size(62, 25)
        Me.OficioInicio.TabIndex = 5
        Me.OficioInicio.Text = "Oficio:"
        '
        'cbOficioInicio
        '
        Me.cbOficioInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOficioInicio.FormattingEnabled = True
        Me.cbOficioInicio.Location = New System.Drawing.Point(380, 262)
        Me.cbOficioInicio.Name = "cbOficioInicio"
        Me.cbOficioInicio.Size = New System.Drawing.Size(214, 33)
        Me.cbOficioInicio.TabIndex = 6
        '
        'btnAceptarInicio
        '
        Me.btnAceptarInicio.Enabled = False
        Me.btnAceptarInicio.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarInicio.Location = New System.Drawing.Point(179, 354)
        Me.btnAceptarInicio.Name = "btnAceptarInicio"
        Me.btnAceptarInicio.Size = New System.Drawing.Size(208, 47)
        Me.btnAceptarInicio.TabIndex = 7
        Me.btnAceptarInicio.Text = "Aceptar"
        Me.btnAceptarInicio.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(490, 354)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(208, 47)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptarInicio)
        Me.Controls.Add(Me.cbOficioInicio)
        Me.Controls.Add(Me.OficioInicio)
        Me.Controls.Add(Me.tbContraseñaInicio)
        Me.Controls.Add(Me.lblContraseñaInicio)
        Me.Controls.Add(Me.tbUsuarioInicio)
        Me.Controls.Add(Me.lblUsuarioInicio)
        Me.Controls.Add(Me.lblOdriozola)
        Me.Name = "FormInicioSesion"
        Me.Text = "Inicio Sesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOdriozola As Label
    Friend WithEvents lblUsuarioInicio As Label
    Friend WithEvents tbUsuarioInicio As TextBox
    Friend WithEvents lblContraseñaInicio As Label
    Friend WithEvents tbContraseñaInicio As TextBox
    Friend WithEvents OficioInicio As Label
    Friend WithEvents cbOficioInicio As ComboBox
    Friend WithEvents btnAceptarInicio As Button
    Friend WithEvents btnCancelar As Button
End Class
