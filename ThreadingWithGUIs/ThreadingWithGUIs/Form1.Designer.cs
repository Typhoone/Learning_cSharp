namespace ThreadingWithGUIs
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
            this.updateBox = new System.Windows.Forms.TextBox();
            this.mousePos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateBox
            // 
            this.updateBox.Location = new System.Drawing.Point(81, 31);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(100, 20);
            this.updateBox.TabIndex = 0;
            this.updateBox.TextChanged += new System.EventHandler(this.updateBox_TextChanged);
            // 
            // mousePos
            // 
            this.mousePos.AutoSize = true;
            this.mousePos.Location = new System.Drawing.Point(119, 99);
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(22, 13);
            this.mousePos.TabIndex = 1;
            this.mousePos.Text = "0,0";
            this.mousePos.Click += new System.EventHandler(this.mousePos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mousePos);
            this.Controls.Add(this.updateBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox updateBox;
        private System.Windows.Forms.Label mousePos;
    }
}

