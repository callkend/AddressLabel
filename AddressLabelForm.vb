'Kendal Callister
'RCET0265
'Spring 2021
'Address label program
'

Option Explicit On
Option Strict On

Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = FirstNameTextBox.Text + " " + LastNameTextBox.Text + vbCrLf
        DisplayLabel.Text += StreetAddressTextBox.Text + vbCrLf
        DisplayLabel.Text += CityTextBox.Text + ", " + StateTextBox.Text + " " + ZipTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = String.Empty
    End Sub
End Class
