using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Components.Elements
{
    public partial class VolumeControl : UserControl
    {
        private EventHandler<float>? changeValue;
        private bool mute;
        public VolumeControl()
        {
            InitializeComponent();
            volumeBar.AddWheelEvent();
            volumeBar.ChangeValue += VolumeBar_ChangeValue;
            volumeBar.Value = 50.0f;
            Volume = 0.5f;
        }
        public event EventHandler<float> ChangeValue
        {
            add { changeValue += value; }
            remove { changeValue -= value; }
        }
        private void VolumeBar_ChangeValue(object? sender, float e)
        {
            if (e == 0 && !mute)
            {
                volumeImage.Image = Properties.Resources.mute;
                mute = true;
            }

            if (e > 0 && mute)
            {
                volumeImage.Image = Properties.Resources.volume_up;
                mute = false;
            }

            Volume = e / 100;
            changeValue?.Invoke(sender, Volume);
        }
        public float Volume {  get; set; }
    }
}