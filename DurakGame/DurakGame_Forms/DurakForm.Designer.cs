namespace DurakGame_Client
{
    partial class frmDurak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDurak));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxCardNum = new System.Windows.Forms.GroupBox();
            this.lblCardNum = new System.Windows.Forms.Label();
            this.rdo52 = new System.Windows.Forms.RadioButton();
            this.rdo36 = new System.Windows.Forms.RadioButton();
            this.rdo20 = new System.Windows.Forms.RadioButton();
            this.gbxDifficulty = new System.Windows.Forms.GroupBox();
            this.rdoHard = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoEasy = new System.Windows.Forms.RadioButton();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHowTo = new System.Windows.Forms.Button();
            this.gbxCardNum.SuspendLayout();
            this.gbxDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(249, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(724, 97);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Durak!";
            // 
            // gbxCardNum
            // 
            this.gbxCardNum.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxCardNum.Controls.Add(this.lblCardNum);
            this.gbxCardNum.Controls.Add(this.rdo52);
            this.gbxCardNum.Controls.Add(this.rdo36);
            this.gbxCardNum.Controls.Add(this.rdo20);
            this.gbxCardNum.Location = new System.Drawing.Point(678, 109);
            this.gbxCardNum.Name = "gbxCardNum";
            this.gbxCardNum.Size = new System.Drawing.Size(400, 210);
            this.gbxCardNum.TabIndex = 1;
            this.gbxCardNum.TabStop = false;
            // 
            // lblCardNum
            // 
            this.lblCardNum.AutoSize = true;
            this.lblCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNum.Location = new System.Drawing.Point(6, 18);
            this.lblCardNum.Name = "lblCardNum";
            this.lblCardNum.Size = new System.Drawing.Size(323, 46);
            this.lblCardNum.TabIndex = 7;
            this.lblCardNum.Text = "Number of Cards";
            // 
            // rdo52
            // 
            this.rdo52.AutoSize = true;
            this.rdo52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo52.Location = new System.Drawing.Point(17, 178);
            this.rdo52.Name = "rdo52";
            this.rdo52.Size = new System.Drawing.Size(55, 29);
            this.rdo52.TabIndex = 6;
            this.rdo52.TabStop = true;
            this.rdo52.Text = "52";
            this.rdo52.UseVisualStyleBackColor = true;
            // 
            // rdo36
            // 
            this.rdo36.AutoSize = true;
            this.rdo36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo36.Location = new System.Drawing.Point(17, 136);
            this.rdo36.Name = "rdo36";
            this.rdo36.Size = new System.Drawing.Size(55, 29);
            this.rdo36.TabIndex = 5;
            this.rdo36.TabStop = true;
            this.rdo36.Text = "36";
            this.rdo36.UseVisualStyleBackColor = true;
            // 
            // rdo20
            // 
            this.rdo20.AutoSize = true;
            this.rdo20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo20.Location = new System.Drawing.Point(17, 93);
            this.rdo20.Name = "rdo20";
            this.rdo20.Size = new System.Drawing.Size(55, 29);
            this.rdo20.TabIndex = 4;
            this.rdo20.TabStop = true;
            this.rdo20.Text = "20";
            this.rdo20.UseVisualStyleBackColor = true;
            // 
            // gbxDifficulty
            // 
            this.gbxDifficulty.BackColor = System.Drawing.Color.Gainsboro;
            this.gbxDifficulty.Controls.Add(this.rdoHard);
            this.gbxDifficulty.Controls.Add(this.rdoMedium);
            this.gbxDifficulty.Controls.Add(this.rdoEasy);
            this.gbxDifficulty.Controls.Add(this.lblDifficulty);
            this.gbxDifficulty.Location = new System.Drawing.Point(157, 109);
            this.gbxDifficulty.Name = "gbxDifficulty";
            this.gbxDifficulty.Size = new System.Drawing.Size(400, 210);
            this.gbxDifficulty.TabIndex = 2;
            this.gbxDifficulty.TabStop = false;
            // 
            // rdoHard
            // 
            this.rdoHard.AutoSize = true;
            this.rdoHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHard.Location = new System.Drawing.Point(14, 178);
            this.rdoHard.Name = "rdoHard";
            this.rdoHard.Size = new System.Drawing.Size(75, 29);
            this.rdoHard.TabIndex = 3;
            this.rdoHard.TabStop = true;
            this.rdoHard.Text = "Hard";
            this.rdoHard.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMedium.Location = new System.Drawing.Point(14, 136);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(103, 29);
            this.rdoMedium.TabIndex = 2;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoEasy
            // 
            this.rdoEasy.AutoSize = true;
            this.rdoEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEasy.Location = new System.Drawing.Point(14, 93);
            this.rdoEasy.Name = "rdoEasy";
            this.rdoEasy.Size = new System.Drawing.Size(77, 29);
            this.rdoEasy.TabIndex = 1;
            this.rdoEasy.TabStop = true;
            this.rdoEasy.Text = "Easy";
            this.rdoEasy.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(6, 18);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(172, 46);
            this.lblDifficulty.TabIndex = 0;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(349, 347);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(169, 50);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(712, 347);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(169, 50);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // btnHowTo
            // 
            this.btnHowTo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowTo.Location = new System.Drawing.Point(516, 432);
            this.btnHowTo.Name = "btnHowTo";
            this.btnHowTo.Size = new System.Drawing.Size(212, 50);
            this.btnHowTo.TabIndex = 5;
            this.btnHowTo.Text = "How To Play";
            this.btnHowTo.UseVisualStyleBackColor = false;
            // 
            // frmDurak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakGame_Forms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 494);
            this.Controls.Add(this.btnHowTo);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gbxDifficulty);
            this.Controls.Add(this.gbxCardNum);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1213, 541);
            this.MinimumSize = new System.Drawing.Size(1213, 541);
            this.Name = "frmDurak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak";
            this.gbxCardNum.ResumeLayout(false);
            this.gbxCardNum.PerformLayout();
            this.gbxDifficulty.ResumeLayout(false);
            this.gbxDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxCardNum;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.RadioButton rdo52;
        private System.Windows.Forms.RadioButton rdo36;
        private System.Windows.Forms.RadioButton rdo20;
        private System.Windows.Forms.GroupBox gbxDifficulty;
        private System.Windows.Forms.RadioButton rdoHard;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoEasy;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHowTo;
    }
}