<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntry
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
        grbOrangeStatus = New GroupBox()
        rdbSend = New RadioButton()
        rdbReceive = New RadioButton()
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
        txbChildName = New TextBox()
        txbRecSend = New TextBox()
        dtpStart = New DateTimePicker()
        dtpEnd = New DateTimePicker()
        cmbType = New ComboBox()
        cmbOfficer = New ComboBox()
        lblProgRptDate = New Label()
        lblDaysRemainProg = New Label()
        lblTransThreshold = New Label()
        lblDaysRemainTrns = New Label()
        Label14 = New Label()
        Label15 = New Label()
        btnSave = New Button()
        btnReturn = New Button()
        Label16 = New Label()
        grbOrangeStatus.SuspendLayout()
        SuspendLayout()
        ' 
        ' grbOrangeStatus
        ' 
        grbOrangeStatus.BackColor = SystemColors.ControlDarkDark
        grbOrangeStatus.Controls.Add(rdbSend)
        grbOrangeStatus.Controls.Add(rdbReceive)
        grbOrangeStatus.ForeColor = SystemColors.ButtonHighlight
        grbOrangeStatus.Location = New Point(18, 88)
        grbOrangeStatus.Name = "grbOrangeStatus"
        grbOrangeStatus.Size = New Size(135, 91)
        grbOrangeStatus.TabIndex = 27
        grbOrangeStatus.TabStop = False
        grbOrangeStatus.Text = "Orange County:"
        ' 
        ' rdbSend
        ' 
        rdbSend.AutoSize = True
        rdbSend.Location = New Point(6, 22)
        rdbSend.Name = "rdbSend"
        rdbSend.Size = New Size(68, 19)
        rdbSend.TabIndex = 14
        rdbSend.TabStop = True
        rdbSend.Text = "Sending"
        rdbSend.UseVisualStyleBackColor = True
        ' 
        ' rdbReceive
        ' 
        rdbReceive.AutoSize = True
        rdbReceive.Location = New Point(6, 54)
        rdbReceive.Name = "rdbReceive"
        rdbReceive.Size = New Size(76, 19)
        rdbReceive.TabIndex = 15
        rdbReceive.TabStop = True
        rdbReceive.Text = "Receiving"
        rdbReceive.UseVisualStyleBackColor = True
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
        ' txbChildName
        ' 
        txbChildName.Font = New Font("Segoe UI", 12F)
        txbChildName.Location = New Point(16, 39)
        txbChildName.Name = "txbChildName"
        txbChildName.Size = New Size(335, 29)
        txbChildName.TabIndex = 28
        ' 
        ' txbRecSend
        ' 
        txbRecSend.Font = New Font("Segoe UI", 12F)
        txbRecSend.Location = New Point(173, 148)
        txbRecSend.Name = "txbRecSend"
        txbRecSend.Size = New Size(178, 29)
        txbRecSend.TabIndex = 29
        ' 
        ' dtpStart
        ' 
        dtpStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpStart.Format = DateTimePickerFormat.Short
        dtpStart.Location = New Point(16, 236)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(137, 29)
        dtpStart.TabIndex = 30
        ' 
        ' dtpEnd
        ' 
        dtpEnd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpEnd.Format = DateTimePickerFormat.Short
        dtpEnd.Location = New Point(203, 236)
        dtpEnd.Name = "dtpEnd"
        dtpEnd.Size = New Size(137, 29)
        dtpEnd.TabIndex = 31
        ' 
        ' cmbType
        ' 
        cmbType.Font = New Font("Segoe UI", 12F)
        cmbType.FormattingEnabled = True
        cmbType.Location = New Point(371, 148)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(135, 29)
        cmbType.TabIndex = 32
        ' 
        ' cmbOfficer
        ' 
        cmbOfficer.Font = New Font("Segoe UI", 12F)
        cmbOfficer.FormattingEnabled = True
        cmbOfficer.Location = New Point(529, 147)
        cmbOfficer.Name = "cmbOfficer"
        cmbOfficer.Size = New Size(161, 29)
        cmbOfficer.TabIndex = 33
        ' 
        ' lblProgRptDate
        ' 
        lblProgRptDate.BorderStyle = BorderStyle.FixedSingle
        lblProgRptDate.Location = New Point(18, 337)
        lblProgRptDate.Name = "lblProgRptDate"
        lblProgRptDate.Size = New Size(103, 23)
        lblProgRptDate.TabIndex = 34
        ' 
        ' lblDaysRemainProg
        ' 
        lblDaysRemainProg.BorderStyle = BorderStyle.FixedSingle
        lblDaysRemainProg.Location = New Point(173, 337)
        lblDaysRemainProg.Name = "lblDaysRemainProg"
        lblDaysRemainProg.Size = New Size(57, 23)
        lblDaysRemainProg.TabIndex = 35
        ' 
        ' lblTransThreshold
        ' 
        lblTransThreshold.BorderStyle = BorderStyle.FixedSingle
        lblTransThreshold.Location = New Point(414, 337)
        lblTransThreshold.Name = "lblTransThreshold"
        lblTransThreshold.Size = New Size(103, 23)
        lblTransThreshold.TabIndex = 36
        ' 
        ' lblDaysRemainTrns
        ' 
        lblDaysRemainTrns.BorderStyle = BorderStyle.FixedSingle
        lblDaysRemainTrns.Location = New Point(558, 337)
        lblDaysRemainTrns.Name = "lblDaysRemainTrns"
        lblDaysRemainTrns.Size = New Size(57, 23)
        lblDaysRemainTrns.TabIndex = 37
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
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSave.Location = New Point(617, 21)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 40)
        btnSave.TabIndex = 40
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Gold
        btnReturn.Location = New Point(617, 71)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(75, 40)
        btnReturn.TabIndex = 41
        btnReturn.Text = "Rtn Main"
        btnReturn.UseVisualStyleBackColor = False
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
        ' frmEntry
        ' 
        AcceptButton = btnSave
        AccessibleRole = AccessibleRole.Caret
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnReturn
        ClientSize = New Size(719, 394)
        Controls.Add(Label16)
        Controls.Add(btnReturn)
        Controls.Add(btnSave)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(lblDaysRemainTrns)
        Controls.Add(lblTransThreshold)
        Controls.Add(lblDaysRemainProg)
        Controls.Add(lblProgRptDate)
        Controls.Add(cmbOfficer)
        Controls.Add(cmbType)
        Controls.Add(dtpEnd)
        Controls.Add(dtpStart)
        Controls.Add(txbRecSend)
        Controls.Add(txbChildName)
        Controls.Add(grbOrangeStatus)
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
        Name = "frmEntry"
        Text = "Entry Form"
        grbOrangeStatus.ResumeLayout(False)
        grbOrangeStatus.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grbOrangeStatus As GroupBox
    Friend WithEvents rdbSend As RadioButton
    Friend WithEvents rdbReceive As RadioButton
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
    Friend WithEvents txbChildName As TextBox
    Friend WithEvents txbRecSend As TextBox
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents dtpEnd As DateTimePicker
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents cmbOfficer As ComboBox
    Friend WithEvents lblProgRptDate As Label
    Friend WithEvents lblDaysRemainProg As Label
    Friend WithEvents lblTransThreshold As Label
    Friend WithEvents lblDaysRemainTrns As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents Label16 As Label
End Class
