<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFamily = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.lblBasicFee = New System.Windows.Forms.Label()
        Me.lblAdditionalFee = New System.Windows.Forms.Label()
        Me.lblMonthlyDues = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbGolf = New System.Windows.Forms.CheckBox()
        Me.cbTennis = New System.Windows.Forms.CheckBox()
        Me.cbRacquet = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFamily)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'radFamily
        '
        Me.radFamily.AutoSize = True
        Me.radFamily.Location = New System.Drawing.Point(22, 82)
        Me.radFamily.Name = "radFamily"
        Me.radFamily.Size = New System.Drawing.Size(60, 19)
        Me.radFamily.TabIndex = 1
        Me.radFamily.TabStop = True
        Me.radFamily.Text = "&Family"
        Me.radFamily.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(22, 41)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(57, 19)
        Me.radSingle.TabIndex = 0
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "&Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Basic Fee:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(47, 286)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(84, 15)
        Me.label7.TabIndex = 3
        Me.label7.Text = "Monthly Dues:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(303, 209)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(86, 15)
        Me.label5.TabIndex = 4
        Me.label5.Text = "Additional Fee:"
        '
        'lblBasicFee
        '
        Me.lblBasicFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBasicFee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBasicFee.Location = New System.Drawing.Point(47, 226)
        Me.lblBasicFee.Name = "lblBasicFee"
        Me.lblBasicFee.Size = New System.Drawing.Size(113, 29)
        Me.lblBasicFee.TabIndex = 5
        Me.lblBasicFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdditionalFee
        '
        Me.lblAdditionalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditionalFee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblAdditionalFee.Location = New System.Drawing.Point(303, 226)
        Me.lblAdditionalFee.Name = "lblAdditionalFee"
        Me.lblAdditionalFee.Size = New System.Drawing.Size(117, 34)
        Me.lblAdditionalFee.TabIndex = 6
        Me.lblAdditionalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthlyDues
        '
        Me.lblMonthlyDues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyDues.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMonthlyDues.Location = New System.Drawing.Point(47, 308)
        Me.lblMonthlyDues.Name = "lblMonthlyDues"
        Me.lblMonthlyDues.Size = New System.Drawing.Size(113, 27)
        Me.lblMonthlyDues.TabIndex = 7
        Me.lblMonthlyDues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(269, 305)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(371, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbGolf
        '
        Me.cbGolf.AutoSize = True
        Me.cbGolf.Location = New System.Drawing.Point(32, 40)
        Me.cbGolf.Name = "cbGolf"
        Me.cbGolf.Size = New System.Drawing.Size(48, 19)
        Me.cbGolf.TabIndex = 0
        Me.cbGolf.Text = "&Golf"
        Me.cbGolf.UseVisualStyleBackColor = True
        '
        'cbTennis
        '
        Me.cbTennis.AutoSize = True
        Me.cbTennis.Location = New System.Drawing.Point(32, 65)
        Me.cbTennis.Name = "cbTennis"
        Me.cbTennis.Size = New System.Drawing.Size(59, 19)
        Me.cbTennis.TabIndex = 1
        Me.cbTennis.Text = "&Tennis"
        Me.cbTennis.UseVisualStyleBackColor = True
        '
        'cbRacquet
        '
        Me.cbRacquet.AutoSize = True
        Me.cbRacquet.Location = New System.Drawing.Point(32, 90)
        Me.cbRacquet.Name = "cbRacquet"
        Me.cbRacquet.Size = New System.Drawing.Size(88, 19)
        Me.cbRacquet.TabIndex = 2
        Me.cbRacquet.Text = "&Racquetball"
        Me.cbRacquet.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbRacquet)
        Me.GroupBox2.Controls.Add(Me.cbTennis)
        Me.GroupBox2.Controls.Add(Me.cbGolf)
        Me.GroupBox2.Location = New System.Drawing.Point(294, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 137)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 373)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMonthlyDues)
        Me.Controls.Add(Me.lblAdditionalFee)
        Me.Controls.Add(Me.lblBasicFee)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Glasgow Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFamily As RadioButton
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents label7 As Label
    Friend WithEvents label5 As Label
    Friend WithEvents lblBasicFee As Label
    Friend WithEvents lblAdditionalFee As Label
    Friend WithEvents lblMonthlyDues As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cbGolf As CheckBox
    Friend WithEvents cbTennis As CheckBox
    Friend WithEvents cbRacquet As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
