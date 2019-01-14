Option Strict On

Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Data

Public Class Setup_Window

    'Initialize all variables needed for an appointment
    Dim tSubject As String = ""
    Dim tBody As String = ""
    Dim tLocation As String = ""
    Dim tParticipantTable As New DataTable 'table of participant data
    Dim reqAtendees As String = ""
    Dim optAtendees As String = ""


    'When User hits Continue..
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Continue_Button_02.Click

        Dim blank As Boolean = IsBlank(ParticipantTable)
        Dim completerows As Boolean = hasCompleteRows(ParticipantTable)
        Dim tablecheck As Object = ProcessTable(ParticipantTable) 'ProcessTable will show error messages

        'If table is completely blank
        If blank Then
            Dim r = MessageBox.Show("Enter at least one row of participant information to continue", "Add participant information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If r = DialogResult.OK Then
                Return
            End If

            'If there is a row with some data, but is not complete
        ElseIf Not completerows Then
            Dim rr = MessageBox.Show("At least one of the rows in the participant table is missing information", "Complete participant information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If rr = DialogResult.OK Then
                Return
            End If

            'Check for email addresses being valid
            'NOT IMPLEMENTED YET
        ElseIf Not String.IsNullOrWhiteSpace(reqAtendees) Then
            Dim tempEmails() As String = SplitAttendees(reqAtendees)
            For Each email In tempEmails
                'Implement an email format check and show an error if there's a problem
                Continue For
            Next


            'Check table for valid dates and times
            'If there are invalid dates or times,the tablecheck function will alert users of offending item
        ElseIf tablecheck.GetType() Is GetType(Boolean) Then
            Return

            'calling tablecheck
            'Else if everything is fine...
        ElseIf tablecheck.GetType() Is GetType(DataTable) Then

            'Set meeting data variables
            tSubject = MeetingSubjectInput.Text
            tBody = bodyRTBinput.Rtf
            tLocation = locationTextbox.Text
            reqAtendees = ReqAtendeesInput.Text
            optAtendees = optAttendeeTextBox.Text
            tParticipantTable = CType(tablecheck, DataTable)

            'Create new confirmation dialog
            Dim dialogConfirm As New Confirmation_Dialog(subject:=tSubject, body:=tBody, location:=tLocation, reqAttendees:=reqAtendees, optAttendees:=optAtendees, ptable:=tParticipantTable)
            If dialogConfirm.ShowDialog() = DialogResult.OK Then
                Me.Close() 'Close this window if the 
            End If
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub



    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button_02.Click
        If True Then

        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label_MeetingSubject.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_4(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_5(sender As Object, e As EventArgs)

    End Sub



    '----- UI Functions to enable more functionality in the datagridview table -------'

    'Enabling Backspace Key to Clear
    Private Sub KeyBackspace(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ParticipantTable.KeyDown
        If e.KeyCode = Keys.Back Then
            Backspace(ParticipantTable)
        End If
    End Sub

    'Enable paste
    Private Sub KeyPaste(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ParticipantTable.KeyDown
        If CBool(CType(e.KeyCode = Keys.V, Keys) And Keys.ControlKey) Then
            PasteData(ParticipantTable)
        End If
    End Sub

    Private Sub Main_Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MeetingSubjectInput_TextChanged(sender As Object, e As EventArgs) Handles MeetingSubjectInput.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ParticipantTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ParticipantTable.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub


    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class