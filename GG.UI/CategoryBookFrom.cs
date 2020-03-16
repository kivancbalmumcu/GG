using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GG.UI
{
    public partial class CategoryBookFrom : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public CategoryBookFrom()
        {
            InitializeComponent();
        }

        private void CategoryBookFrom_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetBooks();
            GetCategoryBook();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCategoryId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textCategoryName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddCategoryBook();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteCategoryBook();
        }

        private void DeleteCategoryBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [CategoryBookMapping] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM CategoryBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetCategories()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Category", sqlConnection);

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

        private void GetCategoryBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM CategoryBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void AddCategoryBook()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [CategoryBookMapping] (BookId,CategoryId) VALUES (@BookId,@CategoryId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@BookId", textBookId.Text);
            sqlCommand.Parameters.AddWithValue("@CategoryId", textCategoryId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM CategoryBookMapping", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;

            sqlConnection.Close();
        }
    }
}
