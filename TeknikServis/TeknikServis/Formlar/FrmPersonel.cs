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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();

        private void Listele()
        {
            
            var degerler = from u in db.Tbl_Personel
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON,


                           };
            gridControl1.DataSource = degerler.ToList();

            gridControl1.DataSource = degerler.ToString();

            lookUpPersonelDepartman.Properties.DataSource = (from x in db.Tbl_Departman
                                                select new
                                                {
                                                    x.ID,
                                                    x.AD
                                                }).ToList();

        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            Listele();
            string ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;


            //1.Personel
            ad1 = db.Tbl_Personel.First(x => x.ID == 1).AD;
            soyad1 = db.Tbl_Personel.First(x => x.ID == 1).SOYAD;
            labelControl12.Text = ad1 + " " + soyad1;
            labelControl5.Text = db.Tbl_Personel.First(x => x.ID == 1).MAIL;
            labelControl3.Text = db.Tbl_Personel.First(x => x.ID == 1).Tbl_Departman.AD;

            //2.Personel
            ad2 = db.Tbl_Personel.First(x => x.ID == 6).AD;
            soyad2 = db.Tbl_Personel.First(x => x.ID == 6).SOYAD;
            labelControl14.Text = ad2 + " " + soyad2;
            labelControl8.Text = db.Tbl_Personel.First(x => x.ID == 6).MAIL;
            labelControl10.Text = db.Tbl_Personel.First(x => x.ID == 6).Tbl_Departman.AD;

            //3.Personel
            ad3 = db.Tbl_Personel.First(x => x.ID == 2).AD;
            soyad3 = db.Tbl_Personel.First(x => x.ID == 2).SOYAD;
            labelControl32.Text = ad3 + " " + soyad3;
            labelControl16.Text = db.Tbl_Personel.First(x => x.ID == 2).MAIL;
            labelControl18.Text = db.Tbl_Personel.First(x => x.ID == 2).Tbl_Departman.AD;

            //4.Personel
            ad4 = db.Tbl_Personel.First(x => x.ID == 7).AD;
            soyad4 = db.Tbl_Personel.First(x => x.ID == 7).SOYAD;
            labelControl20.Text = ad4 + " " + soyad4;
            labelControl22.Text = db.Tbl_Personel.First(x => x.ID == 7).MAIL;
            labelControl24.Text = db.Tbl_Personel.First(x => x.ID == 7).Tbl_Departman.AD;



        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Tbl_Personel t = new Tbl_Personel();
            t.AD = TxtPersonelAd.Text;
            t.SOYAD = TxtPersonelSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpPersonelDepartman.EditValue.ToString());
            db.Tbl_Personel.Add(t);
            db.SaveChanges();
            MessageBox.Show("PERSONEL SİSTEME EKLENDİ");
            Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
