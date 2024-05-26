using DuckHunt.Properties;
using System.Media;

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
            Bitmap bmp = new Bitmap("C:/Users/User/Desktop/DuckHunt/Resources/duck1.png");
            Cursor crsr = new Cursor(bmp.GetHicon());
            this.Cursor = crsr;
        }

        private void Game_Result()
        {
            if (key==true)
            {
                game_over.Visible = true;
                startSound = new SoundPlayer("C:/Users/User/Desktop/DuckHunt/Resources/lose.wav"); // Убедитесь, что музыка добавлена в ресурсы
                startSound.PlayLooping();
                timer1.Stop();
            }
        }

        private void InitializeStartScreen()
        {
            // Инициализация и запуск музыки
            startSound = new SoundPlayer("C:/Users/User/Desktop/DuckHunt/Resources/start.wav"); // Убедитесь, что музыка добавлена в ресурсы
            startSound.PlayLooping();

            this.Controls.Add(startPictureBox);
            startPictureBox.BringToFront();

            game_over.Visible = false;
            lbl_kill.Text = "0"; // Начальное значение для счета убийств

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
            startSound = new SoundPlayer("C:/Users/User/Desktop/DuckHunt/Resources/duck_drop.wav"); // Убедитесь, что музыка добавлена в ресурсы
            startSound.Play();
        }
        

        private void Shoot()
        {
            startSound = new SoundPlayer("C:/Users/User/Desktop/DuckHunt/Resources/gunshot.wav"); // Убедитесь, что музыка добавлена в ресурсы
            startSound.Play();
        }

        private void Birds()
        {
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
            duck1.Left += 5;
            duck2.Left += 8;
            duck3.Left += 13;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Остановить таймер при загрузке формы
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Birds();
            Game_Result();
        }

        private void duck1_Click(object sender, EventArgs e)
        {
            lbl_kill.Text = (int.Parse(lbl_kill.Text) + 500).ToString();
            duck1.Image = Properties.Resources.end1;
            Shoot();
            Hit();

        }

        private void duck2_Click(object sender, EventArgs e)
        {
            lbl_kill.Text = (int.Parse(lbl_kill.Text) + 500).ToString();
            duck2.Image = Properties.Resources.end2;
            Shoot();
            Hit();
        }

        private void duck3_Click(object sender, EventArgs e)
        {
            lbl_kill.Text = (int.Parse(lbl_kill.Text) + 500).ToString();
            duck3.Image = Properties.Resources.end3;
            Shoot();
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
