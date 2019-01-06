namespace sportCarnival
{
    partial class ShootForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShootForm));
            this.question = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bulletcount4 = new System.Windows.Forms.PictureBox();
            this.bulletcount3 = new System.Windows.Forms.PictureBox();
            this.bulletcount2 = new System.Windows.Forms.PictureBox();
            this.bulletcount1 = new System.Windows.Forms.PictureBox();
            this.bulletcount8 = new System.Windows.Forms.PictureBox();
            this.bulletcount7 = new System.Windows.Forms.PictureBox();
            this.bulletcount6 = new System.Windows.Forms.PictureBox();
            this.bulletcount5 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.questionbox = new System.Windows.Forms.PictureBox();
            this.gamescene = new System.Windows.Forms.PictureBox();
            this.scoreboard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamescene)).BeginInit();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(534, 179);
            this.question.Name = "question";
            this.question.ReadOnly = true;
            this.question.Size = new System.Drawing.Size(143, 22);
            this.question.TabIndex = 2;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.ImageList = this.imageList1;
            this.start.Location = new System.Drawing.Point(534, 431);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(143, 53);
            this.start.TabIndex = 4;
            this.start.Text = "Start game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sun.jpg");
            this.imageList1.Images.SetKeyName(1, "cat.jpg");
            this.imageList1.Images.SetKeyName(2, "dog.jpg");
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pause
            // 
            this.pause.Enabled = false;
            this.pause.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pause.Location = new System.Drawing.Point(534, 490);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(143, 47);
            this.pause.TabIndex = 7;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(534, 543);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(143, 45);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(557, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "剩餘子彈數";
            // 
            // bulletcount4
            // 
            this.bulletcount4.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount4.Location = new System.Drawing.Point(642, 359);
            this.bulletcount4.Name = "bulletcount4";
            this.bulletcount4.Size = new System.Drawing.Size(30, 30);
            this.bulletcount4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount4.TabIndex = 16;
            this.bulletcount4.TabStop = false;
            // 
            // bulletcount3
            // 
            this.bulletcount3.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount3.Location = new System.Drawing.Point(606, 359);
            this.bulletcount3.Name = "bulletcount3";
            this.bulletcount3.Size = new System.Drawing.Size(30, 30);
            this.bulletcount3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount3.TabIndex = 15;
            this.bulletcount3.TabStop = false;
            // 
            // bulletcount2
            // 
            this.bulletcount2.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount2.Location = new System.Drawing.Point(570, 359);
            this.bulletcount2.Name = "bulletcount2";
            this.bulletcount2.Size = new System.Drawing.Size(30, 30);
            this.bulletcount2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount2.TabIndex = 14;
            this.bulletcount2.TabStop = false;
            // 
            // bulletcount1
            // 
            this.bulletcount1.Image = ((System.Drawing.Image)(resources.GetObject("bulletcount1.Image")));
            this.bulletcount1.Location = new System.Drawing.Point(534, 359);
            this.bulletcount1.Name = "bulletcount1";
            this.bulletcount1.Size = new System.Drawing.Size(30, 30);
            this.bulletcount1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount1.TabIndex = 13;
            this.bulletcount1.TabStop = false;
            // 
            // bulletcount8
            // 
            this.bulletcount8.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount8.Location = new System.Drawing.Point(642, 395);
            this.bulletcount8.Name = "bulletcount8";
            this.bulletcount8.Size = new System.Drawing.Size(30, 30);
            this.bulletcount8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount8.TabIndex = 12;
            this.bulletcount8.TabStop = false;
            // 
            // bulletcount7
            // 
            this.bulletcount7.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount7.Location = new System.Drawing.Point(606, 395);
            this.bulletcount7.Name = "bulletcount7";
            this.bulletcount7.Size = new System.Drawing.Size(30, 30);
            this.bulletcount7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount7.TabIndex = 11;
            this.bulletcount7.TabStop = false;
            // 
            // bulletcount6
            // 
            this.bulletcount6.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount6.Location = new System.Drawing.Point(570, 395);
            this.bulletcount6.Name = "bulletcount6";
            this.bulletcount6.Size = new System.Drawing.Size(30, 30);
            this.bulletcount6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount6.TabIndex = 10;
            this.bulletcount6.TabStop = false;
            // 
            // bulletcount5
            // 
            this.bulletcount5.Image = global::sportCarnival.Properties.Resources.bulletcount;
            this.bulletcount5.Location = new System.Drawing.Point(534, 395);
            this.bulletcount5.Name = "bulletcount5";
            this.bulletcount5.Size = new System.Drawing.Size(30, 30);
            this.bulletcount5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bulletcount5.TabIndex = 9;
            this.bulletcount5.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::sportCarnival.Properties.Resources.player1;
            this.player.Location = new System.Drawing.Point(200, 504);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(113, 95);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // questionbox
            // 
            this.questionbox.Location = new System.Drawing.Point(534, 12);
            this.questionbox.Name = "questionbox";
            this.questionbox.Size = new System.Drawing.Size(143, 151);
            this.questionbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionbox.TabIndex = 1;
            this.questionbox.TabStop = false;
            // 
            // gamescene
            // 
            this.gamescene.Image = global::sportCarnival.Properties.Resources.back;
            this.gamescene.Location = new System.Drawing.Point(0, 0);
            this.gamescene.Name = "gamescene";
            this.gamescene.Size = new System.Drawing.Size(528, 608);
            this.gamescene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gamescene.TabIndex = 18;
            this.gamescene.TabStop = false;
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.scoreboard.Location = new System.Drawing.Point(534, 234);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(65, 22);
            this.scoreboard.TabIndex = 19;
            this.scoreboard.Text = "分數:";
            // 
            // ShootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 600);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulletcount4);
            this.Controls.Add(this.bulletcount3);
            this.Controls.Add(this.bulletcount2);
            this.Controls.Add(this.bulletcount1);
            this.Controls.Add(this.bulletcount8);
            this.Controls.Add(this.bulletcount7);
            this.Controls.Add(this.bulletcount6);
            this.Controls.Add(this.bulletcount5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.player);
            this.Controls.Add(this.start);
            this.Controls.Add(this.question);
            this.Controls.Add(this.questionbox);
            this.Controls.Add(this.gamescene);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShootForm";
            this.Text = "ShootForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShootForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletcount5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamescene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox questionbox;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox bulletcount5;
        private System.Windows.Forms.PictureBox bulletcount6;
        private System.Windows.Forms.PictureBox bulletcount7;
        private System.Windows.Forms.PictureBox bulletcount8;
        private System.Windows.Forms.PictureBox bulletcount1;
        private System.Windows.Forms.PictureBox bulletcount2;
        private System.Windows.Forms.PictureBox bulletcount3;
        private System.Windows.Forms.PictureBox bulletcount4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gamescene;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label scoreboard;
    }
}