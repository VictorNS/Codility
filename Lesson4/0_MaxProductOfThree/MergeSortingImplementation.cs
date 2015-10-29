using System;
using System.Linq;

namespace _0_MaxProductOfThree
{
	public static class MergeSortingImplementation
	{
		static Int32[] Merge_Sort(Int32[] massive)
		{
			if (massive.Length == 1)
				return massive;
			Int32 mid_point = massive.Length / 2;
			return Merge(Merge_Sort(massive.Take(mid_point).ToArray()), Merge_Sort(massive.Skip(mid_point).ToArray()));
		}

		static Int32[] Merge(Int32[] mass1, Int32[] mass2)
		{
			Int32 a = 0, b = 0;
			Int32[] merged = new int[mass1.Length + mass2.Length];
			for (Int32 i = 0; i < mass1.Length + mass2.Length; i++)
			{
				if (b < mass2.Length && a < mass1.Length)
					if (mass1[a] > mass2[b])
						merged[i] = mass2[b++];
					else //if int go for
						merged[i] = mass1[a++];
				else
					if (b < mass2.Length)
						merged[i] = mass2[b++];
					else
						merged[i] = mass1[a++];
			}
			return merged;
		}

		public static void RunTest()
		{
			Int32[] arr = new Int32[100];

			Random rd = new Random();
			for (Int32 i = 0; i < arr.Length; ++i)
			{
				arr[i] = rd.Next(1, 101);
			}
			Console.WriteLine("The array before sorting:");
			foreach (Int32 x in arr)
			{
				Console.Write(x + " ");
			}

			arr = Merge_Sort(arr);

			Console.WriteLine("\n\nThe array after sorting:");
			foreach (Int32 x in arr)
			{
				Console.Write(x + " ");
			}
			Console.WriteLine();
		}
	}
}
