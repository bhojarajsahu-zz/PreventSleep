using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreventSleep
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        #region Prevent Lock
        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_SYSTEM_REQUIRED = 0x00000001,
            ES_DISPLAY_REQUIRED = 0x00000002,
            // Legacy flag, should not be used.
            // ES_USER_PRESENT   = 0x00000004,
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
        }
        public static class SleepUtil
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        }
        public void PreventSleep()
        {
            if (SleepUtil.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS
                | EXECUTION_STATE.ES_DISPLAY_REQUIRED
                | EXECUTION_STATE.ES_SYSTEM_REQUIRED
                | EXECUTION_STATE.ES_AWAYMODE_REQUIRED) == 0) //Away mode for Windows >= Vista
                SleepUtil.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS
                    | EXECUTION_STATE.ES_DISPLAY_REQUIRED
                    | EXECUTION_STATE.ES_SYSTEM_REQUIRED); //Windows < Vista, forget away mode
        }
        #endregion

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                PreventSleep();
                mouseMove();
                notifyIconPreventSleep.ShowBalloonTip(1000);
                this.Hide();
            }
            catch { }
        }
        public void mouseMove()
        {
            timer.Enabled = true;
        }
        private void notifyIconPreventSleep_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to deactivate it?", "Prevent Sleep For System", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
            catch { }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Height;
            int y = Screen.PrimaryScreen.WorkingArea.Width;

            Random random = new Random();
            int randomX = random.Next(0, x);

            //Random random = new Random();
            int randomY = random.Next(0, y);

            Cursor.Position = new Point(randomX, randomY);
        }
    }
}
