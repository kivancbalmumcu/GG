using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GG.UI
{
    public partial class AuthorsForm : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public AuthorsForm()
        {
            InitializeComponent();
        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {
            GetAuthors();
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

        private void AddAuthor()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [Author] (Firstname,Middlename,Lastname) VALUES (@Firstname,@Middlename,@Lastname)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Firstname", textFirstname.Text);
            sqlCommand.Parameters.AddWithValue("@Middlename", textMiddlename.Text);
            sqlCommand.Parameters.AddWithValue("@Lastname", textLastname.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Author", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void DeleteAuthor()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [Author] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Author", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void UpdateAuthor()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("UPDATE [Author] SET Firstname=@Firstname,Middlename=@Middlename,Lastname=@Lastname WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
            sqlCommand.Parameters.AddWithValue("@Firstname", textFirstname.Text);
            sqlCommand.Parameters.AddWithValue("@Middlename", textMiddlename.Text);
            sqlCommand.Parameters.AddWithValue("@Lastname", textLastname.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Author", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textFirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textMiddlename.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textLastname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddAuthor();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteAuthor();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateAuthor();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.ShowDialog();
        }
    }
}
