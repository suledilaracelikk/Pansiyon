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
    public partial class musterisil : Form
    {
        public musterisil()
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from musteriekle where adi=@adi",baglanti);

            komut.Parameters.AddWithValue("@adi", txtsil.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("kayit basariyla silindi...");
            baglanti.Close();
        }
    }
}
