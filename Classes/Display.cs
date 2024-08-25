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

		//RGB[,] pixelData;
		int[,] pixelData;

        int pixSize = 3;
		int pixOffset = 1;

		int pixComplete;

		Bitmap display;
		
		public Display(int xDimention, int yDimention)
		{
			xDim = xDimention;
			yDim = yDimention;

			pixComplete = pixSize + pixOffset;

			//pixelData = new RGB[xDim, yDim];
			pixelData = new int[xDim, yDim];
			InitalizePixelData();

			display = new Bitmap((xDim * pixComplete) - pixOffset, (yDim * pixComplete) - pixOffset);
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
				//{ pixelData[x, y] = new RGB(0, 0, 0); }
				{ pixelData[x, y] = 0; }
			}
		}

		public Bitmap GetDisplayImage() { return display; }

		public void SetNewDisplayImageTest()
		{
			
			for (int y = 0; y < display.Height; y = y + pixComplete)
			{
				for (int x = 0; x < display.Width; x = x + pixComplete)
				{
					Color pixelColor = GetColorFromPixelData((x/pixComplete),(y/pixComplete));
					
					for (int pixY = 0; pixY < pixComplete; pixY++)
					{
						for (int pixX = 0; pixX < pixComplete; pixX++)
						{
							
								if (pixX < pixSize && pixY < pixSize)
								{ display.SetPixel((x + pixX), (y + pixY), pixelColor); }	
						
						}
					}
					
				
				
				}
			}

		}

		private Color GetColorFromPixelData(int pixelX,int pixelY)
		{

			switch(pixelData[pixelX,pixelY])
			{
				    case 0:return Color.DarkGray;
					case 1:return Color.Blue;
					case 2:return Color.Green;
					case 3:return Color.Red;
					case 4:return Color.Yellow;
					
				    default:return Color.White;
			}
			
		}
					
					

	}
}
