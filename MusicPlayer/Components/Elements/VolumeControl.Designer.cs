namespace MusicPlayer.Components.Elements
{
    partial class VolumeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            volumeArea = new TableLayoutPanel();
            volumeImage = new PictureBox();
            volumeBar = new TrackBar();
            volumeArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volumeImage).BeginInit();
            SuspendLayout();
            // 
            // volumeArea
            // 
            volumeArea.ColumnCount = 2;
            volumeArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            volumeArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            volumeArea.Controls.Add(volumeImage, 0, 0);
            volumeArea.Controls.Add(volumeBar, 1, 0);
            volumeArea.Dock = DockStyle.Fill;
            volumeArea.Location = new Point(8, 8);
            volumeArea.Margin = new Padding(0);
            volumeArea.Name = "volumeArea";
            volumeArea.RowCount = 1;
            volumeArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            volumeArea.Size = new Size(184, 44);
            volumeArea.TabIndex = 0;
            // 
            // volumeImage
            // 
            volumeImage.Dock = DockStyle.Fill;
            volumeImage.Image = Properties.Resources.volume_down;
            volumeImage.Location = new Point(10, 10);
            volumeImage.Margin = new Padding(10);
            volumeImage.Name = "volumeImage";
            volumeImage.Size = new Size(30, 24);
            volumeImage.SizeMode = PictureBoxSizeMode.Zoom;
            volumeImage.TabIndex = 0;
            volumeImage.TabStop = false;
            // 
            // volumeBar
            // 
            volumeBar.Dock = DockStyle.Fill;
            volumeBar.HeightPadding = 14;
            volumeBar.Location = new Point(53, 2);
            volumeBar.Margin = new Padding(3, 2, 3, 2);
            volumeBar.Max = 100F;
            volumeBar.Name = "volumeBar";
            volumeBar.Size = new Size(128, 40);
            volumeBar.TabIndex = 1;
            volumeBar.Value = 50F;
            // 
            // VolumeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(volumeArea);
            Name = "VolumeControl";
            Padding = new Padding(8);
            Size = new Size(200, 60);
            volumeArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)volumeImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel volumeArea;
        private PictureBox volumeImage;
        private TrackBar volumeBar;
    }
}
