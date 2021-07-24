namespace Hendri_WAVOgame
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelGameSound = new System.Windows.Forms.Label();
            this.trackBarGameSound = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarSoundEffect = new System.Windows.Forms.TrackBar();
            this.labelSoundEffect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoundEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Settings";
            // 
            // labelGameSound
            // 
            this.labelGameSound.AutoSize = true;
            this.labelGameSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGameSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameSound.ForeColor = System.Drawing.Color.White;
            this.labelGameSound.Location = new System.Drawing.Point(265, 93);
            this.labelGameSound.Name = "labelGameSound";
            this.labelGameSound.Size = new System.Drawing.Size(18, 19);
            this.labelGameSound.TabIndex = 1;
            this.labelGameSound.Text = "0";
            // 
            // trackBarGameSound
            // 
            this.trackBarGameSound.BackColor = System.Drawing.Color.DarkSlateGray;
            this.trackBarGameSound.Location = new System.Drawing.Point(12, 82);
            this.trackBarGameSound.Maximum = 100;
            this.trackBarGameSound.Name = "trackBarGameSound";
            this.trackBarGameSound.Size = new System.Drawing.Size(253, 45);
            this.trackBarGameSound.TabIndex = 2;
            this.trackBarGameSound.TickFrequency = 10;
            this.trackBarGameSound.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGameSound.Scroll += new System.EventHandler(this.TrackBarGameSound_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Game Sound";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sound Effect";
            // 
            // trackBarSoundEffect
            // 
            this.trackBarSoundEffect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.trackBarSoundEffect.Location = new System.Drawing.Point(12, 168);
            this.trackBarSoundEffect.Maximum = 100;
            this.trackBarSoundEffect.Name = "trackBarSoundEffect";
            this.trackBarSoundEffect.Size = new System.Drawing.Size(253, 45);
            this.trackBarSoundEffect.TabIndex = 5;
            this.trackBarSoundEffect.TickFrequency = 10;
            this.trackBarSoundEffect.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarSoundEffect.Scroll += new System.EventHandler(this.TrackBarSoundEffect_Scroll);
            // 
            // labelSoundEffect
            // 
            this.labelSoundEffect.AutoSize = true;
            this.labelSoundEffect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSoundEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoundEffect.ForeColor = System.Drawing.Color.White;
            this.labelSoundEffect.Location = new System.Drawing.Point(265, 179);
            this.labelSoundEffect.Name = "labelSoundEffect";
            this.labelSoundEffect.Size = new System.Drawing.Size(18, 19);
            this.labelSoundEffect.TabIndex = 6;
            this.labelSoundEffect.Text = "0";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(313, 234);
            this.Controls.Add(this.labelSoundEffect);
            this.Controls.Add(this.trackBarSoundEffect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarGameSound);
            this.Controls.Add(this.labelGameSound);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGameSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSoundEffect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGameSound;
        private System.Windows.Forms.TrackBar trackBarGameSound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarSoundEffect;
        private System.Windows.Forms.Label labelSoundEffect;
    }
}