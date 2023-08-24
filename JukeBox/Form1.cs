using NAudio.Wave;

namespace JukeBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            hideSubMenu();  
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tracks = Directory.GetFiles("music", "*.mp3");

            for (int i = 0; i < tracks.Length; i++)
            {
                FileInfo file = new FileInfo(tracks[i]);

                var track = new MusicItem();
                track.File = file.FullName;
                track.PlayMusic += Track_PlayMusic;
                track.Title = file.Name.Replace(".mp3", " ");
                track.Description = file.CreationTime.ToString("yyyy  MMMM ");
                musicItemArea.Controls.Add(track);
            }

        }

        private void Track_PlayMusic(object? sender, EventArgs e)
        {
            string path = sender!.ToString()!;
            WaveOut wave = new WaveOut();
            AudioFileReader reader = new AudioFileReader(path);
            wave.Init(reader);
            wave.Play();
        }

        private void customizeDesing()
        {
            panelMediaSubMenu.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
            {
                panelMediaSubMenu.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            openDetiForm(new Form2());

            hideSubMenu();


        }
        private Form activeForm = null!;
        private void openDetiForm(Form DetiForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = DetiForm;
            DetiForm.TopLevel = false;
            DetiForm.FormBorderStyle = FormBorderStyle.None;
            DetiForm.Dock = DockStyle.Fill;
            panelDeti.Controls.Add(DetiForm);
            panelDeti.Tag = DetiForm;
            DetiForm.BringToFront();
            DetiForm.Show();
        }
    }
}