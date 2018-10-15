Public Class MainForm

    Dim id As Integer
    Dim login As String


    Public Sub New(id As Integer, login As String)
        Me.id = id
        Me.login = login
        InitializeComponent()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Zalogowany: " & Me.login & " (" & Me.id & ")"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Przechodzimy na zarzadzanie wydatkami
        Dim frm As New ExpensesForm(Me.id, Me.login)
        Me.Hide()
        frm.Show()
        NotifyMainForm.Dispose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Przechodzimy na zarzadzanie kategoriami
        Dim frm As New CategoryForm(Me.id, Me.login)
        Me.Hide()
        frm.Show()
        NotifyMainForm.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Przechodzimy na zarzadzanie przychodami
        Dim frm As New IncomesForm(Me.id, Me.login)
        Me.Hide()
        frm.Show()
        NotifyMainForm.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Przechodzimy na statystyki
        Dim frm As New StatisticsForm(Me.id, Me.login)
        Me.Hide()
        frm.Show()
        NotifyMainForm.Dispose()
    End Sub

    Private Sub LabelLogout_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Finalize()
        NotifyMainForm.Dispose()
        MessageBox.Show("Zostałeś wylogowany!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'wlaczenie mozliwosci ponowenego zalogownia
        Dim frm As New LoginForm()
        frm.Show()
    End Sub


    'Ikona w tray
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Try
            If Me.WindowState = FormWindowState.Minimized Then
                GC.Collect()
                Me.Visible = False
                NotifyMainForm.Visible = True
                NotifyMainForm.ShowBalloonTip(1, "BudzetDomowy", "Uruchomione ...", ToolTipIcon.Info)
                ShowInTaskbar = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyMainForm.MouseDoubleClick
        Try
            GC.Collect()
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyMainForm.Visible = False
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