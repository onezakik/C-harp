using System;
using System.Collections.Generic;

namespace Lesson08_2_
{
	class Program
	{
		static void Main(string[] args)
		{
			//List<int> intList = new List<int>
			//{
			//	10,
			//	20,
			//	30,
			//	40
			//};

			//Console.WriteLine(string.Join(", ", intList));
			List<double> values = new List<double>();

			Console.WriteLine("Напишите Stop");
			const string stop = "stop";
			string input=string.Empty;
			while(true)
			{
				input = (Console.ReadLine());
				if (input == stop)
				{
					break;
				}

				double value = double.Parse(input);
				values.Add(value);
			};

			double sOfValues = 0;
			foreach(double value in values)
			{
				sOfValues += value;
			}
			Console.WriteLine(sOfValues);
			Console.WriteLine(sOfValues / values.Count);

			Console.ReadKey();
		}
	}
}
