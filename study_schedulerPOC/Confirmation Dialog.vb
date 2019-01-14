Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.Office.Interop
Imports System.Data

Public Class Confirmation_Dialog

    'Initializing items needed for the dialog
    Dim fSubject As String = "No Subject"
    Dim fBody As String = ""
    Dim fLocation As String = ""
    Dim rAttend As String = ""
    Dim oAttend As String = ""
    Dim fParticipants As New DataTable

    'Creates a new confirmation dialog based on input
    Public Sub New(subject As String, body As String, location As String, reqAttendees As String, optAttendees As String, ptable As DataTable)

        InitializeComponent()

        'Set Variables
        If Not String.IsNullOrWhiteSpace(subject) Then
            subjectLabel.Text = subject
            fSubject = subject
        End If
        fLocation = location
        fBody = body
        fParticipants = ptable
        ParticipantTableFINAL.DataSource = ptable
        rAttend = reqAttendees
        oAttend = optAttendees

        'UPDATE UI based on variables
        locationLabel.Text = fLocation
        bodycontenttxtbox.Rtf = fBody
        thefollowingXmeetingsLabel.Text = fParticipants.Rows.Count.ToString + " meeting(s) will be created"
        Dim rA As Boolean = String.IsNullOrWhiteSpace(rAttend)
        Dim oA As Boolean = String.IsNullOrWhiteSpace(oAttend)
        If rA Then
            If oA Then
                attendeeListLabel.Text = rAttend + "; " + oAttend
            Else
                attendeeListLabel.Text = rAttend
            End If

        Else 'not rA
            If oA Then
                attendeeListLabel.Text = oAttend
            Else
                attendeeListLabel.Text = "None"
            End If
        End If

        attendeeListLabel.Visible = True
        AttendeeLabel.Visible = True
    End Sub

    'Handles OK button (create appointments)
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            CreateAppointments()
        Catch ex As Exception
            Diagnostics.Debug.WriteLine("Unable to create appointment:" + ex.Message) 'Don't show an error message to the user here because CreateAppointments() will do this
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



    ' Create a set of appointments
    ' Based on variables initialized at the top of this Sub
    Private Sub CreateAppointments()
        For Each row As DataRow In fParticipants.Rows
            CreateAppointment(subject:=fSubject, body:=fBody, location:=fLocation, oAttendees:=oAttend, rAttendees:=rAttend, participantname:=row.Item(0).ToString, starttime:=row.Item(1).ToString, endtime:=row.Item(2).ToString)
        Next
    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BodyContentFINAL_Click(sender As Object, e As EventArgs)

    End Sub
End Class
