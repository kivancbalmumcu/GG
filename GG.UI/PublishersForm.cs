using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GG.UI
{
    public partial class PublishersForm : Form
    {
        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public PublishersForm()
        {
            InitializeComponent();
        }

        private void PublishersForm_Load(object sender, EventArgs e)
        {
            GetPublishers();
            GetAddresses();
        }

        private void GetPublishers()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Publisher", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void GetAddresses()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Address", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView2.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void AddPublisher()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [Publisher] (Name,Phone,Email,AddressId) VALUES (@Name,@Phone,@Email,@AddressId)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Name", textName.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", textPhone.Text);
            sqlCommand.Parameters.AddWithValue("@Email", textEmail.Text);
            sqlCommand.Parameters.AddWithValue("@AddressId", textAddressId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Publisher", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void DeletePublisher()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [Publisher] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Publisher", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;


            sqlConnection.Close();
        }

        private void UpdatePublisher()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("UPDATE [Publisher] SET Name=@Name,Phone=@Phone,Email=@Email,AddressId=@AddressId WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
            sqlCommand.Parameters.AddWithValue("@Name", textName.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", textPhone.Text);
            sqlCommand.Parameters.AddWithValue("@Email", textEmail.Text);
            sqlCommand.Parameters.AddWithValue("@AddressId", textAddressId.Text);

            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Publisher", sqlConnection);

            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddPublisher();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletePublisher();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdatePublisher();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textAddressId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
