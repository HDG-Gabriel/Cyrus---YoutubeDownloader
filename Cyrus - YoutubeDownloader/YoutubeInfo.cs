using VideoLibrary;
using System.Net;
using System.Drawing;
using System.Windows.Forms;

namespace Cyrus___YoutubeDownloader
{
    public class YoutubeInfo
    {
        private static int _numeroThumb;
        public static int NumeroThumb
        {
            get
            {
                return _numeroThumb++;
            }
        }
        private Video _video;
        public string Autor { get; }
        public string Titulo { get; }
        public string Duracao { get; }
        public string URL { get; set; }

        public YoutubeInfo(Video video)
        {
            _video = video;
            Autor = video.Info.Author;
            Titulo = video.Info.Title;
            Duracao = TempoDeVideoFormatado(video.Info.LengthSeconds);
        }

        // Pega o tempo de video e retorna uma string no tipo m:ss
        private string TempoDeVideoFormatado(int? segundos)
        {
            var tempo = "";
            // Calcula as horas do vídeo
            var horas = segundos / 3600;
            segundos -= horas * 3600;
            // Calcula os minutos
            var minutos = segundos / 60;
            // O restante é o tempo em segundos
            segundos -= minutos * 60;

            if (horas >= 1)
            {
                tempo += $"{horas}:{minutos.ToString().PadLeft(2,'0')}:";
            }
            else
            {
                tempo += minutos.ToString() + ":";
            }

            tempo += $"{segundos.ToString().PadLeft(2, '0')}";
            
            return tempo;
        }

        public void DownloadThumb(string destino, PictureBox imagem)
        {
            try
            {
                var cliente = new WebClient();
                cliente.DownloadFile("https://i.ytimg.com/vi/" + URL.Substring(32) + "/default.jpg", destino);
                imagem.Image = Image.FromFile(destino);
            } catch
            {
                imagem.Image = Properties.Resources.youtube_default;
            }
        }
    }
}
