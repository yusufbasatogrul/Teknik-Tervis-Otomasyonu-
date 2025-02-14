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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        public string id, serino;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;    
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            Tbl_UrunTakip t = new Tbl_UrunTakip();
            t.ACIKLAMA = RchArizaDetay.Text;
            t.SERINO = TxtSeriNo.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            db.Tbl_UrunTakip.Add(t);

            //2.GUNCELLEME
            Tbl_UrunKabul tb = new Tbl_UrunKabul();
            int urunid = int.Parse(id.ToString());
            var deger = db.Tbl_UrunKabul.Find(urunid);
            deger.URUNDURUMDETAY = comboBox1.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün arıza detayları güncellendi");
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void RchArizaDetay_Click(object sender, EventArgs e)
        {
            RchArizaDetay.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*DbTeknikServisEntities db = new DbTeknikServisEntities();
Tbl_UrunTakip t = new Tbl_UrunTakip();
t.ACIKLAMA = RichEditAciklama.Text;
t.SERINO = TxtSeriNo.Text;
t.TARIH = DateTime.Parse(TxtTarih.Text);
db.TBLURUNTAKIP.Add(t);


TBLURUNKABUL tb = new TBLURUNKABUL();
int urunid = int.Parse(id.ToString());
var deger = db.TBLURUNKABUL.Find(urunid);
deger.URUNDURUMDETAY = comboBoxKonu.Text;
db.SaveChanges();
MessageBox.Show("Ürün arıza detayları güncellendi");
}

private void TxtSeriNo_Click(object sender, EventArgs e)
{
TxtSeriNo.Clear();
}

private void TxtTarih_Click(object sender, EventArgs e)
{
TxtTarih.Text = DateTime.Now.ToShortDateString();
}

private void RichEditAciklama_Click(object sender, EventArgs e)
{
RichEditAciklama.ClearUndo();
}

private void ButtonUrunVazgec_Click(object sender, EventArgs e)
{
this.Close();
}

public string id, serino;

private void FrmArizaDetaylar_Load(object sender, EventArgs e)
{
TxtSeriNo.Text = serino;
}*/

    }
}
