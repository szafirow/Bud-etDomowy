Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class NewIncomes

    Dim id As Integer
    Dim login As String
    Dim connection As New SqlConnection(DB.connectionString)
    Private ef As IncomesForm

    Public Sub New(ByRef f As IncomesForm, id As Integer, login As String)
        Me.ef = f
        Me.id = id
        Me.login = login
        InitializeComponent()
    End Sub

    Private Sub NewIncomes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'uzupelnienie comoboxa kategoriami
        connection.Open()
        Using cmd As SqlCommand = New SqlCommand("select * from category where type = 2", connection)
            Dim rs As SqlDataReader = cmd.ExecuteReader
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

            Dim query As String
            Dim cmd As New SqlCommand


            Dim date_val As String = DateTimePicker1.Value.ToShortDateString
            Dim amount_val As Decimal = TextBoxAmount.Text
            Dim category_val As Integer = Int32.Parse((ComboBox1.SelectedValue.ToString()))
            Dim user_val As Integer = Me.id


            Dim D As String
            D = MsgBox("Czy jestes pewny że chcesz dodać przychód o podanych parametrach do bazy?", vbYesNo + vbQuestion, "Pytanie")
            If D = vbYes Then
                'Insert
                connection.Open()
                query = "INSERT INTO incomes (date,amount,category_id,users_id) VALUES ('" & date_val & "','" & amount_val & "','" & category_val & "','" & user_val & "')"
                cmd = New SqlCommand(query, connection)
                cmd.ExecuteNonQuery()
                Me.Close()
                MessageBox.Show("Przychód dodany do bazy. Będzie on widoczny po wykonaniu aktualizacji!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                connection.Close()


                'aktualizacja danych na pierwszym formie - ExpensesForm
                connection.Open()
                Using cmd2 As New SqlCommand("select * from v_incomes ORDER BY id DESC", connection)
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