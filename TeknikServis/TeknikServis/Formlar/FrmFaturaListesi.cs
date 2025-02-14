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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Listele()
        {
            var degerler = from u in db.Tbl_FaturaBilgi
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGİDAİRE,
                               CARIAD = u.Tbl_Cari.AD + u.Tbl_Cari.SOYAD,
                               PERSONELAD = u.Tbl_Personel.AD + u.Tbl_Personel.SOYAD
                           };

            //lookUpPersonelDepartman.Properties.DataSource = db.TBLDEPARTMAN.ToList();
            lookUpFaturaCari.Properties.DataSource = (from x in db.Tbl_Cari
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();

            lookUpFaturaPersonel.Properties.DataSource = (from x in db.Tbl_Personel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList(); ;

            gridControl1.DataSource = degerler.ToList();
        }
            private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
                Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_FaturaBilgi t = new Tbl_FaturaBilgi();
            t.SERI = TxtFaturaSeriNo.Text;
            t.SIRANO = TxtFaturaSiraNo.Text;
            t.TARIH = Convert.ToDateTime(TxtFaturaTarih.Text);
            t.SAAT = TxtFaturaSaat.Text;
            t.VERGİDAİRE = TxtFaturaVergiDairesi.Text;
            t.PERSONEL = short.Parse(lookUpFaturaPersonel.EditValue.ToString());
            t.CARI = int.Parse(lookUpFaturaCari.EditValue.ToString());
            db.Tbl_FaturaBilgi.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Sisteme Kaydedilmiştir, Kalem Girişi Yapabilirsiniz");
        }


        
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
