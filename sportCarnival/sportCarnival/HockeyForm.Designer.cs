namespace sportCarnival
{
    partial class HockeyForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.timenotice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.NPC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.edge3 = new System.Windows.Forms.PictureBox();
            this.edge4 = new System.Windows.Forms.PictureBox();
            this.edge6 = new System.Windows.Forms.PictureBox();
            this.edge5 = new System.Windows.Forms.PictureBox();
            this.edge2 = new System.Windows.Forms.PictureBox();
            this.edge1 = new System.Windows.Forms.PictureBox();
            this.gamescene = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamescene)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(595, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "player\'s point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(700, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(724, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "NPC\'s  point";
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Font = new System.Drawing.Font("新細明體", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(599, 190);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(241, 57);
            this.result.TabIndex = 6;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timenotice
            // 
            this.timenotice.AutoSize = true;
            this.timenotice.Font = new System.Drawing.Font("新細明體", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timenotice.Location = new System.Drawing.Point(689, 317);
            this.timenotice.Name = "timenotice";
            this.timenotice.Size = new System.Drawing.Size(79, 43);
            this.timenotice.TabIndex = 7;
            this.timenotice.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(656, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "剩餘時間";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player.ForeColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(248, 561);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(90, 40);
            this.player.TabIndex = 18;
            this.player.Text = "player";
            this.player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NPC
            // 
            this.NPC.BackColor = System.Drawing.Color.Black;
            this.NPC.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NPC.ForeColor = System.Drawing.Color.White;
            this.NPC.Location = new System.Drawing.Point(248, 63);
            this.NPC.Name = "NPC";
            this.NPC.Size = new System.Drawing.Size(90, 40);
            this.NPC.TabIndex = 19;
            this.NPC.Text = "NPC";
            this.NPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(595, 377);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(142, 54);
            this.start.TabIndex = 20;
            this.start.Text = "start game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pause.Location = new System.Drawing.Point(595, 456);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(142, 59);
            this.pause.TabIndex = 21;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(595, 537);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 50);
            this.exit.TabIndex = 22;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score1.Location = new System.Drawing.Point(625, 88);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(58, 64);
            this.score1.TabIndex = 23;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score2.Location = new System.Drawing.Point(756, 88);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(58, 64);
            this.score2.TabIndex = 24;
            this.score2.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sportCarnival.Properties.Resources.mole;
            this.pictureBox1.Location = new System.Drawing.Point(754, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::sportCarnival.Properties.Resources.ball1;
            this.ball.Location = new System.Drawing.Point(277, 286);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(40, 40);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 15;
            this.ball.TabStop = false;
            // 
            // edge3
            // 
            this.edge3.BackColor = System.Drawing.Color.Red;
            this.edge3.Location = new System.Drawing.Point(0, 10);
            this.edge3.Name = "edge3";
            this.edge3.Size = new System.Drawing.Size(10, 625);
            this.edge3.TabIndex = 14;
            this.edge3.TabStop = false;
            // 
            // edge4
            // 
            this.edge4.BackColor = System.Drawing.Color.Red;
            this.edge4.Location = new System.Drawing.Point(567, 10);
            this.edge4.Name = "edge4";
            this.edge4.Size = new System.Drawing.Size(10, 625);
            this.edge4.TabIndex = 13;
            this.edge4.TabStop = false;
            // 
            // edge6
            // 
            this.edge6.BackColor = System.Drawing.Color.Red;
            this.edge6.Location = new System.Drawing.Point(383, 635);
            this.edge6.Name = "edge6";
            this.edge6.Size = new System.Drawing.Size(194, 10);
            this.edge6.TabIndex = 12;
            this.edge6.TabStop = false;
            // 
            // edge5
            // 
            this.edge5.BackColor = System.Drawing.Color.Red;
            this.edge5.Location = new System.Drawing.Point(0, 635);
            this.edge5.Name = "edge5";
            this.edge5.Size = new System.Drawing.Size(194, 10);
            this.edge5.TabIndex = 11;
            this.edge5.TabStop = false;
            // 
            // edge2
            // 
            this.edge2.BackColor = System.Drawing.Color.Red;
            this.edge2.Location = new System.Drawing.Point(382, 0);
            this.edge2.Name = "edge2";
            this.edge2.Size = new System.Drawing.Size(195, 10);
            this.edge2.TabIndex = 10;
            this.edge2.TabStop = false;
            // 
            // edge1
            // 
            this.edge1.BackColor = System.Drawing.Color.Red;
            this.edge1.Location = new System.Drawing.Point(0, 0);
            this.edge1.Name = "edge1";
            this.edge1.Size = new System.Drawing.Size(194, 10);
            this.edge1.TabIndex = 9;
            this.edge1.TabStop = false;
            // 
            // gamescene
            // 
            this.gamescene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gamescene.Image = global::sportCarnival.Properties.Resources.line1;
            this.gamescene.Location = new System.Drawing.Point(0, 0);
            this.gamescene.Name = "gamescene";
            this.gamescene.Size = new System.Drawing.Size(577, 645);
            this.gamescene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamescene.TabIndex = 0;
            this.gamescene.TabStop = false;
            // 
            // HockeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.NPC);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.edge3);
            this.Controls.Add(this.edge4);
            this.Controls.Add(this.edge6);
            this.Controls.Add(this.edge5);
            this.Controls.Add(this.edge2);
            this.Controls.Add(this.edge1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timenotice);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gamescene);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HockeyForm";
            this.Text = "HockeyForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HockeyForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HockeyForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamescene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label timenotice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox edge1;
        private System.Windows.Forms.PictureBox edge2;
        private System.Windows.Forms.PictureBox edge5;
        private System.Windows.Forms.PictureBox edge6;
        private System.Windows.Forms.PictureBox edge4;
        private System.Windows.Forms.PictureBox edge3;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label NPC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox gamescene;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}