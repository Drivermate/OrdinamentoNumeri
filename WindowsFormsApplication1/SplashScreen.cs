using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SplashScreen : Form
    {
        Form1 a = new Form1();

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {            
            timeleft = 20;
            timer1.Start();
            a.Show();
        }

        private int timeleft { get; set; }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0) timeleft -= 1;
            else
            {
                timer1.Stop();                
                this.Hide();
            }
        }
    }
}
