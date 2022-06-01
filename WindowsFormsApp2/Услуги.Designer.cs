namespace WindowsFormsApp2
{
    partial class Услуги
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
            this.cl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cl
            // 
            this.cl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.cl.Location = new System.Drawing.Point(670, 387);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(118, 51);
            this.cl.TabIndex = 0;
            this.cl.Text = "Клиенты";
            this.cl.UseVisualStyleBackColor = false;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // Услуги
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.cl);
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "Услуги";
            this.Text = "Услуги";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cl;
    }
}