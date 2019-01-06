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
    public partial class SkiingForm : Form
    {   
        private List<string> question;
        private List<Label> brick;

        public int mapX;
        
        public PictureBox mole;
        public PictureBox backImg;
        public int moleX;
        public int moleY;
        public int lastmove;//0:A,1:S,2:D,3:W

        private int brickSpeed;
        private int counter;

        private string currentQ;
        private char[] currentCharArr;
        private bool[] eachCharState;
        private string currentA;
        private bool finish;

        public SkiingForm()
        {
            InitializeComponent();

            initQuestion();
            brickSpeed = 5;

            mapX = 0;
            lastmove = 0;



            backImg = new PictureBox
            {
                Name = "background_img",
                Size = new Size(2472, 726),
                Location = new Point(0, 0),
                Image = Image.FromFile(@"../../../Resource/ski_back.jpg")
            };
            mole = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(70, 70),
                Image = Image.FromFile(@"../../../Resource/ski_mole.png"),
                Parent = backImg,
                Location = new Point(50, 300),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.Zoom

            };


            moleX = 50;
            moleY = 300;

            mypanel.Controls.Add(mole);
            mypanel.Controls.Add(backImg);
            

        }

        private void SkiingForm_Load(object sender, EventArgs e)
        {

            counter = 0;
            timer1.Interval = 5;
            brick = new List<Label>();

            finish = true;


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random myrand = new Random();



            backImg.Location = new Point(mapX, 0);
            mole.Location = new Point(moleX, moleY);

            if (mapX < -600)
            {
                //moleX -= (-mapX);
                mapX = 0;
            }
            else
            {
                //moleX += 4;
                mapX -= 4;
            }
            //if out of boundary
            if (moleX < 0)
            {
                lastmove = 2;
            }
            if (moleX > 850)
            {
                lastmove = 0;
            }
            if (moleY > 460)
            {
                lastmove = 3;
            }
            if(moleY < 250)
            {
                lastmove = 1;
            }


            //make it more smooth
            switch (lastmove)
            {
                case 0:
                    moleX -= 1;
                    break;
                case 1:
                    moleY += 1;
                    break;
                case 2:
                    moleX += 1;
                    break;
                case 3:
                    moleY -= 1;
                    break;
                default:
                    break;
            }

            //generate Question
            if (finish)
            {
                currentQ = question[myrand.Next(0, question.Count)];
                currentCharArr = currentQ.ToCharArray();
                eachCharState = new bool[currentQ.Length];
                for (int i = 0; i < eachCharState.Length; i++)
                    eachCharState[i] = false;
                labelQ.Text = "題目:" + currentQ;
                ansLabel.Text = "完成:";
                finish = false;
            }



            //generate brick
            counter++;
            if (counter > 50)
            {
                counter = 0;
                geneBrick();
            }
            //update each brick's position
            for(int i = 0; i < brick.Count; i++)
            {
                brick[i].Left -= brickSpeed;
            }
            //check whether collide
            for(int i = 0; i < brick.Count; i++)
            {
                int centerY = (brick[i].Top+brick[i].Bottom)/ 2;
                int centerX = brick[i].Left;
                if (centerX < mole.Right && centerX > mole.Left && centerY < mole.Bottom && centerY > mole.Top)
                {
                    //collide
                    char[] arr = brick[i].Text.ToArray();
                    //MessageBox.Show(arr[0].ToString());
                    if (currentQ.IndexOf(arr[0]) != -1)
                    {
                        //Question contain brick.text which is collided currently
                        eachCharState[currentQ.IndexOf(arr[0])] = true;

                        //update content in ansLabel
                        ansLabel.Text = "完成: ";
                        for(int j = 0; j < eachCharState.Length; j++)
                        {
                            if (eachCharState[j])
                            {
                                ansLabel.Text += currentCharArr[j];
                            }
                        }
                    }
                    mypanel.Controls.Remove(brick[i]);
                    brick[i].Dispose();
                    brick.Remove(brick[i]);
                }
            }
            // check whether finish current Question
            if (complete())
            {
                timer1.Stop();
                DialogResult tmp = MessageBox.Show("你完成了, 按確認回到首頁");

                if (tmp == DialogResult.OK)
                {
                    this.Close();
                }
               
            }

        }
        // check whether finish current Question
        private bool complete()
        {
            for (int k = 0; k < eachCharState.Length; k++)
            {
                if (!eachCharState[k])
                    return false;
            }
            return true;
        }
        private void SkiingForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "A")
            {
                moleX -= 10;
                lastmove = 0;
            }else if (e.KeyCode.ToString() == "S")
            {
                moleY += 10;
                lastmove = 1;
            }else if (e.KeyCode.ToString() == "D")
            {
                moleX += 10;
                lastmove = 2;
            }else if (e.KeyCode.ToString() == "W")
            {
                moleY -= 10;
                lastmove = 3;
            }else
            {
       
            }
        }

        private void geneBrick()
        {
            Random myrand = new Random();
            //Graphics g;
            int num = myrand.Next(65, 73);
            char ch = (char)num;
            
            
            Label tmp = new Label();
            tmp.Text = ch.ToString();
            tmp.TextAlign = ContentAlignment.MiddleCenter;
            tmp.Font = new Font("Arial",18);
            tmp.Width = 45;
            tmp.Height = 45;
            tmp.Left = myrand.Next(800,900);
            tmp.Top = myrand.Next(250,460);
            tmp.BackColor = Color.FromArgb(1, 202, 207, 210);
            tmp.BringToFront();
            brick.Add(tmp);
            
            mypanel.Controls.Add(tmp);
            tmp.BringToFront();
            
        }
        private void initQuestion()
        {
            question = new List<string>();
            question.Add("GAB");
            question.Add("DAD");
            question.Add("CAD");
            question.Add("BAD");
            question.Add("ADC");
        }
    }

}
