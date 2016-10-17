namespace PolimorfismoForm
{
    partial class FrmRectangulo
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
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.Location = new System.Drawing.Point(12, 194);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(260, 55);
            this.btnRectangulo.TabIndex = 1;
            this.btnRectangulo.Text = "Presiona para ver la figura";
            this.btnRectangulo.UseVisualStyleBackColor = true;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRectangulo);
            this.Name = "FrmRectangulo";
            this.Text = "FrmRectangulo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRectangulo;
    }
}