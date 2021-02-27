using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Cicegi_Pansiyon_Uygulamasi
{
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=aycicegipansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            frmanaform fr = new frmanaform();
            fr.Show();
            this.Hide();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from admingiris where kullanici='" + txtkullaniciadi.Text + "' and sifre='" + txtsifre.Text + "'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                frmanaform fr1 = new frmanaform();
                fr1.Show();
                this.Hide();
                MessageBox.Show("giris basarili...");
                
            }

            else
            {
                MessageBox.Show("yanlis girdiniz...");
                txtkullaniciadi.Clear();
                txtsifre.Clear();
            }

            baglanti.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("update admingiris set kullanici='"+txtkullaniciadi.Text+"',sifre='"+txtsifre.Text+"'", baglanti);


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("sifre basariyla guncellendi...");
        }
    }
}
