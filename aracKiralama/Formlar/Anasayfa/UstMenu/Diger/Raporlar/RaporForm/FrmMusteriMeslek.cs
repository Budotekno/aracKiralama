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
    public partial class FrmMusteriMeslek : Form
    {
        public FrmMusteriMeslek()
        {
            InitializeComponent();
        }

        private void FrmMusteriMeslek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracKiralamaDataSet.musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.aracKiralamaDataSet.musteri);

            this.reportViewer1.RefreshReport();
        }
    }
}
