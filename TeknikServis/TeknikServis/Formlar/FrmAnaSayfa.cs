using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TeknikServis.Formlar
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControlKritikSeviye.DataSource = (from x in db.Tbl_Urun
                                                  select new
                                                  {
                                                      x.AD,
                                                      x.STOK
                                                  }).Where(x => x.STOK < 30).ToList();

            gridControlFihrist.DataSource = (from y in db.Tbl_Cari
                                             select new
                                             {
                                                 AD = y.AD + " " + y.SOYAD,
                                                 y.IL
                                             }).ToList();

            gridControlKategoriUrun.DataSource = db.urunkategori().ToList();

            DateTime bugun = DateTime.Today;
            var degerler = (from x in db.Tbl_Notlarım.OrderBy(y => y.ID)
                            where (x.TARIH == bugun)
                            select new
                            {
                                x.BASLIK,
                                x.ICERİK
                            });
            gridControlBugunYapilacaklar.DataSource = degerler.ToList();

            // Örnek olarak 10 etiket kontrolü oluşturuyoruz.
            LabelControl[] labelControls = { labelControl1, labelControl2, labelControl3, labelControl4, labelControl5, labelControl6, labelControl7, labelControl8, labelControl9, labelControl10 };

            // İletişim tablosundaki en büyük ID'yi alıyoruz.
            int? maxID = db.Tbl_Iletisim.Max(x => (int?)x.ID);

            if (maxID.HasValue)
            {
                // En büyük ID'yi temel alarak son 10 kaydı alıyoruz.
                var sonIletisimKayitlari = db.Tbl_Iletisim
                    .Where(x => x.ID <= maxID)        // En büyük ID'yi ve öncesini alıyoruz.
                    .OrderByDescending(x => x.ID)    // ID'ye göre azalan sırayla sıralıyoruz.
                    .Take(10)                        // İlk 10 kaydı alıyoruz.
                    .ToList();

                // Etiketleri doldurmak için bir döngü kullanıyoruz.
                for (int i = 0; i < labelControls.Length; i++)
                {
                    // Eğer alınan kayıtlar içinde mevcut bir kayıt varsa etiketi güncelliyoruz.
                    if (i < sonIletisimKayitlari.Count)
                    {
                        var iletişim = sonIletisimKayitlari[i];

                        // Konu ve ad bilgilerini alıyoruz.
                        string konu = iletişim.KONU;
                        string ad = iletişim.ADSOYAD;

                        // Etiketin metnini güncelliyoruz.
                        labelControls[i].Text = $"{konu} - {ad}";
                    }
                    else
                    {
                        // Eğer kayıt yoksa, etiketi boş bırakıyoruz.
                        labelControls[i].Text = string.Empty;
                    }
                }
            }
            else
            {
                // Eğer tablonun içinde hiç veri yoksa, tüm etiketler boş bırakılır.
                foreach (var label in labelControls)
                {
                    label.Text = string.Empty;
                }
            }


        }
    }
}
