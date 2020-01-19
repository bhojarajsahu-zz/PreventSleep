namespace PreventSleep
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.notifyIconPreventSleep = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // notifyIconPreventSleep
            // 
            this.notifyIconPreventSleep.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconPreventSleep.BalloonTipText = "Prevent sleep activated.";
            this.notifyIconPreventSleep.BalloonTipTitle = "Prevent Sleep For System";
            this.notifyIconPreventSleep.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconPreventSleep.Icon")));
            this.notifyIconPreventSleep.Text = "Prevent sleep activated.";
            this.notifyIconPreventSleep.Visible = true;
            this.notifyIconPreventSleep.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconPreventSleep_MouseDoubleClick);
            // 
            // timer
            // 
            this.timer.Interval = 6000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 61);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 95);
            this.MinimumSize = new System.Drawing.Size(420, 95);
            this.Name = "Home";
            this.ShowInTaskbar = false;
            this.Text = "Prevent Sleep";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconPreventSleep;
        private System.Windows.Forms.Timer timer;
    }
}

