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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.Tbl_Urun.Count().ToString();
            labelControl3.Text = db.Tbl_Kategori.Count().ToString();
            labelControl5.Text = db.Tbl_Urun.Sum(x => x.STOK).ToString();
            labelControl7.Text = "12";
            labelControl17.Text = (from x in db.Tbl_Urun
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl15.Text = (from x in db.Tbl_Urun
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.Tbl_Urun
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl19.Text = (from x in db.Tbl_Urun
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl23.Text = db.Tbl_Urun.Count(x => x.KATEGORİ == 4).ToString();
            labelControl21.Text = db.Tbl_Urun.Count(x => x.KATEGORİ == 1).ToString();
            labelControl29.Text = db.Tbl_Urun.Count(x => x.KATEGORİ == 3).ToString();
            labelControl39.Text = (from x in db.Tbl_Urun
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl35.Text = db.Tbl_UrunKabul.Count().ToString();
            labelControl13.Text = db.makskategoriurun().FirstOrDefault(); 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
