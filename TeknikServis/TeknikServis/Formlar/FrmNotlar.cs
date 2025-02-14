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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.Tbl_Notlarım.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.Tbl_Notlarım.Where(x => x.DURUM == true).ToList();
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Tbl_Notlarım t = new Tbl_Notlarım();
            t.BASLIK = TxtBaslik.Text;
            t.ICERİK = TxtIcerik.Text;
            t.DURUM = false;
            t.TARIH = DateTime.Parse(textEdit1.Text);
            db.Tbl_Notlarım.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if(chkOkundu.Checked == true)
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.Tbl_Notlarım.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
