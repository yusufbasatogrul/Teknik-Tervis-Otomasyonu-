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
    public partial class FrmArizaliUrunKaydi : Form
    {
        
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {

           

            Tbl_UrunKabul t = new Tbl_UrunKabul();
            t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
            t.GELISTARIH = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = byte.Parse(lookUpEdit2.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.Tbl_UrunKabul.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Arıza Kaydı Girişi Yapıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri Getir
            lookUpEdit1.Properties.DataSource = (from x in db.Tbl_Cari
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit1.Properties.NullText = "Lütfen Müşteri Seçin";


            //Personel Getir
            lookUpEdit2.Properties.DataSource = (from x in db.Tbl_Personel
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            lookUpEdit2.Properties.NullText = "Lütfen Personel Seçin";

        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}
