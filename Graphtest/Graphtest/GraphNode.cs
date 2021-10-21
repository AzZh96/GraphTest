using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphtest
{
    class GraphNode<T> where T : IComparable
    {
        private T id; // data stored in the node. can think like the (unique) "label" of the node
        private LinkedList<T> adjList; // adjacent list of the node

        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        // set and get the data stored in the node 
        public T ID
        {
            set { id = value; }
            get { return id; }
        }

        //add edge from this node to the node "to"; it is an unweighted and *directed* graph. 
        public void AddEdge(GraphNode<T> to)
        {
            adjList.AddLast(to.ID);
        }

        // return the adjacent list of the node (needed for the visit of the graph)
        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }

        public void RemoveEdge(GraphNode<T> to)
        {
            adjList.Remove(to.ID);
        }




    }
}
