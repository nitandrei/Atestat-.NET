namespace Atestat.NET
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTDA = new System.Windows.Forms.Button();
            this.buttonADB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.codeEducationLogo = new System.Windows.Forms.PictureBox();
            this.button_Meniu = new System.Windows.Forms.Button();
            this.buttonTeorie = new System.Windows.Forms.Button();
            this.buttonMDP = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer_Meniu = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeEducationLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.buttonTDA);
            this.panel1.Controls.Add(this.buttonADB);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.codeEducationLogo);
            this.panel1.Controls.Add(this.button_Meniu);
            this.panel1.Controls.Add(this.buttonTeorie);
            this.panel1.Controls.Add(this.buttonMDP);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 1;
            // 
            // buttonTDA
            // 
            this.buttonTDA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTDA.FlatAppearance.BorderSize = 0;
            this.buttonTDA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTDA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTDA.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTDA.Image = global::Atestat.NET.Properties.Resources.Buton_Teste;
            this.buttonTDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTDA.Location = new System.Drawing.Point(12, 286);
            this.buttonTDA.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTDA.Name = "buttonTDA";
            this.buttonTDA.Size = new System.Drawing.Size(188, 73);
            this.buttonTDA.TabIndex = 10;
            this.buttonTDA.Text = "Teste de    \r\nantrenament";
            this.buttonTDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTDA.UseVisualStyleBackColor = true;
            this.buttonTDA.Click += new System.EventHandler(this.buttonTDA_Click);
            // 
            // buttonADB
            // 
            this.buttonADB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonADB.FlatAppearance.BorderSize = 0;
            this.buttonADB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonADB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonADB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADB.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADB.Image = global::Atestat.NET.Properties.Resources.Buton_ADB;
            this.buttonADB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonADB.Location = new System.Drawing.Point(12, 213);
            this.buttonADB.Margin = new System.Windows.Forms.Padding(0);
            this.buttonADB.Name = "buttonADB";
            this.buttonADB.Size = new System.Drawing.Size(188, 73);
            this.buttonADB.TabIndex = 9;
            this.buttonADB.Text = "Algoritmi de\r\nbaza      ";
            this.buttonADB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonADB.UseVisualStyleBackColor = true;
            this.buttonADB.Click += new System.EventHandler(this.buttonADB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(228)))), ((int)(((byte)(37)))));
            this.panel3.Location = new System.Drawing.Point(1, 721);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 73);
            this.panel3.TabIndex = 8;
            // 
            // codeEducationLogo
            // 
            this.codeEducationLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeEducationLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.codeEducationLogo.Image = global::Atestat.NET.Properties.Resources.Code_Education_Logo;
            this.codeEducationLogo.Location = new System.Drawing.Point(7, 518);
            this.codeEducationLogo.Margin = new System.Windows.Forms.Padding(0);
            this.codeEducationLogo.Name = "codeEducationLogo";
            this.codeEducationLogo.Size = new System.Drawing.Size(186, 109);
            this.codeEducationLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codeEducationLogo.TabIndex = 7;
            this.codeEducationLogo.TabStop = false;
            this.codeEducationLogo.Click += new System.EventHandler(this.codeEducationLogo_Click);
            // 
            // button_Meniu
            // 
            this.button_Meniu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Meniu.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Meniu;
            this.button_Meniu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Meniu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Meniu.FlatAppearance.BorderSize = 0;
            this.button_Meniu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Meniu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Meniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Meniu.Location = new System.Drawing.Point(133, 9);
            this.button_Meniu.Margin = new System.Windows.Forms.Padding(0);
            this.button_Meniu.Name = "button_Meniu";
            this.button_Meniu.Size = new System.Drawing.Size(60, 50);
            this.button_Meniu.TabIndex = 5;
            this.button_Meniu.UseVisualStyleBackColor = true;
            this.button_Meniu.Click += new System.EventHandler(this.button_Meniu_Click);
            // 
            // buttonTeorie
            // 
            this.buttonTeorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTeorie.FlatAppearance.BorderSize = 0;
            this.buttonTeorie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTeorie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTeorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeorie.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeorie.Image = global::Atestat.NET.Properties.Resources.Buton_Teorie;
            this.buttonTeorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeorie.Location = new System.Drawing.Point(12, 67);
            this.buttonTeorie.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTeorie.Name = "buttonTeorie";
            this.buttonTeorie.Size = new System.Drawing.Size(165, 73);
            this.buttonTeorie.TabIndex = 4;
            this.buttonTeorie.Text = "Teorie";
            this.buttonTeorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTeorie.UseVisualStyleBackColor = true;
            this.buttonTeorie.Click += new System.EventHandler(this.buttonTeorie_Click);
            // 
            // buttonMDP
            // 
            this.buttonMDP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMDP.FlatAppearance.BorderSize = 0;
            this.buttonMDP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMDP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMDP.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMDP.Image = global::Atestat.NET.Properties.Resources.Buton_MDP;
            this.buttonMDP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMDP.Location = new System.Drawing.Point(12, 140);
            this.buttonMDP.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMDP.Name = "buttonMDP";
            this.buttonMDP.Size = new System.Drawing.Size(188, 73);
            this.buttonMDP.TabIndex = 3;
            this.buttonMDP.Text = "Metode de \r\nprogramare";
            this.buttonMDP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMDP.UseVisualStyleBackColor = true;
            this.buttonMDP.Click += new System.EventHandler(this.buttonMDP_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = global::Atestat.NET.Properties.Resources.Buton_Exit;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(7, 636);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(110, 52);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 720);
            this.panel2.TabIndex = 2;
            // 
            // timer_Meniu
            // 
            this.timer_Meniu.Interval = 15;
            this.timer_Meniu.Tick += new System.EventHandler(this.timer_Meniu_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeEducationLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMDP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTeorie;
        private System.Windows.Forms.Button button_Meniu;
        private System.Windows.Forms.Timer timer_Meniu;
        private System.Windows.Forms.PictureBox codeEducationLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonADB;
        private System.Windows.Forms.Button buttonTDA;
    }
}

