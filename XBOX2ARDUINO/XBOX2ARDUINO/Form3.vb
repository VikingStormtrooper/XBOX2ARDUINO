Public Class frmOutputs

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        ' Closes form
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ' Closes form and assigns user-defined data to main form
        If checkStrings() = False Then
            If txtActL1.Text <> "" Then
                LeftMotorSpeed1 = tkbL1.Value / 10
                LeftMotorActivationWord1 = txtActL1.Text
            End If
            If txtActL2.Text <> "" Then
                LeftMotorSpeed2 = tkbL2.Value / 10
                LeftMotorActivationWord2 = txtActL2.Text
            End If
            If txtDeact.Text <> "" Then
                MotorDeactivationWord = txtDeact.Text
            End If
            If txtActR2.Text <> "" Then
                RightMotorSpeed2 = tkbR2.Value / 10
                RightMotorActivationWord2 = txtActR2.Text
            End If
            If txtActR1.Text <> "" Then
                RightMotorSpeed1 = tkbR1.Value / 10
                RightMotorActivationWord1 = txtActR1.Text
            End If

            Me.Close()
        Else
            MsgBox("Strings have to be different.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub tkbL1_Scroll(sender As Object, e As EventArgs) Handles tkbL1.Scroll
        lblL1.Text = tkbL1.Value / 10
    End Sub

    Private Sub tkbR1_Scroll(sender As Object, e As EventArgs) Handles tkbR1.Scroll
        lblR1.Text = tkbR1.Value / 10
    End Sub

    Private Sub tkbL2_Scroll(sender As Object, e As EventArgs) Handles tkbL2.Scroll
        lblL2.Text = tkbL2.Value / 10
    End Sub

    Private Sub tkbR2_Scroll(sender As Object, e As EventArgs) Handles tkbR2.Scroll
        lblR2.Text = tkbR2.Value / 10
    End Sub

    Function checkStrings() As Boolean
        Dim txt1 As String
        Dim txt2 As String
        Dim txt3 As String
        Dim txt4 As String
        Dim txt5 As String

        txt1 = txtActL1.Text
        txt2 = txtActL2.Text
        txt3 = txtActR1.Text
        txt4 = txtActR2.Text
        txt5 = txtDeact.Text

        If (txt1 = txt2 And txt1 <> "") Or (txt1 = txt3 And txt1 <> "") Or (txt1 = txt4 And txt1 <> "") Or (txt1 = txt5 And txt1 <> "") Or (txt2 = txt3 And txt2 <> "") Or (txt2 = txt4 And txt2 <> "") Or (txt2 = txt5 And txt2 <> "") Or (txt3 = txt4 And txt3 <> "") Or (txt3 = txt5 And txt3 <> "") Or (txt4 = txt5 And txt4 <> "") Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub frmOutputs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtActL1.Text = LeftMotorActivationWord1
        txtActL2.Text = LeftMotorActivationWord2
        txtActR1.Text = RightMotorActivationWord1
        txtActR2.Text = RightMotorActivationWord2
        txtDeact.Text = MotorDeactivationWord
        tkbL1.Value = LeftMotorSpeed1 * 10
        tkbL2.Value = LeftMotorSpeed2 * 10
        tkbR1.Value = RightMotorSpeed1 * 10
        tkbR2.Value = RightMotorSpeed2 * 10
        lblL1.Text = tkbL1.Value / 10
        lblR1.Text = tkbR1.Value / 10
        lblL2.Text = tkbL2.Value / 10
        lblR2.Text = tkbR2.Value / 10
    End Sub
End Class