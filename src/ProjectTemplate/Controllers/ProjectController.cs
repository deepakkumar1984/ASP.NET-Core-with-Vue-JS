using ASP.NET_Core_SPA_with_Vue_Js2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_SPA_with_Vue_Js2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        [HttpGet]
        [Route("list")]
        public async Task<List<ProjectModel>> List()
        {
            var json = await System.IO.File.ReadAllTextAsync("./data/projects.json");
            return JsonConvert.DeserializeObject<List<ProjectModel>>(json);
        }

        [HttpGet]
        [Route("details/{id}")]
        public async Task<ProjectModel> Get(string id)
        {
            var json = await System.IO.File.ReadAllTextAsync("./data/projects.json");
            var projects = JsonConvert.DeserializeObject<List<ProjectModel>>(json);
            var project = projects.Where(x => x.ID == id.ToUpper()).FirstOrDefault();
            return project;
        }
    }
}
