using System;

namespace ArrayExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = 0;
			int columns = 0;

			int[,] array = new int[rows, columns];


			Console.WriteLine("Insert number of rows M");

			rows = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Insert number of columns N");

			columns = Convert.ToInt32(Console.ReadLine());
					   
			Console.WriteLine("Insert numbers");

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					array[i, j] = int.Parse(Console.ReadLine());
					Console.WriteLine(array[i,j]);
					Console.ReadLine();
				}
			}

		}
	}
}
