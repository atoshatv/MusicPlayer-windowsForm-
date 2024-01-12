using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer.Components
{
    public partial class AudioPlayerControl : UserControl
    {

        WaveOut wave;
        AudioFileReader? audio;
        MusicCard lastCard;
        bool isRepeat = false;
        bool playRandom = false;
        Random random = new Random();

        #region Play
        bool play;

        public bool Play
        {
            get
            {
                return play;
            }
            set
            {
                play = value;
                if (play)
                {
                    wave.Play();
                    playButton.Image = Properties.Resources.stop;
                }
                else
                {
                    if (wave != null)
                    {
                        wave.Pause();
                    }
                    playButton.Image = Properties.Resources.play;
                }
            }
        }
        #endregion
        public AudioPlayerControl()
        {
            InitializeComponent();
            trackInfo.Title = "";
            trackInfo.Singer = "";
            trackBar.ChangeValue += TrackBar_ChangeValue;
            volumeBar.ChangeValue += VolumeBar_ChangeValue;
            trackBar.Value = 0.0f;
            lastCard = null;
        }

        private void VolumeBar_ChangeValue(object? sender, float e)
        {
            if (audio != null)
            {
                audio.Volume = e;
            }
        }

        #region MusicControl
        private void TrackBar_ChangeValue(object? sender, float e)
        {
            if (audio != null)
            {
                audio.CurrentTime = TimeSpan.FromSeconds(e);
            }
        }
        public void PlayTrack(MusicCard card)
        {
            if (lastCard != null) //ЛАСТ КАРД ЭТО ГЛОБАЛ ПЕРЕМЕННАЯ
            {
                lastCard.Play = false;
            }

            card.Play = true;
            lastCard = card;
            if (wave != null)
            {
                wave.Dispose();
                audio?.Dispose();
            }

            wave = new WaveOut();
            audio = new AudioFileReader(card.Source);
            wave.Init(audio);
            wave.PlaybackStopped += NextEvent;

            trackInfo.Image = card.Image;
            trackInfo.Title = card.Title;
            trackInfo.Singer = card.Singer;

            trackBar.Max = (float)audio.TotalTime.TotalSeconds;
            TimeSpan end = audio.TotalTime;
            endTime.Text = $"{end:mm}:{end:ss}";

            audio.Volume = volumeBar.Volume;
            Play = true;
        }

        private void audioTimer_Tick(object sender, EventArgs e)
        {
            if (audio != null)
            {
                TimeSpan current = audio.CurrentTime;
                currentTime.Text = $"{current:mm}:{current:ss}";
                trackBar.Value = (float)audio.CurrentTime.TotalSeconds;
            }
        }
        #endregion

        #region Events

        EventHandler<MusicCard>? next;
        public event EventHandler<MusicCard> Next
        {
            add
            {
                next += value;
            }
            remove
            {
                next -= value;
            }
        }
        EventHandler<MusicCard>? prev;
        public event EventHandler<MusicCard> Prev
        {
            add
            {
                prev += value;
            }
            remove
            {
                prev -= value;
            }
        }
        EventHandler<MusicCard>? randomMusic;
        public event EventHandler<MusicCard> RandomMusic
        {
            add
            {
                randomMusic += value;
            }
            remove
            {
                randomMusic -= value;
            }
        }
        #endregion

        #region Buttons click
        private void playButton_Click(object sender, EventArgs e)
        {
            if (lastCard != null)
            {
                Play = !Play;
            }
        }

        private void NextEvent(object? sender, EventArgs e)
        {
            if (isRepeat)
            {
                PlayTrack(lastCard);
            }
            else
            {
                next?.Invoke(sender, lastCard);
            }
        }

        private void PrevEvent(object? sender, EventArgs e)
        {
            prev?.Invoke(sender, lastCard);
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (isRepeat)
            {
                btnRepeat.ShowDot = false;
                isRepeat = !isRepeat;
            }
            else
            {
                btnRepeat.ShowDot = true;
                isRepeat = !isRepeat;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            playRandom = !playRandom; // Переключаем флаг
            // Устанавливаем состояние точки
            btnRandom.ShowDot = playRandom;
        }
        #endregion
    }
}
