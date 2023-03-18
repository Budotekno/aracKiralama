using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{
    public partial class FrmKiralamaIslemleri : Form
    {
        public FrmKiralamaIslemleri()
        {
            InitializeComponent();
        }


        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            txtAraPlaka.Text = "Plakaya göre arama";
            txtAraPlaka.ForeColor = Color.Silver;
            dataGridView1.Focus();            
            aracKiralaAc();
        }
        public static void aracKiralaAc()
        {
            FrmAracKirala frm = new FrmAracKirala();
            frm.ShowDialog();
 
        }

        private void FrmKiralamaIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            string sorgu = "Select * from kiralama";
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "kiralama");
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
           
            txtAraPlaka.Text = "Plakaya göre arama";
            txtAraPlaka.ForeColor = Color.Silver;
            dataGridView1.Focus();
            listele();
           
           
        }

        private void FrmKiralamaIslemleri_Activated(object sender, EventArgs e)
        {
            listele();
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            aracGuncelle();   
            txtAraPlaka.Text = "Plakaya göre arama";
            txtAraPlaka.ForeColor = Color.Silver;
            dataGridView1.Focus();
            listele();

        }

        private void aracGuncelle()
        {
            FrmAracGuncelleme frm = new FrmAracGuncelleme();
            frm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPlaka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.dtpVerilis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.dtpTeslim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.mtxtTutar.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.mtxtEkTutar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.mtxtToplamTutar.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Nakit")
                frm.rbtnNakit.Checked=true;
            else frm.rbtnKredi.Checked = true;
            frm.ShowDialog();
        }

       
        private void btnAracTeslim_Click(object sender, EventArgs e)
        {

            aracTeslim();
            txtAraPlaka.Text = "Plakaya göre arama";
            txtAraPlaka.ForeColor = Color.Silver;
            dataGridView1.Focus();
            listele();
  
        }
        private void aracTeslim()
        {
            FrmAracTeslim frm = new FrmAracTeslim();
            frm.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtTc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtPlaka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.ShowDialog();
        }

        private void txtAraPlaka_Click(object sender, EventArgs e)
        {
            txtAraPlaka.Text = "";
        }

        private void txtAraPlaka_Leave(object sender, EventArgs e)
        {

            if (txtAraPlaka.Text == "")
            {
                txtAraPlaka.Text = "Plakaya göre arama";
                txtAraPlaka.ForeColor = Color.Silver;
            }
        }

        private void txtAraPlaka_TextChanged(object sender, EventArgs e)
        {

            if (txtAraPlaka.Text != "")
            {
                txtAraPlaka.ForeColor = Color.Black;
                string sorgu = "select * from kiralama where plaka like '" + txtAraPlaka.Text + "%'";
                DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "kiralama");
                dataGridView1.DataSource = dataset.Tables[0];
            }
            
        }
       
    }
}
