namespace MusicPlayer.Components
{
    partial class EQ
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
            EQpanel = new Panel();
            timerEQ = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // EQpanel
            // 
            EQpanel.Dock = DockStyle.Fill;
            EQpanel.Location = new Point(0, 0);
            EQpanel.Name = "EQpanel";
            EQpanel.Size = new Size(291, 150);
            EQpanel.TabIndex = 0;
            EQpanel.Paint += EQpanel_Paint;
            // 
            // EQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EQpanel);
            Name = "EQ";
            Size = new Size(291, 150);
            ResumeLayout(false);
        }

        #endregion

        private Panel EQpanel;
        private System.Windows.Forms.Timer timerEQ;
    }
}
