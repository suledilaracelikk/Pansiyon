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
    public partial class frmmesaj : Form
    {
        public frmmesaj()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=aycicegipansiyon;Integrated Security=True");
       
        private void verilerigoster()
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from mesajlar ", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["mesaj"].ToString());


                listView1.Items.Add(ekle);
            }

            baglanti.Close();
         
        }
        
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kayitekle = new SqlCommand("insert into mesajlar(adsoyad,mesaj) values (@p1,@p2)", baglanti);

            kayitekle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@p2", richTextBox1.Text);

            kayitekle.ExecuteNonQuery();
            baglanti.Close();

            textBox1.Clear();
            richTextBox1.Clear();
            MessageBox.Show("mesaj basariyla kaydedildi...");
        }


        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from mesajlar where adsoyad=@adi", baglanti);

            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("mesaj basariyla silindi...");
            baglanti.Close();
        }
    }
    }

