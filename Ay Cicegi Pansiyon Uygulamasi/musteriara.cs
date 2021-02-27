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
    public partial class musteriara : Form
    {
        public musteriara()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=aycicegipansiyon;Integrated Security=True");

        private void btnkaydet_Click(object sender, EventArgs e)
        {


         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmanaform fr = new frmanaform();
            fr.Show();
            this.Hide();
        }

        private void verilerigoster()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from musteriekle where adi='"+txtadi.Text+"' ", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["musteriid"].ToString();
                ekle.SubItems.Add(oku["adi"].ToString());
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
                ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }
        private void btnkaydet_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster();
        }

        
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            int musteriid = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);

            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            //txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            //cmbcinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            //txttelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            //txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            //txttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            //txtoda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            //txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            //dtpgiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            //dtpcikis.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        
       
    }
}
