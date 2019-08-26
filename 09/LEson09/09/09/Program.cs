using System;

namespace _09
{
	class Program
	{
		static void Main(string[] args)



		{
			//int x = 0;
			//x = x + 1;

			const int length = 5;
			const int maxValue = int.MaxValue;

			int[] arr = GetTestArray(length, maxValue);


			


			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i]);
			}
			//bubble sorting

			for (int j = 0; j < arr.Length - 1; j++)
			{
				for (int i = 0; i < arr.Length - 1 - j; i++)
				{
					if (arr[i] > arr[i + 1])
					{
						int temp = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = temp;
					}
				}
			}
			Console.WriteLine(string.Join(", ", arr));
			Console.ReadKey();
		}
		public static int[] GetTestArray(int arrayLenght, int maxElemenntValue)
		{
			var arr = new int[arrayLenght];
			var rnd = new Random();

			for (var i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(maxElemenntValue);
			}
			return arr;
		}
	}
}