Public Class Form

    Dim count As Integer = 0
    Dim buttonArray(4, 5) As Button
    Dim cmbColorArray(5) As ComboBox

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click


        If cmbColor1.Text <> "Choose a Color" And cmbColor2.Text <> "Choose a Color" And cmbColor3.Text <> "Choose a Color" And cmbColor4.Text <> "Choose a Color" And cmbColor5.Text <> "Choose a Color" And cmbColor6.Text <> "Choose a Color" Or btnRandom.Visible = False Then

            cmbColor1.Text = "Choose a Color"
            cmbColor2.Text = "Choose a Color"
            cmbColor3.Text = "Choose a Color"
            cmbColor4.Text = "Choose a Color"
            cmbColor5.Text = "Choose a Color"
            cmbColor6.Text = "Choose a Color"

            count += 1

            If btnNext.Text = "New Game" Then
                Wipe()
                btnNext.Text = "Next"
            End If

            If count < 4 Then
                btnRandom.Visible = True
            End If

            If count = 3 Then
                btnNext.Text = "Solve"
            End If

            If count >= 4 Then
                btnNext.Visible = False

                ColorGraph()

                For x As Integer = 0 To 3
                    For y As Integer = 0 To 5

                        If y = 5 Then
                            Exit For
                        End If

                        If buttonArray(x, y).BackColor <> buttonArray(x, y + 1).BackColor Then

                            LineGraph(x, y, btnGraphBottomLeft, btnGraphBottomRight, lblBottomLine1, lblBottomLine2, lblBottomLine3, x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString)
                            LineGraph(x, y, btnGraphTopLeft, btnGraphTopRight, lblTopLine1, lblTopLine2, lblTopLine3, x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString + x.ToString)
                            LineGraph(x, y, btnGraphBottomLeft, btnGraphTopLeft, lblLeftLine1, lblLeftLine2, lblLeftLine3, x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine)
                            LineGraph(x, y, btnGraphBottomRight, btnGraphTopRight, lblRightLine1, lblRightLine2, lblRightLine3, x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine + x.ToString + vbNewLine)
                        End If

                        If y = 0 Or y = 2 Then
                            y += 1
                        End If

                    Next
                Next

                If win() = False Then
                    lblWin.Text = "No Solution"
                End If

                btnNext.Visible = True
                btnNext.Text = "New Game"

            End If


        Else
            MsgBox("Please Color All Boxes First")
        End If

        If count < 4 Then
            btnRandom.Visible = True
        End If

    End Sub

    Private Function Wipe()

        lblBottomLine1.Visible = False
        lblBottomLine2.Visible = False
        lblBottomLine3.Visible = False
        lblLeftLine1.Visible = False
        lblLeftLine2.Visible = False
        lblLeftLine3.Visible = False
        lblTopLine1.Visible = False
        lblTopLine2.Visible = False
        lblTopLine3.Visible = False
        lblRightLine1.Visible = False
        lblRightLine2.Visible = False
        lblRightLine3.Visible = False
        btnGraphBottomLeft.BackColor = Color.White
        btnGraphBottomRight.BackColor = Color.White
        btnGraphTopLeft.BackColor = Color.White
        btnGraphTopRight.BackColor = Color.White
        For x As Integer = 0 To 3
            For y As Integer = 0 To 5
                buttonArray(x, y).BackColor = Color.White
            Next
        Next
        count = 0
        lblWin.Text = ""
        btnRandom.Visible = False

        Return Nothing
    End Function

    Private Function win() As Boolean

        If lblBottomLine1.Visible = True And lblBottomLine2.Visible = True And lblLeftLine1.Visible = True And lblLeftLine2.Visible = True And lblTopLine1.Visible = True And lblTopLine2.Visible = True And lblRightLine1.Visible = True And lblRightLine2.Visible = True Then

            Dim cube1text(4) As String
            Dim answer(20) As Char

            answer(0) = lblBottomLine1.Text.Substring(0, 1)
            answer(1) = lblBottomLine2.Text.Substring(0, 1)
            answer(2) = lblLeftLine1.Text.Substring(0, 1)
            answer(3) = lblLeftLine2.Text.Substring(0, 1)
            answer(4) = lblTopLine1.Text.Substring(0, 1)
            answer(5) = lblTopLine2.Text.Substring(0, 1)
            answer(6) = lblRightLine1.Text.Substring(0, 1)
            answer(7) = lblRightLine2.Text.Substring(0, 1)

            If lblBottomLine3.Visible = True Or lblLeftLine3.Visible = True Or lblRightLine3.Visible Or lblTopLine3.Visible Then

                If lblBottomLine3.Visible = True Then
                    answer(8) = lblBottomLine3.Text.Substring(0, 1)
                End If
                If lblLeftLine3.Visible = True Then
                    answer(9) = lblLeftLine3.Text.Substring(0, 1)
                End If
                If lblRightLine3.Visible = True Then
                    answer(10) = lblRightLine3.Text.Substring(0, 1)
                End If
                If lblTopLine3.Visible = True Then
                    answer(11) = lblTopLine3.Text.Substring(0, 1)
                End If

            End If

            cube1text(0) = answer(0)
            If answer(0) <> answer(2) Or answer(0) <> answer(3) Then
                If answer(0) = answer(2) Then
                    cube1text(1) = answer(3)
                Else
                    cube1text(1) = answer(2)
                End If
            End If

            lblWin.Text = "Solution Found"
            Return True
        End If

        Return False
    End Function

    Private Function LineGraph(x As Integer, y As Integer, button1 As Button, button2 As Button, labelChange1 As Label, labelChange2 As Label, labelChange3 As Label, text As String)

        If buttonArray(x, y).BackColor = button1.BackColor Or buttonArray(x, y + 1).BackColor = button1.BackColor Then
            If labelChange1.Visible = False Then
                If buttonArray(x, y + 1).BackColor = button2.BackColor Or buttonArray(x, y).BackColor = button2.BackColor Then
                    labelChange1.Visible = True
                    labelChange1.Text = text
                End If
            ElseIf labelChange2.Visible = False And labelChange1.Text <> text Then
                If buttonArray(x, y + 1).BackColor = button2.BackColor Or buttonArray(x, y).BackColor = button2.BackColor Then
                    labelChange2.Visible = True
                    labelChange2.Text = text
                End If
            ElseIf labelChange3.Visible = False And labelChange1.Text <> text And labelChange2.Text <> text Then
                If buttonArray(x, y + 1).BackColor = button2.BackColor Or buttonArray(x, y).BackColor = button2.BackColor Then
                    labelChange3.Visible = True
                    labelChange3.Text = text
                End If
            End If
        End If

        Return Nothing
    End Function

    Private Function ColorGraph()

        For x As Integer = 0 To 3
            For y As Integer = 0 To 5
                If btnGraphBottomLeft.BackColor = Color.White Then
                    btnGraphBottomLeft.BackColor = buttonArray(x, y).BackColor
                End If
                If buttonArray(x, y).BackColor <> btnGraphBottomLeft.BackColor And btnGraphBottomRight.BackColor = Color.White Then
                    btnGraphBottomRight.BackColor = buttonArray(x, y).BackColor
                End If
                If buttonArray(x, y).BackColor <> btnGraphBottomLeft.BackColor And buttonArray(x, y).BackColor <> btnGraphBottomRight.BackColor And btnGraphTopLeft.BackColor = Color.White Then
                    btnGraphTopLeft.BackColor = buttonArray(x, y).BackColor
                End If
                If buttonArray(x, y).BackColor <> btnGraphBottomLeft.BackColor And buttonArray(x, y).BackColor <> btnGraphBottomRight.BackColor And buttonArray(x, y).BackColor <> btnGraphTopLeft.BackColor And btnGraphTopRight.BackColor = Color.White Then
                    btnGraphTopRight.BackColor = buttonArray(x, y).BackColor
                End If
            Next
        Next

        Return Nothing
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        buttonArray(0, 0) = btnBox1Top
        buttonArray(0, 1) = btnBox1Bottom
        buttonArray(0, 2) = btnBox1Front
        buttonArray(0, 3) = btnBox1Back
        buttonArray(0, 4) = btnBox1Right
        buttonArray(0, 5) = btnBox1Left

        buttonArray(1, 0) = btnBox2Top
        buttonArray(1, 1) = btnBox2Bottom
        buttonArray(1, 2) = btnBox2Front
        buttonArray(1, 3) = btnBox2Back
        buttonArray(1, 4) = btnBox2Right
        buttonArray(1, 5) = btnBox2Left

        buttonArray(2, 0) = btnBox3Top
        buttonArray(2, 1) = btnBox3Bottom
        buttonArray(2, 2) = btnBox3Front
        buttonArray(2, 3) = btnBox3Back
        buttonArray(2, 4) = btnBox3Right
        buttonArray(2, 5) = btnBox3Left

        buttonArray(3, 0) = btnBox4Top
        buttonArray(3, 1) = btnBox4Bottom
        buttonArray(3, 2) = btnBox4Front
        buttonArray(3, 3) = btnBox4Back
        buttonArray(3, 4) = btnBox4Right
        buttonArray(3, 5) = btnBox4Left

        cmbColorArray(0) = cmbColor1
        cmbColorArray(1) = cmbColor2
        cmbColorArray(2) = cmbColor3
        cmbColorArray(3) = cmbColor4
        cmbColorArray(4) = cmbColor5
        cmbColorArray(5) = cmbColor6
    End Sub

    Private Sub cmbColor1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor1.SelectedIndexChanged

        If cmbColor1.Text = "Green" Then
            buttonArray(count, 0).BackColor = Color.Green

        ElseIf cmbColor1.Text = "Red" Then
            buttonArray(count, 0).BackColor = Color.Red

        ElseIf cmbColor1.Text = "Yellow" Then
            buttonArray(count, 0).BackColor = Color.Yellow

        ElseIf cmbColor1.Text = "Blue" Then
            buttonArray(count, 0).BackColor = Color.Blue
        End If

    End Sub

    Private Sub cmbColor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor2.SelectedIndexChanged

        If cmbColor2.Text = "Green" Then
            buttonArray(count, 1).BackColor = Color.Green

        ElseIf cmbColor2.Text = "Red" Then
            buttonArray(count, 1).BackColor = Color.Red

        ElseIf cmbColor2.Text = "Yellow" Then
            buttonArray(count, 1).BackColor = Color.Yellow

        ElseIf cmbColor2.Text = "Blue" Then
            buttonArray(count, 1).BackColor = Color.Blue
        End If

    End Sub

    Private Sub cmbColor3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor3.SelectedIndexChanged

        If cmbColor3.Text = "Green" Then
            buttonArray(count, 2).BackColor = Color.Green

        ElseIf cmbColor3.Text = "Red" Then
            buttonArray(count, 2).BackColor = Color.Red

        ElseIf cmbColor3.Text = "Yellow" Then
            buttonArray(count, 2).BackColor = Color.Yellow

        ElseIf cmbColor3.Text = "Blue" Then
            buttonArray(count, 2).BackColor = Color.Blue
        End If
    End Sub

    Private Sub cmbColor4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor4.SelectedIndexChanged

        If cmbColor4.Text = "Green" Then
            buttonArray(count, 3).BackColor = Color.Green

        ElseIf cmbColor4.Text = "Red" Then
            buttonArray(count, 3).BackColor = Color.Red

        ElseIf cmbColor4.Text = "Yellow" Then
            buttonArray(count, 3).BackColor = Color.Yellow

        ElseIf cmbColor4.Text = "Blue" Then
            buttonArray(count, 3).BackColor = Color.Blue
        End If
    End Sub

    Private Sub cmbColor5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor5.SelectedIndexChanged

        If cmbColor5.Text = "Green" Then
            buttonArray(count, 4).BackColor = Color.Green

        ElseIf cmbColor5.Text = "Red" Then
            buttonArray(count, 4).BackColor = Color.Red

        ElseIf cmbColor5.Text = "Yellow" Then
            buttonArray(count, 4).BackColor = Color.Yellow

        ElseIf cmbColor5.Text = "Blue" Then
            buttonArray(count, 4).BackColor = Color.Blue
        End If
    End Sub

    Private Sub cmbColor6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor6.SelectedIndexChanged

        If cmbColor6.Text = "Green" Then
            buttonArray(count, 5).BackColor = Color.Green

        ElseIf cmbColor6.Text = "Red" Then
            buttonArray(count, 5).BackColor = Color.Red

        ElseIf cmbColor6.Text = "Yellow" Then
            buttonArray(count, 5).BackColor = Color.Yellow

        ElseIf cmbColor6.Text = "Blue" Then
            buttonArray(count, 5).BackColor = Color.Blue
        End If
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        RandomColor()
        btnRandom.Visible = False
    End Sub

    Private Function RandomColor()

        Dim random As Random = New Random

        For num As Integer = 0 To 5
            Dim randomNumber As Integer = random.Next(0, 4)

            If randomNumber = 0 Then
                buttonArray(count, num).BackColor = Color.Red

            ElseIf randomNumber = 1 Then
                buttonArray(count, num).BackColor = Color.Green

            ElseIf randomNumber = 2 Then
                buttonArray(count, num).BackColor = Color.Yellow

            ElseIf randomNumber = 3 Then
                buttonArray(count, num).BackColor = Color.Blue
            End If

        Next

        Return Nothing
    End Function

End Class
