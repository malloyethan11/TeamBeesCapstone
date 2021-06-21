﻿Public Class frmCheckout

    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        For Each Control In Controls
            If Control.GetType() = GetType(Button) Then
                Control.FlatStyle = FlatStyle.Flat
                Control.ForeColor = BackColor
                Control.FlatAppearance.BorderColor = BackColor
                Control.FlatAppearance.MouseOverBackColor = BackColor
                Control.FlatAppearance.MouseDownBackColor = BackColor
            End If
        Next

        dtpExpirationDate.Format = DateTimePickerFormat.Custom
        dtpExpirationDate.CustomFormat = "MM/yyyy"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        OpenFormKillParent(Me, frmTransactions)

    End Sub

    Private Sub btnItemLookup_Click(sender As Object, e As EventArgs) Handles btnItemLookup.Click

        Dim intItem As Integer

        Dim frmLookup As New frmItemLookup

        OpenFormMaintainParent(Me, frmLookup)

        ' Get the selected item
        intItem = frmLookup.intPrimaryKeyReturnValue

    End Sub
End Class