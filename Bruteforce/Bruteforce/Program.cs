using System;

namespace Bruteforce
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = "zzzzzz";

			string bruteforcedPassword = "";

			foreach (var item in password)
			{
				for (char i = 'a'; i <= 'z'; i++)
				{
					if (item == i) bruteforcedPassword += item;
				}
			}

			Console.WriteLine("Bruteforced password is: " + bruteforcedPassword);
		}
	}
}