Option Strict On

Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.Drawing
Imports System.Data
Imports System.Globalization

Module Functions


    '---------------------------- VALIDATION FUNCTIONS -------------------------------

    'Checks if a datagridview is completely blank
    Public Function IsBlank(dgv As DataGridView) As Boolean
        Dim blank As Boolean = True
        For Each row As DataGridViewRow In dgv.Rows
            For i As Integer = 0 To dgv.Columns.Count - 1
                Try
                    If Not row.Cells(i).Value Is Nothing Then
                        If Not row.Cells(i).Value.ToString.Equals("") Then
                            blank = False
                        End If
                    End If
                Catch ex As Exception
                End Try
            Next
        Next
        Return blank
    End Function


    'Checks if datagridview has all columns of a row filled out
    Public Function hasCompleteRows(dgv As DataGridView) As Boolean
        Dim completerows As Boolean = True
        For Each row As DataGridViewRow In dgv.Rows
            Dim blankrow = IsBlank(row)
            Dim completerow = allCellsFilled(row)
            If Not blankrow And Not completerow Then
                completerows = False
            End If
        Next
        Return completerows
    End Function

    'Returns true if a row has all the cells filled out
    'Used to alert the user of a partially filled out row 
    Public Function allCellsFilled(row As DataGridViewRow) As Boolean
        Dim blankcell = False 'set false until a blank value is found
        For Each cell As DataGridViewCell In row.Cells
            If cell.Value Is Nothing Then
                blankcell = True
            ElseIf cell.Value.ToString = "" Then
                blankcell = True
            End If
        Next
        Return Not blankcell
    End Function


    'Returns true if a row is blank 
    'Used to ignore empty rows in a table
    Public Function IsBlank(row As DataGridViewRow) As Boolean
        Dim blank As Boolean = True 'set as true until a non-blank value is found
        For Each cell As DataGridViewCell In row.Cells
            For i As Integer = 0 To row.Cells.Count - 1
                If Not row.Cells(i).Value Is Nothing Then
                    If Not String.IsNullOrWhiteSpace(row.Cells(i).Value.ToString) Then
                        blank = False
                    End If
                End If
            Next
        Next
        Return blank
    End Function

    'MAIN DATETIME VALIDATION FUNCTION
    'Fully validate all date and timeslot columns
    'Returns either a boolean (if invalid) or datatable (if valid)
    Public Function ProcessTable(dgv As DataGridView) As Object 'Object will be a boolean if the table is invalid, or a datatable with dgv values (with blanks removed) if valid
        Dim fail As Boolean = False
        Dim dt As New DataTable
        dt.Columns.Add("Participant")
        dt.Columns.Add("Start Time")
        dt.Columns.Add("End Time")
        dt.Columns.Add("Duration")

        For Each row As DataGridViewRow In dgv.Rows
            'Ignore blank rows
            If IsBlank(row) Then
                Continue For
            End If

            'Ignore incomplete rows
            If Not allCellsFilled(row) Then
                Continue For
            End If

            'Setup variables
            Dim oDateCell As String = row.Cells(1).Value.ToString
            Dim cleanDateCell As String = CleanDate(oDateCell)
            Dim oTimesCell As String = row.Cells(2).Value.ToString
            Dim cleanTimesCell As String = CleanTime(oTimesCell)
            Dim rowdata(3) As String  'this will be inserted into dt if all conditions are passed

            Dim day As DateTime
            Dim st As DateTime
            Dim et As DateTime

            'If Date cell does not have valid date
            If Not DateTime.TryParse(cleanDateCell, day) Then
                Dim result As DialogResult = MessageBox.Show("Date not recognized: " + oDateCell + Environment.NewLine + "This may be due to an unrecognized format (try MM/DD/YYYY, or Month DD, YYYY), or a day of the week not correctly corresponding with the date.", "Date or Time issue", MessageBoxButtons.OK)
                If result = DialogResult.OK Then
                    Return fail
                End If
            Else
                'Else try splitting the times
                Dim nsplittimes = splitTimes(cleanTimesCell)

                'If times cell is not delimitered correctly (i.e. don't return two values when split on dash or hyphen)
                If nsplittimes.Length <> 2 Then
                    Dim r As DialogResult = MessageBox.Show("Invalid time slot: " + oTimesCell + " . Please enter a time range separated by a single dash.", "", MessageBoxButtons.OK)
                    If r = DialogResult.OK Then
                        Return fail
                    End If
                End If

                'If times cell does not parse into two valid times
                If Not DateTime.TryParse(nsplittimes(0).ToString, st) Or Not DateTime.TryParse(nsplittimes(1).ToString, et) Then
                    Dim result2 As DialogResult = MessageBox.Show("At least one of the times in the timeslots column is not recognized: " + oTimesCell + ". Please enter a time range separated by a dash (e.g. 3-4pm). Note that timezone indicators will not be recognized.", "Date or Time issue", MessageBoxButtons.OK)
                    If result2 = DialogResult.OK Then
                        Return fail
                    End If
                End If

                'If start time is after end time
                If DateTime.Compare(st, et) > 0 Then
                    Dim result3 As DialogResult = MessageBox.Show("Start time must be before end time: " + oTimesCell, "Date or Time issue", MessageBoxButtons.OK)
                    If result3 = DialogResult.OK Then
                        Return fail
                    End If
                End If

                'If time is in the past 
                If DateTime.Compare(DateTime.Today, day) > 0 Then
                    Dim result4 As DialogResult = MessageBox.Show("The date " + oDateCell + " looks like it's in the past. Cannot create meetings for days in the past.", "Date or Time issue", MessageBoxButtons.OK)
                    If result4 = DialogResult.OK Then
                        Return fail
                    End If
                End If

                'If duration is longer than 12 hours (happens because things like 2-3pm will be interpreted as 2am to 3pm)
                'Fix by adding 12 hrs to the start time, but only if that wouldn't create a negative duration 
                If DateDiff(DateInterval.Hour, st, et) >= 12 Then
                    Dim newST As DateTime = st.AddHours(12)
                    If DateTime.Compare(newST, et) < 0 Then
                        st = newST
                    End If
                End If

                'Finally, if we haven't returned the fail boolean yet, that means none of the past error conditions were true
                'Can continue with appointment setup
                'Setup rows and add them to the table
                Try
                    Dim dFrom As Date = New DateTime(day.Year, day.Month, day.Day, st.Hour, st.Minute, st.Second) 'merge date and start time into a single datetime
                    Dim dTo As Date = New DateTime(day.Year, day.Month, day.Day, et.Hour, et.Minute, st.Second)   'merge date and end time into a single datetime
                    Dim hDuration As Long = DateDiff(DateInterval.Hour, dFrom, dTo)
                    Dim mDuration As Long = DateDiff(DateInterval.Minute, dFrom, dTo)
                    rowdata(0) = row.Cells(0).Value.ToString 'Participant name
                    rowdata(1) = dFrom.ToString
                    rowdata(2) = dTo.ToString
                    rowdata(3) = (Math.Abs(mDuration) / 60).ToString + " hr(s)" 'Duration column
                    dt.Rows.Add(rowdata) 'Add row to participant table
                Catch ex As Exception
                    Dim result4 As DialogResult = MessageBox.Show("An unknown error has occured. It may be due to a date or time entry issue. Please check your input and try again", "Unknown Error", MessageBoxButtons.OK)
                    If result4 = DialogResult.OK Then
                        Return fail
                    End If
                End Try
            End If
        Next
        'Return the constructed data table
        Return dt
    End Function







    '---------------------------- DATETIME FUNCTIONS-------------------------------------------


    'Splits string text based on splitchars
    'Intended for timeslot cell, which should have things like 2-3pm
    Public Function splitTimes(txt As String) As String()
        Dim stringarray() As String = {""}
        Dim splitchars As String() = {"–", "-", "—"}
        stringarray = txt.Split(splitchars, StringSplitOptions.None)
        For i = 0 To stringarray.Length - 1
            stringarray(i) = addAM(stringarray(i)) 'Add am if necessary
        Next
        Return stringarray
    End Function


    'Attempts to "Clean" a string to remove characters or patterns that tend to trip up the DateTime.TryParse() function
    'TryParse() has trouble with the endings of things like 2nd, 3rd, etc., so this removes those characters
    'TryParse() can handle 'Tuesday' and 'Tue', but not 'Tues', so this removes those and similar strings
    Private Function CleanDate(datestring As String) As String
        Dim s = datestring
        Dim patterns1() As String = {"th", "rd", "nd", "st", ","} 'put lowercase letters in this array
        Dim patterns2() As String = {"tues", "thurs", "thur", ","}

        'Process patterns1() and remove/replace if certain conditions are met
        For Each pattern In patterns1
            'Remove if anything in patterns followed by a space appears
            'The space is necessary so that words like "Thursday" are unaffected by the "th" pattern
            If s.ToLower().Contains(pattern + " ") Then
                s = s.Replace(pattern + " ", " ")
            End If

            'Remove the pattern if it comes at the ends of the string
            'Again, necessary so words like Thursday are unaffected by the "th" pattern
            If s.ToLower().EndsWith(pattern) And s.Length > 2 Then
                s = s.Substring(0, s.Length - 2)
            End If
        Next

        'Handle "tues", "thurs", and "thur", which also trip up TryParse()
        'Remove those strings, unless the full day of the week is in there
        For Each pattern In patterns2
            If Not s.ToLower().Contains("tuesday") Then
                If s.ToLower().Contains("tues") Then
                    s = s.ToLower().Replace("tues", " ")
                End If
            End If
            If Not s.ToLower().Contains("thursday") Then
                If s.ToLower().Contains("thurs") Then
                    s = s.ToLower().Replace("thurs", " ")
                End If
                If s.ToLower().Contains("thur") Then
                    s = s.ToLower().Replace("thur", " ")
                End If
            End If

        Next
        Return s
    End Function

    'Attempts to "clean" a string representing the time to remove things that might trip up the TryParse() function
    'Removes anything after "am" or "pm", which is likely to be a timezone designation
    'This means that this tool cannot handle timezone information, and all times will be interpreted as if in the system default timezone
    Private Function CleanTime(timestring As String) As String
        Dim s = timestring
        Dim EndPatterns() As String = {"am", "pm"} 'put lowercase strings in this array

        For Each pattern In EndPatterns
            If s.ToLower().Contains(pattern) Then
                s = s.ToLower().Substring(0, s.ToLower().LastIndexOf(pattern) + pattern.Length)
            End If
        Next
        Return s
    End Function




    'If the string does not contain "am" or "pm" (case insensitive), add "am" to the end of the string
    'This is purely for it to be recognized as a time, since "2" will not parse but "2am" will parse
    'Whether the time should actually be interpreted AM or PM is handled in the main ProcessTable() function
    Public Function addAM(txt As String) As String
        Dim hasAM As Boolean = txt.IndexOf("am", 0, StringComparison.CurrentCultureIgnoreCase) > -1
        Dim hasPM As Boolean = txt.IndexOf("pm", 0, StringComparison.CurrentCultureIgnoreCase) > -1
        If Not hasAM And Not hasPM Then
            txt = txt + "am"
            Return txt
        End If
        Return txt
    End Function



    '---------------------------- OTHER FUNCTIONS-------------------------------------------'


    'Splits string txt based on splitchars
    'Intended for email addresses
    Public Function SplitAttendees(txt As String) As String()
        Dim stringarray() As String = {""}
        Dim splitchars As String() = {",", ";"}
        stringarray = txt.Split(splitchars, StringSplitOptions.None)

        For i = 0 To stringarray.Length - 1
            stringarray(i) = addAM(stringarray(i))
        Next

        Return stringarray
    End Function


    ' Creates a single new calendar appointment
    ' Saves, but does not send invites
    Public Sub CreateAppointment(subject As String, body As String, location As String, oAttendees As String, rAttendees As String, participantname As String, starttime As Date, endtime As Date)
        Try
            Dim TempApp As Outlook.Application = New Outlook.Application()
            Dim TempAppItem As Outlook.AppointmentItem = CType(TempApp.CreateItem(Outlook.OlItemType.olAppointmentItem), Outlook.AppointmentItem)
            Dim FinalBody As String = buildApptBody(body, participantname)
            Dim FinalEmails As New List(Of String)

            Dim oAttend As String() = SplitAttendees(oAttendees)
            Dim rAttend As String() = SplitAttendees(rAttendees)

            'Setup Appointment
            TempAppItem.MeetingStatus = Outlook.OlMeetingStatus.olMeeting
            TempAppItem.Subject = subject
            TempAppItem.Body = FinalBody
            TempAppItem.Location = "Skype meeting"
            TempAppItem.Start = starttime
            TempAppItem.End = endtime

            For Each email In oAttend
                If Not String.IsNullOrWhiteSpace(email) Then
                    TempAppItem.Recipients.Add(email)
                End If
            Next

            For Each email In rAttend
                If Not String.IsNullOrWhiteSpace(email) Then
                    TempAppItem.Recipients.Add(email)
                End If
            Next

            TempAppItem.RequiredAttendees = rAttendees
            TempAppItem.OptionalAttendees = oAttendees
            Dim myRecipients = TempAppItem.Recipients


            TempAppItem.ReminderSet = True
            TempAppItem.ReminderMinutesBeforeStart = 15
            TempAppItem.BusyStatus = Outlook.OlBusyStatus.olBusy

            'Save to Calendar
            '***Does not send invites***
            TempAppItem.Save()
            TempApp = Nothing
            TempAppItem = Nothing

        Catch ex As Exception
            MessageBox.Show("An Unknown error has occured. Some invites may not have been created.", "Error", MessageBoxButtons.OK)
            Diagnostics.Debug.WriteLine(ex.Message)
            Return
        End Try
    End Sub



    'Adds "Participant: <pname>" to the start of the meeting body
    'Returns RTF, NOT a plain string (this is needed to keep all formatting that is pasted into the Body textbox)
    Public Function buildApptBody(body As String, pName As String) As String
        Dim NewBody As String = ""
        Dim rtbTmp1 As New RichTextBox ' Temporary Rich Text Box, needed to merge the two rich text formats
        Dim rtbTmp2 As New RichTextBox
        rtbTmp1.Font = New Font("Calibri", 12)
        rtbTmp1.AppendText("Participant: " + pName + vbNewLine)

        'Uses Clipboard to keep the rich text formatting intact
        'If you simply appended strings, you'd either lose formatting or would generate invalid RTF, which the appointment wouldn't be able to read
        Clipboard.SetText(rtbTmp1.Rtf, TextDataFormat.Rtf)
        rtbTmp2.Paste()
        rtbTmp2.AppendText(Environment.NewLine)
        Clipboard.SetText(body, TextDataFormat.Rtf)
        rtbTmp2.Paste()
        Clipboard.Clear()

        NewBody = rtbTmp2.Rtf

        Return NewBody
    End Function
End Module

