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
    public partial class MusicItem : UserControl
    {
        public MusicItem()
        {
            InitializeComponent();
            HoverRecursive(musicArea);
           // Click.Recursive(musicArea);





        }

        private void MusicArea_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 50, 50);
        }

        private void MusicArea_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(60, 60, 60);
        }

        void HoverRecursive(Control element)
        {
            element.MouseEnter += MusicArea_MouseEnter;
            element.MouseLeave += MusicArea_MouseLeave;


            for (int i = 0; i < element.Controls.Count; i++)
            {
                HoverRecursive(element.Controls[i]);
            }


        }
        void ClickRecursive(Control element)
        {
            element.MouseDown += Element_MouseDown;
            element.MouseUp += Element_MouseUp;


            for (int i = 0; i < element.Controls.Count; i++)
            {
                ClickRecursive(element.Controls[i]);
            }


        }

        private void Element_MouseUp(object? sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(60, 60, 60);
        }

        private void Element_MouseDown(object? sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(70, 70, 70);
        }



        [Category("Властивості трека")]
        public string Title
        {
            get
            {
                return title.Text;
            }
            set
            {
                title.Text = value;
            }
        }
        [Category("Властивості трека")]
        public string Description
        {
            get
            {
                return description.Text;
            }
            set
            {
                description.Text = value;
            }
        }
    }
    
}


