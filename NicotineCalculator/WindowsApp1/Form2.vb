Imports MySql.Data.MySqlClient
Public Class signUpForm
    'Todo:
    'Swap strings as .texts
    'dfgfdg
    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=Artificial1!1!")



    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim passcheck1 As String = txtPassword.Text
        Dim passcheck2 As String = txtConfirmPass.Text
        Dim user As String = txtUsername.Text
        Dim purpose As String = cbPurpose.Text

        If passcheck1 = "" Or user = "" Or purpose = "" Then
            MessageBox.Show("Please Fill out all fields")

        Else

            If passcheck1 <> passcheck2 Then

                MessageBox.Show("Passwords Do Not Match")

            Else
                connection.Open()

                Dim command2 As New MySqlCommand("INSERT INTO logininfo2.user2table (user, pass, DOB, Purpose) VALUES (@user, @pass, @dateOfBirth, @Purpose);", connection)
                Dim command1 As New MySqlCommand("SELECT user FROM logininfo2.user2table WHERE user = @user;", connection)
                Dim adapter2 As New MySqlDataAdapter(command2)
                Dim adapter1 As New MySqlDataAdapter(command1)
                Dim table2 As New DataTable()
                Dim table1 As New DataTable()

                command1.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsername.Text

                command2.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsername.Text
                command2.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text
                command2.Parameters.Add("@dateOfBirth", MySqlDbType.VarChar).Value = dtpBirthday.Text
                command2.Parameters.Add("@Purpose", MySqlDbType.VarChar).Value = cbPurpose.Text


                adapter1.Fill(table1)

                If table1.Rows.Count >= 1 Then

                    MessageBox.Show("Username is already taken")
                    connection.Close()


                Else

                    adapter2.Fill(table2)

                    connection.Close()

                    MessageBox.Show("Thank you for signing up, Please Login")
                    Dim Form As New LoginForm1()
                    Form.Show()
                    Me.Hide()



                End If



            End If

        End If













    End Sub

    Private Sub btnCancelSignUp_Click(sender As Object, e As EventArgs) Handles btnCancelSignUp.Click
        Dim Form As New LoginForm1()
        Form.Show()
        Me.Hide()



    End Sub
End Class