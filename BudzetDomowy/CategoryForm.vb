Imports System.Data.SqlClient

Public Class CategoryForm

    Dim id As Integer
    Dim login As String
    Dim connection As New SqlConnection(DB.connectionString)

    Public Sub New(id As Integer, login As String)
        Me.id = id
        Me.login = login
        InitializeComponent()
    End Sub

    Private Sub CategoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Zalogowany: " & Me.login & " (" & Me.id & ")"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToAddRows = False

        connection.Open()
        Dim cmd As New SqlCommand("select * from v_category ORDER BY id DESC", connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table.DefaultView

        'If table.Rows.Count() = 0 Then
        '    MessageBox.Show("Brak danych!")
        'End If
        connection.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NotifyCategoryForm.Dispose()
        Me.Hide()
        Dim frm As New MainForm(Me.id, Me.login)
        frm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New NewCategory(Me, Me.id, Me.login)
        frm.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim category_id As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

        Dim D As String
        D = MsgBox("Czy jestes pewny że chcesz usunąć tą kategorie?", vbYesNo + vbQuestion, "Pytanie")
        If D = vbYes Then
            'Delete
            connection.Open()
            Using cmd = New SqlCommand("DELETE FROM category WHERE id = '" & category_id & "' ", connection)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
            MessageBox.Show("Kategoria została usunięta. Lista zostanie uaktualniona po odświeżeniu!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'aktualizacja danych na pierwszym formie - ExpensesForm
            connection.Open()
            Using cmd2 As New SqlCommand("select * from v_category ORDER BY id DESC", connection)
                Dim adapter As New SqlDataAdapter(cmd2)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table.DefaultView

                'If table.Rows.Count() = 0 Then
                '    MessageBox.Show("Brak danych!")
                'End If
                connection.Close()
            End Using

        Else
            Exit Sub
        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim category_id As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim name_val As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Dim type_val As String = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()



        Dim frm As New UpdateCategory(Me, Me.id, Me.login, category_id, name_val, type_val)
        frm.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        connection.Open()
        Dim cmd As New SqlCommand("select * from v_category ORDER BY id DESC", connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table.DefaultView

        'If table.Rows.Count() = 0 Then
        '    MessageBox.Show("Brak danych!")
        'End If
        connection.Close()
    End Sub

    Private Sub LabelLogout_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Finalize()
        NotifyCategoryForm.Dispose()
        MessageBox.Show("Zostałeś wylogowany!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'wlaczenie mozliwosci ponowenego zalogownia
        Dim frm As New LoginForm()
        frm.Show()
    End Sub



    'powiadomienia po najechaniu na przyciski z nawigacji
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        ToolTip1.Show("Cofnij", PictureBox4, 2000)
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        ToolTip1.Show("Nowy rekord", PictureBox1, 2000)
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        ToolTip1.Show("Edytuj", PictureBox2, 2000)
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        ToolTip1.Show("Usuń", PictureBox3, 2000)
    End Sub
    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        ToolTip1.Show("Odśwież dane", PictureBox5, 2000)
    End Sub



    'Ikona w tray
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                NotifyCategoryForm.Visible = True
                NotifyCategoryForm.ShowBalloonTip(1, "BudzetDomowy", "Uruchomione ...", ToolTipIcon.Info)
                ShowInTaskbar = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyCategoryForm.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyCategoryForm.Visible = False
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