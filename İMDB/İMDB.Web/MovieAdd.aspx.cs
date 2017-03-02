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
            if (Request.QueryString["ID"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["ID"]);
                var result = MovieRepositery.GetMovie(id);
                txtMovieName.Text = result.MovieName;
                txtSubject.Text = result.MovieSubject;
                txtMovieRating.Text =result.MovieRating.ToString();
                DropMovieType.DataSource = MovieTypeRepository.GetAllMovieType();
                DropMovieType.DataTextField = "MovieTypeName";
                DropMovieType.DataValueField = "MovieTypeID";
                DropMovieType.DataBind();
                DropDirector.DataSource = DirectorRepository.GetAllDirector();
                DropDirector.DataTextField = "DirectorName";
                DropDirector.DataValueField = "DirectorID";
                DropDirector.DataBind();
                btnKaydet.CssClass = "btn btn-Info btn-block";
                btnKaydet.Text = "Güncelle";

            }
            else
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
          
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            if (btnKaydet.Text == "Güncelle")
            {
                movie.MovieName = txtMovieName.Text;
                movie.MovieSubject = txtSubject.Text;
                movie.MovieRating =int.Parse( txtMovieRating.Text);
                movie.MovieTypeID= Convert.ToInt32(DropMovieType.SelectedItem.Value);
                movie.RealiseDate= Convert.ToDateTime(txtRealiseDate.Text);
                movie.DirectorID = Convert.ToInt32(DropDirector.SelectedItem.Value);
                int id = int.Parse(Request.QueryString["ID"]);
                MovieRepositery.UpdateMovie(id, txtMovieName.Text,txtSubject.Text,int.Parse(txtMovieRating.Text),int.Parse(DropDirector.SelectedItem.Value), int.Parse(DropMovieType.SelectedItem.Value),Convert.ToDateTime(  txtRealiseDate.Text));
                Response.Redirect("MovieList.aspx");
            }
            movie.MovieName = txtMovieName.Text;
            movie.MovieSubject = txtSubject.Text;
            movie.MovieRating =int.Parse( txtMovieRating.Text);
            movie.RealiseDate =Convert.ToDateTime( txtRealiseDate.Text);
            movie.MovieTypeID = Convert.ToInt32(DropMovieType.SelectedItem.Value);
            movie.DirectorID = Convert.ToInt32(DropDirector.SelectedItem.Value);
            MovieRepositery.AddMovie(movie);
            Response.Redirect("MovieList.aspx");
        }
    }
}