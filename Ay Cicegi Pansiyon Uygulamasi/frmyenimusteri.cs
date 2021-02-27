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
    public partial class frmyenimusteri : Form
    {
        public frmyenimusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=aycicegipansiyon;Integrated Security=True");
        private void frmyenimusteri_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnoda101_Click(object sender, EventArgs e)
        {
            txtoda.Text = "101";
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtoda.Text = "102";
        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtoda.Text = "103";
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtoda.Text = "104";
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtoda.Text = "105";
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtoda.Text = "106";
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtoda.Text = "107";
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtoda.Text = "108";
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtoda.Text = "109";
        }

        private void btnoda110_Click(object sender, EventArgs e)
        {
            txtoda.Text = "110";
        }

        private void btnoda111_Click(object sender, EventArgs e)
        {
            txtoda.Text = "111";
        }

        private void btnoda112_Click(object sender, EventArgs e)
        {
            txtoda.Text = "112";
        }

        private void btnoda113_Click(object sender, EventArgs e)
        {
            txtoda.Text = "113";
        }

        private void btnoda114_Click(object sender, EventArgs e)
        {
            txtoda.Text = "114";
        }

        private void btnoda115_Click(object sender, EventArgs e)
        {
            txtoda.Text = "115";
        }

        private void btnoda116_Click(object sender, EventArgs e)
        {
            txtoda.Text = "116";
        }

        private void btnoda117_Click(object sender, EventArgs e)
        {
            txtoda.Text = "117";
        }

        private void btnoda118_Click(object sender, EventArgs e)
        {
            txtoda.Text = "118";
        }

        private void btnoda119_Click(object sender, EventArgs e)
        {
            txtoda.Text = "119";
        }

        private void btnoda120_Click(object sender, EventArgs e)
        {
            txtoda.Text = "120";
        }

        private void btnoda121_Click(object sender, EventArgs e)
        {
            txtoda.Text = "121";
        }

        private void btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kirmizi renkli butonlar doludur.");
        }

        private void btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yesil renkli butonlar bostur.");
        }

        private void cmbcinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpcikis_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpgiris.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpcikis.Text);

            TimeSpan sonuc = buyuktarih - kucuktarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text)*100;
            txtucret.Text = ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kayitekle = new SqlCommand("insert into musteriekle(adi,soyadi,cinsiyet,telefon,mail,tc,odano,ucret,giristarihi,cikistarihi) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",baglanti);

            kayitekle.Parameters.AddWithValue("@p1", txtadi.Text);
            kayitekle.Parameters.AddWithValue("@p2", txtsoyadi.Text);
            kayitekle.Parameters.AddWithValue("@p3", cmbcinsiyet.Text);
            kayitekle.Parameters.AddWithValue("@p4", txttelefon.Text);
            kayitekle.Parameters.AddWithValue("@p5", txtmail.Text);
            kayitekle.Parameters.AddWithValue("@p6", txttc.Text);
            kayitekle.Parameters.AddWithValue("@p7", txtoda.Text);
            kayitekle.Parameters.AddWithValue("@p8", txtucret.Text);
            kayitekle.Parameters.AddWithValue("@p9", dtpgiris.Value.ToString("yyyy-MM-dd"));
            kayitekle.Parameters.AddWithValue("@p10", dtpcikis.Value.ToString("yyyy-MM-dd"));


            kayitekle.ExecuteNonQuery();
            baglanti.Close();

            txtadi.Clear();
            txtmail.Clear();
            txtoda.Clear();
            txtsoyadi.Clear();
            txttc.Clear();
            txttelefon.Clear();
            txtucret.Clear();
            

            MessageBox.Show("kayit basarili sekilde kaydedildi...");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanaform fr = new frmanaform();
            fr.Show();
            this.Hide();

        }
    }
}
