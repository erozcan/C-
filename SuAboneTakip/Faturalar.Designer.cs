namespace WP_SuAboneTakip
{
    partial class Faturalar
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "FaturaGoruntule";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FaturaID";
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
            this.dataGridView1.Location = new System.Drawing.Point(42, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 150);
            this.dataGridView1.TabIndex = 3;
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
            // Faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Faturalar";
            this.Text = "Faturalar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource faturaBindingSource;
    }
}