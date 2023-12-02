namespace Quiz
{
    partial class EasyForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelQ = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(176, 246);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 3;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelN
            // 
            this.labelN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.Location = new System.Drawing.Point(124, 41);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(175, 24);
            this.labelN.TabIndex = 26;
            this.labelN.Text = "label2";
            this.labelN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelQ);
            this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(41, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 64);
            this.panel1.TabIndex = 25;
            // 
            // labelQ
            // 
            this.labelQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQ.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.Location = new System.Drawing.Point(0, 0);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(340, 64);
            this.labelQ.TabIndex = 0;
            this.labelQ.Text = "label1";
            this.labelQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // EasyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 300);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.textBox1);
            this.Name = "EasyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.TextBox textBox2;
    }
}