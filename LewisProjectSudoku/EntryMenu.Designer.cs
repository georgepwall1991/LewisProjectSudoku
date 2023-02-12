
namespace LewisProjectSudoku
{
    partial class EntryMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Diff1 = new System.Windows.Forms.Button();
            this.Diff2 = new System.Windows.Forms.Button();
            this.Diff3 = new System.Windows.Forms.Button();
            this.Diff4 = new System.Windows.Forms.Button();
            this.Diff5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Diff1
            // 
            this.Diff1.BackColor = System.Drawing.Color.MintCream;
            this.Diff1.Location = new System.Drawing.Point(397, 112);
            this.Diff1.Name = "Diff1";
            this.Diff1.Size = new System.Drawing.Size(144, 55);
            this.Diff1.TabIndex = 0;
            this.Diff1.Text = "Difficulty Level 1";
            this.Diff1.UseVisualStyleBackColor = false;
            this.Diff1.Click += new System.EventHandler(this.Diff1_Click);
            // 
            // Diff2
            // 
            this.Diff2.BackColor = System.Drawing.Color.Aquamarine;
            this.Diff2.Location = new System.Drawing.Point(397, 173);
            this.Diff2.Name = "Diff2";
            this.Diff2.Size = new System.Drawing.Size(144, 55);
            this.Diff2.TabIndex = 1;
            this.Diff2.Text = "Difficulty Level 2";
            this.Diff2.UseVisualStyleBackColor = false;
            this.Diff2.Click += new System.EventHandler(this.Diff2_Click);
            // 
            // Diff3
            // 
            this.Diff3.BackColor = System.Drawing.Color.Turquoise;
            this.Diff3.Location = new System.Drawing.Point(397, 234);
            this.Diff3.Name = "Diff3";
            this.Diff3.Size = new System.Drawing.Size(144, 55);
            this.Diff3.TabIndex = 2;
            this.Diff3.Text = "Difficulty Level 3";
            this.Diff3.UseVisualStyleBackColor = false;
            this.Diff3.Click += new System.EventHandler(this.Diff3_Click);
            // 
            // Diff4
            // 
            this.Diff4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Diff4.Location = new System.Drawing.Point(397, 295);
            this.Diff4.Name = "Diff4";
            this.Diff4.Size = new System.Drawing.Size(144, 55);
            this.Diff4.TabIndex = 3;
            this.Diff4.Text = "Difficulty Level 4";
            this.Diff4.UseVisualStyleBackColor = false;
            this.Diff4.Click += new System.EventHandler(this.Diff4_Click);
            // 
            // Diff5
            // 
            this.Diff5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Diff5.Location = new System.Drawing.Point(397, 356);
            this.Diff5.Name = "Diff5";
            this.Diff5.Size = new System.Drawing.Size(144, 55);
            this.Diff5.TabIndex = 4;
            this.Diff5.Text = "Difficulty Level 5";
            this.Diff5.UseVisualStyleBackColor = false;
            this.Diff5.Click += new System.EventHandler(this.Diff5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(332, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Hello! Welcome to Steph\'s Sudoku Solver";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Plum;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(174, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(589, 50);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Please pick the difficulty level you feel you are, don\'t worry about this as you " +
    "will soon be solving at the best level for you!";
            // 
            // EntryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(961, 603);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Diff5);
            this.Controls.Add(this.Diff4);
            this.Controls.Add(this.Diff3);
            this.Controls.Add(this.Diff2);
            this.Controls.Add(this.Diff1);
            this.Name = "EntryMenu";
            this.Text = "S";
            this.TransparencyKey = System.Drawing.Color.MediumVioletRed;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Diff1;
        private System.Windows.Forms.Button Diff2;
        private System.Windows.Forms.Button Diff3;
        private System.Windows.Forms.Button Diff4;
        private System.Windows.Forms.Button Diff5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

