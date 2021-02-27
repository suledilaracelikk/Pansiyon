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
    public partial class kayitlimusteriler : Form
    {
        public kayitlimusteriler()
        {
            InitializeComponent();
        }

        private void kayitlimusteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aycicegipansiyonDataSet.musteriekle' table. You can move, or remove it, as needed.
            this.musteriekleTableAdapter.Fill(this.aycicegipansiyonDataSet.musteriekle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmanaform fr = new frmanaform();
            fr.Show();
            this.Hide();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            musteriguncelle fr = new musteriguncelle(textBox1.Text);
            
            fr.Show();
            this.Hide();

            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
        }



    }

    }

