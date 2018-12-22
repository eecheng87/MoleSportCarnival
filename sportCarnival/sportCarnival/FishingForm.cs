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
            fishList = new List<Fish>();



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
                direction = false;

            // if current fish number less than threshold, then generate fish
            if (currentFishNum < 3)
            {
                geneFish();
            }
            // update each fish next position
            if(currentFishNum>0)
                foreach(Fish tmp in fishList)
                {
                    if ((string)tmp.img.Image.Tag == "right")
                    {
                        // current direction is forward to right
                        tmp.img.Left += 1;
                    }else
                    {
                        // current direction is forward to left
                        tmp.img.Left -= 1;
                    }
                }

        }
        private void TimerCallback(object sender, EventArgs e)
        {
            if (lineEnd <= lineStart && direction == false)
                return;
            // function for update how to paint (process new coordinate for line)
            if (direction)
            {
                lineEnd += 1;
            }
            else
            {
                lineEnd -= 1;
            }
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
            //fishList.Add(fish);
            
            /*Fish fish = new Fish();
           
            if (direction == 0)
            {// direction is left
                fish.direction = "left";
                fish.imgPath = "@\"../../../ Resource / fish_left.png\"";
                fish.left = 900;
                fish.top = myrand.Next(250, 450);
            }
            else
            {
                fish.direction = "right";
                fish.imgPath = "@\"../../../ Resource / fish_right.png\"";
                fish.left = -70;
                fish.top = myrand.Next(250, 450);
            }*/

            fishList.Add(fish);
            currentFishNum++;
        }
    }
}
