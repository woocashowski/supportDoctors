using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Decode passwords
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

        private void signinButton_Click(object sender, EventArgs e)
        {

            //loginBox
            string login = loginBox.Text;
            string password = PasswordBox.Text;
            password = Caesar(password, 1);
            //cinema_dbDataSet.usersDataTable usersRows = new cinema_dbDataSet.usersDataTable();
            //DataRow user = usersRows.FindByIdentyfikator(1);
            //Console.WriteLine(user);
            //Console.WriteLine("teeeest");
            //MessageBox.Show();

            Cinema_DB cinema = new Cinema_DB();
            User use = cinema.find_user_by_login(login);
            //User use = cinema.find_user_by_ID(1);
            try
            {
                Console.WriteLine(use.login);
                Console.WriteLine("pass " + use.password);
                Console.WriteLine(use.id);
                Console.WriteLine("pass2 " + password);
                if (password != use.password) goto End;
            }
            catch
            {
                goto End;
            }

            bool isAdmin = use.worker;
            if (isAdmin)
            {
                var frm = new AdminForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();
            }
            else
            {
                var frm = new ReservationForm();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Show(); };
                frm.Show();
                this.Hide();

                frm.user_number(use.id);
            }
        End:;

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var frm = new SignUpForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        
    }
}