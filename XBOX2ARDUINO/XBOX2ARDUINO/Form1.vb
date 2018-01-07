' VB program to communicate with Arduino via serial interface
' Thanks to Martyn Currey for providing his tutorials:
' http://www.martyncurrey.com/arduino-and-visual-basic-part-1-receiving-data-from-the-arduino/
' http://www.martyncurrey.com/arduino-and-visual-basic-part-3-controlling-an-arduino/

Imports System
Imports System.IO.Ports
Imports Microsoft.Xna.Framework.Input

Public Class frmXBOX2ARDUINO
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim connected As Boolean = False
    Dim selectedController As Microsoft.Xna.Framework.PlayerIndex

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize timer, comPORT value, and COM ports list
        timIO.Enabled = False
        timXBOX.Enabled = True
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOM.Items.Add(sp)
        Next
        cmbController.SelectedItem = "Player 1"
        cmbControllerRefreshTime.SelectedItem = "50 ms"
        cmbRXRefreshTime.SelectedItem = "1 s"
    End Sub

    Private Sub refresh_BTN_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        ' Refresh COM ports list after pressing Refresh button
        cmbCOM.Items.Clear()
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cmbCOM.Items.Add(sp)
        Next
    End Sub

    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCOM.SelectedIndexChanged
        ' Updates comPORT value after changing selection in COM ports list
        If (cmbCOM.SelectedItem <> "") Then
            comPORT = cmbCOM.SelectedItem
        End If
    End Sub

    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles cmdConnect.Click
        If (cmdConnect.Text = "Connect") Then
            ' Opens connection with selected COM port
            If (comPORT <> "") Then
                spt1.Close()
                spt1.PortName = comPORT
                spt1.BaudRate = 9600
                spt1.DataBits = 8
                spt1.Parity = Parity.None
                spt1.StopBits = StopBits.One
                spt1.Handshake = Handshake.None
                spt1.Encoding = System.Text.Encoding.Default
                spt1.ReadTimeout = 10000
                spt1.Open()
                cmdConnect.Text = "Disconnect"
                timIO.Enabled = True
                connected = True
                cmdSend.Enabled = True
            Else
                MsgBox("Select a COM port first.", vbExclamation)
            End If
        Else
            ' Closes connection with selected COM port
            spt1.Close()
            cmdConnect.Text = "Connect"
            timIO.Enabled = False
            connected = False
            cmdSend.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timIO.Tick
        ' Periodically updates received messages list
        Dim dateTimeIndication As String
        Dim receivedDataLength As Integer
        Dim dateTimeLength As Integer
        Dim startPos As Integer

        receivedData = ReceiveSerialData()
        receivedDataLength = receivedData.Length
        If receivedDataLength > 0 Then
            dateTimeIndication = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") & ": "
            dateTimeLength = dateTimeIndication.Length

            startPos = rtbRX.TextLength
            rtbRX.AppendText(dateTimeIndication)
            rtbRX.Select(startPos, dateTimeLength)
            rtbRX.SelectionColor = Color.Red
            startPos = rtbRX.TextLength
            rtbRX.AppendText(receivedData)
            lblTest.Text = receivedData.Substring(0, 4)
            rtbRX.Select(startPos, receivedDataLength)
            rtbRX.SelectionColor = Color.Black
        End If

        If lblTest.Text = LeftMotorActivationWord1 Then
            GamePad.SetVibration(selectedController, LeftMotorSpeed1, 0)
        End If
        If lblTest.Text = LeftMotorActivationWord2 Then
            GamePad.SetVibration(selectedController, LeftMotorSpeed2, 0)
        End If
        If lblTest.Text = RightMotorActivationWord1 Then
            GamePad.SetVibration(selectedController, 0, RightMotorSpeed1)
        End If
        If lblTest.Text = RightMotorActivationWord2 Then
            GamePad.SetVibration(selectedController, 0, RightMotorSpeed2)
        End If
        If lblTest.Text = MotorDeactivationWord Then
            GamePad.SetVibration(selectedController, 0, 0)
        End If

    End Sub

    Function ReceiveSerialData() As String
        ' Reads strings from the connected Arduino
        Dim Incoming As String
        Try
            Incoming = spt1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function

    Private Sub send_BTN_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
        ' Sends user-defined strings to Arduino
        If (connected) Then
            Dim tmp As String
            Dim dateTimeIndication As String
            Dim tmpLength As Integer
            Dim dateTimeLength As Integer
            Dim startPos As Integer

            dateTimeIndication = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") & ": "
            dateTimeLength = dateTimeIndication.Length
            tmp = txtSend.Text
            tmpLength = tmp.Length
            spt1.WriteLine(tmp)
            tmp = tmp & vbCrLf

            startPos = rtbTX.TextLength
            rtbTX.AppendText(dateTimeIndication)
            rtbTX.Select(startPos, dateTimeLength)
            rtbTX.SelectionColor = Color.Blue
            startPos = rtbTX.TextLength
            rtbTX.AppendText(tmp)
            rtbTX.Select(startPos, tmpLength)
            rtbTX.SelectionColor = Color.Black
        End If
    End Sub

    Private Sub clear_BTN_Click(sender As Object, e As EventArgs) Handles cmdClearRX.Click
        ' Clears RX messages list
        rtbRX.Text = ""
    End Sub

    Private Sub clear_BTN2_Click(sender As Object, e As EventArgs) Handles cmdClearTX.Click
        ' Clears TX messages list
        rtbTX.Text = ""
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtbRX.TextChanged
        ' Sets the current caret position to the end
        rtbRX.SelectionStart = rtbRX.TextLength
        ' Scrolls RichTextBox automatically
        rtbRX.ScrollToCaret()
    End Sub
    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs) Handles rtbTX.TextChanged
        ' Sets the current caret position to the end
        rtbTX.SelectionStart = rtbTX.TextLength
        ' Scrolls RichTextBox automatically
        rtbTX.ScrollToCaret()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timXBOX.Tick
        ' Periodically updates connection state of the selected Xbox 360 controller

        Dim LT As Single
        Dim RT As Single
        Dim LSX As Single
        Dim RSX As Single
        Dim LSY As Single
        Dim RSY As Single

        Select Case cmbController.SelectedItem
            Case "Player 1"
                selectedController = Microsoft.Xna.Framework.PlayerIndex.One
                picController.Image = pic1.Image
            Case "Player 2"
                selectedController = Microsoft.Xna.Framework.PlayerIndex.Two
                picController.Image = pic2.Image
            Case "Player 3"
                selectedController = Microsoft.Xna.Framework.PlayerIndex.Three
                picController.Image = pic3.Image
            Case "Player 4"
                selectedController = Microsoft.Xna.Framework.PlayerIndex.Four
                picController.Image = pic4.Image
        End Select

        LT = GamePad.GetState(selectedController).Triggers.Left
        RT = GamePad.GetState(selectedController).Triggers.Right
        RSX = GamePad.GetState(selectedController).ThumbSticks.Right.X
        RSY = GamePad.GetState(selectedController).ThumbSticks.Right.Y
        LSY = GamePad.GetState(selectedController).ThumbSticks.Left.Y
        LSX = GamePad.GetState(selectedController).ThumbSticks.Left.X

        chkDetected.Checked = GamePad.GetState(selectedController).IsConnected
        chkX.Checked = GamePad.GetState(selectedController).Buttons.X
        chkY.Checked = GamePad.GetState(selectedController).Buttons.Y
        chkA.Checked = GamePad.GetState(selectedController).Buttons.A
        chkB.Checked = GamePad.GetState(selectedController).Buttons.B
        chkLB.Checked = GamePad.GetState(selectedController).Buttons.LeftShoulder
        chkRB.Checked = GamePad.GetState(selectedController).Buttons.RightShoulder
        lblLT.Text = String.Concat("LT: ", LT)
        lblRT.Text = String.Concat("RT: ", RT)
        chkRS.Checked = GamePad.GetState(selectedController).Buttons.RightStick
        chkLS.Checked = GamePad.GetState(selectedController).Buttons.LeftStick
        chkST.Checked = GamePad.GetState(selectedController).Buttons.Start
        chkBA.Checked = GamePad.GetState(selectedController).Buttons.Back
        chkPD.Checked = GamePad.GetState(selectedController).DPad.Down
        chkPU.Checked = GamePad.GetState(selectedController).DPad.Up
        chkPL.Checked = GamePad.GetState(selectedController).DPad.Left
        chkPR.Checked = GamePad.GetState(selectedController).DPad.Right
        lblRSY.Text = String.Concat("RSY: ", RSY)
        lblRSX.Text = String.Concat("RSX: ", RSX)
        lblLSY.Text = String.Concat("LSY: ", LSY)
        lblLSX.Text = String.Concat("LSX: ", LSX)

        ' Sends character to Arduino when activating mapped inputs
        If A_char <> Chr(0) And chkA.Checked = True And timIO.Enabled = True Then
            sendCharacter(A_char)
        End If
        If B_char <> Chr(0) And chkB.Checked = True And timIO.Enabled = True Then
            sendCharacter(B_char)
        End If
        If X_char <> Chr(0) And chkX.Checked = True And timIO.Enabled = True Then
            sendCharacter(X_char)
        End If
        If Y_char <> Chr(0) And chkY.Checked = True And timIO.Enabled = True Then
            sendCharacter(Y_char)
        End If
        If LB_char <> Chr(0) And chkLB.Checked = True And timIO.Enabled = True Then
            sendCharacter(LB_char)
        End If
        If RB_char <> Chr(0) And chkRB.Checked = True And timIO.Enabled = True Then
            sendCharacter(RB_char)
        End If
        If LS_char <> Chr(0) And chkLS.Checked = True And timIO.Enabled = True Then
            sendCharacter(LS_char)
        End If
        If RS_char <> Chr(0) And chkRS.Checked = True And timIO.Enabled = True Then
            sendCharacter(RS_char)
        End If
        If BA_char <> Chr(0) And chkBA.Checked = True And timIO.Enabled = True Then
            sendCharacter(BA_char)
        End If
        If ST_char <> Chr(0) And chkST.Checked = True And timIO.Enabled = True Then
            sendCharacter(ST_char)
        End If
        If PU_char <> Chr(0) And chkPU.Checked = True And timIO.Enabled = True Then
            sendCharacter(PU_char)
        End If
        If PD_char <> Chr(0) And chkPD.Checked = True And timIO.Enabled = True Then
            sendCharacter(PD_char)
        End If
        If PR_char <> Chr(0) And chkPR.Checked = True And timIO.Enabled = True Then
            sendCharacter(PR_char)
        End If
        If PL_char <> Chr(0) And chkPL.Checked = True And timIO.Enabled = True Then
            sendCharacter(PL_char)
        End If
        If LT1_char <> Chr(0) And LT >= 0.33 And LT < 0.66 And timIO.Enabled = True Then
            sendCharacter(LT1_char)
        End If
        If LT2_char <> Chr(0) And LT >= 0.66 And LT <= 1 And timIO.Enabled = True Then
            sendCharacter(LT2_char)
        End If
        If RT1_char <> Chr(0) And RT >= 0.33 And RT < 0.66 And timIO.Enabled = True Then
            sendCharacter(RT1_char)
        End If
        If RT2_char <> Chr(0) And RT >= 0.66 And RT <= 1 And timIO.Enabled = True Then
            sendCharacter(RT2_char)
        End If
        If LSX0_char <> Chr(0) And LSX <= -0.33 And timIO.Enabled = True Then
            sendCharacter(LSX0_char)
        End If
        If LSX2_char <> Chr(0) And LSX >= 0.33 And timIO.Enabled = True Then
            sendCharacter(LSX2_char)
        End If
        If RSX0_char <> Chr(0) And RSX <= -0.33 And timIO.Enabled = True Then
            sendCharacter(RSX0_char)
        End If
        If RSX2_char <> Chr(0) And RSX >= 0.33 And timIO.Enabled = True Then
            sendCharacter(RSX2_char)
        End If
        If LSY0_char <> Chr(0) And LSY <= -0.33 And timIO.Enabled = True Then
            sendCharacter(LSY0_char)
        End If
        If LSY2_char <> Chr(0) And LSY >= 0.33 And timIO.Enabled = True Then
            sendCharacter(LSY2_char)
        End If
        If RSY0_char <> Chr(0) And RSY <= -0.33 And timIO.Enabled = True Then
            sendCharacter(RSY0_char)
        End If
        If RSY2_char <> Chr(0) And RSY >= 0.33 And timIO.Enabled = True Then
            sendCharacter(RSY2_char)
        End If

    End Sub

    Private Sub sendCharacter(keyChar As Char)

        Dim tmp As Char
        Dim dateTimeIndication As String
        Dim dateTimeLength As Integer
        Dim tmpLength As Integer
        Dim startPos As Integer

        dateTimeIndication = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") & ": "
        dateTimeLength = dateTimeIndication.Length
        tmp = keyChar & vbCrLf
        tmpLength = 1
        spt1.WriteLine(tmp)

        startPos = rtbTX.TextLength
        rtbTX.AppendText(dateTimeIndication)
        rtbTX.Select(startPos, dateTimeLength)
        rtbTX.SelectionColor = Color.Blue
        startPos = rtbTX.TextLength
        rtbTX.AppendText(tmp)
        rtbTX.Select(startPos, tmpLength)
        rtbTX.SelectionColor = Color.Black

    End Sub

    Private Sub cmdInputs_Click(sender As Object, e As EventArgs) Handles cmdInputs.Click
        frmInputs.Show()
    End Sub

    Private Sub cmdOutputs_Click(sender As Object, e As EventArgs) Handles cmdOutputs.Click
        frmOutputs.Show()
    End Sub

    Private Sub chkLV_CheckedChanged(sender As Object, e As EventArgs) Handles chkLV.CheckedChanged
        tkbL.Enabled = chkLV.Checked
        If tkbL.Enabled = False Then
            GamePad.SetVibration(selectedController, 0, 0)
        Else
            GamePad.SetVibration(selectedController, tkbL.Value / 10, 0)
        End If
    End Sub

    Private Sub chkRV_CheckedChanged(sender As Object, e As EventArgs) Handles chkRV.CheckedChanged
        tkbR.Enabled = chkRV.Checked
        If tkbR.Enabled = False Then
            GamePad.SetVibration(selectedController, 0, 0)
        Else
            GamePad.SetVibration(selectedController, 0, tkbR.Value / 10)
        End If
    End Sub

    Private Sub tkbL_Scroll(sender As Object, e As EventArgs) Handles tkbL.Scroll
        GamePad.SetVibration(selectedController, tkbL.Value / 10, 0)
    End Sub

    Private Sub tkbR_Scroll(sender As Object, e As EventArgs) Handles tkbR.Scroll
        GamePad.SetVibration(selectedController, 0, tkbR.Value / 10)
    End Sub

    Private Sub cmbControllerRefreshTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbControllerRefreshTime.SelectedIndexChanged
        Select Case cmbControllerRefreshTime.Text
            Case "50 ms"
                timXBOX.Interval = 50
            Case "100 ms"
                timXBOX.Interval = 100
            Case "200 ms"
                timXBOX.Interval = 200
            Case "500 ms"
                timXBOX.Interval = 500
            Case "1 s"
                timXBOX.Interval = 1000
        End Select
    End Sub

    Private Sub cmbRXRefreshTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRXRefreshTime.SelectedIndexChanged
        Select Case cmbRXRefreshTime.Text
            Case "50 ms"
                timIO.Interval = 50
            Case "100 ms"
                timIO.Interval = 100
            Case "200 ms"
                timIO.Interval = 200
            Case "500 ms"
                timIO.Interval = 500
            Case "1 s"
                timIO.Interval = 1000
        End Select
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
    End Sub
End Class