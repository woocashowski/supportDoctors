using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using System.Timers;

namespace Projekt1
{
    public partial class ReservationForm : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        System.Timers.Timer refresh = new System.Timers.Timer(500);
        private int movie_select = -1;
        private int counter = 0;
        private List<Movie> movies;
        private Movie movie_selected;
        private List<Rezervation> rezervations;
        private List<int> seats = new List<int>();
        private List<string> taken = new List<string>();
        //private int idMovie;

        public ReservationForm()
        {
            InitializeComponent();

            Cinema_DB cinema = new Cinema_DB();
            movies = cinema.read_Movies();
            movieComboBox.Items.Clear();
            foreach (Movie movie in movies)
            {
                movieComboBox.Items.Add(movie.id + ".         " + movie.title + " " + movie.date.Substring(0, 10).ToString() + " " + movie.time.Substring(10));// " " + movie.date.ToString() +
            }
            movie_select = -1;


            timer.Elapsed += Timer_Elapsed;
            timer.Stop();
            timer.Dispose();
            timer = new System.Timers.Timer(10000);
            timer.Start();

            refresh.Elapsed += OnTimedEvent;
            refresh.AutoReset = true;
            refresh.Enabled = true;
            // green - avaible
            // gray - not avaible
            // orange - your choice

            // Tu wczytujemy zajętość 
           
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Green;
            }
            button16.BackColor = Color.Gray;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("XD");
            timer.Stop();
            button16.BackColor = Color.Gray;

            foreach(string t in taken)
            {
                Console.WriteLine(t);
                button_Click(t);
            }
            counter += 1;
            if(counter == 5)
            {
                counter = 0;
            }

