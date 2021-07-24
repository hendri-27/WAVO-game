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
    public partial class FormMainMenu : Form
    {
        Thread th;
        string resourcesPath = Application.StartupPath + "\\Resources\\";
        public WindowsMediaPlayer gameSound = new WindowsMediaPlayer();


        public int volumeGameSound = 80;
        public int volumeSoundEffect = 70;

        public FormMainMenu()
        {
            InitializeComponent();
            userControlHowToPlay.Hide();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            gameSound.settings.volume = volumeGameSound;
            gameSound.controls.play();
            gameSound.settings.setMode("loop", true);
            gameSound.URL = resourcesPath + "Tetris 99.mp3";
        }

        private void ButtonNewGame_Click(object sender, EventArgs e)
        {
            userControlHowToPlay.Show();
            buttonContinue.Visible = true;
            buttonContinue.BringToFront();
        }

        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            gameSound.controls.pause();
            this.Close();
            th = new Thread(OpenNewForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewForm(object obj)
        {
            FormWAVO formWAVO = new FormWAVO();
            formWAVO.SaveSettings(volumeGameSound, volumeSoundEffect);
            Application.Run(formWAVO);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Owner = this;
            formSettings.ShowDialog();
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to leave the game?", "Quit the game", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        public void SaveSettings(int soundGame, int effectSound)
        {
            volumeGameSound = soundGame;
            volumeSoundEffect = effectSound;
        }

    }
}
