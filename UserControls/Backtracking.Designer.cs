namespace Atestat.NET.UserControls
{
    partial class Backtracking
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSudoku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Back;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Location = new System.Drawing.Point(112, 585);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 100);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSudoku
            // 
            this.buttonSudoku.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Sudoku;
            this.buttonSudoku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSudoku.FlatAppearance.BorderSize = 0;
            this.buttonSudoku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSudoku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSudoku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSudoku.Location = new System.Drawing.Point(802, 555);
            this.buttonSudoku.Name = "buttonSudoku";
            this.buttonSudoku.Size = new System.Drawing.Size(100, 100);
            this.buttonSudoku.TabIndex = 3;
            this.buttonSudoku.UseVisualStyleBackColor = true;
            this.buttonSudoku.Click += new System.EventHandler(this.buttonSudoku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Joc\r\nPractic\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Backtracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atestat.NET.Properties.Resources.Backtracking;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSudoku);
            this.Controls.Add(this.buttonBack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Backtracking";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSudoku;
        private System.Windows.Forms.Label label1;
    }
}
