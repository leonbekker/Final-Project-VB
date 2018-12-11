Public Class Form1
    Dim dir As Integer
    Dim xstep As Integer
    Dim ystep As Integer

    Private Sub tmr_pacman_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_pacman.Tick
        pacman.Left += xstep
        pacman.Top += ystep
        For Each x In Me.Controls
            If x.name.ToString.Contains("PictureBox") Then
                If pacman.Bounds.IntersectsWith(x.bounds) Then
                    If dir = 1 Then
                        pacman.Left -= 2
                    ElseIf dir = 2 Then
                        pacman.Left += 2
                    ElseIf dir = 3 Then
                        pacman.Top += 2
                    Else
                        pacman.Top -= 2
                    End If
                    dir = 0
                    xstep = 0
                    ystep = 0

                End If
            End If
        Next
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        tmr_pacman.Start()
        Select Case e.KeyCode
            Case Keys.Right
                dir = 1
                xstep = 2
                ystep = 0
                pacman.Image = My.Resources.PacmanRight
            Case Keys.Left
                dir = 2
                xstep = -2
                ystep = 0
                pacman.Image = My.Resources.PacmanLeft
            Case Keys.Up
                dir = 3
                xstep = 0
                ystep = -2
                pacman.Image = My.Resources.PacmanUp
            Case Keys.Down
                dir = 4
                xstep = 0
                ystep = 2
                pacman.Image = My.Resources.pacmanDown

        End Select
    End Sub
End Class
