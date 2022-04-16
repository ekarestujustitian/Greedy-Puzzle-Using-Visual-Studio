Module BranchingFactor

    Sub branching()


        Dim N As Long
        Dim Ngh As Double
        Dim mean As Integer = Form1.TextBox7.Text
        Dim b As Integer = Form1.TextBox4.Text
        Dim depth As Integer = Form1.TextBox2.Text


        'EBF
        If Form1.TextBox5.Text = "NA" Then
            N = 0
        Else
            N = Form1.TextBox5.Text
        End If


        If Form1.TextBox2.Text > 32 Then
            Form1.TextBox5.Text = "NA"
        Else
            N = N + b ^ depth
            Form1.TextBox5.Text = N
        End If

        'totalb
        mean = mean + b

        Form1.TextBox7.Text = mean


        'EBF h1
        Ngh = (1 + mean) / depth


        Form1.TextBox6.Text = Format(Ngh, "0.00")

    End Sub

End Module
