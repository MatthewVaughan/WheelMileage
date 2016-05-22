using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab06
// Date: 01/26/2015 12:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab06
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User clicks and program closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exit button will exit the application
            this.Close();
        }

        /// <summary>
        /// User clicks and message box appears displaying coders info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About button will display my name class and Lab number
            MessageBox.Show("Matthew Vaughan\nCS1400\nLab #7");
        }
        
        //IGNORE
        private void txtWheelDiameter_TextChanged(object sender, EventArgs e)
        { }
        //IGNORE
        

        /// <summary>
        /// User clicks button to clear text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //btnClear clears previous data when clicked
            txtWheelDiameter.Text = "";
            txtTurnsPerMile.Text = "";
        }

        /// <summary>
        /// User inputs wheel diameter then event handler will output how many turns the wheel will make per mile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWheelDiameter_Leave(object sender, EventArgs e)
        {
            /* 1. Declares variables to hold data provided by the user
                a. wheelDiam- holds the diameter of wheel (double)
                b. wheelCircum - holds the circumference of wheel (double)
                c. wheelTurns - holds the number of rotations per miles (double)
                d. pI- Declared constant to avoid magic numbers
                e. inchMile- Declared constant to avoid magic numbers */

            const double pI = 3.14;
            const double inchMile = 63360;

            //2.User inputs diameter into txtWheelDiameter which translate to wheelDiam
            double wheelDiam = double.Parse(txtWheelDiameter.Text);

            //3.WheelCircum multiples wheelDiam by pI
            double wheelCircum = pI * wheelDiam;

            //4.wheelTurns finds how many turns it would take to travel 1 mile
            double wheelTurns = inchMile / wheelCircum;

            //5.Converts wheelTurns to string and displays in txtTurnsPerMile
            string outStr = $"{wheelTurns:N2}";
            txtTurnsPerMile.Text = outStr;

        }
    }
}
