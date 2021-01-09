using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class DatiPioggiaController : Controller
    {
        [HttpGet]
        [Route("GetNow")]
        public Int64 GetNow()
        {
            return 124;
            //var databaseHelper = new DatabaseHelper();
            //var pioggia = databaseHelper.GetPioggiaAdesso();
            //return pioggia.Valore;
        }
    }
}
