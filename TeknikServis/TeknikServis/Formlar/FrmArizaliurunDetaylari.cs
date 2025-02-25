﻿using System;
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
    public partial class FrmArizaliurunDetaylari : Form
    {
        public FrmArizaliurunDetaylari()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmArizaliurunDetaylari_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Tbl_UrunTakip
                                                      select new
                                                      {
                                                          x.TAKIPID,
                                                          x.TARIH,
                                                          x.SERINO,
                                                          x.ACIKLAMA
                                                      }).ToList();
        }
    }
}
