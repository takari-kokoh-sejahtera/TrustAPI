using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TrustAPI.Models;
using TrustAPI.Models.Model;

namespace TrustAPI.Controllers
{
    public class BSTKBeforeForAfterController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();
        public IQueryable<Tr_BSTKBeforeForAfter> GetTr_BSTKBeforeValue()
        {
            return db.Tr_BSTKBefores.Where(x => x.IsCompleted == false).Select(x =>
            new Tr_BSTKBeforeForAfter
            {
                BSTKBefore_ID = x.BSTKBefore_ID,
                Company_Name = x.Ms_Customers.Company_Name,
                license_no = x.Ms_Vehicles.license_no,
                Type = x.Ms_Vehicles.Ms_Vehicle_Models.Type
            });
        }
        // GET: api/BSTKAfter/5

        public IQueryable<Tr_BSTKBeforeForAfter> GetTr_BSTKBeforeValue(int id)
        {
            return db.Tr_BSTKBefores.
                Where(x => x.IsCompleted == false && x.CreatedBy == id).Select(x =>
                 new Tr_BSTKBeforeForAfter
                 {
                     BSTKBefore_ID = x.BSTKBefore_ID,
                     Company_Name = x.Ms_Customers.Company_Name,
                     license_no = x.Ms_Vehicles.license_no,
                     Type = x.Ms_Vehicles.Ms_Vehicle_Models.Type
                 });
        }

    }
}
