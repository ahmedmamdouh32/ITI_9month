using Day4.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Day4
{
    public partial class AddBookWindow : Form
    {
        Author author;
        string BookImagePath;
        Context _dbContext;
        //Context _dbContext = new Context();
        public AddBookWindow(Author author, Context _dbContext)
        {
            InitializeComponent();
            this.author = author;
            this._dbContext = _dbContext;
        }

        private void tbx_Brief_TextChanged(object sender, EventArgs e)
        {
            int textLength = tbx_Brief.Text.Length;
            if (textLength < 300)
            {
                lbl_YourExperienceLength.ForeColor = Color.White;
                lbl_YourExperienceLength.Text = $"{tbx_Brief.Text.Length}/300";
            }
            else
            {
                lbl_YourExperienceLength.ForeColor = Color.Yellow;
                lbl_YourExperienceLength.Text = $"{tbx_Brief.Text.Length}/300";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbx_BookImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Profile Picture";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BookImagePath = ofd.FileName;

                // Display in PictureBox immediately
                Image BookCover = Image.FromFile(BookImagePath);
                
                pbx_BookImage.Image = ResizeImage(BookCover, 256, 256);

                // Save a copy for future use
                //SaveProfileImage(BookImagePath,"1.png");
            }
        }
        private void SaveBookCoverImage(string originalPath, string newImageName)
        {
            // 1️⃣ Create safe folder inside AppData
            
            string folder = Path.GetDirectoryName(Application.StartupPath);
            folder += "\\BooksCovers";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // 2️⃣ Get original extension (.png, .jpg, etc.)
            string extension = Path.GetExtension(originalPath).ToLower();

            // 3️⃣ Create new full file path
            string newFilePath = Path.Combine(folder, newImageName + extension);

            // 4️⃣ Read and save image with new name
            using (Image img = Image.FromFile(originalPath))
            {
                img.Save(newFilePath);
            }
        }
        private Image ResizeImage(Image originalImage, int maxWidth, int maxHeight)
        {
            // Calculate the ratio to keep aspect ratio
            double ratioX = (double)maxWidth / originalImage.Width;
            double ratioY = (double)maxHeight / originalImage.Height;
            double ratio = Math.Min(ratioX, ratioY);

            // Only resize if original is larger
            if (ratio > 1) ratio = 1;

            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            // Create a new bitmap with new dimensions
            Bitmap newImage = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }

        private void AddBookWindow_Load(object sender, EventArgs e)
        {
            cbx_Category.DataSource = _dbContext.Categories.Select(c => c).ToList();
            cbx_Category.DisplayMember = "Name";
            cbx_Category.ValueMember = "Id";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_Title.Text) || string.IsNullOrEmpty(dtp_PublishDate.Value.ToString()))
            {
                MessageBox.Show("Book Name and Publish Date Are Mandatory");
            }
            else
            {
                Book book = new Book()
                {
                    Title = tbx_Title.Text,
                    Brief = tbx_Brief.Text,
                    Price = string.IsNullOrWhiteSpace(tbx_Price.Text) ? null : Convert.ToInt32(tbx_Price.Text),
                    Quantity = string.IsNullOrWhiteSpace(tbx_Quantity.Text) ? null : Convert.ToInt32(tbx_Quantity.Text),
                    CategoryId = Convert.ToInt32(cbx_Category.SelectedValue),
                    PublishDate = dtp_PublishDate.Value,
                    AuthorId = author.Id,
                };
                string dateFormat = string.Format("{0:yyyy-MM-dd_HH-mm-ss}", book.PublishDate);
                book.ImagePath = $"{author.Id}-{book.Title}-{dateFormat}";
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                SaveBookCoverImage(BookImagePath, book.ImagePath);
                MessageBox.Show("Book Added","Process Done Successfully",MessageBoxButtons.OK);
            }
        }
    }
}
