using System;
using System.Drawing;
using System.Windows.Forms;

namespace Day4
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComponent()
        {
            this.Text = "Home";
            this.BackColor = Color.FromArgb(245, 245, 245);

            // ===== HEADER PANEL =====
            Panel headerPanel = new Panel();
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 80;
            headerPanel.BackColor = Color.FromArgb(182, 64, 0);

            Label lblTitle = new Label();
            lblTitle.Text = "Dashboard";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            headerPanel.Controls.Add(lblTitle);
            this.Controls.Add(headerPanel);

            // ===== MAIN LAYOUT PANEL =====
            TableLayoutPanel mainLayout = new TableLayoutPanel();
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.ColumnCount = 3;
            mainLayout.RowCount = 1;
            mainLayout.Padding = new Padding(100, 100, 100, 100);

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            // HomeWindow
            // 
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(282, 253);
            Controls.Add(headerPanel);
            Controls.Add(mainLayout);
            Name = "HomeWindow";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            // 
            // btn_Logout
            // 
            Button btn_Logout = new Button();
            btn_Logout.BackColor = Color.White;
            btn_Logout.Font = new Font("Microsoft YaHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Logout.ForeColor = Color.Sienna;
            btn_Logout.Image = Properties.Resources.logout;
            //btn_Logout.Location = new Point(12, 12);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(64, 52);
            btn_Logout.TabIndex = 10;
            btn_Logout.UseVisualStyleBackColor = false;

            btn_Logout.Dock = DockStyle.Left; // aligns to right side of header
            btn_Logout.Click += (s, e) => this.Close();

            headerPanel.Controls.Add(btn_Logout);
            btn_Logout.BringToFront(); // ensure it appears above label
            // 
            // HomeWindow
            // 
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(746, 438);
            Controls.Add(headerPanel);
            Controls.Add(mainLayout);
            Name = "HomeWindow";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            // ===== BUTTONS =====
            Button btnProfile = CreateModernButton("My Profile", Properties.Resources.user);
            Button btnAddBook = CreateModernButton("Add Book", Properties.Resources.addBook);
            Button btnLibrary = CreateModernButton("My Library", Properties.Resources.books);

            btnProfile.Click += UserProfile_Click;

            btnAddBook.Click += btnAddBook_Click;
            btnLibrary.Click += btnLibrary_Click;

            mainLayout.Controls.Add(btnProfile, 0, 0);
            mainLayout.Controls.Add(btnAddBook, 1, 0);
            mainLayout.Controls.Add(btnLibrary, 2, 0);

            this.Controls.Add(mainLayout);
        }

        private Button CreateModernButton(string text, Image img)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Image = img;

            btn.Dock = DockStyle.Fill;
            btn.Margin = new Padding(20);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.BackColor = Color.White;
            btn.ForeColor = Color.FromArgb(182, 64, 0);

            btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btn.TextImageRelation = TextImageRelation.ImageAboveText;
            btn.ImageAlign = ContentAlignment.MiddleCenter;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Cursor = Cursors.Hand;

            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 240, 230);

            return btn;
        }
    }
}
