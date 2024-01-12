namespace MusicPlayer.Components
{
    partial class TrackBar
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
            TrackBarArea = new TableLayoutPanel();
            FirstLine = new Label();
            LastLine = new Label();
            TrackBarArea.SuspendLayout();
            SuspendLayout();
            // 
            // TrackBarArea
            // 
            TrackBarArea.ColumnCount = 2;
            TrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TrackBarArea.Controls.Add(FirstLine, 0, 0);
            TrackBarArea.Controls.Add(LastLine, 1, 0);
            TrackBarArea.Dock = DockStyle.Fill;
            TrackBarArea.Location = new Point(0, 0);
            TrackBarArea.Name = "TrackBarArea";
            TrackBarArea.RowCount = 1;
            TrackBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TrackBarArea.Size = new Size(728, 41);
            TrackBarArea.TabIndex = 0;
            TrackBarArea.MouseClick += FirstLine_MouseClick;
            // 
            // FirstLine
            // 
            FirstLine.AutoSize = true;
            FirstLine.BackColor = Color.Red;
            FirstLine.Cursor = Cursors.Hand;
            FirstLine.Dock = DockStyle.Fill;
            FirstLine.Location = new Point(0, 0);
            FirstLine.Margin = new Padding(0);
            FirstLine.Name = "FirstLine";
            FirstLine.Size = new Size(364, 41);
            FirstLine.TabIndex = 0;
            FirstLine.MouseClick += FirstLine_MouseClick;
            // 
            // LastLine
            // 
            LastLine.AutoSize = true;
            LastLine.BackColor = SystemColors.ButtonShadow;
            LastLine.Cursor = Cursors.Hand;
            LastLine.Dock = DockStyle.Fill;
            LastLine.Location = new Point(364, 0);
            LastLine.Margin = new Padding(0);
            LastLine.Name = "LastLine";
            LastLine.Size = new Size(364, 41);
            LastLine.TabIndex = 1;
            LastLine.MouseClick += LastLine_MouseClick;
            // 
            // TrackBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TrackBarArea);
            Name = "TrackBar";
            Size = new Size(728, 41);
            TrackBarArea.ResumeLayout(false);
            TrackBarArea.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TrackBarArea;
        private Label FirstLine;
        private Label LastLine;
    }
}
