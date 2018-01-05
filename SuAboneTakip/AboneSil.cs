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
    public partial class AboneSil : Form
    {

        private dataclassDataContext database = new dataclassDataContext();

        public AboneSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ID = 0;
            try
            {
                ID = Convert.ToDecimal(idTextBox.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hatalı veri girdiniz!");
            }

            Abone abone = (from a in database.Abones where a.Abone_ID.Equals(ID) orderby a.İsim, a.Soyisim select a).Single();
            if (abone == null)
            {
                MessageBox.Show("Böyle bir abone yok!");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarılı!");
                database.Abones.DeleteOnSubmit(abone);
                database.SubmitChanges();
            }
        }
    }
}
