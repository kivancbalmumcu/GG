using GG.Core.Entities.Addresses;
using GG.Service.Addresses;
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
    public partial class AddressesForm : Form
    {
        //private readonly IAddressService _addressService;
        //private Address address;

        private string connectionString = "data source=pc\\sqlexpress;initial catalog=GG;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;

        public AddressesForm()
        {
            InitializeComponent();
            //this._addressService = new AddressService();
        }

        private void AddressesForm_Load(object sender, EventArgs e)
        {
            GetAddresses();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            #region Summary

            //address = new Address()
            //{
            //    Street = textStreet.Text,
            //    Neighborhood = textNeighborhood.Text,
            //    BuildingNumber = Convert.ToInt32(textBuildingNumber.Text),
            //    FloorNumber = Convert.ToInt32(textFloorNumber.Text),
            //    PostCode = Convert.ToInt32(textPostCode.Text),
            //    District = textDisrict.Text,
            //    Province = textProvince.Text,
            //};

            //_addressService.InsertAddress(address); 
            //Todo : the table does not change momentarily


            #endregion

            AddAddress();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteAddress();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateAddress();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
        }

        private void GetAddresses()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Address", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void AddAddress()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("INSERT INTO [Address] (Name,Street,Neighborhood,BuildingNumber,FloorNumber,PostCode,District,Province) VALUES (@Name,@Street,@Neighborhood,@BuildingNumber,@FloorNumber,@PostCode,@District,@Province)", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@Name", textName.Text);
            sqlCommand.Parameters.AddWithValue("@Street", textStreet.Text);
            sqlCommand.Parameters.AddWithValue("@Neighborhood", textNeighborhood.Text);
            sqlCommand.Parameters.AddWithValue("@BuildingNumber", Convert.ToInt32(textBuildingNumber.Text));
            sqlCommand.Parameters.AddWithValue("@FloorNumber", Convert.ToInt32(textFloorNumber.Text));
            sqlCommand.Parameters.AddWithValue("@PostCode", Convert.ToInt32(textPostCode.Text));
            sqlCommand.Parameters.AddWithValue("@District", textDistrict.Text);
            sqlCommand.Parameters.AddWithValue("@Province", textProvince.Text);
            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Address", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void DeleteAddress()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("DELETE FROM [Address] WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Address", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void UpdateAddress()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            sqlCommand = new SqlCommand("UPDATE [Address] SET Street=@Street,Neighborhood=@Neighborhood,BuildingNumber=@BuildingNumber,FloorNumber=@FloorNumber,PostCode=@PostCode,District=@District,Province=@Province WHERE Id = @id", sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textId.Text));
            sqlCommand.Parameters.AddWithValue("@Street", textStreet.Text);
            sqlCommand.Parameters.AddWithValue("@Neighborhood", textNeighborhood.Text);
            sqlCommand.Parameters.AddWithValue("@BuildingNumber", Convert.ToInt32(textBuildingNumber.Text));
            sqlCommand.Parameters.AddWithValue("@FloorNumber", Convert.ToInt32(textFloorNumber.Text));
            sqlCommand.Parameters.AddWithValue("@PostCode", Convert.ToInt32(textPostCode.Text));
            sqlCommand.Parameters.AddWithValue("@District", textDistrict.Text);
            sqlCommand.Parameters.AddWithValue("@Province", textProvince.Text);
            sqlCommand.ExecuteNonQuery();

            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Address", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textStreet.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textNeighborhood.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBuildingNumber.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textFloorNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textPostCode.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textDistrict.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textProvince.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
