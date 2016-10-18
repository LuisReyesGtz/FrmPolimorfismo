using System;

namespace PolimorfismoForm
{
    partial class FrmDecision
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
            this.btnC = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(12, 32);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(260, 57);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Circle";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(16, 98);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(256, 58);
            this.btnT.TabIndex = 6;
            this.btnT.Text = "Triangle";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(16, 162);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(256, 63);
            this.btnR.TabIndex = 7;
            this.btnR.Text = "Square";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // FrmDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnC);
            this.Name = "FrmDecision";
            this.Text = "Elige";
            this.Load += new System.EventHandler(this.FrmDecision_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnC;
        private EventHandler FrmDesicion;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnR;
    }
}

