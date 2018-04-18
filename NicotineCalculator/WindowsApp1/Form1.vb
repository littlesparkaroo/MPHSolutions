Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Try

            'Assigning input values to Decimals' 
            Dim liquidVaped As Decimal = CDec(txtLiquid.Text)
            Dim mgPerMl As Decimal = CDec(txtMgml.Text)
            Dim cost As Decimal = CDec(txtCostML.Text)
            Dim efficiency As Decimal = CDec(cbEfficiency.SelectedItem)


            'Calculating results'
            Dim efficiencyPercent = efficiency / 100
            Dim todaysCost = Decimal.Round(cost * liquidVaped, 2)
            Dim nicotineIntake = Decimal.Round(liquidVaped * mgPerMl * efficiencyPercent)
            Dim cig1 = Decimal.Round(nicotineIntake / 1.4)
            Dim cig2 = Decimal.Round(nicotineIntake / 0.6)

            'Output of values to results labels'
            lblNicotineAnswer.Text = CStr(nicotineIntake) + "mg"
            lblCostAnswer.Text = "$" + CStr(todaysCost)
            lblCigAnswer.Text = "~ " + CStr(cig1) + "-" + CStr(cig2) + " Cigarettes"

        Catch ex As Exception

            MessageBox.Show("An Unknown Error Occured.",
                            "Error")


        End Try


    End Sub

    Private Sub cbEfficiency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEfficiency.SelectedIndexChanged

    End Sub

    Private Sub btnCostCalculator_Click(sender As Object, e As EventArgs) Handles btnCostCalculator.Click

        Try

            'Hides the cost/ml textbox and shows cost/ml calculator'
            txtCostML.Visible = False
            lblSizeOfBottle.Visible = True
            txtSizeOfBottle.Visible = True
            LblCostOfBottle.Visible = True
            txtCostOfBottle.Visible = True
            btnCalcCostMl.Visible = True
            lblMlLabel.Visible = True
            lblDollarsCostOfBottle.Visible = True


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalcCostMl_Click(sender As Object, e As EventArgs) Handles btnCalcCostMl.Click

        Try

            'Assigning input values to decimals (Cost/ML Calculator)
            Dim sizeOfBottle As Decimal = CDec(txtSizeOfBottle.Text)
            Dim costOfBottle As Decimal = CDec(txtCostOfBottle.Text)

            'Calculated Cost/ML'
            Dim calculatedCostMl = Decimal.Round(costOfBottle / sizeOfBottle, 4)

            'Outputs calculated Cost/ML to hidden Cost/ML TextBox'
            txtCostML.Text = CStr(calculatedCostMl)

            'Shows hidden Cost/ML Textbox and hides Cost/ML Calculator'
            txtCostML.Visible = True
            lblSizeOfBottle.Visible = False
            txtSizeOfBottle.Visible = False
            LblCostOfBottle.Visible = False
            txtCostOfBottle.Visible = False
            btnCalcCostMl.Visible = False
            lblMlLabel.Visible = False
            lblDollarsCostOfBottle.Visible = False


        Catch ex As Exception

        End Try


    End Sub

    Private Sub lblDollarsCostOfBottle_Click(sender As Object, e As EventArgs) Handles lblDollarsCostOfBottle.Click

    End Sub

    Private Sub lblMlLabel_Click(sender As Object, e As EventArgs) Handles lblMlLabel.Click

    End Sub

    Private Sub lblCostMlLabel_Click(sender As Object, e As EventArgs) Handles lblCostMlLabel.Click

    End Sub

    Private Sub lblPercent_Click(sender As Object, e As EventArgs) Handles lblPercent.Click

    End Sub

    Private Sub lblMgMlLabel_Click(sender As Object, e As EventArgs) Handles lblMgMlLabel.Click

    End Sub

    Private Sub lblCostMl_Click(sender As Object, e As EventArgs) Handles lblCostMl.Click

    End Sub
End Class
