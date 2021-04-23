/* Gurvir Uppal
 * ICS3U
 * Mr. T
 * April 22 2021
 */





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Threading; //allows the use of Thread.Sleep() 
using System.Media; //allows the use of SoundPlayer
namespace playGameProject
{
    public partial class back1State : Form
    {
        public back1State()
        {
           InitializeComponent();
            timeText.Text = ""; // The countdown text starts as blank
        }



        private void startText_Click(object sender, EventArgs e)
        {
            SoundPlayer bleepPlayer = new SoundPlayer(Properties.Resources.Bleep_SoundBible_com_1927126940);
            SoundPlayer crashPlayer = new SoundPlayer(Properties.Resources.Car_Screech_And_Crash_SoundBible_com_1414562045);

            startText.Hide(); // Hide the play game button

            timeText.Text = "Game Starting in: 3";
            bleepPlayer.Play();

            Refresh();            //redraw the screen to show updates then pause for 1 second //redraw the screen to show updates then pause for 1 second 
            Thread.Sleep(1000);

            timeText.Text = "Game Starting in: 2";
            bleepPlayer.Play();

            Refresh();            //redraw the screen to show updates then pause for 1 second 
            Thread.Sleep(1000);

            timeText.Text = "Game Starting in: 1";
            bleepPlayer.Play();

            Refresh();           //redraw the screen to show updates then pause for 1 second 
            Thread.Sleep(1000);

            timeText.Text = "           GO!!!";
            crashPlayer.Play();

            this.BackColor = Color.Green; //change the color of the background
           

        }

      
    }
}
