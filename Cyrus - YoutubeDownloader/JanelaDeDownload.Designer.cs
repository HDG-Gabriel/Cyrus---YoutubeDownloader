
namespace Cyrus___YoutubeDownloader
{
    partial class JanelaDeDownload
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaDeDownload));
            this.panDownload = new System.Windows.Forms.Panel();
            this.btnDonwload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCanal = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.lblBytes = new System.Windows.Forms.Label();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.gifLoading = new System.Windows.Forms.PictureBox();
            this.panDownloadFeedback = new System.Windows.Forms.Panel();
            this.panDownload.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoading)).BeginInit();
            this.panDownloadFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // panDownload
            // 
            this.panDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(46)))));
            this.panDownload.Controls.Add(this.panDownloadFeedback);
            this.panDownload.Controls.Add(this.btnDonwload);
            this.panDownload.Controls.Add(this.panel2);
            this.panDownload.Location = new System.Drawing.Point(0, 0);
            this.panDownload.Name = "panDownload";
            this.panDownload.Size = new System.Drawing.Size(718, 256);
            this.panDownload.TabIndex = 0;
            // 
            // btnDonwload
            // 
            this.btnDonwload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(14)))), ((int)(((byte)(171)))));
            this.btnDonwload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonwload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDonwload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(23)))), ((int)(((byte)(227)))));
            this.btnDonwload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonwload.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDonwload.ForeColor = System.Drawing.Color.White;
            this.btnDonwload.Location = new System.Drawing.Point(299, 201);
            this.btnDonwload.Name = "btnDonwload";
            this.btnDonwload.Size = new System.Drawing.Size(149, 41);
            this.btnDonwload.TabIndex = 8;
            this.btnDonwload.Text = "DOWNLOAD";
            this.btnDonwload.UseVisualStyleBackColor = false;
            this.btnDonwload.Click += new System.EventHandler(this.btnDonwload_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCanal);
            this.panel2.Controls.Add(this.lblTempo);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.imgVideo);
            this.panel2.Location = new System.Drawing.Point(68, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 140);
            this.panel2.TabIndex = 0;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.ForeColor = System.Drawing.Color.White;
            this.lblCanal.Location = new System.Drawing.Point(147, 99);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(41, 16);
            this.lblCanal.TabIndex = 4;
            this.lblCanal.Text = "Canal";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(189)))));
            this.lblTempo.Location = new System.Drawing.Point(147, 68);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(45, 16);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "Tempo";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(146, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(421, 43);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // imgVideo
            // 
            this.imgVideo.Image = global::Cyrus___YoutubeDownloader.Properties.Resources.youtube_default;
            this.imgVideo.Location = new System.Drawing.Point(20, 25);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(120, 90);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // lblBytes
            // 
            this.lblBytes.AutoSize = true;
            this.lblBytes.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBytes.ForeColor = System.Drawing.Color.White;
            this.lblBytes.Location = new System.Drawing.Point(55, 9);
            this.lblBytes.Name = "lblBytes";
            this.lblBytes.Size = new System.Drawing.Size(183, 23);
            this.lblBytes.TabIndex = 9;
            this.lblBytes.Text = "Fazendo o download";
            // 
            // tmrRelogio
            // 
            this.tmrRelogio.Interval = 400;
            this.tmrRelogio.Tick += new System.EventHandler(this.tmrRelogio_Tick);
            // 
            // gifLoading
            // 
            this.gifLoading.Image = ((System.Drawing.Image)(resources.GetObject("gifLoading.Image")));
            this.gifLoading.Location = new System.Drawing.Point(13, 0);
            this.gifLoading.Name = "gifLoading";
            this.gifLoading.Size = new System.Drawing.Size(45, 41);
            this.gifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifLoading.TabIndex = 10;
            this.gifLoading.TabStop = false;
            // 
            // panDownloadFeedback
            // 
            this.panDownloadFeedback.Controls.Add(this.gifLoading);
            this.panDownloadFeedback.Controls.Add(this.lblBytes);
            this.panDownloadFeedback.Location = new System.Drawing.Point(3, 210);
            this.panDownloadFeedback.Name = "panDownloadFeedback";
            this.panDownloadFeedback.Size = new System.Drawing.Size(269, 46);
            this.panDownloadFeedback.TabIndex = 11;
            // 
            // JanelaDeDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panDownload);
            this.Name = "JanelaDeDownload";
            this.Size = new System.Drawing.Size(718, 256);
            this.panDownload.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifLoading)).EndInit();
            this.panDownloadFeedback.ResumeLayout(false);
            this.panDownloadFeedback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panDownload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDonwload;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.Label lblBytes;
        private System.Windows.Forms.Timer tmrRelogio;
        private System.Windows.Forms.PictureBox gifLoading;
        private System.Windows.Forms.Panel panDownloadFeedback;
    }
}
