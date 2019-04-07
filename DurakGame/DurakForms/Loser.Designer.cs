namespace DurakForms
{
    partial class frmLoser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoser));
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblLoser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.AutoSize = true;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(139, 171);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(165, 49);
            this.btnPlayAgain.TabIndex = 4;
            this.btnPlayAgain.Text = "&Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(541, 171);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 49);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblLoser
            // 
            this.lblLoser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoser.AutoSize = true;
            this.lblLoser.BackColor = System.Drawing.Color.Transparent;
            this.lblLoser.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoser.ForeColor = System.Drawing.Color.Red;
            this.lblLoser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoser.Location = new System.Drawing.Point(105, 32);
            this.lblLoser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoser.Name = "lblLoser";
            this.lblLoser.Size = new System.Drawing.Size(494, 62);
            this.lblLoser.TabIndex = 2;
            this.lblLoser.Text = "You are the Loser!";
            this.lblLoser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 321);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblLoser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblLoser;
    }
}