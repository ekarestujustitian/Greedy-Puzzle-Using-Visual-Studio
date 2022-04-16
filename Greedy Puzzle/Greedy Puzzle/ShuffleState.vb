Module ShuffleState
    Sub shuffle()
        Dim rnd As New Random
        Dim x As Integer
        x = rnd.Next(1, 4)

        If x = 1 Then
            Form1.Button1.Text = ""
            Form1.Button2.Text = 1
            Form1.Button3.Text = 2
            Form1.Button4.Text = 4
            Form1.Button5.Text = 5
            Form1.Button6.Text = 6
            Form1.Button7.Text = 7
            Form1.Button8.Text = 3
            Form1.Button9.Text = 8
            Form1.Button10.Text = 9
            Form1.Button11.Text = 12
            Form1.Button12.Text = 13
            Form1.Button13.Text = 18
            Form1.Button14.Text = 15
            Form1.Button15.Text = 10
            Form1.Button16.Text = 11
            Form1.Button17.Text = 16
            Form1.Button18.Text = 19
            Form1.Button19.Text = 14
            Form1.Button20.Text = 20
            Form1.Button21.Text = 21
            Form1.Button22.Text = 17
            Form1.Button23.Text = 22
            Form1.Button24.Text = 23
            Form1.Button25.Text = 24

        ElseIf x = 2 Then
            Form1.Button1.Text = 1
            Form1.Button2.Text = 3
            Form1.Button3.Text = 8
            Form1.Button4.Text = 5
            Form1.Button5.Text = ""
            Form1.Button6.Text = 7
            Form1.Button7.Text = 2
            Form1.Button8.Text = 9
            Form1.Button9.Text = 4
            Form1.Button10.Text = 10
            Form1.Button11.Text = 6
            Form1.Button12.Text = 11
            Form1.Button13.Text = 18
            Form1.Button14.Text = 13
            Form1.Button15.Text = 14
            Form1.Button16.Text = 16
            Form1.Button17.Text = 12
            Form1.Button18.Text = 23
            Form1.Button19.Text = 20
            Form1.Button20.Text = 15
            Form1.Button21.Text = 21
            Form1.Button22.Text = 17
            Form1.Button23.Text = 22
            Form1.Button24.Text = 19
            Form1.Button25.Text = 24

        Else
            Form1.Button1.Text = 1
            Form1.Button2.Text = 2
            Form1.Button3.Text = ""
            Form1.Button4.Text = 3
            Form1.Button5.Text = 4
            Form1.Button6.Text = 7
            Form1.Button7.Text = 12
            Form1.Button8.Text = 9
            Form1.Button9.Text = 14
            Form1.Button10.Text = 5
            Form1.Button11.Text = 6
            Form1.Button12.Text = 13
            Form1.Button13.Text = 8
            Form1.Button14.Text = 15
            Form1.Button15.Text = 10
            Form1.Button16.Text = 11
            Form1.Button17.Text = 16
            Form1.Button18.Text = 23
            Form1.Button19.Text = 18
            Form1.Button20.Text = 20
            Form1.Button21.Text = 21
            Form1.Button22.Text = 17
            Form1.Button23.Text = 22
            Form1.Button24.Text = 19
            Form1.Button25.Text = 24
        End If

    End Sub
End Module
