using İMDB.DAL;
using İMDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İMDB.Web
{
    public partial class MovieAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropMovieType.DataSource = MovieTypeRepository.GetAllMovieType();
                DropMovieType.DataTextField = "MovieTypeName";
                DropMovieType.DataValueField = "MovieTypeID";
                DropMovieType.DataBind();
                DropDirector.DataSource = DirectorRepository.GetAllDirector();
                DropDirector.DataTextField = "DirectorName";
                DropDirector.DataValueField = "DirectorID";
                DropDirector.DataBind();

               
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieName = txtMovieName.Text;
            movie.MovieSubject = txtSubject.Text;
            movie.MovieRating =int.Parse( txtMovieRating.Text);
            movie.RealiseDate =Convert.ToDateTime( txtRealiseDate.Text);
            movie.MovieTypeID = Convert.ToInt32(DropMovieType.SelectedItem.Value);
            movie.DirectorID = Convert.ToInt32(DropDirector.SelectedItem.Value);
            MovieRepository.AddMovie(movie);
            Response.Redirect("MovieList.aspx");
        }
    }
}