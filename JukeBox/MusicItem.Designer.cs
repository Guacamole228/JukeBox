namespace JukeBox
{
    partial class MusicItem
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
            musicArea = new TableLayoutPanel();
            musicitemimage = new PictureBox();
            title = new Label();
            description = new Label();
            musicArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)musicitemimage).BeginInit();
            SuspendLayout();
            // 
            // musicArea
            // 
            musicArea.ColumnCount = 1;
            musicArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            musicArea.Controls.Add(musicitemimage, 0, 0);
            musicArea.Controls.Add(title, 0, 1);
            musicArea.Controls.Add(description, 0, 2);
            musicArea.Dock = DockStyle.Fill;
            musicArea.Location = new Point(0, 0);
            musicArea.Name = "musicArea";
            musicArea.Padding = new Padding(20);
            musicArea.RowCount = 3;
            musicArea.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            musicArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            musicArea.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            musicArea.Size = new Size(230, 330);
            musicArea.TabIndex = 0;
            // 
            // musicitemimage
            // 
            musicitemimage.Dock = DockStyle.Fill;
            musicitemimage.Image = Properties.Resources.omnom;
            musicitemimage.Location = new Point(23, 23);
            musicitemimage.Name = "musicitemimage";
            musicitemimage.Size = new Size(184, 204);
            musicitemimage.SizeMode = PictureBoxSizeMode.StretchImage;
            musicitemimage.TabIndex = 0;
            musicitemimage.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Fill;
            title.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.WhiteSmoke;
            title.Location = new Point(23, 230);
            title.Name = "title";
            title.Size = new Size(184, 40);
            title.TabIndex = 1;
            title.Text = "label1";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = Color.Silver;
            description.Location = new Point(23, 270);
            description.Name = "description";
            description.Size = new Size(184, 40);
            description.TabIndex = 2;
            description.Text = "label2";
            description.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MusicItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(musicArea);
            Margin = new Padding(10);
            Name = "MusicItem";
            Size = new Size(230, 330);
            musicArea.ResumeLayout(false);
            musicArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)musicitemimage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel musicArea;
        private PictureBox musicitemimage;
        private Label title;
        private Label description;
    }
}
