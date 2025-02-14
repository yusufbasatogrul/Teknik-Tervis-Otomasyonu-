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
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.Tbl_UrunHareket
                           select new
                           {
                               x.HAREKETID,
                               x.Tbl_Urun.AD,
                               MUSTERI = x.Tbl_Cari.AD + " " + x.Tbl_Cari.SOYAD,
                               PERSONEL = x.Tbl_Personel.AD +" " + x.Tbl_Personel.SOYAD,
                               x.TARİH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
