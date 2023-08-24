namespace JukeBox
{
    partial class MusicGayBar
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
            MusicTrackBarArea = new TableLayoutPanel();
            musicControlArea = new TableLayoutPanel();
            musicButtoms = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            play = new Button();
            MusicTrackBarArea.SuspendLayout();
            musicControlArea.SuspendLayout();
            musicButtoms.SuspendLayout();
            SuspendLayout();
            // 
            // MusicTrackBarArea
            // 
            MusicTrackBarArea.ColumnCount = 3;
            MusicTrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            MusicTrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MusicTrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            MusicTrackBarArea.Controls.Add(musicControlArea, 1, 0);
            MusicTrackBarArea.Dock = DockStyle.Fill;
            MusicTrackBarArea.Location = new Point(0, 0);
            MusicTrackBarArea.Name = "MusicTrackBarArea";
            MusicTrackBarArea.RowCount = 1;
            MusicTrackBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MusicTrackBarArea.Size = new Size(1229, 144);
            MusicTrackBarArea.TabIndex = 0;
            // 
            // musicControlArea
            // 
            musicControlArea.ColumnCount = 1;
            musicControlArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicControlArea.Controls.Add(musicButtoms, 0, 0);
            musicControlArea.Dock = DockStyle.Fill;
            musicControlArea.Location = new Point(253, 3);
            musicControlArea.Name = "musicControlArea";
            musicControlArea.RowCount = 2;
            musicControlArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            musicControlArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            musicControlArea.Size = new Size(723, 138);
            musicControlArea.TabIndex = 0;
            // 
            // musicButtoms
            // 
            musicButtoms.ColumnCount = 5;
            musicButtoms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            musicButtoms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            musicButtoms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            musicButtoms.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            musicButtoms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            musicButtoms.Controls.Add(button3, 1, 0);
            musicButtoms.Controls.Add(button2, 3, 0);
            musicButtoms.Controls.Add(play, 2, 0);
            musicButtoms.Dock = DockStyle.Fill;
            musicButtoms.Location = new Point(3, 3);
            musicButtoms.Name = "musicButtoms";
            musicButtoms.RowCount = 1;
            musicButtoms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicButtoms.Size = new Size(717, 74);
            musicButtoms.TabIndex = 0;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(241, 3);
            button3.Name = "button3";
            button3.Size = new Size(74, 68);
            button3.TabIndex = 2;
            button3.Text = "B";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(401, 3);
            button2.Name = "button2";
            button2.Size = new Size(74, 68);
            button2.TabIndex = 1;
            button2.Text = "N";
            button2.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            play.Dock = DockStyle.Fill;
            play.Location = new Point(321, 3);
            play.Name = "play";
            play.Size = new Size(74, 68);
            play.TabIndex = 0;
            play.Text = "P";
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // MusicGayBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(MusicTrackBarArea);
            Name = "MusicGayBar";
            Size = new Size(1229, 144);
            MusicTrackBarArea.ResumeLayout(false);
            musicControlArea.ResumeLayout(false);
            musicButtoms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MusicTrackBarArea;
        private TableLayoutPanel musicControlArea;
        private TableLayoutPanel musicButtoms;
        private Button button3;
        private Button button2;
        private Button play;
    }
}
