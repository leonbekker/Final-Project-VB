Public Class Form1
    Dim xspeed As Double = 3
    Dim yspeed As Double = -8
    Dim gravity As Double = 0.1
    Dim score As Integer = 0
    Dim ball_location As Point
    Private Sub tmr_ball_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_ball.Tick
        ball_location = ball.Location
        ball_location.X += xspeed
        ball_location.Y += yspeed
        ball.Location = ball_location
        yspeed += gravity
        If ball.Bounds.IntersectsWith(ground.Bounds) Then
            My.Computer.Audio.Play(My.Resources.fail, AudioPlayMode.Background)
            tmr_ball.Stop()
            ball.Left = 194
            ball.Top = 283
            If h1.Visible Then
                h1.Hide()
            ElseIf h2.Visible Then
                h2.Hide()
            Else : h3.Hide()
                MsgBox("Game Over", MsgBoxStyle.Exclamation)
                score = 0
                lbl_score.Text = "Score:" & score
                h1.Show()
                h2.Show()
                h3.Show()
            End If
        End If
        If ball.Right >= Me.Width Or ball.Left <= 0 Then
            xspeed *= -1
        End If

        If ball.Bottom <= 0 Then
            arrow.Show()
            arrow.Left = ball.Left
        Else
            arrow.Hide()
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case Keys.Space
                If tmr_ball.Enabled Then
                    tmr_ball.Start()
                End If
                If ball.Bounds.IntersectsWith(clown.Bounds) Then
                    yspeed *= -1
                    score += 1
                    lbl_score.Text = "Score:" & score
                End If

            Case Keys.Right
                If clown.Left > 756 Then
                    clown.Left = 756
                Else
                    clown.Left += 5
                End If
                clown.Left += 5

            Case Keys.Left
                If clown.Left < 0 Then
                    clown.Left = 0
                Else
                    clown.Left -= 5
                End If
                clown.Left -= 5
        End Select

    End Sub

    Private Sub arrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrow.Click

    End Sub
End Class
