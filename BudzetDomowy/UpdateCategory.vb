Imports System.Data.SqlClient

Public Class UpdateCategory

    Dim id As Integer
    Dim login As String
    Dim category_id As Integer
    Dim name_val As String
    Dim type_val As String
    Dim connection As New SqlConnection(DB.connectionString)
    Private ef As CategoryForm

    Public Sub New(ByRef f As CategoryForm, id As Integer, login As String, category_id As Integer, name_val As String, type_val As String)
        Me.ef = f
        Me.id = id
        Me.login = login
        Me.category_id = category_id
        Me.name_val = name_val
        Me.type_val = type_val

        InitializeComponent()
    End Sub

    Private Sub UpdateCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCategory.Text = Me.name_val


        'pobranie typu do update
        connection.Open()
        Using cmd As SqlCommand = New SqlCommand("SELECT id, name FROM type t WHERE t.name = '" & Me.type_val & "' UNION ALL SELECT id, name FROM type WHERE id NOT IN (SELECT id FROM type t WHERE t.name = '" & Me.type_val & "') ", connection)
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

        If (String.IsNullOrEmpty(TextBoxCategory.Text)) Then
            MessageBox.Show("Pole Kategoria jest nie wypelnione!", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else


            Dim D As String
            D = MsgBox("Czy jestes pewny że chcesz wykonać tą aktualizację?", vbYesNo + vbQuestion, "Pytanie")
            If D = vbYes Then
                'Update
                connection.Open()
                Using cmd = New SqlCommand("UPDATE category SET name = '" & TextBoxCategory.Text & "', type= '" & ComboBox1.SelectedValue & "' WHERE id = '" & Me.category_id & "' ", connection)
                    cmd.ExecuteNonQuery()
                End Using
                connection.Close()
                Me.Close()
                MessageBox.Show("Kategoria została zaktualizowana. Zmiana będzie widoczna po wykonaniu aktualizacji!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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