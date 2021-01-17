
namespace IntervalTimer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblProcessedTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.trackBarOpacity.AutoSize = false;
            this.trackBarOpacity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBarOpacity.Location = new System.Drawing.Point(0, 103);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 10;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(211, 19);
            this.trackBarOpacity.SmallChange = 10;
            this.trackBarOpacity.TabIndex = 0;
            this.trackBarOpacity.TabStop = false;
            this.trackBarOpacity.TickFrequency = 10;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Value = 100;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            this.trackBarOpacity.MouseLeave += new System.EventHandler(this.trackBarOpacity_MouseLeave);
            this.trackBarOpacity.MouseHover += new System.EventHandler(this.trackBarOpacity_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblProcessedTime
            // 
            this.lblProcessedTime.AutoSize = true;
            this.lblProcessedTime.Font = new System.Drawing.Font("굴림", 30F);
            this.lblProcessedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblProcessedTime.Location = new System.Drawing.Point(13, 9);
            this.lblProcessedTime.Name = "lblProcessedTime";
            this.lblProcessedTime.Size = new System.Drawing.Size(181, 40);
            this.lblProcessedTime.TabIndex = 1;
            this.lblProcessedTime.Text = "99:99:99";
            this.lblProcessedTime.Click += new System.EventHandler(this.lblProcessedTime_Click);
            this.lblProcessedTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.lblProcessedTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblProcessedTime.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lblProcessedTime_PreviewKeyDown);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("굴림", 30F);
            this.lblCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCurrentTime.Location = new System.Drawing.Point(13, 56);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(181, 40);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "99:99:99";
            this.lblCurrentTime.Click += new System.EventHandler(this.lblCurrentTime_Click);
            this.lblCurrentTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.lblCurrentTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(218, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(211, 122);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblProcessedTime);
            this.Controls.Add(this.trackBarOpacity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblProcessedTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnExit;
    }
}

