using QLPhongTro.DB_connect;
using System.Data;

namespace QLPhongTro
{
    public partial class Login : Form
    {
        DataTable dt;
        DBMain db;

        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = textPassword.Text;
            db = new DBMain("AVAN", "QuanLyPhongTro02");
            dt = db.Getdata("Select * from LOGIN where UserName = '" + user + "' and " + "PassWords = '" + password + "'");
            if(dt == null )
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!!!");
                return;
            }
            new Menu().ShowDialog();
            Dispose();




        }

        private void Login_Load(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
