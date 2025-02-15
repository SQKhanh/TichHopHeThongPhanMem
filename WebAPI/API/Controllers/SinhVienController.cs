using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class SinhVienController : ApiController
    {
        // GET api/<controller>
        public List<SinhVien> Get()
        {
            using (var db = new HRMContect())
            {
                return db.SinhViens.ToList();
            }
        }

        // GET api/<controller>/5
        public SinhVien Get(string code)
        {
            using (var db = new HRMContect())
            {
                return db.SinhViens.Find(code);
            }
        }

        // POST api/<controller>
        public void Post(SinhVien sv)
        {
            using (var db = new HRMContect())
            {
                db.SinhViens.Add(sv);
                db.SaveChanges();
            }
        }

        // PUT api/<controller>/5
        public void Put(SinhVien sv)
        {
            using (var db = new HRMContect())
            {
                var svDb = db.SinhViens.Find(sv.code);
                svDb.fullname = sv.fullname;
                svDb.birthday = sv.birthday;
                db.SaveChanges();
            }
        }

        // DELETE api/<controller>/5
        public void Delete(SinhVien sv)
        {
            using (var db = new HRMContect())
            {
                db.SinhViens.Remove(sv);
                db.SaveChanges();
            }
        }
    }
}