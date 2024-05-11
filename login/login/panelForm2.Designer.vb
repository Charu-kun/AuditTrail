<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelForm2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ExpensesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Tbx_TimeRecord = New System.Windows.Forms.TextBox()
        Me.Tbx_Expenditure = New System.Windows.Forms.TextBox()
        Me.Tbx_Amount = New System.Windows.Forms.TextBox()
        Me.Tbx_TotalOutward = New System.Windows.Forms.TextBox()
        Me.Tbx_InwardExp = New System.Windows.Forms.TextBox()
        Me.Tbx_RemainingBudget = New System.Windows.Forms.TextBox()
        Me.Btn_Insert = New Guna.UI.WinForms.GunaButton()
        Me.Update = New Guna.UI.WinForms.GunaButton()
        Me.Delete = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Categories = New System.Windows.Forms.ComboBox()
        Me.MoneyFlow = New System.Windows.Forms.ComboBox()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.ExpensesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpensesChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.ExpensesChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ExpensesChart.Legends.Add(Legend1)
        Me.ExpensesChart.Location = New System.Drawing.Point(849, 54)
        Me.ExpensesChart.Name = "ExpensesChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Inward_VS_Outward"
        Me.ExpensesChart.Series.Add(Series1)
        Me.ExpensesChart.Size = New System.Drawing.Size(267, 228)
        Me.ExpensesChart.TabIndex = 3
        Me.ExpensesChart.Text = "Inward_VS_Outward"
        '
        'Tbx_TimeRecord
        '
        Me.Tbx_TimeRecord.Location = New System.Drawing.Point(325, 354)
        Me.Tbx_TimeRecord.Name = "Tbx_TimeRecord"
        Me.Tbx_TimeRecord.ReadOnly = True
        Me.Tbx_TimeRecord.Size = New System.Drawing.Size(176, 20)
        Me.Tbx_TimeRecord.TabIndex = 4
        '
        'Tbx_Expenditure
        '
        Me.Tbx_Expenditure.Location = New System.Drawing.Point(325, 380)
        Me.Tbx_Expenditure.Name = "Tbx_Expenditure"
        Me.Tbx_Expenditure.Size = New System.Drawing.Size(176, 20)
        Me.Tbx_Expenditure.TabIndex = 5
        '
        'Tbx_Amount
        '
        Me.Tbx_Amount.Location = New System.Drawing.Point(325, 416)
        Me.Tbx_Amount.Name = "Tbx_Amount"
        Me.Tbx_Amount.Size = New System.Drawing.Size(176, 20)
        Me.Tbx_Amount.TabIndex = 6
        '
        'Tbx_TotalOutward
        '
        Me.Tbx_TotalOutward.Location = New System.Drawing.Point(554, 354)
        Me.Tbx_TotalOutward.Name = "Tbx_TotalOutward"
        Me.Tbx_TotalOutward.ReadOnly = True
        Me.Tbx_TotalOutward.Size = New System.Drawing.Size(176, 20)
        Me.Tbx_TotalOutward.TabIndex = 7
        '
        'Tbx_InwardExp
        '
        Me.Tbx_InwardExp.Location = New System.Drawing.Point(554, 406)
        Me.Tbx_InwardExp.Name = "Tbx_InwardExp"
        Me.Tbx_InwardExp.ReadOnly = True
        Me.Tbx_InwardExp.Size = New System.Drawing.Size(176, 20)
        Me.Tbx_InwardExp.TabIndex = 8
        '
        'Tbx_RemainingBudget
        '
        Me.Tbx_RemainingBudget.Location = New System.Drawing.Point(554, 457)
        Me.Tbx_RemainingBudget.Name = "Tbx_RemainingBudget"
        Me.Tbx_RemainingBudget.ReadOnly = True
        Me.Tbx_RemainingBudget.Size = New System.Drawing.Size(176, 20)
        Me.Tbx_RemainingBudget.TabIndex = 9
        '
        'Btn_Insert
        '
        Me.Btn_Insert.AnimationHoverSpeed = 0.07!
        Me.Btn_Insert.AnimationSpeed = 0.03!
        Me.Btn_Insert.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Insert.BorderColor = System.Drawing.Color.Black
        Me.Btn_Insert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Insert.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Insert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Insert.ForeColor = System.Drawing.Color.White
        Me.Btn_Insert.Image = Nothing
        Me.Btn_Insert.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Insert.Location = New System.Drawing.Point(815, 354)
        Me.Btn_Insert.Name = "Btn_Insert"
        Me.Btn_Insert.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Insert.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Insert.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Insert.OnHoverImage = Nothing
        Me.Btn_Insert.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Insert.Size = New System.Drawing.Size(160, 42)
        Me.Btn_Insert.TabIndex = 12
        Me.Btn_Insert.Text = "Insert"
        '
        'Update
        '
        Me.Update.AnimationHoverSpeed = 0.07!
        Me.Update.AnimationSpeed = 0.03!
        Me.Update.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update.BorderColor = System.Drawing.Color.Black
        Me.Update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Update.FocusedColor = System.Drawing.Color.Empty
        Me.Update.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Update.ForeColor = System.Drawing.Color.White
        Me.Update.Image = Nothing
        Me.Update.ImageSize = New System.Drawing.Size(20, 20)
        Me.Update.Location = New System.Drawing.Point(815, 406)
        Me.Update.Name = "Update"
        Me.Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Update.OnHoverForeColor = System.Drawing.Color.White
        Me.Update.OnHoverImage = Nothing
        Me.Update.OnPressedColor = System.Drawing.Color.Black
        Me.Update.Size = New System.Drawing.Size(160, 42)
        Me.Update.TabIndex = 13
        Me.Update.Text = "Update"
        '
        'Delete
        '
        Me.Delete.AnimationHoverSpeed = 0.07!
        Me.Delete.AnimationSpeed = 0.03!
        Me.Delete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Delete.BorderColor = System.Drawing.Color.Black
        Me.Delete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Delete.FocusedColor = System.Drawing.Color.Empty
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Delete.ForeColor = System.Drawing.Color.White
        Me.Delete.Image = Nothing
        Me.Delete.ImageSize = New System.Drawing.Size(20, 20)
        Me.Delete.Location = New System.Drawing.Point(815, 457)
        Me.Delete.Name = "Delete"
        Me.Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Delete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Delete.OnHoverForeColor = System.Drawing.Color.White
        Me.Delete.OnHoverImage = Nothing
        Me.Delete.OnPressedColor = System.Drawing.Color.Black
        Me.Delete.Size = New System.Drawing.Size(160, 42)
        Me.Delete.TabIndex = 14
        Me.Delete.Text = "Delete"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(256, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Expenditure"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label2.Location = New System.Drawing.Point(267, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label3.Location = New System.Drawing.Point(551, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total Outward Cash Flow"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(551, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total Inward Cash Flow"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(559, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Remaining Balance"
        '
        'Categories
        '
        Me.Categories.FormattingEnabled = True
        Me.Categories.Location = New System.Drawing.Point(325, 456)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(121, 21)
        Me.Categories.TabIndex = 21
        Me.Categories.Text = "Categories"
        '
        'MoneyFlow
        '
        Me.MoneyFlow.FormattingEnabled = True
        Me.MoneyFlow.Location = New System.Drawing.Point(325, 483)
        Me.MoneyFlow.Name = "MoneyFlow"
        Me.MoneyFlow.Size = New System.Drawing.Size(121, 21)
        Me.MoneyFlow.TabIndex = 22
        Me.MoneyFlow.Text = "Money Flow"
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GunaDataGridView1.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(325, 54)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(496, 240)
        Me.GunaDataGridView1.TabIndex = 2
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 21
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'panelForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 620)
        Me.Controls.Add(Me.MoneyFlow)
        Me.Controls.Add(Me.Categories)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Btn_Insert)
        Me.Controls.Add(Me.Tbx_RemainingBudget)
        Me.Controls.Add(Me.Tbx_InwardExp)
        Me.Controls.Add(Me.Tbx_TotalOutward)
        Me.Controls.Add(Me.Tbx_Amount)
        Me.Controls.Add(Me.Tbx_Expenditure)
        Me.Controls.Add(Me.Tbx_TimeRecord)
        Me.Controls.Add(Me.ExpensesChart)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Name = "panelForm2"
        Me.Text = "Panel3"
        CType(Me.ExpensesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExpensesChart As DataVisualization.Charting.Chart
    Friend WithEvents Tbx_TimeRecord As TextBox
    Friend WithEvents Tbx_Expenditure As TextBox
    Friend WithEvents Tbx_Amount As TextBox
    Friend WithEvents Tbx_TotalOutward As TextBox
    Friend WithEvents Tbx_InwardExp As TextBox
    Friend WithEvents Tbx_RemainingBudget As TextBox
    Friend WithEvents Btn_Insert As Guna.UI.WinForms.GunaButton
    Friend WithEvents Update As Guna.UI.WinForms.GunaButton
    Friend WithEvents Delete As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Categories As ComboBox
    Friend WithEvents MoneyFlow As ComboBox
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
End Class
