﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReturn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReturn))
        Me.btnRemoveSelectedItem = New System.Windows.Forms.Button()
        Me.btnItemLookup = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPaymentDetails = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtSecurity = New System.Windows.Forms.TextBox()
        Me.lblSecurityCode = New System.Windows.Forms.Label()
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker()
        Me.lblExpDate = New System.Windows.Forms.Label()
        Me.lblCred = New System.Windows.Forms.Label()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblReturn = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblList = New System.Windows.Forms.Label()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.StepAction = New System.Windows.Forms.Timer(Me.components)
        Me.lblPaymentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemoveSelectedItem
        '
        Me.btnRemoveSelectedItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveSelectedItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveSelectedItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveSelectedItem.Image = Global.CashRegister.My.Resources.Resources.Button
        Me.btnRemoveSelectedItem.Location = New System.Drawing.Point(499, 172)
        Me.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem"
        Me.btnRemoveSelectedItem.Size = New System.Drawing.Size(284, 42)
        Me.btnRemoveSelectedItem.TabIndex = 13
        Me.btnRemoveSelectedItem.Text = "Remove Selected Item"
        Me.btnRemoveSelectedItem.UseVisualStyleBackColor = True
        '
        'btnItemLookup
        '
        Me.btnItemLookup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnItemLookup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItemLookup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItemLookup.Image = Global.CashRegister.My.Resources.Resources.Button
        Me.btnItemLookup.Location = New System.Drawing.Point(499, 12)
        Me.btnItemLookup.Name = "btnItemLookup"
        Me.btnItemLookup.Size = New System.Drawing.Size(284, 42)
        Me.btnItemLookup.TabIndex = 12
        Me.btnItemLookup.Text = "Item Lookup"
        Me.btnItemLookup.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Image = Global.CashRegister.My.Resources.Resources.Button
        Me.btnSubmit.Location = New System.Drawing.Point(499, 289)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(284, 42)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = Global.CashRegister.My.Resources.Resources.ButtonShort
        Me.btnExit.Location = New System.Drawing.Point(12, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 42)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPaymentDetails
        '
        Me.lblPaymentDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPaymentDetails.Controls.Add(Me.Label4)
        Me.lblPaymentDetails.Controls.Add(Me.txtPhoneNumber)
        Me.lblPaymentDetails.Controls.Add(Me.txtAddress)
        Me.lblPaymentDetails.Controls.Add(Me.lblState)
        Me.lblPaymentDetails.Controls.Add(Me.lblAddress)
        Me.lblPaymentDetails.Controls.Add(Me.txtEmail)
        Me.lblPaymentDetails.Controls.Add(Me.lblEmail)
        Me.lblPaymentDetails.Controls.Add(Me.lblZip)
        Me.lblPaymentDetails.Controls.Add(Me.txtZip)
        Me.lblPaymentDetails.Controls.Add(Me.txtCity)
        Me.lblPaymentDetails.Controls.Add(Me.lblCity)
        Me.lblPaymentDetails.Controls.Add(Me.txtSecurity)
        Me.lblPaymentDetails.Controls.Add(Me.lblSecurityCode)
        Me.lblPaymentDetails.Controls.Add(Me.dtpExpirationDate)
        Me.lblPaymentDetails.Controls.Add(Me.lblExpDate)
        Me.lblPaymentDetails.Controls.Add(Me.lblCred)
        Me.lblPaymentDetails.Controls.Add(Me.txtCredit)
        Me.lblPaymentDetails.Controls.Add(Me.lblLastName)
        Me.lblPaymentDetails.Controls.Add(Me.txtLastName)
        Me.lblPaymentDetails.Controls.Add(Me.lblFirstName)
        Me.lblPaymentDetails.Controls.Add(Me.txtFirstName)
        Me.lblPaymentDetails.Controls.Add(Me.lblPaymentType)
        Me.lblPaymentDetails.Controls.Add(Me.cboState)
        Me.lblPaymentDetails.Controls.Add(Me.cboPayment)
        Me.lblPaymentDetails.Location = New System.Drawing.Point(13, 12)
        Me.lblPaymentDetails.Name = "lblPaymentDetails"
        Me.lblPaymentDetails.Size = New System.Drawing.Size(485, 260)
        Me.lblPaymentDetails.TabIndex = 66
        Me.lblPaymentDetails.TabStop = False
        Me.lblPaymentDetails.Text = "Payment Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Phone Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(90, 226)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(389, 20)
        Me.txtPhoneNumber.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(90, 124)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(389, 20)
        Me.txtAddress.TabIndex = 6
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(280, 153)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 96
        Me.lblState.Text = "State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(5, 127)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblAddress.TabIndex = 95
        Me.lblAddress.Text = "Street Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(90, 200)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(389, 20)
        Me.txtEmail.TabIndex = 10
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(8, 203)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(76, 13)
        Me.lblEmail.TabIndex = 94
        Me.lblEmail.Text = "Email Address:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(31, 179)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(53, 13)
        Me.lblZip.TabIndex = 93
        Me.lblZip.Text = "Zip Code:"
        Me.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(90, 176)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(390, 20)
        Me.txtZip.TabIndex = 9
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(90, 150)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(158, 20)
        Me.txtCity.TabIndex = 7
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(57, 153)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 92
        Me.lblCity.Text = "City:"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSecurity
        '
        Me.txtSecurity.Enabled = False
        Me.txtSecurity.Location = New System.Drawing.Point(277, 98)
        Me.txtSecurity.Name = "txtSecurity"
        Me.txtSecurity.Size = New System.Drawing.Size(202, 20)
        Me.txtSecurity.TabIndex = 5
        '
        'lblSecurityCode
        '
        Me.lblSecurityCode.AutoSize = True
        Me.lblSecurityCode.Enabled = False
        Me.lblSecurityCode.Location = New System.Drawing.Point(195, 101)
        Me.lblSecurityCode.Name = "lblSecurityCode"
        Me.lblSecurityCode.Size = New System.Drawing.Size(76, 13)
        Me.lblSecurityCode.TabIndex = 91
        Me.lblSecurityCode.Text = "Security Code:"
        Me.lblSecurityCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.Enabled = False
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(90, 98)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(99, 20)
        Me.dtpExpirationDate.TabIndex = 4
        Me.dtpExpirationDate.Value = New Date(2021, 1, 21, 0, 0, 0, 0)
        '
        'lblExpDate
        '
        Me.lblExpDate.AutoSize = True
        Me.lblExpDate.Enabled = False
        Me.lblExpDate.Location = New System.Drawing.Point(2, 101)
        Me.lblExpDate.Name = "lblExpDate"
        Me.lblExpDate.Size = New System.Drawing.Size(82, 13)
        Me.lblExpDate.TabIndex = 90
        Me.lblExpDate.Text = "Expiration Date:"
        Me.lblExpDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCred
        '
        Me.lblCred.AutoSize = True
        Me.lblCred.Enabled = False
        Me.lblCred.Location = New System.Drawing.Point(6, 75)
        Me.lblCred.Name = "lblCred"
        Me.lblCred.Size = New System.Drawing.Size(102, 13)
        Me.lblCred.TabIndex = 89
        Me.lblCred.Text = "Credit Card Number:"
        Me.lblCred.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCredit
        '
        Me.txtCredit.Enabled = False
        Me.txtCredit.Location = New System.Drawing.Point(114, 72)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(365, 20)
        Me.txtCredit.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(254, 49)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 88
        Me.lblLastName.Text = "Last Name:"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(320, 46)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(159, 20)
        Me.txtLastName.TabIndex = 2
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(24, 48)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 87
        Me.lblFirstName.Text = "First Name:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(90, 46)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(158, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'lblPaymentType
        '
        Me.lblPaymentType.AutoSize = True
        Me.lblPaymentType.Location = New System.Drawing.Point(6, 22)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(78, 13)
        Me.lblPaymentType.TabIndex = 86
        Me.lblPaymentType.Text = "Payment Type:"
        Me.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(320, 149)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(159, 21)
        Me.cboState.TabIndex = 8
        '
        'cboPayment
        '
        Me.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Items.AddRange(New Object() {"Select a Payment Type", "Cash", "Credit"})
        Me.cboPayment.Location = New System.Drawing.Point(90, 19)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(389, 21)
        Me.cboPayment.TabIndex = 0
        '
        'lblSalesTax
        '
        Me.lblSalesTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSalesTax.Location = New System.Drawing.Point(504, 249)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(105, 23)
        Me.lblSalesTax.TabIndex = 65
        Me.lblSalesTax.Text = "Sales Tax Returned:"
        Me.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTax
        '
        Me.txtTax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTax.Location = New System.Drawing.Point(615, 251)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(159, 20)
        Me.txtTax.TabIndex = 64
        Me.txtTax.TabStop = False
        '
        'lblReturn
        '
        Me.lblReturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblReturn.Location = New System.Drawing.Point(504, 223)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(75, 23)
        Me.lblReturn.TabIndex = 63
        Me.lblReturn.Text = "Total Return:"
        Me.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrice.Location = New System.Drawing.Point(615, 225)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(159, 20)
        Me.txtPrice.TabIndex = 14
        '
        'lblList
        '
        Me.lblList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblList.Location = New System.Drawing.Point(504, 61)
        Me.lblList.Name = "lblList"
        Me.lblList.Size = New System.Drawing.Size(279, 23)
        Me.lblList.TabIndex = 62
        Me.lblList.Text = "Purchase List:"
        Me.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstItems
        '
        Me.lstItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(504, 87)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(270, 69)
        Me.lstItems.TabIndex = 61
        Me.lstItems.TabStop = False
        '
        'StepAction
        '
        Me.StepAction.Enabled = True
        '
        'frmReturn
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 343)
        Me.Controls.Add(Me.btnRemoveSelectedItem)
        Me.Controls.Add(Me.btnItemLookup)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPaymentDetails)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblReturn)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblList)
        Me.Controls.Add(Me.lstItems)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReturn"
        Me.Text = "Returns"
        Me.lblPaymentDetails.ResumeLayout(False)
        Me.lblPaymentDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRemoveSelectedItem As Button
    Friend WithEvents btnItemLookup As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPaymentDetails As GroupBox
    Friend WithEvents lblSalesTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblReturn As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblList As Label
    Friend WithEvents lstItems As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtSecurity As TextBox
    Friend WithEvents lblSecurityCode As Label
    Friend WithEvents dtpExpirationDate As DateTimePicker
    Friend WithEvents lblExpDate As Label
    Friend WithEvents lblCred As Label
    Friend WithEvents txtCredit As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents StepAction As Timer
End Class
