<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelForm1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelForm1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Create_Btn = New Guna.UI.WinForms.GunaButton()
        Me.Btn_Update = New Guna.UI.WinForms.GunaButton()
        Me.Btn_UndoEnd = New Guna.UI.WinForms.GunaButton()
        Me.Btn_EndProject = New Guna.UI.WinForms.GunaButton()
        Me.Btn_Delete = New Guna.UI.WinForms.GunaButton()
        Me.Tbx_ProjCode_Read = New System.Windows.Forms.TextBox()
        Me.Tbx_ProjName_Write = New System.Windows.Forms.TextBox()
        Me.Tbx_ClientName = New System.Windows.Forms.TextBox()
        Me.Tbx_DateEnded = New System.Windows.Forms.TextBox()
        Me.Tbx_Budget = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_Load = New Guna.UI.WinForms.GunaButton()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Create_Btn
        '
        Me.Create_Btn.AnimationHoverSpeed = 0.07!
        Me.Create_Btn.AnimationSpeed = 0.03!
        Me.Create_Btn.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Create_Btn.BorderColor = System.Drawing.Color.Black
        Me.Create_Btn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Create_Btn.FocusedColor = System.Drawing.Color.Empty
        Me.Create_Btn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Create_Btn.ForeColor = System.Drawing.Color.White
        Me.Create_Btn.Image = CType(resources.GetObject("Create_Btn.Image"), System.Drawing.Image)
        Me.Create_Btn.ImageSize = New System.Drawing.Size(20, 20)
        Me.Create_Btn.Location = New System.Drawing.Point(329, 463)
        Me.Create_Btn.Name = "Create_Btn"
        Me.Create_Btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Create_Btn.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Create_Btn.OnHoverForeColor = System.Drawing.Color.White
        Me.Create_Btn.OnHoverImage = Nothing
        Me.Create_Btn.OnPressedColor = System.Drawing.Color.Black
        Me.Create_Btn.Size = New System.Drawing.Size(160, 42)
        Me.Create_Btn.TabIndex = 2
        Me.Create_Btn.Text = "Create"
        '
        'Btn_Update
        '
        Me.Btn_Update.AnimationHoverSpeed = 0.07!
        Me.Btn_Update.AnimationSpeed = 0.03!
        Me.Btn_Update.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Update.BorderColor = System.Drawing.Color.Black
        Me.Btn_Update.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Update.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Update.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Update.ForeColor = System.Drawing.Color.White
        Me.Btn_Update.Image = CType(resources.GetObject("Btn_Update.Image"), System.Drawing.Image)
        Me.Btn_Update.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Update.Location = New System.Drawing.Point(329, 511)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Update.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Update.OnHoverImage = Nothing
        Me.Btn_Update.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Update.Size = New System.Drawing.Size(160, 42)
        Me.Btn_Update.TabIndex = 3
        Me.Btn_Update.Text = "Update"
        '
        'Btn_UndoEnd
        '
        Me.Btn_UndoEnd.AnimationHoverSpeed = 0.07!
        Me.Btn_UndoEnd.AnimationSpeed = 0.03!
        Me.Btn_UndoEnd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_UndoEnd.BorderColor = System.Drawing.Color.Black
        Me.Btn_UndoEnd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_UndoEnd.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_UndoEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_UndoEnd.ForeColor = System.Drawing.Color.White
        Me.Btn_UndoEnd.Image = CType(resources.GetObject("Btn_UndoEnd.Image"), System.Drawing.Image)
        Me.Btn_UndoEnd.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_UndoEnd.Location = New System.Drawing.Point(509, 511)
        Me.Btn_UndoEnd.Name = "Btn_UndoEnd"
        Me.Btn_UndoEnd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_UndoEnd.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_UndoEnd.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_UndoEnd.OnHoverImage = Nothing
        Me.Btn_UndoEnd.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_UndoEnd.Size = New System.Drawing.Size(160, 42)
        Me.Btn_UndoEnd.TabIndex = 6
        Me.Btn_UndoEnd.Text = "Undo End Project"
        '
        'Btn_EndProject
        '
        Me.Btn_EndProject.AnimationHoverSpeed = 0.07!
        Me.Btn_EndProject.AnimationSpeed = 0.03!
        Me.Btn_EndProject.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_EndProject.BorderColor = System.Drawing.Color.Black
        Me.Btn_EndProject.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_EndProject.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_EndProject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_EndProject.ForeColor = System.Drawing.Color.White
        Me.Btn_EndProject.Image = CType(resources.GetObject("Btn_EndProject.Image"), System.Drawing.Image)
        Me.Btn_EndProject.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_EndProject.Location = New System.Drawing.Point(509, 463)
        Me.Btn_EndProject.Name = "Btn_EndProject"
        Me.Btn_EndProject.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_EndProject.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_EndProject.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_EndProject.OnHoverImage = Nothing
        Me.Btn_EndProject.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_EndProject.Size = New System.Drawing.Size(160, 42)
        Me.Btn_EndProject.TabIndex = 5
        Me.Btn_EndProject.Text = "End Project"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.AnimationHoverSpeed = 0.07!
        Me.Btn_Delete.AnimationSpeed = 0.03!
        Me.Btn_Delete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Delete.BorderColor = System.Drawing.Color.Black
        Me.Btn_Delete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Delete.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.Image = CType(resources.GetObject("Btn_Delete.Image"), System.Drawing.Image)
        Me.Btn_Delete.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Delete.Location = New System.Drawing.Point(509, 415)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Delete.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Delete.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Delete.OnHoverImage = Nothing
        Me.Btn_Delete.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Delete.Size = New System.Drawing.Size(160, 42)
        Me.Btn_Delete.TabIndex = 4
        Me.Btn_Delete.Text = "Delete"
        '
        'Tbx_ProjCode_Read
        '
        Me.Tbx_ProjCode_Read.Location = New System.Drawing.Point(684, 415)
        Me.Tbx_ProjCode_Read.Name = "Tbx_ProjCode_Read"
        Me.Tbx_ProjCode_Read.Size = New System.Drawing.Size(196, 20)
        Me.Tbx_ProjCode_Read.TabIndex = 7
        '
        'Tbx_ProjName_Write
        '
        Me.Tbx_ProjName_Write.Location = New System.Drawing.Point(684, 441)
        Me.Tbx_ProjName_Write.Name = "Tbx_ProjName_Write"
        Me.Tbx_ProjName_Write.Size = New System.Drawing.Size(196, 20)
        Me.Tbx_ProjName_Write.TabIndex = 8
        '
        'Tbx_ClientName
        '
        Me.Tbx_ClientName.Location = New System.Drawing.Point(684, 467)
        Me.Tbx_ClientName.Name = "Tbx_ClientName"
        Me.Tbx_ClientName.Size = New System.Drawing.Size(196, 20)
        Me.Tbx_ClientName.TabIndex = 9
        '
        'Tbx_DateEnded
        '
        Me.Tbx_DateEnded.Location = New System.Drawing.Point(684, 523)
        Me.Tbx_DateEnded.Name = "Tbx_DateEnded"
        Me.Tbx_DateEnded.Size = New System.Drawing.Size(196, 20)
        Me.Tbx_DateEnded.TabIndex = 11
        '
        'Tbx_Budget
        '
        Me.Tbx_Budget.Location = New System.Drawing.Point(684, 497)
        Me.Tbx_Budget.Name = "Tbx_Budget"
        Me.Tbx_Budget.Size = New System.Drawing.Size(196, 20)
        Me.Tbx_Budget.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(899, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Project Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(899, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(899, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Project Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(899, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Client Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(899, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Client Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(899, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Date Ended"
        '
        'Btn_Load
        '
        Me.Btn_Load.AnimationHoverSpeed = 0.07!
        Me.Btn_Load.AnimationSpeed = 0.03!
        Me.Btn_Load.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Load.BorderColor = System.Drawing.Color.Black
        Me.Btn_Load.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Load.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Load.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Load.ForeColor = System.Drawing.Color.White
        Me.Btn_Load.Image = CType(resources.GetObject("Btn_Load.Image"), System.Drawing.Image)
        Me.Btn_Load.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Load.Location = New System.Drawing.Point(329, 415)
        Me.Btn_Load.Name = "Btn_Load"
        Me.Btn_Load.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Load.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Load.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Load.OnHoverImage = Nothing
        Me.Btn_Load.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Load.Size = New System.Drawing.Size(160, 42)
        Me.Btn_Load.TabIndex = 1
        Me.Btn_Load.Text = "Load"
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.GunaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(329, 87)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(769, 307)
        Me.GunaDataGridView1.TabIndex = 18
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
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'panelForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 620)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tbx_DateEnded)
        Me.Controls.Add(Me.Tbx_Budget)
        Me.Controls.Add(Me.Tbx_ClientName)
        Me.Controls.Add(Me.Tbx_ProjName_Write)
        Me.Controls.Add(Me.Tbx_ProjCode_Read)
        Me.Controls.Add(Me.Btn_UndoEnd)
        Me.Controls.Add(Me.Btn_EndProject)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.Create_Btn)
        Me.Controls.Add(Me.Btn_Load)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "panelForm1"
        Me.Text = "Panel1"
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Create_Btn As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_Update As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_UndoEnd As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_EndProject As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_Delete As Guna.UI.WinForms.GunaButton
    Friend WithEvents Tbx_ProjCode_Read As TextBox
    Friend WithEvents Tbx_ProjName_Write As TextBox
    Friend WithEvents Tbx_ClientName As TextBox
    Friend WithEvents Tbx_DateEnded As TextBox
    Friend WithEvents Tbx_Budget As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn_Load As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
End Class
