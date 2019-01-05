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
    public partial class ShootForm : Form
    {
        int count;
        int score;
        int ans_count;
        int bulletcount;
        int bulletcountnum;
        bool contorlable = false;
        bool playing;
        public List<Label> target = new List<Label>();
        public List<PictureBox> bull = new List<PictureBox>();
        public List<string> char_list = new List<string>();
        public List<string> answer = new List<string>() ;
        string[,] questionlist = new string[,] {{"S", "U", "N" },{ "C" , "A" ,"T"} , {"D" , "O" ,"G"}};
         
        public ShootForm()
        {
           
            InitializeComponent();
            player.Parent = gamescene;
            player.BackColor = Color.Transparent ; 
        }
        //start the game and initial something
        void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
            genequestion();
            
            count = 0;
            score = 0;
            bulletcount = 8;
            bulletcountnum = 0 ;
            ans_count = 0; 
            contorlable = true;
            bulletcount1.Visible = true ;
            bulletcount2.Visible = true ;
            bulletcount3.Visible = true ;
            bulletcount4.Visible = true ;
            bulletcount5.Visible = true ;
            bulletcount6.Visible = true ;
            bulletcount7.Visible = true ;
            bulletcount8.Visible = true ;
            start.Enabled = false;
            pause.Enabled = true; 
            playing = true ;
            PictureBox a = new PictureBox();
            a.Left = 0;
            a.Top = 500;
            a.Width = 0;
            a.Height = 0;
            bull.Add(a);
            gamescene.Controls.Add(a);
        }
        //pause the game and restart
        private void pause_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                timer1.Stop();
                contorlable = false;
                playing     = false;
                pause.Text = "Countinue";  
            }
            else
            {
                timer1.Start();
                contorlable = true;
                playing = true ;
                pause.Text = "Pause";   
            } 
        }
        //exit this window
        private void exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            questionbox.Image = null; 
            this.Visible = false;
            for(int i = 0; i < target.Count; ++i)
            {
                target[i].Dispose(); 
            }
            for(int i = 0; i < bull.Count; ++i)
            {
                bull[i].Dispose(); 
            }
            score = 0;
            target.Clear();
            bull.Clear();
            start.Enabled = true ;
            pause.Enabled = false ;   
              
        }
        //generate  targets ,  control targets and bullets' move
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count % 100 == 0)
                genetarget();
            for (int i = 0; i < target.Count; ++i)
            {
                target[i].Left += 1;
                if (target[i].Left > 498)
                {
                    target[i].Dispose();
                    target.Remove(target[i]);
                }  
            }
            for (int i = 1; i < bull.Count; ++i)
            {
                bull[i].Top -= 2;
                if(bull[i].Top < 0)
                {
                    bull[i].Dispose();
                    bull.Remove(bull[i]);
                    ++bulletcountnum; 
                }    
            }
            for (int i = 1; i < bull.Count; ++i)
            {
                for (int j = 1; j < target.Count ; ++j)
                {
                    if ((bull[i].Left + bull[i].Width > target[j -1].Left) && (bull[i].Left < target[j-1].Left + target[j-1].Width) && (bull[i].Top + bull[i].Height > target[j-1].Top) && (bull[i].Top < target[j-1].Top + target[j-1].Height))
                    {
                        if (bull.Count > 0)
                        {
                            char_list.Add(target[j-1].Text);
                            bull[i].Dispose();
                            target[j-1].Dispose();
                            bull.Remove(bull[i]);
                            target.Remove(target[j-1]);
                            ++score;
                            ++bulletcountnum;
                        }
                    }
                }
            }
            
            switch(bulletcount)
            {
                case 0:
                    bulletcount1.Visible = false; 
                    break;
                case 1:
                    bulletcount2.Visible = false;
                    break;
                case 2:
                    bulletcount3.Visible = false;
                    break;
                case 3:
                    bulletcount4.Visible = false;
                    break;
                case 4:
                    bulletcount5.Visible = false;
                    break;
                case 5:
                    bulletcount6.Visible = false;
                    break;
                case 6:
                    bulletcount7.Visible = false;
                    break;
                case 7:
                    bulletcount8.Visible = false;
                    break;
            }
             updatescore();
            if (bulletcountnum == 8)
                gameover();
            ++ count;
        }
        //control player's move
        private void ShootForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (contorlable)
            {
                switch (e.KeyCode.ToString())
                {
                    case "A":
                        player.Left -= 5;
                        break;
                    case "D":
                        player.Left += 5;
                        break;
                    case "L":
                        {
                            if (bulletcount > 0)
                            {
                                genebullet();
                                --bulletcount;
                            }
                        }
                        break;
                }
            }
        }
        //generate target
        private void genetarget()
        {
            Random rnd = new Random();
            int num = rnd.Next(65, 90);
            char ch = (char)num;

            int y = 40 * rnd.Next(0, 4) ;  

            Label tmp = new Label();
            tmp.Text      = ch.ToString();
            tmp.TextAlign = ContentAlignment.MiddleCenter;
            tmp.Font      = new Font("Arial", 12);
            tmp.Width     = 40 ;
            tmp.Height    = 40 ;
            tmp.Left      =  0 ;
            tmp.Top       =  y ; 
            tmp.BackColor = Color.Transparent;
            target.Add(tmp);

            gamescene.Controls.Add(tmp);



        }
        //generate bullet
        private void genebullet()
        {
            PictureBox bullet = new PictureBox() ;
            bullet.Width = 10;
            bullet.Height = 30; 
            bullet.Image = Image.FromFile(@"../../../Resource/newbullet.png");
            bullet.SizeMode = PictureBoxSizeMode.StretchImage; 
            bullet.Left = player.Left + (player.Width - bullet.Width) * 7 / 10 ;
            bullet.Top = player.Top - bullet.Height ;
            bullet.BackColor = Color.Transparent ; 
            bull.Add(bullet);
            gamescene.Controls.Add(bullet);    
        }
        //generate question
        private void genequestion()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 3); 
            questionbox.Image = imageList1.Images[num];
            question.Text = "__ __ __";
            question.TextAlign = HorizontalAlignment.Center;
            for(int i = 0; i < 3; ++i)
            {
                answer.Add(questionlist[num , i]);
            }
        }
        private void updatescore()
        {
            scoreboard.Text = "分數 : " + score + " 分";  
        }
        private void gameover()
        {
            timer1.Stop();
            start.Enabled = true ;
            pause.Enabled = false ;
            for (int i = 0; i < target.Count; ++i)
            {
                target[i].Dispose();
            }
            for (int i = 0; i < bull.Count; ++i)
            {
                bull[i].Dispose();
            }
            for(int i = 0 ; i < char_list.Count; ++i)
            {
             for(int j = 0; j < answer.Count;++j)
             {
                    if (char_list[i] == answer[j])
                        ++ans_count; 
             }
            }
            if(ans_count >= 3)
            {
                score += 10 ; 
            }
            scoreboard.Text = "分數 : " + score + " 分";
            target.Clear();
            bull.Clear();
            DialogResult result;
            result = MessageBox.Show("你獲得了" + score + " 分", "遊戲結果", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
