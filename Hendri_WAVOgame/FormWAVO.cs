// Created BY : Hendri Antonius

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace Hendri_WAVOgame
{
    public partial class FormWAVO : Form
    {
        Thread th;

        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer gameSound = new WindowsMediaPlayer();
        public WindowsMediaPlayer soundEffect = new WindowsMediaPlayer();

        public int soundGame;
        public int effectSound;

        bool gameIsOver;
        bool pauseGame;
        int userLives;
        int timeLeft;
        int round;
        int carSlowSpeed;
        int carFastSpeed;
        int carMax;
        int timeCs;
        int timeSec;
        int timeMin;
        int timeHour;

        List<PictureBox> listOfCar = new List<PictureBox>();
        List<PictureBox> listOfLives = new List<PictureBox>();

        Random generator = new Random();

        public FormWAVO()
        {
            InitializeComponent();
        }


        private void FormWAVO_Load(object sender, EventArgs e)
        {
            gameSound.settings.volume = soundGame;
            soundEffect.settings.volume = effectSound;
            gameSound.settings.setMode("loop", true);
            gameSound.URL = resourcesPath + "Throwback Galaxy.mp3";
            this.DoubleBuffered = true;

            // init variabel
            const int MAX_USER_LIVES = 5;

            gameIsOver = false;
            pauseGame = false;
            userLives = MAX_USER_LIVES;
            timeLeft = 30;
            round = 1;
            carSlowSpeed = 8;
            carFastSpeed = 15;
            carMax = 3;
            timeCs = timeSec = timeMin = timeHour = 0;

            // health player
            LivesGenerator();
        }

        // generating health player
        private void LivesGenerator()
        {
            for(int i = 0; i < 5; i++)
            {
                PictureBox heart = new PictureBox();
                heart.Location = new Point(904 - (i * 26), 9);
                heart.Size = new Size(20, 20);
                heart.Image = Properties.Resources.heart;
                heart.BackColor = Color.Transparent;
                heart.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(heart);
                heart.BringToFront();
                listOfLives.Add(heart);
            }
        }

        // Player move right button
        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (player.Left < 900)
            {
                player.Left += 4;
            }
        }

        // Player move left button
        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if(player.Left > 10)
            {
                player.Left -= 4;
            }
        }
        
        // Player move up button
        private void MoveUpTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top <= 371 && player.Top > 111)
            {
                player.Top -= 130;
                moveUpTimer.Stop();
            }
        }

        // Player move down button
        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            if (player.Top >= 111 && player.Top < 271)
            {
                player.Top += 130;
                moveDownTimer.Stop();
            }
        }

        // When player button pressed
        private void FormWAVO_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pauseGame)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    moveDownTimer.Start();
                }
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    moveUpTimer.Start();
                }
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    moveRightTimer.Start();
                }
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    moveLeftTimer.Start();
                }
            }
        }

        // When player button not pressed
        private void FormWAVO_KeyUp(object sender, KeyEventArgs e)
        {
            moveUpTimer.Stop();
            moveDownTimer.Stop();
            moveLeftTimer.Stop();
            moveRightTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameIsOver)
                {
                    if (!pauseGame)
                    {
                        gameSound.controls.pause();
                        txt_GameOver.Location = new Point(220, 150);
                        txt_GameOver.Text = "GAME PAUSED";
                        txt_GameOver.Visible = buttonResume.Visible = buttonBackToMainMenu.Visible = buttonSettings.Visible = true;
                        txt_GameOver.BringToFront();
                        pauseGame = true;
                        StopTimers();
                    }
                }
            }
        }

        // Car slow generator
        private void CarSlowGenerator_Tick(object sender, EventArgs e)
        {
            if (listOfCar.Count <= carMax)
            {
                PictureBox carSlow = new PictureBox();

                int carTop = generator.Next(1, 4) * 130;
                carSlow.Image = Properties.Resources.carSlow;
                carSlow.Size = new Size(200, 71);
                carSlow.BackColor = Color.Transparent;
                carSlow.SizeMode = PictureBoxSizeMode.Zoom;
                carSlow.BringToFront();
                carSlow.Top = carTop;
                carSlow.Left = 1050;
                carSlow.Tag = carSlowSpeed;

                this.Controls.Add(carSlow);
                listOfCar.Add(carSlow);
            }
            else
            {
                carSlowGenerator.Stop();
            }
        }

        // Car fast generator
        private void CarSpeedGenerator_Tick(object sender, EventArgs e)
        {
            PictureBox carFast = new PictureBox();

            int carTop = generator.Next(1, 4) * 130;
            carFast.Image = Properties.Resources.carFast;
            carFast.Size = new Size(200, 71);
            carFast.BackColor = Color.Transparent;
            carFast.SizeMode = PictureBoxSizeMode.Zoom;
            carFast.BringToFront();
            carFast.Top = carTop;
            carFast.Left = 1050;
            carFast.Tag = carFastSpeed;

            this.Controls.Add(carFast);
            listOfCar.Add(carFast);
            carSpeedGenerator.Stop();
        }

        // Game in real time
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Refresh car so can move to another animation
            for (int i = 0; i<listOfCar.Count;i++)
            {
                
                listOfCar[i].Left -= (int)listOfCar[i].Tag;

                if(listOfCar[i].Left < -200)
                {
                    listOfCar[i].Dispose();
                    listOfCar.RemoveAt(i);

                    carSlowGenerator.Start();
                    carSpeedGenerator.Start();
                    
                }
                else
                {
                    listOfCar[i].Refresh();
                }
            }

            // When car and player crashed
            for(int i = 0; i < listOfCar.Count; i++)
            {
                if (listOfCar[i].Bounds.IntersectsWith(player.Bounds))
                {
                    userLives--;
                    listOfLives[0].Dispose();
                    listOfLives.RemoveAt(0);


                    listOfCar[i].Dispose();
                    listOfCar.RemoveAt(i);

                    carSlowGenerator.Start();
                    carSpeedGenerator.Start();

                    if (userLives <= 0)
                    {
                        GameOver("Game Over");
                    }
                }
            }
        }

        // Timer for next round and update the hard core
        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
            if(timeLeft > 0)
            {
                timeLeft -= 1;
            }
            else
            {
                timeLeft = 30;
                timerCountdown.Start();
                round += 1;
                labelRound.Text = round.ToString();
                carSlowSpeed++;
                carFastSpeed++;
                carMax+=2;
                if (round%3 == 0)
                {
                    carMax += 3;
                    carSlowGenerator.Interval -= 100;
                    if(carSlowGenerator.Interval == 0)
                    {
                        MessageBox.Show("Thank You For Playing", "Last Stage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GameOver("Game Over");
                    }
                }
                else if (round%5 == 0)
                {
                    carFastSpeed += 5;
                    carSpeedGenerator.Interval -= 1000;
                }
            }
        }

        // If game over go in here
        private void GameOver (String str)
        {
            txt_GameOver.Location = new Point(277, 172);
            txt_GameOver.Text = str.Trim();
            txt_GameOver.Visible = true;
            gameIsOver = true;
            pauseGame = true;
            player.Visible = false;
            buttonRestart.Visible = true;
            buttonBackToMainMenu.Visible = labelDivider1.Visible = labelDivider2.Visible = labelDivider3.Visible = true;
            labelSurviveTime.Visible = labelHour.Visible = labelMin.Visible = labelSec.Visible = labelCs.Visible = true;
            StopTimers();
        }

        // All timers gather here for stoppping game
        private void StopTimers()
        {
            carSlowGenerator.Stop();
            carSpeedGenerator.Stop();
            timerCountdown.Stop();
            gameTimer.Stop();
            SurviveTimer.Stop();
        }

        // All timers gather here for starting game
        private void StartTimers()
        {
            carSlowGenerator.Start();
            carSpeedGenerator.Start();
            timerCountdown.Start();
            gameTimer.Start();
            SurviveTimer.Start();
        }

        // Restart the game and reset all
        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            gameSound.controls.pause();
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewForm()
        {
            FormWAVO formWAVO = new FormWAVO();
            formWAVO.SaveSettings(soundGame, effectSound);
            Application.Run(formWAVO);
        }

        private void ButtonBackToMainMenu_Click(object sender, EventArgs e)
        {
            if(!gameIsOver)
            {
                if(MessageBox.Show("Are you sure to leave this game?","Game is Running", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SettingBackToMenu();
                }
            }
            else
            {
                SettingBackToMenu();
            }
        }

        private void SettingBackToMenu()
        {
            gameSound.controls.pause();
            this.Close();
            th = new Thread(BackToMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BackToMenu()
        {
            FormMainMenu formMainMenu = new FormMainMenu();
            formMainMenu.SaveSettings(soundGame, effectSound);
            Application.Run(formMainMenu);
        }

        // Timer for survive time
        private void SurviveTimer_Tick(object sender, EventArgs e)
        {
            if(!pauseGame)
            {
                timeCs++;
                if (timeCs >= 100) 
                {
                    timeSec++;
                    timeCs = 0;

                    if (timeSec >= 60)
                    {
                        timeMin++;
                        timeSec = 0;

                        if(timeMin >= 60)
                        {
                            timeHour++;
                            timeMin = 0;
                        }
                    }
                }
            }
            DrawTime();
        }

        // Writing the time of survive
        private void DrawTime ()
        {
            labelCs.Text = String.Format("{0:00}",timeCs);
            labelSec.Text = String.Format("{0:00}",timeSec);
            labelMin.Text = String.Format("{0:00}", timeMin);
            labelHour.Text = String.Format("{0:00}", timeHour);
        }

        public void SaveSettings(int volumeGameSound, int volumeSoundEffect)
        {
            soundGame = volumeGameSound;
            effectSound = volumeSoundEffect;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.GetSettingsFromWAVO(soundGame, effectSound);
            formSettings.Owner = this;
            formSettings.ShowDialog();
        }

        private void ButtonResume_Click(object sender, EventArgs e)
        {
            gameSound.controls.play();
            txt_GameOver.Visible = buttonResume.Visible = buttonBackToMainMenu.Visible = buttonSettings.Visible = false;
            pauseGame = false;
            StartTimers();
            this.Focus();
        }
    }
}
