﻿using System;


namespace SortArray
{
	public class ArrayFactory
	{
		public static int[] CreateIntArray(int columns)
		{
			Random rand = new Random();

			int[] vector = new int[columns];

			for (int j = 0; j < columns; j++)
			{
				vector[j] = rand.Next(10);
			}
			return vector;
		}

		public static double[] CreateDoubleArray(int columns)
		{
			Random rand = new Random();

			double[] vector = new double[columns];

			for (int j = 0; j < columns; j++)
			{
				vector[j] = rand.NextDouble();
			}
			
			return vector;
		}
	}
}
