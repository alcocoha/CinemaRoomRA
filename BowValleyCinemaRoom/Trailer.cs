using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace BowValleyCinemaRoom
{
    public partial class Trailer : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private VideoView _videoView;
        string _trailer = string.Empty;

        public Trailer(string trailer)
        {
            InitializeComponent();
            this.FormClosing += Trailer_FormClosing;

            Core.Initialize();

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            _videoView = new VideoView
            {
                MediaPlayer = _mediaPlayer,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(_videoView);
            _videoView.BringToFront();
            this._trailer = trailer;
        }

        private void Trailer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mediaPlayer.Stop(); 
        }

        private void Trailer_Load(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            var media = new Media(_libVLC, @"C:\Users\alber\Documents\RapidApplication\BowValleyCinemaRoom\trailers\" + this._trailer, FromType.FromPath);
            _mediaPlayer.Play(media);
        }
    }
}
