namespace WP_SuAboneTakip
{
    partial class Faturasil
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
            this.faturaId = new System.Windows.Forms.Label();
            this.faturaIdTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // faturaId
            // 
            this.faturaId.AutoSize = true;
            this.faturaId.Location = new System.Drawing.Point(86, 50);
            this.faturaId.Name = "faturaId";
            this.faturaId.Size = new System.Drawing.Size(49, 13);
            this.faturaId.TabIndex = 0;
            this.faturaId.Text = "Fatura Id";
            // 
            // faturaIdTextBox
            // 
            this.faturaIdTextBox.Location = new System.Drawing.Point(75, 12);
            this.faturaIdTextBox.Name = "faturaIdTextBox";
            this.faturaIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.faturaIdTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Faturasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.faturaIdTextBox);
            this.Controls.Add(this.faturaId);
            this.Name = "Faturasil";
            this.Text = "Faturasil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label faturaId;
        private System.Windows.Forms.TextBox faturaIdTextBox;
        private System.Windows.Forms.Button button1;
    }
}