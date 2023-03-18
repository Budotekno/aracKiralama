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
    public partial class FrmSozlesmeIslemleri : Form
    {
        public FrmSozlesmeIslemleri()
        {
            InitializeComponent();
        }

        #region FormlarınAçılması

        private void btnSozlesmeEkle_Click(object sender, EventArgs e)
        {
            txtAraTc.Text = "Tc'ye göre arama";
            txtAraTc.ForeColor = Color.Silver;
            dataGridView1.Focus();
            
            
            if (MessageBox.Show("Sözleşme imzalamak için önce Kiralama işlemlerini yapmanız gerekmektedir?\nKirala işlemi yapılsın mı?"
                , "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                FrmKiralamaIslemleri.aracKiralaAc();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sözleşmeyi güncellemek için kiralama güncelleme formuna yönlendiriliyorsunuz?\nİşlemi onaylıyor musunuz?"
               , "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                aracGuncelle();

            txtAraTc.Text = "Tc'ye göre arama";
            txtAraTc.ForeColor = Color.Silver;
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
                frm.rbtnNakit.Checked = true;
            else frm.rbtnKredi.Checked = true;
            frm.ShowDialog();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sözleşme iptal için önce Araç teslimi yapmanız gerekmektedir?\nAraç teslim yapılsın mı?"
               , "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                aracTeslim();


            txtAraTc.Text = "Tc'ye göre arama";
            txtAraTc.ForeColor = Color.Silver;
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



        #endregion

        #region listeleme

        private void listele()
        {
            string sorgu = "Select * from kiralama";
            DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "kiralama");
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void FrmSozlesmeIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            txtAraTc.Text = "Tc'ye göre arama";
            txtAraTc.ForeColor = Color.Silver;
            dataGridView1.Focus();     
            listele();
        }


        #endregion

        private void txtAraTc_Click(object sender, EventArgs e)
        {
            txtAraTc.Text = "";
        }

        private void txtAraTc_Leave(object sender, EventArgs e)
        {
            if (txtAraTc.Text == "")
            {
                txtAraTc.Text = "Tc'ye göre arama";
                txtAraTc.ForeColor = Color.Silver;
            }
        }

        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            if (txtAraTc.Text != "")
            {
                txtAraTc.ForeColor = Color.Black;
                string sorgu = "select * from kiralama where tc like '" + txtAraTc.Text + "%'";
                DataSet dataset = ClsVeriTabaniIslemleri.listele(sorgu, "kiralama");
                dataGridView1.DataSource = dataset.Tables[0];
            }
        }

        

        
    }
}
