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
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker3 = New DateTimePicker()
        brnClose = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblListingID
        ' 
        lblListingID.AutoSize = True
        lblListingID.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblListingID.ForeColor = Color.Blue
        lblListingID.Location = New Point(12, 85)
        lblListingID.Name = "lblListingID"
        lblListingID.Size = New Size(333, 32)
        lblListingID.TabIndex = 0
        lblListingID.Text = "Listing of Current Transfers:" & vbCrLf
        ' 
        ' lblListing
        ' 
        lblListing.BackColor = SystemColors.ActiveCaptionText
        lblListing.ForeColor = SystemColors.Control
        lblListing.Location = New Point(12, 121)
        lblListing.Name = "lblListing"
        lblListing.Size = New Size(1047, 290)
        lblListing.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Green
        btnAdd.Location = New Point(12, 27)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 39)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add New"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Location = New Point(233, 27)
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
        lblDateID.Location = New Point(928, 25)
        lblDateID.Name = "lblDateID"
        lblDateID.Size = New Size(100, 21)
        lblDateID.TabIndex = 5
        lblDateID.Text = "Today's Date:"
        ' 
        ' lblTotalChildren
        ' 
        lblTotalChildren.BorderStyle = BorderStyle.FixedSingle
        lblTotalChildren.Font = New Font("Segoe UI", 12F)
        lblTotalChildren.Location = New Point(17, 444)
        lblTotalChildren.Name = "lblTotalChildren"
        lblTotalChildren.Size = New Size(75, 23)
        lblTotalChildren.TabIndex = 7
        lblTotalChildren.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(154, 444)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 23)
        Label1.TabIndex = 8
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(294, 444)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 23)
        Label2.TabIndex = 9
        Label2.Text = "Label1"
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
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 11.25F)
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(17, 514)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(131, 27)
        DateTimePicker1.TabIndex = 17
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 11.25F)
        DateTimePicker2.Format = DateTimePickerFormat.Short
        DateTimePicker2.Location = New Point(17, 576)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(131, 27)
        DateTimePicker2.TabIndex = 18
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.Font = New Font("Segoe UI", 11.25F)
        DateTimePicker3.Format = DateTimePickerFormat.Short
        DateTimePicker3.Location = New Point(928, 49)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(131, 27)
        DateTimePicker3.TabIndex = 19
        ' 
        ' brnClose
        ' 
        brnClose.BackColor = Color.SkyBlue
        brnClose.Location = New Point(345, 27)
        brnClose.Name = "brnClose"
        brnClose.Size = New Size(75, 39)
        brnClose.TabIndex = 4
        brnClose.Text = "Close"
        brnClose.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gold
        Button1.Location = New Point(121, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 39)
        Button1.TabIndex = 20
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = brnClose
        ClientSize = New Size(1071, 625)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker3)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTotalChildren)
        Controls.Add(lblDateID)
        Controls.Add(brnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(lblListing)
        Controls.Add(lblListingID)
        Name = "frmMain"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents brnClose As Button
    Friend WithEvents Button1 As Button

End Class
