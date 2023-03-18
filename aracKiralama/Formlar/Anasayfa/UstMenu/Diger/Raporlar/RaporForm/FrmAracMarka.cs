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
    public partial class FrmAracMarka : Form
    {
        public FrmAracMarka()
        {
            InitializeComponent();
        }

        private void FrmAracMarka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracKiralamaDataSet.arac' table. You can move, or remove it, as needed.
            this.aracTableAdapter.Fill(this.aracKiralamaDataSet.arac);

            this.reportViewer1.RefreshReport();
        }
    }
}
