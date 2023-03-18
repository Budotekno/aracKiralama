using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace aracKiralama
{
    public partial class FrmLogIslemleri : Form
    {
        public FrmLogIslemleri()
        {
            InitializeComponent();
        }

        private void FrmLogIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            string sorgu = "Select * from log";
            ClsVeriTabaniIslemleri.listele(sorgu, "log");
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "kiralama");
            dataGridView1.DataSource = dataset.Tables[0];
            
        }

      

        private void txtAraLog_Click(object sender, EventArgs e)
        {
            txtAraLog.Text = "";
        }

        private void txtAraLog_Leave(object sender, EventArgs e)
        {
            if (txtAraLog.Text == "")
            {

                txtAraLog.Text = "Hata yerine göre";
                txtAraLog.ForeColor = Color.Silver;
                listele();
            }
        }

        private void txtAraLog_TextChanged(object sender, EventArgs e)
        {
            if (txtAraLog.Text != "")
            {
                txtAraLog.ForeColor = Color.Black;
                string sorgu = "select * from log where hataYeri like '" + txtAraLog.Text + "%'";
                DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "log");
                dataGridView1.DataSource = dataset.Tables[0];
            }
            else {
                listele();
            }
        }
    }
}
