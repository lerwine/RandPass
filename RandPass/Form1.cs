using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RandPass
{
    public partial class RandPassForm : Form
    {
        public RandPassForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTypeComboBox.SelectedIndex = 0;
            Splash myDlg = new Splash();
            myDlg.ShowDialog();
        }
        private void generatePassword()
        {
            int nPassLen;
            int c;
            Random r = new Random();
            string strPassword;
            string[] strUcChars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", 
                "R", "S", "T", "U", "Z", "W", "X", "Y", "Z" };
            string[] strLcChars = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "u", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] strNumberChars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            string[] strPhoneChars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "*", "#" };
            string[] strSpecialChars = new string[] { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=",
                "{", "}", "|", "[", "]", ":", "\"", ";", "'", "<", ">", "?", ",", ".", "/" };
            int nPassCharIdx;

            do
            {
                int nCaps = 0;
                int nDigits = 0;
                int nSpec = 0;
                string[] ucChars = (string[])strUcChars.Clone();
                string[] lcChars = (string[])strLcChars.Clone();
                string[] numberChars = (string[])strNumberChars.Clone();
                string[] specialChars = (string[])strSpecialChars.Clone();
                strPassword = "";

                if (maxPassLenUpDown.Value == minPassLenUpDown.Value)
                {
                    nPassLen = (int)maxPassLenUpDown.Value;
                }
                else
                {
                    nPassLen = r.Next((int)minPassLenUpDown.Value, (int)maxPassLenUpDown.Value);
                }

                for (c = 0; c < nPassLen; c++)
                {
                    int rVal;
                    switch (passwordTypeComboBox.SelectedIndex)
                    {
                        case 1:
                            rVal = r.Next(15) + 1;
                            break;
                        case 2:
                            rVal = -1;
                            break;
                        case 3:
                            rVal = 3;
                            break;
                        default:
                            rVal = r.Next(16);
                            break;
                    }
                    switch (rVal)
                    {
                        case -1:
                            do
                            {
                                nPassCharIdx = r.Next(strPhoneChars.Length);
                            } while (strPhoneChars[nPassCharIdx] == "");
                            strPassword += strPhoneChars[nPassCharIdx];
                            strPhoneChars[nPassCharIdx] = "";
                            break;
                        case 0:
                            nSpec++;
                            if (nSpec > (int)maxSpecUpDown.Value)
                            {
                                c--;
                                break;
                            }
                            do
                            {
                                nPassCharIdx = r.Next(specialChars.Length);
                            } while (specialChars[nPassCharIdx] == "");
                            strPassword += specialChars[nPassCharIdx];
                            specialChars[nPassCharIdx] = "";
                            break;
                        case 1:
                        case 2:
                            nCaps++;
                            if (nCaps > (int)maxCapsUpDown.Value)
                            {
                                c--;
                                break;
                            }
                            do
                            {
                                nPassCharIdx = r.Next(ucChars.Length);
                            } while (ucChars[nPassCharIdx] == "");
                            strPassword += ucChars[nPassCharIdx];
                            ucChars[nPassCharIdx] = "";
                            break;
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            if (passwordTypeComboBox.SelectedIndex != 3)
                            {
                                nDigits++;
                                if (nDigits > (int)maxDigitsUpDown.Value)
                                {
                                    c--;
                                    break;
                                }
                            }
                            do
                            {
                                nPassCharIdx = r.Next(numberChars.Length);
                            } while (numberChars[nPassCharIdx] == "");
                            strPassword += numberChars[nPassCharIdx];
                            numberChars[nPassCharIdx] = "";
                            break;
                        default:
                            do
                            {
                                nPassCharIdx = r.Next(lcChars.Length);
                            } while (lcChars[nPassCharIdx] == "");
                            strPassword += lcChars[nPassCharIdx];
                            lcChars[nPassCharIdx] = "";
                            break;
                    }
                }
            } while (passwordTypeComboBox.SelectedIndex < 2 && (!Regex.IsMatch(strPassword, "[A-Z]") || 
                    !Regex.IsMatch(strPassword, "[0-9]") || (passwordTypeComboBox.SelectedIndex == 0 && 
                    !Regex.IsMatch(strPassword, 
                    "[\\~\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)_\\+\\-\\=\\{\\}\\|\\[\\]\\:\\\"\\;\\'\\<\\>\\?\\,\\.\\/]"))));
            r = null;
            passwordTextBox.ReadOnly = false;
            passwordTextBox.Text = strPassword;
            passwordTextBox.ReadOnly = true;
        }

        private void regenerateButton_Click(object sender, EventArgs e)
        {
            generatePassword();
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordTextBox.Text);
        }

        private void minPassLenUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (minPassLenUpDown.Value > maxPassLenUpDown.Value)
                maxPassLenUpDown.Value = minPassLenUpDown.Value;
        }

        private void maxPassLenUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (minPassLenUpDown.Value > maxPassLenUpDown.Value)
                minPassLenUpDown.Value = maxPassLenUpDown.Value;
            if (maxCapsUpDown.Value > maxPassLenUpDown.Value)
                maxCapsUpDown.Value = maxPassLenUpDown.Value;
            if (maxDigitsUpDown.Value > maxPassLenUpDown.Value)
                maxDigitsUpDown.Value = maxPassLenUpDown.Value;
            if (maxSpecUpDown.Value > maxPassLenUpDown.Value)
                maxSpecUpDown.Value = maxPassLenUpDown.Value;
        }

        private void passwordTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (passwordTypeComboBox.SelectedIndex)
            {
                case 1:
                    if (maxPassLenUpDown.Value < 6) maxPassLenUpDown.Value = 6;
                    if (minPassLenUpDown.Value < 6) minPassLenUpDown.Value = 6;
                    maxPassLenUpDown.Maximum = 16;
                    maxPassLenUpDown.Minimum = 6;
                    minPassLenUpDown.Maximum = 16;
                    minPassLenUpDown.Minimum = 6;
                    maxDigitsUpDown.Enabled = true;
                    maxCapsUpDown.Enabled = true;
                    maxSpecUpDown.Enabled = false;
                    break;
                case 2:
                    if (maxPassLenUpDown.Value > 12) maxPassLenUpDown.Value = 12;
                    maxPassLenUpDown.Maximum = 12;
                    maxPassLenUpDown.Minimum = 3;
                    minPassLenUpDown.Maximum = 12;
                    minPassLenUpDown.Minimum = 3;
                    maxDigitsUpDown.Enabled = false;
                    maxCapsUpDown.Enabled = false;
                    maxSpecUpDown.Enabled = false;
                    break;
                case 3:
                    if (maxPassLenUpDown.Value > 10) maxPassLenUpDown.Value = 10;
                    maxPassLenUpDown.Maximum = 10;
                    maxPassLenUpDown.Minimum = 3;
                    minPassLenUpDown.Maximum = 10;
                    minPassLenUpDown.Minimum = 3;
                    maxDigitsUpDown.Enabled = false;
                    maxCapsUpDown.Enabled = false;
                    maxSpecUpDown.Enabled = false;
                    break;
                default:
                    if (minPassLenUpDown.Value < 6) minPassLenUpDown.Value = 6;
                    maxPassLenUpDown.Maximum = 16;
                    maxPassLenUpDown.Minimum = 6;
                    minPassLenUpDown.Maximum = 16;
                    minPassLenUpDown.Minimum = 6;
                    maxDigitsUpDown.Enabled = true;
                    maxCapsUpDown.Enabled = true;
                    maxSpecUpDown.Enabled = true;
                    break;
            }
            generatePassword();
        }

        private void copyToClipboardButton_MouseUp(object sender, MouseEventArgs e)
        {
            copyToClipboardButton.ImageIndex = 1;
        }

        private void copyToClipboardButton_MouseEnter(object sender, EventArgs e)
        {
            copyToClipboardButton.ImageIndex = 1;
        }

        private void copyToClipboardButton_MouseLeave(object sender, EventArgs e)
        {
            copyToClipboardButton.ImageIndex = 0;
        }
        private void copyToClipboardButton_MouseDown(object sender, MouseEventArgs e)
        {
            copyToClipboardButton.ImageIndex = 2;
        }

        private void regenerateButton_MouseUp(object sender, MouseEventArgs e)
        {
            regenerateButton.ImageIndex = 4;
        }

        private void regenerateButton_MouseEnter(object sender, EventArgs e)
        {
            regenerateButton.ImageIndex = 4;
        }

        private void regenerateButton_MouseLeave(object sender, EventArgs e)
        {
            regenerateButton.ImageIndex = 3;
        }

        private void regenerateButton_MouseDown(object sender, MouseEventArgs e)
        {
            regenerateButton.ImageIndex = 5;
        }
    }
}