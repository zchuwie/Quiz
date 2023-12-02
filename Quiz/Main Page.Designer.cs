namespace Quiz
{
    partial class Main
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
            this.easyBtn = new System.Windows.Forms.Button();
            this.aveBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(67, 69);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(118, 59);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // aveBtn
            // 
            this.aveBtn.Location = new System.Drawing.Point(67, 134);
            this.aveBtn.Name = "aveBtn";
            this.aveBtn.Size = new System.Drawing.Size(118, 59);
            this.aveBtn.TabIndex = 1;
            this.aveBtn.Text = "Average";
            this.aveBtn.UseVisualStyleBackColor = true;
            this.aveBtn.Click += new System.EventHandler(this.aveBtn_Click);
            // 
            // hardBtn
            // 
            this.hardBtn.Location = new System.Drawing.Point(67, 199);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(118, 59);
            this.hardBtn.TabIndex = 2;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = true;
            this.hardBtn.Click += new System.EventHandler(this.hardBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified Jpan", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUIZ GAME";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 275);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(49, 26);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 313);
            this.ControlBox = false;
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hardBtn);
            this.Controls.Add(this.aveBtn);
            this.Controls.Add(this.easyBtn);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button aveBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
    }
}