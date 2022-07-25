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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.movement = New System.Windows.Forms.Timer(Me.components)
        Me.score_lbl = New System.Windows.Forms.Label()
        Me.Roadmover = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.gameover_lbl = New System.Windows.Forms.Label()
        Me.play_lbl = New System.Windows.Forms.Label()
        Me.Quit_lbl = New System.Windows.Forms.Label()
        Me.stop_lbl = New System.Windows.Forms.Label()
        Me.specialMove = New System.Windows.Forms.Timer(Me.components)
        Me.Ammo_lbl = New System.Windows.Forms.Label()
        Me.stop_timer = New System.Windows.Forms.Timer(Me.components)
        Me.speed_increaser = New System.Windows.Forms.Timer(Me.components)
        Me.incoming_dis = New System.Windows.Forms.Timer(Me.components)
        Me.missile_launch = New System.Windows.Forms.Timer(Me.components)
        Me.reset_cars = New System.Windows.Forms.Timer(Me.components)
        Me.car7 = New System.Windows.Forms.PictureBox()
        Me.car1 = New System.Windows.Forms.PictureBox()
        Me.car4 = New System.Windows.Forms.PictureBox()
        Me.car5 = New System.Windows.Forms.PictureBox()
        Me.car8 = New System.Windows.Forms.PictureBox()
        Me.car6 = New System.Windows.Forms.PictureBox()
        Me.car2 = New System.Windows.Forms.PictureBox()
        Me.car3 = New System.Windows.Forms.PictureBox()
        Me.missile_logo = New System.Windows.Forms.PictureBox()
        Me.caution5 = New System.Windows.Forms.PictureBox()
        Me.caution3 = New System.Windows.Forms.PictureBox()
        Me.caution1 = New System.Windows.Forms.PictureBox()
        Me.caution2 = New System.Windows.Forms.PictureBox()
        Me.caution8 = New System.Windows.Forms.PictureBox()
        Me.caution7 = New System.Windows.Forms.PictureBox()
        Me.caution6 = New System.Windows.Forms.PictureBox()
        Me.caution4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.missile = New System.Windows.Forms.PictureBox()
        Me.specialBall = New System.Windows.Forms.PictureBox()
        Me.character = New System.Windows.Forms.PictureBox()
        Me.food = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.track12 = New System.Windows.Forms.PictureBox()
        Me.track11 = New System.Windows.Forms.PictureBox()
        Me.track10 = New System.Windows.Forms.PictureBox()
        Me.track9 = New System.Windows.Forms.PictureBox()
        Me.track8 = New System.Windows.Forms.PictureBox()
        Me.track6 = New System.Windows.Forms.PictureBox()
        Me.track7 = New System.Windows.Forms.PictureBox()
        Me.track5 = New System.Windows.Forms.PictureBox()
        Me.track3 = New System.Windows.Forms.PictureBox()
        Me.track4 = New System.Windows.Forms.PictureBox()
        Me.track2 = New System.Windows.Forms.PictureBox()
        Me.track1 = New System.Windows.Forms.PictureBox()
        Me.road = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.car7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caution4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.specialBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.food, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.track1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.road, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'movement
        '
        Me.movement.Enabled = True
        Me.movement.Interval = 10
        '
        'score_lbl
        '
        Me.score_lbl.AutoSize = True
        Me.score_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_lbl.Location = New System.Drawing.Point(21, 9)
        Me.score_lbl.Name = "score_lbl"
        Me.score_lbl.Size = New System.Drawing.Size(102, 29)
        Me.score_lbl.TabIndex = 2
        Me.score_lbl.Text = "Score: 0"
        '
        'Roadmover
        '
        Me.Roadmover.Enabled = True
        Me.Roadmover.Interval = 70
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'gameover_lbl
        '
        Me.gameover_lbl.AutoSize = True
        Me.gameover_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameover_lbl.Location = New System.Drawing.Point(587, 295)
        Me.gameover_lbl.Name = "gameover_lbl"
        Me.gameover_lbl.Size = New System.Drawing.Size(218, 44)
        Me.gameover_lbl.TabIndex = 8
        Me.gameover_lbl.Text = "Game Over"
        Me.gameover_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.gameover_lbl.Visible = False
        '
        'play_lbl
        '
        Me.play_lbl.AutoSize = True
        Me.play_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.play_lbl.ForeColor = System.Drawing.Color.Lime
        Me.play_lbl.Location = New System.Drawing.Point(537, 347)
        Me.play_lbl.Name = "play_lbl"
        Me.play_lbl.Size = New System.Drawing.Size(135, 29)
        Me.play_lbl.TabIndex = 9
        Me.play_lbl.Text = "Play Again"
        Me.play_lbl.Visible = False
        '
        'Quit_lbl
        '
        Me.Quit_lbl.AutoSize = True
        Me.Quit_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit_lbl.ForeColor = System.Drawing.Color.OrangeRed
        Me.Quit_lbl.Location = New System.Drawing.Point(719, 347)
        Me.Quit_lbl.Name = "Quit_lbl"
        Me.Quit_lbl.Size = New System.Drawing.Size(135, 29)
        Me.Quit_lbl.TabIndex = 9
        Me.Quit_lbl.Text = "Quit Game"
        Me.Quit_lbl.Visible = False
        '
        'stop_lbl
        '
        Me.stop_lbl.AutoSize = True
        Me.stop_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stop_lbl.Location = New System.Drawing.Point(623, 14)
        Me.stop_lbl.Name = "stop_lbl"
        Me.stop_lbl.Size = New System.Drawing.Size(15, 24)
        Me.stop_lbl.TabIndex = 16
        Me.stop_lbl.Text = ":"
        '
        'specialMove
        '
        Me.specialMove.Enabled = True
        '
        'Ammo_lbl
        '
        Me.Ammo_lbl.AutoSize = True
        Me.Ammo_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ammo_lbl.Location = New System.Drawing.Point(1257, 9)
        Me.Ammo_lbl.Name = "Ammo_lbl"
        Me.Ammo_lbl.Size = New System.Drawing.Size(94, 29)
        Me.Ammo_lbl.TabIndex = 26
        Me.Ammo_lbl.Text = "Ammo :"
        Me.Ammo_lbl.Visible = False
        '
        'stop_timer
        '
        Me.stop_timer.Enabled = True
        Me.stop_timer.Interval = 1000
        '
        'speed_increaser
        '
        Me.speed_increaser.Enabled = True
        '
        'incoming_dis
        '
        Me.incoming_dis.Enabled = True
        '
        'missile_launch
        '
        Me.missile_launch.Enabled = True
        '
        'reset_cars
        '
        Me.reset_cars.Interval = 1000
        '
        'car7
        '
        Me.car7.BackColor = System.Drawing.Color.DimGray
        Me.car7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car7.Image = Global.Game_char.My.Resources.Resources.cas_blue
        Me.car7.Location = New System.Drawing.Point(276, 360)
        Me.car7.Name = "car7"
        Me.car7.Size = New System.Drawing.Size(41, 62)
        Me.car7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car7.TabIndex = 27
        Me.car7.TabStop = False
        '
        'car1
        '
        Me.car1.BackColor = System.Drawing.Color.DimGray
        Me.car1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car1.Image = CType(resources.GetObject("car1.Image"), System.Drawing.Image)
        Me.car1.Location = New System.Drawing.Point(297, 609)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(41, 62)
        Me.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car1.TabIndex = 28
        Me.car1.TabStop = False
        '
        'car4
        '
        Me.car4.BackColor = System.Drawing.Color.DimGray
        Me.car4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car4.Image = CType(resources.GetObject("car4.Image"), System.Drawing.Image)
        Me.car4.Location = New System.Drawing.Point(1038, 558)
        Me.car4.Name = "car4"
        Me.car4.Size = New System.Drawing.Size(41, 62)
        Me.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car4.TabIndex = 29
        Me.car4.TabStop = False
        '
        'car5
        '
        Me.car5.BackColor = System.Drawing.Color.DimGray
        Me.car5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car5.Image = CType(resources.GetObject("car5.Image"), System.Drawing.Image)
        Me.car5.Location = New System.Drawing.Point(930, 271)
        Me.car5.Name = "car5"
        Me.car5.Size = New System.Drawing.Size(41, 62)
        Me.car5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car5.TabIndex = 30
        Me.car5.TabStop = False
        '
        'car8
        '
        Me.car8.BackColor = System.Drawing.Color.DimGray
        Me.car8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car8.Image = Global.Game_char.My.Resources.Resources.cas_gray
        Me.car8.Location = New System.Drawing.Point(468, 61)
        Me.car8.Name = "car8"
        Me.car8.Size = New System.Drawing.Size(41, 62)
        Me.car8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car8.TabIndex = 31
        Me.car8.TabStop = False
        '
        'car6
        '
        Me.car6.BackColor = System.Drawing.Color.DimGray
        Me.car6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car6.Image = Global.Game_char.My.Resources.Resources.cas_green
        Me.car6.Location = New System.Drawing.Point(489, 310)
        Me.car6.Name = "car6"
        Me.car6.Size = New System.Drawing.Size(41, 62)
        Me.car6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car6.TabIndex = 32
        Me.car6.TabStop = False
        '
        'car2
        '
        Me.car2.BackColor = System.Drawing.Color.DimGray
        Me.car2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car2.Image = CType(resources.GetObject("car2.Image"), System.Drawing.Image)
        Me.car2.Location = New System.Drawing.Point(580, 485)
        Me.car2.Name = "car2"
        Me.car2.Size = New System.Drawing.Size(41, 62)
        Me.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car2.TabIndex = 33
        Me.car2.TabStop = False
        '
        'car3
        '
        Me.car3.BackColor = System.Drawing.Color.DimGray
        Me.car3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.car3.Image = Global.Game_char.My.Resources.Resources.cas1
        Me.car3.Location = New System.Drawing.Point(784, 405)
        Me.car3.Name = "car3"
        Me.car3.Size = New System.Drawing.Size(41, 62)
        Me.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car3.TabIndex = 34
        Me.car3.TabStop = False
        '
        'missile_logo
        '
        Me.missile_logo.Image = Global.Game_char.My.Resources.Resources.missile_logo
        Me.missile_logo.Location = New System.Drawing.Point(1227, 8)
        Me.missile_logo.Name = "missile_logo"
        Me.missile_logo.Size = New System.Drawing.Size(24, 51)
        Me.missile_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.missile_logo.TabIndex = 25
        Me.missile_logo.TabStop = False
        Me.missile_logo.Visible = False
        '
        'caution5
        '
        Me.caution5.Image = CType(resources.GetObject("caution5.Image"), System.Drawing.Image)
        Me.caution5.Location = New System.Drawing.Point(564, 13)
        Me.caution5.Name = "caution5"
        Me.caution5.Size = New System.Drawing.Size(41, 50)
        Me.caution5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution5.TabIndex = 17
        Me.caution5.TabStop = False
        Me.caution5.Visible = False
        '
        'caution3
        '
        Me.caution3.Image = CType(resources.GetObject("caution3.Image"), System.Drawing.Image)
        Me.caution3.Location = New System.Drawing.Point(360, 9)
        Me.caution3.Name = "caution3"
        Me.caution3.Size = New System.Drawing.Size(41, 50)
        Me.caution3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution3.TabIndex = 18
        Me.caution3.TabStop = False
        Me.caution3.Visible = False
        '
        'caution1
        '
        Me.caution1.Image = CType(resources.GetObject("caution1.Image"), System.Drawing.Image)
        Me.caution1.Location = New System.Drawing.Point(126, 9)
        Me.caution1.Name = "caution1"
        Me.caution1.Size = New System.Drawing.Size(41, 50)
        Me.caution1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution1.TabIndex = 19
        Me.caution1.TabStop = False
        Me.caution1.Visible = False
        '
        'caution2
        '
        Me.caution2.Image = CType(resources.GetObject("caution2.Image"), System.Drawing.Image)
        Me.caution2.Location = New System.Drawing.Point(250, 9)
        Me.caution2.Name = "caution2"
        Me.caution2.Size = New System.Drawing.Size(41, 50)
        Me.caution2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution2.TabIndex = 20
        Me.caution2.TabStop = False
        Me.caution2.Visible = False
        '
        'caution8
        '
        Me.caution8.Image = CType(resources.GetObject("caution8.Image"), System.Drawing.Image)
        Me.caution8.Location = New System.Drawing.Point(987, 9)
        Me.caution8.Name = "caution8"
        Me.caution8.Size = New System.Drawing.Size(41, 50)
        Me.caution8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution8.TabIndex = 21
        Me.caution8.TabStop = False
        Me.caution8.Visible = False
        '
        'caution7
        '
        Me.caution7.Image = CType(resources.GetObject("caution7.Image"), System.Drawing.Image)
        Me.caution7.Location = New System.Drawing.Point(890, 9)
        Me.caution7.Name = "caution7"
        Me.caution7.Size = New System.Drawing.Size(41, 50)
        Me.caution7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution7.TabIndex = 22
        Me.caution7.TabStop = False
        Me.caution7.Visible = False
        '
        'caution6
        '
        Me.caution6.Image = CType(resources.GetObject("caution6.Image"), System.Drawing.Image)
        Me.caution6.Location = New System.Drawing.Point(768, 9)
        Me.caution6.Name = "caution6"
        Me.caution6.Size = New System.Drawing.Size(41, 50)
        Me.caution6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution6.TabIndex = 23
        Me.caution6.TabStop = False
        Me.caution6.Visible = False
        '
        'caution4
        '
        Me.caution4.Image = CType(resources.GetObject("caution4.Image"), System.Drawing.Image)
        Me.caution4.Location = New System.Drawing.Point(452, 9)
        Me.caution4.Name = "caution4"
        Me.caution4.Size = New System.Drawing.Size(41, 50)
        Me.caution4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.caution4.TabIndex = 24
        Me.caution4.TabStop = False
        Me.caution4.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Game_char.My.Resources.Resources.bomb31
        Me.PictureBox4.Location = New System.Drawing.Point(595, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'missile
        '
        Me.missile.Image = Global.Game_char.My.Resources.Resources.missile_up
        Me.missile.Location = New System.Drawing.Point(386, 179)
        Me.missile.Name = "missile"
        Me.missile.Size = New System.Drawing.Size(20, 56)
        Me.missile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.missile.TabIndex = 11
        Me.missile.TabStop = False
        Me.missile.Visible = False
        '
        'specialBall
        '
        Me.specialBall.BackColor = System.Drawing.Color.Transparent
        Me.specialBall.Image = Global.Game_char.My.Resources.Resources.special
        Me.specialBall.Location = New System.Drawing.Point(805, 155)
        Me.specialBall.Name = "specialBall"
        Me.specialBall.Size = New System.Drawing.Size(24, 44)
        Me.specialBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.specialBall.TabIndex = 10
        Me.specialBall.TabStop = False
        Me.specialBall.Visible = False
        '
        'character
        '
        Me.character.BackColor = System.Drawing.Color.Transparent
        Me.character.Image = Global.Game_char.My.Resources.Resources._2
        Me.character.Location = New System.Drawing.Point(62, 392)
        Me.character.Name = "character"
        Me.character.Size = New System.Drawing.Size(22, 30)
        Me.character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.character.TabIndex = 0
        Me.character.TabStop = False
        '
        'food
        '
        Me.food.BackColor = System.Drawing.Color.Transparent
        Me.food.Image = Global.Game_char.My.Resources.Resources.bomb3
        Me.food.Location = New System.Drawing.Point(109, 181)
        Me.food.Name = "food"
        Me.food.Size = New System.Drawing.Size(23, 18)
        Me.food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.food.TabIndex = 1
        Me.food.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox2.Location = New System.Drawing.Point(1108, -10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 883)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'track12
        '
        Me.track12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track12.Location = New System.Drawing.Point(1032, 604)
        Me.track12.Name = "track12"
        Me.track12.Size = New System.Drawing.Size(10, 126)
        Me.track12.TabIndex = 4
        Me.track12.TabStop = False
        '
        'track11
        '
        Me.track11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track11.Location = New System.Drawing.Point(732, 604)
        Me.track11.Name = "track11"
        Me.track11.Size = New System.Drawing.Size(10, 126)
        Me.track11.TabIndex = 4
        Me.track11.TabStop = False
        '
        'track10
        '
        Me.track10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track10.Location = New System.Drawing.Point(373, 604)
        Me.track10.Name = "track10"
        Me.track10.Size = New System.Drawing.Size(10, 126)
        Me.track10.TabIndex = 4
        Me.track10.TabStop = False
        '
        'track9
        '
        Me.track9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track9.Location = New System.Drawing.Point(1032, 417)
        Me.track9.Name = "track9"
        Me.track9.Size = New System.Drawing.Size(10, 126)
        Me.track9.TabIndex = 4
        Me.track9.TabStop = False
        '
        'track8
        '
        Me.track8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track8.Location = New System.Drawing.Point(732, 417)
        Me.track8.Name = "track8"
        Me.track8.Size = New System.Drawing.Size(10, 126)
        Me.track8.TabIndex = 4
        Me.track8.TabStop = False
        '
        'track6
        '
        Me.track6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track6.Location = New System.Drawing.Point(1032, 228)
        Me.track6.Name = "track6"
        Me.track6.Size = New System.Drawing.Size(10, 126)
        Me.track6.TabIndex = 4
        Me.track6.TabStop = False
        '
        'track7
        '
        Me.track7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track7.Location = New System.Drawing.Point(373, 417)
        Me.track7.Name = "track7"
        Me.track7.Size = New System.Drawing.Size(10, 126)
        Me.track7.TabIndex = 4
        Me.track7.TabStop = False
        '
        'track5
        '
        Me.track5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track5.Location = New System.Drawing.Point(732, 228)
        Me.track5.Name = "track5"
        Me.track5.Size = New System.Drawing.Size(10, 126)
        Me.track5.TabIndex = 4
        Me.track5.TabStop = False
        '
        'track3
        '
        Me.track3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track3.Location = New System.Drawing.Point(1032, 15)
        Me.track3.Name = "track3"
        Me.track3.Size = New System.Drawing.Size(10, 126)
        Me.track3.TabIndex = 4
        Me.track3.TabStop = False
        '
        'track4
        '
        Me.track4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track4.Location = New System.Drawing.Point(373, 228)
        Me.track4.Name = "track4"
        Me.track4.Size = New System.Drawing.Size(10, 126)
        Me.track4.TabIndex = 4
        Me.track4.TabStop = False
        '
        'track2
        '
        Me.track2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track2.Location = New System.Drawing.Point(732, 15)
        Me.track2.Name = "track2"
        Me.track2.Size = New System.Drawing.Size(10, 126)
        Me.track2.TabIndex = 4
        Me.track2.TabStop = False
        '
        'track1
        '
        Me.track1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.track1.Location = New System.Drawing.Point(373, 15)
        Me.track1.Name = "track1"
        Me.track1.Size = New System.Drawing.Size(10, 126)
        Me.track1.TabIndex = 4
        Me.track1.TabStop = False
        '
        'road
        '
        Me.road.BackColor = System.Drawing.Color.DimGray
        Me.road.Location = New System.Drawing.Point(273, -10)
        Me.road.Name = "road"
        Me.road.Size = New System.Drawing.Size(852, 771)
        Me.road.TabIndex = 3
        Me.road.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(259, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(19, 883)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.missile_logo)
        Me.Controls.Add(Me.Ammo_lbl)
        Me.Controls.Add(Me.score_lbl)
        Me.Controls.Add(Me.play_lbl)
        Me.Controls.Add(Me.gameover_lbl)
        Me.Controls.Add(Me.car7)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.car4)
        Me.Controls.Add(Me.car5)
        Me.Controls.Add(Me.car8)
        Me.Controls.Add(Me.car6)
        Me.Controls.Add(Me.car2)
        Me.Controls.Add(Me.car3)
        Me.Controls.Add(Me.caution5)
        Me.Controls.Add(Me.caution3)
        Me.Controls.Add(Me.caution1)
        Me.Controls.Add(Me.caution2)
        Me.Controls.Add(Me.caution8)
        Me.Controls.Add(Me.caution7)
        Me.Controls.Add(Me.caution6)
        Me.Controls.Add(Me.caution4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.stop_lbl)
        Me.Controls.Add(Me.missile)
        Me.Controls.Add(Me.specialBall)
        Me.Controls.Add(Me.character)
        Me.Controls.Add(Me.Quit_lbl)
        Me.Controls.Add(Me.food)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.track12)
        Me.Controls.Add(Me.track11)
        Me.Controls.Add(Me.track10)
        Me.Controls.Add(Me.track9)
        Me.Controls.Add(Me.track8)
        Me.Controls.Add(Me.track6)
        Me.Controls.Add(Me.track7)
        Me.Controls.Add(Me.track5)
        Me.Controls.Add(Me.track3)
        Me.Controls.Add(Me.track4)
        Me.Controls.Add(Me.track2)
        Me.Controls.Add(Me.track1)
        Me.Controls.Add(Me.road)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Simple Game"
        CType(Me.car7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caution4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.specialBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.character, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.food, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.track1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.road, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents character As System.Windows.Forms.PictureBox
    Friend WithEvents food As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents movement As System.Windows.Forms.Timer
    Friend WithEvents score_lbl As System.Windows.Forms.Label
    Friend WithEvents road As System.Windows.Forms.PictureBox
    Friend WithEvents track1 As System.Windows.Forms.PictureBox
    Friend WithEvents track2 As System.Windows.Forms.PictureBox
    Friend WithEvents track4 As System.Windows.Forms.PictureBox
    Friend WithEvents track5 As System.Windows.Forms.PictureBox
    Friend WithEvents track7 As System.Windows.Forms.PictureBox
    Friend WithEvents track8 As System.Windows.Forms.PictureBox
    Friend WithEvents track10 As System.Windows.Forms.PictureBox
    Friend WithEvents track11 As System.Windows.Forms.PictureBox
    Friend WithEvents track3 As System.Windows.Forms.PictureBox
    Friend WithEvents track6 As System.Windows.Forms.PictureBox
    Friend WithEvents track9 As System.Windows.Forms.PictureBox
    Friend WithEvents track12 As System.Windows.Forms.PictureBox
    Friend WithEvents Roadmover As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents gameover_lbl As System.Windows.Forms.Label
    Friend WithEvents play_lbl As System.Windows.Forms.Label
    Friend WithEvents Quit_lbl As System.Windows.Forms.Label
    Friend WithEvents specialBall As System.Windows.Forms.PictureBox
    Friend WithEvents missile As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents stop_lbl As System.Windows.Forms.Label
    Friend WithEvents caution5 As System.Windows.Forms.PictureBox
    Friend WithEvents caution3 As System.Windows.Forms.PictureBox
    Friend WithEvents caution1 As System.Windows.Forms.PictureBox
    Friend WithEvents caution2 As System.Windows.Forms.PictureBox
    Friend WithEvents caution8 As System.Windows.Forms.PictureBox
    Friend WithEvents caution7 As System.Windows.Forms.PictureBox
    Friend WithEvents caution6 As System.Windows.Forms.PictureBox
    Friend WithEvents caution4 As System.Windows.Forms.PictureBox
    Friend WithEvents specialMove As System.Windows.Forms.Timer
    Friend WithEvents missile_logo As System.Windows.Forms.PictureBox
    Friend WithEvents Ammo_lbl As System.Windows.Forms.Label
    Friend WithEvents stop_timer As System.Windows.Forms.Timer
    Friend WithEvents speed_increaser As System.Windows.Forms.Timer
    Friend WithEvents incoming_dis As System.Windows.Forms.Timer
    Friend WithEvents car7 As System.Windows.Forms.PictureBox
    Friend WithEvents car1 As System.Windows.Forms.PictureBox
    Friend WithEvents car4 As System.Windows.Forms.PictureBox
    Friend WithEvents car5 As System.Windows.Forms.PictureBox
    Friend WithEvents car8 As System.Windows.Forms.PictureBox
    Friend WithEvents car6 As System.Windows.Forms.PictureBox
    Friend WithEvents car2 As System.Windows.Forms.PictureBox
    Friend WithEvents car3 As System.Windows.Forms.PictureBox
    Friend WithEvents missile_launch As System.Windows.Forms.Timer
    Friend WithEvents reset_cars As System.Windows.Forms.Timer

End Class
