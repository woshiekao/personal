﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
			var names = new List<string> { "<name>", "Ana", "Felipe" };
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}
			Console.WriteLine();
			names.Add("Maria");
			names.Add("Bill");
			names.Remove("Ana");
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}

			Console.WriteLine($"My name is: {names[0]}.");
			Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
			Console.WriteLine($"The list has {names.Count} people in it.");

			var index = names.IndexOf("Felipe");
			if (index != -1)
			{
				Console.WriteLine($"The name {names[index]} is at {index}");
			}
			var notFound = names.IndexOf("Not Found");
			Console.WriteLine($"When an item is not found,IndexOf returns {notFound} ");

			names.Sort();
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}
		}
    }
}
