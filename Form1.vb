Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim weight As Double
        Dim cost As String
        weight = Val(TextBox1.Text)
        Select Case weight
            Case Is <= 2
                cost = 2.5
            Case 2.1 To 5
                cost = 3.8
            Case 5.1 To 10
                cost = 6.0
            Case 10.1 To 20
                cost = 10
            Case Is > 20
                cost = "unacceptable"
        End Select
        TextBox2.Text = cost
    End Sub
End Class
