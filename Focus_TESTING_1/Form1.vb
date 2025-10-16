Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging

Module Wait_Function
    Public Sub Delay(ByVal dblsecs As Double)
        Const onesec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(onesec)
        dblWaitTil = Now.AddSeconds(onesec).AddSeconds(dblsecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub

End Module
Public Class Form1

    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function GetWindowDC(ByVal hwnd As IntPtr) As IntPtr
        'Do not try to name this method "GetDC" it will say that user32 doesnt have GetDC !!!
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Public Shared Function ReleaseDC(ByVal hwnd As IntPtr, ByVal hdc As IntPtr) As Int32

    End Function

    <DllImport("gdi32.dll", SetLastError:=True)>
    Public Shared Function GetPixel(ByVal hdc As IntPtr, ByVal nXPos As Integer, ByVal nYPos As Integer) As UInteger

    End Function



    Dim TestingtimeEnd As DateTime
    Dim TestingtimeStart As DateTime
    Dim result1,
        result2,
        result3,
        result4,
        result5,
        result6,
        result7,
        result8,
        result9,
        result10,
        result11,
        result12,
        result13,
        result14,
        result15,
        result16,
        result17,
        result18,
        result19 As String

    Dim x, y As Integer

    Dim s1_x, s2_x, s3_x, s4_x, s5_x, s6_x, s7_x, s8_x, s9_x, s10_x, s11_x, s12_x, s13_x, s14_x, s15_x, s16_x, s17_x, s18_x, s19_x As Integer



    Private Sub ComboBoxAdd_SelectedIndexChanged(sender As Object, e As KeyEventArgs) Handles ComboBoxAdd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim writer1 As New StreamWriter("C:\FOCUS\Data\Additional_Fail_Test.txt")
            writer1.WriteLine(ComboBoxAdd.Text)
            writer1.Close()
            ComboBoxEst.Select()
        End If
    End Sub

    Private Sub ComboBoxEst_SelectedIndexChanged(sender As Object, e As KeyEventArgs) Handles ComboBoxEst.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim writer2 As New StreamWriter("C:\FOCUS\Data\Est_Fail_Test.txt")
            writer2.WriteLine(ComboBoxEst.Text)
            writer2.Close()
            ComboBoxAdd.Select()
        End If
    End Sub



    Private Sub CheckBoxDelay_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDelay.CheckedChanged
        If CheckBoxDelay.Checked = True Then
            'If CheckBoxShowCOM.CheckedChanged() = vbTrue Then
            'PanelCOM.Show()
            Me.Size = New System.Drawing.Size(1197, 361)
            PanelDelay.Show()
        Else
            'PanelCOM.Hide()
            'Me.Size = New System.Drawing.Size(1012, 245)
            Me.Size = New System.Drawing.Size(1197, 190)
            PanelDelay.Hide()
        End If
    End Sub

    Private Sub StopBT_Click(sender As Object, e As EventArgs) Handles StopBT.Click
        Timer1.Enabled = False
        'Timer2.Enabled = False
        Timer_PASS.Enabled = False
        Timer_FAIL.Enabled = False
        Call stop_process()
        Call clean_log()
    End Sub

    Dim s1_y, s2_y, s3_y, s4_y, s5_y, s6_y, s7_y, s8_y, s9_y, s10_y, s11_y, s12_y, s13_y, s14_y, s15_y, s16_y, s17_y, s18_y, s19_y As Integer
    Dim X1, Y1, X2, Y2 As Integer

    Dim filepath1, filepath2, filepath3, filepath4 As String


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            'If CheckBoxShowCOM.CheckedChanged() = vbTrue Then
            'PanelCOM.Show()
            Me.Size = New System.Drawing.Size(1197, 361)
            LabelTesting.Hide()
        Else
            'PanelCOM.Hide()
            'Me.Size = New System.Drawing.Size(1012, 245)
            Me.Size = New System.Drawing.Size(1197, 190)
            LabelTesting.Show()
        End If

    End Sub
    Function GetValueOpName(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/OperatorName.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function
    Private Sub ComboBoxBadgeID_SelectedIndexChanged(sender As Object, e As KeyEventArgs) Handles ComboBoxBadgeId.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim writer4 As New StreamWriter("C:\FOCUS\Data\BadgeID.txt")
            ComboBoxBadgeId.Text = ComboBoxBadgeId.Text.ToUpper()
            writer4.WriteLine(ComboBoxBadgeId.Text)
            writer4.Close()
            'Form50000792_01.OperatorBadgeIDTextBox.Text = ComboBoxBadgeID.Text

            For row_ = 1 To File.ReadAllLines("C:\FOCUS\Data\OperatorName.csv").Count


                If GetValueOpName(row_, 0) = ComboBoxBadgeId.Text Then 'untuk combo gunakan text bukan SelectedItem 
                    'MsgBox("found it")
                    'Build_Num_val_ref = GetValue(row_, 1)
                    ComboBoxOpName.Text = GetValueOpName(row_, 1)

                    Dim writer3 As New StreamWriter("C:\FOCUS\Data\Operator_Name.txt")
                    ComboBoxOpName.Text = ComboBoxOpName.Text.ToUpper()
                    writer3.WriteLine(ComboBoxOpName.Text)
                    writer3.Close()
                    'Form50000792_01.Operator_testTextBox.Text = ComboBoxOpName.Text

                End If
            Next
        End If


    End Sub


    Sub clean_log()
        result1 = ""
        result2 = ""
        result3 = ""
        result4 = ""
        result5 = ""
        result6 = ""
        result7 = ""
        result8 = ""
        result9 = ""
        result10 = ""
        result11 = ""
        result12 = ""
        result13 = ""
        result14 = ""
        result15 = ""
        result16 = ""
        result17 = ""
        result18 = ""
        result19 = ""
    End Sub

    Sub stop_process()
        Total_Test_TimeTextBox.Text = "00:00:00"
        Start_BT.Enabled = True
        StopBT.Enabled = True
        Start_BT.BackColor = Color.Orange
        ResultTextBoxFCT.Clear()
        ResultTextBoxFCT.BackColor = Color.White

        RichTextBox1.Clear()
        TextBoxSN.Clear()
        'DataGridView1.ClearSelection()


    End Sub
    Private Sub Start_BT_Click(sender As Object, e As EventArgs) Handles Start_BT.Click


        If ComboBoxModel.Text = "" Or ComboBoxRWO_Id.Text = "" Or ComboBoxLot.Text = "" Or ComboBoxOpName.Text = "" Or ComboBoxBadgeId.Text = "" Then
            MsgBox("Masukan data dengan lengkap")
            Call stop_process()
            Exit Sub
        End If

        Call clean_log()
        Call stop_process()


        Timer1.Enabled = False
        'Timer2.Enabled = False
        Timer_PASS.Enabled = False
        Timer_FAIL.Enabled = False

        Start_BT.BackColor = Color.Orange
        StopBT.BackColor = Color.White
        RichTextBox1.Clear()

        If TextBoxSN.Text.Length <> 10 Then
            Do Until TextBoxSN.Text.Length = 10
                TextBoxSN.Text = ""
                'SerialNumTextBox.Text = InputBox("Scan Serial Number ID (9 digit)", "TESTING #1 :", "SE33975449", 500, 450)  'input box
                TextBoxSN.Text = InputBox("Scan Serial Number ID (10 digit)", "TESTING #1 :", "", 500, 450)  'input box
                If TextBoxSN.Text = "" Then
                    Call stop_process()
                    Exit Sub
                End If
            Loop
        End If



        'For row_ = 1 To File.ReadAllLines("C:/FOCUS/Data/Coordinate.csv").Count

        'If GetValue(row, 1) = "50000792-01" Then
        'If GetValue(row_, 1) = LabelModBuildNumber.Text Then 'Model_Menu_Form.ComboBox1.Text Then  
        'MsgBox(row & ", " & col & " = " & value)
        If ComboBoxModel.Text = "850324-105" Then

            'coordinate per switch(x,y)
            s1_x = GetValueCoord_324(1, 1)
            s2_x = GetValueCoord_324(2, 1)
            s3_x = GetValueCoord_324(3, 1)
            s4_x = GetValueCoord_324(4, 1)
            s5_x = GetValueCoord_324(5, 1)
            s6_x = GetValueCoord_324(6, 1)
            s7_x = GetValueCoord_324(7, 1)
            s8_x = GetValueCoord_324(8, 1)
            s9_x = GetValueCoord_324(9, 1)
            s10_x = GetValueCoord_324(10, 1)
            s11_x = GetValueCoord_324(11, 1)


            s1_y = GetValueCoord_324(1, 2)
            s2_y = GetValueCoord_324(2, 2)
            s3_y = GetValueCoord_324(3, 2)
            s4_y = GetValueCoord_324(4, 2)
            s5_y = GetValueCoord_324(5, 2)
            s6_y = GetValueCoord_324(6, 2)
            s7_y = GetValueCoord_324(7, 2)
            s8_y = GetValueCoord_324(8, 2)
            s9_y = GetValueCoord_324(9, 2)
            s10_y = GetValueCoord_324(10, 2)
            s11_y = GetValueCoord_324(11, 2)

            'End If
            'Next

        End If



        If ComboBoxModel.Text = "850326-105" Then

            'coordinate per switch(x,y)
            s1_x = GetValueCoord_326(1, 1)
            s2_x = GetValueCoord_326(2, 1)
            s3_x = GetValueCoord_326(3, 1)
            s4_x = GetValueCoord_326(4, 1)
            s5_x = GetValueCoord_326(5, 1)
            s6_x = GetValueCoord_326(6, 1)
            s7_x = GetValueCoord_326(7, 1)
            s8_x = GetValueCoord_326(8, 1)
            s9_x = GetValueCoord_326(9, 1)
            s10_x = GetValueCoord_326(10, 1)
            s11_x = GetValueCoord_326(11, 1)


            s1_y = GetValueCoord_326(1, 2)
            s2_y = GetValueCoord_326(2, 2)
            s3_y = GetValueCoord_326(3, 2)
            s4_y = GetValueCoord_326(4, 2)
            s5_y = GetValueCoord_326(5, 2)
            s6_y = GetValueCoord_326(6, 2)
            s7_y = GetValueCoord_326(7, 2)
            s8_y = GetValueCoord_326(8, 2)
            s9_y = GetValueCoord_326(9, 2)
            s10_y = GetValueCoord_326(10, 2)
            s11_y = GetValueCoord_326(11, 2)

            'End If
            'Next

        End If



        If ComboBoxModel.Text = "850328-105" Then

            'coordinate per switch(x,y)
            s1_x = GetValueCoord_328(1, 1)
            s2_x = GetValueCoord_328(2, 1)
            s3_x = GetValueCoord_328(3, 1)
            s4_x = GetValueCoord_328(4, 1)
            s5_x = GetValueCoord_328(5, 1)
            s6_x = GetValueCoord_328(6, 1)
            s7_x = GetValueCoord_328(7, 1)
            s8_x = GetValueCoord_328(8, 1)
            s9_x = GetValueCoord_328(9, 1)
            s10_x = GetValueCoord_328(10, 1)
            s11_x = GetValueCoord_328(11, 1)
            s12_x = GetValueCoord_328(12, 1)
            s13_x = GetValueCoord_328(13, 1)
            s14_x = GetValueCoord_328(14, 1)
            s15_x = GetValueCoord_328(15, 1)
            s16_x = GetValueCoord_328(16, 1)
            s17_x = GetValueCoord_328(17, 1)
            s18_x = GetValueCoord_328(18, 1)
            s19_x = GetValueCoord_328(19, 1)


            s1_y = GetValueCoord_328(1, 2)
            s2_y = GetValueCoord_328(2, 2)
            s3_y = GetValueCoord_328(3, 2)
            s4_y = GetValueCoord_328(4, 2)
            s5_y = GetValueCoord_328(5, 2)
            s6_y = GetValueCoord_328(6, 2)
            s7_y = GetValueCoord_328(7, 2)
            s8_y = GetValueCoord_328(8, 2)
            s9_y = GetValueCoord_328(9, 2)
            s10_y = GetValueCoord_328(10, 2)
            s11_y = GetValueCoord_328(11, 2)
            s12_y = GetValueCoord_328(12, 2)
            s13_y = GetValueCoord_328(13, 2)
            s14_y = GetValueCoord_328(14, 2)
            s15_y = GetValueCoord_328(15, 2)
            s16_y = GetValueCoord_328(16, 2)
            s17_y = GetValueCoord_328(17, 2)
            s18_y = GetValueCoord_328(18, 2)
            s19_y = GetValueCoord_328(19, 2)

            'End If
            'Next

        End If


        'Total_Test_TimeTextBox.Text = "00:00:00"
        TestingtimeStart1.Text = Format(Now, "HH:mm:ss") ' HH=jam 00-23, hh=AM atau PM
        TestingtimeStart = TestingtimeStart1.Text
        'TestingtimeStart = Format(Now, "HH:mm:ss")
        Date_testDate.Text = Format(Now, "dd-MMM-yyyy") 'samakan format ini dengan csv/excel
        'RichTextBox1.("\r\nOperator and Badge ID harus diisi\r\n", False)

        Timer1.Enabled = True

        Timer_PASS.Enabled = True


        Delay(ComboBoxEst.Text)

        If ResultTextBoxFCT.Text = "PASS" Then
            Exit Sub
        End If




        'for failure timing
        Delay(ComboBoxAdd.Text)

        If ResultTextBoxFCT.Text = "PASS" Then
            Exit Sub
        End If

        If ResultTextBoxFCT.Text = "" Then
            Timer_FAIL.Enabled = True
        End If
    End Sub
    Function GetValueCoord_324(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/Coordinate_324.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function

    Function GetValueCoord_326(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/Coordinate_326.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function
    Function GetValueCoord_328(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/Coordinate_328.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function

    Function GetValueCapture_324(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/Capture_324.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function

    Function GetValueCapture_326(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/Capture_326.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function

    Function GetValueCapture_328(row As Integer, col As Integer) As String
        'https://stackoverflow.com/questions/62584487/reading-a-specific-value-in-a-cell-in-a-csv-file-in-vb-net
        Dim csvPath = "C:/FOCUS/Data/Capture_328.csv"
        Dim result As String = String.Empty
        Dim lines = File.ReadAllLines(csvPath)
        If row < lines.Length Then
            Dim cols = lines(row).Split(","c)
            If col < cols.Length Then
                result = cols(col)
            End If
        End If
        Return result
    End Function
    Function get_color(ByVal x As Integer, ByVal y As Integer)

        Dim hdc As IntPtr = GetWindowDC(IntPtr.Zero)
        Dim pixel As UInteger = GetPixel(hdc, x, y)
        Dim color As Color
        ReleaseDC(IntPtr.Zero, hdc)

        color = Color.FromArgb(Int(pixel And &HFF),
       Int(pixel And &HFF00) >> 8,
       Int(pixel And &HFF0000) >> 16)
        'RichTextBox1.Text &= color.ToString + vbNewLine + vbNewLine


        Dim R As Integer = Int(pixel And &HFF)
        Dim G As Integer = Int(pixel And &HFF00) >> 8
        Dim B As Integer = Int(pixel And &HFF0000) >> 16

        'RichTextBox1.Text &= R.ToString + vbNewLine
        'RichTextBox1.Text &= G.ToString + vbNewLine
        'RichTextBox1.Text &= B.ToString + vbNewLine

        If R <= 200 And G >= 50 And B <= 200 Then
            'If G >= 70 Then
            'RichTextBox1.Text &= "Green"
            Return "Green"
            'Label5.Text = "Green"
        End If

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Date_testDate.Text = Format(Now, "dd-MMM-yyyy") 'samakan format ini dengan csv/excel
        'Me.Size = New System.Drawing.Size(1012, 245)
        Me.Size = New System.Drawing.Size(1197, 190)
        Total_Test_TimeTextBox.Text = "00:00:00"



        filepath1 = "C:\FOCUS\Data\Operator_Name.txt"
        ComboBoxOpName.Items.AddRange(System.IO.File.ReadAllLines(filepath1))
        ComboBoxOpName.Text = ComboBoxOpName.Items(0).ToString()



        filepath2 = "C:\FOCUS\Data\BadgeID.txt"
        ComboBoxBadgeId.Items.AddRange(System.IO.File.ReadAllLines(filepath2))
        ComboBoxBadgeId.Text = ComboBoxBadgeId.Items(0).ToString()






        filepath3 = "C:\FOCUS\Data\Est_Fail_Test.txt"
        ComboBoxEst.Items.AddRange(System.IO.File.ReadAllLines(filepath3))
        ComboBoxEst.Text = ComboBoxEst.Items(0).ToString()
        'TextBoxEstimate.Text.addrange(System.IO.File.ReadAllLines(filepath3))
        'Dim oFS3 As StreamReader = File.OpenText(filepath3)
        'TextBoxEstimate.Text = oFS3.ReadLine


        filepath4 = "C:\FOCUS\Data\Additional_Fail_Test.txt"
        ComboBoxAdd.Items.AddRange(System.IO.File.ReadAllLines(filepath4))
        ComboBoxAdd.Text = ComboBoxAdd.Items(0).ToString()
        'TextBoxAdditional.Text.addrange(System.IO.File.ReadAllLines(filepath4))
        'Dim oFS4 As StreamReader = File.OpenText(filepath4)
        'TextBoxAdditional.Text = oFS4.ReadLine

    End Sub



    Sub cek_model_324_326()
        'switch #1
        If get_color(s1_x, s1_y) = "Green" And result1 = "" Then
            RichTextBox1.Text = "Switch No1  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No1 | PASS |"
            result1 = "PASS"
        End If

        'switch #2
        If get_color(s2_x, s2_y) = "Green" And result2 = "" Then
            RichTextBox1.Text = "Switch No2  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No2 | PASS |"
            result2 = "PASS"
        End If

        'switch #3
        If get_color(s3_x, s3_y) = "Green" And result3 = "" Then
            RichTextBox1.Text = "Switch No3  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No3 | PASS |"
            result3 = "PASS"
        End If


        'switch #4
        If get_color(s4_x, s4_y) = "Green" And result4 = "" Then
            RichTextBox1.Text = "Switch No4  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No4 | PASS |"
            result4 = "PASS"
        End If


        'switch #5
        If get_color(s5_x, s5_y) = "Green" And result5 = "" Then
            RichTextBox1.Text = "Switch No5  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No5 | PASS |"
            result5 = "PASS"
        End If


        'switch #6
        If get_color(s6_x, s6_y) = "Green" And result6 = "" Then
            RichTextBox1.Text = "Switch No6  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No6 | PASS |"
            result6 = "PASS"
        End If


        'switch #7
        If get_color(s7_x, s7_y) = "Green" And result7 = "" Then
            RichTextBox1.Text = "Switch No7  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No7 | PASS |"
            result7 = "PASS"
        End If


        'switch #8
        If get_color(s8_x, s8_y) = "Green" And result8 = "" Then
            RichTextBox1.Text = "Switch No8  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No8 | PASS |"
            result8 = "PASS"
        End If


        'switch #9
        If get_color(s9_x, s9_y) = "Green" And result9 = "" Then
            RichTextBox1.Text = "Switch No9  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No9 | PASS |"
            result9 = "PASS"
        End If


        'switch #10
        If get_color(s10_x, s10_y) = "Green" And result10 = "" Then
            RichTextBox1.Text = "Switch No10 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No10 | PASS |"
            result10 = "PASS"
        End If

        'switch #11
        If get_color(s11_x, s11_y) = "Green" And result11 = "" Then
            RichTextBox1.Text = "Switch No11 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No11 | PASS |"
            result11 = "PASS"
        End If





    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboBoxModel.Text = "850324-105" Or ComboBoxModel.Text = "850326-105" Then
            Call cek_model_324_326()
        End If

        If ComboBoxModel.Text = "850328-105" Then
            Call cek_model_328()
        End If


    End Sub

    'Sub cek_pass_result()
    Private Sub Timer_PASS_Tick(sender As Object, e As EventArgs) Handles Timer_PASS.Tick

        If ComboBoxModel.Text = "850324-105" Or ComboBoxModel.Text = "850326-105" Then
            If result1 = "PASS" _
            And result2 = "PASS" _
            And result3 = "PASS" _
            And result4 = "PASS" _
            And result5 = "PASS" _
            And result6 = "PASS" _
            And result7 = "PASS" _
            And result8 = "PASS" _
            And result9 = "PASS" _
            And result10 = "PASS" _
            And result11 = "PASS" Then

                ResultTextBoxFCT.Text = "PASS"
                ResultTextBoxFCT.BackColor = Color.LightGreen
                Call finish_test()

            End If
        End If


        If ComboBoxModel.Text = "850328-105" Then

            If result1 = "PASS" _
           And result2 = "PASS" _
           And result3 = "PASS" _
           And result4 = "PASS" _
           And result5 = "PASS" _
           And result6 = "PASS" _
           And result7 = "PASS" _
           And result8 = "PASS" _
           And result9 = "PASS" _
           And result10 = "PASS" _
           And result11 = "PASS" _
           And result12 = "PASS" _
           And result13 = "PASS" _
           And result14 = "PASS" _
           And result15 = "PASS" _
           And result16 = "PASS" _
           And result17 = "PASS" _
           And result18 = "PASS" _
           And result19 = "PASS" Then

                ResultTextBoxFCT.Text = "PASS"
                ResultTextBoxFCT.BackColor = Color.LightGreen
                Call finish_test()


            End If
        End If
    End Sub

    Private Sub Timer_FAIL_Tick(sender As Object, e As EventArgs) Handles Timer_FAIL.Tick
        'If TextBoxFAIL.Text = "FAIL" Then
        If ComboBoxModel.Text = "850324-105" Or ComboBoxModel.Text = "850326-105" Then
                If result1 = "PASS" _
                And result2 = "PASS" _
                And result3 = "PASS" _
                And result4 = "PASS" _
                And result5 = "PASS" _
                And result6 = "PASS" _
                And result7 = "PASS" _
                And result8 = "PASS" _
                And result9 = "PASS" _
                And result10 = "PASS" _
                And result11 = "PASS" Then

                    ResultTextBoxFCT.Text = "PASS"
                    ResultTextBoxFCT.BackColor = Color.LightGreen
                    Call finish_test()

                Else
                    'Delay(15)

                    ResultTextBoxFCT.Text = "FAIL"
                    ResultTextBoxFCT.BackColor = Color.IndianRed

                    Call cek_failure_324_326()
                    Call finish_test()
                End If
            End If


            If ComboBoxModel.Text = "850328-105" Then

                If result1 = "PASS" _
               And result2 = "PASS" _
               And result3 = "PASS" _
               And result4 = "PASS" _
               And result5 = "PASS" _
               And result6 = "PASS" _
               And result7 = "PASS" _
               And result8 = "PASS" _
               And result9 = "PASS" _
               And result10 = "PASS" _
               And result11 = "PASS" _
               And result12 = "PASS" _
               And result13 = "PASS" _
               And result14 = "PASS" _
               And result15 = "PASS" _
               And result16 = "PASS" _
               And result17 = "PASS" _
               And result18 = "PASS" _
               And result19 = "PASS" Then

                    ResultTextBoxFCT.Text = "PASS"
                    ResultTextBoxFCT.BackColor = Color.LightGreen
                    Call finish_test()
                Else
                    'Delay(30)

                    ResultTextBoxFCT.Text = "FAIL"
                    ResultTextBoxFCT.BackColor = Color.IndianRed

                    Call cek_failure_328()
                    Call finish_test()

                End If
            End If
        ' End If
    End Sub


    'Private Sub StopBT_Click(sender As Object, e As EventArgs) Handles StopBT.Click

    Sub finish_test()
        Timer1.Enabled = False
        Timer_PASS.Enabled = False
        Timer_FAIL.Enabled = False

        Start_BT.BackColor = Color.White
        StopBT.BackColor = Color.Orange

        TestingtimeEnd = DateTime.Now
        Total_Test_TimeTextBox.Text = (TestingtimeEnd - TestingtimeStart).ToString("hh':'mm':'ss")




        Dim sb = New System.Text.StringBuilder()
        'sb.Replace("==========================SUMMARY TEST====================", "========================TEST IN PROGRESS==================")
        'sb.Append(vbNewLine)
        sb.Append(vbNewLine)
        sb.Append("==========================SUMMARY TEST====================")
        sb.Append(vbNewLine)
        sb.Append("Model                     :  " + ComboBoxModel.Text + vbNewLine)
        sb.Append("RWO Number                :  " + ComboBoxRWO_Id.Text + vbNewLine)
        sb.Append("Lot Size                  :  " + ComboBoxLot.Text + vbNewLine)
        sb.Append("Serial Number             :  " + TextBoxSN.Text + vbNewLine)
        sb.Append("Operator Name             :  " + ComboBoxOpName.Text.ToUpper() + vbNewLine)
        sb.Append("Operator Badge ID         :  " + ComboBoxBadgeId.Text + vbNewLine)

        'sb.Append("Product Name              :  " + ProductName_val_ref + vbNewLine)
        sb.Append("Date Test                 :  " + Format(Now, "dd-MMM-yyyy") + vbNewLine) 'samakan format ini dengan csv/excel
        sb.Append("Testing Time Start        :  " + TestingtimeStart1.Text + vbNewLine)
        sb.Append("Testing Time End          :  " + TestingtimeEnd.ToString("HH':'mm':'ss") + vbNewLine)
        sb.Append("Testing Time Duration     :  " + Total_Test_TimeTextBox.Text + vbNewLine)
        'sb.Append("LED Blink Check           :  " + LED_Check_result + vbNewLine)
        sb.Append("Result FCT                :  >> " + ResultTextBoxFCT.Text + " <<" + vbNewLine)
        'sb.Append("Voltage Testing           :  " + "" + "VDC" + vbNewLine)
        'sb.Append("Current Testing           :  " + "" + "ADC" + vbNewLine)

        sb.Append("==========================================================")
        sb.Append(vbNewLine)
        sb.Append(vbNewLine)
        sb.Append("============================TEST==========================")
        'sb.Append(vbNewLine)
        'sb.Append(RichTextBox1.Text)

        If ComboBoxModel.Text = "850324-105" Or ComboBoxModel.Text = "850326-105" Then
            sb.Append(vbNewLine)
            'sb.Append("==========================================================" + vbNewLine)
            sb.Append("SWITCH #1 (S1)                                  |" + result1 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #2 (S2)                                  |" + result2 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #3 (S3)                                  |" + result3 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #4 (S4)                                  |" + result4 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #5 (S5)                                  |" + result5 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #6 (S6)                                  |" + result6 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #7 (S7)                                  |" + result7 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #8 (S8)                                  |" + result8 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #9 (S9)                                  |" + result9 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #10 (S10)                                |" + result10 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #11 (S11)                                |" + result11 + "|" + vbNewLine)

        End If

        If ComboBoxModel.Text = "850328-105" Then
            sb.Append(vbNewLine)
            'sb.Append("==========================================================" + vbNewLine)
            sb.Append("SWITCH #1 (S1)                                  |" + result1 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #2 (S2)                                  |" + result2 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #3 (S3)                                  |" + result3 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #4 (S4)                                  |" + result4 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #5 (S5)                                  |" + result5 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #6 (S6)                                  |" + result6 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #7 (S7)                                  |" + result7 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #8 (S8)                                  |" + result8 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #9 (S9)                                  |" + result9 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #10 (S10)                                |" + result10 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #11 (S11)                                |" + result11 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #12 (S12)                                |" + result12 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #13 (S13)                                |" + result13 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #14 (S14)                                |" + result14 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #15 (S15)                                |" + result15 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #16 (S16)                                |" + result16 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #17 (S17)                                |" + result17 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #18 (S18)                                |" + result18 + "|" + vbNewLine)
            sb.Append("----------------------------------------------------------" + vbNewLine)
            sb.Append("SWITCH #19 (S19)                                |" + result19 + "|" + vbNewLine)

        End If

        sb.Append("=============================END==========================" + vbNewLine)
        'TextBox.Rtf = sb.ToString
        RichTextBox1.Text = sb.ToString

        '-----------------------------------------------------------------------------
        'Dim pProcess() As Process = System.Diagnostics.Process.GetProcessesByName("parsing_v2")  'jgn pakai exe, lgs kill form

        'For Each p As Process In pProcess
        'p.Kill()
        'Next
        '=====================================================

        'OK save rich text box:
        'ExcelDialog.FileName = "C:\DB Log Console Manager\Log Testing\" + MACTextBox.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HH';'mm';'ss") + "_" + "PASS" + ".txt"
        'ok ExcelDialog.FileName = "C:\DB Log Console Manager\Log Testing\" + MACTextBox.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBox.Text + ".txt"
        'System.IO.File.WriteAllText(ExcelDialog.FileName, RichTextBox1.Text) 'bisa digunakan
        'ok RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText)  'bisa digunakan

        'Dim sPath As String = IO.Path.Combine("C:\DB Log Console Manager\Log Testing\", Format(Now, "ddMMyyyy"))
        Dim sPath1 As String = IO.Path.Combine("C:\FOCUS\Log Testing\", ComboBoxRWO_Id.Text)
        Dim sPath2 As String = IO.Path.Combine("C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\", ComboBoxModel.Text)
        Dim sPath3 As String = IO.Path.Combine("C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\" + ComboBoxModel.Text + "\", "PASS")
        Dim sPath4 As String = IO.Path.Combine("C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\" + ComboBoxModel.Text + "\", "FAIL")
        'Dim sw As StreamWriter

        'If Not IO.Directory.Exists(sPath1) And Not IO.Directory.Exists(sPath2) Then
        'If Not IO.Directory.Exists(sPath2) Then
        'If Not IO.Directory.Exists(sPath1) Then
        'IO.Directory.CreateDirectory(sPath1)
        'End If
        'IO.Directory.CreateDirectory(sPath2)
        'End If

        If ResultTextBoxFCT.Text = "PASS" Then

            IO.Directory.CreateDirectory(sPath3)
            ExcelDialog.FileName = "C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\" + ComboBoxModel.Text + "\PASS\" + ComboBoxModel.Text + "_" + TextBoxSN.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBoxFCT.Text + ".txt"

            RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText)  'bisa digunakan
            RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText)
        End If


        If ResultTextBoxFCT.Text = "FAIL" Then

            IO.Directory.CreateDirectory(sPath4)
            ExcelDialog.FileName = "C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\" + ComboBoxModel.Text + "\FAIL\" + ComboBoxModel.Text + "_" + TextBoxSN.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBoxFCT.Text + ".txt"

            RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText)  'bisa digunakan
            RichTextBox1.SaveFile(ExcelDialog.FileName, RichTextBoxStreamType.PlainText)
        End If







        Me.Hide()
        Delay(2)


        If ComboBoxModel.Text = "850324-105" Then
            'coordinat capture (x,y)
            X1 = GetValueCapture_324(1, 0)
            Y1 = GetValueCapture_324(1, 1)
            X2 = GetValueCapture_324(1, 2)
            Y2 = GetValueCapture_324(1, 3)
        End If

        If ComboBoxModel.Text = "850326-105" Then
            'coordinat capture (x,y)
            X1 = GetValueCapture_326(1, 0)
            Y1 = GetValueCapture_326(1, 1)
            X2 = GetValueCapture_326(1, 2)
            Y2 = GetValueCapture_326(1, 3)
        End If

        If ComboBoxModel.Text = "850328-105" Then
            'coordinat capture (x,y)
            X1 = GetValueCapture_328(1, 0)
            Y1 = GetValueCapture_328(1, 1)
            X2 = GetValueCapture_328(1, 2)
            Y2 = GetValueCapture_328(1, 3)
        End If

        If ResultTextBoxFCT.Text = "PASS" Then
            Call ScreenCopy_PASS(X1, Y1, X2, Y2)
        End If

        If ResultTextBoxFCT.Text = "FAIL" Then
            Call ScreenCopy_FAIL(X1, Y1, X2, Y2)
        End If

        Me.Show()
        MsgBox("****TESTING SELESAI****")

    End Sub
    Sub cek_failure_324_326()
        If result1 = "" Or result1 = Nothing Then
            result1 = "FAIL"
        End If
        If result2 = "" Or result2 = Nothing Then
            result2 = "FAIL"
        End If
        If result3 = "" Or result3 = Nothing Then
            result3 = "FAIL"
        End If
        If result4 = "" Or result4 = Nothing Then
            result4 = "FAIL"
        End If
        If result5 = "" Or result5 = Nothing Then
            result5 = "FAIL"
        End If
        If result6 = "" Or result6 = Nothing Then
            result6 = "FAIL"
        End If
        If result7 = "" Or result7 = Nothing Then
            result7 = "FAIL"
        End If
        If result8 = "" Or result8 = Nothing Then
            result8 = "FAIL"
        End If
        If result9 = "" Or result9 = Nothing Then
            result9 = "FAIL"
        End If
        If result10 = "" Or result10 = Nothing Then
            result10 = "FAIL"
        End If
        If result11 = "" Or result11 = Nothing Then
            result11 = "FAIL"
        End If
    End Sub


    Sub cek_failure_328()
        If result1 = "" Or result1 = Nothing Then
            result1 = "FAIL"
        End If
        If result2 = "" Or result2 = Nothing Then
            result2 = "FAIL"
        End If
        If result3 = "" Or result3 = Nothing Then
            result3 = "FAIL"
        End If
        If result4 = "" Or result4 = Nothing Then
            result4 = "FAIL"
        End If
        If result5 = "" Or result5 = Nothing Then
            result5 = "FAIL"
        End If
        If result6 = "" Or result6 = Nothing Then
            result6 = "FAIL"
        End If
        If result7 = "" Or result7 = Nothing Then
            result7 = "FAIL"
        End If
        If result8 = "" Or result8 = Nothing Then
            result8 = "FAIL"
        End If
        If result9 = "" Or result9 = Nothing Then
            result9 = "FAIL"
        End If
        If result10 = "" Or result10 = Nothing Then
            result10 = "FAIL"
        End If
        If result11 = "" Or result11 = Nothing Then
            result11 = "FAIL"
        End If
        If result12 = "" Or result12 = Nothing Then
            result12 = "FAIL"
        End If
        If result13 = "" Or result13 = Nothing Then
            result13 = "FAIL"
        End If
        If result14 = "" Or result14 = Nothing Then
            result14 = "FAIL"
        End If
        If result15 = "" Or result15 = Nothing Then
            result15 = "FAIL"
        End If
        If result16 = "" Or result16 = Nothing Then
            result16 = "FAIL"
        End If
        If result17 = "" Or result17 = Nothing Then
            result17 = "FAIL"
        End If
        If result18 = "" Or result18 = Nothing Then
            result18 = "FAIL"
        End If
        If result19 = "" Or result19 = Nothing Then
            result19 = "FAIL"
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim bmp As New Bitmap(1, 1)
        Using g1 As Graphics = Graphics.FromImage(bmp)
            g1.CopyFromScreen(Windows.Forms.Cursor.Position, New Point(0, 0), New Size(1, 1))
        End Using

        Dim pixel As Drawing.Color = bmp.GetPixel(0, 0)
        LabelRGB.Text$ = bmp.GetPixel(0, 0).ToString
        Dim p As New Point
        p.X = (Me.Width / 2) - (LabelRGB.Width / 2)
        p.Y = LabelRGB.Top
        'Label1.Location = p
        PictureBox1.BackColor = pixel 'in ARGB
        'Label5.Text = "#" & Convert.ToInt32(pixel).ToString("X")
        'RichTextBox1.Text &= pixel.ToString
        Me.Invalidate()



        Dim MousePosition As Point  'OK
        MousePosition = Cursor.Position
        LabelXY.Text = MousePosition.ToString

        '-------------------------------------------------------
        x = MousePosition.X.ToString
        y = MousePosition.Y.ToString

        'tambahkan parsing x y dari mouse position
        Dim hdc As IntPtr = GetWindowDC(IntPtr.Zero)
        Dim pixel1 As UInteger = GetPixel(hdc, x, y)
        Dim color As Color
        ReleaseDC(IntPtr.Zero, hdc)
        'MsgBox(pixel)

        'pixel=dec
        'RichTextBox1.Text &= pixel.ToString & "  #" & Convert.ToInt32(pixel).ToString("X") + vbNewLine
        'RichTextBox1.Text &= pixel.ToString & "  #" & Hex(pixel1) + vbNewLine

        'hex color to ARGB
        'RichTextBox1.Text &= ColorTranslator.FromHtml("#003399").ToString + vbNewLine
        'RichTextBox1.Text = Drawing.Color.FromArgb(&H3399FF).ToString + vbNewLine

        'dec to ARGB
        color = Color.FromArgb(Int(pixel1 And &HFF),
        Int(pixel1 And &HFF00) >> 8,
        Int(pixel1 And &HFF0000) >> 16)
        'RichTextBox1.Text = color.ToString + vbNewLine + vbNewLine


        Dim R As Integer = Int(pixel1 And &HFF)
        Dim G As Integer = Int(pixel1 And &HFF00) >> 8
        Dim B As Integer = Int(pixel1 And &HFF0000) >> 16


        LabelHex.Text = "#" & Hex(R * 65536 + G * 256 + B)

        'RichTextBox1.Text = R.ToString + vbNewLine
        'RichTextBox1.Text = G.ToString + vbNewLine
        'RichTextBox1.Text = B.ToString + vbNewLine

        If R <= 200 And G >= 50 And B <= 200 Then
            'If R <= 250 And G >= 70 And B <= 250 Then
            'If G >= 70 Then
            'RichTextBox1.Text &= "Green"
            LabelWARNA.Text = "Green"
        Else
            LabelWARNA.Text = "Not Green"
        End If

    End Sub

    '=================================capture=======================================
    Public Sub ScreenCopy_PASS(ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) 'Optional file As String = "C:\FOCUS\Log Testing\" + TextBoxModel.Text + "\" + ComboBoxRWO_Id.Text + "\" + TextBoxModel.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBoxFCT.Text + ".jpeg")


        'If ResultTextBoxFCT.Text = "PASS" Then
        Dim File As String = "C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\" + ComboBoxModel.Text + "\PASS\" + ComboBoxModel.Text + "_" + TextBoxSN.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBoxFCT.Text + ".jpeg"
        'End If


        'Dim bounds As Rectangle
        'Dim screenshot As System.Drawing.Bitmap
        'Dim g As Graphics
        'bounds = Screen.PrimaryScreen.Bounds
        Dim delta_width, delta_height As Integer
        'Dim X1, Y1, X2, Y2 As Integer

        delta_width = X2 - X1
        delta_height = Y2 - Y1



        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Using bitmap As New Bitmap(delta_width, delta_height)

            Using g = Graphics.FromImage(bitmap)
                'g.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
                g.CopyFromScreen(X1, Y1, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy)
            End Using

            bitmap.Save(File, ImageFormat.Jpeg)
            'Process.Start(file) ' for test purposes
        End Using
    End Sub

    Public Sub ScreenCopy_FAIL(ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) 'Optional file As String = "C:\FOCUS\Log Testing\" + TextBoxModel.Text + "\" + ComboBoxRWO_Id.Text + "\" + TextBoxModel.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBoxFCT.Text + ".jpeg")


        'If ResultTextBoxFCT.Text = "PASS" Then
        Dim File As String = "C:\FOCUS\Log Testing\" + ComboBoxRWO_Id.Text + "\" + ComboBoxModel.Text + "\FAIL\" + ComboBoxModel.Text + "_" + TextBoxSN.Text + "_" + Format(Now, "ddMMyyyy") + "_" + TestingtimeStart.ToString("HHmmss") + "_" + ResultTextBoxFCT.Text + ".jpeg"
        'End If


        'Dim bounds As Rectangle
        'Dim screenshot As System.Drawing.Bitmap
        'Dim g As Graphics
        'bounds = Screen.PrimaryScreen.Bounds
        Dim delta_width, delta_height As Integer
        'Dim X1, Y1, X2, Y2 As Integer

        delta_width = X2 - X1
        delta_height = Y2 - Y1



        Dim shot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Using bitmap As New Bitmap(delta_width, delta_height)

            Using g = Graphics.FromImage(bitmap)
                'g.CopyFromScreen(New Point(0, 0), New Point(0, 0), shot)
                g.CopyFromScreen(X1, Y1, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy)
            End Using

            bitmap.Save(File, ImageFormat.Jpeg)
            'Process.Start(file) ' for test purposes
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'clear

        RichTextBox1.Clear()

        'Exit Sub
        'X1 = GetValueCapture(1, 0)
        'Y1 = GetValueCapture(1, 1)
        'X2 = GetValueCapture(1, 2)
        'Y2 = GetValueCapture(1, 3)

    End Sub


    Sub cek_model_328()
        'switch #1
        If get_color(s1_x, s1_y) = "Green" And result1 = "" Then
            RichTextBox1.Text = "Switch No1  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No1 | PASS |"
            result1 = "PASS"
        End If

        'switch #2
        If get_color(s2_x, s2_y) = "Green" And result2 = "" Then
            RichTextBox1.Text = "Switch No2  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No2 | PASS |"
            result2 = "PASS"
        End If

        'switch #3
        If get_color(s3_x, s3_y) = "Green" And result3 = "" Then
            RichTextBox1.Text = "Switch No3  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No3 | PASS |"
            result3 = "PASS"
        End If


        'switch #4
        If get_color(s4_x, s4_y) = "Green" And result4 = "" Then
            RichTextBox1.Text = "Switch No4  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No4 | PASS |"
            result4 = "PASS"
        End If


        'switch #5
        If get_color(s5_x, s5_y) = "Green" And result5 = "" Then
            RichTextBox1.Text = "Switch No5  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No5 | PASS |"
            result5 = "PASS"
        End If


        'switch #6
        If get_color(s6_x, s6_y) = "Green" And result6 = "" Then
            RichTextBox1.Text = "Switch No6  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No6 | PASS |"
            result6 = "PASS"
        End If


        'switch #7
        If get_color(s7_x, s7_y) = "Green" And result7 = "" Then
            RichTextBox1.Text = "Switch No7  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No7 | PASS |"
            result7 = "PASS"
        End If


        'switch #8
        If get_color(s8_x, s8_y) = "Green" And result8 = "" Then
            RichTextBox1.Text = "Switch No8  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No8 | PASS |"
            result8 = "PASS"
        End If


        'switch #9
        If get_color(s9_x, s9_y) = "Green" And result9 = "" Then
            RichTextBox1.Text = "Switch No9  | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No9 | PASS |"
            result9 = "PASS"
        End If


        'switch #10
        If get_color(s10_x, s10_y) = "Green" And result10 = "" Then
            RichTextBox1.Text = "Switch No10 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No10 | PASS |"
            result10 = "PASS"
        End If

        'switch #11
        If get_color(s11_x, s11_y) = "Green" And result11 = "" Then
            RichTextBox1.Text = "Switch No11 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No11 | PASS |"
            result11 = "PASS"
        End If


        'switch #12
        If get_color(s12_x, s12_y) = "Green" And result12 = "" Then
            RichTextBox1.Text = "Switch No12 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No12 | PASS |"
            result12 = "PASS"
        End If


        'switch #13
        If get_color(s13_x, s13_y) = "Green" And result13 = "" Then
            RichTextBox1.Text = "Switch No13 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No13 | PASS |"
            result13 = "PASS"
        End If

        'switch #14
        If get_color(s14_x, s14_y) = "Green" And result14 = "" Then
            RichTextBox1.Text = "Switch No14 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No14 | PASS |"
            result14 = "PASS"
        End If


        'switch #15
        If get_color(s15_x, s15_y) = "Green" And result15 = "" Then
            RichTextBox1.Text = "Switch No15 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No15 | PASS |"
            result15 = "PASS"
        End If

        'switch #16
        If get_color(s16_x, s16_y) = "Green" And result16 = "" Then
            RichTextBox1.Text = "Switch No16 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No16 | PASS |"
            result16 = "PASS"
        End If


        'switch #17
        If get_color(s17_x, s17_y) = "Green" And result17 = "" Then
            RichTextBox1.Text = "Switch No17 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No17 | PASS |"
            result17 = "PASS"
        End If


        'switch #18
        If get_color(s18_x, s18_y) = "Green" And result18 = "" Then
            RichTextBox1.Text = "Switch No18 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No18 | PASS |"
            result18 = "PASS"
        End If


        'switch #19
        If get_color(s19_x, s19_y) = "Green" And result19 = "" Then
            RichTextBox1.Text = "Switch No19 | PASS |" + vbNewLine + vbNewLine
            'LabelTesting.Text = "Switch No19 | PASS |"
            result19 = "PASS"
        End If

    End Sub

End Class
