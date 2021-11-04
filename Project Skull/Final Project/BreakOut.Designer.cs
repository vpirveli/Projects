namespace Final_Project
{
    partial class Game1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skullhead = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skullhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Pebble2.png");
            this.imageList1.Images.SetKeyName(1, "pebble3.png");
            this.imageList1.Images.SetKeyName(2, "pebble4.png");
            this.imageList1.Images.SetKeyName(3, "pebble6.png");
            this.imageList1.Images.SetKeyName(4, "pebble5.png");
            this.imageList1.Images.SetKeyName(5, "pebble8.png");
            this.imageList1.Images.SetKeyName(6, "pebble7.png");
            this.imageList1.Images.SetKeyName(7, "pebble.png");
            this.imageList1.Images.SetKeyName(8, "pebble9.png");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.SkullHP;
            this.pictureBox3.Location = new System.Drawing.Point(506, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.SkullHP;
            this.pictureBox2.Location = new System.Drawing.Point(530, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.SkullHP;
            this.pictureBox1.Location = new System.Drawing.Point(554, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // skullhead
            // 
            this.skullhead.BackColor = System.Drawing.Color.Transparent;
            this.skullhead.Image = global::Final_Project.Properties.Resources.SkullBall;
            this.skullhead.Location = new System.Drawing.Point(240, 160);
            this.skullhead.Name = "skullhead";
            this.skullhead.Size = new System.Drawing.Size(35, 35);
            this.skullhead.TabIndex = 19;
            this.skullhead.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.player1.Location = new System.Drawing.Point(337, 356);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(120, 21);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skullhead);
            this.Controls.Add(this.player1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Game1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skullhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox skullhead;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}