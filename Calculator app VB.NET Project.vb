Imports System.Drawing.Text

Public Class Calculator

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Button1.Click,
        Button2.Click,
        Button3.Click,
        Button4.Click,
        Button5.Click,
        Button6.Click,
        Button7.Click,
        Button8.Click,
        Button9.Click

        Dim ButtonValue As Button = CType(sender, Button)

        TextBox1.Text &= ButtonValue.Text
    End Sub

    Private Sub Button0_Zero(sender As Object, e As EventArgs) Handles Button0.Click
        If TextBox1.Text = String.Empty Then

        Else
            TextBox1.Text &= "0"

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text = String.Empty Then
            TextBox1.Text &= "0."
        ElseIf Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub Button11_Clear(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = String.Empty
    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles ButtonPlus.Click,
            ButtonMinus.Click,
            ButtonMul.Click,
            ButtonDiv.Click


        TextBox1.Text &= CType(sender, Button).Text



    End Sub

    Private Sub EqualsTo(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            Dim expression As String = TextBox1.Text
            Dim result As Object
            Dim table As New DataTable
            result = table.Compute(expression, String.Empty)
            TextBox1.Text = result.ToString
        Catch ex As Exception
            TextBox1.Text = "Expression Invalid"

        End Try
    End Sub
End Class
