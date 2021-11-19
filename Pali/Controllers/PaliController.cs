using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pali.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaliController : ControllerBase
    {
        //// GET: api/<PaliController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

       

        // GET api/<PalindromeController>/5
        [HttpGet("{PaliString}")]
        public ActionResult<string> GetPalindromeString(string PaliString)
        {
            PaliCheck ps = new PaliCheck();

            return (ps.checkPalindrome(PaliString));



        }
    }
}
