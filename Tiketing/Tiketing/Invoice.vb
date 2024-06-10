Public Class Invoice

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pintu As New Random()

        Label16.Text = pintu.Next(9).ToString()
        Label2.Text = Tambah_Pesanan.kelas
        Label4.Text = Tambah_Pesanan.noTiket
        Label9.Text = Tambah_Pesanan.namaPembeli
        Label10.Text = Tambah_Pesanan.asal
        Label11.Text = Tambah_Pesanan.tujuan
        Label12.Text = Tambah_Pesanan.jadwal

        Dim namaMaskapai As String = Tambah_Pesanan.maskapai
        Dim rsc As Bitmap
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        If namaMaskapai = "GARUDA" Then
            rsc = My.Resources.GarudaIndonesia
            PictureBox1.Image = rsc
        ElseIf namaMaskapai = "CITILINK" Then
            rsc = My.Resources.Citilink
            PictureBox1.Image = rsc
        ElseIf namaMaskapai = "LION AIR" Then
            rsc = My.Resources.LionAir
            PictureBox1.Image = rsc
        ElseIf namaMaskapai = "AIR ASIA" Then
            rsc = My.Resources.AirAsia
            PictureBox1.Image = rsc
        End If


        'save as image
        Dim frm = Me
        Dim namaFolder As String = "E-Tiket"
        Dim namaFile As String = Tambah_Pesanan.noTiket
        frm.FormBorderStyle = FormBorderStyle.None
        Using bmp = New Bitmap(frm.Width, frm.Height)
            frm.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))

            If (Not System.IO.Directory.Exists("D:\" & namaFolder & "\")) Then
                System.IO.Directory.CreateDirectory("D:\" & namaFolder & "\")
            End If

            bmp.Save("D:\" & namaFolder & "\" & namaFile & ".png")
        End Using
        frm.FormBorderStyle = FormBorderStyle.FixedSingle

        MsgBox("Invoice telah disimpan di Folder E-Tiket", MsgBoxStyle.OkOnly, "Informasi")
    End Sub
End Class