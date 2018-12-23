using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportCarnival
{
    public partial class FishingForm : Form
    {
        public int lineStart;
        public int lineEnd;
        public bool direction;// 1 means going down 0 means going up
        public List<Fish> fishList;
        public int currentFishNum;
        public int geneCounter;
        public PictureBox attachFish;
        public bool Catch;
        public FishingForm()
        {
            InitializeComponent();
            
            
        }

        private void FishingForm_Load(object sender, EventArgs e)
        {
          
            BackgroundImage = new Bitmap(@"../../../Resource/fishing_back.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            Location = new Point(0, 0);
            Size = new Size(ClientSize.Width,ClientSize.Height);

            // init variable
            direction = false;
            lineStart = 130;
            lineEnd = 155;
            currentFishNum = 0;
            geneCounter = 200;
            fishList = new List<Fish>();

            Catch = false;
            attachFish = new PictureBox();
            attachFish.Image = new Bitmap(@"../../../Resource/fish_up.png");
            attachFish.SizeMode = PictureBoxSizeMode.Zoom;
            attachFish.Size = new Size(70, 70);
            attachFish.Visible = false;
            attachFish.BackColor = Color.Transparent;
            Controls.Add(attachFish);



            timer1.Tick += new EventHandler(TimerCallback);
            // make graph more meticulous         
            this.DoubleBuffered = true;
            //start game
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lineEnd > 460)
            {
                direction = false;
            }
            // update attach fish's position
            if (Catch)
            {
                attachFish.Visible = true;
                attachFish.Location = new Point(390,lineEnd-6);
                
            }
            // if current fish number less than threshold, then generate fish
            if (currentFishNum < 3)
            {
                geneCounter++;
                if (geneCounter > 250)
                {
                    geneFish();
                    geneCounter = 0;
                }
            }
            // update each fish next position
            if(currentFishNum>0)
                for(int i=0; i<fishList.Count;i++)
                {

                    if ((string)fishList[i].img.Image.Tag == "right")
                    {
                        // current direction is forward to right
                        fishList[i].img.Left += 1;
                        // when fish was caught
                        if (fishList[i].img.Left < 423 && fishList[i].img.Right > 423 && Math.Abs(fishList[i].img.Top - lineEnd) < 2) 
                        {
                            Controls.Remove(fishList[i].img);
                            fishList[i].img.Dispose();
                            fishList.Remove(fishList[i]);
                            currentFishNum--;
                            Catch = true;
                        }
                    }else
                    {
                        // current direction is forward to left
                        fishList[i].img.Left -= 1;
                        // when fish was caught
                        if (fishList[i].img.Left<423 && fishList[i].img.Right > 423 && Math.Abs(fishList[i].img.Top - lineEnd) < 2)
                        {
                            Controls.Remove(fishList[i].img);
                            fishList[i].img.Dispose();
                            fishList.Remove(fishList[i]);
                            currentFishNum--;
                            Catch = true;
                        }
                    }
                }

        }
        private void TimerCallback(object sender, EventArgs e)
        {
            if (lineEnd <= lineStart && direction == false)
            {
                Catch = false;
                attachFish.Visible = false;
                return;
            }
       
            // function for update how to paint (process new coordinate for line)
            if (direction)
            {
                lineEnd += 3;
            }
            else
            {
                lineEnd -= 3;
            }
            // if line is going to down but catch fish -> change direction
            if (direction && Catch)
                direction = false;

            this.Invalidate();
            return;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graph = e.Graphics;
            Pen p = new Pen(Color.White, 3);
            graph.DrawLine(p, 423, 130,423, lineEnd);
            base.OnPaint(e);
        }

        private void FishingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if (direction == false && lineEnd <= lineStart)
                {
                    direction = true;
                }
            }
        }

        private void geneFish()
        {
            Random myrand = new Random();
            int direction = myrand.Next(0, 2);
            Fish fish = new Fish();
            fish.img = new PictureBox();
            fish.img.SizeMode = PictureBoxSizeMode.Zoom;
            fish.img.Size = new Size(70, 70);
            if (direction==0)
            {// direction is left
                fish.img.Location = new Point(900,myrand.Next(250, 450));
                fish.img.Image = new Bitmap(@"../../../Resource/fish_left.png");
                fish.img.Image.Tag = "left";
            }else
            {
                fish.img.Location = new Point(-70, myrand.Next(250, 450));
                fish.img.Image = new Bitmap(@"../../../Resource/fish_right.png");
                fish.img.Image.Tag = "right";
            }
            fish.img.BackColor = Color.Transparent;
            Controls.Add(fish.img);
         
            fishList.Add(fish);
            currentFishNum++;
        }
    }
}
