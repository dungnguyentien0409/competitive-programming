/*
 * Problem: Floyd
 * Author: Dung Nguyen Tien (Chris)
*/

public class Floyd
{
	int[,] graph;
	int vertex;
	int[] previous;

	public Floyd(int[,] g, int v)
	{
		graph = g;
		vertex = v;
		previous = new int[vertex];
	}
	public void floydWarshall(int[,] graph)
	{
		for (var i = 0; i < vertex; i++)
		{
			for (var j = 0; j < vertex; j++)
			{
				for (var k = 0; k < vertex; k++)
				{
					if (graph[i, k] + graph[k, j] < graph[i, j])
					{
						graph[i, j] = graph[i, k] + graph[k, j];
						previous[k] = i;
						previous[j] = k;
					}
					else if (graph[i, j] != Int32.MaxValue)
					{
						previous[j] = i;
					}
				}
			}
		}

		printSolution(graph);
		printTree(previous);
	}

	public void printTree(int[] previous)
	{
		for (var i = 0; i < previous.Length; i++)
		{
			Console.WriteLine(i + " " + previous[i]);
		}
	}

	public void printSolution(int[,] dist)
	{
		Console.WriteLine("Following matrix shows the shortest " +
						"distances between every pair of vertices");
		for (int i = 0; i < vertex; ++i)
		{
			for (int j = 0; j < vertex; ++j)
			{
				if (dist[i, j] == Int32.MaxValue)
				{
					Console.Write("INF ");
				}
				else
				{
					Console.Write(dist[i, j] + " ");
				}
			}

			Console.WriteLine();
		}
	}
}