<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXBOX2ARDUINO
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXBOX2ARDUINO))
        Me.cmbCOM = New System.Windows.Forms.ComboBox()
        Me.lblCOM = New System.Windows.Forms.Label()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.cmdClearRX = New System.Windows.Forms.Button()
        Me.timIO = New System.Windows.Forms.Timer(Me.components)
        Me.rtbRX = New System.Windows.Forms.RichTextBox()
        Me.spt1 = New System.IO.Ports.SerialPort(Me.components)
        Me.lblRX = New System.Windows.Forms.Label()
        Me.rtbTX = New System.Windows.Forms.RichTextBox()
        Me.lblTX = New System.Windows.Forms.Label()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.cmdClearTX = New System.Windows.Forms.Button()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.picController = New System.Windows.Forms.PictureBox()
        Me.chkDetected = New System.Windows.Forms.CheckBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.timXBOX = New System.Windows.Forms.Timer(Me.components)
        Me.chkX = New System.Windows.Forms.CheckBox()
        Me.chkB = New System.Windows.Forms.CheckBox()
        Me.chkY = New System.Windows.Forms.CheckBox()
        Me.chkA = New System.Windows.Forms.CheckBox()
        Me.chkLB = New System.Windows.Forms.CheckBox()
        Me.chkRB = New System.Windows.Forms.CheckBox()
        Me.lblLT = New System.Windows.Forms.Label()
        Me.lblRT = New System.Windows.Forms.Label()
        Me.chkLS = New System.Windows.Forms.CheckBox()
        Me.chkRS = New System.Windows.Forms.CheckBox()
        Me.chkBA = New System.Windows.Forms.CheckBox()
        Me.chkST = New System.Windows.Forms.CheckBox()
        Me.chkPD = New System.Windows.Forms.CheckBox()
        Me.chkPU = New System.Windows.Forms.CheckBox()
        Me.chkPL = New System.Windows.Forms.CheckBox()
        Me.chkPR = New System.Windows.Forms.CheckBox()
        Me.lblRSY = New System.Windows.Forms.Label()
        Me.lblRSX = New System.Windows.Forms.Label()
        Me.lblLSY = New System.Windows.Forms.Label()
        Me.lblLSX = New System.Windows.Forms.Label()
        Me.lblController = New System.Windows.Forms.Label()
        Me.cmbController = New System.Windows.Forms.ComboBox()
        Me.cmdInputs = New System.Windows.Forms.Button()
        Me.cmdOutputs = New System.Windows.Forms.Button()
        Me.tkbL = New System.Windows.Forms.TrackBar()
        Me.tkbR = New System.Windows.Forms.TrackBar()
        Me.chkLV = New System.Windows.Forms.CheckBox()
        Me.chkRV = New System.Windows.Forms.CheckBox()
        Me.lblControllerRefreshPeriod = New System.Windows.Forms.Label()
        Me.cmbControllerRefreshTime = New System.Windows.Forms.ComboBox()
        Me.lblRXRefreshPeriod = New System.Windows.Forms.Label()
        Me.cmbRXRefreshTime = New System.Windows.Forms.ComboBox()
        Me.lblTest = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.cmdAbout = New System.Windows.Forms.Button()
        CType(Me.picController, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tkbR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCOM
        '
        Me.cmbCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCOM.FormattingEnabled = True
        Me.cmbCOM.Location = New System.Drawing.Point(90, 17)
        Me.cmbCOM.Name = "cmbCOM"
        Me.cmbCOM.Size = New System.Drawing.Size(101, 24)
        Me.cmbCOM.TabIndex = 0
        '
        'lblCOM
        '
        Me.lblCOM.AutoSize = True
        Me.lblCOM.Location = New System.Drawing.Point(12, 20)
        Me.lblCOM.Name = "lblCOM"
        Me.lblCOM.Size = New System.Drawing.Size(72, 17)
        Me.lblCOM.TabIndex = 1
        Me.lblCOM.Text = "COM port:"
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(206, 13)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(122, 30)
        Me.cmdConnect.TabIndex = 2
        Me.cmdConnect.Text = "Connect"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'cmdClearRX
        '
        Me.cmdClearRX.Location = New System.Drawing.Point(89, 618)
        Me.cmdClearRX.Name = "cmdClearRX"
        Me.cmdClearRX.Size = New System.Drawing.Size(115, 29)
        Me.cmdClearRX.TabIndex = 4
        Me.cmdClearRX.Text = "Clear"
        Me.cmdClearRX.UseVisualStyleBackColor = True
        '
        'timIO
        '
        Me.timIO.Interval = 1000
        '
        'rtbRX
        '
        Me.rtbRX.BackColor = System.Drawing.Color.White
        Me.rtbRX.Location = New System.Drawing.Point(14, 100)
        Me.rtbRX.Name = "rtbRX"
        Me.rtbRX.ReadOnly = True
        Me.rtbRX.Size = New System.Drawing.Size(281, 512)
        Me.rtbRX.TabIndex = 6
        Me.rtbRX.Text = ""
        '
        'spt1
        '
        Me.spt1.DtrEnable = True
        Me.spt1.RtsEnable = True
        '
        'lblRX
        '
        Me.lblRX.AutoSize = True
        Me.lblRX.Location = New System.Drawing.Point(11, 71)
        Me.lblRX.Name = "lblRX"
        Me.lblRX.Size = New System.Drawing.Size(155, 17)
        Me.lblRX.TabIndex = 7
        Me.lblRX.Text = "RX - Data from Arduino"
        '
        'rtbTX
        '
        Me.rtbTX.BackColor = System.Drawing.Color.White
        Me.rtbTX.Location = New System.Drawing.Point(318, 100)
        Me.rtbTX.Name = "rtbTX"
        Me.rtbTX.ReadOnly = True
        Me.rtbTX.Size = New System.Drawing.Size(281, 484)
        Me.rtbTX.TabIndex = 8
        Me.rtbTX.Text = ""
        '
        'lblTX
        '
        Me.lblTX.AutoSize = True
        Me.lblTX.Location = New System.Drawing.Point(315, 71)
        Me.lblTX.Name = "lblTX"
        Me.lblTX.Size = New System.Drawing.Size(138, 17)
        Me.lblTX.TabIndex = 9
        Me.lblTX.Text = "TX - Data to Arduino"
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(318, 590)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(214, 22)
        Me.txtSend.TabIndex = 10
        '
        'cmdClearTX
        '
        Me.cmdClearTX.Location = New System.Drawing.Point(405, 618)
        Me.cmdClearTX.Name = "cmdClearTX"
        Me.cmdClearTX.Size = New System.Drawing.Size(115, 29)
        Me.cmdClearTX.TabIndex = 11
        Me.cmdClearTX.Text = "Clear"
        Me.cmdClearTX.UseVisualStyleBackColor = True
        '
        'cmdSend
        '
        Me.cmdSend.Enabled = False
        Me.cmdSend.Location = New System.Drawing.Point(538, 587)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(62, 28)
        Me.cmdSend.TabIndex = 12
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = True
        '
        'picController
        '
        Me.picController.Image = CType(resources.GetObject("picController.Image"), System.Drawing.Image)
        Me.picController.Location = New System.Drawing.Point(624, 16)
        Me.picController.Name = "picController"
        Me.picController.Size = New System.Drawing.Size(729, 681)
        Me.picController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picController.TabIndex = 15
        Me.picController.TabStop = False
        '
        'chkDetected
        '
        Me.chkDetected.AutoSize = True
        Me.chkDetected.Location = New System.Drawing.Point(891, 73)
        Me.chkDetected.Name = "chkDetected"
        Me.chkDetected.Size = New System.Drawing.Size(211, 21)
        Me.chkDetected.TabIndex = 17
        Me.chkDetected.Text = "Xbox 360 controller detected"
        Me.chkDetected.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(345, 13)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(122, 30)
        Me.cmdRefresh.TabIndex = 18
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'timXBOX
        '
        Me.timXBOX.Interval = 50
        '
        'chkX
        '
        Me.chkX.AutoSize = True
        Me.chkX.BackColor = System.Drawing.Color.Black
        Me.chkX.ForeColor = System.Drawing.Color.White
        Me.chkX.Location = New System.Drawing.Point(1125, 215)
        Me.chkX.Name = "chkX"
        Me.chkX.Size = New System.Drawing.Size(39, 21)
        Me.chkX.TabIndex = 19
        Me.chkX.Text = "X"
        Me.chkX.UseVisualStyleBackColor = False
        '
        'chkB
        '
        Me.chkB.AutoSize = True
        Me.chkB.BackColor = System.Drawing.Color.Black
        Me.chkB.ForeColor = System.Drawing.Color.White
        Me.chkB.Location = New System.Drawing.Point(1240, 215)
        Me.chkB.Name = "chkB"
        Me.chkB.Size = New System.Drawing.Size(39, 21)
        Me.chkB.TabIndex = 20
        Me.chkB.Text = "B"
        Me.chkB.UseVisualStyleBackColor = False
        '
        'chkY
        '
        Me.chkY.AutoSize = True
        Me.chkY.BackColor = System.Drawing.Color.Black
        Me.chkY.ForeColor = System.Drawing.Color.White
        Me.chkY.Location = New System.Drawing.Point(1183, 161)
        Me.chkY.Name = "chkY"
        Me.chkY.Size = New System.Drawing.Size(39, 21)
        Me.chkY.TabIndex = 21
        Me.chkY.Text = "Y"
        Me.chkY.UseVisualStyleBackColor = False
        '
        'chkA
        '
        Me.chkA.AutoSize = True
        Me.chkA.BackColor = System.Drawing.Color.Black
        Me.chkA.ForeColor = System.Drawing.Color.White
        Me.chkA.Location = New System.Drawing.Point(1183, 272)
        Me.chkA.Name = "chkA"
        Me.chkA.Size = New System.Drawing.Size(39, 21)
        Me.chkA.TabIndex = 22
        Me.chkA.Text = "A"
        Me.chkA.UseVisualStyleBackColor = False
        '
        'chkLB
        '
        Me.chkLB.AutoSize = True
        Me.chkLB.BackColor = System.Drawing.Color.Black
        Me.chkLB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkLB.ForeColor = System.Drawing.Color.White
        Me.chkLB.Location = New System.Drawing.Point(761, 115)
        Me.chkLB.Name = "chkLB"
        Me.chkLB.Size = New System.Drawing.Size(47, 21)
        Me.chkLB.TabIndex = 23
        Me.chkLB.Text = "LB"
        Me.chkLB.UseVisualStyleBackColor = False
        '
        'chkRB
        '
        Me.chkRB.AutoSize = True
        Me.chkRB.BackColor = System.Drawing.Color.Black
        Me.chkRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.chkRB.ForeColor = System.Drawing.Color.White
        Me.chkRB.Location = New System.Drawing.Point(1173, 115)
        Me.chkRB.Name = "chkRB"
        Me.chkRB.Size = New System.Drawing.Size(49, 21)
        Me.chkRB.TabIndex = 24
        Me.chkRB.Text = "RB"
        Me.chkRB.UseVisualStyleBackColor = False
        '
        'lblLT
        '
        Me.lblLT.AutoSize = True
        Me.lblLT.BackColor = System.Drawing.Color.Black
        Me.lblLT.ForeColor = System.Drawing.Color.White
        Me.lblLT.Location = New System.Drawing.Point(773, 80)
        Me.lblLT.Name = "lblLT"
        Me.lblLT.Size = New System.Drawing.Size(41, 17)
        Me.lblLT.TabIndex = 25
        Me.lblLT.Text = "LT: 0"
        '
        'lblRT
        '
        Me.lblRT.AutoSize = True
        Me.lblRT.BackColor = System.Drawing.Color.Black
        Me.lblRT.ForeColor = System.Drawing.Color.White
        Me.lblRT.Location = New System.Drawing.Point(1157, 80)
        Me.lblRT.Name = "lblRT"
        Me.lblRT.Size = New System.Drawing.Size(43, 17)
        Me.lblRT.TabIndex = 26
        Me.lblRT.Text = "RT: 0"
        '
        'chkLS
        '
        Me.chkLS.AutoSize = True
        Me.chkLS.BackColor = System.Drawing.Color.Black
        Me.chkLS.ForeColor = System.Drawing.Color.White
        Me.chkLS.Location = New System.Drawing.Point(749, 215)
        Me.chkLS.Name = "chkLS"
        Me.chkLS.Size = New System.Drawing.Size(47, 21)
        Me.chkLS.TabIndex = 27
        Me.chkLS.Text = "LS"
        Me.chkLS.UseVisualStyleBackColor = False
        '
        'chkRS
        '
        Me.chkRS.AutoSize = True
        Me.chkRS.BackColor = System.Drawing.Color.Black
        Me.chkRS.ForeColor = System.Drawing.Color.White
        Me.chkRS.Location = New System.Drawing.Point(1067, 338)
        Me.chkRS.Name = "chkRS"
        Me.chkRS.Size = New System.Drawing.Size(49, 21)
        Me.chkRS.TabIndex = 28
        Me.chkRS.Text = "RS"
        Me.chkRS.UseVisualStyleBackColor = False
        '
        'chkBA
        '
        Me.chkBA.AutoSize = True
        Me.chkBA.BackColor = System.Drawing.Color.Black
        Me.chkBA.ForeColor = System.Drawing.Color.White
        Me.chkBA.Location = New System.Drawing.Point(888, 224)
        Me.chkBA.Name = "chkBA"
        Me.chkBA.Size = New System.Drawing.Size(48, 21)
        Me.chkBA.TabIndex = 29
        Me.chkBA.Text = "BA"
        Me.chkBA.UseVisualStyleBackColor = False
        '
        'chkST
        '
        Me.chkST.AutoSize = True
        Me.chkST.BackColor = System.Drawing.Color.Black
        Me.chkST.ForeColor = System.Drawing.Color.White
        Me.chkST.Location = New System.Drawing.Point(1045, 224)
        Me.chkST.Name = "chkST"
        Me.chkST.Size = New System.Drawing.Size(48, 21)
        Me.chkST.TabIndex = 30
        Me.chkST.Text = "ST"
        Me.chkST.UseVisualStyleBackColor = False
        '
        'chkPD
        '
        Me.chkPD.AutoSize = True
        Me.chkPD.BackColor = System.Drawing.Color.Black
        Me.chkPD.ForeColor = System.Drawing.Color.White
        Me.chkPD.Location = New System.Drawing.Point(851, 394)
        Me.chkPD.Name = "chkPD"
        Me.chkPD.Size = New System.Drawing.Size(49, 21)
        Me.chkPD.TabIndex = 31
        Me.chkPD.Text = "PD"
        Me.chkPD.UseVisualStyleBackColor = False
        '
        'chkPU
        '
        Me.chkPU.AutoSize = True
        Me.chkPU.BackColor = System.Drawing.Color.Black
        Me.chkPU.ForeColor = System.Drawing.Color.White
        Me.chkPU.Location = New System.Drawing.Point(851, 282)
        Me.chkPU.Name = "chkPU"
        Me.chkPU.Size = New System.Drawing.Size(49, 21)
        Me.chkPU.TabIndex = 32
        Me.chkPU.Text = "PU"
        Me.chkPU.UseVisualStyleBackColor = False
        '
        'chkPL
        '
        Me.chkPL.AutoSize = True
        Me.chkPL.BackColor = System.Drawing.Color.Black
        Me.chkPL.ForeColor = System.Drawing.Color.White
        Me.chkPL.Location = New System.Drawing.Point(812, 336)
        Me.chkPL.Name = "chkPL"
        Me.chkPL.Size = New System.Drawing.Size(47, 21)
        Me.chkPL.TabIndex = 33
        Me.chkPL.Text = "PL"
        Me.chkPL.UseVisualStyleBackColor = False
        '
        'chkPR
        '
        Me.chkPR.AutoSize = True
        Me.chkPR.BackColor = System.Drawing.Color.Black
        Me.chkPR.ForeColor = System.Drawing.Color.White
        Me.chkPR.Location = New System.Drawing.Point(906, 336)
        Me.chkPR.Name = "chkPR"
        Me.chkPR.Size = New System.Drawing.Size(49, 21)
        Me.chkPR.TabIndex = 34
        Me.chkPR.Text = "PR"
        Me.chkPR.UseVisualStyleBackColor = False
        '
        'lblRSY
        '
        Me.lblRSY.AutoSize = True
        Me.lblRSY.BackColor = System.Drawing.Color.Black
        Me.lblRSY.ForeColor = System.Drawing.Color.White
        Me.lblRSY.Location = New System.Drawing.Point(1077, 394)
        Me.lblRSY.Name = "lblRSY"
        Me.lblRSY.Size = New System.Drawing.Size(52, 17)
        Me.lblRSY.TabIndex = 35
        Me.lblRSY.Text = "RSY: 0"
        '
        'lblRSX
        '
        Me.lblRSX.AutoSize = True
        Me.lblRSX.BackColor = System.Drawing.Color.Black
        Me.lblRSX.ForeColor = System.Drawing.Color.White
        Me.lblRSX.Location = New System.Drawing.Point(1131, 346)
        Me.lblRSX.Name = "lblRSX"
        Me.lblRSX.Size = New System.Drawing.Size(52, 17)
        Me.lblRSX.TabIndex = 36
        Me.lblRSX.Text = "RSX: 0"
        '
        'lblLSY
        '
        Me.lblLSY.AutoSize = True
        Me.lblLSY.BackColor = System.Drawing.Color.Black
        Me.lblLSY.ForeColor = System.Drawing.Color.White
        Me.lblLSY.Location = New System.Drawing.Point(773, 162)
        Me.lblLSY.Name = "lblLSY"
        Me.lblLSY.Size = New System.Drawing.Size(50, 17)
        Me.lblLSY.TabIndex = 37
        Me.lblLSY.Text = "LSY: 0"
        '
        'lblLSX
        '
        Me.lblLSX.AutoSize = True
        Me.lblLSX.BackColor = System.Drawing.Color.Black
        Me.lblLSX.ForeColor = System.Drawing.Color.White
        Me.lblLSX.Location = New System.Drawing.Point(832, 206)
        Me.lblLSX.Name = "lblLSX"
        Me.lblLSX.Size = New System.Drawing.Size(50, 17)
        Me.lblLSX.TabIndex = 38
        Me.lblLSX.Text = "LSX: 0"
        '
        'lblController
        '
        Me.lblController.AutoSize = True
        Me.lblController.Location = New System.Drawing.Point(1093, 19)
        Me.lblController.Name = "lblController"
        Me.lblController.Size = New System.Drawing.Size(73, 17)
        Me.lblController.TabIndex = 39
        Me.lblController.Text = "Controller:"
        '
        'cmbController
        '
        Me.cmbController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbController.FormattingEnabled = True
        Me.cmbController.Items.AddRange(New Object() {"Player 1", "Player 2", "Player 3", "Player 4"})
        Me.cmbController.Location = New System.Drawing.Point(1176, 16)
        Me.cmbController.Name = "cmbController"
        Me.cmbController.Size = New System.Drawing.Size(117, 24)
        Me.cmbController.TabIndex = 40
        '
        'cmdInputs
        '
        Me.cmdInputs.Location = New System.Drawing.Point(715, 599)
        Me.cmdInputs.Name = "cmdInputs"
        Me.cmdInputs.Size = New System.Drawing.Size(203, 42)
        Me.cmdInputs.TabIndex = 41
        Me.cmdInputs.Text = "Map controller inputs"
        Me.cmdInputs.UseVisualStyleBackColor = True
        '
        'cmdOutputs
        '
        Me.cmdOutputs.Location = New System.Drawing.Point(1062, 599)
        Me.cmdOutputs.Name = "cmdOutputs"
        Me.cmdOutputs.Size = New System.Drawing.Size(203, 42)
        Me.cmdOutputs.TabIndex = 42
        Me.cmdOutputs.Text = "Map controller outputs"
        Me.cmdOutputs.UseVisualStyleBackColor = True
        '
        'tkbL
        '
        Me.tkbL.BackColor = System.Drawing.Color.Black
        Me.tkbL.Enabled = False
        Me.tkbL.Location = New System.Drawing.Point(826, 506)
        Me.tkbL.Name = "tkbL"
        Me.tkbL.Size = New System.Drawing.Size(129, 56)
        Me.tkbL.TabIndex = 43
        '
        'tkbR
        '
        Me.tkbR.BackColor = System.Drawing.Color.Black
        Me.tkbR.Enabled = False
        Me.tkbR.Location = New System.Drawing.Point(1018, 506)
        Me.tkbR.Name = "tkbR"
        Me.tkbR.Size = New System.Drawing.Size(129, 56)
        Me.tkbR.TabIndex = 44
        '
        'chkLV
        '
        Me.chkLV.AutoSize = True
        Me.chkLV.BackColor = System.Drawing.Color.Black
        Me.chkLV.ForeColor = System.Drawing.Color.White
        Me.chkLV.Location = New System.Drawing.Point(871, 479)
        Me.chkLV.Name = "chkLV"
        Me.chkLV.Size = New System.Drawing.Size(47, 21)
        Me.chkLV.TabIndex = 45
        Me.chkLV.Text = "LV"
        Me.chkLV.UseVisualStyleBackColor = False
        '
        'chkRV
        '
        Me.chkRV.AutoSize = True
        Me.chkRV.BackColor = System.Drawing.Color.Black
        Me.chkRV.ForeColor = System.Drawing.Color.White
        Me.chkRV.Location = New System.Drawing.Point(1062, 479)
        Me.chkRV.Name = "chkRV"
        Me.chkRV.Size = New System.Drawing.Size(49, 21)
        Me.chkRV.TabIndex = 46
        Me.chkRV.Text = "RV"
        Me.chkRV.UseVisualStyleBackColor = False
        '
        'lblControllerRefreshPeriod
        '
        Me.lblControllerRefreshPeriod.AutoSize = True
        Me.lblControllerRefreshPeriod.Location = New System.Drawing.Point(758, 20)
        Me.lblControllerRefreshPeriod.Name = "lblControllerRefreshPeriod"
        Me.lblControllerRefreshPeriod.Size = New System.Drawing.Size(188, 17)
        Me.lblControllerRefreshPeriod.TabIndex = 47
        Me.lblControllerRefreshPeriod.Text = "TX/Controller refresh period:"
        '
        'cmbControllerRefreshTime
        '
        Me.cmbControllerRefreshTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbControllerRefreshTime.FormattingEnabled = True
        Me.cmbControllerRefreshTime.Items.AddRange(New Object() {"50 ms", "100 ms", "200 ms", "500 ms", "1 s"})
        Me.cmbControllerRefreshTime.Location = New System.Drawing.Point(956, 17)
        Me.cmbControllerRefreshTime.Name = "cmbControllerRefreshTime"
        Me.cmbControllerRefreshTime.Size = New System.Drawing.Size(105, 24)
        Me.cmbControllerRefreshTime.TabIndex = 48
        '
        'lblRXRefreshPeriod
        '
        Me.lblRXRefreshPeriod.AutoSize = True
        Me.lblRXRefreshPeriod.Location = New System.Drawing.Point(488, 19)
        Me.lblRXRefreshPeriod.Name = "lblRXRefreshPeriod"
        Me.lblRXRefreshPeriod.Size = New System.Drawing.Size(124, 17)
        Me.lblRXRefreshPeriod.TabIndex = 49
        Me.lblRXRefreshPeriod.Text = "RX refresh period:"
        '
        'cmbRXRefreshTime
        '
        Me.cmbRXRefreshTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRXRefreshTime.FormattingEnabled = True
        Me.cmbRXRefreshTime.Items.AddRange(New Object() {"50 ms", "100 ms", "200 ms", "500 ms", "1 s"})
        Me.cmbRXRefreshTime.Location = New System.Drawing.Point(628, 18)
        Me.cmbRXRefreshTime.Name = "cmbRXRefreshTime"
        Me.cmbRXRefreshTime.Size = New System.Drawing.Size(110, 24)
        Me.cmbRXRefreshTime.TabIndex = 50
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(476, 61)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(88, 17)
        Me.lblTest.TabIndex = 51
        Me.lblTest.Text = "RX word test"
        Me.lblTest.Visible = False
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(405, 468)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(32, 32)
        Me.pic1.TabIndex = 52
        Me.pic1.TabStop = False
        Me.pic1.Visible = False
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(443, 468)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(32, 32)
        Me.pic2.TabIndex = 53
        Me.pic2.TabStop = False
        Me.pic2.Visible = False
        '
        'pic3
        '
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(405, 506)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(32, 32)
        Me.pic3.TabIndex = 54
        Me.pic3.TabStop = False
        Me.pic3.Visible = False
        '
        'pic4
        '
        Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(443, 506)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(32, 32)
        Me.pic4.TabIndex = 55
        Me.pic4.TabStop = False
        Me.pic4.Visible = False
        '
        'cmdAbout
        '
        Me.cmdAbout.Location = New System.Drawing.Point(1318, 11)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(38, 37)
        Me.cmdAbout.TabIndex = 56
        Me.cmdAbout.Text = "?"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'frmXBOX2ARDUINO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1368, 653)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.lblTest)
        Me.Controls.Add(Me.cmbRXRefreshTime)
        Me.Controls.Add(Me.lblRXRefreshPeriod)
        Me.Controls.Add(Me.cmbControllerRefreshTime)
        Me.Controls.Add(Me.lblControllerRefreshPeriod)
        Me.Controls.Add(Me.chkRV)
        Me.Controls.Add(Me.chkLV)
        Me.Controls.Add(Me.tkbR)
        Me.Controls.Add(Me.tkbL)
        Me.Controls.Add(Me.cmdOutputs)
        Me.Controls.Add(Me.cmdInputs)
        Me.Controls.Add(Me.cmbController)
        Me.Controls.Add(Me.lblController)
        Me.Controls.Add(Me.lblLSX)
        Me.Controls.Add(Me.lblLSY)
        Me.Controls.Add(Me.lblRSX)
        Me.Controls.Add(Me.lblRSY)
        Me.Controls.Add(Me.chkPR)
        Me.Controls.Add(Me.chkPL)
        Me.Controls.Add(Me.chkPU)
        Me.Controls.Add(Me.chkPD)
        Me.Controls.Add(Me.chkST)
        Me.Controls.Add(Me.chkBA)
        Me.Controls.Add(Me.chkRS)
        Me.Controls.Add(Me.chkLS)
        Me.Controls.Add(Me.lblRT)
        Me.Controls.Add(Me.lblLT)
        Me.Controls.Add(Me.chkRB)
        Me.Controls.Add(Me.chkLB)
        Me.Controls.Add(Me.chkA)
        Me.Controls.Add(Me.chkY)
        Me.Controls.Add(Me.chkB)
        Me.Controls.Add(Me.chkX)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.chkDetected)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.cmdClearTX)
        Me.Controls.Add(Me.txtSend)
        Me.Controls.Add(Me.lblTX)
        Me.Controls.Add(Me.rtbTX)
        Me.Controls.Add(Me.lblRX)
        Me.Controls.Add(Me.rtbRX)
        Me.Controls.Add(Me.cmdClearRX)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.lblCOM)
        Me.Controls.Add(Me.cmbCOM)
        Me.Controls.Add(Me.picController)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmXBOX2ARDUINO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XBOX2ARDUINO"
        CType(Me.picController, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tkbR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCOM As System.Windows.Forms.ComboBox
    Friend WithEvents lblCOM As System.Windows.Forms.Label
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents cmdClearRX As System.Windows.Forms.Button
    Friend WithEvents timIO As System.Windows.Forms.Timer
    Friend WithEvents rtbRX As System.Windows.Forms.RichTextBox
    Friend WithEvents spt1 As System.IO.Ports.SerialPort
    Friend WithEvents lblRX As System.Windows.Forms.Label
    Friend WithEvents rtbTX As System.Windows.Forms.RichTextBox
    Friend WithEvents lblTX As System.Windows.Forms.Label
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents cmdClearTX As System.Windows.Forms.Button
    Friend WithEvents cmdSend As System.Windows.Forms.Button
    Friend WithEvents picController As System.Windows.Forms.PictureBox
    Friend WithEvents chkDetected As System.Windows.Forms.CheckBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents timXBOX As System.Windows.Forms.Timer
    Friend WithEvents chkX As System.Windows.Forms.CheckBox
    Friend WithEvents chkB As System.Windows.Forms.CheckBox
    Friend WithEvents chkY As System.Windows.Forms.CheckBox
    Friend WithEvents chkA As System.Windows.Forms.CheckBox
    Friend WithEvents chkLB As System.Windows.Forms.CheckBox
    Friend WithEvents chkRB As System.Windows.Forms.CheckBox
    Friend WithEvents lblLT As System.Windows.Forms.Label
    Friend WithEvents lblRT As System.Windows.Forms.Label
    Friend WithEvents chkLS As System.Windows.Forms.CheckBox
    Friend WithEvents chkRS As System.Windows.Forms.CheckBox
    Friend WithEvents chkBA As System.Windows.Forms.CheckBox
    Friend WithEvents chkST As System.Windows.Forms.CheckBox
    Friend WithEvents chkPD As System.Windows.Forms.CheckBox
    Friend WithEvents chkPU As System.Windows.Forms.CheckBox
    Friend WithEvents chkPL As System.Windows.Forms.CheckBox
    Friend WithEvents chkPR As System.Windows.Forms.CheckBox
    Friend WithEvents lblRSY As System.Windows.Forms.Label
    Friend WithEvents lblRSX As System.Windows.Forms.Label
    Friend WithEvents lblLSY As System.Windows.Forms.Label
    Friend WithEvents lblLSX As System.Windows.Forms.Label
    Friend WithEvents lblController As System.Windows.Forms.Label
    Friend WithEvents cmbController As System.Windows.Forms.ComboBox
    Friend WithEvents cmdInputs As System.Windows.Forms.Button
    Friend WithEvents cmdOutputs As System.Windows.Forms.Button
    Friend WithEvents tkbL As System.Windows.Forms.TrackBar
    Friend WithEvents tkbR As System.Windows.Forms.TrackBar
    Friend WithEvents chkLV As System.Windows.Forms.CheckBox
    Friend WithEvents chkRV As System.Windows.Forms.CheckBox
    Friend WithEvents lblControllerRefreshPeriod As System.Windows.Forms.Label
    Friend WithEvents cmbControllerRefreshTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblRXRefreshPeriod As System.Windows.Forms.Label
    Friend WithEvents cmbRXRefreshTime As System.Windows.Forms.ComboBox
    Friend WithEvents lblTest As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAbout As System.Windows.Forms.Button

End Class
