using Day4.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Day4
{
    public partial class LibraryWindow : Form
    {
        int currentPage = 0;
        Author author;
        Context _dbContext;
        int totalBooks = 0;
        public LibraryWindow(Author author, Context _dbContext)
        {
            InitializeComponent();
            this.author = author;
            this._dbContext = _dbContext;
            InitializeLayout();
        }

        private Panel CreateBookCard(Book book)
        {
            Panel card = new Panel();
            card.Height = 240;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);
            card.BackColor = Color.White;
            card.Width = flowBooks.ClientSize.Width - 40; // padding


            // LEFT SIDE PANEL (Text Area)
            Panel leftPanel = new Panel();
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Padding = new Padding(15);

            // RIGHT SIDE PANEL (Image + PDF Button)
            Panel rightPanel = new Panel();
            rightPanel.Width = 160;
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Padding = new Padding(10);

            // 📘 Title
            Label lblTitle = new Label();
            lblTitle.Text = book.Title;
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Top = 10;
            lblTitle.ForeColor = Color.FromArgb(182, 64, 0);

            // 📝 Brief
            Label lblBrief = new Label();
            lblBrief.Text = book.Brief;
            lblBrief.Font = new Font("Segoe UI", 9);
            lblBrief.ForeColor = Color.Sienna;
            lblBrief.MaximumSize = new Size(1200, 100);
            lblBrief.AutoSize = true;
            lblBrief.Top = 55;

            // 📅 Info

            Label lblInfo = new Label();
            lblInfo.Font = new Font("Segoe UI", 8);
            lblInfo.Text = $"Published: {book.PublishDate:yyyy-MM-dd} | Qty: {book.Quantity} | Category: {book.category.Name}";
            lblInfo.Top = 120;//85;
            lblInfo.AutoSize = true;

            //lbl Price
            Label lblPrice = new Label();
            lblPrice.Text = $"Price: ${book.Price}";
            lblPrice.Top = 145;//110;
            lblPrice.Font = new Font("Segoe UI", 10,FontStyle.Bold);
            lblPrice.AutoSize = true;
            lblPrice.ForeColor = Color.FromArgb(65, 145, 52);

            // ✏ Edit
            Button btnEdit = new Button();
            btnEdit.Text = "Edit";
            btnEdit.Top = 185;//150;
            btnEdit.Left = 10;
            btnEdit.Tag = book;
            btnEdit.BackColor = Color.White;
            btnEdit.Font = new Font("Microsoft YaHei", 11.2F, FontStyle.Bold);
            btnEdit.ForeColor = Color.Sienna;
            btnEdit.Size = new Size(90, 35);
            btnEdit.TabIndex = 27;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Click += (e, args) =>
            {
                EditBook addBookWindow = new EditBook(author,_dbContext,(Book)btnEdit.Tag);
                this.Hide();
                addBookWindow.Show();
                addBookWindow.FormClosed += (e, args) => this.Show();
            };





            // 🗑 Delete
            Button btnDelete = new Button();
            btnDelete.Text = "Delete";
            btnDelete.Top = 185;//150;
            btnDelete.Left = 110;
            btnDelete.Tag = book;  
            btnDelete.Click += (e, s) =>
            {
                Book bookToDelete = (Book)btnDelete.Tag;
                DeleteBook(bookToDelete, card);
            };
            btnDelete.BackColor = Color.White;
            btnDelete.Font = new Font("Microsoft YaHei", 11.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Size = new Size(90, 35);
            btnDelete.TabIndex = 27;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Cursor = Cursors.Hand;

            // 🖼 Image
            PictureBox pic = new PictureBox();
            pic.Size = new Size(120, 130);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Top = 5;
            string imagePath = Path.Combine(Application.StartupPath, "BooksCovers", book.ImagePath);
            if (File.Exists(imagePath))
                pic.Image = Image.FromFile(imagePath);


            // 📖 Open PDF Button
            Button btnOpenPdf = new Button();
            btnOpenPdf.Text = "Open PDF";
            btnOpenPdf.Top = 140;
            btnDelete.Left = 110;
            btnOpenPdf.BackColor = Color.White;
            btnOpenPdf.Font = new Font("Microsoft YaHei", 11.2F, FontStyle.Bold);
            btnOpenPdf.ForeColor = Color.Sienna;
            btnOpenPdf.Size = new Size(140, 35);
            btnOpenPdf.TabIndex = 27;
            btnOpenPdf.UseVisualStyleBackColor = false;
            btnOpenPdf.Cursor = Cursors.Hand;
            string pdfPath = Path.Combine(Application.StartupPath, "BooksPDF", book.PDF_Path);
            btnOpenPdf.Click += (s, e) =>
            {
                if (File.Exists(pdfPath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = pdfPath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("PDF file not found.");
                }
            };

            // Add Controls
            leftPanel.Controls.Add(lblTitle);
            leftPanel.Controls.Add(lblBrief);
            leftPanel.Controls.Add(lblInfo);
            leftPanel.Controls.Add(btnEdit);
            leftPanel.Controls.Add(btnDelete);
            leftPanel.Controls.Add(lblPrice);

            rightPanel.Controls.Add(pic);
            rightPanel.Controls.Add(btnOpenPdf);

            card.Controls.Add(leftPanel);
            card.Controls.Add(rightPanel);

            return card;
        }
        private void DeleteBook(Book book, Panel card)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{book.Title}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Remove from flow layout panel
                FlowLayoutPanel parent = card.Parent as FlowLayoutPanel;
                parent?.Controls.Remove(card);

                MessageBox.Show($"Book deleted: {book.Title}");

                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }


        private void EditBook(Book book, Panel card)
        {
            
            
            //MessageBox.Show($"Book deleted: {book.Title}");
            book.Title = "hhh";
            //_dbContext.Books.Remove(book);
            //_dbContext.SaveChanges();
            
        }

        private void LibraryWindow_Load(object sender, EventArgs e)
        {

            totalBooks = _dbContext.Books.Where(b => b.AuthorId == author.Id).Count();
            lblPaging.Text = $"{currentPage +1}/{totalBooks / 5 + 1}";
            var books = _dbContext.Books.Where(b => b.AuthorId == author.Id).Skip(currentPage).Take(5).Include(b => b.category);
            var categories = _dbContext.Categories.Select(c => c).ToList();
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";
            foreach (Book b in books)
            {
                flowBooks.Controls.Add(CreateBookCard(b));
            }
        }

        private void btnNext_Clicked(object sender, EventArgs args)
        {
            if (currentPage + 5 < totalBooks)
            {
                currentPage += 5;
                flowBooks.Controls.Clear();
                lblPaging.Text = $"{currentPage / 5 + 1}/{totalBooks / 5 + 1}";
                var books = _dbContext.Books.Where(b => b.AuthorId == author.Id).Skip(currentPage).Take(5).Include(b => b.category);
                flowBooks.Controls.Clear();
                foreach (Book b in books)
                {
                    flowBooks.Controls.Add(CreateBookCard(b));
                }
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage -= 5;
                lblPaging.Text = $"{currentPage / 5 + 1}/{totalBooks / 5 + 1}";
                var books = _dbContext.Books.Where(b => b.AuthorId == author.Id).Skip(currentPage).Take(5).Include(b=>b.category);
                flowBooks.Controls.Clear();
                foreach (Book b in books)
                {
                    flowBooks.Controls.Add(CreateBookCard(b));
                }
            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {

            var books = _dbContext.Books.Where(b => b.category.Name == cmbCategories.Text).ToList();
            flowBooks.Controls.Clear();
            foreach (Book book in books)
            {
                flowBooks.Controls.Add(CreateBookCard(book));
            }
        }

    }
}
