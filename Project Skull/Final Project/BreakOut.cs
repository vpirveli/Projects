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
    public partial class Game1 : Form
    {

        SoundPlayer crackPunch = new SoundPlayer(Properties.Resources.crackPunch);
        SoundPlayer fistPunch = new SoundPlayer(Properties.Resources.fistPunch);
        SoundPlayer Ouch = new SoundPlayer(Properties.Resources.Ouch);
        SoundPlayer Slap = new SoundPlayer(Properties.Resources.Slap);

        Image[,] Blocks;

        int blockcolmn;
        int blockrow;
        int blockam = 0;
        int skullspeed = 6;
        static int hpcounter = 3;
        public Game1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        #region nw
        //bool right = false;
        //bool left = false;
        #endregion


        Random rnd = new Random();

        private int CreateBlocks(int row, int colmn)
        {
            Blocks = new Image[row, colmn];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colmn; j++)
                {
                    int r = rnd.Next(0, 9);
                    Blocks[i, j] = imageList1.Images[r];
                }
            }
            return row * colmn;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Game1_Load(object sender, EventArgs e)
        {
            blockrow = 4;
            blockcolmn = imageList1.Images.Count;
            blockam = CreateBlocks(blockrow, blockcolmn);
        }

        private void Game1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer1.Enabled = false;
                Hide();
                Form3 nwf = new Form3();
                nwf.ShowDialog();
            }
        }

        private void Game1_MouseMove(object sender, MouseEventArgs e)
        {
            player1.Left = e.X;
            if (player1.Left < 0)
            {
                player1.Left = 0;
            }

            if (player1.Left > 464)
            {
                player1.Left = 464;
            }
        }

        int direction_x = 1;
        int direction_y = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Point skullnoshake = skullhead.Location;
            skullnoshake.X += skullspeed * direction_x;
            skullnoshake.Y += skullspeed * direction_y;
            skullhead.Location = skullnoshake;

            if (skullnoshake.X < 0 || skullnoshake.X > ClientRectangle.Width - skullhead.Width)
            {
                direction_x = -direction_x;
                skullhead.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                int randomNoice = rnd.Next(0, 3);

                switch (randomNoice)
                {
                    case 0:
                        Slap.Play();
                        break;
                    case 1:
                        Ouch.Play();
                        break;
                    case 2:
                        crackPunch.Play();
                        break;
                    case 3:
                        fistPunch.Play();
                        break;
                }
            }

            if (skullnoshake.Y < 0)
            {
                direction_y = -direction_y;
                skullhead.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                int randomNoice = rnd.Next(0, 3);

                switch (randomNoice)
                {
                    case 0:
                        Slap.Play();
                        break;
                    case 1:
                        Ouch.Play();
                        break;
                    case 2:
                        crackPunch.Play();
                        break;
                    case 3:
                        fistPunch.Play();
                        break;

                }
            }

            if (skullnoshake.Y > ClientRectangle.Height)
            {
                hpcounter--;
                if (hpcounter == 2)
                {
                    int randomNoice = rnd.Next(0, 16);

                    switch (randomNoice)
                    {
                        case 0:
                            Slap.Play();
                            break;
                        case 1:
                            Ouch.Play();
                            break;
                        case 2:
                            crackPunch.Play();
                            break;
                        case 3:
                            fistPunch.Play();
                            break;

                    }
                    skullhead.Left = 240;
                    skullhead.Top = 160;
                    pictureBox3.Hide();
                }
                if (hpcounter == 1)
                {
                    int randomNoice = rnd.Next(0, 3);

                    switch (randomNoice)
                    {
                        case 0:
                            Slap.Play();
                            break;
                        case 1:
                            Ouch.Play();
                            break;
                        case 2:
                            crackPunch.Play();
                            break;
                        case 3:
                            fistPunch.Play();
                            break;

                    }
                    skullhead.Left = 240;
                    skullhead.Top = 160;
                    pictureBox2.Hide();

                }
                if (hpcounter == 0)
                {
                    int randomNoice = rnd.Next(0, 3);

                    switch (randomNoice)
                    {
                        case 0:
                            Slap.Play();
                            break;
                        case 1:
                            Ouch.Play();
                            break;
                        case 2:
                            crackPunch.Play();
                            break;
                        case 3:
                            fistPunch.Play();
                            break;

                    }
                    pictureBox1.Hide();
                    timer1.Enabled = false;
                    hpcounter = 3;
                    Hide();
                    Form3 nwf = new Form3();
                    nwf.ShowDialog();
                }


                //Lose Skull
            }


            if (skullhead.Bounds.IntersectsWith(player1.Bounds))
            {
                int randomNoice = rnd.Next(0, 9);

                switch (randomNoice)
                {
                    case 0:
                        Slap.Play();
                        break;
                    case 1:
                        Ouch.Play();
                        break;
                    case 2:
                        crackPunch.Play();
                        break;
                    case 3:
                        fistPunch.Play();
                        break;

                }
                direction_y = -direction_y;
                skullhead.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            }

            Point[] skullpts = new Point[]
            {
            new Point (skullnoshake.X, skullnoshake.Y),
            new Point(skullnoshake.X+skullhead.Width, skullnoshake.Y),
            new Point(skullnoshake.X, skullnoshake.Y+skullhead.Height),
            new Point(skullnoshake.X+skullhead.Width, skullnoshake.Y+skullhead.Height),

        };
            int hitthepebble = 0;
            foreach (Point skullpnt in skullpts)
            {
                int imgWidth = imageList1.ImageSize.Width;
                int imgHeight = imageList1.ImageSize.Height;
                int pabblepos = 45;
                int pabbleposy = 35;
                int row = skullpnt.Y - pabbleposy;
                int colmn = skullpnt.X - pabblepos;

                colmn /= imgWidth;
                row /= imgHeight;

                if (colmn >= 0 && colmn < blockcolmn && row >= 0 && row < blockrow)
                {
                    if (Blocks[row, colmn] != null)
                    {
                        Blocks[row, colmn] = null;
                        Rectangle rc = new Rectangle(pabblepos + colmn * imgWidth, pabbleposy + row * imgHeight, imgWidth, imgHeight);
                        Invalidate(rc);
                        ++hitthepebble;

                    }
                }
            }
            if (hitthepebble > 0)
            {
                direction_y = -direction_y;
                blockam -= hitthepebble;

                if (blockam == 0)
                {
                    timer1.Enabled = false;
                    Hide();
                    Form3 nwf = new Form3();
                    nwf.green1 = true;
                    nwf.ShowDialog();
                }
            }
        }

        private void Game1_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            int pabblepos;
            int pabbleposy = 35;
            int imgWidth = imageList1.ImageSize.Width;
            int imgHeight = imageList1.ImageSize.Height;
            for (int i = 0; i < blockrow; i++)
            {
                pabblepos = (ClientRectangle.Width - imgWidth * blockcolmn) / 2;
                for (int j = 0; j < blockcolmn; j++)
                {
                    if (Blocks[i, j] != null)
                        G.DrawImage(Blocks[i, j], pabblepos, pabbleposy);
                    pabblepos += imgWidth;
                }
                pabbleposy += imgHeight;
            }
        }
    }
}
