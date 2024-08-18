using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Classes
{
	internal class Display
	{
		int xDim;
		int yDim;

		RGB[,] pixelData;

		Bitmap display;
		
		public Display(int xDimention, int yDimention)
		{
			xDim = xDimention;
			yDim = yDimention;

			pixelData = new RGB[xDim, yDim];
			InitalizePixelData();

			display = new Bitmap((xDim * 2) - 2, (yDim * 2) - 2);
			InitalizeDisplay();

		}

		private void InitalizeDisplay()
		{

			for (int y = 0; y < display.Height; y++)
			{
				for (int x = 0; x < display.Width; x++) 
				{ display.SetPixel(x, y, Color.Black); }
			}
		}
		private void InitalizePixelData()
		{
			for (int y = 0; y < yDim; y++)
			{
				for (int x = 0; x < xDim; x++)
				{ pixelData[x, y] = new RGB(0, 0, 0); }
			}
		}

		public Bitmap GetDisplayImage() { return display; }


	}
}
