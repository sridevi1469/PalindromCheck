using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaliAPI.Model;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaliAPI.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalindromeController : ControllerBase
    {
        // GET: api/<PalindromeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PalindromeController>/5
        [HttpGet("{PaliString}")]
        public ActionResult<string> GetPalindromeString(string PaliString)
        {
            PaliCheck ps = new PaliCheck();

            return(ps.longestPali(PaliString));


          
        }

       
      
    }
}
