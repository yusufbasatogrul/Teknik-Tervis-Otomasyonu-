using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.Tbl_Urun.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).
                Select(z => new
                {
                    Marka = z.Key,
                    Toplam = z.Count()
                });
            gridControl1.DataSource = degerler.ToList();

            labelControl2.Text = db.Tbl_Urun.Count().ToString();
            labelControl3.Text = (from x in db.Tbl_Urun
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.Tbl_Urun
                                   orderby x.SATISFIYAT descending
                                   select x.MARKA).FirstOrDefault();
            labelControl5.Text = db.maksurunmarka().FirstOrDefault();

            chartControl1.Series["Series 1"].Points.AddPoint("SIEMENS", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("ARÇELİK", 7);
            chartControl1.Series["Series 1"].Points.AddPoint("BEKO", 6);
            chartControl1.Series["Series 1"].Points.AddPoint("BOSH", 5);
            chartControl1.Series["Series 1"].Points.AddPoint("VESTEL", 3);
            chartControl1.Series["Series 1"].Points.AddPoint("PHILIPS", 10);
            chartControl1.Series["Series 1"].Points.AddPoint("FAKİR", 27);
            chartControl1.Series["Series 1"].Points.AddPoint("ARZUM", 15);
            
            
            //1.CHART
            SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-OH4EKOT\MSSQLSERVER01;Initial Catalog=DbTeknikServis;Integrated Security=True");
            bgl.Open();
            SqlCommand komut = new SqlCommand(@"SELECT  MARKA, Count(*) from tbl_urun group by MARKA", bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            bgl.Close();

            //2.CHART
           /* SqlConnection bgl1 = new SqlConnection(@"Data Source=DESKTOP-OH4EKOT\MSSQLSERVER01;Initial Catalog=DbTeknikServis;Integrated Security=True");
            bgl1.Open();
            SqlCommand komut2 = new SqlCommand(@"SELECT Tbl_Kategori.AD,COUNT(*) FROM Tbl_Urun
                                                INNER JOIN Tbl_Kategori 
                                                ON Tbl_Urun.KATEGORİ = Tbl_Kategori.ID
                                                GROUP BY Tbl_Kategori.AD",bgl1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategori"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            bgl1.Close();*/

        }
    }
}
