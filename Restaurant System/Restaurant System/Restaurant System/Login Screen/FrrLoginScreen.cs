using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClsUserBusinessLayer;
using ClsGlobalUserLayer;

namespace Restaurant_System.Login_Screen
{
    public partial class FrrLoginScreen : Form
    {
        public FrrLoginScreen()
        {
            InitializeComponent();
        }

        string Path = @"C:\Restaurant-System\Remember_Me\UserLoginInfo.txt";

        enum UserRole { Admin = 1 , Waiter = 2 , Chef = 3 , Manager = 4}
        UserRole _UserRole = UserRole.Chef;

        private void FrrLogin_Load(object sender, EventArgs e)
        {
            CheckRememberMe.Checked = false;

            tbUsername.MaxLength = 50;
            tbPassword.MaxLength = 255;

            cbRoles.Items.Add("Admin");
            cbRoles.Items.Add("Waiter");
            cbRoles.Items.Add("Chef");
            cbRoles.Items.Add("Manager");

            cbRoles.SelectedIndex = 2;

            if(File.Exists(Path))
            {
               string Content = File.ReadAllText(Path, Encoding.UTF8);

                string[] Contents = Content.Split('/');
                if(Content.Length > 0)
                {
                    tbUsername.Text = Contents[0];
                    tbPassword.Text = Contents[1];
                    cbRoles.SelectedItem = Contents[2];
                    CheckRememberMe.Checked = true;
                }
                else
                {
                    MessageBox.Show("Txt File Remember Me Is Empty", "File Is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Txt File Remember Me Not Exists", "File Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetUserRoleID()
        {
            switch(_UserRole)
            {
                case UserRole.Admin:
                    return 1;

                case UserRole.Waiter:
                    return 2;

                case UserRole.Chef:
                    return 3;

                case UserRole.Manager:
                    return 4;
            }

            return 3;
        }
        private string GetUserRoleName()
        {
            switch (_UserRole)
            {
                case UserRole.Admin:
                    return "Admin";

                case UserRole.Waiter:
                    return "Waiter";

                case UserRole.Chef:
                    return "Chef";

                case UserRole.Manager:
                    return "Manager";
            }

            return "Chef";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbUsername.Text.Trim()) || string.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                MessageBox.Show("Username/Password Is Empty", "Input Data Is Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(ClsUser.IsUserExistByUsername(tbUsername.Text))
            {
                if (ClsUser.IsUsernameAndPasswordCorrect(tbUsername.Text.Trim(), tbPassword.Text.Trim(), GetUserRoleID()))
                {
                    ClsGlobalUser.Username = tbUsername.Text.Trim();
                    ClsGlobalUser.Role = GetUserRoleName();

                    if (File.Exists(Path))
                    {
                        try
                        {
                            File.WriteAllText(Path, tbUsername.Text.Trim() + '/' + tbPassword.Text.Trim() + '/' + cbRoles.SelectedItem.ToString());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error Writing On File Remember Me: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show("File Path Remember Me Not Found", "Path Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    FrrDashboardScreen frr = new FrrDashboardScreen();
                    frr.ShowDialog();
                }
                else
                    MessageBox.Show("Username/Password Not Correct", "Data Not Correct", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoles.SelectedItem.ToString() == "Admin")
                _UserRole = UserRole.Admin;

            if (cbRoles.SelectedItem.ToString() == "Waiter")
                _UserRole = UserRole.Waiter;

            if (cbRoles.SelectedItem.ToString() == "Chef")
                _UserRole = UserRole.Chef;

            if (cbRoles.SelectedItem.ToString() == "Manager")
                _UserRole = UserRole.Manager;
        }
    }
}
