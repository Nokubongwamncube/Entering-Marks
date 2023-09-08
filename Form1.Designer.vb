<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(460, 257)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(131, 42)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Result"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Marks"
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(500, 151)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(152, 26)
        Me.txtMark.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMark As TextBox
End Class
