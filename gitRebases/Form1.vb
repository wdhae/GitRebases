Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(String.Format("Hello, {0} , {1} !!", TextBox1.Text, TextBox2.Text()))
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show(String.Format("Feature X for {0} ! ", TextBox1.Text))
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show(String.Format("Feature Y:" & Environment.NewLine() & "Text1 : {0} !!" & Environment.NewLine() & "Text2 : {1} !!!", TextBox1.Text, TextBox2.Text()))
    End Sub
End Class
