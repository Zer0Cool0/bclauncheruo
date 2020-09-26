Imports System.IO


' Looking into adding '

'' Add Minimize to system tray - Done
'' Look into datatable for server pop, queue, and status
'' FAQ?



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Form2.Visible = False

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' Joins Queens
        System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/qqyyov")
        Me.Close()

        If CheckBox1.Checked = True Then

            If MessageBox.Show("Are you sure you want to clear your cache and join this server? ", "FiveM Quick Clear Cache", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If My.Settings.fivem = "" Then

                    MsgBox("You have not selected your FiveM Directory! Go to the settings and select your FiveM Directory")
                    Stop

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\browser") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\browser", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\db") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\db", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\priv") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\priv", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\servers") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\servers", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\subprocess") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\subprocess", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\unconfirmed") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\unconfirmed", True)

                End If

            End If

        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Joins Staten

        If CheckBox1.Checked = True Then

            If MessageBox.Show("Are you sure you want to clear your cache and join this server? ", "FiveM Quick Clear Cache", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If My.Settings.fivem = "" Then

                    MsgBox("You have not selected your FiveM Directory! Go to the settings and select your FiveM Directory")
                    Stop

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\browser") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\browser", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\db") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\db", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\priv") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\priv", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\servers") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\servers", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\subprocess") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\subprocess", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\unconfirmed") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\unconfirmed", True)

                End If

            End If

        End If

        System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/xl669x")
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Joins Bronx

        If CheckBox1.Checked = True Then

            If MessageBox.Show("Are you sure you want to clear your cache and join this server? ", "FiveM Quick Clear Cache", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If My.Settings.fivem = "" Then

                    MsgBox("You have not selected your FiveM Directory! Go to the settings and select your FiveM Directory")
                    Stop

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\browser") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\browser", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\db") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\db", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\priv") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\priv", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\servers") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\servers", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\subprocess") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\subprocess", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\unconfirmed") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\unconfirmed", True)

                End If

            End If

        End If

        System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/6meoe6")
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' Joins Manhattan

        If CheckBox1.Checked = True Then

            If MessageBox.Show("Are you sure you want to clear your cache and join this server? ", "FiveM Quick Clear Cache", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If My.Settings.fivem = "" Then

                    MsgBox("You have not selected your FiveM Directory! Go to the settings and select your FiveM Directory")
                    Stop

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\browser") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\browser", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\db") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\db", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\priv") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\priv", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\servers") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\servers", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\subprocess") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\subprocess", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\unconfirmed") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\unconfirmed", True)

                End If

            End If

        End If

        System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/leaao4")
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' Joins Brooklyn

        If CheckBox1.Checked = True Then

            If MessageBox.Show("Are you sure you want to clear your cache and join this server? ", "FiveM Quick Clear Cache", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                If My.Settings.fivem = "" Then

                    MsgBox("You have not selected your FiveM Directory! Go to the settings and select your FiveM Directory")
                    Stop

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\browser") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\browser", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\db") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\db", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\priv") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\priv", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\servers") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\servers", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\subprocess") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\subprocess", True)

                End If

                If System.IO.Directory.Exists(My.Settings.fivem + "\FiveM.app\cache\unconfirmed") Then
                    System.IO.Directory.Delete(My.Settings.fivem + "\FiveM.app\cache\unconfirmed", True)

                End If

            End If

        End If

        System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/3ykory")
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ' Opens TS3 and connects to the BigCityRP TS

        System.Diagnostics.Process.Start($"ts3server://bigcityrp.com")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        ' Opens the BigCityRP Website

        System.Diagnostics.Process.Start($"https://bigcityrp.com")

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        ' Settings

        Me.Visible = False
        Form2.Visible = True

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False

    End Sub
End Class
