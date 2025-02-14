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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text != "" && TxtKategoriAd.Text.Length <= 30)
            {
                DbTeknikServisEntities db = new DbTeknikServisEntities();
                Tbl_Kategori t = new Tbl_Kategori();
                t.AD = TxtKategoriAd.Text;
                db.Tbl_Kategori.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Lütfen karakter sayısını 0-30 arasında giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            FrmYeniKategori fr = new FrmYeniKategori();
            this.Close();
        }
    }
}
