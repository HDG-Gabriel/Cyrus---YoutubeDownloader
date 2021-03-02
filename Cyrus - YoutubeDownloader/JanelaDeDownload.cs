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

namespace Cyrus___YoutubeDownloader
{
    public partial class JanelaDeDownload : UserControl
    {
        public YoutubeInfo VideoInfo { get; set; }
        public string URL { get; set; }
        // Pasta onde ficam armazenadas as thumbs TEMPORARIAMENTE
        private readonly string pasta = @"C:\Users\Gabri\Downloads\Thumbs\thumbnail";
        private readonly string pastaDestino = @"C:\Users\Gabri\Downloads\";
        public JanelaDeDownload()
        {
            InitializeComponent();
        }

        // Carrega as informações do título, autor, thumb e tempo do vídeo
        public void CarregarVideo(Video video)
        {
            // Informações do vídeo
            VideoInfo = new YoutubeInfo(video);
            VideoInfo.URL = this.URL;
            lblTitulo.Text = VideoInfo.Titulo;
            lblCanal.Text = VideoInfo.Autor;
            lblTempo.Text = VideoInfo.Duracao;

            ConfigurarPosicaoDuracao();

            // Local de donwload
            var pathDownload = pasta + YoutubeInfo.NumeroThumb.ToString() + ".jpg";
            imgVideo.Image = null;

            VideoInfo.DownloadThumb(pathDownload);
            imgVideo.Image = Image.FromFile(pathDownload);
        }

        // Exclui todos os aquivos da pasta de thumbs
        public static void LimparPasta(string path)
        {
            try
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    File.Delete(file);
                }
            } 
            catch
            {
                Application.Exit();
            }
            
        }

        private void btnDonwload_Click(object sender, EventArgs e)
        {
            var video = YouTube.Default.GetVideo(URL);
            this.Cursor = Cursors.WaitCursor;
            File.WriteAllBytes(pastaDestino + video.FullName, video.GetBytes());
            this.Cursor = Cursors.Default;
            // Mensagem informando que o download terminou
            var title = "Feito";
            var message = "Download concluído!";
            var icon = MessageBoxIcon.Information;
            var button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button, icon);
        }

        private void ConfigurarPosicaoDuracao()
        {
            if (VideoInfo.Titulo.Length > 54)
            {
                lblTempo.Location = new Point(lblTempo.Location.X, 68);
            }
            else
            {
                lblTempo.Location = new Point(lblTempo.Location.X, 48);
            }
        }
    }
}
