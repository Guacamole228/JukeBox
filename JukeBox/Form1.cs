namespace JukeBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tracks = Directory.GetFiles("music", "*.mp3");

            for (int i = 0; i < tracks.Length; i++)
            {
                FileInfo file = new FileInfo(tracks[i]);

                var track = new MusicItem();
                track.Title = file.Name.Replace(".wav", " ");
                track.Description = file.CreationTime.ToString("yyyy  MMMM ");
                musicItemArea.Controls.Add(track);


            }

        }
    }
}