Public Class Form1

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        shuffle()
        resetstep()
        resetbranch()
        checkload()
        EBFh1TextBox.Text = 1
        EBFh4TextBox.Text = 1

    End Sub

    Private Sub SolveButton_Click(sender As Object, e As EventArgs) Handles SolveButton.Click

        SolveCheck()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '26

        cblev1(Button1, Button2)
        cblev1(Button1, Button6)
        checkload()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '1 3 7

        cblev1(Button2, Button1)
        cblev1(Button2, Button3)
        cblev1(Button2, Button7)
        checkload()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '2 4 8

        cblev1(Button3, Button2)
        cblev1(Button3, Button4)
        cblev1(Button3, Button8)
        checkload()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '3 5 9

        cblev1(Button4, Button3)
        cblev1(Button4, Button5)
        cblev1(Button4, Button9)
        checkload()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '4 10

        cblev1(Button5, Button4)
        cblev1(Button5, Button10)
        checkload()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '1 7 11

        cblev1(Button6, Button1)
        cblev1(Button6, Button7)
        cblev1(Button6, Button11)
        checkload()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '2 6 8 12

        cblev1(Button7, Button2)
        cblev1(Button7, Button6)
        cblev1(Button7, Button8)
        cblev1(Button7, Button12)
        checkload()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '3 7 9 13

        cblev1(Button8, Button3)
        cblev1(Button8, Button7)
        cblev1(Button8, Button9)
        cblev1(Button8, Button13)
        checkload()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '4 8 10 14

        cblev1(Button9, Button4)
        cblev1(Button9, Button8)
        cblev1(Button9, Button10)
        cblev1(Button9, Button14)
        checkload()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        '5 9 15

        cblev1(Button10, Button5)
        cblev1(Button10, Button9)
        cblev1(Button10, Button15)
        checkload()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        '6 12 16

        cblev1(Button11, Button6)
        cblev1(Button11, Button12)
        cblev1(Button11, Button16)
        checkload()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        '7 11 13 17

        cblev1(Button12, Button7)
        cblev1(Button12, Button11)
        cblev1(Button12, Button13)
        cblev1(Button12, Button17)
        checkload()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        '8 12 14 18

        cblev1(Button13, Button8)
        cblev1(Button13, Button12)
        cblev1(Button13, Button14)
        cblev1(Button13, Button18)
        checkload()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        '9 13 15 19

        cblev1(Button14, Button9)
        cblev1(Button14, Button13)
        cblev1(Button14, Button15)
        cblev1(Button14, Button19)
        checkload()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        '10 14 20

        cblev1(Button15, Button10)
        cblev1(Button15, Button14)
        cblev1(Button15, Button20)
        checkload()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        '11 17 21

        cblev1(Button16, Button11)
        cblev1(Button16, Button17)
        cblev1(Button16, Button21)
        checkload()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        '12 16 18 22

        cblev1(Button17, Button12)
        cblev1(Button17, Button16)
        cblev1(Button17, Button18)
        cblev1(Button17, Button22)
        checkload()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click, Button27.Click
        '13 17 19 23

        cblev1(Button18, Button13)
        cblev1(Button18, Button17)
        cblev1(Button18, Button19)
        cblev1(Button18, Button23)
        checkload()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        '14 18 20 24

        cblev1(Button19, Button14)
        cblev1(Button19, Button18)
        cblev1(Button19, Button20)
        cblev1(Button19, Button24)
        checkload()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        '15 19 25

        cblev1(Button20, Button15)
        cblev1(Button20, Button19)
        cblev1(Button20, Button25)
        checkload()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        '16 22

        cblev1(Button21, Button16)
        cblev1(Button21, Button22)
        checkload()

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        '17 21 23

        cblev1(Button22, Button17)
        cblev1(Button22, Button21)
        cblev1(Button22, Button23)
        checkload()

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        '18 22 24

        cblev1(Button23, Button18)
        cblev1(Button23, Button22)
        cblev1(Button23, Button24)
        checkload()

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        '19 23 25

        cblev1(Button24, Button19)
        cblev1(Button24, Button23)
        cblev1(Button24, Button25)
        checkload()


    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        '20 24

        cblev1(Button25, Button20)
        cblev1(Button25, Button24)
        checkload()

    End Sub


End Class
