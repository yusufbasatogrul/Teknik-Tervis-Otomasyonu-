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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        int secilen;
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Tbl_Cari t = new Tbl_Cari();
                t.AD = TxtCariAd.Text;
                t.SOYAD = TxtCariSoyad.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAIL = TxtMail.Text;
                t.IL = lookUpEditil.Text;
                t.ILCE = lookUpEditilce.Text;
                t.BANKA = TxtBanka.Text;
                t.VERGİDAİRESİ = TxtVergiDaire.Text;
                t.VERGİNO = TxtVergiNo.Text;
                t.STATU = TxtStatu.Text;
                t.ADRES = TxtAdres.Text;
                db.Tbl_Cari.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Başarılı Bir Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEditil.Properties.DataSource = (from x in db.Tbl_Iller
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehiradi
                                                  }).ToList();
            lookUpEditil.Properties.NullText = "Lütfen bir İL seçiniz";
            lookUpEditilce.Properties.NullText = "Lütfen bir İLÇE seçiniz";
        }

        private void lookUpEditilce_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEditil_EditValueChanged(object sender, EventArgs e)
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
    }
    
}
