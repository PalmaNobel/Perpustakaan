Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("User Name & Password Harus Di Isi", MsgBoxStyle.OkOnly, "Perhatian")
        Else
            If TextBox1.Text = "" Then
                MsgBox("User Name Belum Di Isi", MsgBoxStyle.OkOnly, "Perhatian")
            Else
                If TextBox2.Text = "" Then
                    MsgBox("Password Belum Di Isi", MsgBoxStyle.OkOnly, "Perhatian")
                Else
                    If TextBox1.Text = "perpal" And TextBox2.Text = "perpuskeren" Then
                        MsgBox("Welcome", MsgBoxStyle.OkOnly, "Sukses")
                        beranda.show()
                        Call kosong()
                        Me.Hide()
                    Else
                        MsgBox("User Name / Password yang Anda Masukkan Salah", MsgBoxStyle.OkOnly, "perhatian")
                        Call kosong()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call kosong()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosong()
    End Sub
    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class