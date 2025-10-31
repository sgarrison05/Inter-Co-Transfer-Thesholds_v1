<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entry_Form
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
        GroupBox1 = New GroupBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblChildName = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label16 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDarkDark
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(18, 88)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(135, 91)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "Orange County:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(68, 19)
        RadioButton1.TabIndex = 14
        RadioButton1.TabStop = True
        RadioButton1.Text = "Sending"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 54)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(76, 19)
        RadioButton2.TabIndex = 15
        RadioButton2.TabStop = True
        RadioButton2.Text = "Receiving"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(555, 313)
        Label9.Name = "Label9"
        Label9.Size = New Size(97, 15)
        Label9.TabIndex = 26
        Label9.Text = "Days Till Transfer:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(170, 313)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 15)
        Label8.TabIndex = 25
        Label8.Text = "Days Till Prog Report:" & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(173, 121)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 15)
        Label7.TabIndex = 24
        Label7.Text = "Receiving/Sending County:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(369, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 23
        Label6.Text = "Type:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(529, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 22
        Label5.Text = "Officer:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(203, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 21
        Label4.Text = "End Date:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(411, 313)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 15)
        Label3.TabIndex = 20
        Label3.Text = "Transfer Threshold:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 313)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 15)
        Label2.TabIndex = 19
        Label2.Text = "Progress Report Date:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 218)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 15)
        Label1.TabIndex = 18
        Label1.Text = "Start Date:"
        ' 
        ' lblChildName
        ' 
        lblChildName.AutoSize = True
        lblChildName.Location = New Point(16, 21)
        lblChildName.Name = "lblChildName"
        lblChildName.Size = New Size(73, 15)
        lblChildName.TabIndex = 17
        lblChildName.Text = "Child Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(16, 39)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(335, 29)
        TextBox1.TabIndex = 28
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(173, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(178, 29)
        TextBox2.TabIndex = 29
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(16, 236)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(137, 29)
        DateTimePicker1.TabIndex = 30
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(203, 236)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(137, 29)
        DateTimePicker2.TabIndex = 31
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(371, 148)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(135, 29)
        ComboBox1.TabIndex = 32
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(529, 147)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(161, 29)
        ComboBox2.TabIndex = 33
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Location = New Point(18, 337)
        Label10.Name = "Label10"
        Label10.Size = New Size(103, 23)
        Label10.TabIndex = 34
        ' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Location = New Point(173, 337)
        Label11.Name = "Label11"
        Label11.Size = New Size(57, 23)
        Label11.TabIndex = 35
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Location = New Point(414, 337)
        Label12.Name = "Label12"
        Label12.Size = New Size(103, 23)
        Label12.TabIndex = 36
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.FixedSingle
        Label13.Location = New Point(558, 337)
        Label13.Name = "Label13"
        Label13.Size = New Size(57, 23)
        Label13.TabIndex = 37
        ' 
        ' Label14
        ' 
        Label14.Location = New Point(231, 338)
        Label14.Name = "Label14"
        Label14.Size = New Size(47, 22)
        Label14.TabIndex = 38
        Label14.Text = "Days"
        Label14.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Label15
        ' 
        Label15.Location = New Point(617, 337)
        Label15.Name = "Label15"
        Label15.Size = New Size(47, 22)
        Label15.TabIndex = 39
        Label15.Text = "Days"
        Label15.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.Location = New Point(617, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 40)
        Button1.TabIndex = 40
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gold
        Button2.Location = New Point(617, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 40)
        Button2.TabIndex = 41
        Button2.Text = "Rtn Main"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(164, 243)
        Label16.Name = "Label16"
        Label16.Size = New Size(30, 15)
        Label16.TabIndex = 42
        Label16.Text = "--->"
        ' 
        ' Entry_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(719, 394)
        Controls.Add(Label16)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(GroupBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblChildName)
        Name = "Entry_Form"
        Text = "Entry_Form"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChildName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
End Class
