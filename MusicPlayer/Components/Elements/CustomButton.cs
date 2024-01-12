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
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        private void buttonImage_MouseHover(object sender, EventArgs e)
        {
            Padding = new Padding(0);
        }

        private void buttonImage_MouseLeave(object sender, EventArgs e)
        {
            Padding = new Padding(2);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        public Image Image
        {
            get
            {
                return buttonImage.Image;
            }
            set
            {
                buttonImage.Image = value;
            }
        }
        private bool showDot = false;
        private Color dotColor = Color.Red;
        public bool ShowDot
        {
            get { return showDot; }
            set
            {
                showDot = value;
                Invalidate();
            }
        }
        public Color DotColor
        {
            get { return dotColor; }
            set
            {
                dotColor = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ShowDot)
            {
                int dotSize = 5; // Размер точки
                int x = (Width - dotSize) / 2; // Центрируем точку по горизонтали
                int y = Height - dotSize; // Помещаем точку внизу

                using (SolidBrush brush = new SolidBrush(DotColor))
                {
                    e.Graphics.FillEllipse(brush, new Rectangle(x, y, dotSize, dotSize));
                }
            }
        }
    }
}
