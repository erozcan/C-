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
    public partial class Faturalar : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public Faturalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ıd = Convert.ToDecimal(textBox1.Text);
                faturaBindingSource.DataSource = from Fatura in database.Faturas where Fatura.Abone_ID.Equals(ıd) orderby Fatura.Fatura_ID select Fatura;
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
    }
}
