Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Form 2 Load

        Me.CenterToScreen()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.fivem = FolderBrowserDialog1.SelectedPath

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ''Handles Button for opening fivem directory''

        Try

            Process.Start(My.Settings.fivem)

        Catch ex As Exception

            MessageBox.Show("Please set your FiveM Directory", "BigCityRP | Unofficial Launcher | Settings")

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MessageBox.Show("Are you sure you want to clear your cache? ", "FiveM Quick Clear Cache", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            If My.Settings.fivem = "" Then

                MsgBox("You have not selected your FiveM Directory!")
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

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

        My.Settings.form2cb1 = Me.CheckBox1.CheckState

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        Me.Visible = False
        Form1.Visible = True

    End Sub
End Class