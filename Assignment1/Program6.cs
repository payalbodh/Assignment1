using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
	class Program6
	{
		struct Books
		{
			public string title;
			public string author;
			public string subject;
			public enum bookType { Magazine, Novel, ReferenceBook, Miscellaneous };
		};

		public class testStructure
		{
			public static void Main()
			{
				int nobook = 5;
				Books[] books = new Books[nobook];
				int i, j, n = 1, k = 1;
				Console.Write("\n\nInsert the information of five books :\n");
				Console.Write("-----------------------------------------\n");
				for (j = 0; j <= n; j++)
				{
					Console.WriteLine("Information of book {0} :", k);

					Console.Write("Enter Title of the book : ");
					books[j].title = Console.ReadLine();

					Console.Write("Enter author : ");
					books[j].author = Console.ReadLine();

					Console.Write("Enter Subject : ");
					books[j].subject = Console.ReadLine();

					k++;
					Console.WriteLine();
				}

				for (i = 0; i <= n; i++)
				{
					Console.WriteLine("{0}: Title = {1},  Author = {2}, Subject={3}", i + 1, books[i].title, books[i].author, books[i].subject);
					Console.WriteLine();
				}

			}


		}

	}
}