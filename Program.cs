using System;
using System.Collections;
using System.Net.Http;

namespace Krystek_Lab_4_6
{
	class Program
	{
		static void Main(string[] args)
		{
			// Name:	Keith Krystek
			// Date:	07.27.2020
			// Class: SD1104-A - Full Stack C# Development - Sona Patel - 7 / 11 / 2020
			//
			// Assignment: Lab 4_6
			// =========================================================================
			//
			//
			// 1.Create a To-Do List Planner looping through Days and Tasks.
			//

			// 1.Create Arrays/Lists.

			string[] Days = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

			ArrayList TaskList = new ArrayList();


			// 2.Create Loop to Collect Tasks.

			int counter = 1;
			foreach (string day in Days)
			{
				Console.WriteLine("Type in a new task for {0}", day);
				TaskList.Add(Console.ReadLine());
				counter++;
			};

			Console.Clear();


			// 3.Display List of Task by Day.

			counter = 0;
			while (counter < 7)
			{
				Console.WriteLine("On {0}, remember to {1}.", Days[counter], TaskList[counter]);
				counter++;
			};


			// End

		}
	}
}
