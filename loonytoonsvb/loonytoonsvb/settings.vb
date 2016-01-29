Public Class settings
    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBxLife.Text = My.Settings.life.ToString
        txtBxWidth.Text = My.Settings.gamewidth
        txtBxHeight.Text = My.Settings.gameheight
        If My.Settings.diff = 0 Then
            ComboBox1.Text = "Easy"
        Else
            ComboBox1.Text = "Difficult"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBxLife.Text <> "" Then
            My.Settings.life = txtBxLife.Text
        End If
        If ComboBox1.Text = "Easy" Then
            My.Settings.diff = 0
        Else
            My.Settings.diff = 1
        End If
        If txtBxWidth.Text <> "" Then
            My.Settings.gamewidth = txtBxWidth.Text
        End If
        If txtBxHeight.Text <> "" Then
            My.Settings.gameheight = txtBxHeight.Text
        End If
        My.Settings.Save()
        Me.Close()
    End Sub
End Class