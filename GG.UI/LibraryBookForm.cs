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
    public partial class LibraryBookForm : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public LibraryBookForm()
        {
            InitializeComponent();
        }

        private void LibraryBookForm_Load(object sender, EventArgs e)
        {
            GetLibraries();
            GetBooks();
            GetLibraryBook();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddLibraryBook();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteLibraryBook();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textLibraryId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textLibraryName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBookId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textInternationalStandardBookNumber.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBookName.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerPublishedDate.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells[3].Value);
            textPageCount.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textPublisherId.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }

        private void AddLibraryBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [LibraryBookMapping] (BookId,LibraryId) VALUES (@BookId,@LibraryId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@BookId", textBookId.Text);
            sqlCommand.Parameters.AddWithValue("@LibraryId", textLibraryId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM LibraryBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void DeleteLibraryBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [LibraryBookMapping] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM LibraryBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetLibraries()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Library", sqlConnection);

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

        private void GetLibraryBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM LibraryBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
