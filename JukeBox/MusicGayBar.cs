using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukeBox
{
    public partial class MusicGayBar : UserControl
    {
        public MusicGayBar()
        {
            InitializeComponent();
        }
        WaveOut wave;
        AudioFileReader reader;
        bool start = false;
        private void play_Click(object sender, EventArgs e)
        {
            if (start)
            {
                wave.Pause();
            }
            else
            {
                wave.Play();
            }
            start = !start;
        }

        public void PlayPause(MusicItem track)
        {

            if (wave != null)
            {
                wave.Dispose();
                reader.Dispose();
            }
            wave = new WaveOut();
            reader = new AudioFileReader(track.File);
            Play();

        }

        void Play()
        {
            wave.Init(reader);
            wave.Play();
            musicplaytimer.Start();
            start = true;
            TimeSpan end = reader.TotalTime;
            endTime.Text = $"{end:mm}:{end:ss}";
        }



        private void musicplaytimer_Tick(object sender, EventArgs e)
        {
            TimeSpan current = reader.CurrentTime;
            currentTime.Text = $"{current:mm}:{current:ss} ";

            float timePercent =(float)(reader.CurrentTime / reader.TotalTime * 100);
            TrackBar.ColumnStyles[0].Width = timePercent;
            TrackBar.ColumnStyles[1].Width = 100 - timePercent;
        }
    }
}
