using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAppAPI.Database;
using WebAppAPI.Models;

namespace WebAppAPI.Controllers
{
    public class DefaultController : ApiController
    {
        DatabaseContext db = new DatabaseContext();

        //api/user
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return db.Users.ToList();
        }

        // [HttpGet]
        // public string Greet(string StrName ="Web Service is running!")
        // {
        //     return  StrName;
        // }

        //api/user/2
        [HttpGet]
        public User GetUsers(int id)
        {
            return db.Users.Find(id);
        }

        //
        [HttpPost]
        public HttpResponseMessage AddUser(User Umodel)
        {
            try 
            {
                db.Users.Add(Umodel);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
            
        }

        [HttpPut]
        public HttpResponseMessage UpdateUser(int Id, User Umodel)
        {
            try
            {
                if (Id == Umodel.UserId)
                {
                    db.Entry(Umodel).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
                }
                
                
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }

        }

        public HttpResponseMessage DeleteUser(int Id)
        {
            User user = db.Users.Find(Id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            else 
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }
        }
    }
}
