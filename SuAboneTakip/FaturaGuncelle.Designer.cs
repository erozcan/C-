namespace WP_SuAboneTakip
{
    partial class FaturaGuncelle
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AboneID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // AboneID
            // 
            this.AboneID.AutoSize = true;
            this.AboneID.Location = new System.Drawing.Point(118, 36);
            this.AboneID.Name = "AboneID";
            this.AboneID.Size = new System.Drawing.Size(49, 13);
            this.AboneID.TabIndex = 1;
            this.AboneID.Text = "AboneID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FaturaID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "BUL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aboneIDDataGridViewTextBoxColumn,
            this.faturaIDDataGridViewTextBoxColumn,
            this.faturaDATEDataGridViewTextBoxColumn,
            this.faturaBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.faturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataSource = typeof(WP_SuAboneTakip.Fatura);
            // 
            // aboneIDDataGridViewTextBoxColumn
            // 
            this.aboneIDDataGridViewTextBoxColumn.DataPropertyName = "Abone_ID";
            this.aboneIDDataGridViewTextBoxColumn.HeaderText = "Abone_ID";
            this.aboneIDDataGridViewTextBoxColumn.Name = "aboneIDDataGridViewTextBoxColumn";
            // 
            // faturaIDDataGridViewTextBoxColumn
            // 
            this.faturaIDDataGridViewTextBoxColumn.DataPropertyName = "Fatura_ID";
            this.faturaIDDataGridViewTextBoxColumn.HeaderText = "Fatura_ID";
            this.faturaIDDataGridViewTextBoxColumn.Name = "faturaIDDataGridViewTextBoxColumn";
            // 
            // faturaDATEDataGridViewTextBoxColumn
            // 
            this.faturaDATEDataGridViewTextBoxColumn.DataPropertyName = "Fatura_DATE";
            this.faturaDATEDataGridViewTextBoxColumn.HeaderText = "Fatura_DATE";
            this.faturaDATEDataGridViewTextBoxColumn.Name = "faturaDATEDataGridViewTextBoxColumn";
            // 
            // faturaBorcDataGridViewTextBoxColumn
            // 
            this.faturaBorcDataGridViewTextBoxColumn.DataPropertyName = "Fatura_Borc";
            this.faturaBorcDataGridViewTextBoxColumn.HeaderText = "Fatura_Borc";
            this.faturaBorcDataGridViewTextBoxColumn.Name = "faturaBorcDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(98, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FaturaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 577);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AboneID);
            this.Controls.Add(this.textBox1);
            this.Name = "FaturaGuncelle";
            this.Text = "FaturaGuncelle";
            this.Load += new System.EventHandler(this.FaturaGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label AboneID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}