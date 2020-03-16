namespace GG.UI
{
    using GG.Core.Entities.Users;
    using GG.Service.Users;
    using System;
    using System.Windows.Forms;

    public partial class RegisterForm : Form
    {
        LoginForm loginForm = new LoginForm();

        private readonly IApplicationUserService _applicationUserService;
        private ApplicationUser applicationUser;

        public RegisterForm()
        {
            InitializeComponent();
            this._applicationUserService = new ApplicationUserService();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            applicationUser = new ApplicationUser();

            applicationUser.TurkishIdentityNumber = textTCKN.Text;
            applicationUser.Name = textName.Text;
            applicationUser.Surname = textSurname.Text;
            applicationUser.Phone = textPhone.Text;
            applicationUser.Username = textUsername.Text;
            applicationUser.Email = textEmail.Text;
            applicationUser.Password = textPassword.Text;
            applicationUser.DateOfBirth = dateTimePickerBirthDate.Value;
            applicationUser.Active = true;

            _applicationUserService.InsertApplicationUser(applicationUser);

            this.Hide();

            loginForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
