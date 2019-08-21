using System;
using System.Collections.Generic;

namespace Lesson08_3_
{
	class Program
	{
		static void Main(string[] args)
		{

			//Dictionary<string, string> countries = new Dictionary<string, string>(5);
			//countries.Add("1", "Russia");
			//countries.Add(3.ToString(), "Great Britain");
			//countries.Add("2", "USA");
			//countries.Add("4", "France");
			//countries.Add("5", "China");

			//foreach (KeyValuePair<string, string> keyValue in countries)
			//	Console.WriteLine($"{keyValue.Key} - {keyValue.Value}");

			//string country = countries["4"];
			//countries["4"] = "Spain";
			//countries.Remove("2");

			//Console.WriteLine("the most Country in the world is {0}.aff {0} ", countries["5"]);

			Console.WriteLine("Введите команду! wash , dry, exit");
			string input = Console.ReadLine();
			Stack<string> stack = new Stack<string>();

			stack.Push("wash");
			//stack.Push("dry");
			//stack.Push("exit");
			while (stack.Count > 0)
			{
				if (input == "wash")
				stack.Push("wash");
				if (input == "dry")
				stack.Pop();
				if (input == "exit") 
				stack.
			}

			Console.ReadKey();
		}
	}
}
