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
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cinema_DB cinema = new Cinema_DB();

            string duration = DurationBox.Text;
            string title = titleMovieBox.Text;
            string time = TimeBox.Text;
            string date = DateBox.Text;


            Movie movie = new Movie();
            movie.duration = duration;
            movie.title = title;
            movie.time = time;
            movie.date = date;

            cinema.add_movie(movie);
            MessageBox.Show("Film dodany");
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
