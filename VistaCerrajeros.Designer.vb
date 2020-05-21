<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VistaCerrajeros
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
        Me.lblCerrajeros = New System.Windows.Forms.Label()
        Me.txtTrabajadorCerrajeros = New System.Windows.Forms.TextBox()
        Me.tbFabricaCerrajeros = New System.Windows.Forms.TextBox()
        Me.lbMateriales = New System.Windows.Forms.ListBox()
        Me.lbCantidad = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblCerrajeros
        '
        Me.lblCerrajeros.AutoSize = True
        Me.lblCerrajeros.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrajeros.Location = New System.Drawing.Point(331, 9)
        Me.lblCerrajeros.Name = "lblCerrajeros"
        Me.lblCerrajeros.Size = New System.Drawing.Size(189, 42)
        Me.lblCerrajeros.TabIndex = 0
        Me.lblCerrajeros.Text = "Cerrajeros"
        Me.lblCerrajeros.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTrabajadorCerrajeros
        '
        Me.txtTrabajadorCerrajeros.Location = New System.Drawing.Point(68, 64)
        Me.txtTrabajadorCerrajeros.Name = "txtTrabajadorCerrajeros"
        Me.txtTrabajadorCerrajeros.ReadOnly = True
        Me.txtTrabajadorCerrajeros.Size = New System.Drawing.Size(156, 20)
        Me.txtTrabajadorCerrajeros.TabIndex = 1
        '
        'tbFabricaCerrajeros
        '
        Me.tbFabricaCerrajeros.Location = New System.Drawing.Point(338, 64)
        Me.tbFabricaCerrajeros.Name = "tbFabricaCerrajeros"
        Me.tbFabricaCerrajeros.ReadOnly = True
        Me.tbFabricaCerrajeros.Size = New System.Drawing.Size(271, 20)
        Me.tbFabricaCerrajeros.TabIndex = 2
        '
        'lbMateriales
        '
        Me.lbMateriales.FormattingEnabled = True
        Me.lbMateriales.Location = New System.Drawing.Point(70, 128)
        Me.lbMateriales.Name = "lbMateriales"
        Me.lbMateriales.Size = New System.Drawing.Size(268, 264)
        Me.lbMateriales.TabIndex = 3
        '
        'lbCantidad
        '
        Me.lbCantidad.FormattingEnabled = True
        Me.lbCantidad.Location = New System.Drawing.Point(380, 130)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(99, 264)
        Me.lbCantidad.TabIndex = 4
        '
        'VistaCerrajeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbCantidad)
        Me.Controls.Add(Me.lbMateriales)
        Me.Controls.Add(Me.tbFabricaCerrajeros)
        Me.Controls.Add(Me.txtTrabajadorCerrajeros)
        Me.Controls.Add(Me.lblCerrajeros)
        Me.Name = "VistaCerrajeros"
        Me.Text = "VistaCerrajeros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCerrajeros As Label
    Friend WithEvents txtTrabajadorCerrajeros As TextBox
    Friend WithEvents tbFabricaCerrajeros As TextBox
    Friend WithEvents lbMateriales As ListBox
    Friend WithEvents lbCantidad As ListBox
End Class
