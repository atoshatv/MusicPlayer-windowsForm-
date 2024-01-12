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
    public partial class TrackBar : UserControl
    {
        private EventHandler<float>? changeValue;
        public TrackBar()

        {
            InitializeComponent();
            Max = 100.0f;
            Value = 50.0f;
            HoverRecursive(TrackBarArea);
        }
        #region Property

        public int HeightPadding
        {
            get
            {
                return TrackBarArea.Padding.Top;
            }
            set
            {
                TrackBarArea.Padding = new Padding(0, value, 0, value);
            }


        }
        public float Value
        {
            get
            {
                return TrackBarArea.ColumnStyles[0].Width;
            }
            set
            {
                float firstLine = value/Max * 100;
                if (firstLine < 0)
                {
                    firstLine = 0;
                }
                if (firstLine > 100)
                {
                    firstLine = 100;
                }
                TrackBarArea.ColumnStyles[0].Width = firstLine;
                TrackBarArea.ColumnStyles[1].Width = 100 - firstLine;
            }
        }
        public float Max { get; set; }
        #endregion

        #region Event
        public event EventHandler<float> ChangeValue
        {
            add { changeValue += value; }
            remove { changeValue -= value; }
        }

        private void PanelHaupt_MouseEnter(object sender, EventArgs e)
        {
           FirstLine.BackColor = Color.Black;
        }

        private void PanelHaupt_MouseLeave(object sender, EventArgs e)
        {
            FirstLine.BackColor = Color.Red;
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

        private void WheelRecursive(Control element)
        {
            element.MouseWheel += Element_MouseWheel;
            for (int i = 0; i < element.Controls.Count; i++)
            {
                var child = element.Controls[i];
                WheelRecursive(child);
            }
        }

        private void Element_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta >= 0) 
            {
                Value += 2;
            }
            else
            {
                Value -= 2;
            }

            changeValue?.Invoke(sender, Value);
        }
        #endregion
        private void FirstLine_MouseClick(object sender, MouseEventArgs e)
        {
            var value = (e.X * Max) / TrackBarArea.Width;
            Value = value;
            changeValue?.Invoke(sender, value);
        }

        private void LastLine_MouseClick(object sender, MouseEventArgs e)
        {
            var value = ((FirstLine.Width + e.X) * Max) / TrackBarArea.Width;
            Value = value;
            changeValue?.Invoke(sender, value);
        }

        public void AddWheelEvent() 
        {
            WheelRecursive(TrackBarArea);
        }
    }
}
