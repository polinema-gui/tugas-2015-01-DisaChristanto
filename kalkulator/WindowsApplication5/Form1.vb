Public Class Form1
    Dim f As Integer
    Dim hasil As Byte

    
    Private Sub Bt0_Click(sender As Object, e As EventArgs) Handles Bt0.Click
        If (cekIsi()) Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text &= "0"
        End If
    End Sub
    Private Sub Bt1_Click(sender As Object, e As EventArgs) Handles Bt1.Click
        If (cekIsi()) Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text &= "1"
        End If
    End Sub
    Private Sub Bt2_Click(sender As Object, e As EventArgs) Handles Bt2.Click
        If (cekIsi()) Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text &= "2"
        End If
    End Sub
    Private Sub Bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        If (cekIsi()) Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text &= "3"
        End If
    End Sub
    Private Sub Bt4_Click(sender As Object, e As EventArgs) Handles Bt4.Click
        If (cekIsi()) Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text &= "4"
        End If
    End Sub
   
    Private Sub Bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        If (cekIsi()) Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text &= "6"
        End If
    End Sub
    Private Sub Bt7_Click(sender As Object, e As EventArgs) Handles Bt7.Click
        If (cekIsi()) Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text &= "7"
        End If
    End Sub
    Private Sub Bt8_Click(sender As Object, e As EventArgs) Handles Bt8.Click
        If (cekIsi()) Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text &= "8"
        End If
    End Sub
    Private Sub Bt5_Click(sender As Object, e As EventArgs) Handles Bt9.Click
        If (cekIsi()) Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text &= "9"
        End If
    End Sub
    Private Function cekIsi()
        If (TextBox1.Text.Equals("0") Or Me.hasil> 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles btclr.Click
        TextBox1.Text = "0"
        Me.f = 0
        Me.hasil = 0
    End Sub

    Private Sub Btkrng_Click(sender As Object, e As EventArgs) Handles btkrng.Click
        If (Me.f = 0 Or Me.hasil = 2) Then
            Me.f += Convert.ToInt32(TextBox1.Text)
        Else
            Me.f -= Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.f.ToString
        Me.hasil = 1
    End Sub
   

    Private Sub Bt5_Click_1(sender As Object, e As EventArgs) Handles Bt5.Click
        If (cekIsi()) Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text &= "5"
        End If
    End Sub

    Private Sub btsmdn_Click(sender As Object, e As EventArgs) Handles btsmdn.Click
        Select Case Me.hasil

            Case 1
                TextBox1.Text = Convert.ToString(Me.f - Convert.ToInt32(TextBox1.Text))
            Case 2
                TextBox1.Text = Convert.ToString(Me.f + Convert.ToInt32(TextBox1.Text))
        End Select
        Me.f = 0
    End Sub

    Private Sub btpls_Click(sender As Object, e As EventArgs) Handles btpls.Click
        If (Me.hasil = 1) Then
            Me.f -= Convert.ToInt32(TextBox1.Text)
        Else
            Me.f += Convert.ToInt32(TextBox1.Text)
        End If
        TextBox1.Text = Me.f.ToString
        Me.hasil = 2
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Background_Click(sender As Object, e As EventArgs) Handles Background.Click
        If Me.BackColor() = Color.White Then
            Me.BackColor() = Color.Black
        Else
            Me.BackColor() = Color.White
        End If
    End Sub
End Class

