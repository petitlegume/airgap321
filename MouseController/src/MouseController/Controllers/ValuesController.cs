using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MouseController.Helpers;

namespace MouseController.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private MouseControls mouse;

        public ValuesController()
        {
            mouse = new MouseControls();
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet]
        [Route("move")]
        public string Get([FromQuery]int x, [FromQuery]int y)
        {
            //example query: http://localhost:60200/api/values/move?x=200&y=100
            mouse.MoveCursorFrom(x, y);
            return "done";
        }
        
    }
}
