<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim OperatorBadgeID As System.Windows.Forms.Label
        Dim TimeLabel As System.Windows.Forms.Label
        Dim Date_testLabel As System.Windows.Forms.Label
        Dim Operator_testLabel As System.Windows.Forms.Label
        Dim RWO_IdLabel As System.Windows.Forms.Label
        Dim Total_Test_TimeLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TestingtimeStart1 = New System.Windows.Forms.TextBox()
        Me.Date_testDate = New System.Windows.Forms.TextBox()
        Me.ComboBoxBadgeId = New System.Windows.Forms.ComboBox()
        Me.ComboBoxOpName = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRWO_Id = New System.Windows.Forms.ComboBox()
        Me.StopBT = New System.Windows.Forms.Button()
        Me.Start_BT = New System.Windows.Forms.Button()
        Me.Total_Test_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBoxFCT = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelXY = New System.Windows.Forms.Label()
        Me.LabelRGB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxSN = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ExcelDialog = New System.Windows.Forms.SaveFileDialog()
        Me.LabelHex = New System.Windows.Forms.Label()
        Me.LabelWARNA = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LabelTesting = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBoxModel = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLot = New System.Windows.Forms.ComboBox()
        Me.Timer_PASS = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_FAIL = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxDelay = New System.Windows.Forms.CheckBox()
        Me.LabelEstimate = New System.Windows.Forms.Label()
        Me.LabelAdditional = New System.Windows.Forms.Label()
        Me.PanelDelay = New System.Windows.Forms.Panel()
        Me.ComboBoxAdd = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEst = New System.Windows.Forms.ComboBox()
        OperatorBadgeID = New System.Windows.Forms.Label()
        TimeLabel = New System.Windows.Forms.Label()
        Date_testLabel = New System.Windows.Forms.Label()
        Operator_testLabel = New System.Windows.Forms.Label()
        RWO_IdLabel = New System.Windows.Forms.Label()
        Total_Test_TimeLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDelay.SuspendLayout()
        Me.SuspendLayout()
        '
        'OperatorBadgeID
        '
        OperatorBadgeID.AutoSize = True
        OperatorBadgeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OperatorBadgeID.Location = New System.Drawing.Point(18, 85)
        OperatorBadgeID.Name = "OperatorBadgeID"
        OperatorBadgeID.Size = New System.Drawing.Size(145, 16)
        OperatorBadgeID.TabIndex = 424
        OperatorBadgeID.Text = "Operator Badge ID :"
        '
        'TimeLabel
        '
        TimeLabel.AutoSize = True
        TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TimeLabel.Location = New System.Drawing.Point(296, 11)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(86, 16)
        TimeLabel.TabIndex = 421
        TimeLabel.Text = "Start Time :"
        '
        'Date_testLabel
        '
        Date_testLabel.AutoSize = True
        Date_testLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_testLabel.Location = New System.Drawing.Point(80, 15)
        Date_testLabel.Name = "Date_testLabel"
        Date_testLabel.Size = New System.Drawing.Size(83, 16)
        Date_testLabel.TabIndex = 420
        Date_testLabel.Text = "Date Test :"
        '
        'Operator_testLabel
        '
        Operator_testLabel.AutoSize = True
        Operator_testLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Operator_testLabel.Location = New System.Drawing.Point(42, 58)
        Operator_testLabel.Name = "Operator_testLabel"
        Operator_testLabel.Size = New System.Drawing.Size(121, 16)
        Operator_testLabel.TabIndex = 419
        Operator_testLabel.Text = "Operator Name :"
        '
        'RWO_IdLabel
        '
        RWO_IdLabel.AutoSize = True
        RWO_IdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RWO_IdLabel.Location = New System.Drawing.Point(112, 34)
        RWO_IdLabel.Name = "RWO_IdLabel"
        RWO_IdLabel.Size = New System.Drawing.Size(51, 16)
        RWO_IdLabel.TabIndex = 418
        RWO_IdLabel.Text = "RWO :"
        '
        'Total_Test_TimeLabel
        '
        Total_Test_TimeLabel.AutoSize = True
        Total_Test_TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Total_Test_TimeLabel.Location = New System.Drawing.Point(776, 2)
        Total_Test_TimeLabel.Name = "Total_Test_TimeLabel"
        Total_Test_TimeLabel.Size = New System.Drawing.Size(121, 16)
        Total_Test_TimeLabel.TabIndex = 430
        Total_Test_TimeLabel.Text = "Total Test Time:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(984, 4)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(107, 15)
        Label3.TabIndex = 432
        Label3.Text = "TEST RESULT :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(692, 47)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 16)
        Label5.TabIndex = 436
        Label5.Text = "Model :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(712, 78)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(36, 16)
        Label1.TabIndex = 448
        Label1.Text = "SN :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(348, 35)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(70, 16)
        Label2.TabIndex = 449
        Label2.Text = "Lot Size :"
        '
        'TestingtimeStart1
        '
        Me.TestingtimeStart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestingtimeStart1.Location = New System.Drawing.Point(387, 9)
        Me.TestingtimeStart1.Name = "TestingtimeStart1"
        Me.TestingtimeStart1.Size = New System.Drawing.Size(114, 20)
        Me.TestingtimeStart1.TabIndex = 422
        Me.TestingtimeStart1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Date_testDate
        '
        Me.Date_testDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_testDate.Location = New System.Drawing.Point(167, 9)
        Me.Date_testDate.Name = "Date_testDate"
        Me.Date_testDate.Size = New System.Drawing.Size(122, 20)
        Me.Date_testDate.TabIndex = 423
        Me.Date_testDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBoxBadgeId
        '
        Me.ComboBoxBadgeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBadgeId.FormattingEnabled = True
        Me.ComboBoxBadgeId.Location = New System.Drawing.Point(167, 81)
        Me.ComboBoxBadgeId.Name = "ComboBoxBadgeId"
        Me.ComboBoxBadgeId.Size = New System.Drawing.Size(334, 21)
        Me.ComboBoxBadgeId.TabIndex = 427
        '
        'ComboBoxOpName
        '
        Me.ComboBoxOpName.Enabled = False
        Me.ComboBoxOpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxOpName.FormattingEnabled = True
        Me.ComboBoxOpName.Location = New System.Drawing.Point(167, 56)
        Me.ComboBoxOpName.Name = "ComboBoxOpName"
        Me.ComboBoxOpName.Size = New System.Drawing.Size(334, 21)
        Me.ComboBoxOpName.TabIndex = 426
        '
        'ComboBoxRWO_Id
        '
        Me.ComboBoxRWO_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxRWO_Id.FormattingEnabled = True
        Me.ComboBoxRWO_Id.Location = New System.Drawing.Point(167, 32)
        Me.ComboBoxRWO_Id.Name = "ComboBoxRWO_Id"
        Me.ComboBoxRWO_Id.Size = New System.Drawing.Size(169, 21)
        Me.ComboBoxRWO_Id.TabIndex = 425
        '
        'StopBT
        '
        Me.StopBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.StopBT.Location = New System.Drawing.Point(511, 58)
        Me.StopBT.Name = "StopBT"
        Me.StopBT.Size = New System.Drawing.Size(167, 39)
        Me.StopBT.TabIndex = 429
        Me.StopBT.Text = "STOP"
        Me.StopBT.UseVisualStyleBackColor = True
        '
        'Start_BT
        '
        Me.Start_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_BT.Location = New System.Drawing.Point(511, 13)
        Me.Start_BT.Name = "Start_BT"
        Me.Start_BT.Size = New System.Drawing.Size(167, 39)
        Me.Start_BT.TabIndex = 428
        Me.Start_BT.Text = "START TESTING"
        Me.Start_BT.UseVisualStyleBackColor = True
        '
        'Total_Test_TimeTextBox
        '
        Me.Total_Test_TimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Test_TimeTextBox.Location = New System.Drawing.Point(753, 22)
        Me.Total_Test_TimeTextBox.Name = "Total_Test_TimeTextBox"
        Me.Total_Test_TimeTextBox.Size = New System.Drawing.Size(177, 22)
        Me.Total_Test_TimeTextBox.TabIndex = 431
        Me.Total_Test_TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultTextBoxFCT
        '
        Me.ResultTextBoxFCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultTextBoxFCT.Location = New System.Drawing.Point(961, 22)
        Me.ResultTextBoxFCT.Name = "ResultTextBoxFCT"
        Me.ResultTextBoxFCT.Size = New System.Drawing.Size(170, 24)
        Me.ResultTextBoxFCT.TabIndex = 433
        Me.ResultTextBoxFCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 132)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1142, 167)
        Me.RichTextBox1.TabIndex = 434
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.WordWrap = False
        '
        'Timer1
        '
        '
        'LabelXY
        '
        Me.LabelXY.AutoSize = True
        Me.LabelXY.Location = New System.Drawing.Point(756, 116)
        Me.LabelXY.Name = "LabelXY"
        Me.LabelXY.Size = New System.Drawing.Size(24, 13)
        Me.LabelXY.TabIndex = 440
        Me.LabelXY.Text = "X,Y"
        Me.LabelXY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelRGB
        '
        Me.LabelRGB.AutoSize = True
        Me.LabelRGB.Location = New System.Drawing.Point(752, 100)
        Me.LabelRGB.Name = "LabelRGB"
        Me.LabelRGB.Size = New System.Drawing.Size(30, 13)
        Me.LabelRGB.TabIndex = 439
        Me.LabelRGB.Text = "RGB"
        Me.LabelRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(950, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 39)
        Me.PictureBox1.TabIndex = 438
        Me.PictureBox1.TabStop = False
        '
        'TextBoxSN
        '
        Me.TextBoxSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSN.Location = New System.Drawing.Point(753, 73)
        Me.TextBoxSN.Name = "TextBoxSN"
        Me.TextBoxSN.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxSN.TabIndex = 441
        Me.TextBoxSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'LabelHex
        '
        Me.LabelHex.AutoSize = True
        Me.LabelHex.Location = New System.Drawing.Point(947, 100)
        Me.LabelHex.Name = "LabelHex"
        Me.LabelHex.Size = New System.Drawing.Size(30, 13)
        Me.LabelHex.TabIndex = 442
        Me.LabelHex.Text = "RGB"
        Me.LabelHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelWARNA
        '
        Me.LabelWARNA.AutoSize = True
        Me.LabelWARNA.Location = New System.Drawing.Point(1070, 100)
        Me.LabelWARNA.Name = "LabelWARNA"
        Me.LabelWARNA.Size = New System.Drawing.Size(0, 13)
        Me.LabelWARNA.TabIndex = 443
        Me.LabelWARNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(30, 109)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox1.TabIndex = 444
        Me.CheckBox1.Text = "LOG TEST"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LabelTesting
        '
        Me.LabelTesting.AutoSize = True
        Me.LabelTesting.Location = New System.Drawing.Point(228, 186)
        Me.LabelTesting.Name = "LabelTesting"
        Me.LabelTesting.Size = New System.Drawing.Size(0, 13)
        Me.LabelTesting.TabIndex = 445
        Me.LabelTesting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 446
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBoxModel
        '
        Me.ComboBoxModel.FormattingEnabled = True
        Me.ComboBoxModel.Items.AddRange(New Object() {"850324-105", "850326-105", "850328-105"})
        Me.ComboBoxModel.Location = New System.Drawing.Point(753, 47)
        Me.ComboBoxModel.Name = "ComboBoxModel"
        Me.ComboBoxModel.Size = New System.Drawing.Size(177, 21)
        Me.ComboBoxModel.TabIndex = 447
        '
        'ComboBoxLot
        '
        Me.ComboBoxLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxLot.FormattingEnabled = True
        Me.ComboBoxLot.Location = New System.Drawing.Point(416, 32)
        Me.ComboBoxLot.Name = "ComboBoxLot"
        Me.ComboBoxLot.Size = New System.Drawing.Size(85, 21)
        Me.ComboBoxLot.TabIndex = 450
        '
        'Timer_PASS
        '
        '
        'Timer_FAIL
        '
        '
        'CheckBoxDelay
        '
        Me.CheckBoxDelay.AutoSize = True
        Me.CheckBoxDelay.Location = New System.Drawing.Point(1142, 136)
        Me.CheckBoxDelay.Name = "CheckBoxDelay"
        Me.CheckBoxDelay.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxDelay.TabIndex = 452
        Me.CheckBoxDelay.UseVisualStyleBackColor = True
        '
        'LabelEstimate
        '
        Me.LabelEstimate.AutoSize = True
        Me.LabelEstimate.Location = New System.Drawing.Point(11, 18)
        Me.LabelEstimate.Name = "LabelEstimate"
        Me.LabelEstimate.Size = New System.Drawing.Size(92, 13)
        Me.LabelEstimate.TabIndex = 454
        Me.LabelEstimate.Text = "Estimate Fail Testi"
        '
        'LabelAdditional
        '
        Me.LabelAdditional.AutoSize = True
        Me.LabelAdditional.Location = New System.Drawing.Point(11, 48)
        Me.LabelAdditional.Name = "LabelAdditional"
        Me.LabelAdditional.Size = New System.Drawing.Size(96, 13)
        Me.LabelAdditional.TabIndex = 455
        Me.LabelAdditional.Text = "Additional Fail Test"
        '
        'PanelDelay
        '
        Me.PanelDelay.Controls.Add(Me.ComboBoxAdd)
        Me.PanelDelay.Controls.Add(Me.ComboBoxEst)
        Me.PanelDelay.Controls.Add(Me.LabelEstimate)
        Me.PanelDelay.Controls.Add(Me.LabelAdditional)
        Me.PanelDelay.Location = New System.Drawing.Point(946, 161)
        Me.PanelDelay.Name = "PanelDelay"
        Me.PanelDelay.Size = New System.Drawing.Size(211, 80)
        Me.PanelDelay.TabIndex = 456
        '
        'ComboBoxAdd
        '
        Me.ComboBoxAdd.FormattingEnabled = True
        Me.ComboBoxAdd.Location = New System.Drawing.Point(111, 45)
        Me.ComboBoxAdd.Name = "ComboBoxAdd"
        Me.ComboBoxAdd.Size = New System.Drawing.Size(89, 21)
        Me.ComboBoxAdd.TabIndex = 458
        '
        'ComboBoxEst
        '
        Me.ComboBoxEst.FormattingEnabled = True
        Me.ComboBoxEst.Location = New System.Drawing.Point(111, 15)
        Me.ComboBoxEst.Name = "ComboBoxEst"
        Me.ComboBoxEst.Size = New System.Drawing.Size(89, 21)
        Me.ComboBoxEst.TabIndex = 457
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 322)
        Me.Controls.Add(Me.PanelDelay)
        Me.Controls.Add(Me.CheckBoxDelay)
        Me.Controls.Add(Me.ComboBoxLot)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBoxModel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelTesting)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LabelWARNA)
        Me.Controls.Add(Me.LabelHex)
        Me.Controls.Add(Me.TextBoxSN)
        Me.Controls.Add(Me.LabelXY)
        Me.Controls.Add(Me.LabelRGB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ResultTextBoxFCT)
        Me.Controls.Add(Total_Test_TimeLabel)
        Me.Controls.Add(Me.Total_Test_TimeTextBox)
        Me.Controls.Add(Me.StopBT)
        Me.Controls.Add(Me.Start_BT)
        Me.Controls.Add(Me.TestingtimeStart1)
        Me.Controls.Add(Me.Date_testDate)
        Me.Controls.Add(Me.ComboBoxBadgeId)
        Me.Controls.Add(Me.ComboBoxOpName)
        Me.Controls.Add(Me.ComboBoxRWO_Id)
        Me.Controls.Add(OperatorBadgeID)
        Me.Controls.Add(TimeLabel)
        Me.Controls.Add(Date_testLabel)
        Me.Controls.Add(Operator_testLabel)
        Me.Controls.Add(RWO_IdLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FOCUS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDelay.ResumeLayout(False)
        Me.PanelDelay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TestingtimeStart1 As TextBox
    Friend WithEvents Date_testDate As TextBox
    Friend WithEvents ComboBoxBadgeId As ComboBox
    Friend WithEvents ComboBoxOpName As ComboBox
    Friend WithEvents ComboBoxRWO_Id As ComboBox
    Friend WithEvents StopBT As Button
    Friend WithEvents Start_BT As Button
    Friend WithEvents Total_Test_TimeTextBox As TextBox
    Friend WithEvents ResultTextBoxFCT As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelXY As Label
    Friend WithEvents LabelRGB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBoxSN As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ExcelDialog As SaveFileDialog
    Friend WithEvents LabelHex As Label
    Friend WithEvents LabelWARNA As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LabelTesting As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBoxModel As ComboBox
    Friend WithEvents ComboBoxLot As ComboBox
    Friend WithEvents Timer_PASS As Timer
    Friend WithEvents Timer_FAIL As Timer
    Friend WithEvents CheckBoxDelay As CheckBox
    Friend WithEvents LabelEstimate As Label
    Friend WithEvents LabelAdditional As Label
    Friend WithEvents PanelDelay As Panel
    Friend WithEvents ComboBoxAdd As ComboBox
    Friend WithEvents ComboBoxEst As ComboBox
End Class
