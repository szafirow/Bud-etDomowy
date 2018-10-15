<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.NotifyLoginForm = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LabelLastModify = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(176, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Zaloguj"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxLogin.Location = New System.Drawing.Point(176, 181)
        Me.TextBoxLogin.Multiline = True
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(437, 56)
        Me.TextBoxLogin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(47, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 46)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hasło"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.SystemColors.Control
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TextBoxPassword.Location = New System.Drawing.Point(176, 246)
        Me.TextBoxPassword.Multiline = True
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(437, 56)
        Me.TextBoxPassword.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(402, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(211, 46)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Zamknij"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(176, 317)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 24)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Odkryj hasło"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BudzetDomowy.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(260, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(323, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Walutą domyślną dla programu jest PLN  !!!"
        '
        'Timer1
        '
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelTime.Location = New System.Drawing.Point(547, 9)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(49, 20)
        Me.LabelTime.TabIndex = 10
        Me.LabelTime.Text = "00:00"
        Me.LabelTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NotifyLoginForm
        '
        Me.NotifyLoginForm.Icon = CType(resources.GetObject("NotifyLoginForm.Icon"), System.Drawing.Icon)
        Me.NotifyLoginForm.Text = "Logowanie"
        Me.NotifyLoginForm.Visible = True
        '
        'LabelLastModify
        '
        Me.LabelLastModify.AutoSize = True
        Me.LabelLastModify.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelLastModify.ForeColor = System.Drawing.SystemColors.Info
        Me.LabelLastModify.Location = New System.Drawing.Point(31, 413)
        Me.LabelLastModify.Name = "LabelLastModify"
        Me.LabelLastModify.Size = New System.Drawing.Size(0, 20)
        Me.LabelLastModify.TabIndex = 11
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 511)
        Me.Controls.Add(Me.LabelLastModify)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.Text = "BD - Logowanie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTime As Label
    Friend WithEvents NotifyLoginForm As NotifyIcon
    Friend WithEvents LabelLastModify As Label
End Class
