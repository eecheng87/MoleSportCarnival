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
    public partial class Form1 : Form
    {
        //declare var for each form
        FishingForm FormFish = new FishingForm();
        HockeyForm FormHockey = new HockeyForm();
        ShootForm FormShoot = new ShootForm();
        SkiingForm FormSki = new SkiingForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(@"../../../Resource/startImg.jpg");
            BackgroundImageLayout = ImageLayout.Zoom;
            button5.Text = "離開";
            button5.BackColor = Color.Red;

        }

        private void ski_btn_Click(object sender, EventArgs e)
        {
            FormSki = new SkiingForm();
            FormSki.Show();
        }

        private void fishing_btn_Click(object sender, EventArgs e)
        {
            FormFish = new FishingForm();
            FormFish.Show();
        }

        private void shoot_btn_Click(object sender, EventArgs e)
        {
            FormShoot.Show();
        }

        private void hockey_btn_Click(object sender, EventArgs e)
        {
            FormHockey.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
