namespace JukeBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            panelMediaSubMenu = new Panel();
            pictureBox2 = new PictureBox();
            buttonplay = new PictureBox();
            btnMedia = new Button();
            panel1 = new Panel();
            panelDown = new Panel();
            musicGayBar1 = new MusicGayBar();
            panelDeti = new Panel();
            musicItemArea = new FlowLayoutPanel();
            panelLeft.SuspendLayout();
            panelMediaSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonplay).BeginInit();
            panelDown.SuspendLayout();
            panelDeti.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panelMediaSubMenu);
            panelLeft.Controls.Add(btnMedia);
            panelLeft.Controls.Add(panel1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(2, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(5);
            panelLeft.Size = new Size(200, 503);
            panelLeft.TabIndex = 0;
            // 
            // panelMediaSubMenu
            // 
            panelMediaSubMenu.BackColor = Color.FromArgb(30, 30, 30);
            panelMediaSubMenu.Controls.Add(pictureBox2);
            panelMediaSubMenu.Controls.Add(buttonplay);
            panelMediaSubMenu.Dock = DockStyle.Top;
            panelMediaSubMenu.Location = new Point(5, 150);
            panelMediaSubMenu.Name = "panelMediaSubMenu";
            panelMediaSubMenu.Size = new Size(190, 150);
            panelMediaSubMenu.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(45, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // buttonplay
            // 
            buttonplay.Image = Properties.Resources.media_player_icon_png;
            buttonplay.Location = new Point(45, 20);
            buttonplay.Name = "buttonplay";
            buttonplay.Size = new Size(100, 50);
            buttonplay.SizeMode = PictureBoxSizeMode.Zoom;
            buttonplay.TabIndex = 0;
            buttonplay.TabStop = false;
            buttonplay.Click += buttonplay_Click;
            // 
            // btnMedia
            // 
            btnMedia.Dock = DockStyle.Top;
            btnMedia.FlatStyle = FlatStyle.Flat;
            btnMedia.ForeColor = SystemColors.ButtonFace;
            btnMedia.Location = new Point(5, 105);
            btnMedia.Name = "btnMedia";
            btnMedia.Size = new Size(190, 45);
            btnMedia.TabIndex = 1;
            btnMedia.Text = "Открыть мою медиатеку";
            btnMedia.UseVisualStyleBackColor = true;
            btnMedia.Click += btnMedia_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 100);
            panel1.TabIndex = 0;
            // 
            // panelDown
            // 
            panelDown.Controls.Add(musicGayBar1);
            panelDown.Dock = DockStyle.Bottom;
            panelDown.Location = new Point(2, 505);
            panelDown.Name = "panelDown";
            panelDown.Size = new Size(1229, 96);
            panelDown.TabIndex = 1;
            // 
            // musicGayBar1
            // 
            musicGayBar1.BackColor = Color.FromArgb(15, 15, 15);
            musicGayBar1.Dock = DockStyle.Bottom;
            musicGayBar1.Location = new Point(0, 0);
            musicGayBar1.Name = "musicGayBar1";
            musicGayBar1.Size = new Size(1229, 96);
            musicGayBar1.TabIndex = 0;
            // 
            // panelDeti
            // 
            panelDeti.Controls.Add(musicItemArea);
            panelDeti.Dock = DockStyle.Fill;
            panelDeti.Location = new Point(202, 2);
            panelDeti.Name = "panelDeti";
            panelDeti.Size = new Size(1029, 503);
            panelDeti.TabIndex = 2;
            // 
            // musicItemArea
            // 
            musicItemArea.AutoScroll = true;
            musicItemArea.Dock = DockStyle.Fill;
            musicItemArea.Location = new Point(0, 0);
            musicItemArea.Margin = new Padding(0);
            musicItemArea.Name = "musicItemArea";
            musicItemArea.Padding = new Padding(5);
            musicItemArea.Size = new Size(1029, 503);
            musicItemArea.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1233, 603);
            Controls.Add(panelDeti);
            Controls.Add(panelLeft);
            Controls.Add(panelDown);
            Name = "Form1";
            Padding = new Padding(2);
            Text = "Form1";
            Load += Form1_Load;
            panelLeft.ResumeLayout(false);
            panelMediaSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonplay).EndInit();
            panelDown.ResumeLayout(false);
            panelDeti.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelDown;
        private Panel panelDeti;
        private FlowLayoutPanel musicItemArea;
        private Panel panel1;
        private Button btnMedia;
        private Panel panelMediaSubMenu;
        private PictureBox pictureBox2;
        private PictureBox buttonplay;
        private MusicGayBar musicGayBar1;
    }
}