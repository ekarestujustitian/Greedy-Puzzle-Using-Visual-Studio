Module PuzzleState
    Dim puzzlestep As Integer = 0
    Sub cblev1(ByRef button1 As Button, ByRef button2 As Button)

        Dim h1, h4 As Integer
        h1 = Form1.h1TextBox.Text
        h4 = Form1.h4TextBox.Text

        If button2.Text = "" Then
            button2.Text = button1.Text
            button1.Text = ""
            checkload()
            If Form1.h1TextBox.Text < h1 And Form1.h4TextBox.Text < h4 Then
                puzzlestep = puzzlestep + 1
                Form1.StepTextBox.Text = puzzlestep
                branch()
                branching()
            Else
                button1.Text = button2.Text
                button2.Text = ""
            End If
        End If

        If Form1.StepTextBox.Text = 2 Then
            Form1.d2TextBox.Text = Form1.EBFh1TextBox.Text
        ElseIf Form1.StepTextBox.Text = 4 Then
            Form1.d4TextBox.Text = Form1.EBFh1TextBox.Text
        ElseIf Form1.StepTextBox.Text = 8 Then
            Form1.d8TextBox.Text = Form1.EBFh1TextBox.Text
        ElseIf Form1.StepTextBox.Text = 16 Then
            Form1.d16TextBox.Text = Form1.EBFh1TextBox.Text
        Else
            Form1.doutputTextBox.Text = Form1.EBFh1TextBox.Text

        End If

    End Sub

    Sub resetstep()
        puzzlestep = 0
        Form1.StepTextBox.Text = puzzlestep
    End Sub

    Sub resetbranch()
        Form1.b_TextBox.Text = 0
        Form1.EBFh1TextBox.Text = 0
    End Sub

End Module
