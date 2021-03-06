﻿using İMDB.DAL;
using İMDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace İMDB.Web
{
    public partial class MovieList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropMovieType.DataSource = MovieTypeRepository.GetAllMovieType();
                DropMovieType.DataTextField = "MovieTypeName";
                DropMovieType.DataValueField = "MovieTypeID";
                DropMovieType.DataBind();

                if (Request.QueryString["sort"] == "rating_desc")
                {
                    Repeater1.DataSource = MovieRepositery.GetAllDRating();
                    Repeater1.DataBind();
                }


                else
                {

                    if (Request.QueryString["ID"] != null && !IsPostBack)
                    {
                        int id = int.Parse(Request.QueryString["ID"]);
                        MovieRepositery.DeleteMovie(id);
                        Response.Redirect("MovieList.aspx");

                    }

                }

                Repeater1.DataSource = MovieRepositery.GetAllMovie();
                Repeater1.DataBind();
            }

        }

        protected void DropMovieType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Repeater1.DataSource= MovieRepositery.GetAllMovieType(int.Parse(DropMovieType.SelectedItem.Value));
            Repeater1.DataBind();
        }
    }
}
    
