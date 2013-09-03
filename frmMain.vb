Imports System.ComponentModel

Public Class frmMain
    Shared _timer As Timer
    Shared uptime_monitor As BackgroundWorker

    ' This delegate enables asynchronous calls for setting 
    ' the text property on a TextBox control. 
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Delegate Sub SetIntCallback()


    Private Sub toggle_monitor()
        If txtWordUp.Text = "" Then
            MsgBox("FATAL ERROR: Words to look for my now be empty")
            Exit Sub
        End If

        'disable input group
        'grpInput.Enabled = False
        toggle_inputs()

        'frequency may not be below 5 seconds
        If txtFreq.Text < 5 Or My.Settings.frequency < 5 Then
            My.Settings.frequency = 5
            txtFreq.Text = 5
        End If

        'timeout may not be below 1second
        If txtWebTimeout.Text < 1000 Or My.Settings.timeout < 1000 Then
            My.Settings.timeout = 1000
            txtWebTimeout.Text = 1000
        End If


        'store settings for next time
        My.Settings.url = txtSrv.Text
        My.Settings.words = txtWordUp.Text
        My.Settings.report_ok = chkReportOK.Checked
        My.Settings.report_error = chkReportError.Checked
        My.Settings.timeout = txtWebTimeout.Text



        If uptime_monitor Is Nothing Then
            ' prepare background worker to do the uptime checks
            uptime_monitor = New BackgroundWorker

            uptime_monitor.WorkerReportsProgress = True
            uptime_monitor.WorkerSupportsCancellation = True
            AddHandler uptime_monitor.DoWork, AddressOf get_website
            uptime_monitor.RunWorkerAsync()

            'now setup timer to keep the worker running
            _timer = New Timer()
            _timer.Interval = txtFreq.Text * 1000
            AddHandler _timer.Tick, AddressOf uptime_worker_restart
            _timer.Start()

            btnToggle.Text = "Stop"
            lblThreadStatus.Text = "running - " & Now.ToString("u")
            lblThrStarted.Text = "started  - " & Now.ToString("u")
        Else
            _timer.Stop()
            uptime_monitor.CancelAsync()
            btnToggle.Text = "Start"
            uptime_monitor = Nothing
            lblThreadStatus.Text = ""
            lblThrStarted.Text = "stopped - " & Now.ToString("u")
            grpInput.Enabled = True
        End If
    End Sub



    Private Sub uptime_worker_restart()
        If Not uptime_monitor Is Nothing Then
            If uptime_monitor.IsBusy = False And uptime_monitor.CancellationPending = False Then
                uptime_monitor.RunWorkerAsync()
            End If
        End If
    End Sub

    Private Sub get_website(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        Dim content() As Object = DownloadWebpage(My.Settings.url)
        Dim check() As String

        'check content for errors
        If content(0) = "!200" Then
            log_message(False)
            'log content to last error box
            If Me.txtLastError.InvokeRequired Then
                ' It's on a different thread, so use Invoke. 
                Dim d As New SetTextCallback(AddressOf SetLastError)
                Me.Invoke(d, New Object() {Now.ToString("u") & vbCrLf & content(1)})
            Else
                ' It's on the same thread, no need for Invoke. 
                Me.txtLastError.Text = Now.ToString("u") & vbCrLf & content(1)
            End If
            Exit Sub
        End If

        If Not InStr(My.Settings.words, ",") = Nothing Then
            check = My.Settings.words.Split(",")
        Else
            ReDim check(0)
            check(0) = My.Settings.words
        End If

        ' loop over and look for words
        Dim found_cnt As Integer = 0 ' must match check() count later on
        For Each look4 As String In check
            If Not InStr(content(1), look4) = Nothing Then
                'match found, good
                found_cnt = found_cnt + 1
            End If
        Next


        'compare check with found counter. if they are the same then everything "should" be ok
        If check.Count = found_cnt Then
            log_message(True)
        Else
            log_message(False)
            'log content to last error box
            If Me.txtLastError.InvokeRequired Then
                ' It's on a different thread, so use Invoke. 
                Dim d As New SetTextCallback(AddressOf SetLastError)
                Me.Invoke(d, New Object() {Now.ToString("u") & " - not all words (" & My.Settings.words & ") found!" & vbCrLf & "Website returned:" & vbCrLf & content(1)})
            Else
                ' It's on the same thread, no need for Invoke. 
                Me.txtLastError.Text = Now.ToString("u") & " - not all words (" & My.Settings.words & ") found!" & vbCrLf & "Website returned:" & vbCrLf & content(1)
            End If
        End If

    End Sub

    Public Sub SetLastError(ByVal [string] As String)
        Me.txtLastError.Text = [string]
    End Sub

    Public Sub log_message(ByRef success As Boolean)
        Dim row As String
        Dim cur_index As Integer = Me.gridLog.Rows.Count

        ' show that thread is still active
        If Me.lblThreadStatus.InvokeRequired Then
            ' It's on a different thread, so use Invoke. 
            Dim d As New SetTextCallback(AddressOf SetTreadLabel)
            Me.Invoke(d, New Object() {"running - "})
        Else
            ' It's on the same thread, no need for Invoke. 
            Me.lblThreadStatus.Text = "running - " & Now.ToString("u")
        End If


        If success = True And My.Settings.report_ok = True Then
            ' log positive message
            row = "OK," & Now.ToString("u") & "," & My.Settings.url
        ElseIf success = False And My.Settings.report_error = True Then
            ' log negative message
            row = "ERROR," & Now.ToString("u") & "," & My.Settings.url
            increment_error_counter()
        Else
            Exit Sub
        End If

        ' Check if this method is running on a different thread 
        ' than the thread that created the control. 
        If Me.gridLog.InvokeRequired Then
            ' It's on a different thread, so use Invoke. 
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {row})
        Else
            ' It's on the same thread, no need for Invoke. 
            Me.gridLog.Rows.Insert(0, [row])
        End If

    End Sub

    Private Sub increment_error_counter()
        ' increments the error counter
        If Me.lblErrorCnt.InvokeRequired Then
            ' It's on a different thread, so use Invoke. 
            Dim d As New SetIntCallback(AddressOf SetErrorCount)
            Me.Invoke(d, New Object() {})
        Else
            ' It's on the same thread, no need for Invoke. 
            Me.lblErrorCnt.Text = Me.lblErrorCnt.Text + 1
        End If
    End Sub

    Private Sub SetErrorCount()
        Me.lblErrorCnt.Text = Me.lblErrorCnt.Text + 1
        Me.lblErrorCnt.ForeColor = Color.Red
    End Sub

    Private Sub SetTreadLabel(ByVal [text] As String)
        'indicate that the worker is still aive
        Me.lblThreadStatus.Text = [text] & Now.ToString("u")
    End Sub

    ' This method is passed in to the SetTextCallBack delegate 
    ' to set the property of gridLog 
    Private Sub SetText(ByVal [text] As String)

        Dim row As String() = [text].Split(",")

        'Me.gridLog.Rows.Add(row)
        Me.gridLog.Rows.Insert(0, row)
    End Sub


    Public Function DownloadWebpage(ByVal URL As String) As Object
        'http://msdn.microsoft.com/de-de/library/bb979281.aspx
        ' Lädt den Quelltext einer Seite aus dem Inter-/Intranet herunter  
        ' und liefert ihn als String zurück. Bei Auftreten eines 
        ' beliebigen Fehlers wird ein leerer String returniert. 
        ' MOD Kaiser: returns an object (0) status code=200|!200, (1) content/error message
        Dim IoStream As System.IO.Stream
        Dim StrRead As System.IO.StreamReader
        Dim ret(1) As Object
        Try
            ' Einen WebRequest für den URL erzeugen 
            Dim Request As System.Net.WebRequest _
            = System.Net.WebRequest.Create(URL)
            Request.Timeout = My.Settings.timeout
            ' Die Antwort auf den Request in einen Stream legen 
            IoStream = Request.GetResponse.GetResponseStream
            ' Einen StreamReader erzeugen, der den Stream ausliest 
            StrRead = New System.IO.StreamReader(IoStream)
            ' Den Quellcode des URLs zurückgeben 
            ret(0) = "200"
            ret(1) = StrRead.ReadToEnd
            Return ret
        Catch ex As System.Net.WebException
            ret(0) = "!200"
            ret(1) = ex.Message
            Return ret
        Catch ex As Exception ' bei beliebigem Fehler
            ret(0) = "!200"
            ret(1) = ex.Message
            Return ret
        Finally
            ' StreamReader und Stream in jedem Fall wieder schließen 
            If Not StrRead Is Nothing Then
                StrRead.Close()
            End If

            If Not IoStream Is Nothing Then
                IoStream.Close()
            End If
        End Try
    End Function

    Private Sub frmMain_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        'start / when pressing enter and terminate on ESC
        If e.KeyCode = 27 Or e.KeyCode = 13 Then
            'enusre that btnToggle has no focus or monitoring is started and stopped right away
            If e.KeyCode = 13 And btnToggle.Focused() = True Then
                Exit Sub
            End If

            ' exit if monitoring is currently stopped - exit on second ESC
            If e.KeyCode = 27 And btnToggle.Text = "Start" Then
                Application.Exit()
            End If

            toggle_monitor()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'load and prepare settigns
        If Not My.Settings.IsUpgraded Then
            My.Settings.Upgrade()
            My.Settings.IsUpgraded = True
            MsgBox("Your settings have been imported from the previous version.", MsgBoxStyle.Information, "Upgrade Complete")
        End If

        'load settings
        txtSrv.Text = My.Settings.url
        txtFreq.Text = My.Settings.frequency
        txtWebTimeout.Text = My.Settings.timeout
        txtWordUp.Text = My.Settings.words
        chkReportError.Checked = My.Settings.report_error
        chkReportOK.Checked = My.Settings.report_ok

        Dim tooltip_words As ToolTip = New ToolTip()
        tooltip_words.SetToolTip(txtWordUp, "comma separated list of words to look for on the website specified above")

        'define default grid view
        setup_new_grid()
    End Sub

    Private Sub reset_input()
        setup_new_grid()
        lblErrorCnt.Text = 0
        lblErrorCnt.ForeColor = Color.Black
        txtLastError.Text = "no errors yet ...."
    End Sub

    Private Sub setup_new_grid()
        'setup data grid
        gridLog.Rows.Clear()
        gridLog.ColumnCount = 3
        gridLog.Columns(0).Name = "Status"
        gridLog.Columns(1).Name = "Datum"
        gridLog.Columns(2).Name = "Host"
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub chkReportOK_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkReportOK.CheckedChanged

        If chkReportOK.Checked = True Then
            My.Settings.report_ok = True
        Else
            My.Settings.report_ok = False
        End If
    End Sub

    Private Sub chkReportError_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkReportError.CheckedChanged
        If chkReportError.Checked = True Then
            My.Settings.report_error = True
        Else
            My.Settings.report_error = False
        End If
    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        reset_input()
    End Sub



    Private Sub btnExit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnAbout_Click(sender As System.Object, e As System.EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnToggle_Click(sender As System.Object, e As System.EventArgs) Handles btnToggle.Click
        toggle_monitor()
    End Sub

    Private Sub toggle_inputs()
        ' loop over group box and disable all input fields
        For Each ele As Windows.Forms.Control In grpInput.Controls
            If TypeOf ele Is TextBox Then
                Dim suckit As TextBox = ele
                If suckit.ReadOnly = True Then
                    suckit.ReadOnly = False
                Else
                    suckit.ReadOnly = True
                End If
            End If
        Next
    End Sub
End Class
