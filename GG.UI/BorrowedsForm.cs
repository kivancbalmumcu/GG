using GG.Core.Entities.Libraries;
using GG.Service.Books;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GG.UI
{
    public partial class BorrowedsForm : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private IBookService _bookService;

        public BorrowedsForm()
        {
            InitializeComponent();
            _bookService = new BookService();
        }

        private void BorrowedsForm_Load(object sender, EventArgs e)
        {
            GetLibraries();
            GetBooks();
            GetApplicationUsers();
            GetBorroweds();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var appUserId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var libraryId = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bookId = dataGridView3.CurrentRow.Cells[0].Value.ToString();
        }
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBorrowed_Click(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            _bookService.BookLibraryExists(int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString()), int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString()));

            sqlCommand = new SqlCommand("INSERT INTO [Borrowed] (BorrowedDate,IsRecieved,ApplicationUserId,LibraryId,BookId) VALUES (@BorrowedDate,@IsRecieved  ,@ApplicationUserId,@LibraryId,@BookId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@BorrowedDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@IsRecieved", false);
            sqlCommand.Parameters.AddWithValue("@ApplicationUserId", dataGridView1.CurrentRow.Cells[0].Value);
            sqlCommand.Parameters.AddWithValue("@LibraryId", dataGridView2.CurrentRow.Cells[0].Value);
            sqlCommand.Parameters.AddWithValue("@BookId", dataGridView3.CurrentRow.Cells[0].Value);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Borrowed", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;
        }

        private void GetApplicationUsers()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM ApplicationUser", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }
        private void GetLibraries()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Library", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            sqlConnection.Close();
        }
        private void GetBooks()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Book", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetBorroweds()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Borrowed", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView4.DataSource = dataTable;

            sqlConnection.Close();
        }

        public void GetRecieved()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("UPDATE [Borrowed] SET RecievedDate=@RecievedDate,IsRecieved=@IsRecieved WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", int.Parse(dataGridView4.CurrentRow.Cells[0].Value.ToString()));
            sqlCommand.Parameters.AddWithValue("@RecievedDate", DateTime.Now);
            sqlCommand.Parameters.AddWithValue("@IsRecieved", true);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Borrowed", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView4.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void buttonRecieved_Click(object sender, EventArgs e)
        {
            GetRecieved();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }
    }
}
