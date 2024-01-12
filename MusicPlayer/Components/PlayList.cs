using MusicPlayer.Estensions;
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
    public partial class PlayList : UserControl
    {
        private EventHandler? openPlayList;
        private PlayList()
        {
            InitializeComponent();

        }
        public PlayList(string path) : this()
        {
            Source = path;
            var dirInfo = new DirectoryInfo(Source);
            Title = dirInfo.Name;
            var tracks = Directory.GetFiles(path, "*.mp3");
            Description = tracks.Length + " Tracks";
            string pathImage = Path.Combine(Source, Title + ".jpg");
            if (File.Exists(pathImage))
            {
                Image = new Bitmap(pathImage);
            }
            else
            {
                Image = Properties.Resources.audio1;
            }
            ClickRecursive(PanelHaupt);
            HoverRecursive(PanelHaupt);
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
                return TextPlaylistName.Text;
            }
            set
            {
                TextPlaylistName.Text = value;
            }

        }
        public string Description
        {
            get
            {
                return TextDiscription.Text;
            }
            set
            {
                TextDiscription.Text = value;
            }

        }
        public string Source { get; set; }
        #endregion




        #region Наведение
        private void PanelHaupt_MouseEnter(object sender, EventArgs e)
        {
            PanelHaupt.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void PanelHaupt_MouseLeave(object sender, EventArgs e)
        {
            PanelHaupt.BackColor = Color.White;
        }
        private void HoverRecursive(Control panel)
        {
            panel.MouseEnter += PanelHaupt_MouseEnter;
            panel.MouseLeave += PanelHaupt_MouseLeave;
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var child = panel.Controls[i];
                HoverRecursive(child);
            }

        }
        #endregion

        #region Нажим



        private void ClickRecursive(Control panel)
        {
            panel.MouseClick += Panel_MouseClick;


            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var child = panel.Controls[i];
                ClickRecursive(child);
            }

        }

        private void Panel_MouseClick(object? sender, MouseEventArgs e)
        {
            openPlayList?.Invoke(this, e);
        }

        public event EventHandler OpenPlayList
        {
            add { openPlayList += value; }
            remove { openPlayList -= value; }
        }
        #endregion
    }
}
