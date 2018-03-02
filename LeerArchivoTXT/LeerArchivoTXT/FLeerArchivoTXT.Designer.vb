<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FLeerArchivoTXT
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTPulsar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LArchivotexto = New System.Windows.Forms.ListBox()
        Me.TXTArchivotexto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTPulsar
        '
        Me.BTPulsar.Location = New System.Drawing.Point(21, 25)
        Me.BTPulsar.Name = "BTPulsar"
        Me.BTPulsar.Size = New System.Drawing.Size(187, 23)
        Me.BTPulsar.TabIndex = 0
        Me.BTPulsar.Text = "Pulse para seleccionar archivo"
        Me.BTPulsar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        '
        'LArchivotexto
        '
        Me.LArchivotexto.FormattingEnabled = True
        Me.LArchivotexto.HorizontalScrollbar = True
        Me.LArchivotexto.Location = New System.Drawing.Point(331, 87)
        Me.LArchivotexto.Name = "LArchivotexto"
        Me.LArchivotexto.Size = New System.Drawing.Size(289, 303)
        Me.LArchivotexto.TabIndex = 2
        '
        'TXTArchivotexto
        '
        Me.TXTArchivotexto.Location = New System.Drawing.Point(21, 87)
        Me.TXTArchivotexto.Multiline = True
        Me.TXTArchivotexto.Name = "TXTArchivotexto"
        Me.TXTArchivotexto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTArchivotexto.Size = New System.Drawing.Size(275, 303)
        Me.TXTArchivotexto.TabIndex = 3
        '
        'FLeerArchivoTXT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 407)
        Me.Controls.Add(Me.TXTArchivotexto)
        Me.Controls.Add(Me.LArchivotexto)
        Me.Controls.Add(Me.BTPulsar)
        Me.Name = "FLeerArchivoTXT"
        Me.Text = "Leer archivo de texto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTPulsar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LArchivotexto As ListBox
    Friend WithEvents TXTArchivotexto As TextBox
End Class
