<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lbl_score = New System.Windows.Forms.Label
        Me.tmr_ball = New System.Windows.Forms.Timer(Me.components)
        Me.arrow = New System.Windows.Forms.PictureBox
        Me.h1 = New System.Windows.Forms.PictureBox
        Me.h3 = New System.Windows.Forms.PictureBox
        Me.h2 = New System.Windows.Forms.PictureBox
        Me.ground = New System.Windows.Forms.PictureBox
        Me.clown = New System.Windows.Forms.PictureBox
        Me.ball = New System.Windows.Forms.PictureBox
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.h1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.h3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.h2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_score
        '
        Me.lbl_score.AutoSize = True
        Me.lbl_score.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_score.Location = New System.Drawing.Point(28, 28)
        Me.lbl_score.Name = "lbl_score"
        Me.lbl_score.Size = New System.Drawing.Size(86, 28)
        Me.lbl_score.TabIndex = 6
        Me.lbl_score.Text = "Score: 0"
        '
        'tmr_ball
        '
        Me.tmr_ball.Enabled = True
        Me.tmr_ball.Interval = 30
        '
        'arrow
        '
        Me.arrow.Image = Global.Clown_Gravity.My.Resources.Resources.Green_Up_Arrow_svg
        Me.arrow.Location = New System.Drawing.Point(347, 53)
        Me.arrow.Name = "arrow"
        Me.arrow.Size = New System.Drawing.Size(28, 35)
        Me.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.arrow.TabIndex = 7
        Me.arrow.TabStop = False
        Me.arrow.Visible = False
        '
        'h1
        '
        Me.h1.Image = Global.Clown_Gravity.My.Resources.Resources.heart
        Me.h1.Location = New System.Drawing.Point(633, 28)
        Me.h1.Name = "h1"
        Me.h1.Size = New System.Drawing.Size(66, 49)
        Me.h1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.h1.TabIndex = 5
        Me.h1.TabStop = False
        '
        'h3
        '
        Me.h3.Image = Global.Clown_Gravity.My.Resources.Resources.heart
        Me.h3.Location = New System.Drawing.Point(777, 28)
        Me.h3.Name = "h3"
        Me.h3.Size = New System.Drawing.Size(66, 49)
        Me.h3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.h3.TabIndex = 4
        Me.h3.TabStop = False
        '
        'h2
        '
        Me.h2.Image = Global.Clown_Gravity.My.Resources.Resources.heart
        Me.h2.Location = New System.Drawing.Point(705, 28)
        Me.h2.Name = "h2"
        Me.h2.Size = New System.Drawing.Size(66, 49)
        Me.h2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.h2.TabIndex = 3
        Me.h2.TabStop = False
        '
        'ground
        '
        Me.ground.BackColor = System.Drawing.Color.Brown
        Me.ground.Location = New System.Drawing.Point(-5, 540)
        Me.ground.Name = "ground"
        Me.ground.Size = New System.Drawing.Size(882, 18)
        Me.ground.TabIndex = 2
        Me.ground.TabStop = False
        '
        'clown
        '
        Me.clown.Image = Global.Clown_Gravity.My.Resources.Resources.colourful_happy_clown_kids_sticker_157
        Me.clown.Location = New System.Drawing.Point(372, 401)
        Me.clown.Name = "clown"
        Me.clown.Size = New System.Drawing.Size(110, 138)
        Me.clown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clown.TabIndex = 1
        Me.clown.TabStop = False
        '
        'ball
        '
        Me.ball.Image = Global.Clown_Gravity.My.Resources.Resources.ball1
        Me.ball.Location = New System.Drawing.Point(194, 283)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(20, 21)
        Me.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ball.TabIndex = 0
        Me.ball.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(871, 558)
        Me.Controls.Add(Me.arrow)
        Me.Controls.Add(Me.lbl_score)
        Me.Controls.Add(Me.h1)
        Me.Controls.Add(Me.h3)
        Me.Controls.Add(Me.h2)
        Me.Controls.Add(Me.ground)
        Me.Controls.Add(Me.clown)
        Me.Controls.Add(Me.ball)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.arrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.h1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.h3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.h2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ball As System.Windows.Forms.PictureBox
    Friend WithEvents clown As System.Windows.Forms.PictureBox
    Friend WithEvents ground As System.Windows.Forms.PictureBox
    Friend WithEvents h2 As System.Windows.Forms.PictureBox
    Friend WithEvents h3 As System.Windows.Forms.PictureBox
    Friend WithEvents h1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_score As System.Windows.Forms.Label
    Friend WithEvents tmr_ball As System.Windows.Forms.Timer
    Friend WithEvents arrow As System.Windows.Forms.PictureBox

End Class
