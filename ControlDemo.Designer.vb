<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCtrlDemo
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
        Me.listBoxS = New System.Windows.Forms.ListBox()
        Me.listBoxD = New System.Windows.Forms.ListBox()
        Me.lblStotal = New System.Windows.Forms.Label()
        Me.btnAddCity = New System.Windows.Forms.Button()
        Me.btnRemCity = New System.Windows.Forms.Button()
        Me.btnStoD = New System.Windows.Forms.Button()
        Me.btnStoDall = New System.Windows.Forms.Button()
        Me.btnDtoS = New System.Windows.Forms.Button()
        Me.btnDtoSall = New System.Windows.Forms.Button()
        Me.lblDtotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'listBoxS
        '
        Me.listBoxS.FormattingEnabled = True
        Me.listBoxS.ItemHeight = 16
        Me.listBoxS.Items.AddRange(New Object() {"patna ", "delhi", "kolkata"})
        Me.listBoxS.Location = New System.Drawing.Point(130, 34)
        Me.listBoxS.Name = "listBoxS"
        Me.listBoxS.Size = New System.Drawing.Size(120, 164)
        Me.listBoxS.TabIndex = 0
        '
        'listBoxD
        '
        Me.listBoxD.FormattingEnabled = True
        Me.listBoxD.ItemHeight = 16
        Me.listBoxD.Location = New System.Drawing.Point(493, 34)
        Me.listBoxD.Name = "listBoxD"
        Me.listBoxD.Size = New System.Drawing.Size(120, 164)
        Me.listBoxD.TabIndex = 1
        '
        'lblStotal
        '
        Me.lblStotal.AutoSize = True
        Me.lblStotal.Location = New System.Drawing.Point(130, 211)
        Me.lblStotal.Name = "lblStotal"
        Me.lblStotal.Size = New System.Drawing.Size(67, 17)
        Me.lblStotal.TabIndex = 2
        Me.lblStotal.Text = "Total City"
        '
        'btnAddCity
        '
        Me.btnAddCity.Location = New System.Drawing.Point(260, 346)
        Me.btnAddCity.Name = "btnAddCity"
        Me.btnAddCity.Size = New System.Drawing.Size(75, 35)
        Me.btnAddCity.TabIndex = 3
        Me.btnAddCity.Text = "Add City"
        Me.btnAddCity.UseVisualStyleBackColor = True
        '
        'btnRemCity
        '
        Me.btnRemCity.Location = New System.Drawing.Point(390, 346)
        Me.btnRemCity.Name = "btnRemCity"
        Me.btnRemCity.Size = New System.Drawing.Size(100, 35)
        Me.btnRemCity.TabIndex = 4
        Me.btnRemCity.Text = "Remove City"
        Me.btnRemCity.UseVisualStyleBackColor = True
        '
        'btnStoD
        '
        Me.btnStoD.Location = New System.Drawing.Point(335, 36)
        Me.btnStoD.Name = "btnStoD"
        Me.btnStoD.Size = New System.Drawing.Size(75, 23)
        Me.btnStoD.TabIndex = 5
        Me.btnStoD.Text = ">"
        Me.btnStoD.UseVisualStyleBackColor = True
        '
        'btnStoDall
        '
        Me.btnStoDall.Location = New System.Drawing.Point(335, 77)
        Me.btnStoDall.Name = "btnStoDall"
        Me.btnStoDall.Size = New System.Drawing.Size(75, 23)
        Me.btnStoDall.TabIndex = 6
        Me.btnStoDall.Text = ">>"
        Me.btnStoDall.UseVisualStyleBackColor = True
        '
        'btnDtoS
        '
        Me.btnDtoS.Location = New System.Drawing.Point(335, 125)
        Me.btnDtoS.Name = "btnDtoS"
        Me.btnDtoS.Size = New System.Drawing.Size(75, 23)
        Me.btnDtoS.TabIndex = 7
        Me.btnDtoS.Text = "<"
        Me.btnDtoS.UseVisualStyleBackColor = True
        '
        'btnDtoSall
        '
        Me.btnDtoSall.Location = New System.Drawing.Point(335, 174)
        Me.btnDtoSall.Name = "btnDtoSall"
        Me.btnDtoSall.Size = New System.Drawing.Size(75, 23)
        Me.btnDtoSall.TabIndex = 8
        Me.btnDtoSall.Text = "<<"
        Me.btnDtoSall.UseVisualStyleBackColor = True
        '
        'lblDtotal
        '
        Me.lblDtotal.AutoSize = True
        Me.lblDtotal.Location = New System.Drawing.Point(500, 211)
        Me.lblDtotal.Name = "lblDtotal"
        Me.lblDtotal.Size = New System.Drawing.Size(67, 17)
        Me.lblDtotal.TabIndex = 9
        Me.lblDtotal.Text = "Total City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(490, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Destination city"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Source City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Enter City Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(341, 281)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 35)
        Me.TextBox1.TabIndex = 13
        '
        'frmCtrlDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDtotal)
        Me.Controls.Add(Me.btnDtoSall)
        Me.Controls.Add(Me.btnDtoS)
        Me.Controls.Add(Me.btnStoDall)
        Me.Controls.Add(Me.btnStoD)
        Me.Controls.Add(Me.btnRemCity)
        Me.Controls.Add(Me.btnAddCity)
        Me.Controls.Add(Me.lblStotal)
        Me.Controls.Add(Me.listBoxD)
        Me.Controls.Add(Me.listBoxS)
        Me.Name = "frmCtrlDemo"
        Me.Text = "Controls Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listBoxS As ListBox
    Friend WithEvents listBoxD As ListBox
    Friend WithEvents lblStotal As Label
    Friend WithEvents btnAddCity As Button
    Friend WithEvents btnRemCity As Button
    Friend WithEvents btnStoD As Button
    Friend WithEvents btnStoDall As Button
    Friend WithEvents btnDtoS As Button
    Friend WithEvents btnDtoSall As Button
    Friend WithEvents lblDtotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
