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
        public int bucketCounter;
        public PictureBox attachFish;
        public PictureBox WormImg;
        public PictureBox bucketImg;

        public bool bucketState; // if value is true: exist
        public bool Catch;
        public bool Worm; // if value is true: have worm

        // variable for question and current state( success or fail )
        public int expression; // 0 means >, 1 means <
        public bool newQuestion; // true means generate new question
        public int leftOperator;
        public int rightOperator;
        public Label question;
        public Label result;

        // score
        public int score;
        // worm number
        public int wormNum;
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
            bucketCounter = 0;
            bucketState = false;
            fishList = new List<Fish>();
            Worm = true;

            Catch = false;
            attachFish = new PictureBox();
            attachFish.Image = new Bitmap(@"../../../Resource/fish_up.png");
            attachFish.SizeMode = PictureBoxSizeMode.Zoom;
            attachFish.Size = new Size(70, 70);
            attachFish.Visible = false;
            attachFish.BackColor = Color.Transparent;
            Controls.Add(attachFish);

            WormImg = new PictureBox();
            WormImg.Image = new Bitmap(@"../../../Resource/worm.png");
            WormImg.SizeMode = PictureBoxSizeMode.Zoom;
            WormImg.Size = new Size(40, 40);
            WormImg.BackColor = Color.Transparent;
            Controls.Add(WormImg);

            bucketImg = new PictureBox();
            bucketImg.Image = new Bitmap(@"../../../Resource/bucket.png");
            bucketImg.SizeMode = PictureBoxSizeMode.Zoom;
            bucketImg.Size = new Size(90, 90);
            bucketImg.Location = new Point(-100, 320);
            bucketImg.BackColor = Color.Transparent;
            Controls.Add(bucketImg);

            // initial Question variable
            question = new Label();
            question.Text = "題目: ";
            question.Location = new Point(250, 40);
            question.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(question);

            result = new Label();
            result.Text = "產生中...";
            result.Location = new Point(550, 40);
            result.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(result);

            newQuestion = true;

            score = 0;
            wormNum = 3;
            instruct.Visible = false;
            this.KeyPreview = true;
            timer1.Tick += new EventHandler(TimerCallback);
            // make graph more meticulous         
            this.DoubleBuffered = true;
            //start game
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // update score board
            point.Text = "分數: " + score.ToString();
            life.Text = "魚餌剩餘: " + wormNum.ToString();

            // generate new quetion
            if (newQuestion)
            {
                geneQuestion();
            }
            // for generate bucket counter
            bucketCounter++;
            if (bucketCounter>200&&!bucketState) // time interval 10
            {
                bucketCounter = 0;
                bucketImg.Left = -50;
                bucketState = true;
            }

            // update bucket position
            if (bucketState)
            {
                bucketImg.Left += 2;
                if (bucketImg.Left > 1000)
                {
                    bucketState = false;
                   // bucketImg.Dispose();
                }
            }

            // check worm whether collide bucket
            if( bucketImg.Left-423 < 90 && bucketImg.Left - 423 > -40 && bucketImg.Top-lineEnd<70 && Worm == true)
            {
                wormNum--;
                Worm = false;
            }

            // game over
            if(wormNum == 0)
            {
                timer1.Stop();
                DialogResult tmp = MessageBox.Show("遊戲結束, 獲得 " + score.ToString() + " 分");
                
                if (tmp == DialogResult.OK)
                {
                    this.Close();
                }
            }

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
            // update attch worm's position
            if (Worm)
            {
                WormImg.Visible = true;
                WormImg.Location = new Point(405, lineEnd - 5);
            }else
            {
                WormImg.Visible = false;
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
            if (currentFishNum > 0)
                for(int i=0; i<fishList.Count;i++)
                {
                    if (fishList[i].img.Left < -70 || fishList[i].img.Left > 900)
                    {
                        currentFishNum--;
                        Controls.Remove(fishList[i].img);
                        fishList[i].img.Dispose();
                        fishList.Remove(fishList[i]);
                    }

                    if ((string)fishList[i].img.Image.Tag == "right")
                    {
                        // current direction is forward to right
                        fishList[i].img.Left += 1;
                        fishList[i].label.Left += 1;
                        // when fish was caught
                        if (fishList[i].img.Left < 423 && fishList[i].img.Right > 423 && Math.Abs(fishList[i].img.Top - lineEnd) < 2) 
                        {
                            // check answer whether correct
                            if (expression == 0)
                            {
                                // 0 means >
                                if(fishList[i].num > rightOperator)
                                {
                                    //correct
                                    newQuestion = true;
                                    result.Text = "答對囉~ ~";
                                    score++;
                                }else
                                {
                                    newQuestion = true;
                                    result.Text = "答錯囉~ ~";
                                }
                            }
                            else
                            {
                                // 1 means <
                                if (fishList[i].num < rightOperator)
                                {
                                    //correct
                                    newQuestion = true;
                                    result.Text = "答對囉~ ~";
                                    score++;
                                }
                                else
                                {
                                    newQuestion = true;
                                    result.Text = "答錯囉~ ~";
                                }
                            }
                            // remove fish's label
                            Controls.Remove(fishList[i].label);
                            // remove fish
                            Controls.Remove(fishList[i].img);
                            fishList[i].img.Dispose();
                            fishList.Remove(fishList[i]);
                            currentFishNum--;
                            Catch = true;
                            Worm = false;
                        }
                    }else
                    {
                        // current direction is forward to left
                        fishList[i].img.Left -= 1;
                        fishList[i].label.Left -= 1;
                        // when fish was caught
                        if (fishList[i].img.Left<423 && fishList[i].img.Right > 423 && Math.Abs(fishList[i].img.Top - lineEnd) < 2)
                        {
                            // check answer whether correct
                            if (expression == 0)
                            {
                                // 0 means >
                                if (fishList[i].num > rightOperator)
                                {
                                    //correct
                                    newQuestion = true;
                                    result.Text = "答對囉~ ~";
                                    score++;
                                }
                                else
                                {
                                    newQuestion = true;
                                    result.Text = "答錯囉~ ~";
                                }
                            }
                            else
                            {
                                // 1 means <
                                if (fishList[i].num < rightOperator)
                                {
                                    //correct
                                    newQuestion = true;
                                    result.Text = "答對囉~ ~";
                                    score++;
                                }
                                else
                                {
                                    newQuestion = true;
                                    result.Text = "答錯囉~ ~";
                                }
                            }

                            // remove fish's label
                            Controls.Remove(fishList[i].label);
                            // remove fish
                            Controls.Remove(fishList[i].img);
                            fishList[i].img.Dispose();
                            fishList.Remove(fishList[i]);
                            currentFishNum--;
                            Catch = true;
                            Worm = false;
                        }
                    }
                }

        }
        private void TimerCallback(object sender, EventArgs e)
        {
            if (lineEnd <= lineStart && direction == false)
            {
                Worm = true;
                Catch = false;
                attachFish.Visible = false;
                WormImg.Visible = true;
                return;
                /*****************
                 *   
                 * 
                 ****************/ 
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

        private void geneQuestion()
        {
            Random myrand = new Random();
            int exp = myrand.Next(0, 2); // 0 means >
            int right = myrand.Next(3, 8);
            expression = exp;
            rightOperator = right;
            string str;
            if (exp == 0)
                str = ">";
            else
                str = "<";

            question.Text = "題目: " + "  " + str + rightOperator.ToString();

            newQuestion = false;
        }
        private void geneFish()
        {
            Random myrand = new Random();
            int direction = myrand.Next(0, 2);
            Fish fish = new Fish();
            fish.img = new PictureBox();
            fish.img.SizeMode = PictureBoxSizeMode.Zoom;
            fish.img.Size = new Size(70, 70);
            
            // set fish's top 
            fish.top = myrand.Next(250, 450);

            fish.label = new Label();
            fish.num = myrand.Next(1, 10);
            fish.label.Text = fish.num.ToString();
            
            fish.label.Width = 15;
            fish.label.Height = 15;
            //fish.label.TextAlign = ContentAlignment.MiddleCenter;
            fish.label.Font = new Font("Arial", 10);
            Controls.Add(fish.label);
         
            if (direction==0)
            {// direction is left
                fish.left = 900;
                fish.label.Location = new Point(fish.left+20, fish.top);
                fish.img.Location = new Point(900,fish.top);
                fish.img.Image = new Bitmap(@"../../../Resource/fish_left.png");
                fish.img.Image.Tag = "left";
            }else
            {
                fish.left = -70;
                fish.label.Location = new Point(fish.left+20, fish.top);
                fish.img.Location = new Point(-70, fish.top);
                fish.img.Image = new Bitmap(@"../../../Resource/fish_right.png");
                fish.img.Image.Tag = "right";
            }
            fish.img.BackColor = Color.Transparent;
            Controls.Add(fish.img);
         
            fishList.Add(fish);
            currentFishNum++;
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instruction_Click(object sender, EventArgs e)
        {
            instruct.Visible = true;
        }

        private void instruct_Click(object sender, EventArgs e)
        {
            instruct.Visible = false;
        }
    }
}
