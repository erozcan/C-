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
    public partial class AboneSorgula : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public AboneSorgula()
        {
            InitializeComponent();
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
                    AboneDataGrid.DataSource = aboneBindingSource;
                    button1.Enabled = true;
                }
            }
            catch (System.FormatException v)
            {
                MessageBox.Show("Hiç bir alan boş bırakılamaz");
            }

        }
            

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AboneSorgula_Load(object sender, EventArgs e)
        {
            AboneDataGrid.DataSource = null;
            button1.Enabled = true;
        }
    }
}
