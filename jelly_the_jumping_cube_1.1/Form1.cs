using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Threading;

namespace jelly_the_jumping_cube_1._1
{
    public partial class Form1 : Form
    {
        int index, g = 17, force, c1 = 1, c2 = 1, c3 = 1, c4 = 1, c5 = 1, c6 = 1, c7 = 1, c8 = 1, c9 = 1, c10 = 1, c11 = 1, c12 = 1, c13 = 1, c14 = 1, c15 = 1, c16 = 1, c17 = 1, c18 = 1;
        bool right, left, jump; 
        

        //StreamReader reader = new StreamReader(@"text.txt");
       // StreamWriter writer = new StreamWriter(@"text1.txt");
        WindowsMediaPlayer[] musicplayer = new WindowsMediaPlayer[10];
        WindowsMediaPlayer[] ingamesoundplayer = new WindowsMediaPlayer[3];
        string content = File.ReadAllText(@"text.txt"); int inter;
        string leveldecider = File.ReadAllText(@"levelfile.txt"); int intleveldecider;
        string level1score = File.ReadAllText(@"level1score.txt"); int intlevel1score;
        public void initialization()
        {
             inter = int.Parse(content);
            if (inter > 6) inter = 0;
            index = inter;
            intleveldecider = int.Parse(leveldecider);
            intlevel1score = int.Parse(level1score);
        }

        public void resetmediaplayer()
        {
            inter++;
            content = inter.ToString(); File.WriteAllText(@"text.txt", content);
        }

        public void activatebuttons()
        {
            audiosettingsbutton.Visible = true;
            storybutton.Visible = true;
            playbutton.Visible = true;
            creditsbutton.Visible = true;
        }

        public void deactivatebutons()
        {
            audiosettingsbutton.Visible = false;
            storybutton.Visible = false;
            playbutton.Visible = false;
            creditsbutton.Visible = false;


        }

        public void activatetrackbar()
        {
            musictrackbar.Visible = true;
            ingamesoundtrackbar.Visible = true;
        }

        public void deactivatetrackbar()
        {
            musictrackbar.Visible = false;
            ingamesoundtrackbar.Visible = false;
        }

        public Form1()
        {
            InitializeComponent();
            
            musicplayer[0] = new WindowsMediaPlayer(); musicplayer[0].URL = "song1.mp3"; musicplayer[0].controls.stop();
            musicplayer[1] = new WindowsMediaPlayer(); musicplayer[1].URL = "song2.mp3"; musicplayer[1].controls.stop();
            musicplayer[2] = new WindowsMediaPlayer(); musicplayer[2].URL = "song3.mp3"; musicplayer[2].controls.stop();
            musicplayer[3] = new WindowsMediaPlayer(); musicplayer[3].URL = "song4.mp3"; musicplayer[3].controls.stop();
            musicplayer[4] = new WindowsMediaPlayer(); musicplayer[4].URL = "song5.mp3"; musicplayer[4].controls.stop();
            musicplayer[5] = new WindowsMediaPlayer(); musicplayer[5].URL = "song6.mp3"; musicplayer[5].controls.stop();
            musicplayer[6] = new WindowsMediaPlayer(); musicplayer[6].URL = "song7.mp3"; musicplayer[6].controls.stop();
            musicplayer[7] = new WindowsMediaPlayer();
            musicplayer[8] = new WindowsMediaPlayer();
            musicplayer[9] = new WindowsMediaPlayer();

            ingamesoundplayer[0] = new WindowsMediaPlayer(); ingamesoundplayer[0].URL = "beep1.mp3"; ingamesoundplayer[0].controls.stop();
            ingamesoundplayer[1] = new WindowsMediaPlayer(); ingamesoundplayer[1].URL = "beep2.mp3"; ingamesoundplayer[1].controls.stop();
            
            initialization();
            resetmediaplayer();
            this.KeyPreview = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameplaylevel3.Parent = mainmenu;
            gameplaylevel1.Parent = mainmenu;
            gameplaylevel2.Parent = mainmenu;
            storypage3.Parent = mainmenu; 
            storypage2.Parent = mainmenu; 
            storypage1.Parent = mainmenu; 
            Creditspage.Parent = mainmenu;
            playbutton.Parent = mainmenu;
            creditsbutton.Parent = mainmenu;
            audiosettingsbutton.Parent = mainmenu;
            storybutton.Parent=mainmenu;
            blackimage.Parent = mainmenu;
            information_page.Parent = mainmenu;

            plant1lvl1.Parent = gameplaylevel1; coin1lvl1.Parent = gameplaylevel1; coin7lvl1.Parent = gameplaylevel1; coin11lvl1.Parent = gameplaylevel1;
            plant2lvl1.Parent = gameplaylevel1; coin2lvl1.Parent = gameplaylevel1; coin8lvl1.Parent = gameplaylevel1; coin12lvl1.Parent = gameplaylevel1;
            plant3lvl1.Parent = gameplaylevel1; coin3lvl1.Parent = gameplaylevel1; coin9lvl1.Parent = gameplaylevel1; coin13lvl1.Parent = gameplaylevel1;
            plant4lvl1.Parent = gameplaylevel1; coin4lvl1.Parent = gameplaylevel1; coin10lvl1.Parent = gameplaylevel1; coin14lvl1.Parent = gameplaylevel1;
            coin6lvl1.Parent = gameplaylevel1; coin5lvl1.Parent = gameplaylevel1; coin15lvl1.Parent = gameplaylevel1; coin16lvl1.Parent = gameplaylevel1;
            coin17lvl1.Parent = gameplaylevel1; coin18lvl1.Parent = gameplaylevel1;

            plant1lvl2.Parent = gameplaylevel2; coin1lvl2.Parent = gameplaylevel2; coin7lvl2.Parent = gameplaylevel2; coin11lvl2.Parent = gameplaylevel2;
            plant2lvl2.Parent = gameplaylevel2; coin2lvl2.Parent = gameplaylevel2; coin8lvl2.Parent = gameplaylevel2; coin12lvl2.Parent = gameplaylevel2;
            plant3lvl2.Parent = gameplaylevel2; coin3lvl2.Parent = gameplaylevel2; coin9lvl2.Parent = gameplaylevel2; coin13lvl2.Parent = gameplaylevel2;
            plant4lvl2.Parent = gameplaylevel2; coin4lvl2.Parent = gameplaylevel2; coin10lvl2.Parent = gameplaylevel2; coin14lvl2.Parent = gameplaylevel2;
            coin6lvl2.Parent = gameplaylevel2; coin5lvl2.Parent = gameplaylevel2; coin15lvl2.Parent = gameplaylevel2; coin16lvl2.Parent = gameplaylevel2;
            coin17lvl2.Parent = gameplaylevel2; coin18lvl2.Parent = gameplaylevel2;

            plant1lvl3.Parent = gameplaylevel3; coin1lvl3.Parent = gameplaylevel3; coin7lvl3.Parent = gameplaylevel3; coin11lvl3.Parent = gameplaylevel3;
            plant2lvl3.Parent = gameplaylevel3; coin2lvl3.Parent = gameplaylevel3; coin8lvl3.Parent = gameplaylevel3; coin12lvl3.Parent = gameplaylevel3;
            coin3lvl3.Parent = gameplaylevel3; coin9lvl3.Parent = gameplaylevel3; coin13lvl3.Parent = gameplaylevel3;
            coin4lvl3.Parent = gameplaylevel3; coin10lvl3.Parent = gameplaylevel3; coin14lvl3.Parent = gameplaylevel3;
            coin6lvl3.Parent = gameplaylevel3; coin5lvl3.Parent = gameplaylevel3; coin15lvl3.Parent = gameplaylevel3; coin16lvl3.Parent = gameplaylevel3;
            coin17lvl3.Parent = gameplaylevel3; coin18lvl3.Parent = gameplaylevel3;

            this.MaximizeBox = false;
            musictrackbar.Minimum = 0;
            musictrackbar.Maximum = 100;
            musictrackbar.Value = 100;
            ingamesoundtrackbar.Minimum = 0;
            ingamesoundtrackbar.Maximum = 100;
            ingamesoundtrackbar.Value = 100;
            deactivatetrackbar();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timerforinformationimage.Enabled = true;
            blackimage.Visible = false;
            information_page.Visible = true;
        }

