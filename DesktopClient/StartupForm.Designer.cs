
using System;

namespace DesktopClient
{
    partial class StartupForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.letmein = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.letmein);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(64, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logaj se";
            // 
            // letmein
            // 
            this.letmein.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letmein.Location = new System.Drawing.Point(165, 221);
            this.letmein.Name = "letmein";
            this.letmein.Size = new System.Drawing.Size(135, 39);
            this.letmein.TabIndex = 1;
            this.letmein.Text = "Let me in!";
            this.letmein.UseVisualStyleBackColor = true;
            this.letmein.Click += new System.EventHandler(this.letmein_Click);
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUser.Location = new System.Drawing.Point(125, 149);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(225, 36);
            this.tbUser.TabIndex = 0;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 453);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartupForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button letmein;
        private System.Windows.Forms.TextBox tbUser;

    }
}