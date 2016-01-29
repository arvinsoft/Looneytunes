Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'x = Int(Rnd() * (My.Computer.Screen.Bounds.Width - Me.Width))
        'y = Int(Rnd() * (My.Computer.Screen.Bounds.Height - Me.Height))
        Label1.Text = "button 1 : " & Button1.Location.X & " : " & Button1.Location.Y & " Size : " & Button1.Width & " : " & Button1.Height & " bb : " & Button1.Location.X - Button2.Height + 25 & " : " & (Button1.Location.Y - Button2.Width)
        Label2.Text = "button 2 : " & Button2.Location.X & " : " & Button2.Location.Y & " Size : " & Button2.Width & " : " & Button2.Height & " BB : " & Button2.Location.X + 25 & " : " & Button2.Location.Y + 25 & vbNewLine & Button1.Location.Y & " = " & Me.Height & " : " & Button1.Location.X & " = " & Me.Width
        'If (My.Computer.Screen.Bounds.Width) - Button1.Location.X = (My.Computer.Screen.Bounds.Width) - Button2.Height And (My.Computer.Screen.Bounds.Height) - 30 - Button1.Location.Y = (My.Computer.Screen.Bounds.Height) - Button2.Location.Y Then
        ' If (Button1.Location.X - Button2.Height) = Button2.Location.X + 25 Or (Button1.Location.Y - Button2.Width) = Button2.Location.Y Or Button1.Location.X = Button2.Location.X Or Button1.Location.Y - Button2.Height = Button2.Location.Y Or (Button3.Location.X - Button2.Height) = Button2.Location.X + 25 Or (Button3.Location.Y - Button2.Width) = Button2.Location.Y Or Button3.Location.X = Button2.Location.X Or Button3.Location.Y - Button2.Height = Button2.Location.Y Then
        'java equivalent
        '    Public Class Player
        '{
        '    int X;
        '    int Y;
        '    int Width;
        '    int Height;

        '    // Getters And Setters
        '}

        'Public Class Enemy
        '{
        '    int X;
        '    int Y;
        '    int Width;
        '    int Height;

        '    // Getters And Setters
        '}
        '        foreach(Enemy e In EnemyCollection)
        '{
        '    Rectangle r = New Rectangle(e.X, e.Y, e.Width, e.Height);
        '    Rectangle p = New Rectangle(player.X, player.Y, player.Width, player.Height);

        '    // Assuming there Is an intersect method, otherwise just handcompare the values
        '    If (r.Intersects(p)) Then
        '                {
        '       // A Collision!
        '       // we know which enemy (e), so we can call e.DoCollision();
        '       e.DoCollision();
        '    }
        '}
        If Button1.Bounds.IntersectsWith(Button2.Bounds) Or Button3.Bounds.IntersectsWith(Button2.Bounds) Or Button4.Bounds.IntersectsWith(Button2.Bounds) Or Button5.Bounds.IntersectsWith(Button2.Bounds) Then
            Timer1.Enabled = False
            If My.Settings.high < Label10.Text Then
                My.Settings.high = Label10.Text
                My.Settings.Save()
                ' MsgBox(My.Settings.high & " : " & Label10.Text)
            End If
            MsgBox("Game Over try next time and your score is " & Label10.Text & " Seconds" & vbNewLine & "High Score : " & My.Settings.high & " Seconds " & vbNewLine & "Carrots Collected : " & Label11.Text, MsgBoxStyle.Critical + vbOKOnly, "Sorry")

            Panel1.Enabled = False
            PauseToolStripMenuItem.Enabled = False
            PlayToolStripMenuItem.Enabled = False
            Timer1.Enabled = False
                Timer2.Enabled = False


                Timer6.Enabled = False


            Label3.Text = "hit"
        Else
            If Button1.Location.Y > Me.Height Or Button1.Location.X > Me.Width Then
                Timer1.Enabled = False
                Timer2.Enabled = True

            Else
                Button1.Location = New Point(Button1.Location.X - 5, Button1.Location.Y + 10)
                Button3.Location = New Point(Button3.Location.X + 20, Button3.Location.Y + 5)
                Button4.Location = New Point(Button4.Location.X - 15, Button4.Location.Y - 15)
                Button5.Location = New Point(Button5.Location.X + 20, Button5.Location.Y - 5)

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub
    Dim startx As Integer
    Dim starty As Integer
    Dim endy As Integer
    Dim endx As Integer
    Dim finalx As Integer
    Dim finaly As Integer
    Dim mdown As Boolean
    Dim valx As Boolean
    Dim valy As Boolean
    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        If Button2.Location.X > Panel1.Width - 50 Or Button2.Location.Y > Panel1.Height - 10 Or Button2.Location.X <= 0 Or Button2.Location.Y <= 0 Then
            'MsgBox("game over")
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
            If My.Settings.high < Label10.Text Then
                My.Settings.high = Label10.Text
                My.Settings.Save()
                'MsgBox(My.Settings.high & " : " & Label10.Text)
            End If
            MsgBox("Game Over try next time and your score is " & Label10.Text & " Seconds" & vbNewLine & "High Score : " & My.Settings.high & " Seconds " & vbNewLine & "Carrots Collected : " & Label11.Text, MsgBoxStyle.Critical + vbOKOnly, "Sorry")

            Panel1.Enabled = False
            PauseToolStripMenuItem.Enabled = False
            PlayToolStripMenuItem.Enabled = False
            Timer1.Enabled = False
                Timer2.Enabled = False

            Timer6.Enabled = False


        Else
            If PictureBox1.Visible = True And PictureBox1.Bounds.IntersectsWith(Button2.Bounds) Then
                Timer5.Enabled = True
                PictureBox1.Visible = False
                If Timer1.Enabled = True Then
                    tim1.Text = 1
                    tim2.Text = 0
                Else
                    tim1.Text = 0
                    tim2.Text = 0
                End If
                My.Computer.Audio.Play(Application.StartupPath & "/button-4.wav")
            End If
            If PictureBox2.Visible = True And PictureBox2.Bounds.IntersectsWith(Button2.Bounds) Then
                Timer8.Enabled = True
                My.Computer.Audio.Play(Application.StartupPath & "/button-3.wav")
            End If
            If mdown = True Then
                endx = (MousePosition.X - Me.Left)
                endy = (MousePosition.Y - Me.Top)

                If valy = False Then
                    starty = endy - sender.top
                    valy = True
                End If
                If valx = False Then
                    startx = endx - sender.left
                    valx = True
                End If
                sender.left = endx - startx
                sender.top = endy - starty
            End If
        End If

    End Sub

    Private Sub Button2_MouseDown(sender As Object, e As MouseEventArgs) Handles Button2.MouseDown
        startx = MousePosition.X
        starty = MousePosition.Y
        mdown = True
        valx = False
        valy = False
    End Sub

    Private Sub Button2_MouseUp(sender As Object, e As MouseEventArgs) Handles Button2.MouseUp
        mdown = False
        valx = False
        valy = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label1.Text = "button 1 : " & Button1.Location.X & " : " & Button1.Location.Y & " Size : " & Button1.Width & " : " & Button1.Height & " bb : " & Button1.Location.X - Button2.Height + 25 & " : " & (Button1.Location.Y - Button2.Width)
        Label2.Text = "button 2 : " & Button2.Location.X & " : " & Button2.Location.Y & " Size : " & Button2.Width & " : " & Button2.Height & " BB : " & Button2.Location.X + 25 & " : " & Button2.Location.Y + 25 & vbNewLine & Button1.Location.Y & " = " & Me.Height & " : " & Button1.Location.X & " = " & Me.Width
        If Button1.Bounds.IntersectsWith(Button2.Bounds) Or Button3.Bounds.IntersectsWith(Button2.Bounds) Or Button4.Bounds.IntersectsWith(Button2.Bounds) Or Button5.Bounds.IntersectsWith(Button2.Bounds) Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            If My.Settings.high < Label10.Text Then
                My.Settings.high = Label10.Text
                My.Settings.Save()
                ' MsgBox(My.Settings.high & " : " & Label10.Text)
            End If
            MsgBox("Game Over try next time and your score is " & Label10.Text & " Seconds" & vbNewLine & "High Score : " & My.Settings.high & " Seconds " & vbNewLine & "Carrots Collected : " & Label11.Text, MsgBoxStyle.Critical + vbOKOnly, "Sorry")

            Panel1.Enabled = False
            PauseToolStripMenuItem.Enabled = False
            PlayToolStripMenuItem.Enabled = False
            Timer1.Enabled = False
                Timer2.Enabled = False


            Timer6.Enabled = False



            Label3.Text = "hit"
        End If
        If Button1.Location.Y <= 0 Or Button1.Location.X <= 0 Then

            Timer1.Enabled = True
            Timer2.Enabled = False



        Else
            Button1.Location = New Point(Button1.Location.X + 5, Button1.Location.Y - 10)
            Button3.Location = New Point(Button3.Location.X - 20, Button3.Location.Y - 5)
            Button4.Location = New Point(Button4.Location.X + 15, Button4.Location.Y + 15)
            Button5.Location = New Point(Button5.Location.X - 20, Button5.Location.Y + 5)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        My.Computer.Audio.Play(Application.StartupPath & "/music.wav")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label5.Text = Timer1.Interval & " : " & Timer2.Interval
        If Label4.Text = 5 Then
            Label4.Text = 0
            If Timer1.Interval = 1 Or Timer2.Interval = 1 Then

            Else

                Timer1.Interval = Timer1.Interval - 5
                Timer2.Interval = Timer2.Interval - 5

            End If
            Button1.Width = Button1.Width + 20
            Button1.Height = Button1.Height + 20
            'Button2.Width = Button2.Width + 20
            'Button2.Height = Button2.Height + 20
            Button3.Width = Button3.Width + 20
            Button3.Height = Button3.Height + 20
            Button4.Width = Button4.Width + 20
            Button4.Height = Button4.Height + 20
            Button5.Width = Button5.Width + 20
            Button5.Height = Button5.Height + 20
        Else
            Label4.Text = Integer.Parse(Label4.Text) + 1
        End If
        If Label6.Text = 5 Then
            Label6.Text = 0
            ' Me.Height = Me.Height - 20
            ' Me.Width = Me.Width - 20
            Panel1.Height = Panel1.Height - 20
            Panel1.Width = Panel1.Width - 20
        Else
            Label6.Text = Integer.Parse(Label6.Text) + 1
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim randomValue = CInt(Int((6 * Rnd()) + 1))
        If randomValue = 1 Or randomValue = 3 Then
            Randomize()
            PictureBox1.Visible = True

            Dim blah As Integer = Me.Width * Rnd()
            Dim meh As Integer = Me.Height * Rnd()

            PictureBox1.Top = meh
            PictureBox1.Left = blah
        Else
            PictureBox1.Visible = False
        End If

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If Label7.Text = My.Settings.life Then


            If tim1.Text = 1 Then
                Timer1.Enabled = True
            Else
                Timer2.Enabled = True
            End If
            Timer5.Enabled = False
            Timer3.Enabled = True
            Label7.Text = 0
        Else
            Label7.Text = Integer.Parse(Label7.Text) + 1
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
        End If

    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label10.Text = Integer.Parse(Label10.Text) + 1
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim AoutBox1 = New AboutBox1
        AoutBox1.ShowDialog()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        If Timer1.Enabled = True Then
            tim1.Text = 1
            tim2.Text = 0
        Else
            tim1.Text = 0
            tim2.Text = 1
        End If
        Timer1.Enabled = False
        Timer2.Enabled = False
        Panel1.Enabled = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Panel1.Enabled = True
        Label11.Text = 0
        PauseToolStripMenuItem.Enabled = True
        PlayToolStripMenuItem.Enabled = True
        If My.Settings.diff = 0 Then
            Panel1.BackColor = Color.Gainsboro
        Else
            Panel1.BackColor = Color.White
        End If
        Button1.Location = New Point(750, 0)
        Button2.Location = New Point(322, 181)
        Button3.Location = New Point(-114, -10)
        Button4.Location = New Point(710, 396)
        Button5.Location = New Point(-157, 362)
        Timer1.Interval = 50
        Timer2.Interval = 50
        Timer6.Enabled = True
        Button1.Size = New Size(192, 182)
        Button2.Size = New Size(60, 60)
        Button3.Size = New Size(153, 169)
        Button4.Size = New Size(232, 140)
        Button5.Size = New Size(188, 174)
        Panel1.Size = New Size(782, 492)
        Timer1.Enabled = True
        Label10.Text = 0
        Label7.Text = 0
        Panel1.Size = New Size(My.Settings.gamewidth, My.Settings.gameheight)

    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        Panel1.Enabled = True
        If tim1.Text = 1 Then
            Timer1.Enabled = True
            Timer2.Enabled = False
        Else
            Timer2.Enabled = True
            Timer1.Enabled = False
        End If

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim bset = New settings
        bset.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Dim randomValue = CInt(Int((6 * Rnd()) + 1))
        If randomValue = 1 Or randomValue = 3 Or randomValue = 5 Or randomValue = 6 Then
            Randomize()
            PictureBox2.Visible = True

            Dim blah As Integer = Me.Width * Rnd()
            Dim meh As Integer = Me.Height * Rnd()

            PictureBox2.Top = meh
            PictureBox2.Left = blah
        Else
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Label11.Text = Integer.Parse(Label11.Text) + 1
        PictureBox2.Visible = False
        Timer8.Enabled = False
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim ina = New Intro
        ina.ShowDialog()
    End Sub
End Class
