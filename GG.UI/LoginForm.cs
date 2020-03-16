namespace GG.UI
{
    using GG.Service.Users;
    using System;
    using System.Windows.Forms;

    public partial class LoginForm : Form
    {
        private readonly IApplicationUserService _applicationUserService;

        public LoginForm()
        {
            InitializeComponent();
            this._applicationUserService = new ApplicationUserService();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var appUser = _applicationUserService.GetApplicationUserByEmail(textEmail.Text);

            if (appUser != null && appUser.Password == textPassword.Text)
            {
                this.Hide();
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
            }
            else
                MessageBox.Show("E-Posta veya şifre hatalı.");
        }
    }
}
