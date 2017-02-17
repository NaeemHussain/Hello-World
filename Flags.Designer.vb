<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PrintButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.FlagLabel = New System.Windows.Forms.Label
        Me.CountryNameLabel = New System.Windows.Forms.Label
        Me.ProgrammerLabel = New System.Windows.Forms.Label
        Me.UnitedStatesRadioButton = New System.Windows.Forms.RadioButton
        Me.CanadaRadioButton = New System.Windows.Forms.RadioButton
        Me.JapanRadioButton = New System.Windows.Forms.RadioButton
        Me.MexicoRadioButton = New System.Windows.Forms.RadioButton
        Me.TitleCheckBox = New System.Windows.Forms.CheckBox
        Me.CountryNameCheckBox = New System.Windows.Forms.CheckBox
        Me.ProgrammerCheckBox = New System.Windows.Forms.CheckBox
        Me.CountryGroupBox = New System.Windows.Forms.GroupBox
        Me.FlagPictureBox = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CountryGroupBox.SuspendLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintButton
        '
        Me.PrintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.Location = New System.Drawing.Point(400, 359)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 28)
        Me.PrintButton.TabIndex = 0
        Me.PrintButton.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.PrintButton, "Print the form")
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(482, 359)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 28)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Close the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FlagLabel
        '
        Me.FlagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlagLabel.Location = New System.Drawing.Point(229, 48)
        Me.FlagLabel.Name = "FlagLabel"
        Me.FlagLabel.Size = New System.Drawing.Size(160, 31)
        Me.FlagLabel.TabIndex = 2
        Me.FlagLabel.Text = "Flag Viewer"
        Me.FlagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlagLabel.Visible = False
        '
        'CountryNameLabel
        '
        Me.CountryNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CountryNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryNameLabel.Location = New System.Drawing.Point(217, 275)
        Me.CountryNameLabel.Name = "CountryNameLabel"
        Me.CountryNameLabel.Size = New System.Drawing.Size(175, 28)
        Me.CountryNameLabel.TabIndex = 3
        Me.CountryNameLabel.Visible = False
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerLabel.Location = New System.Drawing.Point(149, 406)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(240, 17)
        Me.ProgrammerLabel.TabIndex = 4
        Me.ProgrammerLabel.Text = "Programmed By Naeem Hussain"
        Me.ProgrammerLabel.Visible = False
        '
        'UnitedStatesRadioButton
        '
        Me.UnitedStatesRadioButton.AutoSize = True
        Me.UnitedStatesRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitedStatesRadioButton.Location = New System.Drawing.Point(11, 29)
        Me.UnitedStatesRadioButton.Name = "UnitedStatesRadioButton"
        Me.UnitedStatesRadioButton.Size = New System.Drawing.Size(111, 21)
        Me.UnitedStatesRadioButton.TabIndex = 5
        Me.UnitedStatesRadioButton.TabStop = True
        Me.UnitedStatesRadioButton.Text = "&United States"
        Me.UnitedStatesRadioButton.UseVisualStyleBackColor = True
        '
        'CanadaRadioButton
        '
        Me.CanadaRadioButton.AutoSize = True
        Me.CanadaRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CanadaRadioButton.Location = New System.Drawing.Point(11, 99)
        Me.CanadaRadioButton.Name = "CanadaRadioButton"
        Me.CanadaRadioButton.Size = New System.Drawing.Size(75, 21)
        Me.CanadaRadioButton.TabIndex = 6
        Me.CanadaRadioButton.TabStop = True
        Me.CanadaRadioButton.Text = "&Canada"
        Me.CanadaRadioButton.UseVisualStyleBackColor = True
        '
        'JapanRadioButton
        '
        Me.JapanRadioButton.AutoSize = True
        Me.JapanRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JapanRadioButton.Location = New System.Drawing.Point(11, 62)
        Me.JapanRadioButton.Name = "JapanRadioButton"
        Me.JapanRadioButton.Size = New System.Drawing.Size(65, 21)
        Me.JapanRadioButton.TabIndex = 7
        Me.JapanRadioButton.TabStop = True
        Me.JapanRadioButton.Text = "&Japan"
        Me.JapanRadioButton.UseVisualStyleBackColor = True
        '
        'MexicoRadioButton
        '
        Me.MexicoRadioButton.AutoSize = True
        Me.MexicoRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MexicoRadioButton.Location = New System.Drawing.Point(11, 137)
        Me.MexicoRadioButton.Name = "MexicoRadioButton"
        Me.MexicoRadioButton.Size = New System.Drawing.Size(69, 21)
        Me.MexicoRadioButton.TabIndex = 8
        Me.MexicoRadioButton.TabStop = True
        Me.MexicoRadioButton.Text = "&Mexico"
        Me.MexicoRadioButton.UseVisualStyleBackColor = True
        '
        'TitleCheckBox
        '
        Me.TitleCheckBox.AutoSize = True
        Me.TitleCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleCheckBox.Location = New System.Drawing.Point(15, 29)
        Me.TitleCheckBox.Name = "TitleCheckBox"
        Me.TitleCheckBox.Size = New System.Drawing.Size(53, 20)
        Me.TitleCheckBox.TabIndex = 9
        Me.TitleCheckBox.Text = "&Title"
        Me.ToolTip1.SetToolTip(Me.TitleCheckBox, "Show the Title name")
        Me.TitleCheckBox.UseVisualStyleBackColor = True
        '
        'CountryNameCheckBox
        '
        Me.CountryNameCheckBox.AutoSize = True
        Me.CountryNameCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryNameCheckBox.Location = New System.Drawing.Point(15, 63)
        Me.CountryNameCheckBox.Name = "CountryNameCheckBox"
        Me.CountryNameCheckBox.Size = New System.Drawing.Size(112, 20)
        Me.CountryNameCheckBox.TabIndex = 10
        Me.CountryNameCheckBox.Text = "C&ountry Name"
        Me.ToolTip1.SetToolTip(Me.CountryNameCheckBox, "Show the Country name")
        Me.CountryNameCheckBox.UseVisualStyleBackColor = True
        '
        'ProgrammerCheckBox
        '
        Me.ProgrammerCheckBox.AutoSize = True
        Me.ProgrammerCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammerCheckBox.Location = New System.Drawing.Point(15, 100)
        Me.ProgrammerCheckBox.Name = "ProgrammerCheckBox"
        Me.ProgrammerCheckBox.Size = New System.Drawing.Size(94, 20)
        Me.ProgrammerCheckBox.TabIndex = 11
        Me.ProgrammerCheckBox.Text = "P&rgrammer"
        Me.ToolTip1.SetToolTip(Me.ProgrammerCheckBox, "Show the programmer Name")
        Me.ProgrammerCheckBox.UseVisualStyleBackColor = True
        '
        'CountryGroupBox
        '
        Me.CountryGroupBox.Controls.Add(Me.UnitedStatesRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.JapanRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.CanadaRadioButton)
        Me.CountryGroupBox.Controls.Add(Me.MexicoRadioButton)
        Me.CountryGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryGroupBox.Location = New System.Drawing.Point(46, 121)
        Me.CountryGroupBox.Name = "CountryGroupBox"
        Me.CountryGroupBox.Size = New System.Drawing.Size(137, 172)
        Me.CountryGroupBox.TabIndex = 12
        Me.CountryGroupBox.TabStop = False
        Me.CountryGroupBox.Text = "Country"
        '
        'FlagPictureBox
        '
        Me.FlagPictureBox.Image = Global.Flags.My.Resources.Resources.US
        Me.FlagPictureBox.Location = New System.Drawing.Point(217, 140)
        Me.FlagPictureBox.Name = "FlagPictureBox"
        Me.FlagPictureBox.Size = New System.Drawing.Size(172, 113)
        Me.FlagPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.FlagPictureBox.TabIndex = 13
        Me.FlagPictureBox.TabStop = False
        Me.FlagPictureBox.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CountryNameCheckBox)
        Me.GroupBox1.Controls.Add(Me.TitleCheckBox)
        Me.GroupBox1.Controls.Add(Me.ProgrammerCheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(417, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 145)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(604, 469)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlagPictureBox)
        Me.Controls.Add(Me.CountryGroupBox)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.CountryNameLabel)
        Me.Controls.Add(Me.FlagLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flag Viewer"
        Me.CountryGroupBox.ResumeLayout(False)
        Me.CountryGroupBox.PerformLayout()
        CType(Me.FlagPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents FlagLabel As System.Windows.Forms.Label
    Friend WithEvents CountryNameLabel As System.Windows.Forms.Label
    Friend WithEvents ProgrammerLabel As System.Windows.Forms.Label
    Friend WithEvents UnitedStatesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CanadaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents JapanRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents MexicoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TitleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryNameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProgrammerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CountryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents FlagPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
