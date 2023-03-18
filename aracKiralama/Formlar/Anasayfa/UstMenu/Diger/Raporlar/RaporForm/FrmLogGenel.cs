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
    public partial class FrmLogGenel : Form
    {
        public FrmLogGenel()
        {
            InitializeComponent();
        }

        private void FrmLogGenel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracKiralamaDataSet.log' table. You can move, or remove it, as needed.
            this.logTableAdapter.Fill(this.aracKiralamaDataSet.log);

            this.reportViewer1.RefreshReport();
        }
    }
}
