using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Final_Project
{
    public partial class Game2 : Form
    {
        #region Private
        private SoundPlayer song = new SoundPlayer(Properties.Resources.Shadowtask);
        private int _skullSpeed, _timeCounter, _points;
        private bool _moveRight, _moveLeft, _enterTheDragon;
        #endregion

        #region ctor
        public Game2()
        {
            InitializeComponent();
            song.Play();
        }
        #endregion

        #region PlayerandBullet
        #region PlayerMovement
        private void Game2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = true;
            }
        }

        private void Game2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                _moveRight = false;
            }
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {

            }
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region PlayerControl
            _timeCounter += 10;
            _skullSpeed += 10;

            if (_moveLeft && player.Left > 0)
                player.Left -= 5;
            if (_moveRight && player.Left < 537)
                player.Left += 5;

            foreach (Control x in this.Controls)
            {
                if (x.Tag != null && x is PictureBox && x.Tag.ToString() == "skull")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        Endgame(false);
                    }

                 ((PictureBox)x).Left += 1;
                    if (_skullSpeed % 1000 == 0)
                    {
                        ((PictureBox)x).Top += ((PictureBox)x).Height;
                    }
                    if (((PictureBox)x).Left > 600)
                    {

                        ((PictureBox)x).Left = -20;
                    }
                }
                if (_points >= 12)
                {
                    Endgame(true);
                }
            }
            #endregion
            #region BulletControl
            #region 1foreach
            foreach (Control v in this.Controls)
            {
                foreach (Control b in this.Controls)
                {
                    if (v.Tag != null && v is PictureBox && v.Tag.ToString() == "bullet")
                    {
                        if (b.Tag != null && b is PictureBox && b.Tag.ToString() == "skull")
                        {
                            if (v.Bounds.IntersectsWith(b.Bounds))
                            {
                                _points++;
                                this.Controls.Remove(v);
                                this.Controls.Remove(b);
                            }
                        }
                    }
                }
            }
            #endregion
            #region 2foreach
            foreach (Control v in this.Controls)
            {
                foreach (Control b in this.Controls)
                {
                    if (v.Tag != null && v is PictureBox && v.Tag.ToString() == "bullet2")
                    {
                        if (b.Tag != null && b is PictureBox && b.Tag.ToString() == "skull")
                        {
                            if (v.Bounds.IntersectsWith(b.Bounds))
                            {
                                _points++;
                                this.Controls.Remove(v);
                                this.Controls.Remove(b);
                            }
                        }

                    }
                }

            }
            #endregion
            #region 3foreach
            foreach (Control v in this.Controls)
            {
                foreach (Control b in this.Controls)
                {
                    if (v.Tag != null && v is PictureBox && v.Tag.ToString() == "bullet3")
                    {
                        if (b.Tag != null && b is PictureBox && b.Tag.ToString() == "skull")
                        {
                            if (v.Bounds.IntersectsWith(b.Bounds))

                            {
                                _points++;
                                this.Controls.Remove(v);
                                this.Controls.Remove(b);
                            }
                        }

                    }
                }

            }
            #endregion
            #region 4foreach
            foreach (Control v in this.Controls)
            {
                foreach (Control b in this.Controls)
                {

                    if (v.Tag != null && v is PictureBox && v.Tag.ToString() == "bullet4")
                    {
                        if (b.Tag != null && b is PictureBox && b.Tag.ToString() == "skull")
                        {


                            if (v.Bounds.IntersectsWith(b.Bounds))

                            {
                                _points++;
                                this.Controls.Remove(v);
                                this.Controls.Remove(b);
                            }
                        }

                    }
                }

            }
            #endregion
            #region 4foreach
            foreach (Control v in this.Controls)
            {
                foreach (Control b in this.Controls)
                {

                    if (v.Tag != null && v is PictureBox && v.Tag.ToString() == "bullet")
                    {
                        if (b.Tag != null && b is PictureBox && b.Tag.ToString() == "skull")
                        {
                            if (v.Bounds.IntersectsWith(b.Bounds))
                            {
                                _points++;
                                this.Controls.Remove(v);
                                this.Controls.Remove(b);
                            }
                        }

                    }
                }
            }
            #endregion
            #endregion
        }
        #region BulletSpeedControl
        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control y in this.Controls)
            {
                if (y.Tag != null && y is PictureBox && y.Tag.ToString() == "bullet")
                {
                    y.Top -= 5;
                    if (((PictureBox)y).Top < this.Height - 450)
                    {
                        this.Controls.Remove(y);
                    }
                }
            }

            foreach (Control j in this.Controls)
            {
                if (j.Tag != null && j is PictureBox && j.Tag.ToString() == "bullet2")
                {
                    j.Top -= 5;
                    j.Left -= 5;

                    if (((PictureBox)j).Top < this.Height - 450 || ((PictureBox)j).Left < 1)
                    {
                        this.Controls.Remove(j);
                    }
                }
            }

            foreach (Control l in this.Controls)
            {
                if (l.Tag != null && l is PictureBox && l.Tag.ToString() == "bullet3")
                {
                    l.Top -= 5;
                    l.Left += 5;

                    if (((PictureBox)l).Top < this.Height - 450 || ((PictureBox)l).Right > 580)
                    {
                        this.Controls.Remove(l);
                    }
                }
            }

            foreach (Control p in this.Controls)
            {
                if (p.Tag != null && p is PictureBox && p.Tag.ToString() == "bullet4")
                {
                    p.Left -= 5;

                    if (((PictureBox)p).Left < 1)
                    {
                        this.Controls.Remove(p);
                    }
                }
            }

            foreach (Control q in this.Controls)
            {
                if (q.Tag != null && q is PictureBox && q.Tag.ToString() == "bullet5")
                {
                    q.Left += 5;

                    if (((PictureBox)q).Right > 580)
                    {
                        this.Controls.Remove(q);
                    }
                }
            }

        }
        #endregion
        #region BulletRain
        Random rnd = new Random();
        private void bulletRain()
        {
            bullet.Image = Properties.Resources.bullet1;

            bullet.Size = new Size(18, 18);
            bullet.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + player.Width / 2 - bullet.Width / 2;
            bullet.Top = player.Top;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        private void bulletRain2()
        {
            int i = rnd.Next(0);

            PictureBox bullet2 = new PictureBox();
            switch (i)
            {
                case 0:
                    bullet2.Image = Properties.Resources.bullet1;
                    break;
            }
            bullet2.Size = new Size(18, 18);
            bullet2.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet2.Tag = "bullet2";
            bullet2.Left = player.Left;
            bullet2.Top = player.Top;
            this.Controls.Add(bullet2);
            bullet2.BringToFront();
        }

        private void bulletRain3()
        {
            int i = rnd.Next(0);

            PictureBox bullet3 = new PictureBox();
            switch (i)
            {
                case 0:
                    bullet3.Image = Properties.Resources.bullet1;
                    break;
            }
            bullet3.Size = new Size(18, 18);
            bullet3.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet3.Tag = "bullet3";
            bullet3.Left = player.Right - bullet3.Width;
            bullet3.Top = player.Top;
            this.Controls.Add(bullet3);
            bullet3.BringToFront();
        }

        private void bulletRain4()
        {
            int i = rnd.Next(0);

            PictureBox bullet4 = new PictureBox();
            switch (i)
            {
                case 0:
                    bullet4.Image = Properties.Resources.bullet1;
                    break;
            }
            bullet4.Size = new Size(18, 18);
            bullet4.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet4.Tag = "bullet4";
            bullet4.Left = player.Left - 20;
            bullet4.Top = player.Top + bullet4.Height / 2;
            this.Controls.Add(bullet4);
            bullet4.BringToFront();
        }

        private void bulletRain5()
        {
            int i = rnd.Next(0);

            PictureBox bullet5 = new PictureBox();
            switch (i)
            {
                case 0:
                    bullet5.Image = Properties.Resources.bullet1;
                    break;
            }
            bullet5.Size = new Size(18, 18);
            bullet5.SizeMode = PictureBoxSizeMode.CenterImage;
            bullet5.Tag = "bullet5";
            bullet5.Left = player.Right;
            bullet5.Top = player.Top + bullet5.Height / 2;
            this.Controls.Add(bullet5);
            bullet5.BringToFront();
        }
        #endregion
        #endregion

        #region Methods
        private void Game2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void Endgame(bool result)
        {

            _points = 0;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            song.Stop();
            this.Hide();
            Form3 frm = new Form3();
            if (result)
            {
                frm.win = true;
            }

            frm.ShowDialog();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (_timeCounter >= 5000)
            {
                _enterTheDragon = true;
            }

            bulletRain();

            if (_enterTheDragon)
            {
                bulletRain2();
                bulletRain3();
                bulletRain4();
                bulletRain5();
            }
        }
        #endregion
    }
}
