using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oop
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost;database=NaveedZahir;user=root;password=wc2028aus@naveed;";

        // Containers
        private Panel leftPanel;
        private Panel rightPanel;
        private Panel loginContainer;
        private Panel signupContainer;

        // Login Controls
        private TextBox txtId, txtName, txtPass;
        // Signup Controls
        private TextBox txtNewId, txtNewName, txtNewPass, txtConfirmPass;

        public Form1()
        {
            this.Text = "TradeVision — Stock Intelligence Platform";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(10, 15, 30);

            BuildLeftPanel();
            BuildRightPanel();

            // Show Login by default
            ShowLoginView();
        }

        private void BuildLeftPanel()
        {
            leftPanel = new Panel { Size = new Size(370, 600), Location = new Point(0, 0), BackColor = Color.FromArgb(6, 16, 32) };
            this.Controls.Add(leftPanel);

            // (Your existing Logo and Tagline code goes here...)
            Label logo = new Label { Text = "TRADE VISION", ForeColor = Color.White, Font = new Font("Segoe UI", 14, FontStyle.Bold), Location = new Point(40, 40), AutoSize = true };
            leftPanel.Controls.Add(logo);
        }

        private void BuildRightPanel()
        {
            rightPanel = new Panel { Size = new Size(530, 600), Location = new Point(370, 0), BackColor = Color.FromArgb(7, 13, 26) };
            this.Controls.Add(rightPanel);

            BuildLoginView();
            BuildSignupView();
        }

        private void BuildLoginView()
        {
            loginContainer = new Panel { Size = rightPanel.Size, Location = new Point(0, 0), Visible = true };
            rightPanel.Controls.Add(loginContainer);

            AddHeader(loginContainer, "Welcome Back", "Sign in to your account");

            txtId = CreateInput(loginContainer, "USER ID", 160, "Enter ID");
            txtName = CreateInput(loginContainer, "NAME", 240, "Enter Name");
            txtPass = CreateInput(loginContainer, "PASSWORD", 320, "••••••", true);

            Button btnLogin = new Button { Text = "LOGIN", Size = new Size(400, 45), Location = new Point(60, 400), BackColor = Color.FromArgb(0, 200, 85), FlatStyle = FlatStyle.Flat, ForeColor = Color.White };
            btnLogin.Click += LoginButton_Click;
            loginContainer.Controls.Add(btnLogin);

            Label lnkToSignup = new Label { Text = "Don't have an account? Sign Up", ForeColor = Color.Gray, Location = new Point(60, 460), AutoSize = true, Cursor = Cursors.Hand };
            lnkToSignup.Click += (s, e) => ShowSignupView();
            loginContainer.Controls.Add(lnkToSignup);
        }

        private void BuildSignupView()
        {
            signupContainer = new Panel { Size = rightPanel.Size, Location = new Point(0, 0), Visible = false };
            rightPanel.Controls.Add(signupContainer);

            AddHeader(signupContainer, "Create Account", "Join the TradeVision platform");

            txtNewId = CreateInput(signupContainer, "USER ID", 140, "Choose an ID");
            txtNewName = CreateInput(signupContainer, "NAME", 210, "Your full name");
            txtNewPass = CreateInput(signupContainer, "PASSWORD", 280, "••••••", true);
            txtConfirmPass = CreateInput(signupContainer, "CONFIRM PASSWORD", 350, "••••••", true);

            Button btnSignup = new Button { Text = "CREATE ACCOUNT", Size = new Size(400, 45), Location = new Point(60, 420), BackColor = Color.FromArgb(0, 120, 215), FlatStyle = FlatStyle.Flat, ForeColor = Color.White };
            btnSignup.Click += SignupButton_Click;
            signupContainer.Controls.Add(btnSignup);

            Label lnkToLogin = new Label { Text = "Already have an account? Login", ForeColor = Color.Gray, Location = new Point(60, 480), AutoSize = true, Cursor = Cursors.Hand };
            lnkToLogin.Click += (s, e) => ShowLoginView();
            signupContainer.Controls.Add(lnkToLogin);
        }

        // --- Logic Methods ---

        private void ShowLoginView() { loginContainer.Visible = true; signupContainer.Visible = false; }
        private void ShowSignupView() { loginContainer.Visible = false; signupContainer.Visible = true; }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match!"); return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Check if ID exists
                    string check = "SELECT COUNT(*) FROM Users WHERE Id=@id";
                    MySqlCommand checkCmd = new MySqlCommand(check, con);
                    checkCmd.Parameters.AddWithValue("@id", txtNewId.Text);
                    if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                    {
                        MessageBox.Show("ID already taken!"); return;
                    }

                    // Insert User
                    string query = "INSERT INTO Users (Id, Username, Password) VALUES (@id, @name, @pass)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtNewId.Text);
                    cmd.Parameters.AddWithValue("@name", txtNewName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtNewPass.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Created! Please Login.");
                    ShowLoginView();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Id=@id AND Username=@name AND Password=@pass";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                    if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                        MessageBox.Show("Welcome " + txtName.Text);
                    else
                        MessageBox.Show("Invalid Credentials");
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }

        // --- UI Helper Methods ---

        private void AddHeader(Panel p, string title, string sub)
        {
            Label lblTitle = new Label { Text = title, Font = new Font("Segoe UI", 22, FontStyle.Bold), ForeColor = Color.White, Location = new Point(55, 40), AutoSize = true };
            Label lblSub = new Label { Text = sub, ForeColor = Color.Gray, Location = new Point(60, 85), AutoSize = true };
            p.Controls.Add(lblTitle); p.Controls.Add(lblSub);
        }

        private TextBox CreateInput(Panel p, string labelText, int y, string placeholder, bool isPass = false)
        {
            Label lbl = new Label { Text = labelText, ForeColor = Color.FromArgb(0, 255, 136), Location = new Point(60, y), AutoSize = true, Font = new Font("Segoe UI", 8, FontStyle.Bold) };
            Panel pan = new Panel { Size = new Size(400, 35), Location = new Point(60, y + 20), BackColor = Color.FromArgb(12, 22, 40) };
            TextBox txt = new TextBox { BorderStyle = BorderStyle.None, BackColor = Color.FromArgb(12, 22, 40), ForeColor = Color.White, Location = new Point(10, 8), Size = new Size(380, 20), PlaceholderText = placeholder };
            if (isPass) txt.PasswordChar = '●';
            pan.Controls.Add(txt); p.Controls.Add(lbl); p.Controls.Add(pan);
            return txt;
        }
    }
}