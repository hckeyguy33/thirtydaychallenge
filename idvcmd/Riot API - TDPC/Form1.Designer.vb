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
        Me.nameListRButton = New System.Windows.Forms.RadioButton()
        Me.summonerNameRButton = New System.Windows.Forms.RadioButton()
        Me.summonerIDRButton = New System.Windows.Forms.RadioButton()
        Me.masteriesRButton = New System.Windows.Forms.RadioButton()
        Me.runesRButton = New System.Windows.Forms.RadioButton()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1035, 349)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.nameListRButton)
        Me.TabPage1.Controls.Add(Me.summonerNameRButton)
        Me.TabPage1.Controls.Add(Me.summonerIDRButton)
        Me.TabPage1.Controls.Add(Me.masteriesRButton)
        Me.TabPage1.Controls.Add(Me.runesRButton)
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
        'nameListRButton
        '
        Me.nameListRButton.AutoSize = True
        Me.nameListRButton.Location = New System.Drawing.Point(398, 278)
        Me.nameListRButton.Name = "nameListRButton"
        Me.nameListRButton.Size = New System.Drawing.Size(136, 17)
        Me.nameListRButton.TabIndex = 24
        Me.nameListRButton.TabStop = True
        Me.nameListRButton.Text = "SummonerNameListDto"
        Me.nameListRButton.UseVisualStyleBackColor = True
        '
        'summonerNameRButton
        '
        Me.summonerNameRButton.AutoSize = True
        Me.summonerNameRButton.Location = New System.Drawing.Point(398, 255)
        Me.summonerNameRButton.Name = "summonerNameRButton"
        Me.summonerNameRButton.Size = New System.Drawing.Size(125, 17)
        Me.summonerNameRButton.TabIndex = 23
        Me.summonerNameRButton.TabStop = True
        Me.summonerNameRButton.Text = "SummonerDto/Name"
        Me.summonerNameRButton.UseVisualStyleBackColor = True
        '
        'summonerIDRButton
        '
        Me.summonerIDRButton.AutoSize = True
        Me.summonerIDRButton.Location = New System.Drawing.Point(398, 232)
        Me.summonerIDRButton.Name = "summonerIDRButton"
        Me.summonerIDRButton.Size = New System.Drawing.Size(108, 17)
        Me.summonerIDRButton.TabIndex = 22
        Me.summonerIDRButton.TabStop = True
        Me.summonerIDRButton.Text = "SummonerDto/ID"
        Me.summonerIDRButton.UseVisualStyleBackColor = True
        '
        'masteriesRButton
        '
        Me.masteriesRButton.AutoSize = True
        Me.masteriesRButton.Location = New System.Drawing.Point(398, 209)
        Me.masteriesRButton.Name = "masteriesRButton"
        Me.masteriesRButton.Size = New System.Drawing.Size(109, 17)
        Me.masteriesRButton.TabIndex = 21
        Me.masteriesRButton.TabStop = True
        Me.masteriesRButton.Text = "MasteryPagesDto"
        Me.masteriesRButton.UseVisualStyleBackColor = True
        '
        'runesRButton
        '
        Me.runesRButton.AutoSize = True
        Me.runesRButton.Location = New System.Drawing.Point(399, 186)
        Me.runesRButton.Name = "runesRButton"
        Me.runesRButton.Size = New System.Drawing.Size(98, 17)
        Me.runesRButton.TabIndex = 20
        Me.runesRButton.TabStop = True
        Me.runesRButton.Text = "RunePagesDto"
        Me.runesRButton.UseVisualStyleBackColor = True
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
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1027, 323)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1027, 323)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1027, 323)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1027, 323)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
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
    Friend WithEvents nameListRButton As RadioButton
    Friend WithEvents summonerNameRButton As RadioButton
    Friend WithEvents summonerIDRButton As RadioButton
    Friend WithEvents masteriesRButton As RadioButton
    Friend WithEvents runesRButton As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
End Class
