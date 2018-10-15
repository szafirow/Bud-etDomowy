Imports System.Data.SqlClient
Imports System.IO
Imports System.Web


Public Class LoginForm

    Dim connection As New SqlConnection(DB.connectionString)

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' MessageBox.Show(Application.StartupPath & "\last_modify.txt")

        'zaczytywanie pliku ostatnich zmian
        Using reader As New StreamReader(Application.StartupPath & "\last_modify.txt")
            Do Until reader.EndOfStream
                Dim line As String = reader.ReadLine()
                If line.StartsWith("-") Then
                    LabelLastModify.Text = LabelLastModify.Text & line & vbCrLf
                End If
            Loop
        End Using


        NotifyLoginForm.Visible = True
        TextBoxLogin.Select()
        TextBoxPassword.PasswordChar = "*"

        'czas odliczania timera
        timeLeft = 10800
        LabelTime.Text = "Czas na zalogowanie:" & vbNewLine & "00:03:00"
        Timer1.Start()

    End Sub


    Private Sub loginUsers()
        connection.Open()
        Dim cmd As New SqlCommand("select * from users where login = @login and password = @password", connection)

        cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = TextBoxLogin.Text
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        If (String.IsNullOrEmpty(TextBoxLogin.Text) Or String.IsNullOrEmpty(TextBoxPassword.Text)) Then
            MessageBox.Show("Nie uzupełniono wszystkich pól!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxLogin.Clear()
            TextBoxPassword.Clear()
            TextBoxLogin.Select()
        ElseIf table.Rows.Count() <= 0 Then
            MessageBox.Show("Nie ma takiego użytkownika w bazie danych!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxLogin.Clear()
            TextBoxPassword.Clear()
            TextBoxLogin.Select()
        Else

            Dim id As Integer = table.Rows(0).ItemArray(0).ToString()
            Dim login As String = TextBoxLogin.Text
            'Logowanie udane
            Dim frm As New MainForm(id, login)
            frm.Show()
            Me.Hide()
            Timer1.Stop()
            NotifyLoginForm.Dispose()

        End If
        connection.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginUsers()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim D As String
        D = MsgBox("Czy jestes pewny że chcesz wyjść z aplikacji?", vbYesNo + vbQuestion, "Pytanie")
        If D = vbYes Then
            Application.Exit()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If TextBoxPassword.UseSystemPasswordChar = True Then
            'ukryj haslo
            TextBoxPassword.UseSystemPasswordChar = False
        Else
            'pokaz haslo
            TextBoxPassword.UseSystemPasswordChar = True
        End If

    End Sub



    Private timeLeft As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft > 0 Then
            ' Display the new time left
            ' by updating the Time Left label.
            timeLeft -= 1
            LabelTime.Text = "Czas na zalogowanie:" & vbNewLine & GetTime(timeLeft)
        Else
            ' If the user ran out of time, stop the timer, show
            ' a MessageBox, and fill in the answers.
            Timer1.Stop()
            MessageBox.Show("Nie zdarzyles sie zalogować. Spróbuj ponownie kolejnym razem. Żegnaj!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Application.Exit()
        End If
    End Sub

    Public Function GetTime(Time As Integer) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '

        'Seconds'
        Sec = Time Mod 60

        'Minutes'
        Min = ((Time - Sec) / 60) Mod 60

        'Hours'
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60

        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function


    Private Sub TextBoxLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxLogin.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loginUsers()
        End If
    End Sub

    Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            loginUsers()
        End If
    End Sub


    'Ikona w tray
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                NotifyLoginForm.Visible = True
                NotifyLoginForm.ShowBalloonTip(1, "BudzetDomowy", "Uruchomione ...", ToolTipIcon.Info)
                ShowInTaskbar = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyLoginForm.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyLoginForm.Visible = False
            ShowInTaskbar = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'close app
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If MsgBox("Czy jesteś pewny, że chcesz wyjść z aplikacji?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Pytanie") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
