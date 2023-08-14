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
            musicItemArea = new FlowLayoutPanel();
            musicItem1 = new MusicItem();
            musicItemArea.SuspendLayout();
            SuspendLayout();
            // 
            // musicItemArea
            // 
            musicItemArea.AutoScroll = true;
            musicItemArea.BackColor = Color.FromArgb(30, 30, 30);
            musicItemArea.Controls.Add(musicItem1);
            musicItemArea.Dock = DockStyle.Fill;
            musicItemArea.Location = new Point(0, 0);
            musicItemArea.Name = "musicItemArea";
            musicItemArea.Size = new Size(1164, 478);
            musicItemArea.TabIndex = 0;
            // 
            // musicItem1
            // 
            musicItem1.BackColor = Color.FromArgb(50, 50, 50);
            musicItem1.Description = "label2";
            musicItem1.Location = new Point(10, 10);
            musicItem1.Margin = new Padding(10);
            musicItem1.Name = "musicItem1";
            musicItem1.Size = new Size(230, 330);
            musicItem1.TabIndex = 0;
            musicItem1.Title = "2313";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 478);
            Controls.Add(musicItemArea);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            musicItemArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel musicItemArea;
        private MusicItem musicItem1;
    }
}