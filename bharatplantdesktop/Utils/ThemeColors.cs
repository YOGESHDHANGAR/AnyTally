using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace bharatplantdesktop.Utils
{
    public static class ThemeColors
    {

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }

        public static Color pnlMenuClr = Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(102)))), ((int)(((byte)(244)))));


        public static Color color1 = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
        public static Color color2 = Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
        public static Color color3 = Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
        public static Color color4 = Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
        public static Color color5 = Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(199)))), ((int)(((byte)(202)))));
        public static Color color6 = Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

        public static void SetColumnWidthsInPercentage(DataGridView dataGridView, params int[] percentages)
        {
            if (dataGridView == null || percentages == null || dataGridView.Columns.Count != percentages.Length)
            {
                return; // Invalid input, do nothing
            }

            int totalWidth = dataGridView.ClientSize.Width - dataGridView.RowHeadersWidth;
            int totalPercentage = percentages.Sum();
            int totalWidthCalculated = 0;

            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                int width = totalWidth * percentages[i] / totalPercentage;
                dataGridView.Columns[i].Width = width;
                totalWidthCalculated += width;
            }

            // Set the width of the last column to fill the remaining space and handle rounding errors
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

    }
}
