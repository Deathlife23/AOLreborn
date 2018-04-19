Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            Timer1.Enabled = False
            If My.Computer.Network.IsAvailable Then
                Me.Hide()
                Form3.Show()
            Else
                Timer1.Enabled = False
                MessageBox.Show("Cannot connect to the Internet! Must be connected.", _
    "AOL Reborn - Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
            End If
        End If
    End Sub
End Class