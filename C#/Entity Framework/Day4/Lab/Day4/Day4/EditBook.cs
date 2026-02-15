using Day4.Entites;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Day4
{
    public partial class EditBook : Form
    {
        Author author;
        string BookImagePath;
        Context _dbContext;
        string BookPDFPath;
        Book selectedBook;
        //Context _dbContext = new Context();
        public EditBook(Author author, Context _dbContext, Book book)
        {
            InitializeComponent();
            this.author = author;
            this._dbContext = _dbContext;
            selectedBook = book;
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
                originalBookCoverImageUncahnged = false;//this means that the image has changed
                BookImagePath = ofd.FileName;

                // Display in PictureBox immediately
                Image BookCover = Image.FromFile(BookImagePath);

                pbx_BookImage.Image = ResizeImage(BookCover, 256, 256);

                // Save a copy for future use
                //SaveProfileImage(BookImagePath,"1.png");
            }
        }
        private void SaveBookCoverImage(string originalPath, string newImageName, out string extension)
        {
            // 1️⃣ Create safe folder inside AppData

            string folder = Path.GetDirectoryName(Application.StartupPath);
            folder += "\\BooksCovers";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // 2️⃣ Get original extension (.png, .jpg, etc.)
            extension = Path.GetExtension(originalPath).ToLower();
            newImageName = newImageName.Split('.')[0];
            // 3️⃣ Create new full file path
            string newFilePath = Path.Combine(folder, newImageName + extension);

            // 4️⃣ Read and save image with new name
            using (Image img = Image.FromFile(originalPath))
            {
                try
                {
                    img.Save(newFilePath);
                }
                catch
                {
                    MessageBox.Show("Try changing image again later", "Process Cancelled", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                }

                //img.Save(newFilePath);
            }
            
        }


        private void SaveBookPDFFile(string originalPath, string newPDFName)
        {
            // 1️⃣ Create safe folder inside your project

            string folder = Path.GetDirectoryName(Application.StartupPath);
            folder += "\\BooksPDF";
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            //23️ Create new full file path
            string newFilePath = Path.Combine(folder, newPDFName);

            // 4️⃣ Read and save image with new name
            File.Copy(originalPath, newFilePath, true); // true = overwrite if exists
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

        bool originalBookCoverImageUncahnged = true;  //used as a flag to know if original Book Cover Image file changed or not
        bool originalBookPDFUncahnged = true; //used as a flag to know if original Book PDf file changed or not

        private void EditBookWindow_Load(object sender, EventArgs e)
        {
            cbx_Category.DataSource = _dbContext.Categories.Select(c => c).ToList();
            cbx_Category.DisplayMember = "Name";
            cbx_Category.ValueMember = "Id";

            tbx_Brief.Text = selectedBook.Brief;
            tbx_Price.Text = selectedBook.Price.ToString();
            tbx_Quantity.Text = selectedBook.Quantity.ToString();
            cbx_Category.SelectedValue = selectedBook.CategoryId;
            tbx_Title.Text = selectedBook.Title;

            string fullBookCoverImagePath= Path.Combine(Application.StartupPath, "BooksCovers", selectedBook.ImagePath);
            if (File.Exists(fullBookCoverImagePath))
            {
                pbx_BookImage.Image = ResizeImage(Image.FromFile(fullBookCoverImagePath), 256, 256);
            }
        }





        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_Title.Text))
            {
                MessageBox.Show("Book Name and Publish Date Are Mandatory");
            }
            else
            {
                selectedBook.Title = tbx_Title.Text;
                selectedBook.Price = string.IsNullOrWhiteSpace(tbx_Price.Text) ? null : Convert.ToInt32(tbx_Price.Text);
                selectedBook.Quantity = string.IsNullOrWhiteSpace(tbx_Quantity.Text) ? null : Convert.ToInt32(tbx_Quantity.Text);
                selectedBook.CategoryId = Convert.ToInt32(cbx_Category.SelectedValue);
                selectedBook.Brief = tbx_Brief.Text;
                if (originalBookCoverImageUncahnged == false) //originalk image has changed
                {
                    originalBookCoverImageUncahnged = true;
                    SaveBookCoverImage(BookImagePath, selectedBook.ImagePath, out string extension);
                    selectedBook.ImagePath = selectedBook.ImagePath.Split('.')[0]+extension; //updating image extension
                }
                if(originalBookPDFUncahnged == false) //original pdf has changed
                {
                    originalBookPDFUncahnged = true;
                    SaveBookPDFFile(BookPDFPath, selectedBook.PDF_Path);
                }

                //selectedBook.PDF_Path += ".pdf";
                _dbContext.SaveChanges();
                MessageBox.Show("Book Updated", "Process Done Successfully", MessageBoxButtons.OK);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select PDF File";
            ofd.Filter = "PDF Files (*.pdf)|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalBookPDFUncahnged = false;
                BookPDFPath = ofd.FileName;
                var filePath = ofd.FileName.Split('\\');
                btn_ChooseFile.Text = filePath[filePath.Length - 1];
            }

        }
    }
}
