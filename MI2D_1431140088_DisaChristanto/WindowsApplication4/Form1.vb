Public Class Form1


    Private Sub layarButton_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub ubahButton_Click(sender As Object, e As EventArgs) Handles ubahButton.Click
        If Me.BackColor() = Color.Chocolate Then
            Me.BackColor() = Color.White
        Else
            Me.BackColor() = Color.Chocolate
        End If
    End Sub
End Class
