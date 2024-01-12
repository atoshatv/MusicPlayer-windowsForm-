using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Components
{
    public partial class TrackInfo : UserControl
    {
        public TrackInfo()
        {
            InitializeComponent();
        }

        public TrackInfo(string path) : this()
        {
            Source = path;
            var dirInfo = new DirectoryInfo(Source);
            Title = dirInfo.Name;
            var tracks = Directory.GetFiles(path, "*.mp3");
            Singer = tracks.Length + " Tracks";
            string pathImage = Path.Combine(Source, Title + ".jpg");
            if (File.Exists(pathImage))
            {
                Image = new Bitmap(pathImage);
            }
            else
            {
                Image = Properties.Resources.audio1;
            }
        }

        #region  Properties
        public Image Image
        {
            get
            {
                return pictureList.Image;
            }
            set
            {
                pictureList.Image = value;
            }
        }

        public string Title
        {
            get
            {
                return TextTrackTitle.Text;
            }
            set
            {
                TextTrackTitle.Text = value;
            }
        }

        public string Singer
        {
            get
            {
                return TextSinger.Text;
            }
            set
            {
                TextSinger.Text = value;
            }
        }

        public string Source { get; set; }
        #endregion
    }
}
