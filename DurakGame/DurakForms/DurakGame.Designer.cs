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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDurakGame));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.gbxComputer = new System.Windows.Forms.GroupBox();
            this.pnlCPU = new System.Windows.Forms.Panel();
            this.gbxHuman = new System.Windows.Forms.GroupBox();
            this.pnlHuman = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTalonCount = new System.Windows.Forms.Label();
            this.gbxRiver = new System.Windows.Forms.GroupBox();
            this.pnlRiver = new System.Windows.Forms.Panel();
            this.DurakTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxComputer.SuspendLayout();
            this.gbxHuman.SuspendLayout();
            this.gbxRiver.SuspendLayout();
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
            this.DurakTip.SetToolTip(this.btnMainMenu, "click to Go back to main menu");
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // gbxComputer
            // 
            this.gbxComputer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxComputer.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxComputer.Controls.Add(this.pnlCPU);
            this.gbxComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxComputer.ForeColor = System.Drawing.Color.Aqua;
            this.gbxComputer.Location = new System.Drawing.Point(147, 12);
            this.gbxComputer.Name = "gbxComputer";
            this.gbxComputer.Size = new System.Drawing.Size(641, 144);
            this.gbxComputer.TabIndex = 0;
            this.gbxComputer.TabStop = false;
            this.gbxComputer.Text = "Defender";
            // 
            // pnlCPU
            // 
            this.pnlCPU.Location = new System.Drawing.Point(1, 19);
            this.pnlCPU.Name = "pnlCPU";
            this.pnlCPU.Size = new System.Drawing.Size(640, 122);
            this.pnlCPU.TabIndex = 0;
            this.DurakTip.SetToolTip(this.pnlCPU, "Cards For Defender");
            // 
            // gbxHuman
            // 
            this.gbxHuman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxHuman.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxHuman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxHuman.Controls.Add(this.pnlHuman);
            this.gbxHuman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbxHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHuman.ForeColor = System.Drawing.Color.Cyan;
            this.gbxHuman.Location = new System.Drawing.Point(147, 311);
            this.gbxHuman.Name = "gbxHuman";
            this.gbxHuman.Size = new System.Drawing.Size(641, 145);
            this.gbxHuman.TabIndex = 0;
            this.gbxHuman.TabStop = false;
            this.gbxHuman.Text = "Attacker";
            // 
            // pnlHuman
            // 
            this.pnlHuman.Location = new System.Drawing.Point(1, 21);
            this.pnlHuman.Name = "pnlHuman";
            this.pnlHuman.Size = new System.Drawing.Size(640, 122);
            this.pnlHuman.TabIndex = 1;
            this.DurakTip.SetToolTip(this.pnlHuman, "Cards for attcker");
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(3, 60);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 38);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.DurakTip.SetToolTip(this.btnQuit, "Click to quit the game");
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTalonCount
            // 
            this.lblTalonCount.AutoSize = true;
            this.lblTalonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalonCount.Location = new System.Drawing.Point(30, 150);
            this.lblTalonCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTalonCount.Name = "lblTalonCount";
            this.lblTalonCount.Size = new System.Drawing.Size(38, 26);
            this.lblTalonCount.TabIndex = 9;
            this.lblTalonCount.Text = "99";
            this.DurakTip.SetToolTip(this.lblTalonCount, "Cards left in deck");
            // 
            // gbxRiver
            // 
            this.gbxRiver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxRiver.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxRiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxRiver.Controls.Add(this.pnlRiver);
            this.gbxRiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxRiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRiver.ForeColor = System.Drawing.Color.Aqua;
            this.gbxRiver.Location = new System.Drawing.Point(148, 161);
            this.gbxRiver.Name = "gbxRiver";
            this.gbxRiver.Size = new System.Drawing.Size(641, 144);
            this.gbxRiver.TabIndex = 10;
            this.gbxRiver.TabStop = false;
            this.gbxRiver.Text = "River";
            // 
            // pnlRiver
            // 
            this.pnlRiver.Location = new System.Drawing.Point(1, 19);
            this.pnlRiver.Name = "pnlRiver";
            this.pnlRiver.Size = new System.Drawing.Size(640, 122);
            this.pnlRiver.TabIndex = 0;
            this.DurakTip.SetToolTip(this.pnlRiver, "Cards played");
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.gbxRiver);
            this.Controls.Add(this.lblTalonCount);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.gbxHuman);
            this.Controls.Add(this.gbxComputer);
            this.Controls.Add(this.btnMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDurakGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.gbxComputer.ResumeLayout(false);
            this.gbxHuman.ResumeLayout(false);
            this.gbxRiver.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox gbxComputer;
        private System.Windows.Forms.GroupBox gbxHuman;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlCPU;
        private System.Windows.Forms.Panel pnlHuman;
        private System.Windows.Forms.Label lblTalonCount;
        private System.Windows.Forms.GroupBox gbxRiver;
        private System.Windows.Forms.Panel pnlRiver;
        private System.Windows.Forms.ToolTip DurakTip;
    }
}