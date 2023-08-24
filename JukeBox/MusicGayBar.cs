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
            wave.Init(reader);
            wave.Play();
            start = true;
        }
    }
}
