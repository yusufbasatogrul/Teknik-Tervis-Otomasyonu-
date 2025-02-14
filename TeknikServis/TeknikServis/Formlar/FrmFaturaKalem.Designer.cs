namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalem));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFaturaKalemUrun = new DevExpress.XtraEditors.TextEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtFaturaKalemAdet = new DevExpress.XtraEditors.TextEdit();
            this.TxtFaturaKalemFiyat = new DevExpress.XtraEditors.TextEdit();
            this.TxtFaturaKalemTutar = new DevExpress.XtraEditors.TextEdit();
            this.TxtFaturaKalemFaturaID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemFaturaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(184)))), ((int)(((byte)(187)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(189)))), ((int)(((byte)(199)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, 4);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1405, 749);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(88, 172);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ÜRÜN:";
            // 
            // TxtFaturaKalemUrun
            // 
            this.TxtFaturaKalemUrun.Location = new System.Drawing.Point(151, 166);
            this.TxtFaturaKalemUrun.Name = "TxtFaturaKalemUrun";
            this.TxtFaturaKalemUrun.Size = new System.Drawing.Size(262, 22);
            this.TxtFaturaKalemUrun.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(151, 360);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(262, 29);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(151, 395);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(262, 29);
            this.BtnSil.TabIndex = 9;
            this.BtnSil.Text = "SİL";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(151, 430);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(262, 29);
            this.BtnGuncelle.TabIndex = 10;
            this.BtnGuncelle.Text = "GÜNCELLE";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(151, 465);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(262, 29);
            this.BtnListele.TabIndex = 11;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(62, 135);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 16);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "DETAY ID :";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(151, 129);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(262, 22);
            this.TxtID.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(89, 209);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "ADET:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(86, 246);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "FİYAT:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(80, 283);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 16);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "TUTAR:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(57, 320);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 16);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "FATURA ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtFaturaKalemFaturaID);
            this.groupControl1.Controls.Add(this.TxtFaturaKalemTutar);
            this.groupControl1.Controls.Add(this.TxtFaturaKalemFiyat);
            this.groupControl1.Controls.Add(this.TxtFaturaKalemAdet);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtFaturaKalemUrun);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1409, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(517, 749);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // TxtFaturaKalemAdet
            // 
            this.TxtFaturaKalemAdet.Location = new System.Drawing.Point(151, 203);
            this.TxtFaturaKalemAdet.Name = "TxtFaturaKalemAdet";
            this.TxtFaturaKalemAdet.Size = new System.Drawing.Size(262, 22);
            this.TxtFaturaKalemAdet.TabIndex = 2;
            // 
            // TxtFaturaKalemFiyat
            // 
            this.TxtFaturaKalemFiyat.Location = new System.Drawing.Point(151, 240);
            this.TxtFaturaKalemFiyat.Name = "TxtFaturaKalemFiyat";
            this.TxtFaturaKalemFiyat.Size = new System.Drawing.Size(262, 22);
            this.TxtFaturaKalemFiyat.TabIndex = 3;
            // 
            // TxtFaturaKalemTutar
            // 
            this.TxtFaturaKalemTutar.Location = new System.Drawing.Point(151, 277);
            this.TxtFaturaKalemTutar.Name = "TxtFaturaKalemTutar";
            this.TxtFaturaKalemTutar.Size = new System.Drawing.Size(262, 22);
            this.TxtFaturaKalemTutar.TabIndex = 4;
            // 
            // TxtFaturaKalemFaturaID
            // 
            this.TxtFaturaKalemFaturaID.Location = new System.Drawing.Point(151, 314);
            this.TxtFaturaKalemFaturaID.Name = "TxtFaturaKalemFaturaID";
            this.TxtFaturaKalemFaturaID.Size = new System.Drawing.Size(262, 22);
            this.TxtFaturaKalemFaturaID.TabIndex = 5;
            // 
            // FrmFaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 756);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaKalem";
            this.Text = "FrmFaturaKalem";
            this.Load += new System.EventHandler(this.FrmFaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaturaKalemFaturaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtFaturaKalemUrun;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtFaturaKalemFaturaID;
        private DevExpress.XtraEditors.TextEdit TxtFaturaKalemTutar;
        private DevExpress.XtraEditors.TextEdit TxtFaturaKalemFiyat;
        private DevExpress.XtraEditors.TextEdit TxtFaturaKalemAdet;
    }
}