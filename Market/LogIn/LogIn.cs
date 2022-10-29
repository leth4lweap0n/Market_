using System.Linq;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Market.Entity;

namespace Market.LogIn
{
    public partial class LogIn : XtraForm
    {
        public LogIn()
        {
            InitializeComponent();
            SeeThePassword.SvgImage = MySvgImageCollection[0];
#if DEBUG
            ButtonAddUser.Visible = true;
#endif    
        }

        private bool LogInCheck()
        {
            using var db = new ExampleDBContext();
            var UserInfo = db.Users.FirstOrDefault(
                u => u.Username == TextBoxID.Text && u.Password == TextBoxPassword.Text
                );
            return UserInfo != null;
        }

        private void ButtonLogIn_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxID.Text) || string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!LogInCheck())
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Giriş başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonAddUser_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxID.Text) || string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = new Users
            {
                Username = TextBoxID.Text,
                Password = TextBoxPassword.Text
            };
            using var db = new ExampleDBContext();
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SeeThePassword_MouseCaptureChanged(object sender, System.EventArgs e)
        {
            TextBoxPassword.Properties.UseSystemPasswordChar = !TextBoxPassword.Properties.UseSystemPasswordChar;
            SeeThePassword.SvgImage = MySvgImageCollection[TextBoxPassword.Properties.UseSystemPasswordChar ? 0 : 1];
        }
    }
}