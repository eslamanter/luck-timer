Public Class Form1
    Dim x As New Random

    Private Sub tmr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Me.lbl.Text = x.Next(Integer.Parse(Me.txt1.Text), Integer.Parse(Me.txt2.Text + 1))
        Me.tmr.Interval -= 100
        If Me.tmr.Interval = 100 Then
            Me.tmr.Enabled = False
            MessageBox.Show(Me.lbl.Text, "Luck Timer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        Me.tmr.Interval = 1000
        Me.tmr.Enabled = True
    End Sub
End Class
