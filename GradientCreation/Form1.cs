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

            label1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int width = 700;
            int height = 25;

            trackBar1.Width = width+26;
            trackBar1.Maximum = width-1;
            trackBar1.Visible = true;

            Color firstColor = firstColorLook.BackColor;
            Color secondColor = secondColorLook.BackColor;
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

            gradientPicture.Width = width;
            gradientPicture.Height = height;
            gradientPicture.Image = gradient;
        }

        private void FirstColorEnter_TextChanged(object sender, EventArgs e)
        {
            string firstColorText = firstColorEnter.Text;
            int pointIndex = firstColorText.IndexOf(',');
            if (pointIndex == -1)
            {
                return;
            }

            int red;
            if (!int.TryParse(firstColorText.Substring(0, pointIndex), out red))
            {
                return;
            }

            firstColorText = firstColorText.Substring(pointIndex + 1, firstColorText.Length - pointIndex - 1);
            pointIndex = firstColorText.IndexOf(',');
            if (pointIndex == -1)
            {
                return;
            }

            int green;
            if (!int.TryParse(firstColorText.Substring(0, pointIndex), out green))
            {
                return;
            }

            firstColorText = firstColorText.Substring(pointIndex + 1, firstColorText.Length - pointIndex - 1);

            int blue;
            if (!int.TryParse(firstColorText, out blue))
            {
                return;
            }

            firstColorLook.BackColor = Color.FromArgb(red, green, blue);
        }

        private void SecondColorEnter_TextChanged(object sender, EventArgs e)
        {
            string secondColorText = secondColorEnter.Text;
            int pointIndex = secondColorText.IndexOf(',');
            if (pointIndex == -1)
            {
                return;
            }

            int red;
            if (!int.TryParse(secondColorText.Substring(0, pointIndex), out red))
            {
                return;
            }
            

            secondColorText = secondColorText.Substring(pointIndex + 1, secondColorText.Length - pointIndex - 1);
            pointIndex = secondColorText.IndexOf(',');
            if (pointIndex == -1)
            {
                return;
            }

            int green;
            if (!int.TryParse(secondColorText.Substring(0, pointIndex), out green))
            {
                return;
            }

            secondColorText = secondColorText.Substring(pointIndex + 1, secondColorText.Length - pointIndex - 1);
            pointIndex = secondColorText.IndexOf(',');

            int blue;
            if (!int.TryParse(secondColorText, out blue))
            {
                return;
            }

            secondColorLook.BackColor = Color.FromArgb(red, green, blue);
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            Bitmap gradient = new Bitmap(gradientPicture.Image);
            var pixel = gradient.GetPixel(trackBar1.Value, 0);
            int red = pixel.R;
            int green = pixel.G;
            int blue = pixel.B;
            label1.Text = $"{red}, {green}, {blue}";
            label1.Location = new Point(trackBar1.Location.X + trackBar1.Value, label1.Location.Y);
        }
    }
}
