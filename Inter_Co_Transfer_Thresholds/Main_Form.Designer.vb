<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblListingID = New Label()
        lblListing = New Label()
        btnAdd = New Button()
        btnDelete = New Button()
        lblDateID = New Label()
        lblTotalChildren = New Label()
        lblTotReceived = New Label()
        lblTotSent = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        dtpNinety = New DateTimePicker()
        dtpOneEighty = New DateTimePicker()
        dtpToday = New DateTimePicker()
        brnClose = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblListingID
        ' 
        lblListingID.AutoSize = True
        lblListingID.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblListingID.ForeColor = Color.Blue
        lblListingID.Location = New Point(12, 15)
        lblListingID.Name = "lblListingID"
        lblListingID.Size = New Size(333, 32)
        lblListingID.TabIndex = 0
        lblListingID.Text = "Listing of Current Transfers:" & vbCrLf
        ' 
        ' lblListing
        ' 
        lblListing.BackColor = SystemColors.ActiveCaptionText
        lblListing.Font = New Font("Cascadia Mono", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblListing.ForeColor = SystemColors.Control
        lblListing.Location = New Point(12, 94)
        lblListing.Name = "lblListing"
        lblListing.Size = New Size(1178, 290)
        lblListing.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Green
        btnAdd.Location = New Point(766, 558)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 39)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add New"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(987, 558)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 39)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblDateID
        ' 
        lblDateID.AutoSize = True
        lblDateID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDateID.Location = New Point(965, 15)
        lblDateID.Name = "lblDateID"
        lblDateID.Size = New Size(100, 21)
        lblDateID.TabIndex = 5
        lblDateID.Text = "Today's Date:"
        ' 
        ' lblTotalChildren
        ' 
        lblTotalChildren.BorderStyle = BorderStyle.FixedSingle
        lblTotalChildren.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalChildren.Location = New Point(17, 444)
        lblTotalChildren.Name = "lblTotalChildren"
        lblTotalChildren.Size = New Size(75, 23)
        lblTotalChildren.TabIndex = 7
        lblTotalChildren.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotReceived
        ' 
        lblTotReceived.BorderStyle = BorderStyle.FixedSingle
        lblTotReceived.Font = New Font("Segoe UI", 12F)
        lblTotReceived.Location = New Point(154, 444)
        lblTotReceived.Name = "lblTotReceived"
        lblTotReceived.Size = New Size(75, 23)
        lblTotReceived.TabIndex = 8
        ' 
        ' lblTotSent
        ' 
        lblTotSent.BorderStyle = BorderStyle.FixedSingle
        lblTotSent.Font = New Font("Segoe UI", 12F)
        lblTotSent.Location = New Point(294, 444)
        lblTotSent.Name = "lblTotSent"
        lblTotSent.Size = New Size(75, 23)
        lblTotSent.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(12, 425)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 15)
        Label5.TabIndex = 12
        Label5.Text = "Total Children:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(154, 425)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 15)
        Label6.TabIndex = 13
        Label6.Text = "Total Recived:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(294, 425)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 15)
        Label7.TabIndex = 14
        Label7.Text = "Total Sent:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label8.Location = New Point(17, 496)
        Label8.Name = "Label8"
        Label8.Size = New Size(119, 15)
        Label8.TabIndex = 15
        Label8.Text = "90 Days from Today:" & vbCrLf
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label9.Location = New Point(17, 558)
        Label9.Name = "Label9"
        Label9.Size = New Size(126, 15)
        Label9.TabIndex = 16
        Label9.Text = "180 Days from Today:"
        ' 
        ' dtpNinety
        ' 
        dtpNinety.Font = New Font("Segoe UI", 11.25F)
        dtpNinety.Format = DateTimePickerFormat.Short
        dtpNinety.Location = New Point(17, 514)
        dtpNinety.Name = "dtpNinety"
        dtpNinety.Size = New Size(131, 27)
        dtpNinety.TabIndex = 17
        ' 
        ' dtpOneEighty
        ' 
        dtpOneEighty.Font = New Font("Segoe UI", 11.25F)
        dtpOneEighty.Format = DateTimePickerFormat.Short
        dtpOneEighty.Location = New Point(17, 576)
        dtpOneEighty.Name = "dtpOneEighty"
        dtpOneEighty.Size = New Size(131, 27)
        dtpOneEighty.TabIndex = 18
        ' 
        ' dtpToday
        ' 
        dtpToday.Enabled = False
        dtpToday.Font = New Font("Segoe UI", 11.25F)
        dtpToday.Format = DateTimePickerFormat.Short
        dtpToday.Location = New Point(965, 39)
        dtpToday.Name = "dtpToday"
        dtpToday.Size = New Size(131, 27)
        dtpToday.TabIndex = 19
        ' 
        ' brnClose
        ' 
        brnClose.BackColor = Color.SkyBlue
        brnClose.Location = New Point(1099, 558)
        brnClose.Name = "brnClose"
        brnClose.Size = New Size(75, 39)
        brnClose.TabIndex = 4
        brnClose.Text = "Close"
        brnClose.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Location = New Point(875, 558)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 39)
        Button1.TabIndex = 20
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AcceptButton = btnAdd
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = brnClose
        ClientSize = New Size(1204, 625)
        Controls.Add(Button1)
        Controls.Add(dtpToday)
        Controls.Add(dtpOneEighty)
        Controls.Add(dtpNinety)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblTotSent)
        Controls.Add(lblTotReceived)
        Controls.Add(lblTotalChildren)
        Controls.Add(lblDateID)
        Controls.Add(brnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(lblListing)
        Controls.Add(lblListingID)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inter County Transfer Thresholds"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblListingID As Label
    Friend WithEvents lblListing As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblDateID As Label
    Friend WithEvents lblTotalChildren As Label
    Friend WithEvents lblTotReceived As Label
    Friend WithEvents lblTotSent As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpNinety As DateTimePicker
    Friend WithEvents dtpOneEighty As DateTimePicker
    Friend WithEvents dtpToday As DateTimePicker
    Friend WithEvents brnClose As Button
    Friend WithEvents Button1 As Button

End Class
