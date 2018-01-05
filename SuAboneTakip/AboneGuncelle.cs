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
    public partial class AboneGuncelle : Form
    {
        dataclassDataContext database = new dataclassDataContext();
        public AboneGuncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = Convert.ToDecimal(textBox1.Text);
                aboneBindingSource.DataSource = from Abone in database.Abones where Abone.Abone_ID.Equals(ID) select Abone;
                if (aboneBindingSource.DataSource == null)
                {
                    MessageBox.Show("Abone bulunamadı");
                    textBox1.Clear();
                }
                else
                {
                    dataGridView1.DataSource = aboneBindingSource;
                    dataGridView1.Enabled = true;
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

        private void AboneGuncelle_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView1.DataSource = null;
            MessageBox.Show("Güncellenmek istenen IDyi giriniz");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ID = Convert.ToDecimal(textBox1.Text);
           var update= from Abone in database.Abones where Abone.Abone_ID.Equals(ID) select Abone;
            int rowindex = dataGridView1.CurrentRow.Index;
            foreach(var u in update)
            {
                u.Abone_ID = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells[0].Value);
                u.İsim = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                u.Soyisim = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                u.Adres = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
                u.Telefon = Convert.ToDecimal(dataGridView1.Rows[rowindex].Cells[4].Value);
                u.EskiBorc = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[5].Value);
            }
        }
    }
}
