Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UpdateExpenses

    Dim id As Integer
    Dim login As String
    Dim expenses_id As Integer
    Dim date_val As String
    Dim amount As Decimal
    Dim category As String
    Dim person As String
    Dim connection As New SqlConnection(DB.connectionString)
    Private ef As ExpensesForm

    Public Sub New(ByRef f As ExpensesForm, id As Integer, login As String, expenses_id As Integer, date_val As String, amount As Decimal, category As String, person As String)
        Me.ef = f
        Me.id = id
        Me.login = login
        Me.expenses_id = expenses_id
        Me.date_val = date_val
        Me.amount = amount
        Me.category = category
        Me.person = person

        InitializeComponent()
    End Sub

    Private Sub UpdateExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DateTimePicker1.Value = Me.date_val
        TextBoxAmount.Text = Me.amount

        'pobranie kategori do update
        connection.Open()
        Using cmd As SqlCommand = New SqlCommand("SELECT id, name FROM category c WHERE c.type = '1' and c.name = '" & Me.category & "' UNION ALL SELECT id, name FROM category WHERE type = '1' and id NOT IN (SELECT id FROM category c WHERE c.type = '1' and c.name = '" & Me.category & "') ", connection)
            Dim rs As SqlDataReader
            rs = cmd.ExecuteReader
            Dim dt As DataTable = New DataTable
            dt.Load(rs)
            ComboBox1.ValueMember = "id"
            ComboBox1.DisplayMember = "name"
            ComboBox1.DataSource = dt
        End Using
        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Regex.IsMatch(TextBoxAmount.Text, "^[0-9 ]+$") Then

            Dim D As String
            D = MsgBox("Czy jestes pewny że chcesz wykonać tą aktualizację?", vbYesNo + vbQuestion, "Pytanie")
            If D = vbYes Then
                'Update
                connection.Open()
                Using cmd = New SqlCommand("UPDATE expenses SET category_id = '" & ComboBox1.SelectedValue & "', date = '" & DateTimePicker1.Value & "', amount = '" & TextBoxAmount.Text & "' WHERE id = '" & Me.expenses_id & "' ", connection)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
                Me.Close()
                MessageBox.Show("Wydatek został zaktualizowany. Zmiana będzie widoczna po wykonaniu aktualizacji!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                'aktualizacja danych na pierwszym formie - ExpensesForm
                connection.Open()
                Using cmd2 As New SqlCommand("select * from v_expenses ORDER BY id DESC", connection)
                    Dim adapter As New SqlDataAdapter(cmd2)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    ef.DataGridView1.DataSource = table.DefaultView

                    If table.Rows.Count() <= 0 Then
                        MessageBox.Show("Sa takie dane!")
                    ElseIf table.Rows.Count() = 0 Then
                        MessageBox.Show("Brak danych!")
                    End If
                    connection.Close()
                End Using


            Else
                Exit Sub
            End If

        ElseIf (String.IsNullOrEmpty(TextBoxAmount.Text)) Then
            MessageBox.Show("Pole Kwota jest nie wypelnione!", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            MessageBox.Show("Pole kwota nie jest liczba!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

End Class