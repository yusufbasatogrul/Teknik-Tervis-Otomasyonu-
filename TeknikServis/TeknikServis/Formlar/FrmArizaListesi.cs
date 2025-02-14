using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.Tbl_UrunKabul
                           select new
                           {
                               x.ISLEMID,

                               CARI = x.Tbl_Cari.AD + " " + x.Tbl_Cari.SOYAD,
                               PERSONELAD = x.Tbl_Personel.AD + " " + x.Tbl_Personel.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIH,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY

                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl3.Text = db.Tbl_UrunKabul.Count(x => x.URUNDURUM==true ).ToString();
            labelControl5.Text = db.Tbl_UrunKabul.Count(x => x.URUNDURUM==false ).ToString();
            labelControl15.Text = db.Tbl_UrunKabul.Count().ToString();
            labelControl7.Text = db.Tbl_UrunKabul.Count(x => x.URUNDURUMDETAY == "Parça bekleniyor").ToString();
            labelControl11.Text = db.Tbl_UrunKabul.Count(x => x.URUNDURUMDETAY == "Mesaj bekleniyor").ToString();
            labelControl13.Text = db.Tbl_UrunKabul.Count(x => x.URUNDURUMDETAY == "İptal bekleniyor").ToString();

            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-OH4EKOT\MSSQLSERVER01;Initial Catalog=DbTeknikServis;Integrated Security=True");
            bgl.Open();
            SqlCommand komut = new SqlCommand(@"SELECT  URUNDURUMDETAY, Count(*) from Tbl_UrunKabul group by URUNDURUMDETAY", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
            fr.Show();
       
        }
    }
}
