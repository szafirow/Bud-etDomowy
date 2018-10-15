<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsForm
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticsForm))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelLogout = New System.Windows.Forms.Label()
        Me.NotifyStatisticsForm = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones
        Series1.ChartArea = "ChartArea1"
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(853, 366)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(72, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(870, 434)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart3)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(862, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ogólne"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart3
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea2)
        Me.Chart3.Location = New System.Drawing.Point(457, 235)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Name = "Series1"
        Me.Chart3.Series.Add(Series2)
        Me.Chart3.Size = New System.Drawing.Size(303, 124)
        Me.Chart3.TabIndex = 14
        Me.Chart3.Text = "Chart3"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(457, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(303, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(453, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(453, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(453, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(862, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Wydatki w podziale na kategorie"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Chart2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(862, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Przychody w podziale na kategorie"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea3)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(5, 17)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series3.ChartArea = "ChartArea1"
        Series3.IsVisibleInLegend = False
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(853, 366)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "Chart2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'LabelLogout
        '
        Me.LabelLogout.AutoSize = True
        Me.LabelLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelLogout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelLogout.Font = New System.Drawing.Font("Envy Code R", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelLogout.ForeColor = System.Drawing.Color.Navy
        Me.LabelLogout.Location = New System.Drawing.Point(868, 10)
        Me.LabelLogout.Name = "LabelLogout"
        Me.LabelLogout.Size = New System.Drawing.Size(74, 21)
        Me.LabelLogout.TabIndex = 16
        Me.LabelLogout.Text = "WYLOGUJ"
        '
        'NotifyStatisticsForm
        '
        Me.NotifyStatisticsForm.Icon = CType(resources.GetObject("NotifyStatisticsForm.Icon"), System.Drawing.Icon)
        Me.NotifyStatisticsForm.Text = "StatisticsForm"
        Me.NotifyStatisticsForm.Visible = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.BudzetDomowy.My.Resources.Resources.back
        Me.PictureBox4.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(54, 51)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'StatisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(954, 482)
        Me.Controls.Add(Me.LabelLogout)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StatisticsForm"
        Me.Text = "StatisticsForm"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents LabelLogout As Label
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents NotifyStatisticsForm As NotifyIcon
    Friend WithEvents ToolTip1 As ToolTip
End Class
