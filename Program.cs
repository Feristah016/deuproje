using System;
using System.Threading;

namespace asd
{
    class Program
    {
        static void Main(String[] args)
        {
		
			/*Random r = new Random();
			string x;
			x = Console.ReadLine();
			Console.Clear();
			for (int y = 0; y < Convert.ToInt32(x); y++)
			{
				Console.WriteLine(r.Next(1, 7));
			}
			*/
			Console.Clear();
			Random r = new Random();

			int x;
			int y;

			try
			{
			System.Console.WriteLine("Enter the location of A: ");
			System.Console.Write("AX: ");
			string xx = Console.ReadLine();
			x = Convert.ToInt32(xx);

			System.Console.Write("AY: ");

			string yy = Console.ReadLine();
			y = Convert.ToInt32(yy);
			}
			catch (System.Exception)
			{
				System.Console.WriteLine("input a valid integer!");
				Thread.Sleep(3000);
			
			try
			{
			System.Console.Write("AX: ");
			string xx = Console.ReadLine();
			x = Convert.ToInt32(xx);

			System.Console.Write("AY: ");

			string yy = Console.ReadLine();
			y = Convert.ToInt32(yy);
			}
			catch (System.Exception)
			{
				System.Console.WriteLine("not valid, exiting the program...");
				Thread.Sleep(2000);
				Environment.Exit(0);
				throw;
			}
			}

			if ((x < -10) || (x > 10) || (y < -10) || (y > 10))
			{
				System.Console.WriteLine("x and y must be between -10, 10");
				System.Console.WriteLine("exiting the program...");
				Thread.Sleep(2000);
				Environment.Exit(0);
			}

			int xxx = x;
			int yyy = y;

			x = x+12;
			y = 11-y;

			System.Console.WriteLine("");
			
			int[] sets = {1, 2, 3};
			int sss = r.Next(0, sets.Length);
 			//Console.Write(sets[sss]);
			int aset = sets[sss];

			int[] helts = {60, 80, 100};
			int ssss = r.Next(0, helts.Length);
			int ahelt = helts[ssss];

			System.Console.WriteLine($"A: ({xxx},{yyy})  Set {aset}  Health:{ahelt}");


			int setToRemove = aset;
			sets = sets.Where(val => val != setToRemove).ToArray();

			int heltToRemove = ahelt;
			helts = helts.Where(val => val != heltToRemove).ToArray();



			int bx = r.Next(2, 22);
			int by = r.Next(1, 21);

			sss = r.Next(0, sets.Length);
			int bset = sets[sss];

			ssss = r.Next(0, helts.Length);
			int bhelt = helts[ssss];

			System.Console.WriteLine($"B: ({bx-12},{11-by})  Set {bset}  Health:{bhelt}");

			setToRemove = bset;
			sets = sets.Where(val => val != setToRemove).ToArray();

			heltToRemove = bhelt;
			helts = helts.Where(val => val != heltToRemove).ToArray();

			/*System.Console.Write("coordinates of B: ");
			System.Console.Write("(");
			System.Console.Write(bx-12);
			System.Console.Write(", ");
			System.Console.Write(11-by);
			System.Console.WriteLine(")");*/

			int cx = r.Next(2, 22);
			int cy = r.Next(1, 21);
			if ((cx == bx) && (cy == by))
			{
				cx = r.Next(2, 22);
				cy = r.Next(1, 21);
				if ((cx == bx) && (cy == by))
				{
					cx = r.Next(1, 21);
					cy = r.Next(2, 22);
				}
			}

			sss = r.Next(0, sets.Length);
			int cset = sets[sss];

			ssss = r.Next(0, helts.Length);
			int chelt = helts[ssss];

			System.Console.WriteLine($"C: ({cx-12},{11-cy})  Set {cset}  Health:{chelt}");

			/*System.Console.Write("coordinates of C: ");
			System.Console.Write("(");
			System.Console.Write(cx-12);
			System.Console.Write(", ");
			System.Console.Write(11-cy);
			System.Console.WriteLine(")");*/

			string[,] array2D = new string[,] {{"   ", " +", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "^", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "+", "\n"}, {" 10", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  9", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  8", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  7", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  6", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  5", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  4", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  3", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  2", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  1", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"  0", "|", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "+", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", ">", "\n"}, {" -1", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -2", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -3", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -4", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -5", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -6", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -7", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -8", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {" -9", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"-10", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", ".", ".", ".", ".", ".", ".", ".", ".", ".", ".", "|", "\n"}, {"   ", "+", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "-", "+", "\n"}, {"   ", " ", "0", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", " ", "\n"}};
			array2D[y, x] = "A";
			array2D[by, bx] = "B";
			array2D[cy, cx] = "C";
			/*foreach (string tup in array2D)
			{
				System.Console.Write(tup);
				System.Console.Write(" ");
				
			}*/


			
			//Console.Clear();
			foreach (string tup in array2D)
			{
				System.Console.Write(tup);
				System.Console.Write(" ");
				
			}
    	}
	}
}