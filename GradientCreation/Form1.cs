using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradientCreation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int width = 500;
            int height = 200;

            Color firstColor = Color.Red;
            Color secondColor = Color.White;
            Color currentColor = firstColor;

            double colorChangeIndexR = (double)(secondColor.R - firstColor.R) / (double)width;
            double colorChangeIndexG = (double)(secondColor.G - firstColor.G) / (double)width;
            double colorChangeIndexB = (double)(secondColor.B - firstColor.B) / (double)width;

            double currentR = firstColor.R;
            double currentG = firstColor.G;
            double currentB = firstColor.B;

            Bitmap gradient = new Bitmap(width, height);
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    gradient.SetPixel(j, i, currentColor);
                }

                currentR += colorChangeIndexR;
                currentG += colorChangeIndexG;
                currentB += colorChangeIndexB;

                int red = (int)currentR;
                int green = (int)currentG;
                int blue = (int)currentB;

                currentColor = Color.FromArgb(red, green, blue);
            }

            PictureBox gradientPicture = new PictureBox();
            gradientPicture.Width = width;
            gradientPicture.Height = height;
            gradientPicture.Image = gradient;

            this.Controls.Add(gradientPicture);
        }
    }
}
