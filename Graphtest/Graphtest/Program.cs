﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphtest
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a graph with ID of nodes as 'char'
            Graph<char> myGraph = new Graph<char>();

            // add nodes in the graph
            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');
            myGraph.AddNode('E');

            // add connections between the nodes. these are direct edges
            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');
            myGraph.AddEdge('B', 'C');
            myGraph.AddEdge('D', 'A');
            myGraph.AddEdge('D', 'E');

            myGraph.AddEdge('A', 'E');

            
            myGraph.RemoveEdge('D', 'E');
            
          

            Console.WriteLine("Is myGraph empty? Answer: {0}", myGraph.IsEmptyGraph());

            // is there an edge from 'A' to 'B' ?

            Console.WriteLine("Is there an edge from {0} to {1}? {2}",
            myGraph.GetNodeByID('A').ID, myGraph.GetNodeByID('B').ID,
            myGraph.GetNodeByID('A').GetAdjList().Contains('B'));


            // is there an edge from 'B' to 'A' ?

            Console.WriteLine("Is there an edge from {0} to {1}? {2}",
            myGraph.GetNodeByID('B').ID, myGraph.GetNodeByID('A').ID,
            myGraph.GetNodeByID('B').GetAdjList().Contains('A'));



            Console.WriteLine("Is node {0} adjacent to node {1} ? Answer: {2}",
     myGraph.GetNodeByID('B').ID,
     myGraph.GetNodeByID('C').ID,
     myGraph.IsAdjacent(myGraph.GetNodeByID('C'), myGraph.GetNodeByID('B')));

            Console.WriteLine("Is node {0} adjacent to node {1} ? Answer: {2}",
                 myGraph.GetNodeByID('E').ID,
                 myGraph.GetNodeByID('D').ID,
                 myGraph.IsAdjacent(myGraph.GetNodeByID('D'), myGraph.GetNodeByID('E')));

            Console.ReadKey();


            Console.ReadKey();


        }

    }
}
