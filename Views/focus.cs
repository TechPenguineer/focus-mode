using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ocus_mode.Views
{
    public partial class focus : Form
    {
        public focus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void focus_Load(object sender, EventArgs e)
        {
            int currentTime=0;
            while(true)
            {
                Thread.Sleep(1000);
                currentTime += 1;
                string time = currentTime.ToString();
                elapsedTimeCounterLabel.Text = time;
            }
        }
    }
}
