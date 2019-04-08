namespace DurakForms
{
    partial class DurakMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DurakMain));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxDifficulty = new System.Windows.Forms.GroupBox();
            this.rdoHard = new System.Windows.Forms.RadioButton();
            this.rdoModerate = new System.Windows.Forms.RadioButton();
            this.rdoEasy = new System.Windows.Forms.RadioButton();
            this.gbxCardNum = new System.Windows.Forms.GroupBox();
            this.rdo52 = new System.Windows.Forms.RadioButton();
            this.rdo36 = new System.Windows.Forms.RadioButton();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.DurakTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxDifficulty.SuspendLayout();
            this.gbxCardNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitle.Location = new System.Drawing.Point(173, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(476, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome To Durak!";
            // 
            // gbxDifficulty
            // 
            this.gbxDifficulty.Controls.Add(this.rdoHard);
            this.gbxDifficulty.Controls.Add(this.rdoModerate);
            this.gbxDifficulty.Controls.Add(this.rdoEasy);
            this.gbxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDifficulty.Location = new System.Drawing.Point(101, 133);
            this.gbxDifficulty.Name = "gbxDifficulty";
            this.gbxDifficulty.Size = new System.Drawing.Size(277, 214);
            this.gbxDifficulty.TabIndex = 0;
            this.gbxDifficulty.TabStop = false;
            this.gbxDifficulty.Text = "&Difficulty: ";
            this.DurakTip.SetToolTip(this.gbxDifficulty, "Select Difficulty Level");
            // 
            // rdoHard
            // 
            this.rdoHard.AutoSize = true;
            this.rdoHard.Enabled = false;
            this.rdoHard.Location = new System.Drawing.Point(48, 144);
            this.rdoHard.Name = "rdoHard";
            this.rdoHard.Size = new System.Drawing.Size(76, 29);
            this.rdoHard.TabIndex = 3;
            this.rdoHard.Text = "Hard";
            this.DurakTip.SetToolTip(this.rdoHard, "Hard difficulty level");
            this.rdoHard.UseVisualStyleBackColor = true;
            // 
            // rdoModerate
            // 
            this.rdoModerate.AutoSize = true;
            this.rdoModerate.Checked = true;
            this.rdoModerate.Location = new System.Drawing.Point(46, 92);
            this.rdoModerate.Name = "rdoModerate";
            this.rdoModerate.Size = new System.Drawing.Size(121, 29);
            this.rdoModerate.TabIndex = 2;
            this.rdoModerate.TabStop = true;
            this.rdoModerate.Text = "Moderate";
            this.DurakTip.SetToolTip(this.rdoModerate, "Moderate difficulty level");
            this.rdoModerate.UseVisualStyleBackColor = true;
            // 
            // rdoEasy
            // 
            this.rdoEasy.AutoSize = true;
            this.rdoEasy.Location = new System.Drawing.Point(46, 43);
            this.rdoEasy.Name = "rdoEasy";
            this.rdoEasy.Size = new System.Drawing.Size(78, 29);
            this.rdoEasy.TabIndex = 1;
            this.rdoEasy.Text = "Easy";
            this.DurakTip.SetToolTip(this.rdoEasy, "Easy difficulty level");
            this.rdoEasy.UseVisualStyleBackColor = true;
            // 
            // gbxCardNum
            // 
            this.gbxCardNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCardNum.Controls.Add(this.rdo52);
            this.gbxCardNum.Controls.Add(this.rdo36);
            this.gbxCardNum.Controls.Add(this.rdo20);
            this.gbxCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCardNum.Location = new System.Drawing.Point(447, 133);
            this.gbxCardNum.Name = "gbxCardNum";
            this.gbxCardNum.Size = new System.Drawing.Size(278, 214);
            this.gbxCardNum.TabIndex = 7;
            this.gbxCardNum.TabStop = false;
            this.gbxCardNum.Text = "Number Of Cards:";
            this.DurakTip.SetToolTip(this.gbxCardNum, "Choose Number of Cards to play with.");
            // 
            // rdo52
            // 
            this.rdo52.AutoSize = true;
            this.rdo52.Location = new System.Drawing.Point(52, 144);
            this.rdo52.Name = "rdo52";
            this.rdo52.Size = new System.Drawing.Size(54, 29);
            this.rdo52.TabIndex = 6;
            this.rdo52.Text = "52";
            this.DurakTip.SetToolTip(this.rdo52, "Play with 52 cards.");
            this.rdo52.UseVisualStyleBackColor = true;
            // 
            // rdo36
            // 
            this.rdo36.AutoSize = true;
            this.rdo36.Checked = true;
            this.rdo36.Location = new System.Drawing.Point(52, 92);
            this.rdo36.Name = "rdo36";
            this.rdo36.Size = new System.Drawing.Size(54, 29);
            this.rdo36.TabIndex = 5;
            this.rdo36.TabStop = true;
            this.rdo36.Text = "36";
            this.DurakTip.SetToolTip(this.rdo36, "Play with 36 cards.");
            this.rdo36.UseVisualStyleBackColor = true;
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Location = new System.Drawing.Point(52, 43);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(54, 29);
            this.rdo20.TabIndex = 4;
            this.rdo20.Text = "20";
            this.DurakTip.SetToolTip(this.rdo20, "Play with 20 cards.");
            this.rdo20.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(181, 370);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 40);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.DurakTip.SetToolTip(this.btnQuit, "Click To Exit Game");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(366, 370);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(107, 40);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "&About";
            this.DurakTip.SetToolTip(this.btnAbout, "How to play DURAK game");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(562, 370);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(107, 40);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "&Play";
            this.DurakTip.SetToolTip(this.btnPlay, "Click to Play Game");
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // DurakTip
            // 
            this.DurakTip.ToolTipTitle = "Durak Tip";
            // 
            // DurakMain
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(844, 454);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbxCardNum);
            this.Controls.Add(this.gbxDifficulty);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(596, 410);
            this.Name = "DurakMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DURAK GAME";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.gbxDifficulty.ResumeLayout(false);
            this.gbxDifficulty.PerformLayout();
            this.gbxCardNum.ResumeLayout(false);
            this.gbxCardNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxDifficulty;
        private System.Windows.Forms.RadioButton rdoHard;
        private System.Windows.Forms.RadioButton rdoModerate;
        private System.Windows.Forms.RadioButton rdoEasy;
        private System.Windows.Forms.GroupBox gbxCardNum;
        private System.Windows.Forms.RadioButton rdo52;
        private System.Windows.Forms.RadioButton rdo36;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ToolTip DurakTip;
    }
}

