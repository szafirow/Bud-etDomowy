Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class NewCategory

    Dim id As Integer
    Dim login As String
    Dim connection As New SqlConnection(DB.connectionString)
    Private ef As CategoryForm

    Public Sub New(ByRef f As CategoryForm, id As Integer, login As String)
        Me.ef = f
        Me.id = id
        Me.login = login
        InitializeComponent()
    End Sub

    Private Sub NewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'uzupelnienie comoboxa typami
        connection.Open()
        Using cmd As SqlCommand = New SqlCommand("select * from type", connection)
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

        If (String.IsNullOrEmpty(TextBoxCategory.Text)) Then
            MessageBox.Show("Pole Kategoria jest nie wypelnione!", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim cmd As New SqlCommand

            Dim name_val As String = TextBoxCategory.Text
            Dim type_val As Integer = Int32.Parse((ComboBox1.SelectedValue.ToString()))
            Dim user_val As Integer = Me.id


            Dim D As String
            D = MsgBox("Czy jesteś pewny że chcesz dodać kategorie do bazy?", vbYesNo + vbQuestion, "Pytanie")
            If D = vbYes Then
                'Insert
                connection.Open()
                cmd = New SqlCommand("INSERT INTO category (name,users_id,type) VALUES ('" & name_val & "', '" & user_val & "','" & type_val & "' )", connection)
                cmd.ExecuteNonQuery()
                Me.Close()
                MessageBox.Show("Kategoria dodana do bazy. Będzie ona widoczna po wykonaniu aktualizacji!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                connection.Close()


                'aktualizacja danych na pierwszym formie - CategoryForm
                connection.Open()
                Using cmd2 As New SqlCommand("select * from v_category ORDER BY id DESC", connection)
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



        End If




    End Sub


End Class