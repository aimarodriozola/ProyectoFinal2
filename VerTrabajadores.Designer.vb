<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerTrabajadores
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
        Me.lblVerTrabajadores = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.ListBox()
        Me.lbOficio = New System.Windows.Forms.ListBox()
        Me.btnVolverTrabajadoresOficina = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVerTrabajadores
        '
        Me.lblVerTrabajadores.AutoSize = True
        Me.lblVerTrabajadores.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerTrabajadores.Location = New System.Drawing.Point(329, 23)
        Me.lblVerTrabajadores.Name = "lblVerTrabajadores"
        Me.lblVerTrabajadores.Size = New System.Drawing.Size(199, 43)
        Me.lblVerTrabajadores.TabIndex = 0
        Me.lblVerTrabajadores.Text = "Trabajadores"
        '
        'lbNombre
        '
        Me.lbNombre.FormattingEnabled = True
        Me.lbNombre.Location = New System.Drawing.Point(58, 107)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(322, 186)
        Me.lbNombre.TabIndex = 1
        '
        'lbOficio
        '
        Me.lbOficio.FormattingEnabled = True
        Me.lbOficio.Location = New System.Drawing.Point(403, 107)
        Me.lbOficio.Name = "lbOficio"
        Me.lbOficio.Size = New System.Drawing.Size(322, 186)
        Me.lbOficio.TabIndex = 2
        '
        'btnVolverTrabajadoresOficina
        '
        Me.btnVolverTrabajadoresOficina.Location = New System.Drawing.Point(296, 328)
        Me.btnVolverTrabajadoresOficina.Name = "btnVolverTrabajadoresOficina"
        Me.btnVolverTrabajadoresOficina.Size = New System.Drawing.Size(214, 65)
        Me.btnVolverTrabajadoresOficina.TabIndex = 3
        Me.btnVolverTrabajadoresOficina.Text = "Volver"
        Me.btnVolverTrabajadoresOficina.UseVisualStyleBackColor = True
        '
        'VerTrabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVolverTrabajadoresOficina)
        Me.Controls.Add(Me.lbOficio)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lblVerTrabajadores)
        Me.Name = "VerTrabajadores"
        Me.Text = "VerTrabajadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVerTrabajadores As Label
    Friend WithEvents lbNombre As ListBox
    Friend WithEvents lbOficio As ListBox
    Friend WithEvents btnVolverTrabajadoresOficina As Button
End Class
