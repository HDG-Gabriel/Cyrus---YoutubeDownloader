using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

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
            Duracao = TempoDeVideoFormatado((int)video.Info.LengthSeconds);
        }

        // Pega o tempo de video e retorna uma string no tipo m:ss
        private string TempoDeVideoFormatado(int segundos)
        {
            var minutos = segundos / 60;
            segundos -= minutos * 60;
            return $"{minutos}:{segundos.ToString().PadLeft(2, '0')}";
        }

        public void DownloadThumb(string destino)
        {
            var cliente = new WebClient();
            cliente.DownloadFile("https://i.ytimg.com/vi/" + URL.Substring(32) + "/default.jpg", destino);
        }
    }
}
