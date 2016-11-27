<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Addition))
        Me.lbl2DP = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNewSum = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblHard = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblEasy = New System.Windows.Forms.Label()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl2DP
        '
        Me.lbl2DP.AutoSize = True
        Me.lbl2DP.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2DP.Location = New System.Drawing.Point(616, 156)
        Me.lbl2DP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2DP.Name = "lbl2DP"
        Me.lbl2DP.Size = New System.Drawing.Size(350, 37)
        Me.lbl2DP.TabIndex = 121
        Me.lbl2DP.Text = "Answer to 2 decimal places"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(475, 149)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(132, 46)
        Me.txtAnswer.TabIndex = 120
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 58)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(216, 143)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 58)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "+"
        '
        'txtNum1
        '
        Me.txtNum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(75, 149)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(132, 46)
        Me.txtNum1.TabIndex = 117
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum2
        '
        Me.txtNum2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(275, 149)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(132, 46)
        Me.txtNum2.TabIndex = 116
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(899, 289)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(132, 46)
        Me.txtScore.TabIndex = 115
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(921, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 37)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Score"
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCheck.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheck.Location = New System.Drawing.Point(725, 287)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(165, 49)
        Me.btnCheck.TabIndex = 113
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(459, 11)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(147, 45)
        Me.lblTitle.TabIndex = 112
        Me.lblTitle.Text = "Addition"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(420, 442)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(231, 63)
        Me.btnExit.TabIndex = 111
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnNewSum
        '
        Me.btnNewSum.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNewSum.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewSum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewSum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewSum.Location = New System.Drawing.Point(824, 442)
        Me.btnNewSum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewSum.Name = "btnNewSum"
        Me.btnNewSum.Size = New System.Drawing.Size(231, 63)
        Me.btnNewSum.TabIndex = 110
        Me.btnNewSum.Text = "New Sum"
        Me.btnNewSum.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMenu.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.Location = New System.Drawing.Point(20, 442)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(231, 63)
        Me.btnMenu.TabIndex = 109
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(400, 304)
        Me.lblSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(254, 37)
        Me.lblSelect.TabIndex = 108
        Me.lblSelect.Text = "Select Sum Difficult"
        '
        'lblHard
        '
        Me.lblHard.AutoSize = True
        Me.lblHard.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHard.Location = New System.Drawing.Point(976, 402)
        Me.lblHard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHard.Name = "lblHard"
        Me.lblHard.Size = New System.Drawing.Size(76, 37)
        Me.lblHard.TabIndex = 107
        Me.lblHard.Text = "Hard"
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TrackBar2.LargeChange = 1
        Me.TrackBar2.Location = New System.Drawing.Point(33, 343)
        Me.TrackBar2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TrackBar2.Maximum = 2
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(999, 56)
        Me.TrackBar2.TabIndex = 106
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedium.Location = New System.Drawing.Point(468, 402)
        Me.lblMedium.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(121, 37)
        Me.lblMedium.TabIndex = 105
        Me.lblMedium.Text = "Medium"
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEasy.Location = New System.Drawing.Point(13, 402)
        Me.lblEasy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(71, 37)
        Me.lblEasy.TabIndex = 104
        Me.lblEasy.Text = "Easy"
        '
        'Addition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1071, 516)
        Me.Controls.Add(Me.lbl2DP)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNewSum)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblHard)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.lblMedium)
        Me.Controls.Add(Me.lblEasy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Addition"
        Me.Text = "Maths Challenge"
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl2DP As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNewSum As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblHard As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents lblMedium As Label
    Friend WithEvents lblEasy As Label
End Class
