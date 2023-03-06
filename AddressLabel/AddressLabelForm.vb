Public Class AddressLabelForm

    'Whenever the display button is pressed it formats all values from the textboxes and outputs a label
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = $"{FirstNameTextBox.Text} {LastNameTextBox.Text}{vbCrLf}"
        DisplayLabel.Text = $"{DisplayLabel.Text}{StreetAddressTextBox.Text}{vbCrLf}"
        DisplayLabel.Text = $"{DisplayLabel.Text}{CityTextBox.Text}, {StateTextBox.Text} {ZipTextBox.Text}"
    End Sub

    'Sets the textbox to blank
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    'Closes the entire form when the exit button is pressed at any point in time
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
