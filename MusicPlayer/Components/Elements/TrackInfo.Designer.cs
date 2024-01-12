namespace MusicPlayer.Components
{
    partial class TrackInfo
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
            pictureList = new PictureBox();
            PanelHaupt = new TableLayoutPanel();
            PanelText = new TableLayoutPanel();
            TextTrackTitle = new Label();
            TextSinger = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureList).BeginInit();
            PanelHaupt.SuspendLayout();
            PanelText.SuspendLayout();
            SuspendLayout();
            // 
            // pictureList
            // 
            pictureList.BackColor = SystemColors.ControlLight;
            pictureList.Dock = DockStyle.Fill;
            pictureList.Location = new Point(6, 5);
            pictureList.Margin = new Padding(0);
            pictureList.Name = "pictureList";
            pictureList.Size = new Size(67, 64);
            pictureList.SizeMode = PictureBoxSizeMode.Zoom;
            pictureList.TabIndex = 1;
            pictureList.TabStop = false;
            // 
            // PanelHaupt
            // 
            PanelHaupt.BackColor = SystemColors.ControlLight;
            PanelHaupt.ColumnCount = 2;
            PanelHaupt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PanelHaupt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            PanelHaupt.Controls.Add(pictureList, 0, 0);
            PanelHaupt.Controls.Add(PanelText, 1, 0);
            PanelHaupt.Dock = DockStyle.Fill;
            PanelHaupt.ForeColor = SystemColors.ControlText;
            PanelHaupt.Location = new Point(0, 0);
            PanelHaupt.Margin = new Padding(3, 2, 3, 2);
            PanelHaupt.Name = "PanelHaupt";
            PanelHaupt.Padding = new Padding(6, 5, 6, 5);
            PanelHaupt.RowCount = 1;
            PanelHaupt.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelHaupt.Size = new Size(283, 74);
            PanelHaupt.TabIndex = 1;
            // 
            // PanelText
            // 
            PanelText.BackColor = SystemColors.ControlLight;
            PanelText.ColumnCount = 1;
            PanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelText.Controls.Add(TextTrackTitle, 0, 0);
            PanelText.Controls.Add(TextSinger, 0, 1);
            PanelText.Dock = DockStyle.Fill;
            PanelText.Location = new Point(73, 5);
            PanelText.Margin = new Padding(0);
            PanelText.Name = "PanelText";
            PanelText.RowCount = 2;
            PanelText.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            PanelText.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            PanelText.Size = new Size(204, 64);
            PanelText.TabIndex = 2;
            // 
            // TextTrackTitle
            // 
            TextTrackTitle.AutoSize = true;
            TextTrackTitle.BackColor = SystemColors.ControlLight;
            TextTrackTitle.Dock = DockStyle.Fill;
            TextTrackTitle.Font = new Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextTrackTitle.ForeColor = Color.FromArgb(150, 60, 96);
            TextTrackTitle.Location = new Point(3, 0);
            TextTrackTitle.Name = "TextTrackTitle";
            TextTrackTitle.Size = new Size(198, 36);
            TextTrackTitle.TabIndex = 0;
            TextTrackTitle.Text = "TrackTitle";
            // 
            // TextSinger
            // 
            TextSinger.AutoSize = true;
            TextSinger.BackColor = SystemColors.ControlLight;
            TextSinger.Dock = DockStyle.Fill;
            TextSinger.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextSinger.ForeColor = SystemColors.ControlDarkDark;
            TextSinger.Location = new Point(3, 36);
            TextSinger.Name = "TextSinger";
            TextSinger.Size = new Size(198, 28);
            TextSinger.TabIndex = 1;
            TextSinger.Text = "Discription";
            // 
            // TrackInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(PanelHaupt);
            Name = "TrackInfo";
            Size = new Size(283, 74);
            ((System.ComponentModel.ISupportInitialize)pictureList).EndInit();
            PanelHaupt.ResumeLayout(false);
            PanelText.ResumeLayout(false);
            PanelText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureList;
        private TableLayoutPanel PanelHaupt;
        private TableLayoutPanel PanelText;
        private Label TextTrackTitle;
        private Label TextSinger;
    }
}
