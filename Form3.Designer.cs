namespace FinalIS
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.scantext1 = new System.Windows.Forms.TextBox();
            this.scantext2 = new System.Windows.Forms.TextBox();
            this.scantext3 = new System.Windows.Forms.TextBox();
            this.scantext4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scanbtt1 = new System.Windows.Forms.Button();
            this.scantb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // scantext1
            // 
            this.scantext1.Location = new System.Drawing.Point(229, 211);
            this.scantext1.Name = "scantext1";
            this.scantext1.Size = new System.Drawing.Size(247, 20);
            this.scantext1.TabIndex = 8;
            // 
            // scantext2
            // 
            this.scantext2.Location = new System.Drawing.Point(229, 237);
            this.scantext2.Name = "scantext2";
            this.scantext2.Size = new System.Drawing.Size(247, 20);
            this.scantext2.TabIndex = 9;
            // 
            // scantext3
            // 
            this.scantext3.Location = new System.Drawing.Point(229, 263);
            this.scantext3.Name = "scantext3";
            this.scantext3.Size = new System.Drawing.Size(247, 20);
            this.scantext3.TabIndex = 10;
            // 
            // scantext4
            // 
            this.scantext4.Location = new System.Drawing.Point(229, 289);
            this.scantext4.Name = "scantext4";
            this.scantext4.Size = new System.Drawing.Size(247, 20);
            this.scantext4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Department";
            // 
            // scanbtt1
            // 
            this.scanbtt1.Location = new System.Drawing.Point(291, 137);
            this.scanbtt1.Name = "scanbtt1";
            this.scanbtt1.Size = new System.Drawing.Size(126, 40);
            this.scanbtt1.TabIndex = 15;
            this.scanbtt1.Text = "Scan";
            this.scanbtt1.UseVisualStyleBackColor = true;
            this.scanbtt1.Click += new System.EventHandler(this.scanbtt1_Click);
            // 
            // scantb1
            // 
            this.scantb1.Location = new System.Drawing.Point(199, 111);
            this.scantb1.Name = "scantb1";
            this.scantb1.Size = new System.Drawing.Size(307, 20);
            this.scantb1.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scantb1);
            this.Controls.Add(this.scanbtt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scantext4);
            this.Controls.Add(this.scantext3);
            this.Controls.Add(this.scantext2);
            this.Controls.Add(this.scantext1);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Scan QR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scantext1;
        private System.Windows.Forms.TextBox scantext2;
        private System.Windows.Forms.TextBox scantext3;
        private System.Windows.Forms.TextBox scantext4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button scanbtt1;
        private System.Windows.Forms.TextBox scantb1;
    }
}