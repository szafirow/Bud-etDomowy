<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewIncomes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewIncomes))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Kategoria"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(16, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(196, 28)
        Me.ComboBox1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Kwota"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(16, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 26)
        Me.DateTimePicker1.TabIndex = 10
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(16, 101)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(196, 26)
        Me.TextBoxAmount.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 31)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Zatwierdź"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewIncomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(224, 252)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewIncomes"
        Me.Text = "NewIncome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
