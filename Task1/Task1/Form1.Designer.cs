namespace Task1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDecryuption = new System.Windows.Forms.TextBox();
            this.lblDecOutput = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEncryption = new System.Windows.Forms.TextBox();
            this.lblEncOutput = new System.Windows.Forms.Label();
            this.btnEcrypt = new System.Windows.Forms.Button();
            this.lblDecHeading = new System.Windows.Forms.Label();
            this.lblEncHeading = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDecHeading);
            this.groupBox2.Controls.Add(this.txtDecryuption);
            this.groupBox2.Controls.Add(this.lblDecOutput);
            this.groupBox2.Controls.Add(this.btnDecrypt);
            this.groupBox2.Location = new System.Drawing.Point(476, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 389);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // txtDecryuption
            // 
            this.txtDecryuption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryuption.Location = new System.Drawing.Point(6, 34);
            this.txtDecryuption.Name = "txtDecryuption";
            this.txtDecryuption.Size = new System.Drawing.Size(383, 22);
            this.txtDecryuption.TabIndex = 5;
            // 
            // lblDecOutput
            // 
            this.lblDecOutput.AutoSize = true;
            this.lblDecOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecOutput.Location = new System.Drawing.Point(6, 133);
            this.lblDecOutput.Name = "lblDecOutput";
            this.lblDecOutput.Size = new System.Drawing.Size(51, 16);
            this.lblDecOutput.TabIndex = 3;
            this.lblDecOutput.Text = "Output";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(160, 287);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(103, 39);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEncHeading);
            this.groupBox1.Controls.Add(this.txtEncryption);
            this.groupBox1.Controls.Add(this.lblEncOutput);
            this.groupBox1.Controls.Add(this.btnEcrypt);
            this.groupBox1.Location = new System.Drawing.Point(28, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 389);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtEncryption
            // 
            this.txtEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryption.Location = new System.Drawing.Point(5, 39);
            this.txtEncryption.Name = "txtEncryption";
            this.txtEncryption.Size = new System.Drawing.Size(383, 22);
            this.txtEncryption.TabIndex = 4;
            // 
            // lblEncOutput
            // 
            this.lblEncOutput.AutoSize = true;
            this.lblEncOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncOutput.Location = new System.Drawing.Point(7, 138);
            this.lblEncOutput.Name = "lblEncOutput";
            this.lblEncOutput.Size = new System.Drawing.Size(51, 16);
            this.lblEncOutput.TabIndex = 2;
            this.lblEncOutput.Text = "Output";
            // 
            // btnEcrypt
            // 
            this.btnEcrypt.Location = new System.Drawing.Point(129, 292);
            this.btnEcrypt.Name = "btnEcrypt";
            this.btnEcrypt.Size = new System.Drawing.Size(103, 39);
            this.btnEcrypt.TabIndex = 0;
            this.btnEcrypt.Text = "Encrypt";
            this.btnEcrypt.UseVisualStyleBackColor = true;
            this.btnEcrypt.Click += new System.EventHandler(this.btnEcrypt_Click);
            // 
            // lblDecHeading
            // 
            this.lblDecHeading.AutoSize = true;
            this.lblDecHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecHeading.Location = new System.Drawing.Point(6, 3);
            this.lblDecHeading.Name = "lblDecHeading";
            this.lblDecHeading.Size = new System.Drawing.Size(71, 20);
            this.lblDecHeading.TabIndex = 6;
            this.lblDecHeading.Text = "Decrypt";
            // 
            // lblEncHeading
            // 
            this.lblEncHeading.AutoSize = true;
            this.lblEncHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncHeading.Location = new System.Drawing.Point(2, 3);
            this.lblEncHeading.Name = "lblEncHeading";
            this.lblEncHeading.Size = new System.Drawing.Size(70, 20);
            this.lblEncHeading.TabIndex = 5;
            this.lblEncHeading.Text = "Encrypt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDecryuption;
        private System.Windows.Forms.Label lblDecOutput;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEncryption;
        private System.Windows.Forms.Label lblEncOutput;
        private System.Windows.Forms.Button btnEcrypt;
        private System.Windows.Forms.Label lblDecHeading;
        private System.Windows.Forms.Label lblEncHeading;
    }
}

