namespace HashCalculator
{
    partial class Form1
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
            this.pathFile1 = new System.Windows.Forms.TextBox();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.hashFile1 = new System.Windows.Forms.TextBox();
            this.hashFile2 = new System.Windows.Forms.TextBox();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.pathFile2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathFile1
            // 
            this.pathFile1.Location = new System.Drawing.Point(30, 63);
            this.pathFile1.Name = "pathFile1";
            this.pathFile1.Size = new System.Drawing.Size(319, 20);
            this.pathFile1.TabIndex = 0;
            this.pathFile1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFile1
            // 
            this.btnFile1.Location = new System.Drawing.Point(346, 62);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(50, 21);
            this.btnFile1.TabIndex = 1;
            this.btnFile1.Text = "...";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // hashFile1
            // 
            this.hashFile1.Location = new System.Drawing.Point(30, 122);
            this.hashFile1.Multiline = true;
            this.hashFile1.Name = "hashFile1";
            this.hashFile1.Size = new System.Drawing.Size(366, 76);
            this.hashFile1.TabIndex = 2;
            // 
            // hashFile2
            // 
            this.hashFile2.Location = new System.Drawing.Point(411, 122);
            this.hashFile2.Multiline = true;
            this.hashFile2.Name = "hashFile2";
            this.hashFile2.Size = new System.Drawing.Size(366, 76);
            this.hashFile2.TabIndex = 5;
            // 
            // btnFile2
            // 
            this.btnFile2.Location = new System.Drawing.Point(727, 62);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(50, 21);
            this.btnFile2.TabIndex = 4;
            this.btnFile2.Text = "...";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // pathFile2
            // 
            this.pathFile2.Location = new System.Drawing.Point(411, 63);
            this.pathFile2.Name = "pathFile2";
            this.pathFile2.Size = new System.Drawing.Size(319, 20);
            this.pathFile2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "File 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SHA-256";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SHA-256";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(30, 204);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(747, 50);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 338);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hashFile2);
            this.Controls.Add(this.btnFile2);
            this.Controls.Add(this.pathFile2);
            this.Controls.Add(this.hashFile1);
            this.Controls.Add(this.btnFile1);
            this.Controls.Add(this.pathFile1);
            this.Name = "Form1";
            this.Text = "Hash Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathFile1;
        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.TextBox hashFile1;
        private System.Windows.Forms.TextBox hashFile2;
        private System.Windows.Forms.Button btnFile2;
        private System.Windows.Forms.TextBox pathFile2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button calcButton;
    }
}

