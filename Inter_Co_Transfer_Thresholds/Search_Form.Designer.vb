<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        txbLastName = New TextBox()
        lblChildNameID = New Label()
        btnReturn = New Button()
        btnClear = New Button()
        btnEnter = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txbLastName
        ' 
        txbLastName.Font = New Font("Segoe UI", 12F)
        txbLastName.Location = New Point(12, 27)
        txbLastName.Name = "txbLastName"
        txbLastName.Size = New Size(335, 29)
        txbLastName.TabIndex = 18
        ' 
        ' lblChildNameID
        ' 
        lblChildNameID.AutoSize = True
        lblChildNameID.Location = New Point(12, 9)
        lblChildNameID.Name = "lblChildNameID"
        lblChildNameID.Size = New Size(143, 15)
        lblChildNameID.TabIndex = 19
        lblChildNameID.Text = "Child Name: (Last Name):"
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.Gold
        btnReturn.Location = New Point(444, 195)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(75, 40)
        btnReturn.TabIndex = 20
        btnReturn.Text = "Rtn Main"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Silver
        btnClear.Location = New Point(353, 195)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 40)
        btnClear.TabIndex = 45
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.GreenYellow
        btnEnter.Location = New Point(260, 195)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(75, 40)
        btnEnter.TabIndex = 46
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 93)
        Label1.TabIndex = 47
        Label1.Text = "Label1"
        ' 
        ' frmSearch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(531, 247)
        Controls.Add(Label1)
        Controls.Add(btnEnter)
        Controls.Add(btnClear)
        Controls.Add(btnReturn)
        Controls.Add(txbLastName)
        Controls.Add(lblChildNameID)
        Name = "frmSearch"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search for Child"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbLastName As TextBox
    Friend WithEvents lblChildNameID As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents Label1 As Label
End Class
