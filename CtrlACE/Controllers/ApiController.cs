using CtrlACE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CtrlACE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        DbSalarieContext _context;

        public ApiController(DbSalarieContext context)
        {
            _context = context;
        }

        [HttpGet("byDepartement")]
        public List<Salarie> getSalarieByDepartementId(String departementID)
        {
            List<Salarie> salaries = new List<Salarie>(_context.Salaries);
            List<Salarie> result = new List<Salarie>();
            foreach (Salarie salarie in salaries)
                if(salarie.departementId == departementID)
                    result.Add(salarie);

            return result;
        }
    }
}
