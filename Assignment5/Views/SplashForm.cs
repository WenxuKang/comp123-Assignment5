using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5.Views
{
    public partial class SplashForm : Form
    {

        private Timer time;
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            time = new Timer();
            time.Interval = 3 * 1000;
            time.Tick += new EventHandler(SplashTimer_Tick);
            time.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            time.Stop();
            StartForm main = new StartForm();
            main.Show();
            this.Hide();
        }
    }
}