            taken.Clear();
            button16.BackColor = Color.Gray;
        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
            if(movie_select!=-1)
            {
                read_seats();
            }
            
        }

        private void button_Click(string which)
        {
            if (movie_select < 1) goto goEnd;

            timer.Stop();
            timer.Dispose();
            timer = new System.Timers.Timer(5000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();


            Button button = new Button();

            //progressBar1.Value = 900;

            if (which == "1")
            {
                button = button1;
            }
            else if (which == "2")
            {
                button = button2;
            }
            else if (which == "3")
            {
                button = button3;
            }
            else if (which == "4")
            {
                button = button4;
            }
            else if (which == "5")
            {
                button = button5;
            }
            else if (which == "6")
            {
                button = button6;
            }
            else if (which == "7")
            {
                button = button7;
            }
            else if (which == "8")
            {
                button = button8;
            }
            else if (which == "9")
            {
                button = button9;
            }
            else if (which == "10")
            {
                button = button10;
            }
            else if (which == "11")
            {
                button = button11;
            }
            else if (which == "12")
            {
                button = button12;
            }
            else if (which == "13")
            {
                button = button13;
            }
            else if (which == "14")
            {
                button = button14;
            }
            else if (which == "15")
            {
                button = button15;
            }

            if (button.BackColor == Color.Gray)
            {
                button.BackColor = Color.Gray;
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Orange;
                Console.WriteLine(which);
                taken.Add(which);
                Cinema_DB cinema = new Cinema_DB();
                Rezervation rezervation = new Rezervation();
                rezervation.movie = movie_selected.id;
                rezervation.place = Int32.Parse(which);
                Console.WriteLine(rezervation.place);
                rezervation.user = Int32.Parse(label1.Text);
                Console.WriteLine(rezervation.user);

                cinema.add_rezervation(rezervation);

                // add_rezervation
            }
            else if (button.BackColor == Color.Orange)
            {
                button.BackColor = Color.Green;

                Cinema_DB cinema = new Cinema_DB();
                Rezervation rezervation = new Rezervation();
                rezervation.movie = movie_selected.id;
                rezervation.place = Int32.Parse(which);
                Console.WriteLine(rezervation.place);
                rezervation.user = Int32.Parse(label1.Text);
                Console.WriteLine(rezervation.user);

                Rezervation[] list_of_rezervations = cinema.find_rezervation_by_Movie(rezervation.movie);

                int id_to_delete = new int();

                foreach(Rezervation rez in list_of_rezervations)
                {
                    Console.WriteLine
                        (
                        rez.movie == movie_selected.id &&
                        rez.place == Int32.Parse(which) &&
                        rez.user == Int32.Parse(label1.Text)
                        );

                    if (
                        rez.movie == movie_selected.id &&
                        rez.place == Int32.Parse(which) &&
                        rez.user == Int32.Parse(label1.Text))
                    {
                        id_to_delete = rez.id;
                        Console.WriteLine("To delete:");
                        Console.WriteLine(id_to_delete);
                    }
                }

                //cinema.delete_Rezervation(which);
                cinema.delete_Rezervation(id_to_delete);
                //find_rezervation_by_Movie()


                taken.Remove(which);
            }

            if (button16.BackColor == Color.Gray
                &&
                button.BackColor != Color.Gray)
            {
                button16.BackColor = Color.Red;
            }
        goEnd:;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button_Click("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_Click("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_Click("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_Click("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_Click("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_Click("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_Click("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_Click("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_Click("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_Click("10");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_Click("11");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_Click("12");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_Click("13");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_Click("14");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_Click("15");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_Click("16");

            timer.Stop();


            if (button16.BackColor == Color.Red) 
            {
                button16.BackColor = Color.Gray;
            }
        }
    
        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer.Dispose();

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.Green;
            }
            button16.BackColor = Color.Gray;
            movieComboBox.SelectedItem = sender.ToString();
            string[] movie_number = movieComboBox.Text.Split('.');
            Console.WriteLine("TTTT " + movie_number[0]);


            movie_select = (int)Int64.Parse(movie_number[0]);
            Console.WriteLine("k: " + movie_select.ToString());
            read_seats();


        }
        private void read_seats()
        {
            if(movie_select!=-1)
            {
                seats = new List<int>();

                Cinema_DB cinema = new Cinema_DB();
                //Rezervation rezervation = new Rezervation();
                rezervations = cinema.read_Rezervation();

                // Movie id:
                //label2.Text = i.ToString();


                movie_selected = cinema.find_movie(movie_select);

                foreach (Rezervation rezervation in rezervations)
                {
                    if (rezervation.movie == movie_select)
                    {
                        seats.Add(rezervation.place);
                    }
                    movie_selected = cinema.find_movie(movie_select);
                }
                movie_selected = cinema.find_movie(movie_select);
                foreach (int el in seats)
                {
                    seat_taken(el);
                }
            }
            
        }
        private void seat_taken(int which)
        {
            Button button = new Button();

            //progressBar1.Value = 900;

            if (which == 1)
            {
                button = button1;
            }
            else if (which == 2)
            {
                button = button2;
            }
            else if (which == 3)
            {
                button = button3;
            }
            else if (which == 4)
            {
                button = button4;
            }
            else if (which == 5)
            {
                button = button5;
            }
            else if (which == 6)
            {
                button = button6;
            }
            else if (which == 7)
            {
                button = button7;
            }
            else if (which == 8)
            {
                button = button8;
            }
            else if (which == 9)
            {
                button = button9;
            }
            else if (which == 10)
            {
                button = button10;
            }
            else if (which == 11)
            {
                button = button11;
            }
            else if (which == 12)
            {
                button = button12;
            }
            else if (which == 13)
            {
                button = button13;
            }
            else if (which == 14)
            {
                button = button14;
            }
            else if (which == 15)
            {
                button = button15;
            }

            button.BackColor = Color.Gray;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void user_number(int i)
        {
            label1.Text = i.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.Red) goto dontDo;

            var frm = new ChangeInfoForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            frm.myLogin(Int32.Parse(label1.Text));

            button17.BackColor = Color.Red;
            this.Hide();
        dontDo:;

        }
    }
}
