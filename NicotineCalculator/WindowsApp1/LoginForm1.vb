Imports MySql.Data.MySqlClient


Public Class LoginForm1
    Dim username As String
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=userNic")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        connection.Open()
        username = UsernameTextBox.Text
        Dim command As New MySqlCommand("SELECT user, pass FROM logininfo2.user2table WHERE user = @username AND pass = @password;", connection)
        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = UsernameTextBox.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PasswordTextBox.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid Username Or Password")


        Else

            MessageBox.Show("Welcome " + username)

            Dim newForm As New Form1()
            newForm.Show()
            Me.Hide()



        End If

        connection.Close()





    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim Form As New signUpForm()
        signUpForm.Show()
        Me.Hide()

    End Sub
End Class
