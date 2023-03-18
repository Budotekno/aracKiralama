namespace aracKiralama
{
    partial class FrmMusteriMeslek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriMeslek));
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracKiralamaDataSet = new aracKiralama.aracKiralamaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.musteriTableAdapter = new aracKiralama.aracKiralamaDataSetTableAdapters.musteriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.aracKiralamaDataSet;
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
            reportDataSource1.Value = this.musteriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "aracKiralama.Formlar.Anasayfa.UstMenu.Diger.Raporlar.Report.RptMusteriMeslek.rdlc" +
    "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1252, 590);
            this.reportViewer1.TabIndex = 0;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMusteriMeslek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 590);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMusteriMeslek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Meslek Rapor";
            this.Load += new System.EventHandler(this.FrmMusteriMeslek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracKiralamaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private aracKiralamaDataSet aracKiralamaDataSet;
        private aracKiralamaDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
    }
}