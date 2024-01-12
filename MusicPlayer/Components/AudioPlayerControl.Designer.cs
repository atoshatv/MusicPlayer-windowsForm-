namespace MusicPlayer.Components
{
    partial class AudioPlayerControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TLPAudioKontrol = new TableLayoutPanel();
            TLPControlMain = new TableLayoutPanel();
            TLPControlButton = new TableLayoutPanel();
            playButton = new CustomButton();
            prevButton = new CustomButton();
            nextButton = new CustomButton();
            btnRepeat = new CustomButton();
            btnRandom = new CustomButton();
            TLPControlBar = new TableLayoutPanel();
            trackBar = new TrackBar();
            currentTime = new Label();
            endTime = new Label();
            trackInfo = new TrackInfo();
            volumeArea = new TableLayoutPanel();
            volumeBar = new Elements.VolumeControl();
            audioTimer = new System.Windows.Forms.Timer(components);
            TLPAudioKontrol.SuspendLayout();
            TLPControlMain.SuspendLayout();
            TLPControlButton.SuspendLayout();
            TLPControlBar.SuspendLayout();
            volumeArea.SuspendLayout();
            SuspendLayout();
            // 
            // TLPAudioKontrol
            // 
            TLPAudioKontrol.BackColor = SystemColors.ControlLight;
            TLPAudioKontrol.ColumnCount = 3;
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 612F));
            TLPAudioKontrol.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPAudioKontrol.Controls.Add(TLPControlMain, 1, 0);
            TLPAudioKontrol.Controls.Add(trackInfo, 0, 0);
            TLPAudioKontrol.Controls.Add(volumeArea, 2, 0);
            TLPAudioKontrol.Dock = DockStyle.Fill;
            TLPAudioKontrol.Location = new Point(0, 0);
            TLPAudioKontrol.Margin = new Padding(3, 2, 3, 2);
            TLPAudioKontrol.Name = "TLPAudioKontrol";
            TLPAudioKontrol.RowCount = 1;
            TLPAudioKontrol.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPAudioKontrol.Size = new Size(872, 74);
            TLPAudioKontrol.TabIndex = 0;
            // 
            // TLPControlMain
            // 
            TLPControlMain.ColumnCount = 1;
            TLPControlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlMain.Controls.Add(TLPControlButton, 0, 0);
            TLPControlMain.Controls.Add(TLPControlBar, 0, 1);
            TLPControlMain.Dock = DockStyle.Fill;
            TLPControlMain.Location = new Point(133, 2);
            TLPControlMain.Margin = new Padding(3, 2, 3, 2);
            TLPControlMain.Name = "TLPControlMain";
            TLPControlMain.Padding = new Padding(4);
            TLPControlMain.RowCount = 2;
            TLPControlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 56.9892464F));
            TLPControlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 43.0107536F));
            TLPControlMain.Size = new Size(606, 70);
            TLPControlMain.TabIndex = 0;
            // 
            // TLPControlButton
            // 
            TLPControlButton.BackColor = SystemColors.ControlLight;
            TLPControlButton.ColumnCount = 7;
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            TLPControlButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlButton.Controls.Add(playButton, 3, 0);
            TLPControlButton.Controls.Add(prevButton, 2, 0);
            TLPControlButton.Controls.Add(nextButton, 4, 0);
            TLPControlButton.Controls.Add(btnRepeat, 5, 0);
            TLPControlButton.Controls.Add(btnRandom, 1, 0);
            TLPControlButton.Dock = DockStyle.Fill;
            TLPControlButton.Location = new Point(7, 6);
            TLPControlButton.Margin = new Padding(3, 2, 3, 2);
            TLPControlButton.Name = "TLPControlButton";
            TLPControlButton.RowCount = 1;
            TLPControlButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlButton.Size = new Size(592, 31);
            TLPControlButton.TabIndex = 0;
            // 
            // playButton
            // 
            playButton.Dock = DockStyle.Fill;
            playButton.DotColor = Color.Red;
            playButton.Image = Properties.Resources.play;
            playButton.Location = new Point(276, 3);
            playButton.Name = "playButton";
            playButton.Padding = new Padding(5);
            playButton.ShowDot = false;
            playButton.Size = new Size(39, 25);
            playButton.TabIndex = 0;
            playButton.Click += playButton_Click;
            // 
            // prevButton
            // 
            prevButton.Dock = DockStyle.Fill;
            prevButton.DotColor = Color.Red;
            prevButton.Image = Properties.Resources.prev;
            prevButton.Location = new Point(231, 3);
            prevButton.Name = "prevButton";
            prevButton.Padding = new Padding(5);
            prevButton.ShowDot = false;
            prevButton.Size = new Size(39, 25);
            prevButton.TabIndex = 1;
            prevButton.Click += PrevEvent;
            // 
            // nextButton
            // 
            nextButton.Dock = DockStyle.Fill;
            nextButton.DotColor = Color.Red;
            nextButton.Image = Properties.Resources.next;
            nextButton.Location = new Point(321, 3);
            nextButton.Name = "nextButton";
            nextButton.Padding = new Padding(5);
            nextButton.ShowDot = false;
            nextButton.Size = new Size(39, 25);
            nextButton.TabIndex = 2;
            nextButton.Click += NextEvent;
            // 
            // btnRepeat
            // 
            btnRepeat.DotColor = Color.Red;
            btnRepeat.Image = Properties.Resources.repeat;
            btnRepeat.Location = new Point(366, 3);
            btnRepeat.Name = "btnRepeat";
            btnRepeat.Padding = new Padding(5);
            btnRepeat.ShowDot = false;
            btnRepeat.Size = new Size(39, 25);
            btnRepeat.TabIndex = 3;
            btnRepeat.Click += btnRepeat_Click;
            // 
            // btnRandom
            // 
            btnRandom.DotColor = Color.Red;
            btnRandom.Image = Properties.Resources.random;
            btnRandom.Location = new Point(186, 3);
            btnRandom.Name = "btnRandom";
            btnRandom.Padding = new Padding(5);
            btnRandom.ShowDot = false;
            btnRandom.Size = new Size(39, 25);
            btnRandom.TabIndex = 4;
            btnRandom.Click += btnRandom_Click;
            // 
            // TLPControlBar
            // 
            TLPControlBar.ColumnCount = 3;
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 472F));
            TLPControlBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLPControlBar.Controls.Add(trackBar, 1, 0);
            TLPControlBar.Controls.Add(currentTime, 0, 0);
            TLPControlBar.Controls.Add(endTime, 2, 0);
            TLPControlBar.Dock = DockStyle.Fill;
            TLPControlBar.Location = new Point(7, 41);
            TLPControlBar.Margin = new Padding(3, 2, 3, 2);
            TLPControlBar.Name = "TLPControlBar";
            TLPControlBar.RowCount = 1;
            TLPControlBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLPControlBar.Size = new Size(592, 23);
            TLPControlBar.TabIndex = 1;
            // 
            // trackBar
            // 
            trackBar.Dock = DockStyle.Fill;
            trackBar.HeightPadding = 7;
            trackBar.Location = new Point(63, 2);
            trackBar.Margin = new Padding(3, 2, 3, 2);
            trackBar.Max = 100F;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(466, 19);
            trackBar.TabIndex = 0;
            trackBar.Value = 50F;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Dock = DockStyle.Right;
            currentTime.Location = new Point(27, 0);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(30, 23);
            currentTime.TabIndex = 1;
            currentTime.Text = "--:--";
            currentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Dock = DockStyle.Left;
            endTime.Location = new Point(535, 0);
            endTime.Name = "endTime";
            endTime.Size = new Size(30, 23);
            endTime.TabIndex = 2;
            endTime.Text = "--:--";
            endTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackInfo
            // 
            trackInfo.BackColor = SystemColors.Control;
            trackInfo.Dock = DockStyle.Fill;
            trackInfo.Image = null;
            trackInfo.Location = new Point(3, 3);
            trackInfo.Name = "trackInfo";
            trackInfo.Singer = "Discription";
            trackInfo.Size = new Size(124, 68);
            trackInfo.Source = null;
            trackInfo.TabIndex = 1;
            trackInfo.Title = "TrackTitle";
            // 
            // volumeArea
            // 
            volumeArea.ColumnCount = 1;
            volumeArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            volumeArea.Controls.Add(volumeBar, 0, 1);
            volumeArea.Dock = DockStyle.Fill;
            volumeArea.Location = new Point(745, 3);
            volumeArea.Name = "volumeArea";
            volumeArea.RowCount = 3;
            volumeArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            volumeArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            volumeArea.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            volumeArea.Size = new Size(124, 68);
            volumeArea.TabIndex = 2;
            // 
            // volumeBar
            // 
            volumeBar.Dock = DockStyle.Fill;
            volumeBar.Location = new Point(3, 7);
            volumeBar.Name = "volumeBar";
            volumeBar.Padding = new Padding(8);
            volumeBar.Size = new Size(118, 54);
            volumeBar.TabIndex = 0;
            // 
            // audioTimer
            // 
            audioTimer.Enabled = true;
            audioTimer.Interval = 1000;
            audioTimer.Tick += audioTimer_Tick;
            // 
            // AudioPlayerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TLPAudioKontrol);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AudioPlayerControl";
            Size = new Size(872, 74);
            TLPAudioKontrol.ResumeLayout(false);
            TLPControlMain.ResumeLayout(false);
            TLPControlButton.ResumeLayout(false);
            TLPControlBar.ResumeLayout(false);
            TLPControlBar.PerformLayout();
            volumeArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLPAudioKontrol;
        private TableLayoutPanel TLPControlMain;
        private TableLayoutPanel TLPControlButton;
        private TableLayoutPanel TLPControlBar;
        private TrackBar trackBar;
        private Label currentTime;
        private Label endTime;
        private System.Windows.Forms.Timer audioTimer;
        private PlayList musicInfo;
        private TrackInfo trackInfo;
        private CustomButton playButton;
        private CustomButton prevButton;
        private CustomButton nextButton;
        private CustomButton btnRepeat;
        public CustomButton btnRandom;
        private TableLayoutPanel volumeArea;
        private Elements.VolumeControl volumeBar;
    }
}
