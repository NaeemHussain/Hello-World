'Project:   	The Flag Viewer
'Programmer:	Naeem Hussain
'Date: 		    02-02-2017
'Description: 	This project Displays The flags Viewer of four countries, United states, japan, canada, mexico and also these names in a label and three check box to show The title, country Name and Programmer.

Public Class MainForm
    Private Sub UnitedStatesRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitedStatesRadioButton.CheckedChanged
        'Display the flag image of United Country, set the visible to true, and display name"United states"
        FlagPictureBox.Image = My.Resources.US
        FlagPictureBox.Visible = True
        CountryNameLabel.Text = "United States"
        CountryNameLabel.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    Private Sub JapanRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JapanRadioButton.CheckedChanged
        'Display the flag of japan and the name.
        FlagPictureBox.Image = My.Resources.japanflag
        CountryNameLabel.Text = "Japan"
    End Sub
    Private Sub CanadaRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanadaRadioButton.CheckedChanged
        'Display the flag of Canada and the name.
        FlagPictureBox.Image = My.Resources.canadaflag
        CountryNameLabel.Text = "Canada"

    End Sub
    Private Sub MexicoRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MexicoRadioButton.CheckedChanged
        'Display the flag of Mexico and the name.
        FlagPictureBox.Image = My.Resources.maxicoflag
        CountryNameLabel.Text = "Mexico"
    End Sub
    Private Sub TitleCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleCheckBox.CheckedChanged
        'Display show the flag on form
        FlagLabel.Visible = True
    End Sub
    Private Sub CountryNameCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryNameCheckBox.CheckedChanged
        'Display show the country name on form
        CountryNameLabel.Visible = True
    End Sub
    Private Sub ProgrammerCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgrammerCheckBox.CheckedChanged
        'Display show the Programmer name on form
        ProgrammerLabel.Visible = True
    End Sub
    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        'Print the form
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
    Private Sub ExitButton_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'Close the project
        Me.Close()
    End Sub
End Class
