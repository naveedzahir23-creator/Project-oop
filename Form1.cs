using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oop
{
    public partial class Form1 : Form

    {
        string connectionString =
        "server=localhost;database=NaveedZahir;user=root;password=wc2028aus@naveed;";
        private Panel leftPanel;
        private Panel rightPanel;

        private Panel logoBox;
        private Label logoLabel;
        private Label logoSubLabel;

        private Panel chartPanel;

        private Label tagLineLabel;
        private Label tagHeading1;
        private Label tagHeading2;
        private Label tagDesc;

        private Label secureAccessLabel;
        private Label welcomeLabel;
        private Label signInDescLabel;

        // ID
        private TextBox txtId;

        // Name (was email)
        private Label emailLabel;
        private Panel emailPanel;
        private TextBox txtEmail;
        private Label emailIcon;

        // Password
        private Label passwordLabel;
        private Panel passwordPanel;
        private TextBox txtPassword;
        private Label passwordIcon;

        private CheckBox rememberMe;
        private Label forgotPassword;

        private Panel loginButton;
        private Label loginButtonText;

        private Label dividerLeft;
        private Label dividerOr;
        private Label dividerRight;

        private Label signupLabel;
        private Label signupLink;

        private Panel secureDot;
        private Label secureLabel;

        public Form1()
        {
            this.Text = "TradeVision  —  Stock Intelligence Platform";
            this.Size = new Size(900, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromArgb(10, 15, 30);

            BuildLeftPanel();
            BuildRightPanel();
        }

        private void BuildLeftPanel()
        {
            leftPanel = new Panel();
            leftPanel.Size = new Size(370, 540);
            leftPanel.Location = new Point(0, 0);
            leftPanel.BackColor = Color.FromArgb(6, 16, 32);
            leftPanel.Paint += LeftPanel_Paint;
            this.Controls.Add(leftPanel);

            logoBox = new Panel();
            logoBox.Size = new Size(42, 42);
            logoBox.Location = new Point(36, 36);
            logoBox.BackColor = Color.FromArgb(0, 200, 85);
            logoBox.Paint += LogoBox_Paint;
            leftPanel.Controls.Add(logoBox);

            logoLabel = new Label();
            logoLabel.Text = "TRADE VISION";
            logoLabel.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.AutoSize = true;
            logoLabel.Location = new Point(90, 40);
            leftPanel.Controls.Add(logoLabel);

            logoSubLabel = new Label();
            logoSubLabel.Text = "STOCK INTELLIGENCE PLATFORM";
            logoSubLabel.Font = new Font("Segoe UI", 7);
            logoSubLabel.ForeColor = Color.FromArgb(0, 180, 80);
            logoSubLabel.AutoSize = true;
            logoSubLabel.Location = new Point(90, 62);
            leftPanel.Controls.Add(logoSubLabel);

            chartPanel = new Panel();
            chartPanel.Size = new Size(300, 160);
            chartPanel.Location = new Point(36, 120);
            chartPanel.Paint += ChartPanel_Paint;
            leftPanel.Controls.Add(chartPanel);

            tagLineLabel = new Label();
            tagLineLabel.Text = "——  AI-POWERED";
            tagLineLabel.ForeColor = Color.FromArgb(0, 255, 136);
            tagLineLabel.Location = new Point(36, 310);
            leftPanel.Controls.Add(tagLineLabel);

            tagHeading1 = new Label();
            tagHeading1.Text = "Trade Smarter.";
            tagHeading1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            tagHeading1.ForeColor = Color.White;
            tagHeading1.Location = new Point(36, 332);
            leftPanel.Controls.Add(tagHeading1);

            tagHeading2 = new Label();
            tagHeading2.Text = "Not Harder.";
            tagHeading2.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            tagHeading2.ForeColor = Color.FromArgb(0, 255, 136);
            tagHeading2.Location = new Point(36, 362);
            leftPanel.Controls.Add(tagHeading2);

            tagDesc = new Label();
            tagDesc.Text = "Real-time insights & advanced analytics.";
            tagDesc.Location = new Point(36, 400);
            leftPanel.Controls.Add(tagDesc);
        }

        private void BuildRightPanel()
        {
            rightPanel = new Panel();
            rightPanel.Size = new Size(528, 540);
            rightPanel.Location = new Point(370, 0);
            rightPanel.BackColor = Color.FromArgb(7, 13, 26);
            rightPanel.Paint += RightPanel_Paint;
            this.Controls.Add(rightPanel);

            secureAccessLabel = new Label();
            secureAccessLabel.Text = "SECURE ACCESS";
            secureAccessLabel.Location = new Point(60, 48);
            rightPanel.Controls.Add(secureAccessLabel);

            welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome Back";
            welcomeLabel.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            welcomeLabel.Location = new Point(57, 68);
            rightPanel.Controls.Add(welcomeLabel);

            signInDescLabel = new Label();
            signInDescLabel.Text = "Sign in to your TradeVision dashboard";
            signInDescLabel.Location = new Point(60, 108);
            rightPanel.Controls.Add(signInDescLabel);

            // ---------------- ID ----------------
            Label idLabel = new Label();
            idLabel.Text = "USER ID";
            idLabel.ForeColor = Color.FromArgb(0, 255, 136);
            idLabel.Location = new Point(60, 152);
            rightPanel.Controls.Add(idLabel);

            Panel idPanel = new Panel();
            idPanel.Size = new Size(400, 42);
            idPanel.Location = new Point(60, 172);
            idPanel.BackColor = Color.FromArgb(12, 22, 40);
            idPanel.Paint += InputPanel_Paint;
            rightPanel.Controls.Add(idPanel);

            txtId = new TextBox();
            txtId.BorderStyle = BorderStyle.None;
            txtId.BackColor = Color.FromArgb(12, 22, 40);
            txtId.ForeColor = Color.White;
            txtId.Location = new Point(44, 10);
            txtId.Size = new Size(330, 28);
            txtId.PlaceholderText = "Enter your ID";
            idPanel.Controls.Add(txtId);

            // ---------------- NAME ----------------
            emailLabel = new Label();
            emailLabel.Text = "NAME";
            emailLabel.ForeColor = Color.FromArgb(0, 255, 136);
            emailLabel.Location = new Point(60, 232);
            rightPanel.Controls.Add(emailLabel);

            emailPanel = new Panel();
            emailPanel.Size = new Size(400, 42);
            emailPanel.Location = new Point(60, 252);
            emailPanel.BackColor = Color.FromArgb(12, 22, 40);
            emailPanel.Paint += InputPanel_Paint;
            rightPanel.Controls.Add(emailPanel);

            txtEmail = new TextBox();
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.BackColor = Color.FromArgb(12, 22, 40);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(44, 10);
            txtEmail.Size = new Size(330, 28);
            txtEmail.PlaceholderText = "Enter your name";
            emailPanel.Controls.Add(txtEmail);

            // ---------------- PASSWORD ----------------
            passwordLabel = new Label();
            passwordLabel.Text = "PASSWORD";
            passwordLabel.ForeColor = Color.FromArgb(0, 255, 136);
            passwordLabel.Location = new Point(60, 312);
            rightPanel.Controls.Add(passwordLabel);

            passwordPanel = new Panel();
            passwordPanel.Size = new Size(400, 42);
            passwordPanel.Location = new Point(60, 332);
            passwordPanel.BackColor = Color.FromArgb(12, 22, 40);
            passwordPanel.Paint += InputPanel_Paint;
            rightPanel.Controls.Add(passwordPanel);

            txtPassword = new TextBox();
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.BackColor = Color.FromArgb(12, 22, 40);
            txtPassword.ForeColor = Color.White;
            txtPassword.PasswordChar = '●';
            txtPassword.Location = new Point(44, 10);
            txtPassword.Size = new Size(330, 28);
            txtPassword.PlaceholderText = "Enter password";
            passwordPanel.Controls.Add(txtPassword);

            loginButton = new Panel();
            loginButton.Size = new Size(400, 44);
            loginButton.Location = new Point(60, 380);
            loginButton.BackColor = Color.Green;
            loginButton.Click += LoginButton_Click;
            rightPanel.Controls.Add(loginButton);

            loginButtonText = new Label();
            loginButtonText.Text = "LOGIN";
            loginButtonText.Location = new Point(150, 12);
            loginButton.Controls.Add(loginButtonText);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtEmail.Text.Trim();     
            string pass = txtPassword.Text;

            string query = "SELECT COUNT(*) FROM Users WHERE Id=@id AND Username=@name AND Password=@pass";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@pass", pass);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Welcome " + name,
                                            "Login Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID, Name or Password",
                                            "Login Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        private void InputPanel_Paint(object sender, PaintEventArgs e) { }
        private void LeftPanel_Paint(object sender, PaintEventArgs e) { }
        private void RightPanel_Paint(object sender, PaintEventArgs e) { }
        private void LogoBox_Paint(object sender, PaintEventArgs e) { }
        private void ChartPanel_Paint(object sender, PaintEventArgs e) { }
    }
}