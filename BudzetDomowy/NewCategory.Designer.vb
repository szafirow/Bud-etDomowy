<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewCategory
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCategory))
        Me.TextBoxCategory = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBoxCategory
        '
        Me.TextBoxCategory.Location = New System.Drawing.Point(31, 49)
        Me.TextBoxCategory.Name = "TextBoxCategory"
        Me.TextBoxCategory.Size = New System.Drawing.Size(171, 26)
        Me.TextBoxCategory.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zatwierdź"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nazwa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Typ"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(31, 103)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 28)
        Me.ComboBox1.TabIndex = 7
        '
        'NewCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(224, 190)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxCategory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewCategory"
        Me.Text = "NewCategory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
