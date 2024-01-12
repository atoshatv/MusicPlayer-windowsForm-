namespace MusicPlayer.Components
{
    partial class PlayList
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
            PanelHaupt = new TableLayoutPanel();
            pictureList = new PictureBox();
            PanelText = new TableLayoutPanel();
            TextPlaylistName = new Label();
            TextDiscription = new Label();
            PanelHaupt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureList).BeginInit();
            PanelText.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHaupt
            // 
            PanelHaupt.BackColor = Color.White;
            PanelHaupt.ColumnCount = 2;
            PanelHaupt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            PanelHaupt.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            PanelHaupt.Controls.Add(pictureList, 0, 0);
            PanelHaupt.Controls.Add(PanelText, 1, 0);
            PanelHaupt.Dock = DockStyle.Fill;
            PanelHaupt.ForeColor = SystemColors.ControlText;
            PanelHaupt.Location = new Point(0, 0);
            PanelHaupt.Name = "PanelHaupt";
            PanelHaupt.Padding = new Padding(7);
            PanelHaupt.RowCount = 1;
            PanelHaupt.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            PanelHaupt.Size = new Size(287, 82);
            PanelHaupt.TabIndex = 0;
            // 
            // pictureList
            // 
            pictureList.Dock = DockStyle.Fill;
            pictureList.Location = new Point(7, 7);
            pictureList.Margin = new Padding(0);
            pictureList.Name = "pictureList";
            pictureList.Size = new Size(68, 68);
            pictureList.SizeMode = PictureBoxSizeMode.Zoom;
            pictureList.TabIndex = 1;
            pictureList.TabStop = false;
            // 
            // PanelText
            // 
            PanelText.ColumnCount = 1;
            PanelText.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            PanelText.Controls.Add(TextPlaylistName, 0, 0);
            PanelText.Controls.Add(TextDiscription, 0, 1);
            PanelText.Dock = DockStyle.Fill;
            PanelText.Location = new Point(75, 7);
            PanelText.Margin = new Padding(0);
            PanelText.Name = "PanelText";
            PanelText.RowCount = 2;
            PanelText.RowStyles.Add(new RowStyle(SizeType.Percent, 57.1428566F));
            PanelText.RowStyles.Add(new RowStyle(SizeType.Percent, 42.8571434F));
            PanelText.Size = new Size(205, 68);
            PanelText.TabIndex = 2;
            // 
            // TextPlaylistName
            // 
            TextPlaylistName.AutoSize = true;
            TextPlaylistName.Dock = DockStyle.Fill;
            TextPlaylistName.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextPlaylistName.ForeColor = Color.Maroon;
            TextPlaylistName.Location = new Point(3, 0);
            TextPlaylistName.Name = "TextPlaylistName";
            TextPlaylistName.Size = new Size(199, 38);
            TextPlaylistName.TabIndex = 0;
            TextPlaylistName.Text = "PlayListName";
            // 
            // TextDiscription
            // 
            TextDiscription.AutoSize = true;
            TextDiscription.Dock = DockStyle.Fill;
            TextDiscription.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TextDiscription.ForeColor = SystemColors.ControlDarkDark;
            TextDiscription.Location = new Point(3, 38);
            TextDiscription.Name = "TextDiscription";
            TextDiscription.Size = new Size(199, 30);
            TextDiscription.TabIndex = 1;
            TextDiscription.Text = "Discription";
            // 
            // PlayList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelHaupt);
            Name = "PlayList";
            Size = new Size(287, 82);
            PanelHaupt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureList).EndInit();
            PanelText.ResumeLayout(false);
            PanelText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel PanelHaupt;
        private PictureBox pictureList;
        private TableLayoutPanel PanelText;
        private Label TextPlaylistName;
        private Label TextDiscription;
    }
}
