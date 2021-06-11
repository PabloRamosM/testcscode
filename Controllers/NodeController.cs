using System;
using System.Collections.Generic;
using graph.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace graph.Controllers{
    [ApiController]
    [Route("api/Graph/{Graphid}/Node")]
    public class NodeController: Controller
    {
        
        private readonly ILogger<NodeController> _logger;
       
        public static List<Graph> graphs= new List<Graph>();

        public NodeController(ILogger<NodeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetActionResult(int id)
        {
            return Ok();
        }
    }
 
}
