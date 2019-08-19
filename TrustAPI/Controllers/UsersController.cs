using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TrustAPI.Models;
using TrustAPI.Models.Model;

namespace TrustAPI.Controllers
{
    public class UsersController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();


        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            var results = new Result();
            results.Status = "Error";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            UserManagemen wrapper = new UserManagemen(user.Password);
            string cipherText = wrapper.EncryptData("");
            if (db.Cn_Users.Where(x => x.User_Name == user.User_Name && x.Password == cipherText).Any())
            {
                results.Status = "Success";
                results.Message = "Yes, you are";
            }

            return Json(results);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}