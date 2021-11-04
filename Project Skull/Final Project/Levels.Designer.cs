namespace Final_Project
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pixelKid = new System.Windows.Forms.PictureBox();
            this.door1Open = new System.Windows.Forms.Label();
            this.door2Open = new System.Windows.Forms.Label();
            this.door3Open = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelKid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Door1_0;
            this.pictureBox1.Location = new System.Drawing.Point(65, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.Door1_0;
            this.pictureBox2.Location = new System.Drawing.Point(240, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 185);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.Door1_0;
            this.pictureBox3.Location = new System.Drawing.Point(436, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pixelKid
            // 
            this.pixelKid.BackColor = System.Drawing.Color.Transparent;
            this.pixelKid.Image = global::Final_Project.Properties.Resources.ChampStand;
            this.pixelKid.Location = new System.Drawing.Point(341, 219);
            this.pixelKid.Name = "pixelKid";
            this.pixelKid.Size = new System.Drawing.Size(102, 147);
            this.pixelKid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pixelKid.TabIndex = 3;
            this.pixelKid.TabStop = false;
            // 
            // door1Open
            // 
            this.door1Open.BackColor = System.Drawing.Color.Transparent;
            this.door1Open.ForeColor = System.Drawing.Color.Transparent;
            this.door1Open.Location = new System.Drawing.Point(66, 60);
            this.door1Open.Name = "door1Open";
            this.door1Open.Size = new System.Drawing.Size(100, 85);
            this.door1Open.TabIndex = 4;
            // 
            // door2Open
            // 
            this.door2Open.BackColor = System.Drawing.Color.Transparent;
            this.door2Open.Location = new System.Drawing.Point(241, 60);
            this.door2Open.Name = "door2Open";
            this.door2Open.Size = new System.Drawing.Size(100, 85);
            this.door2Open.TabIndex = 5;
            // 
            // door3Open
            // 
            this.door3Open.BackColor = System.Drawing.Color.Transparent;
            this.door3Open.Location = new System.Drawing.Point(437, 60);
            this.door3Open.Name = "door3Open";
            this.door3Open.Size = new System.Drawing.Size(100, 85);
            this.door3Open.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Final_Project.Properties.Resources.RoomToPlay4;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.door3Open);
            this.Controls.Add(this.door2Open);
            this.Controls.Add(this.door1Open);
            this.Controls.Add(this.pixelKid);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixelKid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pixelKid;
        private System.Windows.Forms.Label door1Open;
        private System.Windows.Forms.Label door2Open;
        private System.Windows.Forms.Label door3Open;
        private System.Windows.Forms.Timer timer1;
    }
}