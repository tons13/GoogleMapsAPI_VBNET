Imports System.Net
Imports System.Xml

Public Class frmCalcularDistancia

    Private zipdistancia, zipkm As String


    Private Sub bntDistancia_Click(sender As Object, e As EventArgs) Handles bntDistancia.Click

        Dim url = String.Format("http://maps.googleapis.com/maps/api/distancematrix/xml?origins={0}&destinations={1}&mode=driving&language=pt-BR&sensor=false", txtOrigem.Text, txtDestino.Text)
        frmGoogleMaps.CalculaDistanciaXML(url)
        frmGoogleMaps.Show()

    End Sub

    Private Sub bntCalcula_Click(sender As Object, e As EventArgs) Handles bntCalcula.Click

        Dim mode As String = Nothing


        If rbVeiculo.Checked = False Then
            MsgBox("Selecione o meio de transporte!")
            Return
        End If

        If rbVeiculo.Checked = True Then
            mode = "driving "
        End If



        Dim url = String.Format("http://maps.googleapis.com/maps/api/distancematrix/xml?origins={0}&destinations={1}&mode={2}&language=pt-BR&sensor=false", txtOrigem.Text, txtDestino.Text, mode)
        Calcula(url)

        lblDistancia.Text = zipdistancia
        lblDistanciaKm.Text = zipkm

    End Sub

    Public Sub Calcula(url As String)

        Dim DistanciaXML As String = Nothing
        Dim wsClient As New WebClient

        'Download os dados no formato XML como uma string
        DistanciaXML = wsClient.DownloadString(url)
        'verifica se o status esta OK e inicia o processamento
        If DistanciaXML.Contains("OK") Then

            'Verifica se a seção postal_code existe na string e continua
            If DistanciaXML.Contains("distance") Then
                Dim xmlDoc As New XmlDocument()
                xmlDoc.LoadXml(DistanciaXML)
                Dim m_nodelist As XmlNodeList

                'Obtem a lista de todos os endereço dos nós distance nodes 
                m_nodelist = xmlDoc.SelectNodes("//distance")
                'Para cada componente verifica a seção type para obter a distancia
                For Each m_node In m_nodelist
                    'obtem a distancia
                    zipdistancia = m_node.ChildNodes.Item(0).InnerText
                    'obtem a distancia em kilometragem
                    zipkm = m_node.ChildNodes.Item(1).InnerText
                Next

            End If
        End If


    End Sub


End Class