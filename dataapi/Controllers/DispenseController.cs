using dataapi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dataapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DispenseController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public DispenseController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TBL_DISPENSELOG>> Get()
        {
            return this._context.TBL_DISPENSELOG.OrderByDescending(x => x.CreatedDate).ToList();
        }

        [HttpPost]
        public ActionResult<TBL_DISPENSELOG> PostDispense(TBL_DISPENSELOG dispenselog)
        {
            DateTime utcTime = DateTime.UtcNow;
            
            dispenselog.CreatedDate = utcTime.AddHours(8);
            this._context.TBL_DISPENSELOG.Add(dispenselog);
            this._context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = dispenselog.DISPENSELOGID}, dispenselog);
        }
    }
}
