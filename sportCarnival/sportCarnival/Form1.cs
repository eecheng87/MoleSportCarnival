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
            //test, later delete
            //FormSki.Show();
        }

        private void ski_btn_Click(object sender, EventArgs e)
        {
            FormSki.Show();
        }

        private void fishing_btn_Click(object sender, EventArgs e)
        {
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
    }
}
