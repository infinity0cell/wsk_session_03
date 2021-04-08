using System;
using System.Collections.Generic;
using System.Linq;

namespace session_03.src.lib.GraphAllPathsFinder
{
    class GraphsTest
    {
        public static void Main_()
        {
            var schedules = 1;

            var auh = new GraphNodeWithData<string>("My test data", "AUH");
            var ade = new GraphNode("ADE");
            var ruh = new GraphNode("RUH");
            var cai = new GraphNode("CAI");
            var doh = new GraphNode("DOH");
            var bah = new GraphNode("BAH");

            auh.AddChildren(ade)
                .AddChildren(ruh)
                .AddChildren(cai)
                .AddChildren(doh)
                .AddChildren(bah);
            cai.AddChildren(doh);

            var from = doh;
            var to = cai;

            var search = new GraphAllPathsFinder();
            var paths = search.FindAllPaths(from, to);

            Console.WriteLine($"All paths from {from} to {to}");
            foreach (var path in paths)
                Console.WriteLine(string.Join(" -> ", path));

            Console.ReadLine();
        }
    }

    
}