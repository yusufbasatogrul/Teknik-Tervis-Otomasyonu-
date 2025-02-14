using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        public int id;
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            //label1.Text = id.ToString();
            gridControl1.DataSource = db.Tbl_FaturaDetay.Where(x => x.FATURAID == id).ToList();
            gridControl2.DataSource = db.Tbl_FaturaBilgi.Where(x => x.ID == id).ToList();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
            MessageBox.Show("Kaydedildi.");
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Xls";
            gridControl1.ExportToXls(path);
            MessageBox.Show("Kaydedildi.");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
