using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using System.Net;

namespace Cyrus___YoutubeDownloader
{
    public partial class TelaPrincipal : Form
    {
        public JanelaDeDownload JanelaDeDownload { get; set; }
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JanelaDeDownload.LimparPasta(@"C:\Users\Gabri\Downloads\Thumbs\");
            // Referência a atual janela como a principal
            barraDeEndereco1.TelaPrincipal = this;

            // Cria uma janela para fazer download
            JanelaDeDownload = new JanelaDeDownload();
            JanelaDeDownload.Location = new Point(0, 115);
            JanelaDeDownload.BringToFront();
            JanelaDeDownload.Hide();
            this.Controls.Add(JanelaDeDownload);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            JanelaDeDownload.LimparPasta(@"C:\Users\Gabri\Downloads\Thumbs\");
        }
    }
}
