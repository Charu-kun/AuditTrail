<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class panelForm3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(panelForm3))
        Me.Btn_Update = New Guna.UI.WinForms.GunaButton()
        Me.Tbx_Username = New System.Windows.Forms.TextBox()
        Me.Tbx_Password = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Credentials = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
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
        Me.Btn_Update.Location = New System.Drawing.Point(332, 243)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Update.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Update.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Update.OnHoverImage = Nothing
        Me.Btn_Update.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Update.Size = New System.Drawing.Size(160, 42)
        Me.Btn_Update.TabIndex = 0
        Me.Btn_Update.Text = "Update"
        '
        'Tbx_Username
        '
        Me.Tbx_Username.Location = New System.Drawing.Point(332, 168)
        Me.Tbx_Username.Name = "Tbx_Username"
        Me.Tbx_Username.Size = New System.Drawing.Size(204, 20)
        Me.Tbx_Username.TabIndex = 1
        '
        'Tbx_Password
        '
        Me.Tbx_Password.Location = New System.Drawing.Point(332, 194)
        Me.Tbx_Password.Name = "Tbx_Password"
        Me.Tbx_Password.Size = New System.Drawing.Size(204, 20)
        Me.Tbx_Password.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(267, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label2.Location = New System.Drawing.Point(267, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Btn_Credentials
        '
        Me.Btn_Credentials.AnimationHoverSpeed = 0.07!
        Me.Btn_Credentials.AnimationSpeed = 0.03!
        Me.Btn_Credentials.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Credentials.BorderColor = System.Drawing.Color.Black
        Me.Btn_Credentials.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Credentials.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Credentials.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btn_Credentials.ForeColor = System.Drawing.Color.White
        Me.Btn_Credentials.Image = CType(resources.GetObject("Btn_Credentials.Image"), System.Drawing.Image)
        Me.Btn_Credentials.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Credentials.Location = New System.Drawing.Point(521, 243)
        Me.Btn_Credentials.Name = "Btn_Credentials"
        Me.Btn_Credentials.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Credentials.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Credentials.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Credentials.OnHoverImage = Nothing
        Me.Btn_Credentials.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Credentials.Size = New System.Drawing.Size(160, 42)
        Me.Btn_Credentials.TabIndex = 5
        Me.Btn_Credentials.Text = "View Credentials"
        '
        'panelForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 620)
        Me.Controls.Add(Me.Btn_Credentials)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tbx_Password)
        Me.Controls.Add(Me.Tbx_Username)
        Me.Controls.Add(Me.Btn_Update)
        Me.Name = "panelForm3"
        Me.Text = "Panel3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Update As Guna.UI.WinForms.GunaButton
    Friend WithEvents Tbx_Username As TextBox
    Friend WithEvents Tbx_Password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Credentials As Guna.UI.WinForms.GunaButton
End Class
