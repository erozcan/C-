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
    public partial class Faturasil : Form
    {
        private dataclassDataContext database = new dataclassDataContext();
        public Faturasil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ID = 0;
            try
            {
                ID = Convert.ToDecimal(faturaIdTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hatalı veri girdiniz!");
            }

            Fatura fatura = (from a in database.Faturas where a.Fatura_ID.Equals(ID)  select a).SingleOrDefault();
            if (fatura == null)
            {
                MessageBox.Show("Böyle bir fatura yok!");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarılı!");
                database.Faturas.DeleteOnSubmit(fatura);
                database.SubmitChanges();
            }
        }
    }
}
