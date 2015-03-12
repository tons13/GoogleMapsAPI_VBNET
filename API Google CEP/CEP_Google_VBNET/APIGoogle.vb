Imports System.Net
Imports System.Xml

Public Class APIGoogle
    Public urlPrincipal As String
    Public endereco As String

    Public Function GetcodigoCEP(ByVal address1 As String, ByVal city As String, ByVal state As String) As String

        Dim enderecoXML As String = String.Empty
        Dim codigoCEP As String = String.Empty



        Try

            'Cria um objeto do tipo web client
            Dim wsClient As New WebClient()

            'Constroi a URL concatenando os valores dos endereços
            Dim codigoCEPurl As String = "?address={0},+{1},+{2}&sensor=false"
            'Aqui na construção da URL , sensor é obrigatório e eindia se a requisição vem de um dispositivo com localização por sensor

            Dim url As String = "http://maps.googleapis.com/maps/api/geocode/xml" & codigoCEPurl
            url = [String].Format(url, address1.Replace(" ", "+"), city.Replace(" ", "+"), state.Replace(" ", "+"))

            'Armazena url XML
            urlPrincipal = url

            'Armazena o endereco
            endereco = "https://www.google.com.br/maps/place/" & address1.Replace(" ", "+")

            'Download os dados no formato XML como uma string
            enderecoXML = wsClient.DownloadString(url)

            'verifica se o status esta OK e inicia o processamento
            If enderecoXML.Contains("OK") Then

                'Verifica se a seção postal_code existe na string e continua
                If enderecoXML.Contains("postal_code") Then
                    Dim xmlDoc As New XmlDocument()
                    xmlDoc.LoadXml(enderecoXML)
                    Dim m_nodelist As XmlNodeList

                    'Obtem a lista de todos os endereço dos nós address_companent nodes 
                    m_nodelist = xmlDoc.SelectNodes("/GeocodeResponse/result/address_component")

                    'Para cada componente verifica a seção type para obter o cep
                    For Each m_node In m_nodelist
                        'Pega o valor do elemento zipLongName
                        Dim zipLongName = m_node.ChildNodes.Item(0).InnerText
                        'Pega o valor do elemento zipShortName
                        Dim zipShortName = m_node.ChildNodes.Item(1).InnerText
                        'Pega o valor do elemento tipo de cep
                        Dim zipType = m_node.ChildNodes.Item(2).InnerText

                        'Se o tipo do componente for postal_code ou postal_code_prefix pega o CEP como zipLongName
                        If zipType = "postal_code_prefix" Or zipType = "postal_code" Then
                            codigoCEP = zipLongName
                        End If
                    Next
                End If
            End If
        Catch ex As WebException
            MessageBox.Show(ex.Message)
        End Try
        Return codigoCEP
    End Function


  
End Class
