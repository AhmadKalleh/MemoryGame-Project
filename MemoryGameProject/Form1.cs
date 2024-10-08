using MemoryGameProject.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void SetRoundedCornersToForm()
        {
            int radius = 30; // نصف قطر الزوايا الدائرية
            GraphicsPath path = new GraphicsPath();

            // إضافة مستطيل بزوايا دائرية إلى المسار
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // تعيين المنطقة المحددة للمسار
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedCornersToForm(); // إعادة تعيين الزوايا عند تغيير حجم النموذج
            
        }

        private int Score = 0;     
        TimeSpan time = new TimeSpan(0,0,0);
        TimeSpan time2 = new TimeSpan(0,0,1);
        
       
        List<Button> buttons = new List<Button>();


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void RestPictures(PictureBox pictureBox)
        {
            pictureBox.BackgroundImage = Resources.EmptyStar;
        }

        private void RestButton(Button button,string num)
        {
            button.BackgroundImage = Resources.Queation;
            button.Tag = num;
        }
        private void RestartGame()
        {
            timer1.Stop();

            DisableAllButtons();

            RestPictures(pictureBox1);
            RestPictures(pictureBox2);
            RestPictures(pictureBox3);
            RestPictures(pictureBox4);
            RestPictures(pictureBox5);

            RestButton(btn1, "?");
            RestButton(btn2, "?");
            RestButton(btn9, "?");
            RestButton(btn5, "?");
            RestButton(btn10,"?");
            RestButton(btn4, "?");
            RestButton(btn3, "?");
            RestButton(btn7, "?");
            RestButton(btn8, "?");
            RestButton(btn6, "?");

            lbTime.Text = "00:00";
            lbTime.ForeColor = Color.DarkSlateGray;
            cbTimer.Text = "1";
            cbSpeed.Text = "1x";
            Score = 0;

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            RestartGame();

        }

        
        private bool IsWin()
        {
            if(Score==10)
                return true; 

            return false;

        }

        private void GetSpeed()
        {
            switch(cbSpeed.Text)
            {
                case "1x":
                    timer1.Interval = 1000;
                    break;

                case "1.5x":
                    timer1.Interval = 500;
                    break;

                case "2x":
                    timer1.Interval = 200;
                    break;

            }
           
        }

        private void UpdateStar()
        {
            switch(Score)
            {
                case 2:
                    pictureBox1.BackgroundImage = Resources.FullStar;
                    break;

                case 4:
                    pictureBox2.BackgroundImage = Resources.FullStar;
                    break ;

                case 6:
                    pictureBox3.BackgroundImage = Resources.FullStar;
                    break ;

                case 8:
                    pictureBox4.BackgroundImage = Resources.FullStar;
                    break ;

                case 10:
                    pictureBox5.BackgroundImage = Resources.FullStar;
                    break ;
            }
        }
       
        private  void IsMatch()
        {

            if (buttons[0].Tag == buttons[1].Tag)
            {
                Score += 2;
                UpdateStar();
                return ;
            }
            

            else
            {
                RestButton(buttons[0], "?");
                RestButton(buttons[1], "?");            
                return ;
            }

        }

        private async void ChangeImage(Button button)
        {
            
            if (button.Tag.ToString() == "?")
            {
                buttons.Add(button);

                if (button == btn1 || button == btn2)
                {
                    button.Tag = "1";
                    button.BackgroundImage = Resources._1;
                }

                else if(button == btn9 || button  == btn5)
                {
                    button.Tag = "2";
                    button.BackgroundImage = Resources._2;
                }

                else if(button == btn10  || button ==btn4)
                {
                    button.Tag = "3";
                    button.BackgroundImage = Resources._3;
                }

                else if(button ==btn7 || button ==btn3)
                {
                    button.Tag = "4";
                    button.BackgroundImage = Resources._4;
                }

                else if(button == btn6 || button == btn8)
                {
                    button.Tag = "5";
                    button.BackgroundImage = Resources._5;
                }
                
                if (buttons.Count == 2)
                {
                    await Task.Delay(1000);
                    IsMatch();
                    buttons.Clear();
                }

                
            }

            else
            {
                MessageBox.Show("Wronge Choice","Warn",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(Score==10)
            {
                timer1.Stop();
                DisableAllButtons();
                if (IsWin())
                {
                    MessageBox.Show("You won", "Congratulations", MessageBoxButtons.OK);
                }
            }
            
            
        }
        private void button_Click(object sender, EventArgs e)
        {            
            
            ChangeImage((Button)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Subtract(time2);


            if (time.Seconds <= 10 && time.Minutes ==0)
                lbTime.ForeColor = Color.Red;


            lbTime.Text = time.Minutes.ToString("D2") + ":" + time.Seconds.ToString("D2");

            if (time.Minutes == 0 && time.Seconds == 0)
            {
                timer1.Stop();
                DisableAllButtons();
                if (IsWin())
                {
                    MessageBox.Show("You won", "Congratulations", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("You lost", "Time's up", MessageBoxButtons.OK);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EnabledAllButtons();
            time = new TimeSpan(0, Convert.ToInt32(cbTimer.Text), 0);
            lbTime.Text = time.Minutes.ToString("D2") + ":" + time.Seconds.ToString("D2");
            GetSpeed();
            timer1.Start();
        }

        private void DisableAllButtons()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
        }

        private void EnabledAllButtons()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisableAllButtons();
        }
    }
}
