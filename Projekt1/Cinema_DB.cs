using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;
using System.Data;

namespace Projekt1
{
    class Cinema_DB
    {
        static readonly string AppPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static readonly string DbPath = Path.Combine(AppPath, "cinema_db.accdb");
        static readonly string DbConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Łukasz\Desktop\Cinema-Lucas\Projekt1\cinema_db.accdb';Persist Security Info=False;";
        OleDbConnection connection = new OleDbConnection(DbConnString);

        public Cinema_DB()
        {
            if (!File.Exists(DbPath))
                throw new Exception("Database file does not exist!");
            

        }

        public void add_user(User user)
        {

            OleDbCommand command = new OleDbCommand("INSERT INTO users (name, login, [password], surname, worker) VALUES ('" + user.name + "', '" + user.login + "', '" + user.password + "', '" + user.surname + "', " + user.worker.ToString().ToLower() + ")", connection);
            Console.WriteLine("INSERT INTO users (name, login, [password], surname, worker) VALUES ('" + user.name + "', '" + user.login + "', '" + user.password + "', '" + user.surname + "', " + user.worker.ToString().ToLower() + ")", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.BeginTransaction().Commit();
            connection.Close();
            

        }
        public void add_movie(Movie movie)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO movies (title, duration, [date], [time]) VALUES('" + movie.title + "', '" + movie.duration + "', '" + movie.date + "', '" + movie.time + "')", connection);
            Console.WriteLine("INSERT INTO movies (title, duration, [date], [time]) VALUES('" + movie.title + "', '" + movie.duration + "', '" + movie.date + "', '" + movie.time + "')");

            connection.Open();
                command.ExecuteNonQuery();
                connection.BeginTransaction().Commit();
                connection.Close();
            

        }

        public void add_rezervation(Rezervation rezervation)
        {
            OleDbCommand command = new OleDbCommand("INSERT INTO rezervation (place, movie, [user]) VALUES(" + rezervation.place.ToString() + ", " + rezervation.movie.ToString() + ", " + rezervation.user.ToString() + ")", connection);
            Console.WriteLine("INSERT INTO movies (place, movie, [user]) VALUES(" + rezervation.place.ToString() + ", " + rezervation.movie.ToString() + ", " + rezervation.user.ToString() + ")");
            connection.Open();
                command.ExecuteNonQuery();
                connection.BeginTransaction().Commit();
                connection.Close();
            

        }

        public List<User> read_Users()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM users ", connection);
            
            connection.Open();
            DataTable usersTable = new DataTable();
            adapter.Fill(usersTable);
            List<User> users = new List<User>();
            Console.WriteLine(usersTable.Rows.Count);
            foreach(DataRow row in usersTable.Rows)
            {
                int l = (int)Int64.Parse(row["ID"].ToString());
                User u = new User(l, row["name"].ToString(), row["login"].ToString(), row["password"].ToString(), row["surname"].ToString(), bool.Parse(row["worker"].ToString()));
                users.Add(u);
            }
            connection.Close();
            Console.WriteLine(users.Count);
            return users;
        }
        public void delete_User(int id)
        {
            OleDbCommand command = new OleDbCommand("DELETE  FROM users WHERE ID = "+id.ToString()+" ", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.BeginTransaction().Commit();
            connection.Close();
            
        }

        public void delete_Movie(int id)
        {
            OleDbCommand command = new OleDbCommand("DELETE  FROM movies WHERE ID = " + id.ToString() + " ", connection);

            connection.Open();
            connection.Open();
            command.ExecuteNonQuery();
            connection.BeginTransaction().Commit();
            connection.Close();

        }

        public void delete_Rezervation(int id)
        {
            OleDbCommand command = new OleDbCommand("DELETE  FROM rezervation WHERE ID = " + id.ToString() + " ", connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.BeginTransaction().Commit();
            connection.Close();

        }
        public List<Movie> read_Movies()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM movies ", connection);

            connection.Open();
            DataTable moviesTable = new DataTable();
            adapter.Fill(moviesTable);
            List<Movie> movies = new List<Movie>();
            Console.WriteLine(moviesTable.Rows.Count);
            foreach (DataRow row in moviesTable.Rows)
            {
                int l = (int)Int64.Parse(row["ID"].ToString());
                Movie m = new Movie(l, row["title"].ToString(), row["duration"].ToString(), row["date"].ToString(), row["time"].ToString());
                movies.Add(m);
            }
            connection.Close();
            Console.WriteLine(movies.Count);
            return movies;
        }
        public List<Rezervation> read_Rezervation()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM rezervation ", connection);

            connection.Open();
            DataTable rezervationTable = new DataTable();
            adapter.Fill(rezervationTable);
            List<Rezervation> rezervations = new List<Rezervation>();
            Console.WriteLine(rezervationTable.Rows.Count);
            foreach (DataRow row in rezervationTable.Rows)
            {
                int l = (int)Int64.Parse(row["ID"].ToString());
                Rezervation r = new Rezervation(l, (int)Int64.Parse(row["place"].ToString()), (int)Int64.Parse(row["movie"].ToString()), (int)Int64.Parse(row["user"].ToString()));
                rezervations.Add(r);
            }
            connection.Close();
            Console.WriteLine(rezervations.Count);
            return rezervations;
        }

        public User find_user_by_ID(int id)
        {
            List<User> users = read_Users();
            var use = users.Where(u => u.id == id)
                                             .Select(u => u);
            

            return use.FirstOrDefault(); 
        }


        public User find_user_by_login(string login)
        {
            List<User> users = read_Users();
            var use = users.Where(u => u.login == login)
                                             .Select(u => u);


            return use.FirstOrDefault();
        }

        public Movie find_movie(int id)
        {
            Console.WriteLine("DB K:"+id.ToString());
            List<Movie> movies = read_Movies();
            var move = movies.Where(m => m.id == id)
                                             .Select(m => m);


            return move.FirstOrDefault();
        }
        public Rezervation[] find_rezervation_by_User(int id_user)
        {
            List<Rezervation> rezervations = read_Rezervation();
            var reze = rezervations.Where(m => m.user == id_user)
                                             .Select(m => m);


            return reze.ToArray();
        }
        public Rezervation[] find_rezervation_by_Movie(int id_movie)
        {
            List<Rezervation> rezervations = read_Rezervation();
            var reze = rezervations.Where(m => m.movie == id_movie)
                                             .Select(m => m);


            return reze.ToArray();
        }
    }
    class User
    {
        public int id;
        public string name;
        public string login;
        public string password;
        public string surname;
        public bool worker;
        public User(int i=-1, string name="", string login="", string password="", string surname="", bool worker=false)
        {
            this.id = i;
            this.name = name;
            this.login = login;
            this.password = password;
            this.surname = surname;
            this.worker = worker;
        }
    }
    class Movie
    {
        public int id;
        public string title ;
        public string duration;
        public string date;
        public string time;
        public Movie(int id=-1, string title="", string duration="", string date="", string time="")
        {
            this.id = id;
            this.title = title;
            this.duration = duration;
            this.date = date;
            this.time = time;
        }
    }
    class Rezervation
    {
        public int id;
        public int place;
        public int movie;
        public int user;
        public Rezervation(int id=-1, int place=-1, int movie=-1, int user=-1)
        {
            this.id = id;
            this.place = place;
            this.movie = movie;
            this.user = user;
        }
    }
}
