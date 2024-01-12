namespace MusicPlayer.Components
{
    partial class MusicCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicCard));
            musicCardArea = new TableLayoutPanel();
            lbSinger = new Label();
            pbMusicImage = new PictureBox();
            lbMusicTitle = new Label();
            panelforEq = new Panel();
            EQ = new EQ();
            pictureBoxplay = new PictureBox();
            musicCardArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).BeginInit();
            panelforEq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxplay).BeginInit();
            SuspendLayout();
            // 
            // musicCardArea
            // 
            musicCardArea.ColumnCount = 1;
            musicCardArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicCardArea.Controls.Add(lbSinger, 0, 2);
            musicCardArea.Controls.Add(pbMusicImage, 0, 0);
            musicCardArea.Controls.Add(lbMusicTitle, 0, 1);
            musicCardArea.Dock = DockStyle.Fill;
            musicCardArea.Location = new Point(0, 0);
            musicCardArea.Margin = new Padding(0);
            musicCardArea.Name = "musicCardArea";
            musicCardArea.Padding = new Padding(23, 27, 23, 27);
            musicCardArea.RowCount = 3;
            musicCardArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicCardArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            musicCardArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            musicCardArea.Size = new Size(207, 335);
            musicCardArea.TabIndex = 0;
            // 
            // lbSinger
            // 
            lbSinger.AutoSize = true;
            lbSinger.BackColor = Color.Transparent;
            lbSinger.ForeColor = SystemColors.ControlDark;
            lbSinger.Location = new Point(29, 280);
            lbSinger.Margin = new Padding(6, 7, 6, 7);
            lbSinger.Name = "lbSinger";
            lbSinger.Size = new Size(50, 20);
            lbSinger.TabIndex = 2;
            lbSinger.Text = "label2";
            // 
            // pbMusicImage
            // 
            pbMusicImage.Dock = DockStyle.Fill;
            pbMusicImage.Location = new Point(29, 34);
            pbMusicImage.Margin = new Padding(6, 7, 6, 7);
            pbMusicImage.Name = "pbMusicImage";
            pbMusicImage.Size = new Size(149, 179);
            pbMusicImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbMusicImage.TabIndex = 0;
            pbMusicImage.TabStop = false;
            // 
            // lbMusicTitle
            // 
            lbMusicTitle.AutoSize = true;
            lbMusicTitle.BackColor = Color.Transparent;
            lbMusicTitle.Dock = DockStyle.Fill;
            lbMusicTitle.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbMusicTitle.ForeColor = Color.Maroon;
            lbMusicTitle.Location = new Point(29, 227);
            lbMusicTitle.Margin = new Padding(6, 7, 6, 7);
            lbMusicTitle.Name = "lbMusicTitle";
            lbMusicTitle.Size = new Size(149, 39);
            lbMusicTitle.TabIndex = 1;
            lbMusicTitle.Text = "label1";
            // 
            // panelforEq
            // 
            panelforEq.Controls.Add(EQ);
            panelforEq.Location = new Point(0, 298);
            panelforEq.Name = "panelforEq";
            panelforEq.Size = new Size(207, 37);
            panelforEq.TabIndex = 1;
            panelforEq.Visible = false;
            // 
            // EQ
            // 
            EQ.Dock = DockStyle.Fill;
            EQ.Location = new Point(0, 0);
            EQ.Name = "EQ";
            EQ.Size = new Size(207, 37);
            EQ.TabIndex = 0;
            // 
            // pictureBoxplay
            // 
            pictureBoxplay.BackColor = Color.Transparent;
            pictureBoxplay.Image = (Image)resources.GetObject("pictureBoxplay.Image");
            pictureBoxplay.Location = new Point(66, 115);
            pictureBoxplay.Name = "pictureBoxplay";
            pictureBoxplay.Size = new Size(70, 70);
            pictureBoxplay.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxplay.TabIndex = 2;
            pictureBoxplay.TabStop = false;
            pictureBoxplay.Visible = false;
            // 
            // MusicCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBoxplay);
            Controls.Add(panelforEq);
            Controls.Add(musicCardArea);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MusicCard";
            Size = new Size(207, 335);
            Enter += MusicCard_Enter;
            Leave += MusicCard_Leave;
            musicCardArea.ResumeLayout(false);
            musicCardArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMusicImage).EndInit();
            panelforEq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicCardArea;
        private Label lbSinger;
        private PictureBox pbMusicImage;
        private Label lbMusicTitle;
        private Panel panelforEq;
        private EQ EQ;
        private PictureBox pictureBoxplay;
    }
}
