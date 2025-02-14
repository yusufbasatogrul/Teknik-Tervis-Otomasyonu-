using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.Formlar
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {

        }

        private void TxtCariAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                string frommail = "basatogrulyusuf@gmail.com";
                string password = "****"; // Burada doğrudan Gmail şifresi yerine uygulama şifresi kullanılmalıdır.
                string alici = TxtAlici.Text;
                string konu = TxtKonu.Text;
                string icerik = TxtIcerik.Text;

                mail.From = new MailAddress(frommail);
                mail.To.Add(alici);
                mail.Subject = konu;
                mail.Body = icerik;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(frommail, password);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Mail başarıyla gönderildi.");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"SMTP Hatası: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Genel Hata: {ex.Message}");
            }



        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
