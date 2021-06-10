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
    [Route("api/[controller]")]
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
        [HttpGet("{id}")]
        public IActionResult GetGraph(int id)
        {
            foreach (Graph g in graphs) {
                if (g.Id == id) {
                    return Ok(g);
                }
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Post()
        {
            GraphController.graphs.Add(new Graph());
            return Ok();
        }
        //Elimina todos los grafos
        [HttpDelete]
        public IActionResult DeleteAllGraphs()
        {
            if(graphs==null)
            {
                return NotFound();
            }else
            {
                graphs.Clear();
                return Ok();
            }  
        }
        //Elimina el grafo con respecto al Id
        [HttpDelete("{id}")]
        public IActionResult DeleteIdGraph(int id)
        {
             if(graphs==null)
            {
                return NotFound();
            }else
            {
                graphs.Remove(graphs[id]);
                return Ok();
            }  
        }
    }
}
