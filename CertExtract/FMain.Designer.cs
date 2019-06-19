namespace CertExtract
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.tbBinaryData = new System.Windows.Forms.TextBox();
            this.bRun = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bGenerateCertificate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBinaryData
            // 
            this.tbBinaryData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBinaryData.Location = new System.Drawing.Point(12, 28);
            this.tbBinaryData.Multiline = true;
            this.tbBinaryData.Name = "tbBinaryData";
            this.tbBinaryData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBinaryData.Size = new System.Drawing.Size(486, 158);
            this.tbBinaryData.TabIndex = 0;
            this.tbBinaryData.Text = resources.GetString("tbBinaryData.Text");
            // 
            // bRun
            // 
            this.bRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bRun.Location = new System.Drawing.Point(504, 28);
            this.bRun.Name = "bRun";
            this.bRun.Size = new System.Drawing.Size(213, 76);
            this.bRun.TabIndex = 1;
            this.bRun.Text = "Extract certificate info";
            this.bRun.UseVisualStyleBackColor = true;
            this.bRun.Click += new System.EventHandler(this.bRun_Click);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResult.Location = new System.Drawing.Point(12, 214);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResult.Size = new System.Drawing.Size(486, 309);
            this.tbResult.TabIndex = 2;
            // 
            // bGenerateCertificate
            // 
            this.bGenerateCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGenerateCertificate.Location = new System.Drawing.Point(504, 110);
            this.bGenerateCertificate.Name = "bGenerateCertificate";
            this.bGenerateCertificate.Size = new System.Drawing.Size(213, 76);
            this.bGenerateCertificate.TabIndex = 3;
            this.bGenerateCertificate.Text = "Write to file";
            this.bGenerateCertificate.UseVisualStyleBackColor = true;
            this.bGenerateCertificate.Click += new System.EventHandler(this.bGenerateCertificate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Certificate Base64 string (put your certificate Base64 string):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result:";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bGenerateCertificate);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.bRun);
            this.Controls.Add(this.tbBinaryData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(491, 367);
            this.Name = "FMain";
            this.Text = "Certificate Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBinaryData;
        private System.Windows.Forms.Button bRun;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bGenerateCertificate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

