<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cboComPort = New System.Windows.Forms.ComboBox()
        Me.cboBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnComOpen = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tbTx = New System.Windows.Forms.TextBox()
        Me.tbRx = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnEnde = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboComPort
        '
        Me.cboComPort.FormattingEnabled = True
        Me.cboComPort.Location = New System.Drawing.Point(151, 12)
        Me.cboComPort.Name = "cboComPort"
        Me.cboComPort.Size = New System.Drawing.Size(121, 21)
        Me.cboComPort.TabIndex = 0
        '
        'cboBaudRate
        '
        Me.cboBaudRate.FormattingEnabled = True
        Me.cboBaudRate.Location = New System.Drawing.Point(151, 39)
        Me.cboBaudRate.Name = "cboBaudRate"
        Me.cboBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.cboBaudRate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PORT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baud Rate"
        '
        'btnComOpen
        '
        Me.btnComOpen.Location = New System.Drawing.Point(12, 85)
        Me.btnComOpen.Name = "btnComOpen"
        Me.btnComOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnComOpen.TabIndex = 3
        Me.btnComOpen.Text = "Open"
        Me.btnComOpen.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(93, 85)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tbTx
        '
        Me.tbTx.Location = New System.Drawing.Point(12, 150)
        Me.tbTx.Multiline = True
        Me.tbTx.Name = "tbTx"
        Me.tbTx.Size = New System.Drawing.Size(260, 72)
        Me.tbTx.TabIndex = 5
        '
        'tbRx
        '
        Me.tbRx.Location = New System.Drawing.Point(12, 283)
        Me.tbRx.Multiline = True
        Me.tbRx.Name = "tbRx"
        Me.tbRx.Size = New System.Drawing.Size(260, 72)
        Me.tbRx.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(174, 85)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 228)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnEnde
        '
        Me.btnEnde.Location = New System.Drawing.Point(93, 228)
        Me.btnEnde.Name = "btnEnde"
        Me.btnEnde.Size = New System.Drawing.Size(75, 23)
        Me.btnEnde.TabIndex = 8
        Me.btnEnde.Text = "Ende"
        Me.btnEnde.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "10"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "ON 1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(476, 56)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "OFF 1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(395, 85)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "ON 2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(476, 85)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "OFF 2"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(395, 114)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "ON 3"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(476, 114)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "OFF 3"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(395, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "ON ALL"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(476, 143)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "OFF ALL"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 414)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEnde)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.tbRx)
        Me.Controls.Add(Me.tbTx)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnComOpen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboBaudRate)
        Me.Controls.Add(Me.cboComPort)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboComPort As System.Windows.Forms.ComboBox
    Friend WithEvents cboBaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnComOpen As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tbTx As System.Windows.Forms.TextBox
    Friend WithEvents tbRx As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnEnde As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class
