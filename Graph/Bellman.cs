/*
 * Problem: Bellman
 * Author: Dung Nguyen Tien (Chris)
*/

public class Bellman
{
	int[,] graph;
	int vertex;
	int[] distance;

	public Bellman(int[,] g, int v)
	{
		graph = g;
		vertex = v;
		distance = new int[v];
		Array.Fill(distance, Int32.MaxValue);
	}

	public void BellmanSolve(int start)
	{
		distance[start] = 0;

		for (var count = 1; count <= vertex - 1; count++)
		{
			for (var i = 0; i < vertex; i++)
			{
				for (var j = 0; j < vertex; j++)
				{
					if (graph[i, j] != Int32.MaxValue)
					{
						if (distance[j] > distance[i] + graph[i, j])
						{
							distance[j] = distance[i] + graph[i, j];
						}
					}
				}
			}
		}
	}

	public void Print()
	{
		for (var i = 0; i < vertex; i++)
		{
			Console.WriteLine(i + " " + distance[i]);
		}
		Console.WriteLine();
	}
}