        private void timerforinformationimage_Tick(object sender, EventArgs e)
        {

            timerforinformationimage.Enabled = false;
            information_page.Visible = false;
            blackimage.Visible = false;
            activatebuttons();
            song1timer.Enabled = true;
            if (index > 6) index = 0;
            musicplayer[index].controls.play();
            index++;    
        }

        private void song1timer_Tick(object sender, EventArgs e)
        {
            song1timer.Enabled = false;
            musicplayer[index].controls.play();
            song2timer.Enabled=true;
            index++;
        }

        private void song2timer_Tick(object sender, EventArgs e)
        {
            song2timer.Enabled = false;
            musicplayer[index].controls.play();
            song3timer.Enabled = true;
            index++;
        }

        private void song3timer_Tick(object sender, EventArgs e)
        {
            song3timer.Enabled = false;
            musicplayer[index].controls.play();
            song4timer.Enabled = true;
            index++;
        }

        private void song4timer_Tick(object sender, EventArgs e)
        {
            song4timer.Enabled = false;
            musicplayer[index].controls.play();
            song5timer.Enabled = true;
            index++;
        }

        private void song5timer_Tick(object sender, EventArgs e)
        {
            song5timer.Enabled = false;
            musicplayer[index].controls.play();
            song6timer.Enabled = true;
            index++;
        }

        private void song6timer_Tick(object sender, EventArgs e)
        {
            song6timer.Enabled = false;
            musicplayer[index].controls.play();
            song7timer.Enabled = true;
            index++;
        }

        private void song7timer_Tick(object sender, EventArgs e)
        {
            song7timer.Enabled = false;
            musicplayer[index].controls.play();
            song1timer.Enabled = true;
            index++;
        }

        private void information_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void storybutton_Click(object sender, EventArgs e)
        {
            deactivatebutons();
            storypage1.Visible = true;
            timerforstorypage1.Enabled = true;
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            leveldecider = File.ReadAllText(@"levelfile.txt");
            intleveldecider = int.Parse(leveldecider);
            if ( intleveldecider == 1)
            {
                deactivatebutons();
                gameplaylevel1.Visible = true;
                level1timer.Enabled = true;
                specialtimer.Enabled = true;
            }
            if (intleveldecider == 2)
            {
                deactivatebutons();
                gameplaylevel2.Visible = true;
                level2timer.Enabled = true;
                specialtimer2.Enabled = true;
            }
            if (intleveldecider == 3)
            {
                deactivatebutons();
                gameplaylevel3.Visible = true;
                level3timer.Enabled = true;
                specialtimer3.Enabled = true;
                bat1timer.Enabled = true;
                bat2timer.Enabled = true;
            }
        }

        private void audiosettingsbutton_Click(object sender, EventArgs e)
        {
            audiosettingspage.Visible = true;
            deactivatebutons();
            activatetrackbar();
        }

        private void creditsbutton_Click(object sender, EventArgs e)
        {
            Creditspage.Visible = true;
            deactivatebutons();
        }

        private void backbuttonsettings_Click(object sender, EventArgs e)
        {
            audiosettingspage.Visible = false;
            activatebuttons();
            
        }

        private void musictrackbar_Scroll(object sender, EventArgs e)
        {
            musicplayer[0].settings.volume = musictrackbar.Value;
            musicplayer[1].settings.volume = musictrackbar.Value;
            musicplayer[2].settings.volume = musictrackbar.Value;
            musicplayer[3].settings.volume = musictrackbar.Value;
            musicplayer[4].settings.volume = musictrackbar.Value;
            musicplayer[5].settings.volume = musictrackbar.Value;
            musicplayer[6].settings.volume = musictrackbar.Value;
            musicplayer[7].settings.volume = musictrackbar.Value;
            
 
        }

        private void ingamesoundtrackbar_Scroll(object sender, EventArgs e)
        {
            ingamesoundplayer[0].settings.volume = ingamesoundtrackbar.Value;
            ingamesoundplayer[1].settings.volume = ingamesoundtrackbar.Value;
  
        }

        private void creditspagebackbutton_Click(object sender, EventArgs e)
        {
            Creditspage.Visible = false;
            activatebuttons();
        }

        private void timerforstorypage1_Tick(object sender, EventArgs e)
        {
            storypage1.Visible = false;
            storypage2.Visible = true;
            timerforstorypage1.Enabled = false;
            timerforstorypage2.Enabled = true;
        }

        private void timerforstorypage2_Tick(object sender, EventArgs e)
        {
            storypage2.Visible = false;
            storypage3.Visible = true;
            timerforstorypage2.Enabled = false;
            timerforstorypage3.Enabled = true;
        }

        private void timerforstorypage3_Tick(object sender, EventArgs e)
        {
            storypage3.Visible = false;
            activatebuttons();
            timerforstorypage3.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
           // if (jump != true)
            //{
                if (e.KeyCode == Keys.Space)
                {
                    jump = true; force = g; //ingamesoundplayer[0].controls.play();
                }
            //}
               // e.Handled = true;
        }


        

