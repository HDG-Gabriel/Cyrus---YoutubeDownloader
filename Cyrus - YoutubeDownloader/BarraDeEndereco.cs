using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace Cyrus___YoutubeDownloader
{
    public partial class BarraDeEndereco : UserControl
    {
        public TelaPrincipal TelaPrincipal { get; set; }
        public bool VideoExiste { get; }
        private Video video;
        private readonly string textoPadrao = " Cole a url aqui...";
        // Cor do texto quando o usário não tiver clicado
        private readonly Color cinzaApagado = Color.FromArgb(184, 184, 186);
        public BarraDeEndereco()
        {
            InitializeComponent();
        }

        // Quando o user clica na barra de pesquisa
        private void txtURL_Enter(object sender, EventArgs e)
        {
            if (txtURL.Text == textoPadrao)
            {
                txtURL.Text = "";
                txtURL.ForeColor = Color.Black;
            }
        }

        // Quando o user sai da barra de pesquisa
        private void txtURL_Leave(object sender, EventArgs e)
        {
            if (txtURL.Text == "")
            {
                ApagarTexto();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ApagarTexto();
        }

        // Retornar o texto ao estado padrão
        private void ApagarTexto()
        {
            txtURL.Text = textoPadrao;
            txtURL.ForeColor = cinzaApagado;
        }

        // Pesquisa o endereço
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Cursor = Cursors.WaitCursor;
            if(ValidarURL(txtURL.Text))
            {
                // Se o vídeo existe, então a tela de download surgirá
                TelaPrincipal.panMensagens.Hide();
                TelaPrincipal.JanelaDeDownload.Show();
                TelaPrincipal.JanelaDeDownload.URL = txtURL.Text;
                TelaPrincipal.JanelaDeDownload.CarregarVideo(video);
            }
            else
            {
                // Vídeo não foi encontrado
                var title = "URL Inválida";
                var message = "Não foi possível encontrar o vídeo.";
                var button = MessageBoxButtons.OK;
                var icon = MessageBoxIcon.Warning;
                MessageBox.Show(message, title, button , icon);
            }
            TelaPrincipal.Cursor = Cursors.Default;
        }

        // Verifica se a URL é válida, isto é, existe
        private bool ValidarURL(string url)
        {
            try
            {
                var video = YouTube.Default.GetVideo(url);
                this.video = video;
                return true;
            } catch
            {
                return false;
            }
            
        }
    }
}
