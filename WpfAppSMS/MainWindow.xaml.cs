using SMSLibrary.Models;
using System.Windows;

namespace WpfAppSMS
{
    public partial class MainWindow : Window
    {
        private SmsContext dbContext;

        public MainWindow()
        {
            InitializeComponent();
            dbContext = new SmsContext(); 
            userControl1.loginBtn.Click += LoginBtn_Click;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string username = userControl1.userNameLbl.Text;
            string password = userControl1.passwordBox.Password;

            bool isValid = ValidateLogin(username, password);

            if (isValid)
            {
                MessageBox.Show("Login successful!");
                var newWindow = new Window1(username); 
                newWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            var user = dbContext.Logins.FirstOrDefault(u => u.LoginName == username && u.Password == password);
            return user != null;
        }
    }
}
