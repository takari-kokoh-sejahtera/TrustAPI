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
    public class CustomerController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();

        // GET: api/Customer
        public IQueryable<Ms_Customer> GetMs_Customers()
        {

            //return db.Ms_Customers.Select(x => new Ms_Customer { Customer_ID = x.Customer_ID, CompanyGroup = x.Ms_Customer_CompanyGroups.CompanyGroup_Name, Company_Name = x.Company_Name,PT =x.PT,
            //Tbk=x.Tbk, Address=x.Address, City=x.Ms_Citys.City, Phone = x.Phone, Email = x.Email, PIC_Email = x.PIC_Email, PIC_Name = x.PIC_Name, PIC_Phone=x.PIC_Phone} );
            return db.Ms_Customers.Where(x => x.IsDeleted == false).Select(x => new Ms_Customer { Company_Name = x.Company_Name} ).OrderBy(x => x.Company_Name);
        }

        // GET: api/Customer/5
        [ResponseType(typeof(Ms_Customers))]
        public IHttpActionResult GetMs_Customers(int id)
        {
            Ms_Customers ms_Customers = db.Ms_Customers.Find(id);
            if (ms_Customers == null)
            {
                return NotFound();
            }

            return Ok(ms_Customers);
        }

        // PUT: api/Customer/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMs_Customers(int id, Ms_Customers ms_Customers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ms_Customers.Customer_ID)
            {
                return BadRequest();
            }

            db.Entry(ms_Customers).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Ms_CustomersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Customer
        [ResponseType(typeof(Ms_Customers))]
        public IHttpActionResult PostMs_Customers(Ms_Customers ms_Customers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ms_Customers.Add(ms_Customers);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ms_Customers.Customer_ID }, ms_Customers);
        }

        // DELETE: api/Customer/5
        [ResponseType(typeof(Ms_Customers))]
        public IHttpActionResult DeleteMs_Customers(int id)
        {
            Ms_Customers ms_Customers = db.Ms_Customers.Find(id);
            if (ms_Customers == null)
            {
                return NotFound();
            }

            db.Ms_Customers.Remove(ms_Customers);
            db.SaveChanges();

            return Ok(ms_Customers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Ms_CustomersExists(int id)
        {
            return db.Ms_Customers.Count(e => e.Customer_ID == id) > 0;
        }
    }
}