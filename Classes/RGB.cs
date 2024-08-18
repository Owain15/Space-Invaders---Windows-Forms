using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders.Classes
{
	internal class RGB
	{
		int Red;
		int Green;
		int Blue;

		public RGB() 
		{ 
		    Red = 0;
			Green = 0;
			Blue = 0;
		}
		public RGB(int red, int green, int blue)
		{
			Red = ValidateInput(red);
			Green = ValidateInput(green);
			Blue = ValidateInput(blue);
		}

		private int ValidateInput(int input)
		{
			if(input > -1 && input < 250) { return input; }
			else if (input < 0 )
			{ 
				Console.WriteLine("Invalid RGB. Value To Small");
				return 0;
			}
			else if (input > 250 )
			{
				Console.WriteLine("Invalid RGB. Value To Large");
				return 250;
			}
			else
			{
				Console.WriteLine($"Invalid RGB. Error Undiagnosed.\nInput:{input}.");
				return 0;
			}
		}

		public void SetRGB(int red, int green, int blue)
		{
			Red = ValidateInput(red);
			Green = ValidateInput(green);
			Blue = ValidateInput(blue);
		}
	}
}
