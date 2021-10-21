using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphtest
{
    class Graph<T> where T : IComparable
    {

        // list of graphnodes in the graph (nodes in the graph)
        private LinkedList<GraphNode<T>> nodes;

        // constructor. set the list of nodes in the graph to be the empty list 
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        // check if the graph is empty (no node is present)
        public bool IsEmptyGraph()
        {
            //if the number of the elements within nodes is equal to 0, return true;
            //otherwise, return false; 
            return nodes.Count == 0;
        }

        // returns the total number of nodes present in the graph
        public int NumNodesGraph()
        {
            return nodes.Count;

        }

        public void RemoveNode(T id)
        {
            GraphNode<T> nodeToRemove = GetNodeByID(id);
            if (nodeToRemove == null)
            {
                // wasnt found
                return;
            }

            nodes.Remove(nodeToRemove);//get graph node with that ID and then pass the graph node

        }

        public void RemoveEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);


            if (n1 != null & n2 != null)
            {
                n1.RemoveEdge(n2);
            }
            else
                return;
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            // to be completed: add a check that node is not null

            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                {

                    return true;
                }

            }

            return false;
        }


        // add a new node in the graph. use constructor of graphnode
        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        // only returns true if node is present in the graph


        //returns the node with this id
        public GraphNode<T> GetNodeByID(T id)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                    return n;
            }
            return null;
        }

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {

            foreach (GraphNode<T> n in nodes)
            {
                if (from.ID.CompareTo(n.ID) == 0)
                {
                    if (from.GetAdjList().Contains(to.ID))
                        return true;

                }

            }
            return false;
        }

        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);


            if (n1 != null & n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
                Console.WriteLine("Node/s not found in the graph. Cannot add the edge");
        }

        // return true if “to” is adjacent to “from”










    }


}
