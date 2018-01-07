<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llbArduino = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.llbMicrosoft = New System.Windows.Forms.LinkLabel()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.llbOlaf = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.llbEntropiaCrescente = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.llbMartynCurrey = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOK
        '
        Me.cmdOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdOK.Location = New System.Drawing.Point(275, 318)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(100, 45)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Arduino is released under a CC license. See"
        '
        'llbArduino
        '
        Me.llbArduino.AutoSize = True
        Me.llbArduino.Location = New System.Drawing.Point(294, 254)
        Me.llbArduino.Name = "llbArduino"
        Me.llbArduino.Size = New System.Drawing.Size(306, 17)
        Me.llbArduino.TabIndex = 2
        Me.llbArduino.TabStop = True
        Me.llbArduino.Text = "https://www.arduino.cc/en/Main/CopyrightNotice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(411, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Xbox and Xbox 360 are properties of Microsoft Corporation. See"
        '
        'llbMicrosoft
        '
        Me.llbMicrosoft.AutoSize = True
        Me.llbMicrosoft.Location = New System.Drawing.Point(420, 284)
        Me.llbMicrosoft.Name = "llbMicrosoft"
        Me.llbMicrosoft.Size = New System.Drawing.Size(167, 17)
        Me.llbMicrosoft.TabIndex = 4
        Me.llbMicrosoft.TabStop = True
        Me.llbMicrosoft.Text = "https://www.xbox.com/it-it/"
        '
        'picIcon
        '
        Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
        Me.picIcon.Location = New System.Drawing.Point(285, 12)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(64, 64)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 5
        Me.picIcon.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(439, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "This software is available under a GNU General Public License v3.0."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(381, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Arduino and Xbox are properties of their respected owners."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(564, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "v 1.0.0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Made by"
        '
        'llbOlaf
        '
        Me.llbOlaf.AutoSize = True
        Me.llbOlaf.Location = New System.Drawing.Point(70, 12)
        Me.llbOlaf.Name = "llbOlaf"
        Me.llbOlaf.Size = New System.Drawing.Size(34, 17)
        Me.llbOlaf.TabIndex = 10
        Me.llbOlaf.TabStop = True
        Me.llbOlaf.Text = "Olaf"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(222, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Instructions (in Italian) available at"
        '
        'llbEntropiaCrescente
        '
        Me.llbEntropiaCrescente.AutoSize = True
        Me.llbEntropiaCrescente.Location = New System.Drawing.Point(231, 118)
        Me.llbEntropiaCrescente.Name = "llbEntropiaCrescente"
        Me.llbEntropiaCrescente.Size = New System.Drawing.Size(268, 17)
        Me.llbEntropiaCrescente.TabIndex = 12
        Me.llbEntropiaCrescente.TabStop = True
        Me.llbEntropiaCrescente.Text = "https://entropiacrescente.wordpress.com/"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Thanks to "
        '
        'llbMartynCurrey
        '
        Me.llbMartynCurrey.AutoSize = True
        Me.llbMartynCurrey.Location = New System.Drawing.Point(83, 162)
        Me.llbMartynCurrey.Name = "llbMartynCurrey"
        Me.llbMartynCurrey.Size = New System.Drawing.Size(97, 17)
        Me.llbMartynCurrey.TabIndex = 14
        Me.llbMartynCurrey.TabStop = True
        Me.llbMartynCurrey.Text = "Martyn Currey"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(186, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(398, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "for his tutorial about serial communication for Arduino and VB."
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdOK
        Me.ClientSize = New System.Drawing.Size(627, 374)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.llbMartynCurrey)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.llbEntropiaCrescente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.llbOlaf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.llbMicrosoft)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.llbArduino)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About XBOX2ARDUINO"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llbArduino As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents llbMicrosoft As System.Windows.Forms.LinkLabel
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents llbOlaf As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents llbEntropiaCrescente As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents llbMartynCurrey As System.Windows.Forms.LinkLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
