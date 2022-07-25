Public Class Form1

    Dim movel, mover, moved, moveu As Boolean
    Dim score As Integer
    Dim car(7) As PictureBox
    Dim roadtrack(11), caution(7) As PictureBox
    Dim gameover As Boolean = False
    Dim special As Integer
    Dim rocket As Boolean = False
    Dim launch As Boolean = False
    Dim target As String
    Dim Ammo As Integer = 4
    Dim timers(5) As Timer
    Dim time As Integer = 10
    Dim speed As Integer = 25
    Dim shot(7) As Integer







    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown


        If (e.KeyCode = Keys.Up And gameover = False) Then

            character.Image = My.Resources._3


            moveu = True
            moved = False
            movel = False
            mover = False









        Else

        End If

        If (e.KeyCode = Keys.Down And gameover = False And character.Top < Me.Width) Then


            moveu = False
            moved = True
            movel = False
            mover = False

            character.Image = My.Resources._end







        Else

        End If

        If (e.KeyCode = Keys.Right And gameover = False And character.Left + 30 < Me.Width) Then

            moveu = False
            moved = False
            movel = False
            mover = True

            character.Image = My.Resources._2








        Else

        End If

        If (e.KeyCode = Keys.Left And gameover = False) Then

            moveu = False
            moved = False
            movel = True
            mover = False

            character.Image = My.Resources._4





        Else

        End If

        If e.KeyCode = Keys.Space And gameover = False Then

            If (launch = False And rocket = True) Then
                missile.Visible = True
                missile.Image = My.Resources.missile_up
                missile.Left = CInt(character.Location.X)
                missile.Top = CInt(character.Location.Y) - 20
                missile.Top -= 10
                launch = True
                target = "up"

            End If





        End If




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized

        car(0) = car1
        car(1) = car2
        car(2) = car3

        car(3) = car4
        car(4) = car5
        car(5) = car6

        car(6) = car7
        car(7) = car8

        roadtrack(0) = track1
        roadtrack(1) = track2
        roadtrack(2) = track3

        roadtrack(3) = track4

        roadtrack(4) = track5

        roadtrack(5) = track6
        roadtrack(6) = track7
        roadtrack(7) = track8
        roadtrack(8) = track9
        roadtrack(9) = track10
        roadtrack(10) = track11
        roadtrack(11) = track12



        timers(0) = Timer1
        timers(1) = Timer2
        timers(2) = Roadmover

        timers(3) = movement
        timers(4) = specialMove
        timers(5) = stop_timer

        caution(0) = caution1
        caution(1) = caution2
        caution(2) = caution3
        caution(3) = caution4
        caution(4) = caution5
        caution(5) = caution6
        caution(6) = caution7
        caution(7) = caution8

        stop_lbl.Left = (Me.Width - stop_lbl.Width) / 2

        PictureBox4.Left = (Me.Width - PictureBox4.Width) / 2 - stop_lbl.Width - 10




    End Sub

    Private Sub food_Click(sender As Object, e As EventArgs) Handles food.Click





    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If character.Bounds.IntersectsWith(food.Bounds) Then

            score += 1

            time = 10



            score_lbl.Text = "Score: " & score


            food.Left = Rnd() * (Me.Width - 150)
            food.Top = Rnd() * (Me.Height - 250)
            special = Math.Floor(Rnd() * 8)
            specialBall.Left = Rnd() * (Me.Width - 100)
            specialBall.Top = Rnd() * (Me.Height - 150)

        Else



        End If



        If (special = 5) Then

            specialBall.Visible = True

        Else

            specialBall.Visible = False


        End If



    End Sub

    Private Sub movement_Tick(sender As Object, e As EventArgs) Handles movement.Tick
 If (movel = True And character.Location.X > 0) Then
            character.Left -= 10



        End If

        If (mover = True And character.Location.X < Me.Width - 40) Then
            character.Left += 10


        End If
        If (moveu = True And character.Location.Y > 0) Then
            character.Top -= 10

        End If
        If (moved = True And character.Location.Y < Me.Height - 20) Then
            character.Top += 10

        End If


    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.Down) Then

            moveu = False
            moved = False
            movel = False
            mover = False

        End If
        If (e.KeyCode = Keys.Left) Then
            moveu = False
            moved = False
            movel = False
            mover = False
        End If
        If (e.KeyCode = Keys.Right) Then
            moveu = False
            moved = False
            movel = False
            mover = False
        End If
        If (e.KeyCode = Keys.Up) Then
            moveu = False
            moved = False
            movel = False
            mover = False

        End If
        If (e.KeyCode = Keys.Escape) Then


            For x As Integer = 0 To 5

                timers(x).Enabled = False




            Next

            gameover_lbl.Visible = True
            gameover_lbl.Text = "Paused"
            play_lbl.Visible = True



            play_lbl.Text = "Resume"
            Quit_lbl.Visible = True



        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Roadmover_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Roadmover_Tick_1(sender As Object, e As EventArgs) Handles Roadmover.Tick


       



        For x As Integer = 0 To 7

            If (shot(x) <> True) Then
                car(x).Top += speed
            Else

            End If





            If (car(x).Top > Me.Height) Then
                car(x).Top = -car(x).Height - 40
                'car(x).Left = CStr(Math.Floor(Rnd() * CInt(road.Location.X + road.Width)))

                If (x = 0) Then
                    car(x).Left = CInt(Math.Floor(Rnd() * 157)) + 0
                    'caution1.Left = car(0).Left

                ElseIf (x = 1) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * 344)) + 159
                    'caution2.Left = car(1).Left
                ElseIf (x = 2) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * 531)) + 349
                    'caution3.Left = car(2).Left
                ElseIf (x = 3) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * 718)) + 536
                    'caution4.Left = car(3).Left
                ElseIf (x = 4) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * 905)) + 723
                    'caution5.Left = car(4).Left
                ElseIf (x = 5) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * 1092)) + 911
                    'caution6.Left = car(5).Left
                ElseIf (x = 6) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * 1279)) + 1097
                    'caution7.Left = car(6).Left

                ElseIf (x = 7) Then

                    car(x).Left = CInt(Math.Floor(Rnd() * Me.Width)) + 1279

                    'caution8.Left = car(7).Left


                End If


            End If

        Next






    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For x As Integer = 0 To 7

            If (car(x).Bounds.IntersectsWith(character.Bounds)) Then

                character.Image = My.Resources.down_char





                Roadmover.Enabled = False
                gameover = True


                gameover_lbl.Visible = True
                play_lbl.Visible = True
                Quit_lbl.Visible = True
                movement.Enabled = False

                character.Top += 20

                Timer2.Enabled = False

                stop_timer.Enabled = False









            End If

        Next

        

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles play_lbl.Click
        If (play_lbl.Text <> "Resume") Then
            Me.Controls.Clear()
            InitializeComponent()
            Form1_Load(e, e)
            gameover = False
            rocket = False
            time = 10
            score = 0
            food.Width = 23
            food.Height = 18
            
        Else
            For x As Integer = 0 To 5
                timers(x).Enabled = True

            Next



            
            gameover_lbl.Visible = False
            gameover_lbl.Text = "Game Over"
            play_lbl.Visible = False



            play_lbl.Text = "Play Again"
            Quit_lbl.Visible = False


        End If






    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Quit_lbl.Click
        Me.Close()

    End Sub

    Private Sub character_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub specialMove_Tick(sender As Object, e As EventArgs) Handles specialMove.Tick
        If (character.Bounds.IntersectsWith(specialBall.Bounds)) Then


            specialBall.Visible = False
            special = Math.Floor(Rnd() * 20)
            rocket = True
            Ammo_lbl.Visible = True
            Ammo_lbl.Text = " :4"
            missile_logo.Visible = True
            missile_logo.Left = Ammo_lbl.Left - 20


        End If



        If launch = True And Ammo > 0 Then




        ElseIf target = "up" Then


            missile.Top -= 55

        ElseIf target = "down" Then

            missile.Top += 55
        Else



        End If











        If (launch = True And missile.Location.Y > Me.Height And Ammo > 0) Or (launch = True And missile.Location.Y < -missile.Height And Ammo > 0) Or (launch = True And Ammo > 0) Or (launch = True And Ammo > 0) Then

            launch = False

            Ammo -= 1
            Ammo_lbl.Text = " :" & Ammo


        End If


        




        If Ammo = 0 Then

            rocket = False
            Ammo = 4
            missile.Visible = False

            Ammo_lbl.Visible = False
            missile_logo.Visible = False






        End If
    End Sub

    Private Sub stop_timer_Tick(sender As Object, e As EventArgs) Handles stop_timer.Tick

        If (time > 0) Then

            time -= 1

            stop_lbl.Text = " :" & time


        Else

            For x As Integer = 0 To 5

                timers(x).Enabled = False

            Next


            food.Image = My.Resources.explosion
            food.Width = 30
            food.Height = 30

            gameover_lbl.Visible = True
            gameover_lbl.Text = "Time's Up"
            play_lbl.Visible = True
            Quit_lbl.Visible = True
            character.Image = My.Resources.down_char1




        End If

    End Sub

    Private Sub speed_increaser_Tick(sender As Object, e As EventArgs) Handles speed_increaser.Tick
        If score > 15 And score < 45 Then


            speed = 30


        ElseIf score > 45 And score < 85 Then

            speed = 40

        ElseIf score > 85 And score < 120 Then

            speed = 50


        End If




    End Sub

    Private Sub incoming_dis_Tick(sender As Object, e As EventArgs) Handles incoming_dis.Tick

        For x As Integer = 0 To 7

            If (character.Location.Y < 250 And car(x).Top < -10) Then

                caution(x).Visible = True


            Else

                caution(x).Visible = False

            End If
        Next


    End Sub

    Private Sub Timer3_Tick_1(sender As Object, e As EventArgs) Handles missile_launch.Tick

        For x As Integer = 0 To 7
            If (missile.Bounds.IntersectsWith(car(x).Bounds) And missile.Visible = True) Then

                car(x).Width = 62

                car(x).Image = My.Resources.explosion
                shot(x) = True
                reset_cars.Enabled = True



            End If
        Next



    End Sub

    Private Sub reset_cars_Tick(sender As Object, e As EventArgs) Handles reset_cars.Tick



        For x As Integer = 0 To 7





            If (x = 0 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 157)) + 0
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas_green
                car(x).Width = 41

                shot(x) = False
                caution1.Left = car(0).Left

            ElseIf (x = 1 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 344)) + 159
                car(x).Top = -car(x).Height - 10

                car(x).Image = My.Resources.cas_blue
                car(x).Width = 41

                shot(x) = False
                caution2.Left = car(1).Left
            ElseIf (x = 2 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 531)) + 349
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas1
                car(x).Width = 41
                shot(x) = False
                caution3.Left = car(2).Left
            ElseIf (x = 3 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 718)) + 536
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas_gray
                car(x).Width = 41
                shot(x) = False
                caution4.Left = car(3).Left
            ElseIf (x = 4 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 905)) + 723
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas_green
                car(x).Width = 41
                shot(x) = False
                caution5.Left = car(4).Left
            ElseIf (x = 5 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 1092)) + 911
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas1
                car(x).Width = 41
                shot(x) = False
                caution6.Left = car(5).Left
            ElseIf (x = 6 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * 1279)) + 1097
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas_blue
                car(x).Width = 41
                shot(x) = False
                caution7.Left = car(6).Left

            ElseIf (x = 7 And shot(x) = True) Then

                car(x).Left = CInt(Math.Floor(Rnd() * Me.Width)) + 1279
                car(x).Top = -car(x).Height - 10
                car(x).Image = My.Resources.cas_gray
                car(x).Width = 41
                shot(x) = False

                caution8.Left = car(7).Left


            End If

        Next

        reset_cars.Enabled = False


    End Sub

    Private Sub road_Click(sender As Object, e As EventArgs) Handles road.Click

    End Sub

    Private Sub road_MouseMove(sender As Object, e As MouseEventArgs) Handles road.MouseMove



    End Sub
End Class
