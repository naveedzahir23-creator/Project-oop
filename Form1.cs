using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace oop
{
    public partial class Form1 : Form
    {
        // Left panel
        private Panel leftPanel;

        // Right panel
        private Panel rightPanel;

        // Logo area
        private Panel logoBox;
        private Label logoLabel;
        private Label logoSubLabel;

        // Chart area
        private Panel chartPanel;

        // Tagline
        private Label tagLineLabel;
        private Label tagHeading1;
        private Label tagHeading2;
        private Label tagDesc;

        // Form title
        private Label secureAccessLabel;
        private Label welcomeLabel;
        private Label signInDescLabel;

        // Email field
        private Label emailLabel;
        private Panel emailPanel;
        private TextBox txtEmail;
        private Label emailIcon;

        // Password field
        private Label passwordLabel;
        private Panel passwordPanel;
        private TextBox txtPassword;
        private Label passwordIcon;

        // Options row
        private CheckBox rememberMe;
        private Label forgotPassword;

        // Login button
        private Panel loginButton;
        private Label loginButtonText;

        // Divider
        private Label dividerLeft;
        private Label dividerOr;
        private Label dividerRight;

        // Signup
        private Label signupLabel;
        private Label signupLink;

        // Secure badge
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

            // Logo box (green square)
            logoBox = new Panel();
            logoBox.Size = new Size(42, 42);
            logoBox.Location = new Point(36, 36);
            logoBox.BackColor = Color.FromArgb(0, 200, 85);
            logoBox.Paint += LogoBox_Paint;
            leftPanel.Controls.Add(logoBox);

            // Logo name
            logoLabel = new Label();
            logoLabel.Text = "TRADE VISION";
            logoLabel.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.AutoSize = true;
            logoLabel.Location = new Point(90, 40);
            leftPanel.Controls.Add(logoLabel);

            // Logo sub text
            logoSubLabel = new Label();
            logoSubLabel.Text = "STOCK INTELLIGENCE PLATFORM";
            logoSubLabel.Font = new Font("Segoe UI", 7, FontStyle.Regular);
            logoSubLabel.ForeColor = Color.FromArgb(0, 180, 80);
            logoSubLabel.AutoSize = true;
            logoSubLabel.Location = new Point(90, 62);
            leftPanel.Controls.Add(logoSubLabel);

            // Chart panel
            chartPanel = new Panel();
            chartPanel.Size = new Size(300, 160);
            chartPanel.Location = new Point(36, 120);
            chartPanel.BackColor = Color.Transparent;
            chartPanel.Paint += ChartPanel_Paint;
            leftPanel.Controls.Add(chartPanel);

            // AI Powered tag
            tagLineLabel = new Label();
            tagLineLabel.Text = "——  AI-POWERED";
            tagLineLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            tagLineLabel.ForeColor = Color.FromArgb(0, 255, 136);
            tagLineLabel.AutoSize = true;
            tagLineLabel.Location = new Point(36, 310);
            leftPanel.Controls.Add(tagLineLabel);

            // Heading line 1
            tagHeading1 = new Label();
            tagHeading1.Text = "Trade Smarter.";
            tagHeading1.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            tagHeading1.ForeColor = Color.White;
            tagHeading1.AutoSize = true;
            tagHeading1.Location = new Point(36, 332);
            leftPanel.Controls.Add(tagHeading1);

            // Heading line 2
            tagHeading2 = new Label();
            tagHeading2.Text = "Not Harder.";
            tagHeading2.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            tagHeading2.ForeColor = Color.FromArgb(0, 255, 136);
            tagHeading2.AutoSize = true;
            tagHeading2.Location = new Point(36, 362);
            leftPanel.Controls.Add(tagHeading2);

            // Description
            tagDesc = new Label();
            tagDesc.Text = "Real-time insights & advanced analytics.";
            tagDesc.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            tagDesc.ForeColor = Color.FromArgb(100, 180, 130);
            tagDesc.AutoSize = true;
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

            // Secure access tag
            secureAccessLabel = new Label();
            secureAccessLabel.Text = "SECURE ACCESS";
            secureAccessLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            secureAccessLabel.ForeColor = Color.FromArgb(0, 255, 136);
            secureAccessLabel.AutoSize = true;
            secureAccessLabel.Location = new Point(60, 48);
            rightPanel.Controls.Add(secureAccessLabel);

            // Welcome heading
            welcomeLabel = new Label();
            welcomeLabel.Text = "Welcome Back";
            welcomeLabel.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(57, 68);
            rightPanel.Controls.Add(welcomeLabel);

            // Sign in description
            signInDescLabel = new Label();
            signInDescLabel.Text = "Sign in to your TradeVision dashboard";
            signInDescLabel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            signInDescLabel.ForeColor = Color.FromArgb(100, 150, 120);
            signInDescLabel.AutoSize = true;
            signInDescLabel.Location = new Point(60, 108);
            rightPanel.Controls.Add(signInDescLabel);

            // Email label
            emailLabel = new Label();
            emailLabel.Text = "EMAIL ADDRESS";
            emailLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(0, 255, 136);
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(60, 152);
            rightPanel.Controls.Add(emailLabel);

            // Email input panel
            emailPanel = new Panel();
            emailPanel.Size = new Size(400, 42);
            emailPanel.Location = new Point(60, 172);
            emailPanel.BackColor = Color.FromArgb(12, 22, 40);
            emailPanel.Paint += InputPanel_Paint;
            emailPanel.Click += (s, e) => txtEmail.Focus();  // FIX
            rightPanel.Controls.Add(emailPanel);

            emailIcon = new Label();
            emailIcon.Text = "✉";
            emailIcon.Font = new Font("Segoe UI", 13);
            emailIcon.ForeColor = Color.FromArgb(0, 180, 80);
            emailIcon.AutoSize = true;
            emailIcon.Location = new Point(12, 10);
            emailIcon.Click += (s, e) => txtEmail.Focus();   // FIX
            emailPanel.Controls.Add(emailIcon);

            txtEmail = new TextBox();
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.BackColor = Color.FromArgb(12, 22, 40);
            txtEmail.ForeColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 11);
            txtEmail.Size = new Size(330, 28);
            txtEmail.Location = new Point(44, 10);
            txtEmail.PlaceholderText = "ahsan4802908@cloud.neduet.edu.pk";
            emailPanel.Controls.Add(txtEmail);

            // Password label
            passwordLabel = new Label();
            passwordLabel.Text = "PASSWORD";
            passwordLabel.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            passwordLabel.ForeColor = Color.FromArgb(0, 255, 136);
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(60, 232);
            rightPanel.Controls.Add(passwordLabel);

            // Password input panel
            passwordPanel = new Panel();
            passwordPanel.Size = new Size(400, 42);
            passwordPanel.Location = new Point(60, 252);
            passwordPanel.BackColor = Color.FromArgb(12, 22, 40);
            passwordPanel.Paint += InputPanel_Paint;
            passwordPanel.Click += (s, e) => txtPassword.Focus();  // FIX
            rightPanel.Controls.Add(passwordPanel);

            passwordIcon = new Label();
            passwordIcon.Text = "🔒";
            passwordIcon.Font = new Font("Segoe UI", 11);
            passwordIcon.ForeColor = Color.FromArgb(0, 180, 80);
            passwordIcon.AutoSize = true;
            passwordIcon.Location = new Point(12, 10);
            passwordIcon.Click += (s, e) => txtPassword.Focus();   // FIX
            passwordPanel.Controls.Add(passwordIcon);

            txtPassword = new TextBox();
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.BackColor = Color.FromArgb(12, 22, 40);
            txtPassword.ForeColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.Size = new Size(330, 28);
            txtPassword.Location = new Point(44, 10);
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.PasswordChar = '●';
            passwordPanel.Controls.Add(txtPassword);

            // Remember me
            rememberMe = new CheckBox();
            rememberMe.Text = "Remember me";
            rememberMe.Font = new Font("Segoe UI", 9);
            rememberMe.ForeColor = Color.FromArgb(100, 150, 120);
            rememberMe.Location = new Point(60, 312);
            rememberMe.AutoSize = true;
            rememberMe.FlatStyle = FlatStyle.Flat;
            rightPanel.Controls.Add(rememberMe);

            // Forgot password
            forgotPassword = new Label();
            forgotPassword.Text = "Forgot Password?";
            forgotPassword.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            forgotPassword.ForeColor = Color.FromArgb(0, 255, 136);
            forgotPassword.AutoSize = true;
            forgotPassword.Location = new Point(330, 314);
            forgotPassword.Cursor = Cursors.Hand;
            forgotPassword.Click += ForgotPassword_Click;
            rightPanel.Controls.Add(forgotPassword);

            // Login button
            loginButton = new Panel();
            loginButton.Size = new Size(400, 44);
            loginButton.Location = new Point(60, 350);
            loginButton.BackColor = Color.FromArgb(0, 200, 85);
            loginButton.Paint += LoginButton_Paint;
            loginButton.Cursor = Cursors.Hand;
            loginButton.Click += LoginButton_Click;
            rightPanel.Controls.Add(loginButton);

            loginButtonText = new Label();
            loginButtonText.Text = "▶   ACCESS DASHBOARD";
            loginButtonText.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            loginButtonText.ForeColor = Color.FromArgb(5, 14, 26);
            loginButtonText.AutoSize = true;
            loginButtonText.Location = new Point(110, 12);
            loginButtonText.Cursor = Cursors.Hand;
            loginButtonText.Click += LoginButton_Click;
            loginButton.Controls.Add(loginButtonText);

            // Divider
            dividerLeft = new Label();
            dividerLeft.Size = new Size(160, 1);
            dividerLeft.Location = new Point(60, 415);
            dividerLeft.BackColor = Color.FromArgb(20, 40, 30);
            rightPanel.Controls.Add(dividerLeft);

            dividerOr = new Label();
            dividerOr.Text = "or";
            dividerOr.Font = new Font("Segoe UI", 8);
            dividerOr.ForeColor = Color.FromArgb(80, 120, 100);
            dividerOr.AutoSize = true;
            dividerOr.Location = new Point(228, 408);
            rightPanel.Controls.Add(dividerOr);

            dividerRight = new Label();
            dividerRight.Size = new Size(160, 1);
            dividerRight.Location = new Point(250, 415);
            dividerRight.BackColor = Color.FromArgb(20, 40, 30);
            rightPanel.Controls.Add(dividerRight);

            // Signup line
            signupLabel = new Label();
            signupLabel.Text = "New to TradeVision?";
            signupLabel.Font = new Font("Segoe UI", 9);
            signupLabel.ForeColor = Color.FromArgb(100, 140, 120);
            signupLabel.AutoSize = true;
            signupLabel.Location = new Point(120, 438);
            rightPanel.Controls.Add(signupLabel);

            signupLink = new Label();
            signupLink.Text = "Create Free Account";
            signupLink.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            signupLink.ForeColor = Color.FromArgb(0, 255, 136);
            signupLink.AutoSize = true;
            signupLink.Location = new Point(285, 438);
            signupLink.Cursor = Cursors.Hand;
            signupLink.Click += SignupLink_Click;
            rightPanel.Controls.Add(signupLink);

            // Secure dot
            secureDot = new Panel();
            secureDot.Size = new Size(8, 8);
            secureDot.Location = new Point(360, 508);
            secureDot.BackColor = Color.FromArgb(0, 255, 136);
            secureDot.Paint += SecureDot_Paint;
            rightPanel.Controls.Add(secureDot);

            secureLabel = new Label();
            secureLabel.Text = "256-bit SSL Encrypted";
            secureLabel.Font = new Font("Segoe UI", 8);
            secureLabel.ForeColor = Color.FromArgb(60, 100, 80);
            secureLabel.AutoSize = true;
            secureLabel.Location = new Point(374, 504);
            rightPanel.Controls.Add(secureLabel);
        }

        // ── LEFT PANEL BACKGROUND ──────────────────────────────────────────────
        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen p = new Pen(Color.FromArgb(15, 0, 255, 136), 1))
            {
                g.DrawEllipse(p, 180, -80, 280, 280);
                g.DrawEllipse(p, -60, 340, 180, 180);
            }

            using (Pen sep = new Pen(Color.FromArgb(13, 32, 64), 1))
            {
                g.DrawLine(sep, 369, 0, 369, 540);
            }
        }

        // ── LOGO BOX ──────────────────────────────────────────────────────────
        private void LogoBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (LinearGradientBrush b = new LinearGradientBrush(
                new Point(0, 0), new Point(42, 42),
                Color.FromArgb(0, 180, 70),
                Color.FromArgb(0, 255, 136)))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, 10, 10, 180, 90);
                path.AddArc(32, 0, 10, 10, 270, 90);
                path.AddArc(32, 32, 10, 10, 0, 90);
                path.AddArc(0, 32, 10, 10, 90, 90);
                path.CloseFigure();
                g.FillPath(b, path);
            }

            g.DrawString("📈", new Font("Segoe UI", 14), Brushes.White, 8, 8);
        }

        // ── CHART ─────────────────────────────────────────────────────────────
        private void ChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Point[] points = {
                new Point(0, 120),
                new Point(40, 100),
                new Point(70, 115),
                new Point(100, 80),
                new Point(130, 55),
                new Point(160, 65),
                new Point(190, 35),
                new Point(220, 45),
                new Point(255, 20),
                new Point(300, 10)
            };

            Point[] fillPoints = new Point[points.Length + 2];
            fillPoints[0] = new Point(0, 155);
            for (int i = 0; i < points.Length; i++)
                fillPoints[i + 1] = points[i];
            fillPoints[fillPoints.Length - 1] = new Point(300, 155);

            using (LinearGradientBrush fill = new LinearGradientBrush(
                new Point(0, 0), new Point(0, 155),
                Color.FromArgb(50, 0, 255, 136),
                Color.FromArgb(0, 0, 255, 136)))
            {
                g.FillPolygon(fill, fillPoints);
            }

            using (Pen linePen = new Pen(Color.FromArgb(0, 255, 136), 2.5f))
            {
                linePen.LineJoin = LineJoin.Round;
                g.DrawLines(linePen, points);
            }

            g.FillEllipse(new SolidBrush(Color.FromArgb(0, 255, 136)),
                points[6].X - 4, points[6].Y - 4, 8, 8);
            g.FillEllipse(new SolidBrush(Color.FromArgb(0, 255, 136)),
                points[9].X - 4, points[9].Y - 4, 8, 8);

            DrawPill(g, 10, 130, "▲ AAPL +2.4%", Color.FromArgb(0, 255, 136), true);
            DrawPill(g, 160, 130, "▼ NASDAQ -0.8%", Color.FromArgb(255, 68, 102), false);
        }

        private void DrawPill(Graphics g, int x, int y, string text, Color color, bool up)
        {
            Size size = new Size(130, 22);
            Rectangle rect = new Rectangle(x, y, size.Width, size.Height);

            using (GraphicsPath path = RoundedRect(rect, 11))
            using (SolidBrush bg = new SolidBrush(Color.FromArgb(25, color)))
            using (Pen border = new Pen(Color.FromArgb(60, color), 1))
            {
                g.FillPath(bg, path);
                g.DrawPath(border, path);
            }

            using (SolidBrush textBrush = new SolidBrush(color))
                g.DrawString(text, new Font("Segoe UI", 8, FontStyle.Bold), textBrush, x + 8, y + 4);
        }

        // ── INPUT PANEL BORDER ────────────────────────────────────────────────
        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Panel p = sender as Panel;
            Rectangle rect = new Rectangle(0, 0, p.Width - 1, p.Height - 1);

            using (GraphicsPath path = RoundedRect(rect, 8))
            using (SolidBrush bg = new SolidBrush(Color.FromArgb(12, 22, 40)))
            using (Pen border = new Pen(Color.FromArgb(0, 255, 136, 30), 1))
            {
                g.FillPath(bg, path);
                g.DrawPath(border, path);
            }
        }

        // ── LOGIN BUTTON ──────────────────────────────────────────────────────
        private void LoginButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Panel p = sender as Panel;
            Rectangle rect = new Rectangle(0, 0, p.Width, p.Height);

            using (LinearGradientBrush b = new LinearGradientBrush(
                new Point(0, 0), new Point(p.Width, 0),
                Color.FromArgb(0, 170, 70),
                Color.FromArgb(0, 255, 136)))
            using (GraphicsPath path = RoundedRect(rect, 8))
            {
                g.FillPath(b, path);
            }
        }

        // ── RIGHT PANEL BORDER ────────────────────────────────────────────────
        private void RightPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            using (Pen p = new Pen(Color.FromArgb(0, 255, 136, 40), 1))
                g.DrawLine(p, 0, 538, 528, 538);
        }

        // ── SECURE DOT ────────────────────────────────────────────────────────
        private void SecureDot_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(Color.FromArgb(0, 255, 136)), 0, 0, 8, 8);
        }

        // ── BUTTON CLICK HANDLERS ─────────────────────────────────────────────

        // LOGIN
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string correctEmail = "ahsan4802908@cloud.neduet.edu.pk";
            string correctPassword = "19765";

            if (txtEmail.Text.Trim() == correctEmail &&
                txtPassword.Text == correctPassword)
            {
                MessageBox.Show(
                    "Login Successful!\n\nWelcome to TradeVision Dashboard.",
                    "TradeVision — Access Granted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Invalid email or password.\nPlease check your credentials and try again.",
                    "TradeVision — Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // FORGOT PASSWORD
        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Please contact the administrator for password reset.\n\n" +
                "📧  ahsan4802908@cloud.neduet.edu.pk",
                "TradeVision — Forgot Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // CREATE ACCOUNT
        private void SignupLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Account registration is currently managed by the administrator.\n\n" +
                "Please contact:\n📧  ahsan4802908@cloud.neduet.edu.pk",
                "TradeVision — Create Account",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ── HELPER — ROUNDED RECTANGLE ────────────────────────────────────────
        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}