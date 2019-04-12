namespace Polymorphism
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
            this.btnIntel = new System.Windows.Forms.Button();
            this.btnAMD = new System.Windows.Forms.Button();
            this.btnNvidia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntel
            // 
            this.btnIntel.Location = new System.Drawing.Point(45, 265);
            this.btnIntel.Name = "btnIntel";
            this.btnIntel.Size = new System.Drawing.Size(206, 61);
            this.btnIntel.TabIndex = 1;
            this.btnIntel.Text = "Intel";
            this.btnIntel.UseVisualStyleBackColor = true;
            this.btnIntel.Click += new System.EventHandler(this.btnIntel_Click);
            // 
            // btnAMD
            // 
            this.btnAMD.Location = new System.Drawing.Point(45, 169);
            this.btnAMD.Name = "btnAMD";
            this.btnAMD.Size = new System.Drawing.Size(206, 61);
            this.btnAMD.TabIndex = 2;
            this.btnAMD.Text = "AMD";
            this.btnAMD.UseVisualStyleBackColor = true;
            this.btnAMD.Click += new System.EventHandler(this.btnAMD_Click);
            // 
            // btnNvidia
            // 
            this.btnNvidia.Location = new System.Drawing.Point(45, 74);
            this.btnNvidia.Name = "btnNvidia";
            this.btnNvidia.Size = new System.Drawing.Size(206, 61);
            this.btnNvidia.TabIndex = 3;
            this.btnNvidia.Text = "Nvidia";
            this.btnNvidia.UseVisualStyleBackColor = true;
            this.btnNvidia.Click += new System.EventHandler(this.btnNvidia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 406);
            this.Controls.Add(this.btnIntel);
            this.Controls.Add(this.btnAMD);
            this.Controls.Add(this.btnNvidia);
            this.Name = "Form1";
            this.Text = "PolymorphismExample";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntel;
        private System.Windows.Forms.Button btnAMD;
        private System.Windows.Forms.Button btnNvidia;
    }
}

