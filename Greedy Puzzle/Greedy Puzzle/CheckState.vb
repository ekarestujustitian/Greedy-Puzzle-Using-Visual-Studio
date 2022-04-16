Module CheckState

    Sub checkload()
        Dim h1count As Integer = 0
        Dim h4count As Integer = 0

        h1count = 0
        '-------------------   h1   -------------------'
        If (Form1.Button1.Text = "1") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button2.Text = "2") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button3.Text = "3") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button4.Text = "4") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button5.Text = "5") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button6.Text = "6") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button7.Text = "7") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button8.Text = "8") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button9.Text = "9") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button10.Text = "10") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button11.Text = "11") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button12.Text = "12") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button13.Text = "13") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button14.Text = "14") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button15.Text = "15") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button16.Text = "16") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button17.Text = "17") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button18.Text = "18") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button19.Text = "19") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button20.Text = "20") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button21.Text = "21") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button22.Text = "22") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button23.Text = "23") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button24.Text = "24") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 1
        End If
        If (Form1.Button25.Text = "") Then
            h1count = h1count + 0
        Else
            h1count = h1count + 0
        End If

        '-------------------   h4   -------------------'

        h4count = 0

        If (Form1.Button1.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button1.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button2.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button2.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button3.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button3.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button4.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button4.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button5.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button5.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button6.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button6.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button7.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button7.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button8.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button8.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button9.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button9.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button10.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button10.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button11.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button11.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button12.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button12.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button13.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button13.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button14.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button14.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button15.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button15.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button16.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button16.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button17.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button17.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button18.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button18.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button19.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button19.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button20.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button20.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button21.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button21.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button22.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button22.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button23.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button23.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button24.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button24.Text Mod 2 = 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If

        If (Form1.Button25.Text = "") Then
            h4count = h4count + 0
        ElseIf (Form1.Button25.Text Mod 2 <> 0) Then
            h4count = h4count + 0
        Else
            h4count = h4count + 1
        End If


        Form1.h1TextBox.Text = h1count
        Form1.h4TextBox.Text = h4count
    End Sub
End Module
