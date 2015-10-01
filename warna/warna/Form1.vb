Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Aqua Then
            Me.BackColor = Color.Lime
        Else
            Me.BackColor = Color.Aqua
        End If
    End Sub
End Class
