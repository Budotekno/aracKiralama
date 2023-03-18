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
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }

        private void FrmAcilis_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private byte tekrar = 0;

        private void tmrParlaklikArti_Tick(object sender, EventArgs e)
        {

           

            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
            }
            else 
            {
                tekrar++;
                if (tekrar == 2)
                {
                   
                    tmrParlaklikArti.Enabled = false;
                    tmrParlaklikEksi.Enabled = false;
                    tmrBar.Enabled = true;

                }

                else
                {
                    tmrParlaklikArti.Enabled = false;
                    tmrParlaklikEksi.Enabled = true;
                
                }

            }
 
        }


        private void tmrParlaklikEksi_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.01;
            }
            else
            {
               
                tmrParlaklikArti.Enabled = true;
                tmrParlaklikEksi.Enabled = false;
            }

        }

        private void tmrBar_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {

                tmrBar.Enabled = false;
                FrmGiris frm = new FrmGiris();
                this.Hide();
                frm.Show();

            }
        }
    }
}
