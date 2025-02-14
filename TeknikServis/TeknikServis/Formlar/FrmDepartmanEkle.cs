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
    public partial class FrmDepartmanEkle : Form
    {
        public FrmDepartmanEkle()
        {
            InitializeComponent();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            
            Tbl_Departman t = new Tbl_Departman();
            
            if (TxtDepartmanAd.Text.Length <= 50 && TxtDepartmanAd.Text != "" && TxtDepartmanAd.Text != "Departman Adı")
            {
                t.AD = TxtDepartmanAd.Text;
                
                db.Tbl_Departman.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Kayıt Başarısız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
