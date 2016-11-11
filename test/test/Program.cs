using System;
//First exercise from code forces
namespace test
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			int h, w, a;

			MainClass theatre = new MainClass ();

			theatre.parameters (out h, out w, out a);

			//Console.WriteLine ("the height {0}, the width {1}, the side {2}", h, w, a);

			bool[][] t_Square = new bool[w][];
			for(int i = 0; i < w; i++) t_Square[i] = new bool[h];

            theatre.falsify(t_Square ,height: h, width: w);
            theatre.printStatus(t_Square, height: h, width: w);
		}

		public void parameters (out int h, out int w, out int a)
		{
			Console.WriteLine ("Please insert the height of the theatre square");
			h = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Now the width");
			w = Convert.ToInt32 (Console.ReadLine ());

			Console.WriteLine ("Lastly, insert the length of the side of the square covering it.");
			a = Convert.ToInt32 (Console.ReadLine ());
		}

        public void falsify (bool[][] t_square, int height , int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++) t_square[i][j] = false;
            }
        }

        public void printStatus (bool[][] t_square, int height, int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(" {0} ", t_square[i][j]);
                }

                Console.WriteLine("");
            }

            
        }
	}
}
