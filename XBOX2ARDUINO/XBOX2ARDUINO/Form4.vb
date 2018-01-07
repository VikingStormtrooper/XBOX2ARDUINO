Public Class frmAbout

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llbArduino.Links(0).LinkData = "https://www.arduino.cc/en/Main/CopyrightNotice"
        llbArduino.Links.Add(0, 46, "https://www.arduino.cc/en/Main/CopyrightNotice")
        llbMicrosoft.Links(0).LinkData = "https://www.xbox.com/it-it/"
        llbMicrosoft.Links.Add(0, 27, "https://www.xbox.com/it-it/")
        llbOlaf.Links(0).LinkData = "http://it.gravatar.com/vikingstormtrooper91"
        llbOlaf.Links.Add(0, 42, "http://it.gravatar.com/vikingstormtrooper91")
        llbMartynCurrey.Links(0).LinkData = "http://www.martyncurrey.com/"
        llbMartynCurrey.Links.Add(0, 28, "http://www.martyncurrey.com/")
        llbEntropiaCrescente.Links(0).LinkData = "https://entropiacrescente.wordpress.com/"
        llbEntropiaCrescente.Links.Add(0, 40, "https://entropiacrescente.wordpress.com/")
    End Sub

    Private Sub llbArduino_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbArduino.LinkClicked
        Dim target As String = CType(e.Link.LinkData, String)

        System.Diagnostics.Process.Start(target)
        Me.Close()

    End Sub

    Private Sub llbMicrosoft_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbMicrosoft.LinkClicked
        Dim target As String = CType(e.Link.LinkData, String)

        System.Diagnostics.Process.Start(target)
        Me.Close()
    End Sub

    Private Sub llbOlaf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbOlaf.LinkClicked
        Dim target As String = CType(e.Link.LinkData, String)

        System.Diagnostics.Process.Start(target)
        Me.Close()
    End Sub

    Private Sub llbMartynCurrey_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbMartynCurrey.LinkClicked
        Dim target As String = CType(e.Link.LinkData, String)

        System.Diagnostics.Process.Start(target)
        Me.Close()
    End Sub

    Private Sub llbEntropiaCrescente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbEntropiaCrescente.LinkClicked
        Dim target As String = CType(e.Link.LinkData, String)

        System.Diagnostics.Process.Start(target)
        Me.Close()
    End Sub
End Class