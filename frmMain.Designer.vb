<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSrv = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWordUp = New System.Windows.Forms.TextBox()
        Me.txtFreq = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gridLog = New System.Windows.Forms.DataGridView()
        Me.chkReportError = New System.Windows.Forms.CheckBox()
        Me.lblThreadStatus = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnToggle = New System.Windows.Forms.Button()
        Me.txtWebTimeout = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkReportOK = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExportLog = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGridPrune = New System.Windows.Forms.TextBox()
        Me.lblChkCounter = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblThrStarted = New System.Windows.Forms.Label()
        Me.lblErrorCnt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLastError = New System.Windows.Forms.TextBox()
        CType(Me.gridLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInput.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSrv
        '
        Me.txtSrv.Location = New System.Drawing.Point(104, 13)
        Me.txtSrv.Name = "txtSrv"
        Me.txtSrv.Size = New System.Drawing.Size(427, 20)
        Me.txtSrv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Website to Check"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Words to look for"
        '
        'txtWordUp
        '
        Me.txtWordUp.Location = New System.Drawing.Point(104, 39)
        Me.txtWordUp.Name = "txtWordUp"
        Me.txtWordUp.Size = New System.Drawing.Size(427, 20)
        Me.txtWordUp.TabIndex = 1
        '
        'txtFreq
        '
        Me.txtFreq.Location = New System.Drawing.Point(104, 65)
        Me.txtFreq.Name = "txtFreq"
        Me.txtFreq.Size = New System.Drawing.Size(38, 20)
        Me.txtFreq.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Frequency (s)"
        '
        'gridLog
        '
        Me.gridLog.AllowUserToAddRows = False
        Me.gridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLog.Location = New System.Drawing.Point(8, 74)
        Me.gridLog.Name = "gridLog"
        Me.gridLog.ReadOnly = True
        Me.gridLog.Size = New System.Drawing.Size(522, 286)
        Me.gridLog.TabIndex = 5
        Me.gridLog.TabStop = False
        '
        'chkReportError
        '
        Me.chkReportError.AutoSize = True
        Me.chkReportError.Location = New System.Drawing.Point(89, 12)
        Me.chkReportError.Name = "chkReportError"
        Me.chkReportError.Size = New System.Drawing.Size(88, 17)
        Me.chkReportError.TabIndex = 5
        Me.chkReportError.Text = "Report Errors"
        Me.chkReportError.UseVisualStyleBackColor = True
        '
        'lblThreadStatus
        '
        Me.lblThreadStatus.AutoSize = True
        Me.lblThreadStatus.Location = New System.Drawing.Point(356, 32)
        Me.lblThreadStatus.Name = "lblThreadStatus"
        Me.lblThreadStatus.Size = New System.Drawing.Size(174, 13)
        Me.lblThreadStatus.TabIndex = 10
        Me.lblThreadStatus.Text = "last check -  2013-01-01 12:33:55Z"
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnAbout)
        Me.grpInput.Controls.Add(Me.btnExit)
        Me.grpInput.Controls.Add(Me.btnToggle)
        Me.grpInput.Controls.Add(Me.txtWebTimeout)
        Me.grpInput.Controls.Add(Me.Label6)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.txtSrv)
        Me.grpInput.Controls.Add(Me.txtWordUp)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.txtFreq)
        Me.grpInput.Location = New System.Drawing.Point(13, 6)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(537, 93)
        Me.grpInput.TabIndex = 11
        Me.grpInput.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(464, 63)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(66, 23)
        Me.btnAbout.TabIndex = 13
        Me.btnAbout.TabStop = False
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(382, 63)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(66, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnToggle
        '
        Me.btnToggle.Location = New System.Drawing.Point(300, 63)
        Me.btnToggle.Name = "btnToggle"
        Me.btnToggle.Size = New System.Drawing.Size(66, 23)
        Me.btnToggle.TabIndex = 4
        Me.btnToggle.TabStop = False
        Me.btnToggle.Text = "Start"
        Me.btnToggle.UseVisualStyleBackColor = True
        '
        'txtWebTimeout
        '
        Me.txtWebTimeout.Location = New System.Drawing.Point(235, 65)
        Me.txtWebTimeout.Name = "txtWebTimeout"
        Me.txtWebTimeout.Size = New System.Drawing.Size(40, 20)
        Me.txtWebTimeout.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(162, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Timeout (ms)"
        '
        'chkReportOK
        '
        Me.chkReportOK.AutoSize = True
        Me.chkReportOK.Location = New System.Drawing.Point(89, 30)
        Me.chkReportOK.Name = "chkReportOK"
        Me.chkReportOK.Size = New System.Drawing.Size(76, 17)
        Me.chkReportOK.TabIndex = 6
        Me.chkReportOK.Text = "Report OK"
        Me.chkReportOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExportLog)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtGridPrune)
        Me.GroupBox1.Controls.Add(Me.lblChkCounter)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.lblThrStarted)
        Me.GroupBox1.Controls.Add(Me.lblErrorCnt)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkReportOK)
        Me.GroupBox1.Controls.Add(Me.lblThreadStatus)
        Me.GroupBox1.Controls.Add(Me.gridLog)
        Me.GroupBox1.Controls.Add(Me.chkReportError)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 366)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'btnExportLog
        '
        Me.btnExportLog.Location = New System.Drawing.Point(6, 12)
        Me.btnExportLog.Name = "btnExportLog"
        Me.btnExportLog.Size = New System.Drawing.Size(75, 23)
        Me.btnExportLog.TabIndex = 20
        Me.btnExportLog.Text = "export log"
        Me.btnExportLog.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(138, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Entries to keep"
        '
        'txtGridPrune
        '
        Me.txtGridPrune.Location = New System.Drawing.Point(89, 48)
        Me.txtGridPrune.Name = "txtGridPrune"
        Me.txtGridPrune.Size = New System.Drawing.Size(43, 20)
        Me.txtGridPrune.TabIndex = 18
        Me.txtGridPrune.Text = "20000"
        '
        'lblChkCounter
        '
        Me.lblChkCounter.AutoSize = True
        Me.lblChkCounter.Location = New System.Drawing.Point(278, 31)
        Me.lblChkCounter.Name = "lblChkCounter"
        Me.lblChkCounter.Size = New System.Drawing.Size(13, 13)
        Me.lblChkCounter.TabIndex = 17
        Me.lblChkCounter.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Checks"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(6, 45)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "clear log"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblThrStarted
        '
        Me.lblThrStarted.AutoSize = True
        Me.lblThrStarted.Location = New System.Drawing.Point(331, 14)
        Me.lblThrStarted.Name = "lblThrStarted"
        Me.lblThrStarted.Size = New System.Drawing.Size(198, 13)
        Me.lblThrStarted.TabIndex = 14
        Me.lblThrStarted.Text = "Monitor stopped - 2013-01-01 12:33:55Z"
        '
        'lblErrorCnt
        '
        Me.lblErrorCnt.AutoSize = True
        Me.lblErrorCnt.Location = New System.Drawing.Point(278, 14)
        Me.lblErrorCnt.Name = "lblErrorCnt"
        Me.lblErrorCnt.Size = New System.Drawing.Size(13, 13)
        Me.lblErrorCnt.TabIndex = 13
        Me.lblErrorCnt.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(238, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Errors"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLastError)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 477)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 82)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Last Error"
        '
        'txtLastError
        '
        Me.txtLastError.Location = New System.Drawing.Point(6, 13)
        Me.txtLastError.Multiline = True
        Me.txtLastError.Name = "txtLastError"
        Me.txtLastError.ReadOnly = True
        Me.txtLastError.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLastError.Size = New System.Drawing.Size(523, 63)
        Me.txtLastError.TabIndex = 0
        Me.txtLastError.TabStop = False
        Me.txtLastError.Text = "no errors yet ...."
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 571)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Internet Uptime Monitor"
        CType(Me.gridLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSrv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWordUp As System.Windows.Forms.TextBox
    Friend WithEvents txtFreq As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gridLog As System.Windows.Forms.DataGridView
    Friend WithEvents lblThreadStatus As System.Windows.Forms.Label
    Friend WithEvents chkReportError As System.Windows.Forms.CheckBox
    Friend WithEvents grpInput As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWebTimeout As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkReportOK As System.Windows.Forms.CheckBox
    Friend WithEvents lblErrorCnt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblThrStarted As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnToggle As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastError As System.Windows.Forms.TextBox
    Friend WithEvents lblChkCounter As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExportLog As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGridPrune As System.Windows.Forms.TextBox

End Class
