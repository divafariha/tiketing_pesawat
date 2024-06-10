Public Class Tambah_Pesanan

    Public noTiket, namaPembeli, jenisKelamin, alamat, nik, noHP, maskapai, kelas, asal, tujuan, totalPenumpang, totalDiskon, totalbayar As String
    Public jadwal As String = "dd MMM yyyy"
    Public iterasi As Integer = 1

    Private Sub Tambah_Pesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        RadioButton1.Select()
        TextBox1.Select()
        Button1.Enabled = False
        TextBox6.Enabled = False

        DateTimePicker1.Value = DateTime.Now
        DateTimePicker1.MinDate = DateTime.Now
    End Sub

    Dim hargaDewasa, hargaAnak, totalHarga, diskon, jumlahDewasa, jumlahAnak, totalDewasa, totalAnak, totalSetelahDiskon As Double
    Dim namaMaskapai, namaKelas, namaAsal, namaTujuan As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        totalHarga = (totalAnak + totalDewasa)
        If totalHarga > 2500000 Then
            diskon = totalHarga * 0.05
            Label14.Text = "Disc 5%"
        Else
            diskon = 0
            Label14.Text = "Disc 0%"
        End If

        totalSetelahDiskon = totalHarga - diskon

        TextBox7.Text = Format(Val(diskon), "Rp ###,###,###,0")
        Label22.Text = Format(totalSetelahDiskon, "Rp ###,###,###,0")
        TextBox6.Enabled = True
        TextBox6.Focus()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        namaMaskapai = ComboBox1.SelectedValue
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        namaKelas = ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        namaAsal = ComboBox3.SelectedItem
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        namaTujuan = ComboBox4.SelectedItem

        If (namaAsal <> namaTujuan) Then
            If (namaAsal = "JAKARTA" And namaTujuan = "YOGYAKARTA") Or (namaAsal = "YOGYAKARTA" And namaTujuan = "JAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 300000
                    hargaAnak = 200000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 400000
                    hargaAnak = 300000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 500000
                    hargaAnak = 400000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "JAKARTA" And namaTujuan = "SOLO") Or (namaAsal = "SOLO" And namaTujuan = "JAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 500000
                    hargaAnak = 400000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 600000
                    hargaAnak = 500000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 700000
                    hargaAnak = 600000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "JAKARTA" And namaTujuan = "SURABAYA") Or (namaAsal = "SURABAYA" And namaTujuan = "JAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 800000
                    hargaAnak = 700000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 900000
                    hargaAnak = 800000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 1000000
                    hargaAnak = 900000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "JAKARTA" And namaTujuan = "DENPASAR") Or (namaAsal = "DENPASAR" And namaTujuan = "JAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 1100000
                    hargaAnak = 1000000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 1200000
                    hargaAnak = 1100000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 1300000
                    hargaAnak = 1200000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "YOGYAKARTA" And namaTujuan = "SOLO") Or (namaAsal = "SOLO" And namaTujuan = "YOGYAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 250000
                    hargaAnak = 150000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 350000
                    hargaAnak = 250000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 450000
                    hargaAnak = 250000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "YOGYAKARTA" And namaTujuan = "SURABAYA") Or (namaAsal = "SURABAYA" And namaTujuan = "YOGYAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 550000
                    hargaAnak = 450000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 650000
                    hargaAnak = 550000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 750000
                    hargaAnak = 650000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "YOGYAKARTA" And namaTujuan = "DENPASAR") Or (namaAsal = "DENPASAR" And namaTujuan = "YOGYAKARTA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 950000
                    hargaAnak = 850000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 1050000
                    hargaAnak = 950000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 1150000
                    hargaAnak = 1050000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "SOLO" And namaTujuan = "SURABAYA") Or (namaAsal = "SURABAYA" And namaTujuan = "SOLO") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 350000
                    hargaAnak = 250000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 450000
                    hargaAnak = 350000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 550000
                    hargaAnak = 450000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "SOLO" And namaTujuan = "DENPASAR") Or (namaAsal = "DENPASAR" And namaTujuan = "SOLO") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 650000
                    hargaAnak = 550000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 750000
                    hargaAnak = 650000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 850000
                    hargaAnak = 750000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            ElseIf (namaAsal = "SURABAYA" And namaTujuan = "DENPASAR") Or (namaAsal = "DENPASAR" And namaTujuan = "SURABAYA") Then
                If namaKelas = "EKONOMI" Then
                    hargaDewasa = 400000
                    hargaAnak = 300000
                ElseIf namaKelas = "BISNIS" Then
                    hargaDewasa = 500000
                    hargaAnak = 400000
                ElseIf namaKelas = "VIP" Then
                    hargaDewasa = 600000
                    hargaAnak = 500000
                Else
                    hargaDewasa = 0
                    hargaAnak = 0
                End If
            Else
                hargaDewasa = 0
                hargaAnak = 0
            End If
            'TextBox8.Text = "RP. " & Format(hargaDewasa, "###,###,###")
            'TextBox9.Text = "RP. " & Format(hargaAnak, "###,###,###")
        Else
            MsgBox("Tujuan tidak boleh sama!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Peringatan!")
            ComboBox4.Text = ""
            ComboBox4.Focus()
        End If

        Button1.Enabled = True
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        jumlahDewasa = NumericUpDown1.Value
        totalDewasa = jumlahDewasa * hargaDewasa
        TextBox8.Text = Format(totalDewasa, "Rp ###,###,###,0")
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        jumlahAnak = NumericUpDown2.Value
        totalAnak = jumlahAnak * hargaAnak
        TextBox9.Text = Format(totalAnak, "Rp ###,###,###,0")
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim uangTunai, uangKembalian As Double

        uangTunai = Val(TextBox6.Text)
        uangKembalian = uangTunai - totalSetelahDiskon
        TextBox10.Text = Format(uangKembalian, "Rp ###,###,###,0")

        If uangTunai >= totalSetelahDiskon Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    'tombol cetak & simpan ke listview
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'mulai isi listview
        Dim kode As String = DateAndTime.Now.ToString("yyMMddHHmmss")
        noTiket = "NF-" & kode
        namaPembeli = TextBox1.Text
        If RadioButton1.Checked = True Then
            jenisKelamin = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            jenisKelamin = RadioButton2.Text
        End If
        alamat = TextBox2.Text
        nik = TextBox3.Text
        noHP = TextBox4.Text
        jadwal = DateTimePicker1.Text
        maskapai = ComboBox1.SelectedItem
        kelas = ComboBox2.SelectedItem
        asal = ComboBox3.SelectedItem
        tujuan = ComboBox4.SelectedItem
        totalPenumpang = jumlahDewasa + jumlahAnak
        totalDiskon = Format(diskon, "Rp ###,###,###,0")
        totalbayar = Format(totalSetelahDiskon, "Rp ###,###,###,0")

        'Isi ke listview
        Dim lv As ListViewItem
        lv = Menu_Utama.ListView1.Items.Add(iterasi)
        lv.SubItems.Add(Me.noTiket)
        lv.SubItems.Add(Me.namaPembeli)
        lv.SubItems.Add(Me.alamat)
        lv.SubItems.Add(Me.jenisKelamin)
        lv.SubItems.Add(Me.nik)
        lv.SubItems.Add(Me.noHP)
        lv.SubItems.Add(Me.jadwal)
        lv.SubItems.Add(Me.maskapai)
        lv.SubItems.Add(Me.kelas)
        lv.SubItems.Add(Me.asal)
        lv.SubItems.Add(Me.tujuan)
        lv.SubItems.Add(Me.totalPenumpang)
        lv.SubItems.Add(Me.totalDiskon)
        lv.SubItems.Add(Me.totalbayar)
        iterasi += 1
        'akhir isi listview

        'clear data
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        RadioButton1.Select()
        DateTimePicker1.Text = DateAndTime.Now
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        Button2.Enabled = False
        Label14.Text = "     "
        Label22.Text = "     "
        TextBox1.Focus()
        Button1.Enabled = False
        TextBox6.Enabled = False
        Dim inv As Invoice = New Invoice
        inv.ShowDialog()
    End Sub

    'button ulangi
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        RadioButton1.Select()
        DateTimePicker1.Text = DateAndTime.Now
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        Button2.Enabled = False
        TextBox6.Enabled = False
        Label14.Text = "     "
        Label22.Text = "     "
        TextBox1.Focus()
    End Sub

    'button tutup
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        RadioButton1.Select()
        DateTimePicker1.Text = DateAndTime.Now
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        Button2.Enabled = False
        TextBox6.Enabled = False
        Label14.Text = "     "
        Label22.Text = "     "
        Me.Hide()
    End Sub
End Class