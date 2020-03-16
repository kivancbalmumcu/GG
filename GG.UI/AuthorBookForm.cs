using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GG.UI
{
    public partial class AuthorBookForm : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public AuthorBookForm()
        {
            InitializeComponent();
        }

        private void AuthorBookForm_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetBooks();
            GetAuthorBook();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddAuthorBook();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textAuthorId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textFirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textMiddlename.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textLastname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBookId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textInternationalStandardBookNumber.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textName.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerPublishedDate.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[3].Value);
            textPageCount.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textPublisherId.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteAuthorBook();
        }

        private void DeleteAuthorBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [AuthorBookMapping] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM AuthorBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetAuthors()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Author", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetBooks()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Book", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetAuthorBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM AuthorBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void AddAuthorBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [AuthorBookMapping] (BookId,AuthorId) VALUES (@BookId,@AuthorId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@BookId", textBookId.Text);
            sqlCommand.Parameters.AddWithValue("@AuthorId", textAuthorId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM AuthorBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
