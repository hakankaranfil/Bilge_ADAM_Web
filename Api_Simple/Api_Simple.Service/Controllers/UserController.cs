﻿using Api_Simple.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Simple.Service.Controllers
{
    public class UserController : ApiController
    {
        public List<User> Get()
        {
            using (UserDBContext db=new UserDBContext())
            {
                return db.User.ToList();
            }
        }
    }
}
