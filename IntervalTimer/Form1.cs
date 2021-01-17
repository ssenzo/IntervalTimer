using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTimer
{
    public partial class Form1 : Form
    {
        private Point mousePoint;
        private DateTime startDateTime;
        private DateTime lastPauseTime;
        private TimeSpan totalPauseTime;
        private bool paused;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            this.Text = trackBarOpacity.Value.ToString();
            this.Opacity = trackBarOpacity.Value/100.0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CancelButton = btnExit;
            paused = false;


            resetElapsedTime();

            trackBarOpacity.Value = 60;
            this.Opacity = 0.6;

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 
                                        Screen.PrimaryScreen.Bounds.Height - this.Height);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");

            TimeSpan timeDiff;

            timeDiff = DateTime.Now - startDateTime;

            if (paused == true)
            {
                DateTime tempNow = DateTime.Now;
                totalPauseTime = totalPauseTime.Add(tempNow - lastPauseTime);
                lastPauseTime = tempNow;                
            }

            timeDiff = timeDiff.Add(-totalPauseTime);

            lblProcessedTime.Text = timeDiff.Hours.ToString().PadLeft(2, '0')
                + ':' + timeDiff.Minutes.ToString().PadLeft(2, '0')
                + ':' + timeDiff.Seconds.ToString().PadLeft(2, '0');
        }

        private void resetElapsedTime()
        {
            startDateTime = DateTime.Now;
            totalPauseTime = startDateTime - startDateTime;
            timer1.Enabled = true;
        }

        private void lblCurrentTime_Click(object sender, EventArgs e)
        {
            resetElapsedTime();
        }

        private void lblProcessedTime_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                paused = true;
                lastPauseTime = DateTime.Now;
            }
            else
            {
                paused = false;
            }
            
            
        }

        private void trackBarOpacity_MouseUp(object sender, MouseEventArgs e)
        {
            lblCurrentTime.Focus();
        }

        private void trackBarOpacity_KeyUp(object sender, KeyEventArgs e)
        {
           lblCurrentTime.Focus();
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void trackBarOpacity_MouseLeave(object sender, EventArgs e)
        {
            lblCurrentTime.Focus();
        }

        private void trackBarOpacity_MouseHover(object sender, EventArgs e)
        {
            trackBarOpacity.Focus();
        }

        private void lblProcessedTime_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Space:
                    if (timer1.Enabled == false) timer1.Enabled = true;
                    else timer1.Enabled = false;
                    break;
                case Keys.Enter:
                    resetElapsedTime();
                    break;
                    
                default:
                    break;
            }
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}