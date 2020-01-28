Imports System.Net.Sockets
Imports System.Text
Imports System.IO

Public Class Form2

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim tcpClient As New TcpClient 'creating the client
            Label1.Text = "Connecting...." & vbCrLf
            Application.DoEvents()

            tcpClient.Connect("192.168.1.66", 9101) 'connecting the client the server
            'port is same as in the server

            Label1.Text &= "Connected" & vbCrLf
            Application.DoEvents()

            Dim strMessage As String
            strMessage = TextBox1.Text

            Dim stm As Stream = tcpClient.GetStream() 'getting the stream of the client
            Dim ascenc As New ASCIIEncoding
            Dim byteData() As Byte = ascenc.GetBytes(strMessage) 'converting the data into bytes

            Label1.Text &= "Transmitting" & vbCrLf
            Application.DoEvents()

            stm.Write(byteData, 0, byteData.Length()) 'writing/transmitting the message


            Dim replymsg(1000) As Byte
            Dim size As Integer = stm.Read(replymsg, 0, 1000) 'reading the reply message and getting its size

            Label1.Text &= "Acknoledgement from Server" & vbCrLf
            Application.DoEvents()

            For i As Integer = 0 To size
                Label1.Text &= Convert.ToChar(replymsg(i)) & vbCrLf 'writing the reply into the console
            Next
            tcpClient.Close() 'closing the connection
        Catch ex As Exception
            Label1.Text &= "Error..." + ex.StackTrace.ToString() & vbCrLf 'writing the exception into the console
            Application.DoEvents()
        End Try
    End Sub
End Class