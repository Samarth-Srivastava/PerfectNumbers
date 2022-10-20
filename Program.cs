//driver code
using System;
using System.IO;

namespace PerfectNumbers{
	public class Program{
		public static void Main(string[] args){
			Solution s = new Solution();

			Console.WriteLine(s.isPerfect(Convert.ToInt32(args[0])));
		}
	}
}
