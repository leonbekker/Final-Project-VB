Public Class Form1
    Dim dir As Integer
    Dim xstep As Integer
    Dim ystep As Integer
    Dim score As Integer = 0
    Dim life As Integer
    Dim ghost_dir As Integer = 1 '0=stop, 1=left, 2=up, 3=down, 4=right

    Private Sub tmr_pacman_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_pacman.Tick
        acman.Left += xstep
        acman.Top += ystep
        For Each x In Me.Controls
            If x.name.ToString.Contains("PictureBox") Then
                If acman.Bounds.IntersectsWith(x.bounds) Then
                    If dir = 1 Then
                        acman.Left -= 2
                    ElseIf dir = 2 Then
                        acman.Left += 2
                    ElseIf dir = 3 Then
                        acman.Top += 2
                    Else
                        acman.Top -= 2
                    End If
                    dir = 0
                    xstep = 0
                    ystep = 0

                End If
            ElseIf x.name.ToString.Contains("p") Then
                If acman.Bounds.IntersectsWith(x.bounds) And x.visible Then
                    score += 1
                    lbl_score.Text = "Score: " & score
                    x.hide()
                End If
            End If
        Next
        If acman.Left <= ghost.Left Then
            'ghost.left -= 1
            ghost_dir = 1
        ElseIf acman.Left > ghost.Left Then
            'ghost.Left += 1
            ghost_dir = 4
        End If
        If acman.Top <= ghost.Top Then
            'ghost.Top -= 1
            ghost_dir = 2
        ElseIf acman.Top > ghost.Top Then
            ' ghost.Top += 1
            ghost_dir = 3
        End If
        For Each x In Me.Controls
            If x.name.ToString.Contains("PictureBox") Then
                If ghost.Bounds.IntersectsWith(x.bounds) Then
                    If ghost_dir = 1 Then 'left
                        ghost.Left += 2
                        If acman.Top <= ghost.Top Then 'acman above ghost
                            ghost_dir = 2 'up
                        ElseIf acman.Top > ghost.Top Then 'acman below ghost
                            ghost_dir = 3 'down
                        End If
                    ElseIf ghost_dir = 2 Then 'up
                        ghost.Top += 2
                        If acman.Left < ghost.Left Then
                            'ghost.left -= 1
                            ghost_dir = 1
                        ElseIf acman.Left > ghost.Left Then
                            'ghost.Left += 1
                            ghost_dir = 4
                        End If
                    ElseIf ghost_dir = 3 Then 'down
                        ghost.Top -= 2
                        If acman.Left < ghost.Left Then
                            'ghost.left -= 1
                            ghost_dir = 1
                        Else
                            ghost_dir = 4
                        End If

                    Else : ghost_dir = 4  'right
                        ghost.Left -= 2
                        If acman.Top <= ghost.Top Then ' pac above
                            ghost_dir = 2 'up
                        Else 'pac below ghost
                            ghost_dir = 3 'down
                        End If
                    End If
                End If
            End If



        Next
        Select Case ghost_dir
            Case 1
                ghost.Left -= 1
            Case 2
                ghost.Top -= 1
            Case 3
                ghost.Top += 1
            Case 4
                ghost.Left += 1

        End Select
        'If acman.Bounds.IntersectsWith(ghost.Bounds) Then
        'hear2.
        ' End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        tmr_pacman.Start()
        Select Case e.KeyCode
            Case Keys.Right
                dir = 1
                xstep = 2.5
                ystep = 0
                acman.Image = My.Resources.PacmanRight
            Case Keys.Left
                dir = 2
                xstep = -2.5
                ystep = 0
                acman.Image = My.Resources.PacmanLeft
            Case Keys.Up
                dir = 3
                xstep = 0
                ystep = -2.5
                acman.Image = My.Resources.PacmanUp
            Case Keys.Down
                dir = 4
                xstep = 0
                ystep = 2.5
                acman.Image = My.Resources.pacmanDown

        End Select

    End Sub

    Private Sub acman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acman.Click

    End Sub
End Class
