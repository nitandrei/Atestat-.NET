namespace Atestat.NET
{
    partial class LoadingScreen
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
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.GIFcontainer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GIFcontainer)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingBar
            // 
            this.LoadingBar.ForeColor = System.Drawing.Color.Purple;
            this.LoadingBar.Location = new System.Drawing.Point(0, 400);
            this.LoadingBar.Margin = new System.Windows.Forms.Padding(0);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(941, 20);
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.LoadingBar.TabIndex = 1;
            // 
            // GIFcontainer
            // 
            this.GIFcontainer.Image = global::Atestat.NET.Properties.Resources.LoadingScreen;
            this.GIFcontainer.Location = new System.Drawing.Point(0, 0);
            this.GIFcontainer.Margin = new System.Windows.Forms.Padding(0);
            this.GIFcontainer.Name = "GIFcontainer";
            this.GIFcontainer.Size = new System.Drawing.Size(800, 400);
            this.GIFcontainer.TabIndex = 0;
            this.GIFcontainer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(49)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.GIFcontainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.Activated += new System.EventHandler(this.LoadingScreen_Activated);
            this.Validated += new System.EventHandler(this.LoadingScreen_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.GIFcontainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GIFcontainer;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Timer timer1;
    }
}