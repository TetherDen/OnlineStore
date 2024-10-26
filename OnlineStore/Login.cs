using System.Windows.Forms;
using System.Drawing;
using OnlineStore.Forms.Register;


namespace OnlineStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginTextBox_Click(object sender, EventArgs e)
        {
            LoginTextBox.BackColor = Color.White;
            LoginPanel.BackColor = Color.White;
            PasswordPanel.BackColor = SystemColors.Control;
            PasswordTextBox.BackColor = SystemColors.Control;
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.White;
            PasswordPanel.BackColor = Color.White;
            LoginTextBox.BackColor = SystemColors.Control;
            LoginPanel.BackColor = SystemColors.Control;
        }

        private void PasswordPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = false;
        }

        private void PasswordPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}
