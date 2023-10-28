Public Class Form1

    Private Sub enit()
        txt_mdp.Clear()
        txt_nom.Clear()


    End Sub
    Private Sub btn_valider_Click(sender As Object, e As EventArgs) Handles btn_valider.Click
        Dim login, pw As String
        login = txt_nom.Text
        pw = txt_mdp.Text
        If (login = "louati") And (pw = "0000") Then
            Me.Hide()
            Form2.Show()
        Else
            enit()

        End If

    End Sub

    Private Sub btn_annul_Click(sender As Object, e As EventArgs) Handles btn_annul.Click
        enit()
    End Sub
End Class
