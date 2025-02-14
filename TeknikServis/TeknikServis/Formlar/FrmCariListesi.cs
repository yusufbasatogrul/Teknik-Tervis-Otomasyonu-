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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        void listele()
        {
             var degerler = (from x in db.Tbl_Cari
             select new
             {
                 x.ID,
                 AD = x.AD + " " + x.SOYAD,
                 x.IL,
                 x.ILCE
             }).ToList();
            gridControl1.DataSource = degerler.ToList();
        }
        int secilen;
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            listele();
            LblToplamCariSayisi.Text = db.Tbl_Cari.Count().ToString();
            lookUpEditil.Properties.DataSource = (from x in db.Tbl_Iller
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehiradi
                                                 }).ToList();
            lookUpEditil.Properties.NullText = "Lütfen bir İL seçiniz";
            LblToplamilceSayisi.Text = db.Tbl_Cari.Select(x => x.ILCE).Distinct().Count().ToString();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl18_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEditil.EditValue.ToString());
            lookUpEditilce.Properties.DataSource = (from y in db.Tbl_Ilceler
                                                 where y.sehirid == secilen
                                                 select new
                                                 {
                                                     y.id,
                                                     y.ilceadi
                                                 }).ToList();
            lookUpEditilce.Properties.NullText = "Lütfen bir İLÇE seçiniz";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Cari t = new Tbl_Cari();
            t.AD = TxtCariAd.Text;
            t.SOYAD = TxtCariSoyad.Text;
            t.TELEFON = TxtTelefon.Text;
            t.IL = lookUpEditil.Text;
            t.ILCE = lookUpEditilce.Text;
            t.BANKA = TxtBanka.Text;
            t.VERGİDAİRESİ = TxtVergiDairesi.Text;
            t.VERGİNO = TxtVergiNO.Text;
            t.STATU = TxtStatu.Text;
            t.ADRES = TxtAdres.Text;
            
          
            db.Tbl_Cari.Add(t);
            db.SaveChanges();
            MessageBox.Show("CARİ BAŞARIYLA EKLENDİ");
            listele();
        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void lookUpEditilce_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
