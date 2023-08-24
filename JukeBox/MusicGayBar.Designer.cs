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
            components = new System.ComponentModel.Container();
            MusicTrackBarArea = new TableLayoutPanel();
            musicControlArea = new TableLayoutPanel();
            musicButtoms = new TableLayoutPanel();
            play = new Button();
            pictureBox1 = new PictureBox();
            btnnext = new PictureBox();
            TrackBarArea = new TableLayoutPanel();
            TrackBar = new TableLayoutPanel();
            GrayLine = new Label();
            whiteLine = new Label();
            currentTime = new Label();
            endTime = new Label();
            musicplaytimer = new System.Windows.Forms.Timer(components);
            MusicTrackBarArea.SuspendLayout();
            musicControlArea.SuspendLayout();
            musicButtoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnnext).BeginInit();
            TrackBarArea.SuspendLayout();
            TrackBar.SuspendLayout();
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
            musicControlArea.Controls.Add(TrackBarArea, 0, 1);
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
            musicButtoms.Controls.Add(play, 2, 0);
            musicButtoms.Controls.Add(pictureBox1, 1, 0);
            musicButtoms.Controls.Add(btnnext, 3, 0);
            musicButtoms.Dock = DockStyle.Fill;
            musicButtoms.Location = new Point(3, 3);
            musicButtoms.Name = "musicButtoms";
            musicButtoms.RowCount = 1;
            musicButtoms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicButtoms.Size = new Size(717, 74);
            musicButtoms.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.levo11;
            pictureBox1.Location = new Point(241, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnnext
            // 
            btnnext.Dock = DockStyle.Fill;
            btnnext.Image = Properties.Resources.pravo1;
            btnnext.Location = new Point(401, 3);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(74, 68);
            btnnext.SizeMode = PictureBoxSizeMode.Zoom;
            btnnext.TabIndex = 2;
            btnnext.TabStop = false;
            
            // 
            // TrackBarArea
            // 
            TrackBarArea.ColumnCount = 3;
            TrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            TrackBarArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TrackBarArea.Controls.Add(TrackBar, 1, 0);
            TrackBarArea.Controls.Add(currentTime, 0, 0);
            TrackBarArea.Controls.Add(endTime, 2, 0);
            TrackBarArea.Location = new Point(3, 83);
            TrackBarArea.Name = "TrackBarArea";
            TrackBarArea.RowCount = 1;
            TrackBarArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TrackBarArea.Size = new Size(717, 58);
            TrackBarArea.TabIndex = 1;
            // 
            // TrackBar
            // 
            TrackBar.BackColor = Color.Transparent;
            TrackBar.ColumnCount = 2;
            TrackBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TrackBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            TrackBar.Controls.Add(GrayLine, 1, 0);
            TrackBar.Controls.Add(whiteLine, 0, 0);
            TrackBar.Dock = DockStyle.Fill;
            TrackBar.Location = new Point(61, 3);
            TrackBar.Name = "TrackBar";
            TrackBar.Padding = new Padding(0, 8, 0, 8);
            TrackBar.RowCount = 1;
            TrackBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TrackBar.Size = new Size(594, 52);
            TrackBar.TabIndex = 0;
            // 
            // GrayLine
            // 
            GrayLine.AutoSize = true;
            GrayLine.BackColor = Color.DimGray;
            GrayLine.Dock = DockStyle.Fill;
            GrayLine.Location = new Point(148, 8);
            GrayLine.Margin = new Padding(0);
            GrayLine.Name = "GrayLine";
            GrayLine.Size = new Size(446, 36);
            GrayLine.TabIndex = 1;
            // 
            // whiteLine
            // 
            whiteLine.AutoSize = true;
            whiteLine.BackColor = Color.WhiteSmoke;
            whiteLine.Dock = DockStyle.Fill;
            whiteLine.Location = new Point(0, 8);
            whiteLine.Margin = new Padding(0);
            whiteLine.Name = "whiteLine";
            whiteLine.Size = new Size(148, 36);
            whiteLine.TabIndex = 0;
            // 
            // currentTime
            // 
            currentTime.AutoSize = true;
            currentTime.Dock = DockStyle.Right;
            currentTime.ForeColor = SystemColors.ButtonShadow;
            currentTime.Location = new Point(21, 0);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(34, 58);
            currentTime.TabIndex = 1;
            currentTime.Text = "00:00";
            currentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Dock = DockStyle.Left;
            endTime.ForeColor = SystemColors.ButtonShadow;
            endTime.Location = new Point(661, 0);
            endTime.Name = "endTime";
            endTime.Size = new Size(34, 58);
            endTime.TabIndex = 2;
            endTime.Text = "00:00";
            endTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // musicplaytimer
            // 
            musicplaytimer.Tick += musicplaytimer_Tick;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnnext).EndInit();
            TrackBarArea.ResumeLayout(false);
            TrackBarArea.PerformLayout();
            TrackBar.ResumeLayout(false);
            TrackBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MusicTrackBarArea;
        private TableLayoutPanel musicControlArea;
        private TableLayoutPanel musicButtoms;
        private Button play;
        private PictureBox pictureBox1;
        private PictureBox btnnext;
        private TableLayoutPanel TrackBarArea;
        private TableLayoutPanel TrackBar;
        private Label GrayLine;
        private Label whiteLine;
        private Label currentTime;
        private Label endTime;
        private System.Windows.Forms.Timer musicplaytimer;
    }
}
