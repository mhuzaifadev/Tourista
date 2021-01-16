using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourista.Data;

namespace Tourista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristaDataController : ControllerBase
    {
        public TouristaDataController(DBContext dBContext)
        {
            DBContext = dBContext;
        }


        public DBContext DBContext { get; }

        [HttpGet]
        [Route("gettouristadata")]
        public async Task<IActionResult> GetTouristaData()
        {
             try
            {
                var touristData =await DBContext.TouristaData.ToListAsync();
                return Ok(touristData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }

        }
    }
}
