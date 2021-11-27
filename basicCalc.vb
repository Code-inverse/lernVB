Public Class frmApplication
    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    'Note :- the sender object gives the identity(type) of control and the "e " object gives the detaild about event and text of control
    Dim fnum, lnum
    Dim errorFlag = 0
    Sub ValidateTexBox()
        If txtFNum.Text = "" Then
            errorFlag = 1
            MsgBox("Please Enter First Num ")
            txtFNum.BackColor = Color.Red
            txtFNum.Focus()
            Exit Sub
        Else
            txtFNum.BackColor = Color.White
            txtSNum.BackColor = Color.White
            '   errorFlag = 0

        End If
        If txtSNum.Text = "" Then
            errorFlag = 1
            MsgBox("Please Enter Second Num")
            txtSNum.BackColor = Color.Red
            txtSNum.Focus()
            Exit Sub
        Else
            txtFNum.BackColor = Color.White
            txtSNum.BackColor = Color.White
            '   errorFlag = 0
        End If

    End Sub
    Function Calc(ByVal fNum As Int16, ByVal sNum As Int16, opr As String)
        If opr = "+" Then
            Return fNum + sNum
        End If
        If opr = "-" Then
            Return fNum - sNum
        End If
        If opr = "*" Then
            Return fNum * sNum
        End If
        If opr = "/" Then
            Return fNum / sNum
        End If

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        If txtBoxStartNum.Text = "" Then
            MsgBox("Please enter First value")
            txtBoxStartNum.Focus()
            Exit Sub



        End If
        If txtBoxEndNum.Text = "" Then
            MsgBox("Please enter End value")
            txtBoxStartNum.Focus()
            Exit Sub


        End If
        If txtBoxIncr.Text = "" Then
            MsgBox("Please enter incriment value")
            txtBoxStartNum.Focus()
            Exit Sub


        End If
        lblDisplay.Text = ""
        'for loop demo
        'For incr = Val(txtBoxStartNum.Text) To Val(txtBoxEndNum.Text) Step Val(txtBoxIncr.Text)
        'lblDisplay.Text = lblDisplay.Text & vbCrLf & incr
        ' Next

        'While loop demo

        Dim startNum = Val(txtBoxStartNum.Text)
        Dim endNum = Val(txtBoxEndNum.Text)
        Dim incr = Val(txtBoxIncr.Text)
        While startNum <= endNum
            lblDisplay.Text = lblDisplay.Text & vbCrLf & startNum
            startNum = startNum + incr

        End While


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBoxStartNum.TextChanged, txtBoxEndNum.TextChanged, txtBoxIncr.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblEndNum.Click, lblIncriment.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxStartNum.TabIndex = 0
        txtBoxEndNum.TabIndex = 1
        txtBoxIncr.TabIndex = 2
        btnGen.TabIndex = 3
        gbxLoopIf.Visible = False



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbxLoopIf.Enter

    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnFirstNum.Click
        fnum = Val(InputBox("Enter First number"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSecNum.Click
        lnum = Val(InputBox("Enetr second Num"))
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBoxOnOff.CheckedChanged
        If ChkBoxOnOff.Checked = True Then
            gbxLoopIf.Visible = True
        Else
            gbxLoopIf.Visible = False
        End If
    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles gbxCalc.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkBoxCalc.CheckedChanged
        If chkBoxCalc.Checked = True Then
            gbxCalc.Visible = True
        Else
            gbxCalc.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        errorFlag = 0
        ValidateTexBox()
        If errorFlag = 0 Then
            txtResult.Text = Calc(Val(txtFNum.Text), Val(txtSNum.Text), sender.ToString.Substring(sender.ToString.Length - 1))
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnSub.Click
        errorFlag = 0
        ValidateTexBox()
        If errorFlag = 0 Then
            txtResult.Text = Calc(Val(txtFNum.Text), Val(txtSNum.Text), sender.ToString.Substring(sender.ToString.Length - 1))
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        errorFlag = 0
        ValidateTexBox()

        If errorFlag = 0 Then
            txtResult.Text = Calc(Val(txtFNum.Text), Val(txtSNum.Text), sender.ToString.Substring(sender.ToString.Length - 1))
        End If

    End Sub
    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        errorFlag = 0
        ValidateTexBox()
        If errorFlag = 0 Then
            txtResult.Text = Calc(Val(txtFNum.Text), Val(txtSNum.Text), sender.ToString.Substring(sender.ToString.Length - 1))
        End If

    End Sub

    Private Sub TxtFNum_TextChanged(sender As Object, e As EventArgs) Handles txtFNum.TextChanged

    End Sub

    Private Sub txtSNum_TextChanged(sender As Object, e As EventArgs) Handles txtSNum.TextChanged

    End Sub

    Private Sub txtResult_TextChanged(sender As Object, e As EventArgs) Handles txtResult.TextChanged

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnSum.Click
        MsgBox(fnum + lnum)

    End Sub



End Class
