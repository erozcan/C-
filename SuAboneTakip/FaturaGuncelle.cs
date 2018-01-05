using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_SuAboneTakip
{
    public partial class FaturaGuncelle : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public FaturaGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = Convert.ToDecimal(textBox1.Text);
                var abone = from Abone in database.Abones where Abone.Abone_ID.Equals(ID) select Abone;
                if (abone == null)
                {
                    MessageBox.Show("Abone bulunamadı");
                    textBox1.Clear();
                }
                else
                {
                    textBox2.Enabled = true;
                    label1.Enabled = true;
                }
            }
            catch (System.FormatException v)
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz");
            }
        }

        private void FaturaGuncelle_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            label1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                var ıd = Convert.ToDecimal(textBox2.Text);
                faturaBindingSource.DataSource = from Fatura in database.Faturas where Fatura.Fatura_ID.Equals(ıd) orderby Fatura.Fatura_ID select Fatura;
                if (faturaBindingSource.DataSource == null)
                {
                    MessageBox.Show("Aradagınız abone bulunmamaktadır");
                }
                else
                {

                    dataGridView1.DataSource = faturaBindingSource;

                }
            }
            catch (System.FormatException g)
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz");
            }
            catch (System.Data.SqlClient.SqlException v)
            {
                MessageBox.Show("Negatif ID giremezsiniz");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var aboneıd = Convert.ToDecimal(textBox1.Text);
            var faturaıd = Convert.ToDecimal(textBox2.Text);
            var update = from Fatura in database.Faturas where Fatura.Abone_ID.Equals(aboneıd) && Fatura.Fatura_ID.Equals(faturaıd) select Fatura;
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            foreach(var v in update)
            {
                v.Abone_ID = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells[0].Value);
                v.Fatura_ID = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[1].Value);
                v.Fatura_DATE = Convert.ToDateTime(dataGridView1.Rows[rowindex].Cells[2].Value);
                v.Fatura_Borc = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[3].Value);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dataGridView1.Rows.Clear();
            this.FaturaGuncelle_Load(sender,e);
        }
    }
}
