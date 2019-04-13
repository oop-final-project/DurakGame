namespace DurakForms
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.AboutTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(904, 476);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(147, 49);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "&Main Menu";
            this.AboutTip.SetToolTip(this.btnMainMenu, "Click to go back to main menu");
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // rtbAbout
            // 
            this.rtbAbout.Location = new System.Drawing.Point(44, 44);
            this.rtbAbout.Margin = new System.Windows.Forms.Padding(4);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbAbout.Size = new System.Drawing.Size(979, 384);
            this.rtbAbout.TabIndex = 2;
            this.rtbAbout.TabStop = false;
            this.rtbAbout.Text = resources.GetString("rtbAbout.Text");
            this.AboutTip.SetToolTip(this.rtbAbout, "About Durak");
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DurakForms.Properties.Resources.TableTop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnMainMenu;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rtbAbout);
            this.Controls.Add(this.btnMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.ToolTip AboutTip;
    }
}