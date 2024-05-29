using DuckHunt.Properties;
using System.Media;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace DuckHunt
{
    public partial class Form1 : Form
    {
        private SoundPlayer startSound;
        private int missed = 0;
        private bool key = false;

        public Form1()
        {
            InitializeComponent();
            InitializeStartScreen();
            //this.DoubleBuffered = true;
            //Cursor cur = new Cursor(Properties.Resources.cursor_img.Handle);
            //this.Cursor = cur;
        }

        private void Game_Result()
        {
            if (key == true)
            {
                this.BackgroundImage = Properties.Resources.background_lose;
                startSound = new SoundPlayer(Properties.Resources.lose);
                startSound.PlayLooping();
                timer1.Stop();
            }
        }

        private void InitializeStartScreen()
        {
            startSound = new SoundPlayer(Properties.Resources.start);
            startSound.PlayLooping();

            this.Controls.Add(startPictureBox);
            startPictureBox.BringToFront();

            lbl_kill.Text = "0";

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                StartGame();
            }
        }

        private void StartGame()
        {
            startPictureBox.Visible = false;
            startSound.Stop();
            this.KeyDown -= new KeyEventHandler(Form1_KeyDown);
            timer1.Start();
        }

        private void Hit()
        {
            startSound = new SoundPlayer(Properties.Resources.duck_drop); 
            startSound.Play();
        }

        private void Shoot()
        {
            startSound = new SoundPlayer(Properties.Resources.gunshot); 
            startSound.Play();
        }

        private void Birds()
        {
            int speed1 = 5;
            int speed2 = 8;
            int speed3 = 13;

            duck1.Left += speed1;
            duck2.Left += speed2;
            duck3.Left += speed3;

            if (duck1.Left > this.ClientSize.Width)
            {
                duck1.Left = -duck1.Width;
                duck1.Image = Properties.Resources._1;
            }
            if (duck2.Left > this.ClientSize.Width)
            {
                duck2.Left = -duck2.Width;
                duck2.Image = Properties.Resources._2;
            }
            if (duck3.Left > this.ClientSize.Width)
            {
                duck3.Left = -duck3.Width;
                duck3.Image = Properties.Resources._3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Birds();
            Game_Result();
        }

        private void duck1_Click(object sender, EventArgs e)
        {
            if (key) return; 

            lbl_kill.Text = (int.Parse(lbl_kill.Text) + 500).ToString();
            duck1.Image = Properties.Resources.end1;
            Hit();
        }

        private void duck2_Click(object sender, EventArgs e)
        {
            if (key) return; 

            lbl_kill.Text = (int.Parse(lbl_kill.Text) + 500).ToString();
            duck2.Image = Properties.Resources.end2;
            Hit();
        }

        private void duck3_Click(object sender, EventArgs e)
        {
            if (key) return; 

            lbl_kill.Text = (int.Parse(lbl_kill.Text) + 500).ToString();
            duck3.Image = Properties.Resources.end3;
            Hit();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Shoot();
            missed++;

            if (missed == 1)
            {
                ammo3.Visible = false;
            }
            else if (missed == 2)
            {
                ammo2.Visible = false;
            }
            else if (missed == 3)
            {
                ammo1.Visible = false;
                key = true;
            }
        }
    }
}
