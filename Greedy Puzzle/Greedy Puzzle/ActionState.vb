Module ActionState
    Dim puzzlestep As Integer = 0
    Sub cblev1(ByRef button1 As Button, ByRef button2 As Button)


        If button2.Text = "" Then
            button2.Text = button1.Text
            button1.Text = ""
            puzzlestep = puzzlestep + 1
            Form1.TextBox2.Text = puzzlestep
            branch()
            branching()

        End If
    End Sub

    Sub resetstep()
        puzzlestep = 0
        Form1.TextBox2.Text = puzzlestep
    End Sub

    Sub resetbranch()
        Form1.TextBox4.Text = 0
        Form1.TextBox5.Text = 0
        Form1.TextBox6.Text = 0
        Form1.TextBox7.Text = 0
    End Sub

End Module
