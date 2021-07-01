using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FVJsonController : ControllerBase
    {
        [HttpPut]
        public void SetPT(PriceTag pt)
        {

        }

        [HttpGet]
        public PriceTag GetPT()
        {
            //return new PriceTag("productName", "EAN", 13.42f, "EUR", new PTChild());
            return new PriceTag();
        }
    }
}
