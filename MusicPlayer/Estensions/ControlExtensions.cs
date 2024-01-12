using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Estensions
{
    static class ControlExtensions
    {
        public static void SetRoundShape(this Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90); 
            path.AddArc(new Rectangle(control.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius * 2, control.Height - radius * 2, radius * 2, radius * 2), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius * 2, radius * 2, radius * 2), 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);

        }

    }
}
