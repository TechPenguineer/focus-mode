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
        System.Threading.Thread t;
        public String time;

        public focus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void updateTimer()
        {
           int currentTime=0;
           while(true)
            {
                currentTime += 1;
                time = currentTime.ToString();
              }
        }

        private async void focus_Load(object sender, EventArgs e)
        {
            while(true)
            {
                await Task.Delay(1000);
                updateTimer();
                elapsedTimeCounterLabel.Text = $"You have been in Focus Mode For: {time} seconds";
            }

        }
    }
}
