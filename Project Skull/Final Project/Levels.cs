using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Final_Project
{
    public partial class Form3 : Form
    {
        #region Private
        private bool _moveRight, _moveLeft, _moveUp, _moveDown;
        private bool _door1isOpen, _door2isOpen, _door3isOpen;
        private bool _charLeftAnim, _charRightAnim;
        #endregion
        #region Public
        public bool green1 = false;
        public bool win = false;
        #endregion
        #region ctor
        public Form3()
        {
            InitializeComponent();
            pixelKid.BringToFront();
            pictureBox1.BringToFront();
            pictureBox2.BringToFront();
            pictureBox3.BringToFront();
        }
        #endregion
        #region Methods
        public void Collision()
        {
            pixelKid.BringToFront();
            if (pixelKid.Bounds.IntersectsWith(door1Open.Bounds))
            {
                pictureBox1.Image = Properties.Resources.Door1;
                _door1isOpen = true;
            }
            else
            {
                pictureBox1.BackColor = Color.Black;
            }

            pixelKid.BringToFront();
            if (pixelKid.Bounds.IntersectsWith(door2Open.Bounds))
            {
                pictureBox2.BackColor = Color.Yellow;
            }
            else
            {
                pictureBox2.BackColor = Color.Black;
            }

            pixelKid.BringToFront();
            if (pixelKid.Bounds.IntersectsWith(door3Open.Bounds))
            {
                pictureBox3.BackColor = Color.Yellow;
            }
            else
            {
                pictureBox3.BackColor = Color.Black;
            }

        }

        #region PlayerMovement
        #region KeyDown
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                while (pixelKid.Bounds.IntersectsWith(pictureBox1.Bounds) && _door1isOpen)
                {
                    Game1 playNow = new Game1();
                    this.Hide();
                    playNow.ShowDialog();
                    break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                while (pixelKid.Bounds.IntersectsWith(pictureBox2.Bounds) && _door2isOpen)
                {
                    Game2 playNow = new Game2();
                    this.Hide();
                    playNow.ShowDialog();
                    break;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                while (pixelKid.Bounds.IntersectsWith(pictureBox3.Bounds) && _door3isOpen)
                {
                    Form1 playNow = new Form1();
                    this.Hide();
                    playNow.ShowDialog();
                    break;
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
                Menu nwf = new Menu();
                nwf.ShowDialog();
            }

            Collision();


            if (pixelKid.Location.X <= 0)
            {
                _moveLeft = false;
            }


            if (e.KeyCode == Keys.Right && pixelKid.Location.X < 512)
            {
                _charRightAnim = true;
                _moveRight = true;
            }
            else
            {
                _charRightAnim = false;
                _moveRight = false;
            }
            if (e.KeyCode == Keys.Left && pixelKid.Location.X > 0)
            {
                _charLeftAnim = true;
                _moveLeft = true;
            }
            else
            {
                _charLeftAnim = false;
                _moveLeft = false;
            }
            if (e.KeyCode == Keys.Up && pixelKid.Location.Y > 95)
            {
                _charRightAnim = true;
                _moveUp = true;
            }
            else
            {
                _moveUp = false;
            }
            if (e.KeyCode == Keys.Down && pixelKid.Location.Y < 252)
            {
                _charLeftAnim = true;
                _moveDown = true;
            }
            else
            {
                _moveDown = false;
            }


            if (_moveLeft)
            {
                pixelKid.Left -= 5;
            }
            if (_moveRight)
            {
                pixelKid.Left += 5;
            }

            if (_moveUp)
            {
                pixelKid.Top -= 5;
            }
            if (_moveDown)
            {
                pixelKid.Top += 5;
            }
        }
        #endregion
        #region KeyUp

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {

                _moveLeft = false;
            }
            if (e.KeyCode == Keys.Up)
            {

                _moveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {

                _moveDown = false;
            }
        }
        #endregion
        #endregion

        private void Form3_Load(object sender, EventArgs e)
        {
            if (win)
            {
                _door3isOpen = true;
            }

            if (green1)
            {
                _door2isOpen = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (_charLeftAnim)
            {
                _charRightAnim = false;
                pixelKid.Image = Properties.Resources.CharacterLeft2;
            }
            if (_charRightAnim)
            {
                _charLeftAnim = false;
                pixelKid.Image = Properties.Resources.CharacterRight2;
            }
        }
        #endregion
    }
}
