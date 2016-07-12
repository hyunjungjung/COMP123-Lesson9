using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Lesson9
{
    public partial class LoginForm : Form
    {
        /**
         * <summary>
         * This is the default constructor for the LoginForm Class
         * </summary>
         * @constructor LoginForm
         */
        public LoginForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method clears the UsernameTextBox and the PasswordTextBox
         * </summary>
         * 
         * @private
         * @method _clearForm
         * @returns {void}
         */
        private void _clearForm()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
        }

        /**
         * <summary>
         * This is the LoginButton Click event handler
         * </summary>
         * 
         * @private
         * @method LoginButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         * @return {void}
         */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Username: " + UsernameTextBox.Text);
            Debug.WriteLine("Password: " + PasswordTextBox.Text);
            this._clearForm();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("text changed");
        }

        private void UsernameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length < 6)
            {
                UsernameTextBox.Focus();
                UsernameTextBox.SelectAll();
                MessageLabe.Text = "Username too short";
                MessageLabe.ForeColor = Color.Red;
            }
            else 
            {
                MessageLabe.Text = "Pleae Login";
                MessageLabe.ForeColor = Color.Black;
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.Length < 6)
            {
                PasswordTextBox.Focus();
                PasswordTextBox.SelectAll();
                MessageLabe.Text = "Password too short";
                MessageLabe.ForeColor = Color.Red;
            }
            else
            {
                MessageLabe.Text = "Please Login";
                MessageLabe.ForeColor = Color.Black;
            }
            LoginButton.Enabled = true;
        }
    }
}
