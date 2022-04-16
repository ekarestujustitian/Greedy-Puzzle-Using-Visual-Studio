Module EffectiveBranchingFactor

    Sub branching()

        Dim Nh1 As Long
        Dim Nh4 As Long
        Dim b As Integer = Form1.b_TextBox.Text
        Dim depth As Integer = Form1.StepTextBox.Text


        'EBF Limit

        'Limit h1
        If Form1.EBFh1TextBox.Text = "NA" Then
            Nh1 = 0
        Else
            Nh1 = Form1.EBFh1TextBox.Text
        End If

        'Limit h4
        If Form1.EBFh4TextBox.Text = "NA" Then
            Nh4 = 0
        Else
            Nh4 = Form1.EBFh4TextBox.Text
        End If


        'EBF Algorithm

        'EBF Algorithm h1
        If Form1.StepTextBox.Text > 32 Then
            Form1.EBFh1TextBox.Text = "NA"
        Else
            Nh1 = Nh1 + b ^ depth
            Form1.EBFh1TextBox.Text = Nh1
        End If

        'EBF Algorithm h4
        If Form1.StepTextBox.Text > 32 Then
            Form1.EBFh4TextBox.Text = "NA"
        Else
            Nh4 = Nh4 + b ^ depth
            Form1.EBFh4TextBox.Text = Nh4
        End If

    End Sub

End Module
