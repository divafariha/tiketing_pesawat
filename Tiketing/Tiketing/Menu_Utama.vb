Public Class Menu_Utama

    Private Sub Menu_Utama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Yakin ingin keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim keluar = MsgBox("Yakin ingin keluar aplikasi?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Konfirmasi")
        If keluar = vbYes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tambah_Pesanan.ShowDialog()
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        e.DrawBackground()
        e.Graphics.FillRectangle(Brushes.Aqua, e.Bounds)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
        Tambah_Pesanan.Close()
    End Sub
End Class