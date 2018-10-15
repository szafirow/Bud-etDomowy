Imports System.Data.SqlClient

Public Class StatisticsForm

    Dim id As Integer
    Dim login As String
    Dim connection As New SqlConnection(DB.connectionString)

    Public Sub New(id As Integer, login As String)
        Me.id = id
        Me.login = login
        InitializeComponent()
    End Sub

    Private Sub StatisticsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Zalogowany: " & Me.login & " (" & Me.id & ")"

        'liczba wszystkich kategorii
        connection.Open()
        Using cmd2 As SqlCommand = New SqlCommand("SELECT COUNT(id) FROM category", connection)
            Dim adapter2 As New SqlDataAdapter(cmd2)
            Dim table2 As New DataTable()
            adapter2.Fill(table2)
            Dim sum_cat_all As Decimal = table2.Rows(0).ItemArray(0).ToString()
            Label2.Text = "Liczba wszystkich kategorii: " & sum_cat_all
        End Using
        connection.Close()

        'liczba kategorii wydatkow
        connection.Open()
        Using cmd3 As SqlCommand = New SqlCommand("SELECT COUNT(id) FROM category WHERE type = 1", connection)
            Dim adapter3 As New SqlDataAdapter(cmd3)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            Dim sum_cat_expenses As Decimal = table3.Rows(0).ItemArray(0).ToString()
            Label3.Text = "Liczba kategorii wydatków: " & sum_cat_expenses
        End Using
        connection.Close()

        'liczba kategorii przychodow
        connection.Open()
        Using cmd4 As SqlCommand = New SqlCommand("SELECT COUNT(id) FROM category WHERE type = 2", connection)
            Dim adapter4 As New SqlDataAdapter(cmd4)
            Dim table4 As New DataTable()
            adapter4.Fill(table4)
            Dim sum_cat_incomes As Decimal = table4.Rows(0).ItemArray(0).ToString()
            Label4.Text = "Liczba kategorii przychodów: " & sum_cat_incomes
        End Using
        connection.Close()

        'największe wydatki w kategorii
        connection.Open()
        Using cmd5 As SqlCommand = New SqlCommand("SELECT TOP 1 c.name as cat_name FROM expenses e INNER JOIN category c ON c.id = e.category_id GROUP BY c.name ORDER BY COUNT(e.id) DESC ", connection)
            Dim adapter5 As New SqlDataAdapter(cmd5)
            Dim table5 As New DataTable()
            adapter5.Fill(table5)
            Dim max_cat_expenses As String = table5.Rows(0).ItemArray(0).ToString()
            Label5.Text = "Największe wydatki w kategorii: " & max_cat_expenses
        End Using
        connection.Close()

        'największe przychody w kategorii
        connection.Open()
        Using cmd6 As SqlCommand = New SqlCommand("SELECT TOP 1 c.name as cat_name FROM incomes i INNER JOIN category c ON c.id = i.category_id GROUP BY c.name ORDER BY COUNT(i.id) DESC ", connection)
            Dim adapter6 As New SqlDataAdapter(cmd6)
            Dim table6 As New DataTable()
            adapter6.Fill(table6)
            Dim max_cat_incomes As String = table6.Rows(0).ItemArray(0).ToString()
            Label6.Text = "Największe przychody w kategorii: " & max_cat_incomes
        End Using
        connection.Close()


        'suma wydatkow
        connection.Open()
        Dim cmd7 As SqlCommand = New SqlCommand("SELECT SUM(amount) FROM expenses", connection)
        Dim adapter7 As New SqlDataAdapter(cmd7)
            Dim table7 As New DataTable()
            adapter7.Fill(table7)
            Dim sum_expenses As Decimal = table7.Rows(0).ItemArray(0).ToString()
        Label7.Text = "Suma wszystkich wydatków: " & sum_expenses
        connection.Close()

        'suma przychodow
        connection.Open()
        Dim cmd8 As SqlCommand = New SqlCommand("SELECT SUM(amount) FROM incomes", connection)
        Dim adapter8 As New SqlDataAdapter(cmd8)
            Dim table8 As New DataTable()
            adapter8.Fill(table8)
            Dim sum_incomes As Decimal = table8.Rows(0).ItemArray(0).ToString()
        Label8.Text = "Suma wszystkich przychdów: " & sum_incomes
        connection.Close()

        'roznica wydatkow i przychodow
        Dim diff As Decimal = -(sum_expenses - sum_incomes)
        Label9.Text = "Różnica wydatków i przychodów: " & diff

        If sum_expenses = sum_incomes Then
            Button1.Text = "Jesteś na zero"
            Button1.BackColor = Color.Blue
            Button1.ForeColor = Color.White
            Label9.ForeColor = Color.Blue

        ElseIf sum_incomes >= sum_expenses Then
            Button1.Text = "Jesteś na plus"
            Button1.BackColor = Color.Green
            Button1.ForeColor = Color.White
            Label9.ForeColor = Color.Green

        ElseIf sum_expenses > sum_incomes Then
            Button1.Text = "Jesteś na minus"
            Button1.BackColor = Color.Red
            Button1.ForeColor = Color.White
            Label9.ForeColor = Color.Red
        End If


        'wykres 1 (chart)- wydatki na kategorie
        connection.Open()
        Dim cmd9 As New SqlCommand("select sum(amount) as sum, c.name as name_cat from expenses e INNER JOIN category c ON c.id = e.category_id GROUP BY c.name", connection)
        Dim adapter9 As New SqlDataAdapter(cmd9)
        Dim table9 As New DataTable()
        adapter9.Fill(table9)
        Chart1.DataSource = table9
        Chart1.ChartAreas("ChartArea1").AxisX.Title = "Kategorie"
        Chart1.ChartAreas("ChartArea1").AxisY.Title = "Kwota"
        Chart1.Series(0).XValueMember = "name_cat"
        Chart1.Series(0).YValueMembers = "sum"
        Chart1.DataBind()
        connection.Close()

        'wykres 2 (chart)- przychody na kategorie
        connection.Open()
        Dim cmd10 As New SqlCommand("select sum(amount) as sum, c.name as name_cat from incomes i INNER JOIN category c ON c.id = i.category_id GROUP BY c.name", connection)
        Dim adapter10 As New SqlDataAdapter(cmd10)
        Dim table10 As New DataTable()
        adapter10.Fill(table10)
        Chart2.DataSource = table10
        Chart2.ChartAreas("ChartArea1").AxisX.Title = "Kategorie"
        Chart2.ChartAreas("ChartArea1").AxisY.Title = "Kwota"
        Chart2.Series(0).XValueMember = "name_cat"
        Chart2.Series(0).YValueMembers = "sum"
        Chart2.DataBind()
        connection.Close()


        'wykres 3 (piechart)- wydatki i przychody
        connection.Open()
        Dim cmd11 As New SqlCommand("SELECT SUM(amount) as sum FROM incomes UNION SELECT SUM(amount) as sum FROM expenses", connection)
        Dim adapter11 As New SqlDataAdapter(cmd11)
        Dim table11 As New DataTable()
        adapter11.Fill(table11)
        Chart3.DataSource = table11
        Chart3.Series(0).YValueMembers = "sum"
        Chart3.DataBind()
        connection.Close()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NotifyStatisticsForm.Dispose()
        Me.Hide()
        Dim frm As New MainForm(Me.id, Me.login)
        frm.Show()
    End Sub

    Private Sub LabelLogout_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Finalize()
        NotifyStatisticsForm.Dispose()
        MessageBox.Show("Zostałeś wylogowany!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'wlaczenie mozliwosci ponowenego zalogownia
        Dim frm As New LoginForm()
        frm.Show()
    End Sub



    'Ikona w tray
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                NotifyStatisticsForm.Visible = True
                NotifyStatisticsForm.ShowBalloonTip(1, "BudzetDomowy", "Uruchomione ...", ToolTipIcon.Info)
                ShowInTaskbar = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyStatisticsForm.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyStatisticsForm.Visible = False
            ShowInTaskbar = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        ToolTip1.Show("Cofnij", PictureBox4, 2000)
    End Sub



End Class