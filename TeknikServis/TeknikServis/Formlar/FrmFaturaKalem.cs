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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Listele()
        {
            var degerler = from u in db.Tbl_FaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_FaturaDetay t = new Tbl_FaturaDetay();
            t.URUN = TxtFaturaKalemUrun.Text;
            t.ADET = short.Parse(TxtFaturaKalemAdet.Text);
            t.FIYAT = decimal.Parse(TxtFaturaKalemFiyat.Text);
            t.TUTAR = decimal.Parse(TxtFaturaKalemTutar.Text);
            t.FATURAID = int.Parse(TxtFaturaKalemFaturaID.Text);
            db.Tbl_FaturaDetay.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya ait kalem girişi başarı ile yapıldı");
        }

        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.Tbl_FaturaDetay
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
