Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim results As Integer

        If IsNumeric(txtMark.Text) = True Then
            results = txtMark.Text
            If results < 0 Or results > 100 Then
                MsgBox("invalid results entered")

            ElseIf results < 50 Then
                MsgBox("You Failed!")

            ElseIf results > 50 Then
                MsgBox("You Passed!")

            End If




        End If
    End Sub
End Class
