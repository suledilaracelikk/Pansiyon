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
    public partial class musteriguncelle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=aycicegipansiyon;Integrated Security=True");
        string ad="";

        public musteriguncelle(string ad)
        {
            
            this.ad = ad;
            InitializeComponent();
            
        }
        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update musteriekle set adi='"+txtadi.Text+"',soyadi='"+txtsoyadi.Text+"',cinsiyet='"+cmbcinsiyet.Text+"',telefon='"+txttelefon.Text+"',mail='"+txtmail.Text+"',tc='"+txttc.Text+"',odano='"+txtoda.Text+"',ucret='"+txtucret.Text+"' where adi='"+ad+"'",baglanti);


            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayit basarili sekilde güncellendi...");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanaform fr = new frmanaform();
            fr.Show();
            this.Hide();
        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void musteriguncelle_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }
    }
}
