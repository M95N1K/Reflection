namespace DZ_Less8_3
{
    partial class FAbout
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
            this.lAutor = new System.Windows.Forms.Label();
            this.lVersion = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.tbLicens = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lAutor
            // 
            this.lAutor.AutoSize = true;
            this.lAutor.Location = new System.Drawing.Point(38, 31);
            this.lAutor.Name = "lAutor";
            this.lAutor.Size = new System.Drawing.Size(94, 13);
            this.lAutor.TabIndex = 0;
            this.lAutor.Text = "Автор: Виль В. В.";
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(41, 66);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(50, 13);
            this.lVersion.TabIndex = 1;
            this.lVersion.Text = "Версия: ";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(12, 185);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(160, 23);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tbLicens
            // 
            this.tbLicens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLicens.Enabled = false;
            this.tbLicens.Location = new System.Drawing.Point(41, 92);
            this.tbLicens.Multiline = true;
            this.tbLicens.Name = "tbLicens";
            this.tbLicens.Size = new System.Drawing.Size(100, 76);
            this.tbLicens.TabIndex = 3;
            this.tbLicens.TabStop = false;
            this.tbLicens.Text = "Данная программа распространяется свободно";
            // 
            // FAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 222);
            this.Controls.Add(this.tbLicens);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lVersion);
            this.Controls.Add(this.lAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAbout";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAutor;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.TextBox tbLicens;
    }
}