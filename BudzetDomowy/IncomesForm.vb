Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel



Public Class IncomesForm

    Dim id As Integer
    Dim login As String
    Dim connection As New SqlConnection(DB.connectionString)

    Public Sub New(id As Integer, login As String)
        Me.id = id
        Me.login = login
        InitializeComponent()
    End Sub

    Private Sub IncomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Zalogowany: " & Me.login & " (" & Me.id & ")"
        DataGridView1.ReadOnly = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToAddRows = False

        connection.Open()
        Dim cmd As New SqlCommand("select * from v_incomes ORDER BY id DESC", connection)
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
        NotifyIncomesForm.Dispose()
        Me.Hide()
        Dim frm As New MainForm(Me.id, Me.login)
        frm.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        connection.Open()
        Dim cmd As New SqlCommand("select * from v_incomes ORDER BY id DESC", connection)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table.DefaultView

        'If table.Rows.Count() = 0 Then
        '    MessageBox.Show("Brak danych!")
        'End If
        connection.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm As New NewIncomes(Me, Me.id, Me.login)
        frm.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim incomes_id As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
        Dim date_val As String = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Dim amount As Decimal = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
        Dim category As String = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
        Dim person As String = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()

        Dim frm As New UpdateIncomes(Me, Me.id, Me.login, incomes_id, date_val, amount, category, person)
        frm.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Dim incomes_id As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

        Dim D As String
        D = MsgBox("Czy jestes pewny że chcesz usunąć ten zapis o przychodzie?", vbYesNo + vbQuestion, "Pytanie")
        If D = vbYes Then
            'Delete
            connection.Open()
            Using cmd = New SqlCommand("DELETE FROM incomes WHERE id = '" & incomes_id & "' ", connection)
                cmd.ExecuteNonQuery()
            End Using
            connection.Close()
            MessageBox.Show("Przychód został usunięty. Lista zostanie uaktualniona po odświeżeniu!", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'aktualizacja danych na pierwszym formie - ExpensesForm
            connection.Open()
            Using cmd2 As New SqlCommand("select * from v_incomes ORDER BY id DESC", connection)
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

    Private Sub LabelLogout_Click(sender As Object, e As EventArgs) Handles LabelLogout.Click
        Me.Finalize()
        NotifyIncomesForm.Dispose()
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
    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        ToolTip1.Show("Wygeneruj PDF", PictureBox6, 2000)
    End Sub
    Private Sub PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        ToolTip1.Show("Wygeneruj EXCEL", PictureBox7, 2000)
    End Sub


    'Ikona w tray
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                NotifyIncomesForm.Visible = True
                NotifyIncomesForm.ShowBalloonTip(1, "BudzetDomowy", "Uruchomione ...", ToolTipIcon.Info)
                ShowInTaskbar = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIncomesForm.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyIncomesForm.Visible = False
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

    'pdf
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If MsgBox("Czy na pewno chcesz wygenerować nowy raport przychodów?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Pytanie") = MsgBoxResult.Yes Then

            Dim TitleRAP As String = "Raport przychody"
            Dim Paragraph As New Paragraph ' nowy paragraf
            Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20) ' rozmiar pdf
            PdfFile.AddTitle(TitleRAP) 'tytul dokumentu pdf
            Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(Application.StartupPath + "\raport-przychody - " + Date.Now.ToString("ddMMyyyyHHmmss") + ".pdf", FileMode.Create))
            PdfFile.Open()

            'declaration font type
            Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
            Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

            'insert title into pdf
            Paragraph = New Paragraph(New Chunk(TitleRAP, pTitle))
            Paragraph.Alignment = Element.ALIGN_CENTER
            Paragraph.SpacingAfter = 5.0F

            'set and add page with current settings
            PdfFile.Add(Paragraph)

            'create data into table
            Dim PdfTable As New PdfPTable(DataGridView1.Columns.Count)
            'setting width of table
            PdfTable.TotalWidth = 500.0F
            PdfTable.LockedWidth = True

            Dim widths(0 To DataGridView1.Columns.Count - 1) As Single
            For i As Integer = 0 To DataGridView1.Columns.Count - 1
                widths(i) = 1.0F
            Next
            PdfTable.SetWidths(widths)
            PdfTable.HorizontalAlignment = 0
            PdfTable.SpacingBefore = 5.0F

            'declaration pdf cells
            Dim pdfcell As PdfPCell = New PdfPCell

            'add pdf header
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(Color.Gray)
                PdfTable.AddCell(cell)
            Next

            'add pdf rows
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    PdfTable.AddCell(cell.Value.ToString())
                Next
            Next

            'add pdf table into pdf document
            PdfFile.Add(PdfTable)
            PdfFile.Close() 'close all session
            MessageBox.Show("Raport został wygenerowany! Znajdziesz go w folderze aplikacji.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        If MsgBox("Czy na pewno chcesz wygenerować nowy raport przychodów?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Pytanie") = MsgBoxResult.Yes Then

            Dim xlApp As Excel.Application = New Excel.Application
            Dim misValue As Object = System.Reflection.Missing.Value
        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Add(misValue)
        Dim xlWorksheet As Excel.Worksheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

        Dim i As Integer
        Dim j As Integer

        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs(Application.StartupPath + "\raport-przychody - " + Date.Now.ToString("ddMMyyyyHHmmss") + ".xlsx")
        xlApp.Quit()

        releseObject(xlApp)
        releseObject(xlWorkSheet)
        releseObject(xlWorkSheet)
            'System.Diagnostics.Process.Start(Application.StartupPath + "\raport-przychody - " + Date.Now.ToString("ddMMyyyyHHmmss") + ".xlsx")

            MessageBox.Show("Raport został wygenerowany! Znajdziesz go w folderze aplikacji.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub releseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub


End Class