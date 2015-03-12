Imports System.Uri

Public Class frmGoogleMaps

    Private Sub frmGoogleMaps_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LoadMapsXML(url As String)
        WbBrowser.ScriptErrorsSuppressed = True
        WbBrowser.Url = (New Uri(url))
    End Sub


    Public Sub LoadMaps(endereco As String)
        WbBrowser.ScriptErrorsSuppressed = True
        WbBrowser.Url = (New Uri(endereco))
    End Sub


    Public Sub CalculaDistanciaXML(url As String)
        WbBrowser.ScriptErrorsSuppressed = True
        WbBrowser.Url = (New Uri(url))
    End Sub

End Class