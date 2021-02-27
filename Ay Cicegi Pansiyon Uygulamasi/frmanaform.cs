using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Cicegi_Pansiyon_Uygulamasi
{
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmadmingiris fr = new frmadmingiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmyenimusteri fr1 = new frmyenimusteri();
            fr1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayitlimusteriler fr = new kayitlimusteriler();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmodalar fr = new frmodalar();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            musteriguncelle fr = new musteriguncelle("");
            fr.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            musterisil fr = new musterisil();
            fr.Show();
            this.Hide();
        }

        private void frmanaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            musteriara fr = new musteriara();
            fr.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            frmmesaj fr = new frmmesaj();
            fr.Show();
            this.Hide();
        }
    }
}
