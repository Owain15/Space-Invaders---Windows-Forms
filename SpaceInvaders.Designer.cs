namespace Space_Invaders
{
    partial class SpaceInvadersWindow
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
			this.userDisplay = new System.Windows.Forms.PictureBox();
			this.RenderTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// userDisplay
			// 
			this.userDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.userDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userDisplay.Location = new System.Drawing.Point(0, 0);
			this.userDisplay.Name = "userDisplay";
			this.userDisplay.Size = new System.Drawing.Size(778, 544);
			this.userDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userDisplay.TabIndex = 0;
			this.userDisplay.TabStop = false;
			// 
			// SpaceInvadersWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.userDisplay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SpaceInvadersWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Space Invaders";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.userDisplay)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox userDisplay;
		private System.Windows.Forms.Timer RenderTimer;
	}
}

