<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmation_Dialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ParticipantTableFINAL = New System.Windows.Forms.DataGridView()
        Me.Participant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.thefollowingXmeetingsLabel = New System.Windows.Forms.Label()
        Me.attendeeListLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subjectLabel = New System.Windows.Forms.Label()
        Me.locationLabel = New System.Windows.Forms.Label()
        Me.bodycontenttxtbox = New System.Windows.Forms.RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.AttendeeLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ParticipantTableFINAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(623, 829)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(533, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.OK_Button.ForeColor = System.Drawing.Color.Snow
        Me.OK_Button.Location = New System.Drawing.Point(295, 6)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(209, 44)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Create Meetings"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Cancel_Button.Location = New System.Drawing.Point(69, 6)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(128, 44)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(52, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(42, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Location"
        '
        'ParticipantTableFINAL
        '
        Me.ParticipantTableFINAL.AllowUserToAddRows = False
        Me.ParticipantTableFINAL.AllowUserToDeleteRows = False
        Me.ParticipantTableFINAL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.ParticipantTableFINAL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ParticipantTableFINAL.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ParticipantTableFINAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ParticipantTableFINAL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Participant, Me.StartTime, Me.EndTime, Me.Duration})
        Me.ParticipantTableFINAL.GridColor = System.Drawing.SystemColors.Control
        Me.ParticipantTableFINAL.Location = New System.Drawing.Point(31, 83)
        Me.ParticipantTableFINAL.Name = "ParticipantTableFINAL"
        Me.ParticipantTableFINAL.ReadOnly = True
        Me.ParticipantTableFINAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ParticipantTableFINAL.RowTemplate.Height = 33
        Me.ParticipantTableFINAL.Size = New System.Drawing.Size(1118, 167)
        Me.ParticipantTableFINAL.TabIndex = 8
        '
        'Participant
        '
        Me.Participant.DataPropertyName = "Participant"
        Me.Participant.HeaderText = "Participant"
        Me.Participant.Name = "Participant"
        Me.Participant.ReadOnly = True
        Me.Participant.Width = 159
        '
        'StartTime
        '
        Me.StartTime.DataPropertyName = "Start Time"
        Me.StartTime.HeaderText = "Start Time"
        Me.StartTime.Name = "StartTime"
        Me.StartTime.ReadOnly = True
        Me.StartTime.Width = 155
        '
        'EndTime
        '
        Me.EndTime.DataPropertyName = "End Time"
        Me.EndTime.HeaderText = "End Time"
        Me.EndTime.Name = "EndTime"
        Me.EndTime.ReadOnly = True
        Me.EndTime.Width = 148
        '
        'Duration
        '
        Me.Duration.DataPropertyName = "Duration"
        Me.Duration.HeaderText = "Duration"
        Me.Duration.Name = "Duration"
        Me.Duration.ReadOnly = True
        Me.Duration.Width = 138
        '
        'thefollowingXmeetingsLabel
        '
        Me.thefollowingXmeetingsLabel.AutoSize = True
        Me.thefollowingXmeetingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thefollowingXmeetingsLabel.ForeColor = System.Drawing.Color.Black
        Me.thefollowingXmeetingsLabel.Location = New System.Drawing.Point(26, 18)
        Me.thefollowingXmeetingsLabel.Name = "thefollowingXmeetingsLabel"
        Me.thefollowingXmeetingsLabel.Padding = New System.Windows.Forms.Padding(0, 20, 0, 0)
        Me.thefollowingXmeetingsLabel.Size = New System.Drawing.Size(483, 49)
        Me.thefollowingXmeetingsLabel.TabIndex = 9
        Me.thefollowingXmeetingsLabel.Text = "The following meeting(s) will be created"
        '
        'attendeeListLabel
        '
        Me.attendeeListLabel.AutoEllipsis = True
        Me.attendeeListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.attendeeListLabel.ForeColor = System.Drawing.Color.Black
        Me.attendeeListLabel.Location = New System.Drawing.Point(151, 394)
        Me.attendeeListLabel.Name = "attendeeListLabel"
        Me.attendeeListLabel.Size = New System.Drawing.Size(998, 41)
        Me.attendeeListLabel.TabIndex = 14
        Me.attendeeListLabel.Text = "None"
        Me.attendeeListLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(78, 459)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Body"
        '
        'subjectLabel
        '
        Me.subjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.subjectLabel.ForeColor = System.Drawing.Color.Black
        Me.subjectLabel.Location = New System.Drawing.Point(156, 282)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(993, 29)
        Me.subjectLabel.TabIndex = 17
        Me.subjectLabel.Text = "No Subject"
        '
        'locationLabel
        '
        Me.locationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.locationLabel.ForeColor = System.Drawing.Color.Black
        Me.locationLabel.Location = New System.Drawing.Point(156, 338)
        Me.locationLabel.Name = "locationLabel"
        Me.locationLabel.Size = New System.Drawing.Size(1000, 29)
        Me.locationLabel.TabIndex = 18
        Me.locationLabel.Text = "Skype Meeting"
        '
        'bodycontenttxtbox
        '
        Me.bodycontenttxtbox.HideSelection = False
        Me.bodycontenttxtbox.Location = New System.Drawing.Point(156, 457)
        Me.bodycontenttxtbox.Name = "bodycontenttxtbox"
        Me.bodycontenttxtbox.ReadOnly = True
        Me.bodycontenttxtbox.Size = New System.Drawing.Size(993, 275)
        Me.bodycontenttxtbox.TabIndex = 19
        Me.bodycontenttxtbox.Text = ""
        '
        'AttendeeLabel
        '
        Me.AttendeeLabel.AutoSize = True
        Me.AttendeeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendeeLabel.ForeColor = System.Drawing.Color.DimGray
        Me.AttendeeLabel.Location = New System.Drawing.Point(25, 394)
        Me.AttendeeLabel.Name = "AttendeeLabel"
        Me.AttendeeLabel.Size = New System.Drawing.Size(121, 29)
        Me.AttendeeLabel.TabIndex = 20
        Me.AttendeeLabel.Text = "Attendees"
        '
        'Confirmation_Dialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(1209, 900)
        Me.Controls.Add(Me.bodycontenttxtbox)
        Me.Controls.Add(Me.locationLabel)
        Me.Controls.Add(Me.subjectLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.thefollowingXmeetingsLabel)
        Me.Controls.Add(Me.ParticipantTableFINAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AttendeeLabel)
        Me.Controls.Add(Me.attendeeListLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Confirmation_Dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Confirm Meeting Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.ParticipantTableFINAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As Windows.Forms.ColorDialog
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ParticipantTableFINAL As Windows.Forms.DataGridView
    Friend WithEvents thefollowingXmeetingsLabel As Windows.Forms.Label
    Friend WithEvents attendeeListLabel As Windows.Forms.Label
    Friend WithEvents Participant As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTime As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndTime As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Duration As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents subjectLabel As Windows.Forms.Label
    Friend WithEvents locationLabel As Windows.Forms.Label
    Friend WithEvents bodycontenttxtbox As Windows.Forms.RichTextBox
    Friend WithEvents BackgroundWorker1 As ComponentModel.BackgroundWorker
    Friend WithEvents AttendeeLabel As Windows.Forms.Label
End Class
