using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_project
{
    public partial class PingPong : Form
    {

        private int _speedVer = 5, _speedHor = 5, _platformSpeed = 15, _score = 0;

        

        public PingPong()
        {
            InitializeComponent();


        }
        private void PingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if((e.KeyCode == Keys.A || e.KeyCode == Keys.Left) && Platform.Left > GamePanel.Left)
            {
                Platform.Left -= _platformSpeed;

            }
            else if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) && Platform.Right < GamePanel.Right)
            {
                Platform.Left += _platformSpeed;

            }
            else if(e.KeyCode == Keys.R && !timer.Enabled)
            {
                Random rnd = new Random();
                Ball.Top = rnd.Next(20, 300);
                Ball.Left = rnd.Next(20, 500);
                _score = 0;
                LabelLose.Visible = false;
                Score.Text = "Score : 0";
                timer.Enabled = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Ball.Left -= _speedHor;
            Ball.Top -= _speedVer;

            if (Ball.Top <= GamePanel.Top)
                _speedVer *= -1;
            if (Ball.Bottom >= GamePanel.Bottom)
            { 
                timer.Enabled = false;
                LabelLose.Visible = true;
            }
            if (Ball.Right <= GamePanel.Right)
                _speedHor *= -1;
            if (Ball.Left >= GamePanel.Left)
                _speedHor *= -1;
            if (Ball.Bottom >= Platform.Top && Ball.Left >= Platform.Left && Ball.Right <= Platform.Right) 
            {
                _speedVer *= -1;
                _score++;
                Score.Text = "Score : " + _score;
                Random random = new Random();
                GamePanel.BackColor = Color.FromArgb(random.Next(150, 255), random.Next(150, 255), random.Next(150, 255));
            }
                

        }

    }
}
