Module SolveState

    Sub SolveCheck()

        If Form1.h1TextBox.Text > 0 Then
            SolveClick()
            SolveCheck()

        Else

            Form1.Label23.Text = Form1.StepTextBox.Text + "    ="
            MessageBox.Show("Good job. You're a WINNER!")

        End If

    End Sub

    Sub SolveClick()

        Form1.Button1.PerformClick()
        Form1.Button2.PerformClick()
        Form1.Button3.PerformClick()
        Form1.Button4.PerformClick()
        Form1.Button5.PerformClick()
        Form1.Button6.PerformClick()
        Form1.Button7.PerformClick()
        Form1.Button8.PerformClick()
        Form1.Button9.PerformClick()
        Form1.Button10.PerformClick()
        Form1.Button11.PerformClick()
        Form1.Button12.PerformClick()
        Form1.Button13.PerformClick()
        Form1.Button14.PerformClick()
        Form1.Button15.PerformClick()
        Form1.Button16.PerformClick()
        Form1.Button17.PerformClick()
        Form1.Button18.PerformClick()
        Form1.Button19.PerformClick()
        Form1.Button20.PerformClick()
        Form1.Button21.PerformClick()
        Form1.Button22.PerformClick()
        Form1.Button23.PerformClick()
        Form1.Button24.PerformClick()
        Form1.Button25.PerformClick()

    End Sub

End Module
