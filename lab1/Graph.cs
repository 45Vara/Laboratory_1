using System;
using System.Collections.Generic;

namespace lab1
{
    public class Graph
    {
        public static Dictionary<char, List<string[]>> AdjacencyList(string input)
        {
            return new Dictionary<char, List<string[]>>
            {
                { 'A', new List<string[]> { new string[2] { "B", "inherit" }, new string[2] { "E" , "aggregation"}} },
                { 'C', new List<string[]> { new string[2] { "B" , "inherit" } } },
                { 'E', new List<string[]> { new string[2] { "A" , "inherit" } } },
                { 'D', new List<string[]> { new string[2] { "C" , "inherit" } } },
                { 'F', new List<string[]> { new string[2] { "C" , "inherit" } } }
            };
        }
    }
}