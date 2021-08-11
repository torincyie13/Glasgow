Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Dues As New Dues
        Dim monthlyDues As Double
        Dim additionalFee As Double
        Dim basicFee As Double


        Dues = New Dues(radSingle.Checked, radFamily.Checked, cbGolf.Checked, cbTennis.Checked, cbRacquet.Checked)
        monthlyDues = Dues.GetMonthlyDues()

        lblMonthlyDues.Text = monthlyDues.ToString("C0")

        If (radSingle.Checked) Then

            If (cbGolf.Checked) Then
                additionalFee += 25
            End If

            If (cbTennis.Checked) Then
                additionalFee += 30
            End If

            If (cbRacquet.Checked) Then
                additionalFee += 20
            End If

            basicFee = 50
        Else
            If (cbGolf.Checked) Then
                additionalFee += 35
            End If

            If (cbTennis.Checked) Then
                additionalFee += 50
            End If

            If (cbRacquet.Checked) Then
                additionalFee += 30
            End If

            basicFee = 90
        End If

        lblBasicFee.Text = basicFee.ToString("C0")
        lblAdditionalFee.Text = additionalFee.ToString("C0")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
