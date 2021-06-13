using System;
using System.Collections.Generic;
using graph.Database;
using graph.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace graph.Controllers{
    
    [ApiController]
    [Route("api/Graph/{id}/[controller]")]
    public class NodeController: Controller
    {
        
        private readonly ILogger<NodeController> _logger;

        public NodeController(ILogger<NodeController> logger)
        {
            _logger = logger;
        }
            
        [HttpGet()]
        public IActionResult GetActionResult(int id)
        {   var getGraphId=GraphDB.Instance.GetGraph(id);
            if(getGraphId==null)
            {
                return NotFound();
            }
            return Ok(getGraphId.Nodes);
        }
    }
 
}
