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
    public class BSTKBeforeController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();

        private bool Validasi(Tr_BSTKBefore BSTKBefore, string result)
        {
            if (db.Ms_Customers.Any(x => x.Company_Name == BSTKBefore.Nama_Customer))
            {
                result = "Company Name does't exist!";
                return false;
            }
            else if (!db.Ms_Vehicles.Any(x => x.license_no == BSTKBefore.Nomor_Plat_Kendaraan))
            {
                result = "license no does't exist!";
                return false;
            }
            return true;
        }

        // POST: api/BSTKBefore
        [ResponseType(typeof(Tr_BSTKBefore))]
        public IHttpActionResult PostTr_BSTKBefores(Tr_BSTKBefore BSTKBefores)
        {
            var results = new Result();
            results.Status = "Error";
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (Validasi(BSTKBefores, results.Message)) {

            }
            //if (db.Cn_Users.Where(x => x.User_Name == user.User_Name && x.Password == cipherText).Any())
            //{
            //    results.Status = "Success";
            //    results.Message = "Yes, you are";
            //}

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

        private bool Tr_BSTKBeforesExists(int id)
        {
            return db.Tr_BSTKBefores.Count(e => e.BSTKBefore_ID == id) > 0;
        }
    }
}