        private void level1timer_Tick(object sender, EventArgs e)
        {
            g = 17;
            if (player.Left <= plant1lvl1.Right && player.Bottom >= plant1lvl1.Top && player.Right > plant1lvl1.Right && player.Top < plant1lvl1.Top || player.Top < plant1lvl1.Top && player.Left < plant1lvl1.Left && player.Right > plant1lvl1.Left && player.Bottom > plant1lvl1.Top || player.Right > plant1lvl1.Right && player.Left < plant1lvl1.Right && player.Left > plant1lvl1.Left && player.Top > plant1lvl1.Top && player.Bottom < plant1lvl1.Bottom || player.Top > plant1lvl1.Top && player.Left < plant1lvl1.Left && player.Right > plant1lvl1.Left && player.Bottom > plant1lvl1.Bottom && player.Right < plant1lvl1.Right && player.Top < plant1lvl1.Bottom) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Left <= plant2lvl1.Right && player.Bottom >= plant2lvl1.Top && player.Right > plant2lvl1.Right && player.Top < plant2lvl1.Top || player.Top < plant2lvl1.Top && player.Left < plant2lvl1.Left && player.Right > plant2lvl1.Left && player.Bottom > plant2lvl1.Top || player.Right > plant2lvl1.Right && player.Left < plant2lvl1.Right && player.Left > plant2lvl1.Left && player.Top > plant2lvl1.Top && player.Bottom < plant2lvl1.Bottom || player.Top > plant2lvl1.Top && player.Left < plant2lvl1.Left && player.Right > plant2lvl1.Left && player.Bottom > plant2lvl1.Bottom && player.Right < plant2lvl1.Right && player.Top < plant2lvl1.Bottom) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Left <= plant3lvl1.Right && player.Bottom >= plant3lvl1.Top && player.Right > plant3lvl1.Right && player.Top < plant3lvl1.Top || player.Top < plant3lvl1.Top && player.Left < plant3lvl1.Left && player.Right > plant3lvl1.Left && player.Bottom > plant3lvl1.Top || player.Right > plant3lvl1.Right && player.Left < plant3lvl1.Right && player.Left > plant3lvl1.Left && player.Top > plant3lvl1.Top && player.Bottom < plant3lvl1.Bottom || player.Top > plant3lvl1.Top && player.Left < plant3lvl1.Left && player.Right > plant3lvl1.Left && player.Bottom > plant3lvl1.Bottom && player.Right < plant3lvl1.Right && player.Top < plant3lvl1.Bottom) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Left <= plant4lvl1.Right && player.Bottom >= plant4lvl1.Top && player.Right > plant4lvl1.Right && player.Top < plant4lvl1.Top || player.Top < plant4lvl1.Top && player.Left < plant4lvl1.Left && player.Right > plant4lvl1.Left && player.Bottom > plant4lvl1.Top || player.Right > plant4lvl1.Right && player.Left < plant4lvl1.Right && player.Left > plant4lvl1.Left && player.Top > plant4lvl1.Top && player.Bottom < plant4lvl1.Bottom || player.Top > plant4lvl1.Top && player.Left < plant4lvl1.Left && player.Right > plant4lvl1.Left && player.Bottom > plant4lvl1.Bottom && player.Right < plant4lvl1.Right && player.Top < plant4lvl1.Bottom) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }


            if (player.Top < plant1lvl1.Top && player.Bottom >= plant1lvl1.Top && player.Bottom < plant1lvl1.Bottom && player.Left > plant1lvl1.Left && player.Left < plant1lvl1.Right && player.Right > plant1lvl1.Left && player.Right < plant1lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top < plant2lvl1.Top && player.Bottom >= plant2lvl1.Top && player.Bottom < plant2lvl1.Bottom && player.Left > plant2lvl1.Left && player.Left < plant2lvl1.Right && player.Right > plant2lvl1.Left && player.Right < plant2lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top < plant3lvl1.Top && player.Bottom >= plant3lvl1.Top && player.Bottom < plant3lvl1.Bottom && player.Left > plant3lvl1.Left && player.Left < plant3lvl1.Right && player.Right > plant3lvl1.Left && player.Right < plant3lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top < plant4lvl1.Top && player.Bottom >= plant4lvl1.Top && player.Bottom < plant4lvl1.Bottom && player.Left > plant4lvl1.Left && player.Left < plant4lvl1.Right && player.Right > plant4lvl1.Left && player.Right < plant4lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }

            if (player.Top > plant1lvl1.Top && player.Top <= plant1lvl1.Bottom && player.Bottom > plant1lvl1.Bottom && player.Left > plant1lvl1.Left && player.Left < plant1lvl1.Right && player.Right > plant1lvl1.Left && player.Right < plant1lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top > plant2lvl1.Top && player.Top <= plant2lvl1.Bottom && player.Bottom > plant2lvl1.Bottom && player.Left > plant2lvl1.Left && player.Left < plant2lvl1.Right && player.Right > plant2lvl1.Left && player.Right < plant2lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top > plant3lvl1.Top && player.Top <= plant3lvl1.Bottom && player.Bottom > plant3lvl1.Bottom && player.Left > plant3lvl1.Left && player.Left < plant3lvl1.Right && player.Right > plant3lvl1.Left && player.Right < plant3lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top > plant4lvl1.Top && player.Top <= plant4lvl1.Bottom && player.Bottom > plant4lvl1.Bottom && player.Left > plant4lvl1.Left && player.Left < plant4lvl1.Right && player.Right > plant4lvl1.Left && player.Right < plant4lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }



            if (player.Top > plant1lvl1.Top && player.Top < plant1lvl1.Bottom && player.Left < plant1lvl1.Left && player.Left < plant1lvl1.Right && player.Bottom < plant1lvl1.Bottom && player.Bottom > plant1lvl1.Top && player.Right < plant1lvl1.Right && player.Right >= plant1lvl1.Left) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top > plant2lvl1.Top && player.Top < plant2lvl1.Bottom && player.Left < plant2lvl1.Left && player.Left < plant2lvl1.Right && player.Bottom < plant2lvl1.Bottom && player.Bottom > plant2lvl1.Top && player.Right < plant2lvl1.Right && player.Right >= plant2lvl1.Left) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top > plant3lvl1.Top && player.Top < plant3lvl1.Bottom && player.Left < plant3lvl1.Left && player.Left < plant3lvl1.Right && player.Bottom < plant3lvl1.Bottom && player.Bottom > plant3lvl1.Top && player.Right < plant3lvl1.Right && player.Right >= plant3lvl1.Left) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top > plant4lvl1.Top && player.Top < plant4lvl1.Bottom && player.Left < plant4lvl1.Left && player.Left < plant4lvl1.Right && player.Bottom < plant4lvl1.Bottom && player.Bottom > plant4lvl1.Top && player.Right < plant4lvl1.Right && player.Right >= plant4lvl1.Left) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }

            if (player.Top < plant1lvl1.Bottom && player.Top > plant1lvl1.Top && player.Bottom > plant1lvl1.Top && player.Bottom < plant1lvl1.Bottom && player.Right > plant1lvl1.Right && player.Right > plant1lvl1.Left && player.Left > plant1lvl1.Left && player.Left <= plant1lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top < plant2lvl1.Bottom && player.Top > plant2lvl1.Top && player.Bottom > plant2lvl1.Top && player.Bottom < plant2lvl1.Bottom && player.Right > plant2lvl1.Right && player.Right > plant2lvl1.Left && player.Left > plant2lvl1.Left && player.Left <= plant2lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top < plant3lvl1.Bottom && player.Top > plant3lvl1.Top && player.Bottom > plant3lvl1.Top && player.Bottom < plant3lvl1.Bottom && player.Right > plant3lvl1.Right && player.Right > plant3lvl1.Left && player.Left > plant3lvl1.Left && player.Left <= plant3lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }
            if (player.Top < plant4lvl1.Bottom && player.Top > plant4lvl1.Top && player.Bottom > plant4lvl1.Top && player.Bottom < plant4lvl1.Bottom && player.Right > plant4lvl1.Right && player.Right > plant4lvl1.Left && player.Left > plant4lvl1.Left && player.Left <= plant4lvl1.Right) { ingamesoundplayer[1].controls.play(); level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); player.Location = new Point(10, 300); MessageBox.Show("Jelly is dead !!"); specialtimer.Enabled = false; }


            if (intlevel1score == 0) { specialtimer.Enabled = false; level1timer.Enabled = false; gameplaylevel1.Visible = false; activatebuttons(); MessageBox.Show("Yeyyyy Level up !!"); File.WriteAllText(@"levelfile.txt", "2"); intlevel1score = 18; c1 = 1; c2 = 1; c3 = 1; c4 = 1; c5 = 1; c6 = 1; c7 = 1; c8 = 1; c9 = 1; c10 = 1; c11 = 1; c12 = 1; c13 = 1; c14 = 1; c15 = 1; c16 = 1; c17 = 1; c18 = 1; }
            if (coin1lvl1.Bottom <= player.Bottom && coin1lvl1.Top > player.Top && coin1lvl1.Left > player.Left && coin1lvl1.Right < player.Right && c1 == 1) { coin1lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c1 = 0; intlevel1score--; }
            if (coin2lvl1.Bottom <= player.Bottom && coin2lvl1.Top > player.Top && coin2lvl1.Left > player.Left && coin2lvl1.Right < player.Right && c2 == 1) { coin2lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c2 = 0; intlevel1score--; }
            if (coin3lvl1.Bottom <= player.Bottom && coin3lvl1.Top > player.Top && coin3lvl1.Left > player.Left && coin3lvl1.Right < player.Right && c3 == 1) { coin3lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c3 = 0; intlevel1score--; }
            if (coin4lvl1.Bottom <= player.Bottom && coin4lvl1.Top > player.Top && coin4lvl1.Left > player.Left && coin4lvl1.Right < player.Right && c4 == 1) { coin4lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c4 = 0; intlevel1score--; }
            if (coin5lvl1.Bottom <= player.Bottom && coin5lvl1.Top > player.Top && coin5lvl1.Left > player.Left && coin5lvl1.Right < player.Right && c5 == 1) { coin5lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c5 = 0; intlevel1score--; }
            if (coin6lvl1.Bottom <= player.Bottom && coin6lvl1.Top > player.Top && coin6lvl1.Left > player.Left && coin6lvl1.Right < player.Right && c6 == 1) { coin6lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c6 = 0; intlevel1score--; }
            if (coin7lvl1.Bottom <= player.Bottom && coin7lvl1.Top > player.Top && coin7lvl1.Left > player.Left && coin7lvl1.Right < player.Right && c7 == 1) { coin7lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c7 = 0; intlevel1score--; }
            if (coin8lvl1.Bottom <= player.Bottom && coin8lvl1.Top > player.Top && coin8lvl1.Left > player.Left && coin8lvl1.Right < player.Right && c8 == 1) { coin8lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c8 = 0; intlevel1score--; }
            if (coin9lvl1.Bottom <= player.Bottom && coin9lvl1.Top > player.Top && coin9lvl1.Left > player.Left && coin9lvl1.Right < player.Right && c9 == 1) { coin9lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c9 = 0; intlevel1score--; }
            if (coin10lvl1.Bottom <= player.Bottom && coin10lvl1.Top > player.Top && coin10lvl1.Left > player.Left && coin10lvl1.Right < player.Right && c10 == 1) { coin10lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c10 = 0; intlevel1score--; }
            if (coin11lvl1.Bottom <= player.Bottom && coin11lvl1.Top > player.Top && coin11lvl1.Left > player.Left && coin11lvl1.Right < player.Right && c11 == 1) { coin11lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c11 = 0; intlevel1score--; }
            if (coin12lvl1.Bottom <= player.Bottom && coin12lvl1.Top > player.Top && coin12lvl1.Left > player.Left && coin12lvl1.Right < player.Right && c12 == 1) { coin12lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c12 = 0; intlevel1score--; }
            if (coin13lvl1.Bottom <= player.Bottom && coin13lvl1.Top > player.Top && coin13lvl1.Left > player.Left && coin13lvl1.Right < player.Right && c13 == 1) { coin13lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c13 = 0; intlevel1score--; }
            if (coin14lvl1.Bottom <= player.Bottom && coin14lvl1.Top > player.Top && coin14lvl1.Left > player.Left && coin14lvl1.Right < player.Right && c14 == 1) { coin14lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c14 = 0; intlevel1score--; }
            if (coin15lvl1.Bottom <= player.Bottom && coin15lvl1.Top > player.Top && coin15lvl1.Left > player.Left && coin15lvl1.Right < player.Right && c15 == 1) { coin15lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c15 = 0; intlevel1score--; }
            if (coin16lvl1.Bottom <= player.Bottom && coin16lvl1.Top > player.Top && coin16lvl1.Left > player.Left && coin16lvl1.Right < player.Right && c16 == 1) { coin16lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c16 = 0; intlevel1score--; }
            if (coin17lvl1.Bottom <= player.Bottom && coin17lvl1.Top > player.Top && coin17lvl1.Left > player.Left && coin17lvl1.Right < player.Right && c17 == 1) { coin17lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c17 = 0; intlevel1score--; }
            if (coin18lvl1.Bottom <= player.Bottom && coin18lvl1.Top > player.Top && coin18lvl1.Left > player.Left && coin18lvl1.Right < player.Right && c18 == 1) { coin18lvl1.Visible = false; ingamesoundplayer[0].controls.play(); c18 = 0; intlevel1score--; }
            if (jump == true)
            {
                player.Top -= force;
                force -= 1;
            }

            if (player.Top + player.Height >= gameplaylevel1.Height)
            {
                player.Top = gameplaylevel1.Height - player.Height;
                jump = false;

            }
            else
            {
                player.Top += 5;
            }


        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void level1exit_Click(object sender, EventArgs e)
        {
            specialtimer.Enabled = false;
            level1timer.Enabled = false;
            gameplaylevel1.Visible = false;
            activatebuttons();
        }

        private void specialtimer_Tick(object sender, EventArgs e)
        {
            if (player.Left < 0) { left = false; jump = false; }
            if (player.Right > gameplaylevel1.Right) { right = false; jump = false; }

            if (right == true) { player.Left += 5; }
            if (left == true) { player.Left -= 5; }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {           
        }

        private void coin3lvl1_Click(object sender, EventArgs e)
        {

        }

        private void coin17lvl1_Click(object sender, EventArgs e)
        {

        }

        private void coin16lvl2_Click(object sender, EventArgs e)
        {

        }

        private void level2exit_Click(object sender, EventArgs e)
        {
            specialtimer2.Enabled = false;
            level2timer.Enabled = false;
            gameplaylevel2.Visible = false;
            activatebuttons();
        }

        private void level2timer_Tick(object sender, EventArgs e)
        {
            g = 17;
            if (player1.Left <= plant1lvl2.Right && player1.Bottom >= plant1lvl2.Top && player1.Right > plant1lvl2.Right && player1.Top < plant1lvl2.Top || player1.Top < plant1lvl2.Top && player1.Left < plant1lvl2.Left && player1.Right > plant1lvl2.Left && player1.Bottom > plant1lvl2.Top || player1.Right > plant1lvl2.Right && player1.Left < plant1lvl2.Right && player1.Left > plant1lvl2.Left && player1.Top > plant1lvl2.Top && player1.Bottom < plant1lvl2.Bottom || player1.Top > plant1lvl2.Top && player1.Left < plant1lvl2.Left && player1.Right > plant1lvl2.Left && player1.Bottom > plant1lvl2.Bottom && player1.Right < plant1lvl2.Right && player1.Top < plant1lvl2.Bottom) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Left <= plant2lvl2.Right && player1.Bottom >= plant2lvl2.Top && player1.Right > plant2lvl2.Right && player1.Top < plant2lvl2.Top || player1.Top < plant2lvl2.Top && player1.Left < plant2lvl2.Left && player1.Right > plant2lvl2.Left && player1.Bottom > plant2lvl2.Top || player1.Right > plant2lvl2.Right && player1.Left < plant2lvl2.Right && player1.Left > plant2lvl2.Left && player1.Top > plant2lvl2.Top && player1.Bottom < plant2lvl2.Bottom || player1.Top > plant2lvl2.Top && player1.Left < plant2lvl2.Left && player1.Right > plant2lvl2.Left && player1.Bottom > plant2lvl2.Bottom && player1.Right < plant2lvl2.Right && player1.Top < plant2lvl2.Bottom) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Left <= plant3lvl2.Right && player1.Bottom >= plant3lvl2.Top && player1.Right > plant3lvl2.Right && player1.Top < plant3lvl2.Top || player1.Top < plant3lvl2.Top && player1.Left < plant3lvl2.Left && player1.Right > plant3lvl2.Left && player1.Bottom > plant3lvl2.Top || player1.Right > plant3lvl2.Right && player1.Left < plant3lvl2.Right && player1.Left > plant3lvl2.Left && player1.Top > plant3lvl2.Top && player1.Bottom < plant3lvl2.Bottom || player1.Top > plant3lvl2.Top && player1.Left < plant3lvl2.Left && player1.Right > plant3lvl2.Left && player1.Bottom > plant3lvl2.Bottom && player1.Right < plant3lvl2.Right && player1.Top < plant3lvl2.Bottom) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Left <= plant4lvl2.Right && player1.Bottom >= plant4lvl2.Top && player1.Right > plant4lvl2.Right && player1.Top < plant4lvl2.Top || player1.Top < plant4lvl2.Top && player1.Left < plant4lvl2.Left && player1.Right > plant4lvl2.Left && player1.Bottom > plant4lvl2.Top || player1.Right > plant4lvl2.Right && player1.Left < plant4lvl2.Right && player1.Left > plant4lvl2.Left && player1.Top > plant4lvl2.Top && player1.Bottom < plant4lvl2.Bottom || player1.Top > plant4lvl2.Top && player1.Left < plant4lvl2.Left && player1.Right > plant4lvl2.Left && player1.Bottom > plant4lvl2.Bottom && player1.Right < plant4lvl2.Right && player1.Top < plant4lvl2.Bottom) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }


            if (player1.Top < plant1lvl2.Top && player1.Bottom >= plant1lvl2.Top && player1.Bottom < plant1lvl2.Bottom && player1.Left > plant1lvl2.Left && player1.Left < plant1lvl2.Right && player1.Right > plant1lvl2.Left && player1.Right < plant1lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top < plant2lvl2.Top && player1.Bottom >= plant2lvl2.Top && player1.Bottom < plant2lvl2.Bottom && player1.Left > plant2lvl2.Left && player1.Left < plant2lvl2.Right && player1.Right > plant2lvl2.Left && player1.Right < plant2lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top < plant3lvl2.Top && player1.Bottom >= plant3lvl2.Top && player1.Bottom < plant3lvl2.Bottom && player1.Left > plant3lvl2.Left && player1.Left < plant3lvl2.Right && player1.Right > plant3lvl2.Left && player1.Right < plant3lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top < plant4lvl2.Top && player1.Bottom >= plant4lvl2.Top && player1.Bottom < plant4lvl2.Bottom && player1.Left > plant4lvl2.Left && player1.Left < plant4lvl2.Right && player1.Right > plant4lvl2.Left && player1.Right < plant4lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }

            if (player1.Top > plant1lvl2.Top && player1.Top <= plant1lvl2.Bottom && player1.Bottom > plant1lvl2.Bottom && player1.Left > plant1lvl2.Left && player1.Left < plant1lvl2.Right && player1.Right > plant1lvl2.Left && player1.Right < plant1lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top > plant2lvl2.Top && player1.Top <= plant2lvl2.Bottom && player1.Bottom > plant2lvl2.Bottom && player1.Left > plant2lvl2.Left && player1.Left < plant2lvl2.Right && player1.Right > plant2lvl2.Left && player1.Right < plant2lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top > plant3lvl2.Top && player1.Top <= plant3lvl2.Bottom && player1.Bottom > plant3lvl2.Bottom && player1.Left > plant3lvl2.Left && player1.Left < plant3lvl2.Right && player1.Right > plant3lvl2.Left && player1.Right < plant3lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top > plant4lvl2.Top && player1.Top <= plant4lvl2.Bottom && player1.Bottom > plant4lvl2.Bottom && player1.Left > plant4lvl2.Left && player1.Left < plant4lvl2.Right && player1.Right > plant4lvl2.Left && player1.Right < plant4lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }



            if (player1.Top > plant1lvl2.Top && player1.Top < plant1lvl2.Bottom && player1.Left < plant1lvl2.Left && player1.Left < plant1lvl2.Right && player1.Bottom < plant1lvl2.Bottom && player1.Bottom > plant1lvl2.Top && player1.Right < plant1lvl2.Right && player1.Right >= plant1lvl2.Left) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top > plant2lvl2.Top && player1.Top < plant2lvl2.Bottom && player1.Left < plant2lvl2.Left && player1.Left < plant2lvl2.Right && player1.Bottom < plant2lvl2.Bottom && player1.Bottom > plant2lvl2.Top && player1.Right < plant2lvl2.Right && player1.Right >= plant2lvl2.Left) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top > plant3lvl2.Top && player1.Top < plant3lvl2.Bottom && player1.Left < plant3lvl2.Left && player1.Left < plant3lvl2.Right && player1.Bottom < plant3lvl2.Bottom && player1.Bottom > plant3lvl2.Top && player1.Right < plant3lvl2.Right && player1.Right >= plant3lvl2.Left) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top > plant4lvl2.Top && player1.Top < plant4lvl2.Bottom && player1.Left < plant4lvl2.Left && player1.Left < plant4lvl2.Right && player1.Bottom < plant4lvl2.Bottom && player1.Bottom > plant4lvl2.Top && player1.Right < plant4lvl2.Right && player1.Right >= plant4lvl2.Left) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }

            if (player1.Top < plant1lvl2.Bottom && player1.Top > plant1lvl2.Top && player1.Bottom > plant1lvl2.Top && player1.Bottom < plant1lvl2.Bottom && player1.Right > plant1lvl2.Right && player1.Right > plant1lvl2.Left && player1.Left > plant1lvl2.Left && player1.Left <= plant1lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top < plant2lvl2.Bottom && player1.Top > plant2lvl2.Top && player1.Bottom > plant2lvl2.Top && player1.Bottom < plant2lvl2.Bottom && player1.Right > plant2lvl2.Right && player1.Right > plant2lvl2.Left && player1.Left > plant2lvl2.Left && player1.Left <= plant2lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top < plant3lvl2.Bottom && player1.Top > plant3lvl2.Top && player1.Bottom > plant3lvl2.Top && player1.Bottom < plant3lvl2.Bottom && player1.Right > plant3lvl2.Right && player1.Right > plant3lvl2.Left && player1.Left > plant3lvl2.Left && player1.Left <= plant3lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }
            if (player1.Top < plant4lvl2.Bottom && player1.Top > plant4lvl2.Top && player1.Bottom > plant4lvl2.Top && player1.Bottom < plant4lvl2.Bottom && player1.Right > plant4lvl2.Right && player1.Right > plant4lvl2.Left && player1.Left > plant4lvl2.Left && player1.Left <= plant4lvl2.Right) { level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); player1.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer2.Enabled = false; }


            if (intlevel1score == 0) { specialtimer.Enabled = false; level2timer.Enabled = false; gameplaylevel2.Visible = false; activatebuttons(); MessageBox.Show("Yeyyyy Level up !!"); File.WriteAllText(@"levelfile.txt", "3"); intlevel1score = 18; c1 = 1; c2 = 1; c3 = 1; c4 = 1; c5 = 1; c6 = 1; c7 = 1; c8 = 1; c9 = 1; c10 = 1; c11 = 1; c12 = 1; c13 = 1; c14 = 1; c15 = 1; c16 = 1; c17 = 1; c18 = 1; }
            if (coin1lvl2.Bottom <= player1.Bottom && coin1lvl2.Top > player1.Top && coin1lvl2.Left > player1.Left && coin1lvl2.Right < player1.Right && c1 == 1) { coin1lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c1 = 0; intlevel1score--; }
            if (coin2lvl2.Bottom <= player1.Bottom && coin2lvl2.Top > player1.Top && coin2lvl2.Left > player1.Left && coin2lvl2.Right < player1.Right && c2 == 1) { coin2lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c2 = 0; intlevel1score--; }
            if (coin3lvl2.Bottom <= player1.Bottom && coin3lvl2.Top > player1.Top && coin3lvl2.Left > player1.Left && coin3lvl2.Right < player1.Right && c3 == 1) { coin3lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c3 = 0; intlevel1score--; }
            if (coin4lvl2.Bottom <= player1.Bottom && coin4lvl2.Top > player1.Top && coin4lvl2.Left > player1.Left && coin4lvl2.Right < player1.Right && c4 == 1) { coin4lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c4 = 0; intlevel1score--; }
            if (coin5lvl2.Bottom <= player1.Bottom && coin5lvl2.Top > player1.Top && coin5lvl2.Left > player1.Left && coin5lvl2.Right < player1.Right && c5 == 1) { coin5lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c5 = 0; intlevel1score--; }
            if (coin6lvl2.Bottom <= player1.Bottom && coin6lvl2.Top > player1.Top && coin6lvl2.Left > player1.Left && coin6lvl2.Right < player1.Right && c6 == 1) { coin6lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c6 = 0; intlevel1score--; }
            if (coin7lvl2.Bottom <= player1.Bottom && coin7lvl2.Top > player1.Top && coin7lvl2.Left > player1.Left && coin7lvl2.Right < player1.Right && c7 == 1) { coin7lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c7 = 0; intlevel1score--; }
            if (coin8lvl2.Bottom <= player1.Bottom && coin8lvl2.Top > player1.Top && coin8lvl2.Left > player1.Left && coin8lvl2.Right < player1.Right && c8 == 1) { coin8lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c8 = 0; intlevel1score--; }
            if (coin9lvl2.Bottom <= player1.Bottom && coin9lvl2.Top > player1.Top && coin9lvl2.Left > player1.Left && coin9lvl2.Right < player1.Right && c9 == 1) { coin9lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c9 = 0; intlevel1score--; }
            if (coin10lvl2.Bottom <= player1.Bottom && coin10lvl2.Top > player1.Top && coin10lvl2.Left > player1.Left && coin10lvl2.Right < player1.Right && c10 == 1) { coin10lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c10 = 0; intlevel1score--; }
            if (coin11lvl2.Bottom <= player1.Bottom && coin11lvl2.Top > player1.Top && coin11lvl2.Left > player1.Left && coin11lvl2.Right < player1.Right && c11 == 1) { coin11lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c11 = 0; intlevel1score--; }
            if (coin12lvl2.Bottom <= player1.Bottom && coin12lvl2.Top > player1.Top && coin12lvl2.Left > player1.Left && coin12lvl2.Right < player1.Right && c12 == 1) { coin12lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c12 = 0; intlevel1score--; }
            if (coin13lvl2.Bottom <= player1.Bottom && coin13lvl2.Top > player1.Top && coin13lvl2.Left > player1.Left && coin13lvl2.Right < player1.Right && c13 == 1) { coin13lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c13 = 0; intlevel1score--; }
            if (coin14lvl2.Bottom <= player1.Bottom && coin14lvl2.Top > player1.Top && coin14lvl2.Left > player1.Left && coin14lvl2.Right < player1.Right && c14 == 1) { coin14lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c14 = 0; intlevel1score--; }
            if (coin15lvl2.Bottom <= player1.Bottom && coin15lvl2.Top > player1.Top && coin15lvl2.Left > player1.Left && coin15lvl2.Right < player1.Right && c15 == 1) { coin15lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c15 = 0; intlevel1score--; }
            if (coin16lvl2.Bottom <= player1.Bottom && coin16lvl2.Top > player1.Top && coin16lvl2.Left > player1.Left && coin16lvl2.Right < player1.Right && c16 == 1) { coin16lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c16 = 0; intlevel1score--; }
            if (coin17lvl2.Bottom <= player1.Bottom && coin17lvl2.Top > player1.Top && coin17lvl2.Left > player1.Left && coin17lvl2.Right < player1.Right && c17 == 1) { coin17lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c17 = 0; intlevel1score--; }
            if (coin18lvl2.Bottom <= player1.Bottom && coin18lvl2.Top > player1.Top && coin18lvl2.Left > player1.Left && coin18lvl2.Right < player1.Right && c18 == 1) { coin18lvl2.Visible = false; ingamesoundplayer[0].controls.play(); c18 = 0; intlevel1score--; }
            if (jump == true)
            {
                player1.Top -= force;
                force -= 1;
            }

            if (player1.Top + player1.Height >= gameplaylevel2.Height)
            {
                player1.Top = gameplaylevel2.Height - player.Height;
                jump = false;

            }
            else
            {
                player1.Top += 5;
            }
        }

        private void specialtimer2_Tick(object sender, EventArgs e)
        {
            if (player1.Left < 0) { left = false; jump = false; }
            if (player1.Right > gameplaylevel2.Right) { right = false; jump = false; }

            if (right == true) { player1.Left += 5; }
            if (left == true) { player1.Left -= 5; }
        }

        private void level3exit_Click(object sender, EventArgs e)
        {
            specialtimer3.Enabled = false;
            level3timer.Enabled = false;
            gameplaylevel3.Visible = false;
            bat1timer.Enabled = false;
            bat2timer.Enabled = false;
            activatebuttons();
        }

        private void specialtimer3_Tick(object sender, EventArgs e)
        {
            //if (player2.Left < 0) { left = false; jump = false; }
            //if (player2.Right > gameplaylevel3.Right) { right = false; jump = false; }

            if (right == true) { player2.Left += 5; }
            if (left == true) { player2.Left -= 5; }
        }

        private void bat1timer_Tick(object sender, EventArgs e)
        {
            if (plant1lvl3.Right >= (gameplaylevel3.Right + plant1lvl3.Width / 2)) { plant1lvl3.Location = new Point(33, 166); }
            plant1lvl3.Left += 5;
        }

        private void level3timer_Tick(object sender, EventArgs e)
        {
            g = 17; intlevel1score = 0;
            if (player2.Left <= plant1lvl3.Right && player2.Bottom >= plant1lvl3.Top && player2.Right > plant1lvl3.Right && player2.Top < plant1lvl3.Top || player2.Top < plant1lvl3.Top && player2.Left < plant1lvl3.Left && player2.Right > plant1lvl3.Left && player2.Bottom > plant1lvl3.Top || player2.Right > plant1lvl3.Right && player2.Left < plant1lvl3.Right && player2.Left > plant1lvl3.Left && player2.Top > plant1lvl3.Top && player2.Bottom < plant1lvl3.Bottom || player2.Top > plant1lvl3.Top && player2.Left < plant1lvl3.Left && player2.Right > plant1lvl3.Left && player2.Bottom > plant1lvl3.Bottom && player2.Right < plant1lvl3.Right && player2.Top < plant1lvl3.Bottom) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }
            if (player2.Left <= plant2lvl3.Right && player2.Bottom >= plant2lvl3.Top && player2.Right > plant2lvl3.Right && player2.Top < plant2lvl3.Top || player2.Top < plant2lvl3.Top && player2.Left < plant2lvl3.Left && player2.Right > plant2lvl3.Left && player2.Bottom > plant2lvl3.Top || player2.Right > plant2lvl3.Right && player2.Left < plant2lvl3.Right && player2.Left > plant2lvl3.Left && player2.Top > plant2lvl3.Top && player2.Bottom < plant2lvl3.Bottom || player2.Top > plant2lvl3.Top && player2.Left < plant2lvl3.Left && player2.Right > plant2lvl3.Left && player2.Bottom > plant2lvl3.Bottom && player2.Right < plant2lvl3.Right && player2.Top < plant2lvl3.Bottom) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }      
            if (player2.Top < plant1lvl3.Top && player2.Bottom >= plant1lvl3.Top && player2.Bottom < plant1lvl3.Bottom && player2.Left > plant1lvl3.Left && player2.Left < plant1lvl3.Right && player2.Right > plant1lvl3.Left && player2.Right < plant1lvl3.Right) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }
            if (player2.Top < plant2lvl3.Top && player2.Bottom >= plant2lvl3.Top && player2.Bottom < plant2lvl3.Bottom && player2.Left > plant2lvl3.Left && player2.Left < plant2lvl3.Right && player2.Right > plant2lvl3.Left && player2.Right < plant2lvl3.Right) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }          
            if (player2.Top > plant1lvl3.Top && player2.Top <= plant1lvl3.Bottom && player2.Bottom > plant1lvl3.Bottom && player2.Left > plant1lvl3.Left && player2.Left < plant1lvl3.Right && player2.Right > plant1lvl3.Left && player2.Right < plant1lvl3.Right) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }
            if (player2.Top > plant2lvl3.Top && player2.Top <= plant2lvl3.Bottom && player2.Bottom > plant2lvl3.Bottom && player2.Left > plant2lvl3.Left && player2.Left < plant2lvl3.Right && player2.Right > plant2lvl3.Left && player2.Right < plant2lvl3.Right) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }           
            if (player2.Top > plant1lvl3.Top && player2.Top < plant1lvl3.Bottom && player2.Left < plant1lvl3.Left && player2.Left < plant1lvl3.Right && player2.Bottom < plant1lvl3.Bottom && player2.Bottom > plant1lvl3.Top && player2.Right < plant1lvl3.Right && player2.Right >= plant1lvl3.Left) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }
            if (player2.Top > plant2lvl3.Top && player2.Top < plant2lvl3.Bottom && player2.Left < plant2lvl3.Left && player2.Left < plant2lvl3.Right && player2.Bottom < plant2lvl3.Bottom && player2.Bottom > plant2lvl3.Top && player2.Right < plant2lvl3.Right && player2.Right >= plant2lvl3.Left) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }          
            if (player2.Top < plant1lvl3.Bottom && player2.Top > plant1lvl3.Top && player2.Bottom > plant1lvl3.Top && player2.Bottom < plant1lvl3.Bottom && player2.Right > plant1lvl3.Right && player2.Right > plant1lvl3.Left && player2.Left > plant1lvl3.Left && player2.Left <= plant1lvl3.Right) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }
            if (player2.Top < plant2lvl3.Bottom && player2.Top > plant2lvl3.Top && player2.Bottom > plant2lvl3.Top && player2.Bottom < plant2lvl3.Bottom && player2.Right > plant2lvl3.Right && player2.Right > plant2lvl3.Left && player2.Left > plant2lvl3.Left && player2.Left <= plant2lvl3.Right) { level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); player2.Location = new Point(0, 530); MessageBox.Show("Jelly is dead !!"); specialtimer3.Enabled = false; }



            if (intlevel1score == 0) { specialtimer3.Enabled = false; level3timer.Enabled = false; gameplaylevel3.Visible = false; activatebuttons(); MessageBox.Show("Yeyyyy you have finished the game, Jelly is happy now that he returned home, next time you play you will start from level1 !!"); File.WriteAllText(@"levelfile.txt", "1"); intlevel1score = 18; c1 = 1; c2 = 1; c3 = 1; c4 = 1; c5 = 1; c6 = 1; c7 = 1; c8 = 1; c9 = 1; c10 = 1; c11 = 1; c12 = 1; c13 = 1; c14 = 1; c15 = 1; c16 = 1; c17 = 1; c18 = 1; }
            if (coin1lvl3.Bottom <= player2.Bottom && coin1lvl3.Top > player2.Top && coin1lvl3.Left > player2.Left && coin1lvl3.Right < player2.Right && c1 == 1) { coin1lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c1 = 0; intlevel1score--; }
            if (coin2lvl3.Bottom <= player2.Bottom && coin2lvl3.Top > player2.Top && coin2lvl3.Left > player2.Left && coin2lvl3.Right < player2.Right && c2 == 1) { coin2lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c2 = 0; intlevel1score--; }
            if (coin3lvl3.Bottom <= player2.Bottom && coin3lvl3.Top > player2.Top && coin3lvl3.Left > player2.Left && coin3lvl3.Right < player2.Right && c3 == 1) { coin3lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c3 = 0; intlevel1score--; }
            if (coin4lvl3.Bottom <= player2.Bottom && coin4lvl3.Top > player2.Top && coin4lvl3.Left > player2.Left && coin4lvl3.Right < player2.Right && c4 == 1) { coin4lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c4 = 0; intlevel1score--; }
            if (coin5lvl3.Bottom <= player2.Bottom && coin5lvl3.Top > player2.Top && coin5lvl3.Left > player2.Left && coin5lvl3.Right < player2.Right && c5 == 1) { coin5lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c5 = 0; intlevel1score--; }
            if (coin6lvl3.Bottom <= player2.Bottom && coin6lvl3.Top > player2.Top && coin6lvl3.Left > player2.Left && coin6lvl3.Right < player2.Right && c6 == 1) { coin6lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c6 = 0; intlevel1score--; }
            if (coin7lvl3.Bottom <= player2.Bottom && coin7lvl3.Top > player2.Top && coin7lvl3.Left > player2.Left && coin7lvl3.Right < player2.Right && c7 == 1) { coin7lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c7 = 0; intlevel1score--; }
            if (coin8lvl3.Bottom <= player2.Bottom && coin8lvl3.Top > player2.Top && coin8lvl3.Left > player2.Left && coin8lvl3.Right < player2.Right && c8 == 1) { coin8lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c8 = 0; intlevel1score--; }
            if (coin9lvl3.Bottom <= player2.Bottom && coin9lvl3.Top > player2.Top && coin9lvl3.Left > player2.Left && coin9lvl3.Right < player2.Right && c9 == 1) { coin9lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c9 = 0; intlevel1score--; }
            if (coin10lvl3.Bottom <= player2.Bottom && coin10lvl3.Top > player2.Top && coin10lvl3.Left > player2.Left && coin10lvl3.Right < player2.Right && c10 == 1) { coin10lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c10 = 0; intlevel1score--; }
            if (coin11lvl3.Bottom <= player2.Bottom && coin11lvl3.Top > player2.Top && coin11lvl3.Left > player2.Left && coin11lvl3.Right < player2.Right && c11 == 1) { coin11lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c11 = 0; intlevel1score--; }
            if (coin12lvl3.Bottom <= player2.Bottom && coin12lvl3.Top > player2.Top && coin12lvl3.Left > player2.Left && coin12lvl3.Right < player2.Right && c12 == 1) { coin12lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c12 = 0; intlevel1score--; }
            if (coin13lvl3.Bottom <= player2.Bottom && coin13lvl3.Top > player2.Top && coin13lvl3.Left > player2.Left && coin13lvl3.Right < player2.Right && c13 == 1) { coin13lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c13 = 0; intlevel1score--; }
            if (coin14lvl3.Bottom <= player2.Bottom && coin14lvl3.Top > player2.Top && coin14lvl3.Left > player2.Left && coin14lvl3.Right < player2.Right && c14 == 1) { coin14lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c14 = 0; intlevel1score--; }
            if (coin15lvl3.Bottom <= player2.Bottom && coin15lvl3.Top > player2.Top && coin15lvl3.Left > player2.Left && coin15lvl3.Right < player2.Right && c15 == 1) { coin15lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c15 = 0; intlevel1score--; }
            if (coin16lvl3.Bottom <= player2.Bottom && coin16lvl3.Top > player2.Top && coin16lvl3.Left > player2.Left && coin16lvl3.Right < player2.Right && c16 == 1) { coin16lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c16 = 0; intlevel1score--; }
            if (coin17lvl3.Bottom <= player2.Bottom && coin17lvl3.Top > player2.Top && coin17lvl3.Left > player2.Left && coin17lvl3.Right < player2.Right && c17 == 1) { coin17lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c17 = 0; intlevel1score--; }
            if (coin18lvl3.Bottom <= player2.Bottom && coin18lvl3.Top > player2.Top && coin18lvl3.Left > player2.Left && coin18lvl3.Right < player2.Right && c18 == 1) { coin18lvl3.Visible = false; ingamesoundplayer[0].controls.play(); c18 = 0; intlevel1score--; }
            if (jump == true)
            {
                player2.Top -= force;
                force -= 1;
            }

            if (player2.Top + player2.Height >= gameplaylevel3.Height)
            {
                player2.Top = gameplaylevel3.Height - player2.Height;
                jump = false;

            }
            else
            {
                player2.Top += 5;
            }
        }

        private void bat2timer_Tick(object sender, EventArgs e)
        {
            if (plant2lvl3.Right >= (gameplaylevel3.Right + plant2lvl3.Width / 2)) { plant2lvl3.Location = new Point(83, 290); }
            plant2lvl3.Left += 5;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

    



    }
}
