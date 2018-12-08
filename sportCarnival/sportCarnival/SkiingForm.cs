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
        public int mapX;
        public PictureBox mole;
        public PictureBox backImg;
        public int moleX;
        public int moleY;
        public int lastmove;//0:A,1:S,2:D,3:W
        public SkiingForm()
        {
            InitializeComponent();
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

            this.Controls.Add(mole);
            this.Controls.Add(backImg);
            

        }

        private void SkiingForm_Load(object sender, EventArgs e)
        {
           
            timer1.Interval = 5;

            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
    }
}
