namespace PolimorfismoForm
{
    partial class FrmCirculo
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
            this.btnUno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(12, 209);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(260, 40);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "Presiona para ver la figura";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // FrmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUno);
            this.Name = "FrmCirculo";
            this.Text = "FrmCirculo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUno;
    }
}