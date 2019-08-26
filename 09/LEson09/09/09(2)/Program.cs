using System;

namespace _09_2_
{
	class Program
	{
		//static void Main(string[] args)
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
