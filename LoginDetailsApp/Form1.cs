using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDetailsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //## Series of if-else statements for not completing the form properly
            if ((firstNameTextBox.Text == "") && (lastnameTextBox.Text == ""))
            {
                errorMessage.Visible = false;
                errorMessage2.Visible = false;
                errorMessage3.Visible = false;
                errorMessage4.Visible = true;
            }
            else if (firstNameTextBox.Text == "")
            {
                errorMessage3.Visible = false;
                errorMessage.Visible = true;
                errorMessage2.Visible = false;
            }
            else if (lastnameTextBox.Text == "")
            {
                errorMessage4.Visible=false;    
                errorMessage3.Visible = true;
                errorMessage.Visible = false;
                errorMessage2.Visible = false;
            }
            else if (passwordLengthNumericUpDown.Value <= 4)
            {
                errorMessage3.Visible = false;
                errorMessage.Visible = false;
                errorMessage2.Visible = true;
                errorMessage4.Visible = false;
            }
            else
            {
                Random random = new Random();

                string firstname = firstNameTextBox.Text;
                string lastname = lastnameTextBox.Text;
                lastname = string.Concat(Convert.ToString(char.ToUpper(lastname[0])) + lastname.Substring(1));
                int passwordLength = Convert.ToInt32(passwordLengthNumericUpDown.Value);

                string letterFirstName = ConvertFirstNameToChar(firstname);
                string username = MergeTheNames(letterFirstName, lastname);

                string password = PasswordGenerator(passwordLength, random);

                usernameBox.Text = username;
                passwordBox.Text = password;


                firstNameTextBox.ReadOnly = true;
                lastnameTextBox.ReadOnly = true;
                passwordLengthNumericUpDown.ReadOnly = true;

                RevealControls();
            }
            
        }

        private void startAgainButton_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        //## Methods
        //## Resets the controls to normal and hides the bottom section
        public void ResetControls()
        {
            InfoLabel.Text = "";
            toolTip1.SetToolTip(passwordLengthNumericUpDown, "The minimum length is 5 letters long");

            usernameBox.Visible = false;
            passwordBox.Visible = false;

            errorMessage.Visible = false;
            errorMessage2.Visible = false;
            errorMessage3.Visible = false;
            errorMessage4.Visible = false;

            firstNameTextBox.Text = "";
            lastnameTextBox.Text = "";
            passwordLengthNumericUpDown.Value = 0;

            usernameLabel.Text = "";
            passwordLabel.Text = "";

            enterButton.Location = new Point(131, 228);
            startAgainButton.Visible = false;

            firstNameTextBox.ReadOnly = false;
            lastnameTextBox.ReadOnly = false;
            passwordLengthNumericUpDown.ReadOnly = false;

        }

        //## Reveals the bottom section and disables the top section
        public void RevealControls()
        {
            usernameBox.Visible = true;
            passwordBox.Visible = true;
            errorMessage.Visible = false;

            usernameLabel.Text = "Username:";
            passwordLabel.Text = "Password:";
            InfoLabel.Text = "* Make sure to store this information in a secure place *";

            enterButton.Location = new Point(52, 228);
            startAgainButton.Visible = true;

            errorMessage.Visible = false;
            errorMessage2.Visible = false;
            errorMessage3.Visible = false;
            errorMessage4.Visible = false;
        }

        //## To get the first letter of the firstname
        static string ConvertFirstNameToChar(string name)
        {
            //## To get the first letter, we need the index of the letter and convert it to a string
            string input = Convert.ToString(name[0]);
            input = input.ToLower();
            return input;
        }

        //## Creates the username
        static string MergeTheNames(string letter, string lastname)
        {
            string input = letter + lastname;
            return input;

        }

        //## Creates a password
        private static string PasswordGenerator(int length, Random random)
        {
            //## Needed variables
            string randomletters = " ";
            string randomNumbersAndSymbols = " ";
            string allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string allNumbers = "0123456789#$%&[]_?";

            //## If the length of the requested password is even e.g. 9, 13, 3
            if (length % 2 == 0)
            {
                for (int i = 0; i < (length / 2); i++)
                {
                    int randomNum = random.Next(0, allLetters.Length);
                    randomletters += allLetters[randomNum];
                }

                for (int i = 0; i < (length / 2); i++)
                {
                    int randomNum = random.Next(0, allNumbers.Length);
                    randomNumbersAndSymbols += allNumbers[randomNum];
                }
            }

            //## If the length of the requested password is odd e.g. 9, 13, 3
            if (length % 2 == 1)
            {
                for (int i = 0; i < ((length / 2) + 0.5); i++)
                {
                    int randomNum = random.Next(0, allLetters.Length);
                    randomletters += allLetters[randomNum];
                }

                for (int i = 0; i < ((length / 2) - 0.5); i++)
                {
                    int randomNum = random.Next(0, allNumbers.Length);
                    randomNumbersAndSymbols += allNumbers[randomNum];
                }
            }

            string randomPassword = randomletters + randomNumbersAndSymbols;
            return randomPassword.Replace(" ", "");
        }
    }
}
