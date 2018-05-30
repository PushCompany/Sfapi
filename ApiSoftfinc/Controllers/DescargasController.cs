using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiSoftfinc.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class DescargasController : Controller
    {
        [HttpGet("{Secret}")]
        public async Task<IActionResult> App(string Secret)
        {
            if (Secret == null)
                return Content("filename not present");

            var path = Path.Combine(
              Directory.GetCurrentDirectory(),
              "wwwroot\\empresa#1\\", "SoftFinc.apk");


            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, System.Net.Mime.MediaTypeNames.Application.Octet, Path.GetFileName(path));

        }
    }
}