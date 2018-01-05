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
    public partial class YeniFatura : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public YeniFatura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fatura yeniFatura = new Fatura();
                yeniFatura.Abone_ID = Convert.ToDecimal(AboneID.Text);
                yeniFatura.Fatura_Borc = Convert.ToInt32(FaturaBorc.Text);
                yeniFatura.Fatura_DATE = Convert.ToDateTime(dateTimePicker1.Text);
                yeniFatura.Fatura_ID = Convert.ToInt32(FaturaID.Text);
                database.Faturas.InsertOnSubmit(yeniFatura);
                database.SubmitChanges();
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
