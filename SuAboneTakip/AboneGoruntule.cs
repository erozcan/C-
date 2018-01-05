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
    public partial class AboneGoruntule : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public AboneGoruntule()
        {
            InitializeComponent();
        }

        private void AboneGoruntule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = Convert.ToDecimal(textBox1.Text);
                aboneBindingSource.DataSource = from Abone in database.Abones where Abone.Abone_ID.Equals(ID) orderby Abone.İsim, Abone.Soyisim select Abone;
                if (aboneBindingSource.DataSource == null)
                {
                    MessageBox.Show("Aradaginiz abone bulunamadı");
                    textBox1.Clear();
                }
                else
                {
                    dataGridView1.DataSource = aboneBindingSource;

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
