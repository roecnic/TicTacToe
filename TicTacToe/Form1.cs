﻿using System;
using System.Windows.Forms;

namespace TicTacToe {
    public partial class TicTacToeForm : Form {

        private int turnCounter = 0;

        public TicTacToeForm () {
            InitializeComponent();
        }

        private void btnUpperLeft_Click (object sender, EventArgs e) {
            btnUpperLeft.Text = SetPlayerValue(btnUpperLeft.Text);
            RoundIsOver();
        }

        private void btnUpperMid_Click (object sender, EventArgs e) {
            btnUpperMid.Text = SetPlayerValue(btnUpperMid.Text);
            RoundIsOver();
        }

        private void btnUpperRight_Click (object sender, EventArgs e) {
            btnUpperRight.Text = SetPlayerValue(btnUpperRight.Text);
            RoundIsOver();
        }

        private void btnMidLeft_Click (object sender, EventArgs e) {
            btnMidLeft.Text = SetPlayerValue(btnMidLeft.Text);
            RoundIsOver();
        }

        private void btnMidMid_Click (object sender, EventArgs e) {
            btnMidMid.Text = SetPlayerValue(btnMidMid.Text);
            RoundIsOver();
        }

        private void btnMidRight_Click (object sender, EventArgs e) {
            btnMidRight.Text = SetPlayerValue(btnMidRight.Text);
            RoundIsOver();
        }

        private void btnLowerLeft_Click (object sender, EventArgs e) {
            btnLowerLeft.Text = SetPlayerValue(btnLowerLeft.Text);
            RoundIsOver();
        }

        private void btnLowerMid_Click (object sender, EventArgs e) {
            btnLowerMid.Text = SetPlayerValue(btnLowerMid.Text);
            RoundIsOver();
        }

        private void btnLowerRight_Click (object sender, EventArgs e) {
            btnLowerRight.Text = SetPlayerValue(btnLowerRight.Text);
            RoundIsOver();
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


        private String SelectWinner () {
            if (!btnUpperLeft.Text.Equals("") && btnUpperLeft.Text.Equals(btnUpperMid.Text) && btnUpperLeft.Text.Equals(btnUpperRight.Text)) {
                return "win for " + btnUpperLeft.Text;
            } else if (!btnUpperLeft.Text.Equals("") && btnUpperLeft.Text.Equals(btnMidLeft.Text) && btnUpperLeft.Text.Equals(btnLowerLeft.Text)) {
                return "win for " + btnUpperLeft.Text;
            } else if (!btnUpperLeft.Text.Equals("") && btnUpperLeft.Text.Equals(btnMidMid.Text) && btnUpperLeft.Text.Equals(btnLowerRight.Text)) {
                return "win for " + btnUpperLeft.Text;
            } else if (!btnLowerRight.Text.Equals("") && btnLowerRight.Text.Equals(btnLowerMid.Text) && btnLowerRight.Text.Equals(btnLowerLeft.Text)) {
                return "win for " + btnLowerRight.Text;
            } else if (!btnLowerRight.Text.Equals("") && btnLowerRight.Text.Equals(btnMidRight.Text) && btnLowerRight.Text.Equals(btnUpperRight.Text)) {
                return "win for " + btnLowerRight.Text;
            } else if (!btnMidLeft.Text.Equals("") && btnMidLeft.Text.Equals(btnMidMid.Text) && btnMidLeft.Text.Equals(btnMidRight.Text)) {
                return "win for " + btnMidLeft.Text;
            } else if (!btnLowerLeft.Text.Equals("") && btnLowerLeft.Text.Equals(btnMidMid.Text) && btnLowerLeft.Text.Equals(btnUpperRight.Text)) {
                return "win for " + btnLowerLeft.Text;
            } else if (!btnUpperMid.Text.Equals("") && btnUpperMid.Text.Equals(btnMidMid.Text) && btnUpperMid.Text.Equals(btnLowerMid.Text)) {
                return "win for " + btnUpperMid.Text;
            } else if (turnCounter > 8) {
                return "draw";
            }

            return "null";
        }

        private void RoundIsOver () {
            var winner = SelectWinner();
            if (!winner.Equals("null")) {
                var result = MessageBox.Show("It is a " + winner + "!" + '\n' + '\n' +
                    "Start again?", "Congratulations!", MessageBoxButtons.YesNo);

                switch (result) {
                    case DialogResult.Yes:
                        btnUpperLeft.Text = "";
                        btnUpperMid.Text = "";
                        btnUpperRight.Text = "";
                        btnMidLeft.Text = "";
                        btnMidMid.Text = "";
                        btnMidRight.Text = "";
                        btnLowerLeft.Text = "";
                        btnLowerMid.Text = "";
                        btnLowerRight.Text = "";

                        turnCounter = 0;
                        break;

                    case DialogResult.No:
                        this.Close();
                        break;
                }
            }
        }
    }
}
