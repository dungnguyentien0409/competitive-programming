/*
 * Problem: Dijkstra algorithm
 * Author: Dung Nguyen Tien (Chris)
*/

public class Dijkstra
{
	int[,] graph;
	int vertex;
	bool[] visited;
	int[] distance;
	int[] previousNode;
	public Dijkstra(int v, int[,] g)
	{
		graph = g;
		vertex = v;
		visited = new bool[v];
		distance = new int[v];
		previousNode = new int[v];

		Array.Fill(visited, false);
		Array.Fill(distance, Int32.MaxValue);
	}

	public int GetMinVertex()
	{
		var min = Int32.MaxValue;
		var iMin = -1;

		for (var i = 0; i < vertex; i++)
		{
			if (!visited[i] && distance[i] < min)
			{
				min = distance[i];
				iMin = i;
			}
		}

		return iMin;
	}

	public int[] BuildSPT(int start)
	{
		distance[start] = 0;
		previousNode[0] = -1;

		for (var count = 0; count < vertex - 1; count++)
		{
			var u = GetMinVertex();

			// dont find any way
			if (u == -1) break;

			this.visited[u] = true;

			for (var v = 0; v < vertex; v++)
			{
				if (this.graph[u, v] != 0
					&& this.distance[v] > this.distance[u] + graph[u, v])
				{
					this.distance[v] = this.distance[u] + graph[u, v];
					this.previousNode[v] = u;
				}
			}
		}

		return this.distance;
	}

	public void PrintTree()
	{
		for (var i = 0; i < previousNode.Length; i++)
		{
			Console.WriteLine(i + " " + previousNode[i]);
		}
	}