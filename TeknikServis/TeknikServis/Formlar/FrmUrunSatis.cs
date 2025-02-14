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
    public partial class FrmUrunSatis : Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnSatisYap_Click(object sender, EventArgs e)
        {
            Tbl_UrunHareket t = new Tbl_UrunHareket(); int ID;
            if (int.TryParse(lookupEditurunid.Text, out ID))
            {
                t.URUN = ID;  // Geçerli ID ile işlemi yap
            }
            else
            {
                // Eğer geçerli bir sayı değilse, kullanıcıya uyarı ver
                MessageBox.Show("Lütfen geçerli bir ürün ID'si girin.");
            }


            t.MUSTERI = int.Parse(lookUpEditCari.Text);
            t.PERSONEL = short.Parse(lookUpEditPersonel.Text);
            t.TARİH = DateTime.Parse(TxtTarih.Text);
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatisFiyatı.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.Tbl_UrunHareket.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            lookupEditurunid.Properties.DataSource = (from x in db.Tbl_Urun
                                                  select new
                                                  {
                                                      x.ID,
                                                      x.AD
                                                  }).ToList();
            lookupEditurunid.Properties.NullText = "ÜRÜN";
            lookUpEditCari.Properties.NullText = "CARİ";
            lookUpEditPersonel.Properties.NullText = "PERSONEL";

            lookUpEditCari.Properties.DataSource = (from x in db.Tbl_Cari
                                                      select new
                                                      {
                                                          x.ID,
                                                          AD = x.AD + " " + x.SOYAD
                                                      }).ToList();
            lookUpEditPersonel.Properties.DataSource = (from x in db.Tbl_Personel
                                                      select new
                                                      {
                                                          x.ID,
                                                          AD= x.AD +" "+x.SOYAD
                                                      }).ToList();
        }

        private void lookupEditurunid_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
