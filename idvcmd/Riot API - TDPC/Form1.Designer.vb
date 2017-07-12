<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class idBox5
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rawJSON = New System.Windows.Forms.RichTextBox()
        Me.summonerLevelBox = New System.Windows.Forms.TextBox()
        Me.revisionStrBox = New System.Windows.Forms.TextBox()
        Me.revisionBox = New System.Windows.Forms.TextBox()
        Me.iconIdBox = New System.Windows.Forms.TextBox()
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.devKeyBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.executeButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 349)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.RadioButton5)
        Me.TabPage1.Controls.Add(Me.RadioButton4)
        Me.TabPage1.Controls.Add(Me.RadioButton3)
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.rawJSON)
        Me.TabPage1.Controls.Add(Me.summonerLevelBox)
        Me.TabPage1.Controls.Add(Me.revisionStrBox)
        Me.TabPage1.Controls.Add(Me.revisionBox)
        Me.TabPage1.Controls.Add(Me.iconIdBox)
        Me.TabPage1.Controls.Add(Me.nameBox)
        Me.TabPage1.Controls.Add(Me.idBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1027, 323)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summoner-V1.4"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Type Of Request"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(398, 278)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton5.TabIndex = 24
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "SummonerNameListDto"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(398, 255)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(125, 17)
        Me.RadioButton4.TabIndex = 23
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "SummonerDto/Name"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(398, 232)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(108, 17)
        Me.RadioButton3.TabIndex = 22
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "SummonerDto/ID"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(398, 209)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(109, 17)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "MasteryPagesDto"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(399, 186)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RunePagesDto"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Raw JSON Response"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(493, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Name - ""summonerLevel"" | Data Type - long | Description - Summoner level associat" &
    "ed with the summer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(611, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name - ""revisionDateStr"" | Data Type - Date | Description - Human readable string" &
    " representing date summoner was last modified"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(167, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(578, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Name - ""revisionDate"" | Data Type - long | Description - Date summoner was last m" &
    "odified specified as epoch milliseconds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(167, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(508, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Name - ""profileIconId"" | Data Type - int | Description - ID of the summoner icon " &
    "associated with the summer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name - ""name"" | Data Type - string | Description - Summoner name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Name - ""id"" | Data Type - long | Description - Summoner ID"
        '
        'rawJSON
        '
        Me.rawJSON.Location = New System.Drawing.Point(6, 186)
        Me.rawJSON.Name = "rawJSON"
        Me.rawJSON.Size = New System.Drawing.Size(386, 131)
        Me.rawJSON.TabIndex = 12
        Me.rawJSON.Text = ""
        '
        'summonerLevelBox
        '
        Me.summonerLevelBox.Location = New System.Drawing.Point(6, 136)
        Me.summonerLevelBox.Name = "summonerLevelBox"
        Me.summonerLevelBox.Size = New System.Drawing.Size(155, 20)
        Me.summonerLevelBox.TabIndex = 11
        '
        'revisionStrBox
        '
        Me.revisionStrBox.Location = New System.Drawing.Point(6, 110)
        Me.revisionStrBox.Name = "revisionStrBox"
        Me.revisionStrBox.Size = New System.Drawing.Size(155, 20)
        Me.revisionStrBox.TabIndex = 10
        '
        'revisionBox
        '
        Me.revisionBox.Location = New System.Drawing.Point(6, 84)
        Me.revisionBox.Name = "revisionBox"
        Me.revisionBox.Size = New System.Drawing.Size(155, 20)
        Me.revisionBox.TabIndex = 9
        '
        'iconIdBox
        '
        Me.iconIdBox.Location = New System.Drawing.Point(6, 58)
        Me.iconIdBox.Name = "iconIdBox"
        Me.iconIdBox.Size = New System.Drawing.Size(155, 20)
        Me.iconIdBox.TabIndex = 8
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(6, 32)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(155, 20)
        Me.nameBox.TabIndex = 7
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(6, 6)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(155, 20)
        Me.idBox.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1027, 323)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Summoner-V3"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(670, 372)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(155, 20)
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Text = "Default is NA"
        '
        'devKeyBox
        '
        Me.devKeyBox.Location = New System.Drawing.Point(670, 415)
        Me.devKeyBox.Name = "devKeyBox"
        Me.devKeyBox.Size = New System.Drawing.Size(155, 20)
        Me.devKeyBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(831, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 35)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "About Dev"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'executeButton
        '
        Me.executeButton.Location = New System.Drawing.Point(831, 405)
        Me.executeButton.Name = "executeButton"
        Me.executeButton.Size = New System.Drawing.Size(212, 39)
        Me.executeButton.TabIndex = 13
        Me.executeButton.Text = "Execute Request"
        Me.executeButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 375)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Region (na | euw | eune) "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(596, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "API Dev Key"
        '
        'idBox5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1059, 447)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.executeButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.devKeyBox)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "idBox5"
        Me.Text = ".NET Implementation of Riot Games LoL API"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rawJSON As RichTextBox
    Friend WithEvents summonerLevelBox As TextBox
    Friend WithEvents revisionStrBox As TextBox
    Friend WithEvents revisionBox As TextBox
    Friend WithEvents iconIdBox As TextBox
    Friend WithEvents nameBox As TextBox
    Friend WithEvents idBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents devKeyBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents executeButton As Button
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
