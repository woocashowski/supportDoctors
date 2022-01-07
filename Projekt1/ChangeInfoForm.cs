using System;
using System.Linq;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class ChangeInfoForm : Form
    {
        public ChangeInfoForm()
        {
            InitializeComponent();
        }

        public void newAdmin()
        {
            workerCheckBox.Checked = true;
        }

        public void newUser()
        {
            workerCheckBox.Checked = false;
        }

        private void add_User(string name, string login, string password, string surname, bool worker)
        {
            cinema_dbDataSet.usersDataTable users = new cinema_dbDataSet.usersDataTable();
            users.AddusersRow(name, login, password, surname, worker);
        }

        // Hide passwords
        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                letter = (char)(letter + shift);
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        public void myLogin(int id)
        {
            Cinema_DB cinema = new Cinema_DB();
            User use = cinema.find_user_by_ID(id);
            label1.Text = id.ToString();

            nameBox.Text = use.name;
            surnameBox.Text = use.surname;
            loginBox.Text = use.login;
            passwordBox.Text = Caesar(use.password, -1);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string surname = surnameBox.Text;
            string login = loginBox.Text;
            string password = passwordBox.Text;
            password = Caesar(password, 1);
            bool isAdmin = false;
            //workerCheckBox
            //MessageBox.Show(password, Caesar(password, -1));
            //workerCheckBox.Checked = true;
            if (workerCheckBox.Checked == true) isAdmin = true;


            int length1 = name.Length;
            int length2 = surname.Length;
            int length3 = login.Length;
            int length4 = password.Length;



            if (length1 > 0 &&
                length2 > 0 &&
                length3 > 0 &&
                length4 > 0)
            {

                if (length4 > 10 ||
                    password.Any(char.IsDigit) == false ||
                    password.Any(char.IsUpper) == false ||
                    password.Any(char.IsLower) == false)
                {
                    MessageBox.Show("Hasło nie powinno być dłuższe niż 10 znaków, zawierać cyfrę oraz małą i dużą literę!");
                    goto notEnded;
                }

                // Funkcja dodająca użytkownika do bazy
                Cinema_DB cinema = new Cinema_DB();

                cinema.delete_User(Int32.Parse(label1.Text));

                User user = new User();
                user.name = name.ToString();
                user.surname = surname.ToString();
                user.login = login.ToString();
                user.password = password.ToString();
                user.worker = isAdmin;
                cinema.add_user(user);

                MessageBox.Show("Zmiana danych zakończona");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Rejestracja nieudana");
            }
        notEnded:;
        }




        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void workerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

    }
}
