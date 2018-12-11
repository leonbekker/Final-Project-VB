Public Class Form2
    Private Sub rara_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_rara.Tick
        ra.Left -= 5
        For Each black_bloks In Me.Controls
            If black_bloks.name.ToString.Contains("black_blok") Then
                If ra.Bounds.IntersectsWith(black_bloks.bounds) Then
                    If ra.Bottom > black_bloks.top Then
                    End If
                End If
            End If
        Next
    End Sub
End Class