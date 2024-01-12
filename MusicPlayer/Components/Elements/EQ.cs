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
    //using System;
    using System.Windows.Forms;
    public partial class EQ : UserControl
    {
        private Timer timer = new Timer();
        private int[] barHeights = new int[25];
        private Random random = new Random();
        
        public EQ()
        {
            InitializeComponent();
            timerEQ.Interval = 100;
            timerEQ.Tick += new EventHandler(UpdateEqualizer);
            timerEQ.Start();
            
        }
        private void UpdateEqualizer(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                barHeights[i] = random.Next(10, EQpanel.Height);
            }

            EQpanel.Invalidate(); // Перерисовываем панель для отображения анимации
        }

        private void EQpanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int barWidth = EQpanel.Width / 30;
            int spacing = 5;

            for (int i = 0; i < 25; i++)
            {
                int x = i * (barWidth + spacing);
                int y = EQpanel.Height - barHeights[i];
                int height = barHeights[i];
                int width = barWidth;
                Color color = Color.Red;
                SolidBrush brush = new SolidBrush(color);

                g.FillRectangle(brush, x, y, width, height);
            }
        }
    }
}
