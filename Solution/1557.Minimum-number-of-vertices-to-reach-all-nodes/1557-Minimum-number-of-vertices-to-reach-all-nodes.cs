using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1557.Minimum_number_of_vertices_to_reach_all_nodes
{
    public class _1557_Minimum_number_of_vertices_to_reach_all_nodes
    {
        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            HashSet<int> hash = new HashSet<int>();

            for (int i = 0; i < n; i++)
                hash.Add(i);

            // Just remove reachable vertices.
            foreach (IList<int> edge in edges)
                hash.Remove(edge[1]);

            return new List<int>(hash);
        }
    }
}
