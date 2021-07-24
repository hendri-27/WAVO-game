namespace Hendri_WAVOgame
{
    partial class FormWAVO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWAVO));
            this.labelTxtLives = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.moveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.moveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.moveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.moveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.carSlowGenerator = new System.Windows.Forms.Timer(this.components);
            this.labelSurviveTime = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelTxtRound = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.txt_GameOver = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.carSpeedGenerator = new System.Windows.Forms.Timer(this.components);
            this.labelDivider2 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelDivider1 = new System.Windows.Forms.Label();
            this.labelCs = new System.Windows.Forms.Label();
            this.labelDivider3 = new System.Windows.Forms.Label();
            this.SurviveTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTxtLives
            // 
            this.labelTxtLives.AutoSize = true;
            this.labelTxtLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtLives.Location = new System.Drawing.Point(749, 9);
            this.labelTxtLives.Name = "labelTxtLives";
            this.labelTxtLives.Size = new System.Drawing.Size(45, 17);
            this.labelTxtLives.TabIndex = 14;
            this.labelTxtLives.Text = "Lives:";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // moveRightTimer
            // 
            this.moveRightTimer.Interval = 1;
            this.moveRightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);
            // 
            // moveLeftTimer
            // 
            this.moveLeftTimer.Interval = 1;
            this.moveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // moveUpTimer
            // 
            this.moveUpTimer.Interval = 1;
            this.moveUpTimer.Tick += new System.EventHandler(this.MoveUpTimer_Tick);
            // 
            // moveDownTimer
            // 
            this.moveDownTimer.Interval = 1;
            this.moveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // carSlowGenerator
            // 
            this.carSlowGenerator.Enabled = true;
            this.carSlowGenerator.Interval = 2000;
            this.carSlowGenerator.Tick += new System.EventHandler(this.CarSlowGenerator_Tick);
            // 
            // labelSurviveTime
            // 
            this.labelSurviveTime.AutoSize = true;
            this.labelSurviveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurviveTime.Location = new System.Drawing.Point(340, 262);
            this.labelSurviveTime.Name = "labelSurviveTime";
            this.labelSurviveTime.Size = new System.Drawing.Size(133, 20);
            this.labelSurviveTime.TabIndex = 18;
            this.labelSurviveTime.Text = "Your survive time:";
            this.labelSurviveTime.Visible = false;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.Location = new System.Drawing.Point(474, 262);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(27, 20);
            this.labelHour.TabIndex = 19;
            this.labelHour.Text = "00";
            this.labelHour.Visible = false;
            // 
            // labelTxtRound
            // 
            this.labelTxtRound.AutoSize = true;
            this.labelTxtRound.BackColor = System.Drawing.Color.Transparent;
            this.labelTxtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxtRound.ForeColor = System.Drawing.Color.Maroon;
            this.labelTxtRound.Location = new System.Drawing.Point(418, 9);
            this.labelTxtRound.Name = "labelTxtRound";
            this.labelTxtRound.Size = new System.Drawing.Size(72, 24);
            this.labelTxtRound.TabIndex = 21;
            this.labelTxtRound.Text = "Round";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.BackColor = System.Drawing.Color.Transparent;
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.ForeColor = System.Drawing.Color.Maroon;
            this.labelRound.Location = new System.Drawing.Point(487, 9);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(21, 24);
            this.labelRound.TabIndex = 22;
            this.labelRound.Text = "1";
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.TimerCountdown_Tick);
            // 
            // txt_GameOver
            // 
            this.txt_GameOver.AutoSize = true;
            this.txt_GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GameOver.ForeColor = System.Drawing.Color.Red;
            this.txt_GameOver.Location = new System.Drawing.Point(277, 172);
            this.txt_GameOver.Name = "txt_GameOver";
            this.txt_GameOver.Size = new System.Drawing.Size(378, 76);
            this.txt_GameOver.TabIndex = 23;
            this.txt_GameOver.Text = "Game Over";
            this.txt_GameOver.Visible = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Black;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(376, 295);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(176, 35);
            this.buttonRestart.TabIndex = 24;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.BackColor = System.Drawing.Color.Gray;
            this.buttonBackToMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBackToMainMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(363, 349);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(196, 35);
            this.buttonBackToMainMenu.TabIndex = 25;
            this.buttonBackToMainMenu.Text = "Back to Main Menu";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMainMenu.Visible = false;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.ButtonBackToMainMenu_Click);
            // 
            // carSpeedGenerator
            // 
            this.carSpeedGenerator.Interval = 10000;
            this.carSpeedGenerator.Tick += new System.EventHandler(this.CarSpeedGenerator_Tick);
            // 
            // labelDivider2
            // 
            this.labelDivider2.AutoSize = true;
            this.labelDivider2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivider2.Location = new System.Drawing.Point(527, 262);
            this.labelDivider2.Name = "labelDivider2";
            this.labelDivider2.Size = new System.Drawing.Size(13, 20);
            this.labelDivider2.TabIndex = 26;
            this.labelDivider2.Text = ":";
            this.labelDivider2.Visible = false;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(505, 262);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(27, 20);
            this.labelMin.TabIndex = 27;
            this.labelMin.Text = "00";
            this.labelMin.Visible = false;
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.Location = new System.Drawing.Point(536, 262);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(27, 20);
            this.labelSec.TabIndex = 28;
            this.labelSec.Text = "00";
            this.labelSec.Visible = false;
            // 
            // labelDivider1
            // 
            this.labelDivider1.AutoSize = true;
            this.labelDivider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivider1.Location = new System.Drawing.Point(496, 262);
            this.labelDivider1.Name = "labelDivider1";
            this.labelDivider1.Size = new System.Drawing.Size(13, 20);
            this.labelDivider1.TabIndex = 29;
            this.labelDivider1.Text = ":";
            this.labelDivider1.Visible = false;
            // 
            // labelCs
            // 
            this.labelCs.AutoSize = true;
            this.labelCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCs.Location = new System.Drawing.Point(566, 262);
            this.labelCs.Name = "labelCs";
            this.labelCs.Size = new System.Drawing.Size(27, 20);
            this.labelCs.TabIndex = 30;
            this.labelCs.Text = "00";
            this.labelCs.Visible = false;
            // 
            // labelDivider3
            // 
            this.labelDivider3.AutoSize = true;
            this.labelDivider3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivider3.Location = new System.Drawing.Point(557, 262);
            this.labelDivider3.Name = "labelDivider3";
            this.labelDivider3.Size = new System.Drawing.Size(13, 20);
            this.labelDivider3.TabIndex = 31;
            this.labelDivider3.Text = ".";
            this.labelDivider3.Visible = false;
            // 
            // SurviveTimer
            // 
            this.SurviveTimer.Enabled = true;
            this.SurviveTimer.Interval = 10;
            this.SurviveTimer.Tick += new System.EventHandler(this.SurviveTimer_Tick);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(387, 299);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(153, 40);
            this.buttonSettings.TabIndex = 52;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonResume.Location = new System.Drawing.Point(387, 248);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(153, 40);
            this.buttonResume.TabIndex = 54;
            this.buttonResume.TabStop = false;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Visible = false;
            this.buttonResume.Click += new System.EventHandler(this.ButtonResume_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Hendri_WAVOgame.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(40, 111);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 90);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            this.player.WaitOnLoad = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 126);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(198, -21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 126);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(394, -21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 126);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(584, -21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(200, 126);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Location = new System.Drawing.Point(746, -21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 126);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // FormWAVO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.labelDivider3);
            this.Controls.Add(this.labelCs);
            this.Controls.Add(this.labelDivider1);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelDivider2);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.labelTxtRound);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.labelSurviveTime);
            this.Controls.Add(this.labelTxtLives);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.txt_GameOver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWAVO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAVO";
            this.Load += new System.EventHandler(this.FormWAVO_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormWAVO_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormWAVO_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label labelTxtLives;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer carSlowGenerator;
        private System.Windows.Forms.Label labelSurviveTime;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelTxtRound;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label txt_GameOver;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Timer carSpeedGenerator;
        private System.Windows.Forms.Label labelDivider2;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelDivider1;
        private System.Windows.Forms.Label labelCs;
        private System.Windows.Forms.Label labelDivider3;
        private System.Windows.Forms.Timer SurviveTimer;
        public System.Windows.Forms.Timer moveRightTimer;
        public System.Windows.Forms.Timer moveLeftTimer;
        public System.Windows.Forms.Timer moveUpTimer;
        public System.Windows.Forms.Timer moveDownTimer;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonResume;
    }
}

