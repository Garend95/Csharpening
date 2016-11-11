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

			unit[][] t_Square = new unit[w][];
			for(int i = 0; i < w; i++) t_Square[i] = new unit[h];

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

        public void falsify (unit[][] t_square, int height , int width)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++) t_square[i][j].covered = false;
            }
        }

        public void printStatus (unit[][] t_square, int height, int width)
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

    struct unit
    {
        public bool covered; // helps to know if a part of the square is covered
        public char symbol; // helps to print visual representation of theatre square after it's covered
    }
}
