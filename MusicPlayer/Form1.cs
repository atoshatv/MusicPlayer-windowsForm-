using MusicPlayer.Components;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        string folderPath = Path.Combine("D:", "Music");
        public Form1()
        {
            InitializeComponent();
            audioPlayerControl.Next += AudioPlayerControl_Next;
            audioPlayerControl.Prev += AudioPlayerControl_Prev;
        }

        private void AudioPlayerControl_Prev(object? sender, MusicCard e)
        {
            int index = musicCardsArea.Controls.IndexOf(e);
            index = index == 0 ? musicCardsArea.Controls.Count - 1 : index - 1;
            var prev = (MusicCard)musicCardsArea.Controls[index];
            audioPlayerControl.PlayTrack(prev);
        }

        private void AudioPlayerControl_Next(object? sender, MusicCard e)
        {
            if (audioPlayerControl.btnRandom.ShowDot) // Проверяем, показывается ли точка на кнопке
            {
                Random random = new Random();
                MusicCard randomCard = (MusicCard)musicCardsArea.Controls[random.Next(musicCardsArea.Controls.Count)];
                audioPlayerControl.PlayTrack(randomCard);
            }
            else
            {
                int index = musicCardsArea.Controls.IndexOf(e);
                index = index == musicCardsArea.Controls.Count - 1 ? 0 : index + 1;
                var next = (MusicCard)musicCardsArea.Controls[index];
                audioPlayerControl.PlayTrack(next);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath))
            {
                OpenFileOnFormLoad();
            }
            string[] dirs = Directory.GetDirectories(folderPath);

            foreach (string dir in dirs)
            {
                var playlist = new PlayList(dir);
                playlist.OpenPlayList += Playlist_OpenPlayList;
                PlayListArea.Controls.Add(playlist);
            }
            if (dirs.Length > 0)
            {
                var firstplaylist = PlayListArea.Controls[0] as PlayList;
                OpenPlayList(firstplaylist);
            }
        }

        private void Playlist_OpenPlayList(object? sender, EventArgs e)
        {
            PlayList? playlist = sender as PlayList;
            if (playlist != null)
            {
                OpenPlayList(playlist);
            }
        }

        private void OpenPlayList(PlayList playlist)
        {
            musicCardsArea.Controls.Clear();
            string[] tracks = Directory.GetFiles(playlist.Source, "*.mp3");

            foreach (var track in tracks)
            {
                var card = new MusicCard(playlist, track);
                card.PlayTrack += Card_PlayTrack;
                musicCardsArea.Controls.Add(card);
            }
        }


        private void Card_PlayTrack(object? sender, EventArgs e)
        {
            if (sender is MusicCard card)
            {
                audioPlayerControl.PlayTrack(card);
            }
        }

        private void OpenFileOnFormLoad()
        {
            MessageBox.Show("😞.\n" +
                            "Please select the music folder on your computer.");
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select Folder";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
            else
            {
                this.Close();
            }
        }
    }
}