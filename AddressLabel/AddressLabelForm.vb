'Joshua Makuch
'RCET 0265
'Spring 2023
'Address Label Program
'https://github.com/JoshuaMakuch/AddressLabel.git

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

    'Creats A Tool Tip sub that provides tool tips for each label and button
    Private Sub AddressLabelForm_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        ' Create the ToolTip and associate with the Form container.
        Dim toolTip1 As New ToolTip()

        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 500
        toolTip1.ReshowDelay = 500

        ' Set up the ToolTip text for the Labels and Buttons.
        toolTip1.SetToolTip(Me.FirstNameLabel, "The Sender's First Name")
        toolTip1.SetToolTip(Me.LastNameLabel, "The Sender's Last Name")
        toolTip1.SetToolTip(Me.StreetAddressLabel, "The Sender's Street Address")
        toolTip1.SetToolTip(Me.CityLabel, "The Sender's City")
        toolTip1.SetToolTip(Me.StateLabel, "The Sender's State ie. ID, HI, CA, TX")
        toolTip1.SetToolTip(Me.ZipLabel, "The Sender's Zip Code")
        toolTip1.SetToolTip(Me.DisplayButton, "Formats and Displays Users Address")
        toolTip1.SetToolTip(Me.ClearButton, "Clears The Current Label")
        toolTip1.SetToolTip(Me.ExitButton, "Exits The Form")
    End Sub

End Class
