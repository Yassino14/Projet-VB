Public Class Form2

    Private Sub btn_calcul_Click(sender As Object, e As EventArgs) Handles btn_calcul.Click
        Dim p As Integer
        txt_mtn.ReadOnly = True
        txt_prixu.ReadOnly = True
        If lst_prod.SelectedItem = "Clavier" Then
            txt_prixu.Text = 30
        ElseIf lst_prod.SelectedItem = "Souris" Then
            txt_prixu.Text = 15
        ElseIf lst_prod.SelectedItem = "Imprimante" Then
            txt_prixu.Text = 500
        ElseIf lst_prod.SelectedItem = "Ordinateur" Then
            txt_prixu.Text = 1000

        End If
        p = txt_prixu.Text * txt_qtn.Text
        txt_mtn.Text = p

    End Sub

    Private Sub btn_ajout_Click(sender As Object, e As EventArgs) Handles btn_ajout.Click
        Dim a2, a3, a4 As Integer
        Dim a1 As String
        Dim somme, somme2, somme3 As Integer
        a1 = lst_prod.SelectedItem
        a2 = txt_prixu.Text
        a3 = txt_qtn.Text
        a4 = txt_mtn.Text
        lst_pr.Items.Add(a1)
        lst_prixu.Items.Add(a2)
        lst_qtn.Items.Add(a3)
        lst_mtn.Items.Add(a4)
        For Each item As Integer In lst_prixu.Items
            somme += item

        Next
        For Each item As Integer In lst_qtn.Items
            somme2 += item

        Next
        For Each item As Integer In lst_mtn.Items
            somme3 += item

        Next
        txt_totpu.Text = somme
        txt_totq.Text = somme2
        txt_totmh.Text = somme3
        txt_tva.Text = txt_totmh.Text * 1.2
        If (txt_tva.Text >= 1000) Then
            txt_r.Text = txt_tva.Text * 0.99
        End If
    End Sub

    Private Sub btn_modif_Click(sender As Object, e As EventArgs) Handles btn_modif.Click
        txt_qtn.Clear()
        txt_mtn.Clear()

        If lst_mtn.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_mtn.Items.RemoveAt(lst_mtn.Items.Count - 1)
        End If
        If lst_pr.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_pr.Items.RemoveAt(lst_pr.Items.Count - 1)
        End If
        If lst_prixu.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_prixu.Items.RemoveAt(lst_prixu.Items.Count - 1)
        End If
        If lst_qtn.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_qtn.Items.RemoveAt(lst_qtn.Items.Count - 1)
        End If

    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        txt_qtn.Clear()
        txt_mtn.Clear()
        txt_prixu.Clear()

        If lst_mtn.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_mtn.Items.RemoveAt(lst_mtn.Items.Count - 1)
        End If
        If lst_pr.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_pr.Items.RemoveAt(lst_pr.Items.Count - 1)
        End If
        If lst_prixu.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_prixu.Items.RemoveAt(lst_prixu.Items.Count - 1)
        End If
        If lst_qtn.Items.Count > 0 Then
            ' Remove the last item in the list
            lst_qtn.Items.RemoveAt(lst_qtn.Items.Count - 1)
        End If
    End Sub

    Private Sub btn_payer_Click(sender As Object, e As EventArgs) Handles btn_payer.Click
        Dim s As Integer = 4500
        If s >= txt_r.Text Then
            txt_code.Text = " Fini "
        Else
            txt_code.Text = " Solde insuffisant "
        End If
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class