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
    public class VehicleController : ApiController
    {
        private EntityTRUST db = new EntityTRUST();

        // GET: api/Vehicle
        public IQueryable<Ms_Vehicle> GetMs_Vehicles()
        {
            return db.Ms_Vehicles.Where(x => x.IsDeleted == false).Select(x => new Ms_Vehicle {license_no = x.license_no, Vehicle_id = x.Vehicle_id,
                Brand_Name = x.Ms_Vehicle_Models.Ms_Vehicle_Brands.Brand_Name, type = x.Ms_Vehicle_Models.Type });
        }

        // GET: api/Vehicle/5
        public Ms_Vehicle GetMs_Vehicles(int id)
        {
            Ms_Vehicle ms_Vehicles = db.Ms_Vehicles.Where(x => x.IsDeleted == false).Select(x => new Ms_Vehicle
            {
                license_no = x.license_no,
                Vehicle_id = x.Vehicle_id,
                Brand_Name = x.Ms_Vehicle_Models.Ms_Vehicle_Brands.Brand_Name,
                type = x.Ms_Vehicle_Models.Type
            }).FirstOrDefault();
            if (ms_Vehicles == null)
            {
                return null;
            }

            return ms_Vehicles;
        }

        // PUT: api/Vehicle/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMs_Vehicles(int id, Ms_Vehicles ms_Vehicles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ms_Vehicles.Vehicle_id)
            {
                return BadRequest();
            }

            db.Entry(ms_Vehicles).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Ms_VehiclesExists(id))
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

        // POST: api/Vehicle
        [ResponseType(typeof(Ms_Vehicles))]
        public IHttpActionResult PostMs_Vehicles(Ms_Vehicles ms_Vehicles)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ms_Vehicles.Add(ms_Vehicles);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ms_Vehicles.Vehicle_id }, ms_Vehicles);
        }

        // DELETE: api/Vehicle/5
        [ResponseType(typeof(Ms_Vehicles))]
        public IHttpActionResult DeleteMs_Vehicles(int id)
        {
            Ms_Vehicles ms_Vehicles = db.Ms_Vehicles.Find(id);
            if (ms_Vehicles == null)
            {
                return NotFound();
            }

            db.Ms_Vehicles.Remove(ms_Vehicles);
            db.SaveChanges();

            return Ok(ms_Vehicles);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Ms_VehiclesExists(int id)
        {
            return db.Ms_Vehicles.Count(e => e.Vehicle_id == id) > 0;
        }
    }
}