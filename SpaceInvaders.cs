using Space_Invaders.Classes;
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
    public partial class SpaceInvadersWindow : Form
    {

        #region Paramiters

        static int displayDimX = 60;

        static int displayDimY = 40;

        Display display;

        #endregion

        public SpaceInvadersWindow()
        {
            InitializeComponent();

            display = new Display(displayDimX,displayDimY);

            InitalizeUserDisplay(); 

           

        }

		#region Methods

		private void InitalizeUserDisplay()
        {
            userDisplay.Width = (displayDimX*2)-2;
            userDisplay.Height = (displayDimY*2)-2;
            userDisplay.Image = display.GetDisplayImage();

        }


		#endregion
	}
}
