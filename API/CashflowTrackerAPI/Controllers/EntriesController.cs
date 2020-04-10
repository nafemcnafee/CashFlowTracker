using CashflowTrackerAPI.Data;
using CashflowTrackerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CashflowTrackerAPI.Controllers
{
    [EnableCors("http://localhost:4200","*","*")]
    public class EntriesController : ApiController
    {
        public IHttpActionResult GetEntries()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var entries = context.Entries.ToList();
                    return Ok(entries);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
            
        }
        [HttpPost]
        public IHttpActionResult PostEntry([FromBody]Entry entry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entries.Add(entry);
                    context.SaveChanges();

                    return Ok("Entry was created!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        
    }
}
