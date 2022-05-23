
namespace Atestat.NET
{
    partial class Teste
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.labelPunctaj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(252, 63);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(969, 142);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.White;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(265, 415);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(75, 55);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Visible = false;
            this.buttonA.Click += new System.EventHandler(this.button_Click);
            // 
            // labelPunctaj
            // 
            this.labelPunctaj.AutoSize = true;
            this.labelPunctaj.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunctaj.ForeColor = System.Drawing.Color.White;
            this.labelPunctaj.Location = new System.Drawing.Point(1009, 21);
            this.labelPunctaj.Name = "labelPunctaj";
            this.labelPunctaj.Size = new System.Drawing.Size(71, 24);
            this.labelPunctaj.TabIndex = 5;
            this.labelPunctaj.Text = "Punctaj";
            this.labelPunctaj.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(848, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timp";
            this.label2.Visible = false;
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.White;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonB.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F);
            this.buttonB.Location = new System.Drawing.Point(497, 415);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(75, 55);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            this.buttonB.Visible = false;
            this.buttonB.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.White;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F);
            this.buttonC.Location = new System.Drawing.Point(877, 415);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 55);
            this.buttonC.TabIndex = 3;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Visible = false;
            this.buttonC.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.White;
            this.buttonD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonD.Font = new System.Drawing.Font("Franklin Gothic Medium", 26.25F);
            this.buttonD.Location = new System.Drawing.Point(1146, 415);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(75, 55);
            this.buttonD.TabIndex = 4;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Visible = false;
            this.buttonD.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Next;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(1159, 585);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 100);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(80)))), ((int)(((byte)(155)))));
            this.BackgroundImage = global::Atestat.NET.Properties.Resources.Teste_Background1;
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPunctaj);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Teste";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label labelPunctaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonNext;
    }
}
