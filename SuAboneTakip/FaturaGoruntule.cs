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
    public partial class FaturaGoruntule : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        Faturalar f1 = new Faturalar();
        public FaturaGoruntule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = Convert.ToDecimal(textBox1.Text);
                var abone = from Abone in database.Abones where Abone.Abone_ID.Equals(ID) orderby Abone.İsim, Abone.Soyisim select Abone;
                if (abone == null)
                {
                    MessageBox.Show("AboneBulunamadı");
                }
                else
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    label1.Enabled = false;
                    f1.MdiParent = this;
                    f1.Show();
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
