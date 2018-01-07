Public Class frmInputs

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        ' Closes form
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ' Closes form and updates key mapping
        A_char = txtSendCA.Text
        B_char = txtSendCB.Text
        X_char = txtSendCX.Text
        Y_char = txtSendCY.Text
        LB_char = txtSendCLB.Text
        RB_char = txtSendCRB.Text
        LS_char = txtSendCLS.Text
        RS_char = txtSendCRS.Text
        PU_char = txtSendCPU.Text
        PD_char = txtSendCPD.Text
        PL_char = txtSendCPL.Text
        PR_char = txtSendCPR.Text
        BA_char = txtSendCBA.Text
        ST_char = txtSendCST.Text
        LT1_char = txtSendCLT1.Text
        LT2_char = txtSendCLT2.Text
        RT1_char = txtSendCRT1.Text
        RT2_char = txtSendCRT2.Text
        LSX0_char = txtSendCLSX0.Text
        LSX2_char = txtSendCLSX2.Text
        RSX0_char = txtSendCRSX0.Text
        RSX2_char = txtSendCRSX2.Text
        LSY0_char = txtSendCLSY0.Text
        LSY2_char = txtSendCLSY2.Text
        RSY0_char = txtSendCRSY0.Text
        RSY2_char = txtSendCRSY2.Text
        Me.Close()
    End Sub

    Private Sub l_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Reloads the existing mapping when reopening this form
        txtSendCA.Text = A_char
        txtSendCB.Text = B_char
        txtSendCX.Text = X_char
        txtSendCY.Text = Y_char
        txtSendCLB.Text = LB_char
        txtSendCRB.Text = RB_char
        txtSendCLS.Text = LS_char
        txtSendCRS.Text = RS_char
        txtSendCPU.Text = PU_char
        txtSendCPD.Text = PD_char
        txtSendCPL.Text = PL_char
        txtSendCPR.Text = PR_char
        txtSendCBA.Text = BA_char
        txtSendCST.Text = ST_char
        txtSendCLT1.Text = LT1_char
        txtSendCLT2.Text = LT2_char
        txtSendCRT1.Text = RT1_char
        txtSendCRT2.Text = RT2_char
        txtSendCLSX0.Text = LSX0_char
        txtSendCLSX2.Text = LSX2_char
        txtSendCRSX0.Text = RSX0_char
        txtSendCRSX2.Text = RSX2_char
        txtSendCLSY0.Text = LSY0_char
        txtSendCLSY2.Text = LSY2_char
        txtSendCRSY0.Text = RSY0_char
        txtSendCRSY2.Text = RSY2_char
    End Sub
End Class