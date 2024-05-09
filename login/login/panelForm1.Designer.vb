<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panelForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaMediumRadioButton1 = New Guna.UI.WinForms.GunaMediumRadioButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GunaMediumRadioButton1
        '
        Me.GunaMediumRadioButton1.BaseColor = System.Drawing.Color.White
        Me.GunaMediumRadioButton1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaMediumRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaMediumRadioButton1.FillColor = System.Drawing.Color.White
        Me.GunaMediumRadioButton1.Location = New System.Drawing.Point(827, 197)
        Me.GunaMediumRadioButton1.Name = "GunaMediumRadioButton1"
        Me.GunaMediumRadioButton1.Size = New System.Drawing.Size(20, 20)
        Me.GunaMediumRadioButton1.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(884, 167)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(78, 15)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "PANEL 1 TEST"
        '
        'panelForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 620)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaMediumRadioButton1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "panelForm1"
        Me.Text = "Panel1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GunaMediumRadioButton1 As Guna.UI.WinForms.GunaMediumRadioButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
End Class
