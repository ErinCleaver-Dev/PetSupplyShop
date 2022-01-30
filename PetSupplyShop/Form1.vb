Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductList.SelectedIndexChanged
        txtTest.Text = ProductList.SelectedItem
    End Sub
End Class
