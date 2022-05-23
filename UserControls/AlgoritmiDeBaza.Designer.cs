
namespace Atestat.NET.UserControls
{
    partial class AlgoritmiDeBaza
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
            this.buttonSSD = new System.Windows.Forms.Button();
            this.buttonCUN = new System.Windows.Forms.Button();
            this.buttonDiviz = new System.Windows.Forms.Button();
            this.buttonSLF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSSD
            // 
            this.buttonSSD.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_SumaSiDiferenta;
            this.buttonSSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSSD.FlatAppearance.BorderSize = 0;
            this.buttonSSD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSSD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSSD.Location = new System.Drawing.Point(253, 269);
            this.buttonSSD.Name = "buttonSSD";
            this.buttonSSD.Size = new System.Drawing.Size(240, 308);
            this.buttonSSD.TabIndex = 0;
            this.buttonSSD.UseVisualStyleBackColor = true;
            this.buttonSSD.Click += new System.EventHandler(this.buttonSSD_Click);
            this.buttonSSD.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonSSD.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            // 
            // buttonCUN
            // 
            this.buttonCUN.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_CifreleUnuiNumar;
            this.buttonCUN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCUN.FlatAppearance.BorderSize = 0;
            this.buttonCUN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCUN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCUN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCUN.Location = new System.Drawing.Point(759, 269);
            this.buttonCUN.Name = "buttonCUN";
            this.buttonCUN.Size = new System.Drawing.Size(240, 308);
            this.buttonCUN.TabIndex = 1;
            this.buttonCUN.UseVisualStyleBackColor = true;
            this.buttonCUN.Click += new System.EventHandler(this.buttonCUN_Click);
            this.buttonCUN.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonCUN.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            // 
            // buttonDiviz
            // 
            this.buttonDiviz.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_Divizibilitate;
            this.buttonDiviz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiviz.FlatAppearance.BorderSize = 0;
            this.buttonDiviz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDiviz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDiviz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiviz.Location = new System.Drawing.Point(507, 269);
            this.buttonDiviz.Name = "buttonDiviz";
            this.buttonDiviz.Size = new System.Drawing.Size(240, 308);
            this.buttonDiviz.TabIndex = 2;
            this.buttonDiviz.UseVisualStyleBackColor = true;
            this.buttonDiviz.Click += new System.EventHandler(this.buttonDiviz_Click);
            this.buttonDiviz.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonDiviz.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            // 
            // buttonSLF
            // 
            this.buttonSLF.BackgroundImage = global::Atestat.NET.Properties.Resources.Buton_SirulLuiFibonacci;
            this.buttonSLF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSLF.FlatAppearance.BorderSize = 0;
            this.buttonSLF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSLF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSLF.Location = new System.Drawing.Point(1013, 269);
            this.buttonSLF.Name = "buttonSLF";
            this.buttonSLF.Size = new System.Drawing.Size(240, 308);
            this.buttonSLF.TabIndex = 3;
            this.buttonSLF.UseVisualStyleBackColor = true;
            this.buttonSLF.Click += new System.EventHandler(this.buttonSLF_Click);
            this.buttonSLF.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonSLF.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            // 
            // AlgoritmiDeBaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Atestat.NET.Properties.Resources.AlgoritmiDeBaza;
            this.Controls.Add(this.buttonSLF);
            this.Controls.Add(this.buttonDiviz);
            this.Controls.Add(this.buttonCUN);
            this.Controls.Add(this.buttonSSD);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AlgoritmiDeBaza";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSSD;
        private System.Windows.Forms.Button buttonCUN;
        private System.Windows.Forms.Button buttonDiviz;
        private System.Windows.Forms.Button buttonSLF;
    }
}
