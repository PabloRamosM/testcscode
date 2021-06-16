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
        //Post
        [HttpPost]
        public IActionResult AddNewNode(int id)
        {
            var getGraphId=GraphDB.Instance.GetGraph(id);
            getGraphId.Nodes.Add(new Node());
            return Ok();
        }

        [HttpGet]
        public IActionResult GetActionResult(int id)
        {   
            
            var getGraphId=GraphDB.Instance.GetGraph(id);
            	
            if(getGraphId==null)
            {
                return NotFound();
            }
            return Ok(getGraphId.Nodes);
        }
        //Elimina todos los nodos 
        [HttpDelete]
        public IActionResult DeleteAllNodes(int id)
        {
            var  getGraphId=GraphDB.Instance.GetGraph(id);
            if(getGraphId==null)
            {
                return NotFound(); 
            }else
            {
                getGraphId.Nodes.Clear();
                return Ok();
            }
        }
        // Elimina nodo respecto al id
         //Este metodo aun no funciona
        [HttpDelete("id")]
        public IActionResult Delete(int id,int idNode)
        {
            var getGraphId=GraphDB.Instance.GetGraph(id);
            if(getGraphId!=null){
                return NotFound();
            }else
            {   
                for(int length=0;length<getGraphId.Nodes.Count;length++)
                {
                    if(getGraphId.Nodes[length].Id==id)
                    {
                        getGraphId.Nodes.RemoveAt(length);
                        return Ok();
                    }
                }return NotFound();
            }

        }


    }
 
}
