using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Space_Invaders
{
    public partial class SpaceInvaders : Form
    {

        #region Paramiters

        static int xDim = 600;
        static int yDim = 400;

        Bitmap backround = new Bitmap(xDim, yDim);

        Color backroundColor = Color.Black;

        #endregion

        public SpaceInvaders()
        {
            InitializeComponent();

            // Prepare The BLack Background BitMap

            DrawBackground();

            //Define The Picture Box Dimentions = To Bitmap.
            //And Display Backgroun(black) Image On Startup.

            display.Width = xDim;
            display.Height = yDim;
            display.Image = backround;

        }

        #region Methods

        public void DrawBackground()
        {
            for (int x = 0; x < xDim; x++)
            {
                for (int y = 0; y < yDim; y++)
                {
                    backround.SetPixel(x, y, backroundColor);
                }
            }
        }

        #endregion
    }
}
