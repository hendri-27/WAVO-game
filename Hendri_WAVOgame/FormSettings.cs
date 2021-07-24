using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hendri_WAVOgame
{
    public partial class FormSettings : Form
    {
        FormMainMenu formMainMenu = null;
        FormWAVO formWAVO = null;
        int volumeGame;
        int effectGame;
        bool Getaccess = false;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            if (!Getaccess)
            {
                formMainMenu = (FormMainMenu)this.Owner;

                volumeGame = formMainMenu.volumeGameSound;
                effectGame = formMainMenu.volumeSoundEffect;
            }
            else
            {
                formWAVO = (FormWAVO)this.Owner;

                volumeGame = formWAVO.soundGame;
                effectGame = formWAVO.effectSound;
            }
                trackBarGameSound.Value = volumeGame;
                labelGameSound.Text = volumeGame.ToString();

                trackBarSoundEffect.Value = effectGame;
                labelSoundEffect.Text = effectGame.ToString();
        }

        private void TrackBarGameSound_Scroll(object sender, EventArgs e)
        {
            if (!Getaccess)
            {
                formMainMenu.volumeGameSound = formMainMenu.gameSound.settings.volume = trackBarGameSound.Value;
            }
            else
            {
                formWAVO.gameSound.settings.volume = formWAVO.soundGame = trackBarGameSound.Value;
            }
            labelGameSound.Text = trackBarGameSound.Value.ToString();
        }

        private void TrackBarSoundEffect_Scroll(object sender, EventArgs e)
        {
            if (!Getaccess)
            {
                formMainMenu.volumeSoundEffect = trackBarSoundEffect.Value;
            }
            else
            {
                formWAVO.soundEffect.settings.volume = formWAVO.effectSound = trackBarSoundEffect.Value;
            }
            labelSoundEffect.Text = trackBarSoundEffect.Value.ToString();
        }

        public void GetSettingsFromWAVO(int soundGame, int effectSound)
        {
            Getaccess = true;
        }
    }
}
