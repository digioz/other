' ***************************************
' DigiOz Pocket PC Temperature Converter
' Author:  Pete Soheil
' Date:    9/25/2007
' Version: 1.0
' Website: http://www.digioz.com
' ***************************************

Public Class frmMain

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        Dim tc As New digioz.Temperature

        If Not IsNumeric(txtFromUnit.Text) Then
            txtOutput.Text = "Enter Numeric Value"
            txtFromUnit.Text = ""
            txtFromUnit.Focus()
            Exit Sub
        End If

        If cmbType.SelectedItem = "Fahrenheit to Celsius" Then
            txtOutput.Text = tc.FahrenheitToCelsius(txtFromUnit.Text, 2)
        ElseIf cmbType.SelectedItem = "Celsius to Fahrenheit" Then
            txtOutput.Text = tc.CelsiusToFahrenheit(txtFromUnit.Text, 2)
        ElseIf cmbType.SelectedItem = "Fahrenheit to Kelvin" Then
            txtOutput.Text = tc.FahrenheitToKelvin(txtFromUnit.Text, 2)
        ElseIf cmbType.SelectedItem = "Kelvin to Fahrenheit" Then
            txtOutput.Text = tc.KelvinToFahrenheit(txtFromUnit.Text, 2)
        ElseIf cmbType.SelectedItem = "Celsius to Kelvin" Then
            txtOutput.Text = tc.CelsiusToKelvin(txtFromUnit.Text, 2)
        ElseIf cmbType.SelectedItem = "Kelvin to Celsius" Then
            txtOutput.Text = tc.KelvinToCelsius(txtFromUnit.Text, 2)
        Else
            txtOutput.Text = "Invalid Combo Selection"
        End If
    End Sub

End Class
