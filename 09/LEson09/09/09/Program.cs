using System;

namespace _09
{
	class Program
	{
		static void Main(string[] args)



		{
			//int x = 0;
			//x = x + 1;

			int a = 10;
			UpgrateValue(ref a);
			Console.WriteLine(a);

			//StopWath sw = new StopWath();

			const int length = 5;
			const int maxValue = int.MaxValue;

			int[] arr = GetTestArray(length, maxValue);
			{
				OutputArray(arr, " исход данные");

				var sortedarr = BubbleSort(arr);
				OutputArray(sortedarr, "sorted array(bubble):");

				OutputArray(arr, "исход данные");

				OutputArray(arr, "отсортировка");

				var sortedArr2 = Systemsort(arr);
				OutputArray(sortedArr2, " сортировка (система):");

			}
			Console.ReadKey();

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

		}

		private static void OutputArray(object sortedArr2, string v)
		{
			throw new NotImplementedException();
		}

		private static object Systemsort(int[] arr)
		{
			throw new NotImplementedException();
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
		public static void OutputArray(int[] arr, string message)
		{
			Console.WriteLine(message);
			Console.WriteLine(string.Join(", ", arr) + "\n");
		}
		public static int[] BubbleSort(int[] inputArr)
		{
			int[] arr = (int[])inputArr.Clone();
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
			return arr;
		}
		public static void UpgrateValue(ref int a)
		{
			a++;
			Console.WriteLine(a);
		}
		//private static[] SystemSort(int[] arr)
		//{
		//	int[] a=int[] arr.Clone());
		//	Array.Sort(a);
		//	return a;
		//}
	}
}