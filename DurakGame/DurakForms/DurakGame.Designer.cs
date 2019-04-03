namespace DurakForms
{
    partial class frmDurakGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDurakGame));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.gbxAttacker = new System.Windows.Forms.GroupBox();
            this.pnlAttacker = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.gbxPlay = new System.Windows.Forms.GroupBox();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.pnlDefender = new System.Windows.Forms.Panel();
            this.gbxDefender = new System.Windows.Forms.GroupBox();
            this.pbDiscard = new System.Windows.Forms.PictureBox();
            this.lblCardCount = new System.Windows.Forms.Label();
            this.lblDiscard = new System.Windows.Forms.Label();
            this.gbxAttacker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            this.gbxPlay.SuspendLayout();
            this.gbxDefender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(3, 12);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(117, 42);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "&Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // gbxAttacker
            // 
            this.gbxAttacker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAttacker.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxAttacker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxAttacker.Controls.Add(this.pnlAttacker);
            this.gbxAttacker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAttacker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAttacker.ForeColor = System.Drawing.Color.Aqua;
            this.gbxAttacker.Location = new System.Drawing.Point(287, 12);
            this.gbxAttacker.Name = "gbxAttacker";
            this.gbxAttacker.Size = new System.Drawing.Size(498, 157);
            this.gbxAttacker.TabIndex = 0;
            this.gbxAttacker.TabStop = false;
            this.gbxAttacker.Text = "Attacker";
            // 
            // pnlAttacker
            // 
            this.pnlAttacker.Location = new System.Drawing.Point(1, 19);
            this.pnlAttacker.Name = "pnlAttacker";
            this.pnlAttacker.Size = new System.Drawing.Size(499, 137);
            this.pnlAttacker.TabIndex = 0;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(138, 12);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 38);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pbDeck
            // 
            this.pbDeck.Location = new System.Drawing.Point(72, 112);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(100, 137);
            this.pbDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDeck.TabIndex = 9;
            this.pbDeck.TabStop = false;
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // gbxPlay
            // 
            this.gbxPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPlay.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxPlay.Controls.Add(this.pnlPlay);
            this.gbxPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPlay.ForeColor = System.Drawing.Color.Aqua;
            this.gbxPlay.Location = new System.Drawing.Point(288, 175);
            this.gbxPlay.Name = "gbxPlay";
            this.gbxPlay.Size = new System.Drawing.Size(498, 157);
            this.gbxPlay.TabIndex = 10;
            this.gbxPlay.TabStop = false;
            this.gbxPlay.Text = "Play Area";
            // 
            // pnlPlay
            // 
            this.pnlPlay.Location = new System.Drawing.Point(1, 19);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(499, 137);
            this.pnlPlay.TabIndex = 0;
            // 
            // pnlDefender
            // 
            this.pnlDefender.Location = new System.Drawing.Point(0, 20);
            this.pnlDefender.Name = "pnlDefender";
            this.pnlDefender.Size = new System.Drawing.Size(500, 135);
            this.pnlDefender.TabIndex = 1;
            // 
            // gbxDefender
            // 
            this.gbxDefender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDefender.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxDefender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDefender.Controls.Add(this.pnlDefender);
            this.gbxDefender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxDefender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDefender.ForeColor = System.Drawing.Color.Cyan;
            this.gbxDefender.Location = new System.Drawing.Point(287, 330);
            this.gbxDefender.Name = "gbxDefender";
            this.gbxDefender.Size = new System.Drawing.Size(498, 157);
            this.gbxDefender.TabIndex = 0;
            this.gbxDefender.TabStop = false;
            this.gbxDefender.Text = "Defender";
            // 
            // pbDiscard
            // 
            this.pbDiscard.Location = new System.Drawing.Point(72, 350);
            this.pbDiscard.Name = "pbDiscard";
            this.pbDiscard.Size = new System.Drawing.Size(100, 137);
            this.pbDiscard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscard.TabIndex = 11;
            this.pbDiscard.TabStop = false;
            // 
            // lblCardCount
            // 
            this.lblCardCount.AutoSize = true;
            this.lblCardCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardCount.ForeColor = System.Drawing.Color.Aqua;
            this.lblCardCount.Location = new System.Drawing.Point(92, 67);
            this.lblCardCount.Name = "lblCardCount";
            this.lblCardCount.Size = new System.Drawing.Size(62, 42);
            this.lblCardCount.TabIndex = 12;
            this.lblCardCount.Text = "88";
            // 
            // lblDiscard
            // 
            this.lblDiscard.AutoSize = true;
            this.lblDiscard.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscard.ForeColor = System.Drawing.Color.Aqua;
            this.lblDiscard.Location = new System.Drawing.Point(37, 322);
            this.lblDiscard.Name = "lblDiscard";
            this.lblDiscard.Size = new System.Drawing.Size(172, 25);
            this.lblDiscard.TabIndex = 13;
            this.lblDiscard.Text = "Discarded Cards";
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 499);
            this.Controls.Add(this.lblDiscard);
            this.Controls.Add(this.lblCardCount);
            this.Controls.Add(this.pbDiscard);
            this.Controls.Add(this.gbxPlay);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbxDefender);
            this.Controls.Add(this.gbxAttacker);
            this.Controls.Add(this.btnMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDurakGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmDurakGame_Load);
            this.gbxAttacker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            this.gbxPlay.ResumeLayout(false);
            this.gbxDefender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox gbxAttacker;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlAttacker;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.GroupBox gbxPlay;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Panel pnlDefender;
        private System.Windows.Forms.GroupBox gbxDefender;
        private System.Windows.Forms.PictureBox pbDiscard;
        private System.Windows.Forms.Label lblCardCount;
        private System.Windows.Forms.Label lblDiscard;
    }
}