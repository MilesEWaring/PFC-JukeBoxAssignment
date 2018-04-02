using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JukeBoxAssignmentv1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ListBox[] Song_Library;
        String[] Title_Genre;
        bool SongPlaying = false;

        private void setUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUp setUp = new SetUp();
            setUp.ShowDialog();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void About_MenuStrip_Btn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String AppPath = Directory.GetCurrentDirectory() + "\\Media\\";
            StreamReader ChosenMedia = File.OpenText(AppPath + "Media.txt");
            String ReadChosenMedia = ChosenMedia.ReadLine();

            int CheckNo;
            if(int.TryParse(ReadChosenMedia, out CheckNo))
            {
                Song_Library = new ListBox[CheckNo];

            }
            int Genre_Counter = Song_Library.Count();
            SelectGenre_HscrollBar.Maximum = Genre_Counter - 1;
            Title_Genre = new string[Genre_Counter];

            ReadChosenMedia = ChosenMedia.ReadLine();

            for(int index = 0; index < Genre_Counter; index++)
            {
                Song_Library[index] = new ListBox();

                if(int.TryParse(ReadChosenMedia, out CheckNo) == true)
                {
                    ReadChosenMedia = ChosenMedia.ReadLine();
                    Title_Genre[index] = ReadChosenMedia;
                    ReadChosenMedia = ChosenMedia.ReadLine();

                    while(int.TryParse(ReadChosenMedia, out CheckNo) != true && ReadChosenMedia != null)
                    {
                        Song_Library[index].Items.Add(ReadChosenMedia);
                        ReadChosenMedia = ChosenMedia.ReadLine();

                    }
                }
            }
            DisplayMedia();
        }

        private void DisplayMedia()
        {
            GenreList_lstBox.Items.Clear();
            int HScrollPos = SelectGenre_HscrollBar.Value;
            int itemNo = Song_Library[HScrollPos].Items.Count;
            GenreTitle_txtBox.Text = Title_Genre[HScrollPos];

            for(int IndexOfItem = 0; IndexOfItem < itemNo; IndexOfItem++)
            {
                GenreList_lstBox.Items.Add(Song_Library[HScrollPos].Items[IndexOfItem]);
            }
        }

        private void SelectGenre_HscrollBar_ValueChanged(object sender, EventArgs e)
        {
            DisplayMedia();
        }

        private void GenreList_lstBox_DoubleClick(object sender, EventArgs e)
        {
            int SongIndex = GenreList_lstBox.SelectedIndex;
            string SongSelected = GenreList_lstBox.Items[SongIndex].ToString();

            if(SongPlaying == true)
            {
                PlayList_ListBox.Items.Add(SongSelected);
            }
            else if(SongPlaying == false && PlayList_ListBox.Items.Count == 0)
            {
                PresentlyPlaying_txtBox.Text = SongSelected;
                String PathOfTrack = Directory.GetCurrentDirectory() + "\\Tracks\\";
                axWindowsMediaPlayer1.URL = PathOfTrack + SongSelected;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                SongPlaying = true;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Enabled = false;
                MoveSong();
            }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                SongPlaying = true;
                
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                SongPlaying = false;
                timer1.Enabled = true;

            }
        }

        private void MoveSong()
        {
            PresentlyPlaying_txtBox.Text = PlayList_ListBox.Items[0].ToString();
            PlayList_ListBox.Items.RemoveAt(0);

            String PathOfTrack = Directory.GetCurrentDirectory() + "\\Tracks\\";
            axWindowsMediaPlayer1.URL = PathOfTrack + PresentlyPlaying_txtBox.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
