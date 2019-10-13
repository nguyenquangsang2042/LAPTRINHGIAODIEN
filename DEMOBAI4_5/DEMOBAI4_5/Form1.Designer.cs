namespace DEMOBAI4_5
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
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(54, 38);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(206, 20);
            this.txtKq.TabIndex = 0;
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(303, 38);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(75, 23);
            this.btnxacnhan.TabIndex = 1;
            this.btnxacnhan.Text = "button1";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kết quả";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Location = new System.Drawing.Point(163, 90);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(35, 13);
            this.lbKQ.TabIndex = 3;
            this.lbKQ.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 142);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.txtKq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKQ;
    }
}

