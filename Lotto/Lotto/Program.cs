using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Lotto
{
	class Program
	{
		static void Main(string[] args)
		{
			int rangeMax = 49;
			int winningNumbersQuantity = 6;

			if (rangeMax<winningNumbersQuantity)
			{
				Console.WriteLine("Range max cannot be less than winning number quantity");
				return;
			}
			
			int[] machineDrum = new int[rangeMax];
			for (int i = 0; i < rangeMax; i++)
			{
				machineDrum[i] = i + 1;
			}

			
			int[] winningNumbers = new int[winningNumbersQuantity];
			for (int i = 0; i < winningNumbersQuantity; i++)
			{
				Random random = new Random();
				int randomArrayIndex = random.Next(rangeMax);
				winningNumbers[i] = machineDrum[randomArrayIndex];
				machineDrum[randomArrayIndex] = machineDrum[rangeMax-1];
				rangeMax--;
			}
			
			Array.Sort(winningNumbers);
			
			Console.WriteLine("Your lucky numbers are:");
			foreach (var i in winningNumbers)
			{
				Console.Write(i+" ");
			}
		}
	}
}