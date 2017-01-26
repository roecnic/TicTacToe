using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class Form1 : Form {

        private int turnCounter = 0;

        public Form1 () {
            InitializeComponent();
        }

        private void btnUpperLeft_Click (object sender, EventArgs e) {
            btnUpperLeft.Text = SetPlayerValue(btnUpperLeft.Text);
        }

        private void btnUpperMid_Click (object sender, EventArgs e) {
            btnUpperMid.Text = SetPlayerValue(btnUpperMid.Text);
        }

        private void btnUpperRight_Click (object sender, EventArgs e) {
            btnUpperRight.Text = SetPlayerValue(btnUpperRight.Text);
        }

        private void btnMidLeft_Click (object sender, EventArgs e) {
            btnMidLeft.Text = SetPlayerValue(btnMidLeft.Text);
        }

        private void btnMidMid_Click (object sender, EventArgs e) {
            btnMidMid.Text = SetPlayerValue(btnMidMid.Text);
        }

        private void btnMidRight_Click (object sender, EventArgs e) {
            btnMidRight.Text = SetPlayerValue(btnMidRight.Text);
        }

        private void btnLowerLeft_Click (object sender, EventArgs e) {
            btnLowerLeft.Text = SetPlayerValue(btnLowerLeft.Text);
        }

        private void btnLowerMid_Click (object sender, EventArgs e) {
            btnLowerMid.Text = SetPlayerValue(btnLowerMid.Text);
        }

        private void btnLowerRight_Click (object sender, EventArgs e) {
            btnLowerRight.Text = SetPlayerValue(btnLowerRight.Text);
        }


        private String SetPlayerValue (String pCurrentButtonText) {
            if (!pCurrentButtonText.Equals("")) {
                return pCurrentButtonText;
            }

            switch (turnCounter) {
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                    turnCounter++;
                    return "X";

                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    turnCounter++;
                    return "O";

                default:
                    return "";
            }
        }
    }
}
