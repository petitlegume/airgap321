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
            mouse.MoveCursorFrom(x, y);
            return "done";
        }

        [HttpGet]
        [Route("leftclick")]
        public string GetLeftClick()
        {
            mouse.LeftClick();
            return "done";
        }

        [HttpGet]
        [Route("rightclick")]
        public string GetRightClick()
        {
            mouse.RightClick();
            return "done";
        }

    }
}
