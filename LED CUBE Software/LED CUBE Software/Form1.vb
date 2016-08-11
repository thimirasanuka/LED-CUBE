Public Class Form1

    Private readBuffer As String = String.Empty
    Private Bytenumber As Integer
    Private ByteToRead As Integer
    Private byteEnd(2) As Char
    Private comOpen As Boolean

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If comOpen Then
            SerialPort1.Close()
        End If
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Portnames As String() = System.IO.Ports.SerialPort.GetPortNames
        If Portnames Is Nothing Then
            MsgBox("There are no Com Ports detected!")
            Me.Close()
        End If
        cboComPort.Items.AddRange(Portnames)
        cboComPort.Text = Portnames(0)
        cboBaudRate.Text = "9600"

    End Sub

    Private Sub btnComOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnComOpen.Click
        With SerialPort1
            .ParityReplace = &H3B
            .PortName = cboComPort.Text
            .BaudRate = CInt(cboBaudRate.Text)
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.One
            .Handshake = IO.Ports.Handshake.None
            .RtsEnable = False
            .ReceivedBytesThreshold = 1
            .NewLine = vbCr
            .ReadTimeout = 10000
        End With

        Try
            SerialPort1.Open()
            comOpen = SerialPort1.IsOpen
        Catch ex As Exception
            comOpen = False
            MsgBox("Error Open:" & ex.Message)
        End Try

        If comOpen Then
            cboComPort.Enabled = False
            cboBaudRate.Enabled = False
        End If

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If comOpen Then
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
        End If

        comOpen = False
        cboBaudRate.Enabled = True
        cboComPort.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        tbRx.Text = String.Empty
        tbTx.Text = String.Empty
    End Sub

    Private Sub btnEnde_Click(sender As System.Object, e As System.EventArgs) Handles btnEnde.Click
        If comOpen Then
            ' clear input buffer 
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
        End If
        comOpen = False
        Me.Close()
    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        If comOpen Then SerialPort1.Write(tbTx.Text)

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If comOpen Then
            Try
                byteEnd = SerialPort1.NewLine.ToCharArray

                Bytenumber = SerialPort1.BytesToRead

                readBuffer = SerialPort1.ReadLine

                Me.Invoke(New EventHandler(AddressOf DoUpdate))

            Catch ex As Exception
                MsgBox("read" & ex.Message)
            End Try
        End If
    End Sub


    Public Sub DoUpdate(ByVal sender As Object, ByVal e As System.EventArgs)
        tbRx.Text = readBuffer
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'If comOpen Then SerialPort1.Write(tbTx.Text)
        If comOpen Then SerialPort1.Write(0)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If comOpen Then SerialPort1.Write("ON1")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If comOpen Then SerialPort1.Write("ON2")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If comOpen Then SerialPort1.Write("ON3")
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If comOpen Then SerialPort1.Write("ONA")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If comOpen Then SerialPort1.Write("OFF1")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If comOpen Then SerialPort1.Write("OFF2")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If comOpen Then SerialPort1.Write("OFF3")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If comOpen Then SerialPort1.Write("OFFA")
    End Sub
End Class
