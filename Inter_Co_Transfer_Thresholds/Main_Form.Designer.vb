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
        lblListing = New Label()
        Listing = New Label()
        btnAdd = New Button()
        btnDelete = New Button()
        brnClose = New Button()
        lblDateID = New Label()
        lblToday = New Label()
        SuspendLayout()
        ' 
        ' lblListing
        ' 
        lblListing.AutoSize = True
        lblListing.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblListing.ForeColor = Color.Blue
        lblListing.Location = New Point(12, 85)
        lblListing.Name = "lblListing"
        lblListing.Size = New Size(333, 32)
        lblListing.TabIndex = 0
        lblListing.Text = "Listing of Current Transfers:" & vbCrLf
        ' 
        ' Listing
        ' 
        Listing.BackColor = SystemColors.ActiveCaptionText
        Listing.ForeColor = SystemColors.Control
        Listing.Location = New Point(12, 121)
        Listing.Name = "Listing"
        Listing.Size = New Size(1047, 399)
        Listing.TabIndex = 1
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
        btnDelete.Location = New Point(123, 27)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 39)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' brnClose
        ' 
        brnClose.BackColor = Color.SkyBlue
        brnClose.Location = New Point(239, 27)
        brnClose.Name = "brnClose"
        brnClose.Size = New Size(75, 39)
        brnClose.TabIndex = 4
        brnClose.Text = "Close"
        brnClose.UseVisualStyleBackColor = False
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
        ' lblToday
        ' 
        lblToday.BorderStyle = BorderStyle.FixedSingle
        lblToday.FlatStyle = FlatStyle.Flat
        lblToday.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblToday.Location = New Point(932, 48)
        lblToday.Name = "lblToday"
        lblToday.Size = New Size(127, 27)
        lblToday.TabIndex = 6
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = brnClose
        ClientSize = New Size(1071, 529)
        Controls.Add(lblToday)
        Controls.Add(lblDateID)
        Controls.Add(brnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(Listing)
        Controls.Add(lblListing)
        Name = "frmMain"
        Text = "Inter County Transfer Thresholds"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblListing As Label
    Friend WithEvents Listing As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents brnClose As Button
    Friend WithEvents lblDateID As Label
    Friend WithEvents lblToday As Label

End Class
