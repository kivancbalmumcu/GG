using GG.Service.Authors;
using GG.Service.Publishers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GG.UI
{
    public partial class BooksForm : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        //private readonly IAuthorService _authorService;
        //private readonly IPublisherService _publisherService;

        public BooksForm()
        {
            InitializeComponent();
            //this._authorService = new AuthorService();
            //this._publisherService = new PublisherService();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            GetBooks();
            GetPublishers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateBook();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void GetBooks()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Book", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetPublishers()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Publisher", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void AddBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [Book] (InternationalStandardBookNumber,Name,PublishedDate,PageCount,PublisherId) VALUES (@InternationalStandardBookNumber,@Name,@PublishedDate,@PageCount,@PublisherId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@InternationalStandardBookNumber", textInternationalStandardBookNumber.Text);
            sqlCommand.Parameters.AddWithValue("@Name", textName.Text);
            sqlCommand.Parameters.AddWithValue("@PublishedDate", Convert.ToDateTime(dateTimePickerPublishedDate.Text));
            sqlCommand.Parameters.AddWithValue("@PageCount", textPageCount.Text);
            sqlCommand.Parameters.AddWithValue("@PublisherId", textPublisherId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Book", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void DeleteBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [Book] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Book", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void UpdateBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("UPDATE [Book] SET InternationalStandardBookNumber=@InternationalStandardBookNumber,Name=@Name,PublishedDate=@PublishedDate,PageCount=@PageCount,PublisherId=@PublisherId WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
            sqlCommand.Parameters.AddWithValue("@InternationalStandardBookNumber", textInternationalStandardBookNumber.Text);
            sqlCommand.Parameters.AddWithValue("@Name", textName.Text);
            sqlCommand.Parameters.AddWithValue("@PublishedDate", Convert.ToDateTime(dateTimePickerPublishedDate.Text));
            sqlCommand.Parameters.AddWithValue("@PageCount", textPageCount.Text);
            sqlCommand.Parameters.AddWithValue("@PublisherId", textPublisherId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Book", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textInternationalStandardBookNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerPublishedDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textPageCount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPublisherId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//if we wanna set name GetPublisherName()
        }

        //private string GetPublisherName()
        //{
        //    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);

        //    var publisher = _publisherService.GetPublisherById(id);

        //    return publisher.Name;
        //}
    }
}
