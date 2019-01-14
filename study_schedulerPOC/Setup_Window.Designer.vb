<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setup_Window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup_Window))
        Me.StartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticipantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReqAtendeesInput = New System.Windows.Forms.TextBox()
        Me.TimeSlot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ParticipantTable = New System.Windows.Forms.DataGridView()
        Me.MeetingSubjectInput = New System.Windows.Forms.TextBox()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Continue_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button_02 = New System.Windows.Forms.Button()
        Me.Continue_Button_02 = New System.Windows.Forms.Button()
        Me.optAttendeeTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.locationTextbox = New System.Windows.Forms.TextBox()
        Me.bodyRTBinput = New System.Windows.Forms.RichTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_MeetingSubject = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.ParticipantTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartDate
        '
        Me.StartDate.HeaderText = "Date"
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Width = 200
        '
        'ParticipantName
        '
        Me.ParticipantName.HeaderText = "Participant Name"
        Me.ParticipantName.Name = "ParticipantName"
        Me.ParticipantName.Width = 250
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(35, 738)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1053, 30)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Semicolon-separated email addresses. Recommendation: Copy and paste from another " &
    "meeting invite."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(30, 883)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 26)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Optional"
        '
        'ReqAtendeesInput
        '
        Me.ReqAtendeesInput.Location = New System.Drawing.Point(136, 781)
        Me.ReqAtendeesInput.Multiline = True
        Me.ReqAtendeesInput.Name = "ReqAtendeesInput"
        Me.ReqAtendeesInput.Size = New System.Drawing.Size(925, 79)
        Me.ReqAtendeesInput.TabIndex = 34
        '
        'TimeSlot
        '
        Me.TimeSlot.HeaderText = "TimeSlot"
        Me.TimeSlot.MinimumWidth = 200
        Me.TimeSlot.Name = "TimeSlot"
        Me.TimeSlot.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 781)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 26)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Required"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 29)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Attendees"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 26)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Participants"
        '
        'ParticipantTable
        '
        Me.ParticipantTable.AllowUserToResizeRows = False
        Me.ParticipantTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ParticipantTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ParticipantTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParticipantTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParticipantName, Me.StartDate, Me.TimeSlot})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ParticipantTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.ParticipantTable.Location = New System.Drawing.Point(37, 428)
        Me.ParticipantTable.Name = "ParticipantTable"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ParticipantTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ParticipantTable.RowTemplate.Height = 33
        Me.ParticipantTable.Size = New System.Drawing.Size(1024, 190)
        Me.ParticipantTable.TabIndex = 26
        '
        'MeetingSubjectInput
        '
        Me.MeetingSubjectInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeetingSubjectInput.Location = New System.Drawing.Point(138, 84)
        Me.MeetingSubjectInput.Name = "MeetingSubjectInput"
        Me.MeetingSubjectInput.Size = New System.Drawing.Size(925, 31)
        Me.MeetingSubjectInput.TabIndex = 24
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(12, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(134, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Continue_Button
        '
        Me.Continue_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Continue_Button.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Continue_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Continue_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Continue_Button.Location = New System.Drawing.Point(174, 6)
        Me.Continue_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.Continue_Button.Name = "Continue_Button"
        Me.Continue_Button.Size = New System.Drawing.Size(166, 44)
        Me.Continue_Button.TabIndex = 0
        Me.Continue_Button.Text = "Continue..."
        Me.Continue_Button.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.66292!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.33708!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Continue_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(895, 1929)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(356, 56)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'Cancel_Button_02
        '
        Me.Cancel_Button_02.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button_02.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button_02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button_02.Location = New System.Drawing.Point(693, 1023)
        Me.Cancel_Button_02.Margin = New System.Windows.Forms.Padding(6)
        Me.Cancel_Button_02.Name = "Cancel_Button_02"
        Me.Cancel_Button_02.Size = New System.Drawing.Size(134, 44)
        Me.Cancel_Button_02.TabIndex = 43
        Me.Cancel_Button_02.Text = "Cancel"
        '
        'Continue_Button_02
        '
        Me.Continue_Button_02.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Continue_Button_02.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Continue_Button_02.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Continue_Button_02.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Continue_Button_02.Location = New System.Drawing.Point(869, 1023)
        Me.Continue_Button_02.Margin = New System.Windows.Forms.Padding(6)
        Me.Continue_Button_02.Name = "Continue_Button_02"
        Me.Continue_Button_02.Size = New System.Drawing.Size(180, 44)
        Me.Continue_Button_02.TabIndex = 42
        Me.Continue_Button_02.Text = "Continue..."
        Me.Continue_Button_02.UseVisualStyleBackColor = False
        '
        'optAttendeeTextBox
        '
        Me.optAttendeeTextBox.Location = New System.Drawing.Point(136, 880)
        Me.optAttendeeTextBox.Name = "optAttendeeTextBox"
        Me.optAttendeeTextBox.Size = New System.Drawing.Size(925, 73)
        Me.optAttendeeTextBox.TabIndex = 44
        Me.optAttendeeTextBox.Text = ""
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(32, 621)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1036, 55)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label10.Location = New System.Drawing.Point(776, 395)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(287, 26)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "*At least one row is required"
        '
        'locationTextbox
        '
        Me.locationTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locationTextbox.Location = New System.Drawing.Point(139, 136)
        Me.locationTextbox.Name = "locationTextbox"
        Me.locationTextbox.Size = New System.Drawing.Size(397, 31)
        Me.locationTextbox.TabIndex = 50
        Me.locationTextbox.Text = "Skype Meeting"
        '
        'bodyRTBinput
        '
        Me.bodyRTBinput.Location = New System.Drawing.Point(138, 191)
        Me.bodyRTBinput.Name = "bodyRTBinput"
        Me.bodyRTBinput.Size = New System.Drawing.Size(925, 181)
        Me.bodyRTBinput.TabIndex = 51
        Me.bodyRTBinput.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label11.Location = New System.Drawing.Point(32, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Location"
        '
        'Label_MeetingSubject
        '
        Me.Label_MeetingSubject.AutoSize = True
        Me.Label_MeetingSubject.BackColor = System.Drawing.Color.Transparent
        Me.Label_MeetingSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label_MeetingSubject.Location = New System.Drawing.Point(40, 86)
        Me.Label_MeetingSubject.Name = "Label_MeetingSubject"
        Me.Label_MeetingSubject.Size = New System.Drawing.Size(85, 26)
        Me.Label_MeetingSubject.TabIndex = 25
        Me.Label_MeetingSubject.Text = "Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label8.Location = New System.Drawing.Point(63, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 26)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Body"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 26)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Meeting Setup"
        '
        'Setup_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1110, 1126)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bodyRTBinput)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label_MeetingSubject)
        Me.Controls.Add(Me.locationTextbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.optAttendeeTextBox)
        Me.Controls.Add(Me.Cancel_Button_02)
        Me.Controls.Add(Me.Continue_Button_02)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ReqAtendeesInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ParticipantTable)
        Me.Controls.Add(Me.MeetingSubjectInput)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Setup_Window"
        Me.Text = "Create Meetings"
        CType(Me.ParticipantTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartDate As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticipantName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents ReqAtendeesInput As Windows.Forms.TextBox
    Friend WithEvents TimeSlot As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents SkypelinkInput As Windows.Forms.TextBox
    Friend WithEvents ParticipantTable As Windows.Forms.DataGridView
    Friend WithEvents MeetingSubjectInput As Windows.Forms.TextBox
    Friend WithEvents Cancel_Button As Windows.Forms.Button
    Friend WithEvents Continue_Button As Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button_02 As Windows.Forms.Button
    Friend WithEvents Continue_Button_02 As Windows.Forms.Button
    Friend WithEvents optAttendeeTextBox As Windows.Forms.RichTextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents HelpProvider1 As Windows.Forms.HelpProvider
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents locationTextbox As Windows.Forms.TextBox
    Friend WithEvents bodyRTBinput As Windows.Forms.RichTextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label_MeetingSubject As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
End Class
