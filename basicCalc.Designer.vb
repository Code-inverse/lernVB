<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApplication
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
        Me.lblStartNum = New System.Windows.Forms.Label()
        Me.txtBoxStartNum = New System.Windows.Forms.TextBox()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.lblEndNum = New System.Windows.Forms.Label()
        Me.txtBoxEndNum = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblIncriment = New System.Windows.Forms.Label()
        Me.txtBoxIncr = New System.Windows.Forms.TextBox()
        Me.gbxLoopIf = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnSecNum = New System.Windows.Forms.Button()
        Me.btnFirstNum = New System.Windows.Forms.Button()
        Me.ChkBoxOnOff = New System.Windows.Forms.CheckBox()
        Me.gbxCalc = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.txtFNum = New System.Windows.Forms.TextBox()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.lblFNum = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblSNum = New System.Windows.Forms.Label()
        Me.txtSNum = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.chkBoxCalc = New System.Windows.Forms.CheckBox()
        Me.gbxLoopIf.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbxCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStartNum
        '
        Me.lblStartNum.AutoSize = True
        Me.lblStartNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblStartNum.Location = New System.Drawing.Point(46, 62)
        Me.lblStartNum.Name = "lblStartNum"
        Me.lblStartNum.Size = New System.Drawing.Size(201, 25)
        Me.lblStartNum.TabIndex = 0
        Me.lblStartNum.Text = "Enter Starting number"
        Me.lblStartNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxStartNum
        '
        Me.txtBoxStartNum.Location = New System.Drawing.Point(271, 53)
        Me.txtBoxStartNum.Multiline = True
        Me.txtBoxStartNum.Name = "txtBoxStartNum"
        Me.txtBoxStartNum.Size = New System.Drawing.Size(236, 44)
        Me.txtBoxStartNum.TabIndex = 1
        '
        'btnGen
        '
        Me.btnGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnGen.Location = New System.Drawing.Point(159, 278)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(219, 36)
        Me.btnGen.TabIndex = 2
        Me.btnGen.Text = "Generate"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'lblEndNum
        '
        Me.lblEndNum.AutoSize = True
        Me.lblEndNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEndNum.Location = New System.Drawing.Point(46, 128)
        Me.lblEndNum.Name = "lblEndNum"
        Me.lblEndNum.Size = New System.Drawing.Size(169, 25)
        Me.lblEndNum.TabIndex = 0
        Me.lblEndNum.Text = "Enter End number"
        Me.lblEndNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxEndNum
        '
        Me.txtBoxEndNum.Location = New System.Drawing.Point(271, 128)
        Me.txtBoxEndNum.Multiline = True
        Me.txtBoxEndNum.Name = "txtBoxEndNum"
        Me.txtBoxEndNum.Size = New System.Drawing.Size(236, 39)
        Me.txtBoxEndNum.TabIndex = 1
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblDisplay.Location = New System.Drawing.Point(567, 57)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(107, 25)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "..................."
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncriment
        '
        Me.lblIncriment.AutoSize = True
        Me.lblIncriment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblIncriment.Location = New System.Drawing.Point(46, 198)
        Me.lblIncriment.Name = "lblIncriment"
        Me.lblIncriment.Size = New System.Drawing.Size(90, 25)
        Me.lblIncriment.TabIndex = 0
        Me.lblIncriment.Text = "incriment"
        Me.lblIncriment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBoxIncr
        '
        Me.txtBoxIncr.Location = New System.Drawing.Point(271, 198)
        Me.txtBoxIncr.Multiline = True
        Me.txtBoxIncr.Name = "txtBoxIncr"
        Me.txtBoxIncr.Size = New System.Drawing.Size(236, 39)
        Me.txtBoxIncr.TabIndex = 1
        '
        'gbxLoopIf
        '
        Me.gbxLoopIf.Controls.Add(Me.txtBoxStartNum)
        Me.gbxLoopIf.Controls.Add(Me.btnGen)
        Me.gbxLoopIf.Controls.Add(Me.lblStartNum)
        Me.gbxLoopIf.Controls.Add(Me.txtBoxIncr)
        Me.gbxLoopIf.Controls.Add(Me.lblEndNum)
        Me.gbxLoopIf.Controls.Add(Me.txtBoxEndNum)
        Me.gbxLoopIf.Controls.Add(Me.lblIncriment)
        Me.gbxLoopIf.Location = New System.Drawing.Point(1, 51)
        Me.gbxLoopIf.Name = "gbxLoopIf"
        Me.gbxLoopIf.Size = New System.Drawing.Size(550, 330)
        Me.gbxLoopIf.TabIndex = 3
        Me.gbxLoopIf.TabStop = False
        Me.gbxLoopIf.Text = "basic application"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSum)
        Me.GroupBox2.Controls.Add(Me.btnSecNum)
        Me.GroupBox2.Controls.Add(Me.btnFirstNum)
        Me.GroupBox2.Location = New System.Drawing.Point(1, 387)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(477, 188)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prompt demo"
        '
        'btnSum
        '
        Me.btnSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSum.Location = New System.Drawing.Point(217, 121)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(102, 48)
        Me.btnSum.TabIndex = 2
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnSecNum
        '
        Me.btnSecNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSecNum.Location = New System.Drawing.Point(252, 45)
        Me.btnSecNum.Name = "btnSecNum"
        Me.btnSecNum.Size = New System.Drawing.Size(182, 36)
        Me.btnSecNum.TabIndex = 1
        Me.btnSecNum.Text = "Enter Sec. number"
        Me.btnSecNum.UseVisualStyleBackColor = True
        '
        'btnFirstNum
        '
        Me.btnFirstNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnFirstNum.Location = New System.Drawing.Point(41, 45)
        Me.btnFirstNum.Name = "btnFirstNum"
        Me.btnFirstNum.Size = New System.Drawing.Size(182, 35)
        Me.btnFirstNum.TabIndex = 0
        Me.btnFirstNum.Text = "Enter First Number"
        Me.btnFirstNum.UseVisualStyleBackColor = True
        '
        'ChkBoxOnOff
        '
        Me.ChkBoxOnOff.AutoSize = True
        Me.ChkBoxOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ChkBoxOnOff.Location = New System.Drawing.Point(12, 12)
        Me.ChkBoxOnOff.Name = "ChkBoxOnOff"
        Me.ChkBoxOnOff.Size = New System.Drawing.Size(110, 29)
        Me.ChkBoxOnOff.TabIndex = 6
        Me.ChkBoxOnOff.Text = "ON/OFF"
        Me.ChkBoxOnOff.UseVisualStyleBackColor = True
        '
        'gbxCalc
        '
        Me.gbxCalc.Controls.Add(Me.btnAdd)
        Me.gbxCalc.Controls.Add(Me.btnMulti)
        Me.gbxCalc.Controls.Add(Me.btnSub)
        Me.gbxCalc.Controls.Add(Me.txtFNum)
        Me.gbxCalc.Controls.Add(Me.btnDiv)
        Me.gbxCalc.Controls.Add(Me.lblFNum)
        Me.gbxCalc.Controls.Add(Me.txtResult)
        Me.gbxCalc.Controls.Add(Me.lblSNum)
        Me.gbxCalc.Controls.Add(Me.txtSNum)
        Me.gbxCalc.Controls.Add(Me.lblResult)
        Me.gbxCalc.Location = New System.Drawing.Point(743, 57)
        Me.gbxCalc.Name = "gbxCalc"
        Me.gbxCalc.Size = New System.Drawing.Size(514, 330)
        Me.gbxCalc.TabIndex = 7
        Me.gbxCalc.TabStop = False
        Me.gbxCalc.Text = "Calculator application"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnAdd.Location = New System.Drawing.Point(357, 272)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 36)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnMulti.Location = New System.Drawing.Point(125, 272)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(110, 36)
        Me.btnMulti.TabIndex = 4
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnSub.Location = New System.Drawing.Point(241, 272)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(110, 36)
        Me.btnSub.TabIndex = 3
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'txtFNum
        '
        Me.txtFNum.Location = New System.Drawing.Point(271, 53)
        Me.txtFNum.Multiline = True
        Me.txtFNum.Name = "txtFNum"
        Me.txtFNum.Size = New System.Drawing.Size(236, 44)
        Me.txtFNum.TabIndex = 1
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btnDiv.Location = New System.Drawing.Point(15, 272)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(104, 36)
        Me.btnDiv.TabIndex = 2
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'lblFNum
        '
        Me.lblFNum.AutoSize = True
        Me.lblFNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFNum.Location = New System.Drawing.Point(46, 62)
        Me.lblFNum.Name = "lblFNum"
        Me.lblFNum.Size = New System.Drawing.Size(146, 25)
        Me.lblFNum.TabIndex = 0
        Me.lblFNum.Text = "Enter First Num"
        Me.lblFNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(271, 198)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(236, 39)
        Me.txtResult.TabIndex = 1
        '
        'lblSNum
        '
        Me.lblSNum.AutoSize = True
        Me.lblSNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSNum.Location = New System.Drawing.Point(46, 128)
        Me.lblSNum.Name = "lblSNum"
        Me.lblSNum.Size = New System.Drawing.Size(144, 25)
        Me.lblSNum.TabIndex = 0
        Me.lblSNum.Text = "Enter Sec Num"
        Me.lblSNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSNum
        '
        Me.txtSNum.Location = New System.Drawing.Point(271, 128)
        Me.txtSNum.Multiline = True
        Me.txtSNum.Name = "txtSNum"
        Me.txtSNum.Size = New System.Drawing.Size(236, 39)
        Me.txtSNum.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblResult.Location = New System.Drawing.Point(46, 198)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(66, 25)
        Me.lblResult.TabIndex = 0
        Me.lblResult.Text = "Result"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkBoxCalc
        '
        Me.chkBoxCalc.AutoSize = True
        Me.chkBoxCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.chkBoxCalc.Location = New System.Drawing.Point(962, 22)
        Me.chkBoxCalc.Name = "chkBoxCalc"
        Me.chkBoxCalc.Size = New System.Drawing.Size(110, 29)
        Me.chkBoxCalc.TabIndex = 8
        Me.chkBoxCalc.Text = "ON/OFF"
        Me.chkBoxCalc.UseVisualStyleBackColor = True
        '
        'frmApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 574)
        Me.Controls.Add(Me.chkBoxCalc)
        Me.Controls.Add(Me.gbxCalc)
        Me.Controls.Add(Me.ChkBoxOnOff)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxLoopIf)
        Me.Controls.Add(Me.lblDisplay)
        Me.MaximizeBox = False
        Me.Name = "frmApplication"
        Me.Text = "Basic Application"
        Me.gbxLoopIf.ResumeLayout(False)
        Me.gbxLoopIf.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbxCalc.ResumeLayout(False)
        Me.gbxCalc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStartNum As Label
    Friend WithEvents txtBoxStartNum As TextBox
    Friend WithEvents btnGen As Button
    Friend WithEvents lblEndNum As Label
    Friend WithEvents txtBoxEndNum As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblIncriment As Label
    Friend WithEvents txtBoxIncr As TextBox
    Friend WithEvents gbxLoopIf As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSecNum As Button
    Friend WithEvents btnFirstNum As Button
    Friend WithEvents btnSum As Button
    Friend WithEvents ChkBoxOnOff As CheckBox
    Friend WithEvents gbxCalc As GroupBox
    Friend WithEvents txtFNum As TextBox
    Friend WithEvents btnDiv As Button
    Friend WithEvents lblFNum As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblSNum As Label
    Friend WithEvents txtSNum As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents chkBoxCalc As CheckBox
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnAdd As Button
End Class
