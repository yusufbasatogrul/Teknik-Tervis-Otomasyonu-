using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace TeknikServis.Formlar
{
    public partial class FrmYouTube : Form
    {
        public FrmYouTube()
        {
            InitializeComponent();
        }

        private void FrmUdemy_Load(object sender, EventArgs e)
        {
            string url = "http://www.youtube.com/";
            webBrowser1.Navigate(url);

            


        }
    }
}
