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
    public partial class HockeyForm : Form
    {
        int score_p, score_n;
        int x_speed;
        int y_speed;
        int x_positive ;
        int x_negative ; 
        int y_positive ;
        int y_negative;
        int time_count ;
        int count; 
        bool playing;
        public HockeyForm()
        {
            InitializeComponent();
            player.Parent = gamescene;
            gamescene.Controls.Add(player);
            gamescene.Controls.Add(ball); 
        }
        private void HockeyForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "A":
                    if (player.Left > 10)
                        x_negative = 1;
                    break;
                case "D":
                    if (player.Left < 480)
                        x_positive = 1;
                    break;
                case "W":
                    if (player.Top > 306)
                        y_negative = 1;
                    break;
                case "S":
                    if (player.Top < 590)
                        y_positive = 1;
                    break;
                //cheating
                case "P":
                    score_p = 7;
                    break;
                case "O":
                    score_n = 7;
                    break;
                case "I":
                    time_count = 0;
                    break; 
            }
        }
        private void HockeyForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "A":
                    x_negative = 0;
                    break;
                case "D":
                    x_positive = 0;
                    break;
                case "W":
                    y_negative = 0;
                    break;
                case "S":
                    y_positive = 0;
                    break;
                
                    
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true ;
            start.Enabled = false ;
            score_n = 0;
            score_p = 0 ;
            time_count = 300 ;
            count = 0; 
            init(0);
            playing = true;
            pause.Enabled = true;
            result.Clear(); 
        }
        private void pause_Click(object sender, EventArgs e)
        {
            if (playing)
            {
                timer1.Stop();
                playing = false;
                pause.Text = "Countinue";
            }
            else
            {
                timer1.Start();
                playing = true;
                pause.Text = "Pause";
                result.Clear();
                result.BackColor = Color.White;
                result.ForeColor = Color.Black;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            start.Enabled = true;
            pause.Enabled = false;
            this.Visible = false;
            timer1.Stop();
            init(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //log the time 
            if (count % 50 == 0)
            {
                --time_count;
                count = 0 ;  
            }
            ++ count;  
            
            //calculate the center of ball
            int ball_center = ball.Left + (ball.Width / 2) ; 
            
            //update the scoreboard
            score1.Text = score_p.ToString();
            score2.Text = score_n.ToString();
            timenotice.Text = time_count.ToString(); 
            
            //control player's move on x_axis
            if (player.Left >= 480)
                player.Left += -x_negative * 3;
            else if (player.Left <= 10)
                player.Left += 3*x_positive; 
            else
                player.Left += 3*(x_positive - x_negative);
            
            //control player's move on y_axis
            if (player.Top >= 590)
                player.Top += -y_negative * 3;
            else if (player.Top <= 306)
                player.Top += y_positive * 3; 
            else
                player.Top += 3* (y_positive - y_negative);

            //control the move of ball
            ball.Top  += y_speed;
            ball.Left += x_speed;

            //deal with the collision between player and ball
            if ((ball.Bottom > player.Top) && (ball.Bottom < player.Bottom) && (ball_center > player.Left) && (ball_center < player.Right))
            {
                if (y_speed > 0)
                    y_speed = -y_speed;
            }
            if ((player.Bottom > ball.Top) && (ball.Bottom > player.Bottom) && (ball_center > player.Left) && (ball_center < player.Right))
            {
                if (y_speed < 0)
                    y_speed = -y_speed;
               
            }

            //deal with  the collision between NPC and ball
            if ((ball.Top < NPC.Bottom) && (ball.Top > NPC.Top) &&(ball_center > NPC.Left) && (ball_center < NPC.Right))
            {
                if (y_speed < 0)
                    y_speed = -y_speed;

            }
            if ((ball.Bottom > NPC.Top) && (ball.Bottom < NPC.Top) &&(ball_center > NPC.Left) && (ball_center < NPC.Right))
            {
                if (y_speed > 0)
                    y_speed = -y_speed;
            }
            
            //deal with the edge's collision
            if (ball.Left <= 10)
                x_speed = (Math.Abs(x_speed) + 1) ;
            if (ball.Left >= 530)
                x_speed = -(Math.Abs(x_speed) + 1) ;
            if ((ball.Top < 10) && (ball.Left <= edge1.Width))
                y_speed = (Math.Abs(y_speed) + 1) ; 
            if ((ball.Top < 10) && (ball.Left >= edge2.Left) &&(ball.Left <= edge2.Left +edge2.Width))
                y_speed = (Math.Abs(y_speed) + 1);
            if ((ball.Bottom > edge5.Top) && (ball.Left <= edge5.Width) && (y_speed > 0))
                y_speed = -(Math.Abs(y_speed) + 1);
            if ((ball.Bottom > edge6.Top) && (ball.Right > edge6.Left) && (ball.Left <= edge6.Left + edge6.Width) &&(y_speed > 0))
                y_speed = -(Math.Abs(y_speed) + 1);

            //deal the goal
            if ((ball.Bottom > edge5.Top) && (ball_center < edge6.Left) &&(ball_center >edge5.Width))
            {
                ++score_n ; 
                init(1);
                result.Text = "NPC's point";
                result.BackColor = Color.White;
                result.ForeColor = Color.Blue;   
            }
            if ((ball.Top < edge1.Bottom) && (ball_center < edge2.Left) && (ball_center > edge1.Width))
            {
                ++score_p;
                init(2);
                result.Text = "player's point";
                result.BackColor = Color.White; 
                result.ForeColor = Color.Red; 
            }
            //finish the game
            check(score_p, score_n , time_count); 
        }
        void init(int i)
        {
            Random rnd = new Random();
            if (i == 0)
            {
                ball.Left = 277;
                ball.Top  = 286; 
                y_speed = 3;
            }
            else
            {
             if (i == 1)
             {
              ball.Left = 260;
              ball.Top = 385;
              y_speed = 3;
             }
             if (i == 2)
             {
              ball.Left = 260;
              ball.Top = 220;
              y_speed = -3;
             }
             player.Top  = 560 ;
             player.Left = 248 ;
             NPC.Left    = 248 ;
             NPC.Top     = 50  ;
             timer1.Stop();
             playing = false;
             pause.Text = "Countinue";
            }
            int temp = rnd.Next(-3, 3);
            while (temp == 0)
            {
                temp = rnd.Next(-3, 3);
            }
            x_speed = temp;
        }
        void check(int i , int j , int t)
        {
            if(i >= 7)
            {
                timer1.Stop();
                score1.Text = "7" ; 
                result.Text = "You Win !!"; 
                result.BackColor = Color.White;
                result.ForeColor = Color.Red;
                pause.Enabled = false;
                start.Enabled = true; 
            }
            if( j >= 7)
            {
                timer1.Stop();
                score2.Text = "7";
                result.Text = "You Lose!!";
                result.BackColor = Color.White;
                result.ForeColor = Color.Blue;
                pause.Enabled = false;
                start.Enabled = true;
            }
            if (t <= 0 )
            {
             if(i > j)
             {
              timer1.Stop();
              result.Text = "You Win !!";
              result.BackColor = Color.White;
              result.ForeColor = Color.Red;
              pause.Enabled = false;
              start.Enabled = true;
             }
             if(j > i)
             {
              timer1.Stop();
              result.Text = "You Lose!!";
              result.BackColor = Color.White;
              result.ForeColor = Color.Blue;
              pause.Enabled = false;
              start.Enabled = true;
             }
             if(i == j)
             {
              timer1.Stop();
              result.Text = "Tie";
              result.BackColor = Color.White;
              result.ForeColor = Color.Gray;
              pause.Enabled = false;
              start.Enabled = true;   
             }
            }
        }
    }
}
