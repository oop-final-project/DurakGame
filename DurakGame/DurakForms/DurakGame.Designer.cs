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
            this.lblTalonCount = new System.Windows.Forms.Label();
            this.gbxRiver = new System.Windows.Forms.GroupBox();
            this.pnlRiver = new System.Windows.Forms.Panel();
            this.btnEndAttack = new System.Windows.Forms.Button();
            this.btnEndDefence = new System.Windows.Forms.Button();
            this.DurakTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxAdder = new System.Windows.Forms.GroupBox();
            this.pnlAdder = new System.Windows.Forms.Panel();
            this.gbxComputer.SuspendLayout();
            this.gbxHuman.SuspendLayout();
            this.gbxRiver.SuspendLayout();
            this.gbxAdder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(4, 15);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(156, 52);
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
            this.gbxComputer.Location = new System.Drawing.Point(227, 15);
            this.gbxComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxComputer.Name = "gbxComputer";
            this.gbxComputer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxComputer.Size = new System.Drawing.Size(855, 177);
            this.gbxComputer.TabIndex = 0;
            this.gbxComputer.TabStop = false;
            this.gbxComputer.Text = "Defender";
            // 
            // pnlCPU
            // 
            this.pnlCPU.Location = new System.Drawing.Point(1, 23);
            this.pnlCPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCPU.Name = "pnlCPU";
            this.pnlCPU.Size = new System.Drawing.Size(853, 150);
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
            this.gbxHuman.Location = new System.Drawing.Point(227, 383);
            this.gbxHuman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxHuman.Name = "gbxHuman";
            this.gbxHuman.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxHuman.Size = new System.Drawing.Size(855, 178);
            this.gbxHuman.TabIndex = 0;
            this.gbxHuman.TabStop = false;
            this.gbxHuman.Text = "Attacker";
            // 
            // pnlHuman
            // 
            this.pnlHuman.Location = new System.Drawing.Point(1, 26);
            this.pnlHuman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHuman.Name = "pnlHuman";
            this.pnlHuman.Size = new System.Drawing.Size(853, 150);
            this.pnlHuman.TabIndex = 1;
            this.DurakTip.SetToolTip(this.pnlHuman, "Cards for attcker");
            // 
            // lblTalonCount
            // 
            this.lblTalonCount.AutoSize = true;
            this.lblTalonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalonCount.Location = new System.Drawing.Point(40, 185);
            this.lblTalonCount.Name = "lblTalonCount";
            this.lblTalonCount.Size = new System.Drawing.Size(46, 31);
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
            this.gbxRiver.Location = new System.Drawing.Point(228, 198);
            this.gbxRiver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxRiver.Name = "gbxRiver";
            this.gbxRiver.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxRiver.Size = new System.Drawing.Size(855, 177);
            this.gbxRiver.TabIndex = 10;
            this.gbxRiver.TabStop = false;
            this.gbxRiver.Text = "River";
            // 
            // pnlRiver
            // 
            this.pnlRiver.Location = new System.Drawing.Point(1, 23);
            this.pnlRiver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRiver.Name = "pnlRiver";
            this.pnlRiver.Size = new System.Drawing.Size(853, 150);
            this.pnlRiver.TabIndex = 0;
            this.DurakTip.SetToolTip(this.pnlRiver, "Cards played");
            // 
            // btnEndAttack
            // 
            this.btnEndAttack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndAttack.Location = new System.Drawing.Point(5, 509);
            this.btnEndAttack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEndAttack.Name = "btnEndAttack";
            this.btnEndAttack.Size = new System.Drawing.Size(208, 58);
            this.btnEndAttack.TabIndex = 11;
            this.btnEndAttack.Text = "&End Attack";
            this.btnEndAttack.UseVisualStyleBackColor = true;
            this.btnEndAttack.Click += new System.EventHandler(this.btnEndAttack_Click);
            // 
            // btnEndDefence
            // 
            this.btnEndDefence.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEndDefence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndDefence.Location = new System.Drawing.Point(5, 508);
            this.btnEndDefence.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEndDefence.Name = "btnEndDefence";
            this.btnEndDefence.Size = new System.Drawing.Size(208, 58);
            this.btnEndDefence.TabIndex = 12;
            this.btnEndDefence.Text = "&End Defence";
            this.btnEndDefence.UseVisualStyleBackColor = true;
            this.btnEndDefence.Visible = false;
            this.btnEndDefence.Click += new System.EventHandler(this.btnEndDefence_Click);
            // 
            // gbxAdder
            // 
            this.gbxAdder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAdder.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.gbxAdder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxAdder.Controls.Add(this.pnlAdder);
            this.gbxAdder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxAdder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdder.ForeColor = System.Drawing.Color.Aqua;
            this.gbxAdder.Location = new System.Drawing.Point(1091, 198);
            this.gbxAdder.Margin = new System.Windows.Forms.Padding(4);
            this.gbxAdder.Name = "gbxAdder";
            this.gbxAdder.Padding = new System.Windows.Forms.Padding(4);
            this.gbxAdder.Size = new System.Drawing.Size(323, 177);
            this.gbxAdder.TabIndex = 13;
            this.gbxAdder.TabStop = false;
            this.gbxAdder.Text = "Added Cards";
            this.gbxAdder.Visible = false;
            // 
            // pnlAdder
            // 
            this.pnlAdder.Location = new System.Drawing.Point(0, 23);
            this.pnlAdder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdder.Name = "pnlAdder";
            this.pnlAdder.Size = new System.Drawing.Size(323, 150);
            this.pnlAdder.TabIndex = 0;
            this.DurakTip.SetToolTip(this.pnlAdder, "Cards played");
            // 
            // frmDurakGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1423, 710);
            this.Controls.Add(this.gbxAdder);
            this.Controls.Add(this.btnEndDefence);
            this.Controls.Add(this.btnEndAttack);
            this.Controls.Add(this.gbxRiver);
            this.Controls.Add(this.lblTalonCount);
            this.Controls.Add(this.gbxHuman);
            this.Controls.Add(this.gbxComputer);
            this.Controls.Add(this.btnMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDurakGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.gbxComputer.ResumeLayout(false);
            this.gbxHuman.ResumeLayout(false);
            this.gbxRiver.ResumeLayout(false);
            this.gbxAdder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.GroupBox gbxComputer;
        private System.Windows.Forms.GroupBox gbxHuman;
        private System.Windows.Forms.Panel pnlCPU;
        private System.Windows.Forms.Panel pnlHuman;
        private System.Windows.Forms.Label lblTalonCount;
        private System.Windows.Forms.GroupBox gbxRiver;
        private System.Windows.Forms.Panel pnlRiver;
        private System.Windows.Forms.Button btnEndAttack;
        private System.Windows.Forms.Button btnEndDefence;
        private System.Windows.Forms.ToolTip DurakTip;
        private System.Windows.Forms.GroupBox gbxAdder;
        private System.Windows.Forms.Panel pnlAdder;
    }
}