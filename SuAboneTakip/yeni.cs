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
    public partial class yeni : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public yeni()
        {
            InitializeComponent();
        }

        private void aboneBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                Abone yeni = new Abone();
                yeni.Abone_ID = Convert.ToDecimal(abone_IDTextBox.Text);
                yeni.Adres = richTextBox1.Text;
                yeni.Soyisim = soyisimTextBox.Text;
                yeni.Telefon = Convert.ToDecimal(telefonTextBox.Text);
                yeni.İsim = İsimTextBox.Text;
                
                database.Abones.InsertOnSubmit(yeni);
                database.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException v)
            {
                MessageBox.Show("Negatif ID giremezsiniz");

            }
            catch (System.FormatException f)
            {
                MessageBox.Show("Hiçbir alan boş bırakılamaz");
            }
        }
    }
}
