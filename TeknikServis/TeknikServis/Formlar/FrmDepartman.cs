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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.Tbl_Departman
                           select new
                           {
                               u.ID,
                               u.AD,
                               

                           };
            gridControl1.DataSource = degerler.ToList();


            labelControl12.Text = db.Tbl_Departman.Count().ToString();
            labelControl14.Text = db.Tbl_Personel.Count().ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Departman t = new Tbl_Departman();
            if (TxtAd.Text.Length <= 50 && TxtAd.Text != "" && rchAciklama.Text.Length >= 1)
            {
                t.AD = TxtAd.Text;
                t.ACIKLAMA = rchAciklama.Text;
                db.Tbl_Departman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAd.Text = null;
                rchAciklama.Text = null;
            }
            else
                MessageBox.Show("Kayıt Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.Tbl_Departman.Find(id);
            db.Tbl_Departman.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.Tbl_Departman.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.Tbl_Departman
                           select new
                           {
                               u.ID,
                               u.AD,
                               

                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
           // rchAciklama.Text = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
        }
    }
}
