namespace WindowsFormsApp2
{
    partial class Товары
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
            this.usl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usl
            // 
            this.usl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.usl.Location = new System.Drawing.Point(662, 392);
            this.usl.Name = "usl";
            this.usl.Size = new System.Drawing.Size(126, 46);
            this.usl.TabIndex = 0;
            this.usl.Text = "Услуги";
            this.usl.UseVisualStyleBackColor = false;
            this.usl.Click += new System.EventHandler(this.usl_Click);
            // 
            // Товары
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.usl);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Товары";
            this.Text = "Товары";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usl;
    }
}