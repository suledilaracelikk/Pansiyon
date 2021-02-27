using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ay_Cicegi_Pansiyon_Uygulamasi
{
    public partial class frmodalar : Form
    {
        public frmodalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J541L4J\\MSSQLSERVER02;Initial Catalog=aycicegipansiyon;Integrated Security=True");
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanaform fr = new frmanaform();
            fr.Show();
            this.Hide();
        }

        private void frmodalar_Load(object sender, EventArgs e)
        {
             baglanti.Open();
             SqlCommand komut = new SqlCommand("select odano from musteriekle",baglanti );

            
             SqlDataReader da= komut.ExecuteReader();

            List<int> array = new List<int>();

            while (da.Read())
            {
                array.Add(Convert.ToInt32(da["odano"]));
            }

          

            foreach(int i in array)
            {

                foreach (Control c in groupBox2.Controls)
                {
                    if (c.GetType() == typeof(Button))
                    {
                       
                        if(c.Text== "BOS" || c.Text == "DOLU")
                        {
                           
                            continue;

                        }
                        if (c.BackColor != Color.Red) { c.BackColor = Color.Green; }
                        
                        if (i == Convert.ToInt32(c.Text))
                        {
                            c.BackColor = Color.Red;
                            
                        }
                    
                       

                    }
                }


                
            }

           
        }
    }
}
