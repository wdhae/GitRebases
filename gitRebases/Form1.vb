Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(String.Format("Hello, {0} !!", TextBox1.Text))
    End Sub
End Class
