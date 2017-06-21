Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox1.Items.Add("°C")
        ComboBox1.Items.Add("°R")
        ComboBox1.Items.Add("°F")
        ComboBox1.Items.Add("°K")
        ComboBox2.Items.Add("°C")
        ComboBox2.Items.Add("°R")
        ComboBox2.Items.Add("°F")
        ComboBox2.Items.Add("°K")
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim suhu As String
        suhu = TextBox1.Text
        If ComboBox1.SelectedItem = "°R" And ComboBox2.SelectedItem = "°C" Then
            TextBox2.Text = (4 / 5) * suhu
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°F" And ComboBox2.SelectedItem = "°C" Then
            TextBox2.Text = (9 / 5) * suhu + 32
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°K" And ComboBox2.SelectedItem = "°C" Then
            TextBox2.Text = suhu + 273
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°C" And ComboBox2.SelectedItem = "°R" Then
            TextBox2.Text = (5 / 4) * suhu
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°F" And ComboBox2.SelectedItem = "°R" Then
            TextBox2.Text = (9 / 4) * suhu + 32
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°K" And ComboBox2.SelectedItem = "°R" Then
            TextBox2.Text = (5 / 4) * suhu + 273
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°C" And ComboBox2.SelectedItem = "°F" Then
            TextBox2.Text = (5 / 9) * (suhu - 32)
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°R" And ComboBox2.SelectedItem = "°F" Then
            TextBox2.Text = (4 / 9) * (suhu - 32)
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°K" And ComboBox2.SelectedItem = "°F" Then
            TextBox2.Text = (5 / 9) * (suhu - 32) + 273
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°C" And ComboBox2.SelectedItem = "°K" Then
            TextBox2.Text = suhu - 273
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°R" And ComboBox2.SelectedItem = "°K" Then
            TextBox2.Text = (4 / 5) * (suhu - 273)
            Label4.Text = ComboBox1.Text
        ElseIf ComboBox1.SelectedItem = "°F" And ComboBox2.SelectedItem = "°K" Then
            TextBox2.Text = (9 / 5) * (suhu - 273) + 32
            Label4.Text = ComboBox1.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        Label4.Text = ""
    End Sub
End Class
