<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.NotifyMainForm = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(48, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 224)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Wydatki"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(48, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(301, 224)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Przychody"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(390, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(301, 224)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Statystyki"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(390, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(301, 224)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Kategorie"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'LabelLogout
        '
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLogout.Font = New System.Drawing.Font("Envy Code R", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelLogout.ForeColor = System.Drawing.Color.Navy
        Me.LabelLogout.Location = New System.Drawing.Point(617, 10)
        Me.LabelLogout.Name = "LabelLogout"
        Me.LabelLogout.Size = New System.Drawing.Size(74, 21)
        Me.LabelLogout.TabIndex = 5
        Me.LabelLogout.Text = "WYLOGUJ"
        '
        'NotifyMainForm
        '
        Me.NotifyMainForm.Icon = CType(resources.GetObject("NotifyMainForm.Icon"), System.Drawing.Icon)
        Me.NotifyMainForm.Text = "MainForm"
        Me.NotifyMainForm.Visible = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(742, 556)
        Me.Controls.Add(Me.LabelLogout)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents LabelLogout As Label
    Friend WithEvents NotifyMainForm As NotifyIcon
End Class
