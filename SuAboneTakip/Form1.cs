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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeni yeniabone = new yeni();
            yeniabone.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YeniFatura yni = new YeniFatura();
            yni.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboneSorgula abone = new AboneSorgula();
            abone.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FaturaSorgula ftra = new FaturaSorgula();
            ftra.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AboneGuncelle aboneguncelle = new AboneGuncelle();
            aboneguncelle.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FaturaGuncelle fatura = new FaturaGuncelle();
            fatura.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AboneSil abone = new AboneSil();
            abone.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          Faturasil fatura = new Faturasil();
          fatura.Show();

        }

        
    }
}
