using System;
using System.Collections.Generic;

namespace BreadthFirstSearch
{
	class Program
	{
		static void Main(string[] args)
		{
			int V = 7; // Number of vertices

			List<int>[] adj = new List<int>[V];

			for(int i = 0; i < V; ++i)
				adj[i] = new List<int>();

			AddEdge(adj, 0, 1);
			AddEdge(adj, 0, 2);
			AddEdge(adj, 1, 3);
			AddEdge(adj, 1, 4);
			AddEdge(adj, 2, 5);
			AddEdge(adj, 2, 6);
			
			Console.WriteLine("Breadth-First Traversal (starting from vertex 0):");
			BFS(adj, 0);
		}

		static void AddEdge(List<int>[] adj, int v, int w)
		{
			adj[v].Add(w);
		}

		static void BFS(List<int>[] adj, int s)
		{
			int V = adj.Length;
			bool[] visited = new bool[V];

			Queue<int> queue = new Queue<int>();
			visited[s] = true;
			queue.Enqueue(s);

			while(queue.Count != 0)
			{
				s = queue.Dequeue();
				Console.Write(s + " ");

				foreach (int neighbor in adj[s])
				{
					if(!visited[neighbor])
					{
						visited[neighbor] = true;

						queue.Enqueue(neighbor);
					}
				}
			}
			Console.WriteLine();
		}
	}
}

		
			
