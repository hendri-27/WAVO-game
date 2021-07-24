namespace Hendri_WAVOgame
{
    partial class FormMainMenu
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.userControlHowToPlay = new Hendri_WAVOgame.UserControlHowToPlay();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Yellow;
            this.labelTitle.Location = new System.Drawing.Point(397, 169);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(153, 16);
            this.labelTitle.TabIndex = 53;
            this.labelTitle.Text = "Walk Avoid Obstacle";
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.AutoSize = true;
            this.labelMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.labelMainMenu.Font = new System.Drawing.Font("Jokerman", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.ForeColor = System.Drawing.Color.White;
            this.labelMainMenu.Location = new System.Drawing.Point(365, 96);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(214, 79);
            this.labelMainMenu.TabIndex = 49;
            this.labelMainMenu.Text = "WAVO";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.Color.Maroon;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.White;
            this.buttonNewGame.Location = new System.Drawing.Point(396, 216);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(153, 40);
            this.buttonNewGame.TabIndex = 50;
            this.buttonNewGame.TabStop = false;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.ButtonNewGame_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Location = new System.Drawing.Point(396, 268);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(153, 40);
            this.buttonSettings.TabIndex = 51;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Black;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.White;
            this.buttonQuit.Location = new System.Drawing.Point(396, 324);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(153, 40);
            this.buttonQuit.TabIndex = 52;
            this.buttonQuit.TabStop = false;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Made by: Hendri";
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonContinue.Location = new System.Drawing.Point(418, 406);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(112, 43);
            this.buttonContinue.TabIndex = 57;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Visible = false;
            this.buttonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            // 
            // userControlHowToPlay
            // 
            this.userControlHowToPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userControlHowToPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlHowToPlay.Location = new System.Drawing.Point(0, 0);
            this.userControlHowToPlay.Name = "userControlHowToPlay";
            this.userControlHowToPlay.Size = new System.Drawing.Size(944, 461);
            this.userControlHowToPlay.TabIndex = 58;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hendri_WAVOgame.Properties.Resources.dark_grey_background;
            this.ClientSize = new System.Drawing.Size(944, 461);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.userControlHowToPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonQuit);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonContinue;
        private UserControlHowToPlay userControlHowToPlay;
    }
}