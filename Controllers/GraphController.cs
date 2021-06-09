using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using graph.Entities;

namespace graph.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GraphController : ControllerBase
    {
        private readonly ILogger<GraphController> _logger;
       
        private static List<Graph> graphs= new List<Graph>();

        public GraphController(ILogger<GraphController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Graph> Get()
        {
            return GraphController.graphs;
        }
        [HttpPost]
        public IActionResult Post()
        {
            GraphController.graphs.Add(new Graph());
            return Ok();
        }
    }
}
