using System;
using System.Drawing;
using System.IO;
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

            // Ajusta o painel visual de feedback do download
            panDownloadFeedback.Location = new Point(230, 195);
            panDownloadFeedback.Hide();

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

        private async void btnDonwload_Click(object sender, EventArgs e)
        {
            btnDonwload.Hide();
            panDownloadFeedback.Show();
            gifLoading.Enabled = true;
            tmrRelogio.Start();

            var video = await YouTube.Default.GetVideoAsync(URL);
            byte[] bytes = await video.GetBytesAsync();

            this.Cursor = Cursors.WaitCursor;
            File.WriteAllBytes(pastaDestino + video.FullName, bytes);
            this.Cursor = Cursors.Default;
            tmrRelogio.Stop();
            gifLoading.Enabled = false;
            panDownloadFeedback.Hide();
            btnDonwload.Show();
            MensagemDownloadConcluido();
        }

        // Mensagem informando que o download terminou
        private void MensagemDownloadConcluido()
        {
            var title = "Feito";
            var message = "Download concluído!";
            var icon = MessageBoxIcon.Information;
            var button = MessageBoxButtons.OK;
            MessageBox.Show(message, title, button, icon);
        }

        private void ConfigurarPosicaoDuracao()
        {
            if (VideoInfo.Titulo.Length > 55)
            {
                lblTempo.Location = new Point(lblTempo.Location.X, 68);
            }
            else
            {
                lblTempo.Location = new Point(lblTempo.Location.X, 48);
            }
        }

        private void tmrRelogio_Tick(object sender, EventArgs e)
        {
            var texto = "Fazendo o download";
            if (lblBytes.Text == texto + ". . . ")
            {
                lblBytes.Text = texto;
            }
            else
            {
                lblBytes.Text += ". ";
            }
        }
    }
}
