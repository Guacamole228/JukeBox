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


                var track = new MusicItem(tracks[i]);
                track.PlayMusic += Track_PlayMusic;
                musicItemArea.Controls.Add(track);
            }

        }

        private void Track_PlayMusic(object? sender, EventArgs e)
        {
            MusicItem music = (MusicItem)sender!;
            musicGayBar1.PlayPause(music);
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