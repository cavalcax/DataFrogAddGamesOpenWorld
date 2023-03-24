Public Class frmDonate

  Private Sub btnPayPal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayPal.Click
    Process.Start("https://www.paypal.com/donate/?business=3CXA66L7FJDFC&no_recurring=0&currency_code=BRL")
  End Sub

  Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
    My.Computer.Clipboard.SetText("guto.cavalca@gmail.com")

    MessageBox.Show("Email copiado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub
End Class