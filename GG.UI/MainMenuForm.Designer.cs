namespace GG.UI
{
    partial class MainMenuForm
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
            this.buttonAddresses = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonPublishers = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonAuthorBook = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonCategoryBook = new System.Windows.Forms.Button();
            this.buttonLibraries = new System.Windows.Forms.Button();
            this.buttonLibraryBook = new System.Windows.Forms.Button();
            this.buttonBorrowed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddresses
            // 
            this.buttonAddresses.Location = new System.Drawing.Point(12, 12);
            this.buttonAddresses.Name = "buttonAddresses";
            this.buttonAddresses.Size = new System.Drawing.Size(317, 23);
            this.buttonAddresses.TabIndex = 0;
            this.buttonAddresses.Text = "Addresses";
            this.buttonAddresses.UseVisualStyleBackColor = true;
            this.buttonAddresses.Click += new System.EventHandler(this.buttonAddresses_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(12, 70);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(317, 23);
            this.buttonBooks.TabIndex = 1;
            this.buttonBooks.Text = "Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonPublishers
            // 
            this.buttonPublishers.Location = new System.Drawing.Point(12, 41);
            this.buttonPublishers.Name = "buttonPublishers";
            this.buttonPublishers.Size = new System.Drawing.Size(317, 23);
            this.buttonPublishers.TabIndex = 2;
            this.buttonPublishers.Text = "Publishers";
            this.buttonPublishers.UseVisualStyleBackColor = true;
            this.buttonPublishers.Click += new System.EventHandler(this.buttonPublishers_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(12, 99);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(317, 23);
            this.buttonAuthors.TabIndex = 3;
            this.buttonAuthors.Text = "Authors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.buttonAuthors_Click);
            // 
            // buttonAuthorBook
            // 
            this.buttonAuthorBook.Location = new System.Drawing.Point(12, 128);
            this.buttonAuthorBook.Name = "buttonAuthorBook";
            this.buttonAuthorBook.Size = new System.Drawing.Size(317, 23);
            this.buttonAuthorBook.TabIndex = 4;
            this.buttonAuthorBook.Text = "Author Book";
            this.buttonAuthorBook.UseVisualStyleBackColor = true;
            this.buttonAuthorBook.Click += new System.EventHandler(this.buttonAuthorBook_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(12, 157);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(317, 23);
            this.buttonCategories.TabIndex = 5;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonCategoryBook
            // 
            this.buttonCategoryBook.Location = new System.Drawing.Point(12, 186);
            this.buttonCategoryBook.Name = "buttonCategoryBook";
            this.buttonCategoryBook.Size = new System.Drawing.Size(317, 23);
            this.buttonCategoryBook.TabIndex = 0;
            this.buttonCategoryBook.Text = "Category Book";
            this.buttonCategoryBook.Click += new System.EventHandler(this.buttonCategoryBook_Click);
            // 
            // buttonLibraries
            // 
            this.buttonLibraries.Location = new System.Drawing.Point(12, 215);
            this.buttonLibraries.Name = "buttonLibraries";
            this.buttonLibraries.Size = new System.Drawing.Size(317, 23);
            this.buttonLibraries.TabIndex = 6;
            this.buttonLibraries.Text = "Libraries";
            this.buttonLibraries.Click += new System.EventHandler(this.buttonLibraries_Click);
            // 
            // buttonLibraryBook
            // 
            this.buttonLibraryBook.Location = new System.Drawing.Point(12, 244);
            this.buttonLibraryBook.Name = "buttonLibraryBook";
            this.buttonLibraryBook.Size = new System.Drawing.Size(317, 23);
            this.buttonLibraryBook.TabIndex = 7;
            this.buttonLibraryBook.Text = "Library Book";
            this.buttonLibraryBook.Click += new System.EventHandler(this.buttonLibraryBook_Click);
            // 
            // buttonBorrowed
            // 
            this.buttonBorrowed.Location = new System.Drawing.Point(12, 273);
            this.buttonBorrowed.Name = "buttonBorrowed";
            this.buttonBorrowed.Size = new System.Drawing.Size(317, 23);
            this.buttonBorrowed.TabIndex = 7;
            this.buttonBorrowed.Text = "Borrowed";
            this.buttonBorrowed.Click += new System.EventHandler(this.buttonBorrowed_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 308);
            this.Controls.Add(this.buttonBorrowed);
            this.Controls.Add(this.buttonLibraryBook);
            this.Controls.Add(this.buttonLibraries);
            this.Controls.Add(this.buttonCategoryBook);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.buttonAuthorBook);
            this.Controls.Add(this.buttonAuthors);
            this.Controls.Add(this.buttonPublishers);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonAddresses);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddresses;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonPublishers;
        private System.Windows.Forms.Button buttonAuthors;
        private System.Windows.Forms.Button buttonAuthorBook;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonCategoryBook;
        private System.Windows.Forms.Button buttonLibraries;
        private System.Windows.Forms.Button buttonLibraryBook;
        private System.Windows.Forms.Button buttonBorrowed;
    }
}