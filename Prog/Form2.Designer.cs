
namespace Prog
{
    partial class Form2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMin = new System.Windows.Forms.TextBox();
            this.TxtMax = new System.Windows.Forms.TextBox();
            this.TxtMaxBoth = new System.Windows.Forms.TextBox();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMinMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(333, 47);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 37);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Max-Max";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(333, 130);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(145, 37);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "Max-Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MIn-Max";
            // 
            // TxtMin
            // 
            this.TxtMin.AcceptsReturn = true;
            this.TxtMin.AccessibleName = " ";
            this.TxtMin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtMin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.TxtMin.Font = new System.Drawing.Font("Aldhabi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMin.ForeColor = System.Drawing.Color.Black;
            this.TxtMin.HideSelection = false;
            this.TxtMin.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.TxtMin.Location = new System.Drawing.Point(594, 132);
            this.TxtMin.MinimumSize = new System.Drawing.Size(100, 50);
            this.TxtMin.Name = "TxtMin";
            this.TxtMin.Size = new System.Drawing.Size(100, 48);
            this.TxtMin.TabIndex = 6;
            this.TxtMin.Text = " ";
            // 
            // TxtMax
            // 
            this.TxtMax.AcceptsReturn = true;
            this.TxtMax.AccessibleName = " ";
            this.TxtMax.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtMax.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TxtMax.Font = new System.Drawing.Font("Aldhabi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMax.ForeColor = System.Drawing.Color.Black;
            this.TxtMax.HideSelection = false;
            this.TxtMax.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.TxtMax.Location = new System.Drawing.Point(594, 34);
            this.TxtMax.MinimumSize = new System.Drawing.Size(100, 50);
            this.TxtMax.Name = "TxtMax";
            this.TxtMax.Size = new System.Drawing.Size(100, 48);
            this.TxtMax.TabIndex = 7;
            this.TxtMax.Text = " ";
            // 
            // TxtMaxBoth
            // 
            this.TxtMaxBoth.AcceptsReturn = true;
            this.TxtMaxBoth.AccessibleName = " ";
            this.TxtMaxBoth.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TxtMaxBoth.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.TxtMaxBoth.Font = new System.Drawing.Font("Aldhabi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxBoth.ForeColor = System.Drawing.Color.Black;
            this.TxtMaxBoth.HideSelection = false;
            this.TxtMaxBoth.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.TxtMaxBoth.Location = new System.Drawing.Point(594, 223);
            this.TxtMaxBoth.MinimumSize = new System.Drawing.Size(100, 50);
            this.TxtMaxBoth.Name = "TxtMaxBoth";
            this.TxtMaxBoth.Size = new System.Drawing.Size(100, 48);
            this.TxtMaxBoth.TabIndex = 9;
            this.TxtMaxBoth.Text = " ";
            // 
            // BtnMax
            // 
            this.BtnMax.Location = new System.Drawing.Point(791, 34);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(137, 47);
            this.BtnMax.TabIndex = 10;
            this.BtnMax.Text = "Clac";
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Location = new System.Drawing.Point(791, 133);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(137, 47);
            this.BtnMin.TabIndex = 11;
            this.BtnMin.Text = "Calc";
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMinMax
            // 
            this.BtnMinMax.Location = new System.Drawing.Point(791, 224);
            this.BtnMinMax.Name = "BtnMinMax";
            this.BtnMinMax.Size = new System.Drawing.Size(137, 47);
            this.BtnMinMax.TabIndex = 12;
            this.BtnMinMax.Text = "Clac";
            this.BtnMinMax.UseVisualStyleBackColor = true;
            this.BtnMinMax.Click += new System.EventHandler(this.BtnMinMax_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1054, 698);
            this.ControlBox = false;
            this.Controls.Add(this.BtnMinMax);
            this.Controls.Add(this.BtnMin);
            this.Controls.Add(this.BtnMax);
            this.Controls.Add(this.TxtMaxBoth);
            this.Controls.Add(this.TxtMax);
            this.Controls.Add(this.TxtMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtMax;
        public System.Windows.Forms.TextBox TxtMin;
        public System.Windows.Forms.TextBox TxtMaxBoth;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMinMax;
    }
}