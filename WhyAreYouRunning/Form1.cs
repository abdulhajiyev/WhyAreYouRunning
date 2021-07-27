using System;
using System.Drawing;
using System.Windows.Forms;

namespace WhyAreYouRunning
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void imageButton_MouseHover(object sender, EventArgs e)
        {
            
            int randomX = random.Next(this.Width-50);
            int randomY = random.Next(30,this.Height-50);

            imageButton.Location = new Point(randomX, randomY);
            locInfo.Text = imageButton.Location.ToString();
        }
    }
}
