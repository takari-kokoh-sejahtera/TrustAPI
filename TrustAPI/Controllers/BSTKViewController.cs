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
    public class BSTKViewController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();

        public IQueryable<BSTKView> GetBSTKViesValue(int id)
        {
            return db.Tr_BSTKBefores.OrderByDescending(x => x.CreatedDate).
                Where(x => x.IsDeleted == false && x.CreatedBy == id).Select(x =>
                 new BSTKView
                 {
                     BSTKBefore_ID = x.BSTKBefore_ID,
                     Company_Name = x.Ms_Customers.Company_Name,
                     license_no = x.Ms_Vehicles.license_no,
                     Type = x.Ms_Vehicles.Ms_Vehicle_Models.Type,
                     IsCompleted = (bool)x.IsCompleted
                 });
        }

    }
}
