using System;
using System.Collections.Generic;
namespace graph.Entities
{
    public class Graph
    {
        private static int currentId=0;
        private int id;
        private List<Node> nodes;
        
        public Graph(){
            this.id= currentId++;
        }

        public Graph(int id)
        {
            this.id=id;
        }

        public int Id
        {
            get{return this.id;}
            set {this.id=value;}
        }

        public List<Node> Nodes { get => nodes;}
    }
}