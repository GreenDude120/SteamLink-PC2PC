Public Class Form1
    Public Sub ShowDesktop()
        keybd_event(VK_LWIN, 0, 0, 0)
        keybd_event(77, 0, 0, 0)
        keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0)
    End Sub

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Long, ByVal dwExtraInfo As Long)
    Private Const KEYEVENTF_KEYUP = &H2
    Private Const VK_LWIN = &H5B
    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Settings.Text = "Settings"
            Button1.Text = TextBox1.Text
            Button2.Text = TextBox4.Text
            Button3.Text = TextBox6.Text
            Button4.Text = TextBox8.Text
            Button5.Text = TextBox10.Text
            Button6.Text = TextBox12.Text
            Button7.Text = TextBox14.Text
            Button8.Text = TextBox16.Text
            My.Computer.Registry.LocalMachine.SetValue("Button1Text", TextBox1.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button2Text", TextBox4.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button3Text", TextBox6.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button4Text", TextBox8.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button5Text", TextBox10.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button6Text", TextBox12.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button7Text", TextBox14.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button8Text", TextBox16.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button1Exe", TextBox2.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button2Exe", TextBox3.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button3Exe", TextBox5.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button4Exe", TextBox7.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button5Exe", TextBox9.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button6Exe", TextBox11.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button7Exe", TextBox13.Text)
            My.Computer.Registry.LocalMachine.SetValue("Button8Exe", TextBox15.Text)
        Else
            TextBox1.Text = My.Computer.Registry.LocalMachine.GetValue("Button1Text")
            TextBox4.Text = My.Computer.Registry.LocalMachine.GetValue("Button2Text")
            TextBox6.Text = My.Computer.Registry.LocalMachine.GetValue("Button3Text")
            TextBox8.Text = My.Computer.Registry.LocalMachine.GetValue("Button4Text")
            TextBox10.Text = My.Computer.Registry.LocalMachine.GetValue("Button5Text")
            TextBox12.Text = My.Computer.Registry.LocalMachine.GetValue("Button6Text")
            TextBox14.Text = My.Computer.Registry.LocalMachine.GetValue("Button7Text")
            TextBox16.Text = My.Computer.Registry.LocalMachine.GetValue("Button8Text")
            TextBox2.Text = My.Computer.Registry.LocalMachine.GetValue("Button1Exe")
            TextBox3.Text = My.Computer.Registry.LocalMachine.GetValue("Button2Exe")
            TextBox5.Text = My.Computer.Registry.LocalMachine.GetValue("Button3Exe")
            TextBox7.Text = My.Computer.Registry.LocalMachine.GetValue("Button4Exe")
            TextBox9.Text = My.Computer.Registry.LocalMachine.GetValue("Button5Exe")
            TextBox11.Text = My.Computer.Registry.LocalMachine.GetValue("Button6Exe")
            TextBox13.Text = My.Computer.Registry.LocalMachine.GetValue("Button7Exe")
            TextBox15.Text = My.Computer.Registry.LocalMachine.GetValue("Button8Exe")
            Panel1.Visible = True
            Settings.Text = "Save"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(TextBox2.Text)
    End Sub

    Private Sub ToDesktop_Click(sender As Object, e As EventArgs) Handles ToDesktop.Click
        Call ShowDesktop()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Process.Start("explorer.exe", "C:\")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(TextBox3.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(TextBox5.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start(TextBox7.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start(TextBox9.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Process.Start(TextBox11.Text)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start(TextBox13.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Process.Start(TextBox15.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = My.Computer.Registry.LocalMachine.GetValue("Button1Text")
        Button2.Text = My.Computer.Registry.LocalMachine.GetValue("Button2Text")
        Button3.Text = My.Computer.Registry.LocalMachine.GetValue("Button3Text")
        Button4.Text = My.Computer.Registry.LocalMachine.GetValue("Button4Text")
        Button5.Text = My.Computer.Registry.LocalMachine.GetValue("Button5Text")
        Button6.Text = My.Computer.Registry.LocalMachine.GetValue("Button6Text")
        Button7.Text = My.Computer.Registry.LocalMachine.GetValue("Button7Text")
        Button8.Text = My.Computer.Registry.LocalMachine.GetValue("Button8Text")
        TextBox2.Text = My.Computer.Registry.LocalMachine.GetValue("Button1Exe")
        TextBox3.Text = My.Computer.Registry.LocalMachine.GetValue("Button2Exe")
        TextBox5.Text = My.Computer.Registry.LocalMachine.GetValue("Button3Exe")
        TextBox7.Text = My.Computer.Registry.LocalMachine.GetValue("Button4Exe")
        TextBox9.Text = My.Computer.Registry.LocalMachine.GetValue("Button5Exe")
        TextBox11.Text = My.Computer.Registry.LocalMachine.GetValue("Button6Exe")
        TextBox13.Text = My.Computer.Registry.LocalMachine.GetValue("Button7Exe")
        TextBox15.Text = My.Computer.Registry.LocalMachine.GetValue("ButtonE8xe")
    End Sub
    Sub Main()
        Button1.Text = My.Computer.Registry.LocalMachine.GetValue("Button1Text")
        Button2.Text = My.Computer.Registry.LocalMachine.GetValue("Button2Text")
        Button3.Text = My.Computer.Registry.LocalMachine.GetValue("Button3Text")
        Button4.Text = My.Computer.Registry.LocalMachine.GetValue("Button4Text")
        Button5.Text = My.Computer.Registry.LocalMachine.GetValue("Button5Text")
        Button6.Text = My.Computer.Registry.LocalMachine.GetValue("Button6Text")
        Button7.Text = My.Computer.Registry.LocalMachine.GetValue("Button7Text")
        Button8.Text = My.Computer.Registry.LocalMachine.GetValue("Button8Text")
        TextBox2.Text = My.Computer.Registry.LocalMachine.GetValue("Button1Exe")
        TextBox3.Text = My.Computer.Registry.LocalMachine.GetValue("Button2Exe")
        TextBox5.Text = My.Computer.Registry.LocalMachine.GetValue("Button3Exe")
        TextBox7.Text = My.Computer.Registry.LocalMachine.GetValue("Button4Exe")
        TextBox9.Text = My.Computer.Registry.LocalMachine.GetValue("Button5Exe")
        TextBox11.Text = My.Computer.Registry.LocalMachine.GetValue("Button6Exe")
        TextBox13.Text = My.Computer.Registry.LocalMachine.GetValue("Button7Exe")
        TextBox15.Text = My.Computer.Registry.LocalMachine.GetValue("ButtonE8xe")
    End Sub
End Class
