Imports System.Net
Imports System.Xml
Imports System.IO

Public Class frmAPIGoogle
    Private APIGoogleAPI As New APIGoogle

    Private Sub btnGetCEP_Click(sender As Object, e As EventArgs) Handles btnGetCEP.Click

        If String.IsNullOrEmpty(txtEndereco.Text) Then
            MessageBox.Show("Informe o endereço")
            Return
        End If
        If String.IsNullOrEmpty(txtCidade.Text) Then
            MessageBox.Show("Informe a cidade")
            Return
        End If
        If String.IsNullOrEmpty(cboUF.Text) Then
            MessageBox.Show("Informe o estado")
            Return
        End If

        txtCEP.Text = APIGoogleAPI.GetcodigoCEP(txtEndereco.Text, txtCidade.Text, cboUF.Text)

        If txtCEP.Text <> "" Then
            bntGoogle.Enabled = True
            bntGoogleMaps.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listCidades As New List(Of String) From {"SP", "MG", "RJ"}
        cboUF.DataSource = listCidades.AsEnumerable

        'Carrega o combobox utilizando um arquivo txt

        'Dim path As String = "C:\dados\estados.txt"
        'cboUF.Items.AddRange(File.ReadAllLines(path))
        'cboUF.SelectedIndex = 0

        '-------------------------------------------- //

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        cboUF.SelectedIndex = 0

        bntGoogle.Enabled = False
        bntGoogleMaps.Enabled = False

    End Sub

    Private Sub bntGoogle_Click(sender As Object, e As EventArgs) Handles bntGoogle.Click

        frmGoogleMaps.LoadMapsXML(APIGoogleAPI.urlPrincipal)
        frmGoogleMaps.Show()


    End Sub

    Private Sub bntGoogleMaps_Click(sender As Object, e As EventArgs) Handles bntGoogleMaps.Click


        frmGoogleMaps.LoadMaps(APIGoogleAPI.endereco)
        frmGoogleMaps.Show()


    End Sub

    Private Sub bntDistanciaXML_Click(sender As Object, e As EventArgs) Handles bntDistanciaXML.Click

        frmCalcularDistancia.Show()

    End Sub
End Class
