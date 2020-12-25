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
        private string elapsedTimeShowType = "ELAPSED";

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
            resetElapsedTime();

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
            
            if (elapsedTimeShowType == "ELAPSED")
            {
                timeDiff = DateTime.Now - startDateTime;
            }
            else
            {
                timeDiff = startDateTime.AddHours(1) - DateTime.Now;
            }
            

            lblProcessedTime.Text = timeDiff.Hours.ToString().PadLeft(2, '0')
                + ':' + timeDiff.Minutes.ToString().PadLeft(2, '0')
                + ':' + timeDiff.Seconds.ToString().PadLeft(2, '0');
        }

        private void resetElapsedTime()
        {
            startDateTime = DateTime.Now;
        }

        private void lblCurrentTime_Click(object sender, EventArgs e)
        {
            resetElapsedTime();
        }

        private void lblProcessedTime_Click(object sender, EventArgs e)
        {
            if (elapsedTimeShowType == "ELAPSED")
            {
                elapsedTimeShowType = "REMAINED";
            }
            else
            {
                elapsedTimeShowType = "ELAPSED";
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
    }
}
