namespace aracKiralama
{
    partial class FrmKullaniciGenel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullaniciGenel));
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new aracKiralama.aracKiralamaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personelTableAdapter = new aracKiralama.aracKiralamaDataSetTableAdapters.personelTableAdapter();
            this.aracBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracTableAdapter = new aracKiralama.aracKiralamaDataSetTableAdapters.aracTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.aracKiralamaDataSet;
            // 
            // aracKiralamaDataSet
            // 
            this.aracKiralamaDataSet.DataSetName = "aracKiralamaDataSet";
            this.aracKiralamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.personelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "aracKiralama.Formlar.Anasayfa.UstMenu.Diger.Raporlar.Report.RptKullaniciGenel.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(507, 518);
            this.reportViewer1.TabIndex = 0;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // aracBindingSource
            // 
            this.aracBindingSource.DataMember = "arac";
            this.aracBindingSource.DataSource = this.aracKiralamaDataSet;
            // 
            // aracTableAdapter
            // 
            this.aracTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKullaniciGenel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 518);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullaniciGenel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Genel Rapor";
            this.Load += new System.EventHandler(this.FrmKullaniciGenel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private aracKiralamaDataSet aracKiralamaDataSet;
        private aracKiralamaDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.BindingSource aracBindingSource;
        private aracKiralamaDataSetTableAdapters.aracTableAdapter aracTableAdapter;
    }
}