using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Menu : Form
    {
        #region Private
        private SoundPlayer player = new SoundPlayer();

        private bool _playerstart = true;
        #endregion

        #region ctor
        public Menu()
        {
            player.SoundLocation = "Automation.wav";
            #region BackgroundPicture
            InitializeComponent();
            var pos = this.PointToScreen(pictureBox2.Location);
            pos = pictureBox1.PointToClient(pos);
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location = pos;
            pictureBox2.BackColor = Color.Transparent;

            var pos1 = this.PointToScreen(pictureBox3.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            pictureBox3.Parent = pictureBox1;
            pictureBox3.Location = pos1;
            pictureBox3.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label1.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            label1.Parent = pictureBox1;
            label1.Location = pos2;
            label1.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label2.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            label2.Parent = pictureBox1;
            label2.Location = pos3;
            label2.BackColor = Color.Transparent;
#endregion
        }
        #endregion

        #region Methods
        private void Form1_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           if (_playerstart)
            {
                player.Stop();
                _playerstart = false;
                label2.ForeColor = Color.Maroon;
            }
           else
            {
                player.PlayLooping();
                _playerstart = true;
                label2.ForeColor = Color.LimeGreen;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 playNow = new Form3();
            Form2 nwf = new Form2();
            player.Stop();
            this.Hide();
            nwf.ShowDialog();
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
                label1.ForeColor = Color.LimeGreen;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Maroon;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Game2 game = new Game2();
            this.Hide();
            game.ShowDialog();
        }
        #endregion
    }
}
