namespace fileDialog
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
            this.filebtn = new System.Windows.Forms.Button();
            this.filelable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // filebtn
            // 
            this.filebtn.Location = new System.Drawing.Point(95, 72);
            this.filebtn.Name = "filebtn";
            this.filebtn.Size = new System.Drawing.Size(75, 23);
            this.filebtn.TabIndex = 0;
            this.filebtn.Text = "Open File";
            this.filebtn.UseVisualStyleBackColor = true;
            this.filebtn.Click += new System.EventHandler(this.filebtn_Click);
            // 
            // filelable
            // 
            this.filelable.AutoSize = true;
            this.filelable.Location = new System.Drawing.Point(10, 48);
            this.filelable.Name = "filelable";
            this.filelable.Size = new System.Drawing.Size(23, 13);
            this.filelable.TabIndex = 1;
            this.filelable.Text = "File";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 122);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.filelable);
            this.Controls.Add(this.filebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filebtn;
        private System.Windows.Forms.Label filelable;
        private System.Windows.Forms.TextBox textBox1;
    }
}

