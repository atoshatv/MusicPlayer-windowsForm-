using MusicPlayer.Estensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Components
{

    public partial class MusicCard : UserControl
    {

        private EventHandler? playTrack;
        private MusicCard()
        {
            InitializeComponent();
            HoverRecursive(this);
            ClickRecursive(this);
            MakePictureBoxRound(pictureBoxplay);
            this.SetRoundShape(20);
        }

        public MusicCard(PlayList playlist, string file) : this()
        {
            Source = file;
            var fileInfo = new FileInfo(file);
            Title = fileInfo.Name;
            DirectoryInfo directoryInfo = fileInfo.Directory;
            Singer = directoryInfo.Name;

            int indexLastPoint = Title.LastIndexOf(".");
            string filePath = Title.Substring(0, indexLastPoint);
            string pathImage = Path.Combine(fileInfo.DirectoryName!, "Images", filePath + ".jpg");

            if (File.Exists(pathImage))
            {
                Image = new Bitmap(pathImage);
            }
            else
            {
                Image = playlist.Image;
            }
        }

        #region скругление кнопочки
        private void MakePictureBoxRound(PictureBox pictureBox)
        {
            pictureBox.Paint += (sender, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                    pictureBox.Region = new Region(path);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, pictureBox.Width, pictureBox.Height);
                }
            };
        }
        #endregion

        #region Properties
        public Image Image
        {
            get
            {
                return pbMusicImage.Image;
            }
            set
            {
                pbMusicImage.Image = value;
            }
        }

        public string Title
        {
            get
            {
                return lbMusicTitle.Text;
            }
            set
            {
                lbMusicTitle.Text = value;
            }
        }

        public string Singer
        {
            get
            {
                return lbSinger.Text;
            }
            set
            {
                lbSinger.Text = value;
            }
        }

        public string Source { get; set; }
        #endregion

        #region Hover
        private void MusicCard_Enter(object? sender, EventArgs e)
        {
            musicCardArea.BackColor = Color.FromArgb(217, 217, 217);
            panelforEq.BackColor = Color.FromArgb(217, 217, 217);
            pictureBoxplay.Visible = true;
        }

        private void MusicCard_Leave(object? sender, EventArgs e)
        {
            pictureBoxplay.Visible = false;
            musicCardArea.BackColor = Color.White;
           
            panelforEq.BackColor = Color.White;
        }

        private void HoverRecursive(Control panel)
        {
            panel.MouseEnter += MusicCard_Enter;
            panel.MouseLeave += MusicCard_Leave;
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var child = panel.Controls[i];
                HoverRecursive(child);
            }
        }
        #endregion

        #region Click
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
            playTrack?.Invoke(this, e);
        }

        private void pictureBoxplay_Click(object sender, EventArgs e)
        {
            playTrack?.Invoke(this, e);
        }

        public event EventHandler PlayTrack
        {
            add 
            { 
                playTrack += value; 
            }
            remove 
            { 
                playTrack -= value; 
            }
        }
        #endregion

        #region Eq
        public bool Play
        {

            get
            {
                return panelforEq.Visible;
            }
            set
            {
                panelforEq.Visible = value;
            }
        }


        #endregion
    }
}
