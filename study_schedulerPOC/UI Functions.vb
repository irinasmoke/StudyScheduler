Option Strict On

Imports System.Windows.Forms


' Functions related purely to enhancing capabilites of the UI components
' No parsing, scheduling, validation, etc. functions 

Module UI_functions

    'Enables Paste functionaltiy in a DataGridView
    'To use, add an event handler on your DataGridView to handle Ctrl+V events, and call this method
    Public Sub PasteData(ByRef dgv As DataGridView)
        Dim tArr() As String
        Dim arT() As String
        Dim i, ii As Integer
        Dim c, cc, r As Integer

        tArr = Clipboard.GetText().Replace("\n", "").Replace("\r", "").Trim().Split(CType(Environment.NewLine, Char()), StringSplitOptions.RemoveEmptyEntries) 'Trims clipboard and gets each new row in an array
        r = dgv.CurrentCell.RowIndex
        c = dgv.CurrentCell.ColumnIndex

        If tArr.Length > (dgv.Rows.Count - r) Then
            dgv.Rows.Add(tArr.Length - (dgv.Rows.Count - r)) 'Add rows if necessary based on clipboard length. Without this, you won't be able to paste more rows than your dgv currently has.
        End If

        For i = 0 To tArr.Length - 1
            Try
                If tArr(i) <> "" Then
                    arT = tArr(i).Split(CType(vbTab, Char()))
                    cc = c
                    For ii = 0 To arT.Length - 1
                        If cc > dgv.ColumnCount - 1 Then Exit For
                        If r > dgv.Rows.Count - 1 Then Exit Sub
                        With dgv.Item(cc, r)
                            .Value = arT(ii).TrimStart
                        End With
                        cc = cc + 1
                    Next
                    r = r + 1
                End If
            Catch ex As Exception
                Diagnostics.Debug.WriteLine(ex.Message)
            End Try
        Next
    End Sub


    'Enables backspace functionaltiy in a DataGridView
    'To use, add an event handler on your DataGridView to handle Backspace key events and call this method
    Public Sub Backspace(ByRef dgv As DataGridView)
        For Each cell As DataGridViewCell In dgv.SelectedCells
            Try
                cell.Value = ""
            Catch ex As Exception
                Diagnostics.Debug.WriteLine(ex.Message)
            End Try

        Next
    End Sub


End Module
