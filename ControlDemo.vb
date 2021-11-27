Public Class frmCtrlDemo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxD.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxS.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblStotal.Click
        lblStotal.Text = lblStotal.Text & listBoxS.Items.Count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnStoD.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDtoS.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDtotal.Click
        lblDtotal.Text = lblDtotal.Text & listBoxD.Items.Count
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRemCity.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddCity.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class