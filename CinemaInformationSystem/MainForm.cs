using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Db_Context;
using Repository.Entities;

namespace CinemaInformationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CinemaDbContext cinemaDbContext = new CinemaDbContext();
            Movie movie = new Movie(Guid.NewGuid(), "Cinderella", "Animation", "Walt Disney", DateTime.Today);
            cinemaDbContext.Add(movie);
            cinemaDbContext.SaveChanges();
        }

        private void AddNewMovieButton_Click(object sender, EventArgs e)
        {

        }
    }
}
