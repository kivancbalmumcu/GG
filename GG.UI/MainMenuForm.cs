namespace GG.UI
{
    using System;
    using System.Windows.Forms;

    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonAddresses_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddressesForm addressesForm = new AddressesForm();
            addressesForm.Show();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksForm booksForm = new BooksForm();
            booksForm.Show();
        }

        private void buttonPublishers_Click(object sender, EventArgs e)
        {
            this.Hide();
            PublishersForm publisherForm = new PublishersForm();
            publisherForm.Show();
        }

        private void buttonAuthors_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorsForm authorsForm = new AuthorsForm();
            authorsForm.Show();
        }

        private void buttonAuthorBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorBookForm authorBookForm = new AuthorBookForm();
            authorBookForm.Show();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.Show();
        }

        private void buttonCategoryBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoryBookFrom categoryBookFrom = new CategoryBookFrom();
            categoryBookFrom.Show();
        }

        private void buttonLibraries_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibrariesForm librariesForm = new LibrariesForm();
            librariesForm.Show();
        }

        private void buttonLibraryBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryBookForm libraryBookForm = new LibraryBookForm();
            libraryBookForm.Show();
        }

        private void buttonBorrowed_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowedsForm borrowedsForm = new BorrowedsForm();
            borrowedsForm.Show();
        }
    }
}