namespace Day4
{
    partial class LibraryWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // LibraryWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(182, 64, 0);
            ClientSize = new Size(800, 450);
            Name = "LibraryWindow";
            Text = "My Library";
            WindowState = FormWindowState.Maximized;
            Load += LibraryWindow_Load;
            ResumeLayout(false);
        }
        private void InitializeLayout()
        {


            // 🔹 Top Search Panel
            panelSearch = new Panel();
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Height = 80;
            panelSearch.BackColor = Color.FromArgb(232, 114, 50); // Lighter shade for contrast
            panelSearch.Padding = new Padding(10);

            // 🔹 Center the Category ComboBox in the Search Panel
            cmbCategories = new ComboBox();
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.Size = new Size(250, 35);
            cmbCategories.Font = new Font("Microsoft YaHei", 12F, FontStyle.Regular);
            cmbCategories.BackColor = Color.White;
            cmbCategories.ForeColor = Color.Sienna;
            cmbCategories.FlatStyle = FlatStyle.Flat;
            cmbCategories.Cursor = Cursors.Hand;
            cmbCategories.SelectedIndexChanged += SelectedIndexChanged;

            cmbCategories.Location = new Point(
                (panelSearch.Width - cmbCategories.Width) / 2,
                (panelSearch.Height - cmbCategories.Height) / 2
            );

            // Add resize handler to keep combobox centered
            panelSearch.Resize += (sender, e) => {
                cmbCategories.Location = new Point(
                    (panelSearch.Width - cmbCategories.Width) / 2,
                    (panelSearch.Height - cmbCategories.Height) / 2
                );
            };

            panelSearch.Controls.Add(cmbCategories);

            // 🔹 Flow Panel (Books Container)
            flowBooks = new FlowLayoutPanel();
            flowBooks.Dock = DockStyle.Fill;
            flowBooks.AutoScroll = true;
            flowBooks.FlowDirection = FlowDirection.TopDown;
            flowBooks.WrapContents = false;
            flowBooks.Padding = new Padding(20);
            flowBooks.BackColor = Color.Honeydew;

            // 🔹 Pagination Panel
            panelPagination = new Panel();
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Height = 60;
            panelPagination.BackColor = Color.FromArgb(182, 64, 0);


            // 🔹 Previous Button
            btnPrev = new Button();
            btnPrev.Text = "◀";
            btnPrev.Location = new Point(900, 5);
            btnPrev.ForeColor = Color.White;
            btnPrev.BackColor = Color.FromArgb(182, 64, 0);
            btnPrev.Size = new Size(65, 45);
            btnPrev.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btnPrev.TabIndex = 27;
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.TextAlign = ContentAlignment.MiddleCenter;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.FlatAppearance.BorderColor = btnPrev.BackColor;
            btnPrev.Cursor = Cursors.Hand;
            btnPrev.Click += BtnPrev_Click;


            // 🔹 Next Button
            btnNext = new Button();
            btnNext.Click += btnNext_Clicked;
            btnNext.Text = "▶";
            btnNext.Location = new Point(980, 5);
            btnNext.ForeColor = Color.White;
            btnNext.BackColor = Color.FromArgb(182, 64, 0);
            btnNext.Size = new Size(65, 45);
            btnNext.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btnNext.TabIndex = 27;
            btnNext.TextAlign = ContentAlignment.TopCenter;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.FlatStyle = FlatStyle.Flat; 
            btnNext.FlatAppearance.BorderColor = btnNext.BackColor;
            btnNext.Cursor = Cursors.Hand;


            // Paging Label
            lblPaging = new Label();
            lblPaging.Text = "1/1";
            lblPaging.ForeColor = Color.White;
            lblPaging.Font = new Font("Microsoft YaHei", 12.2F);
            lblPaging.Location = new Point(1060,15);


            


            // 🔹 back Button
            btnBack = new Button();
            btnBack.Text = "Back";
            btnBack.Location = new Point(20, 8);
            btnBack.Click += (e, args) => this.Close();
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold);
            btnBack.ForeColor = Color.Sienna;
            btnBack.Size = new Size(115, 43);
            btnBack.TabIndex = 27;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Cursor = Cursors.Hand;

            panelPagination.Controls.Add(btnPrev);
            panelPagination.Controls.Add(btnNext);
            panelPagination.Controls.Add(btnBack);
            panelPagination.Controls.Add(lblPaging);

            // 🔹 Add Controls to Form
            this.Controls.Add(flowBooks);
            this.Controls.Add(panelPagination);

            this.Controls.Add(panelSearch);
        }

        

        private FlowLayoutPanel flowBooks;
        private Panel panelPagination;
        private Button btnPrev;
        private Button btnNext;
        private Button btnBack;
        private Label lblPaging;
        private ComboBox cmbCategories;
        private Panel panelSearch;
        #endregion
    }
}