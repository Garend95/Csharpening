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

			unit[][] t_Square = new unit[h][];
			for(int i = 0; i < h; i++) t_Square[i] = new unit[w];

            theatre.uncover(t_Square ,height: h, width: w);
            theatre.findAndFill(t_Square, height: h, width: w, side: a);
            //theatre.printStatus(t_Square, height: h, width: w);
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

        public void uncover (unit[][] t_square, int height , int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++) t_square[i][j].covered = false;
            }
        }

        public void printStatus (unit[][] t_square, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(" {0} ", t_square[i][j].covered);
                }

                Console.WriteLine("");
            }

            
        }

        public void findAndFill (unit[][] t_square, int height, int width, int side)
        {
            
            for (int m = 0; m < height; m++)
            {
            	for (int n = 0; n < width; n++)
                {
                    if(t_square[m][n].covered == false)
                    {
                        fill(t_square, height, width, side, m, n);
                    }
                }
            }
            
            
        }

        public void fill (unit[][] t_square, int height, int width, int side, int startingHeight, int startingWidth)
        {
             
            for (int i = startingHeight; i < height && i < startingHeight + side; i++)
            {
                //Console.WriteLine("height ran");
                for (int j = startingWidth; j < width && j < startingWidth + side; j++)
                {
                    t_square[i][j].covered = true;
                    //Console.WriteLine("width ran");
                }

                
            }
            
            printStatus(t_square, height, width);
               
        }

        //public char makeSymbol (unit[][] t_square, int i, int j)
	}

    struct unit
    {
        public bool covered; // helps to know if a part of the square is covered
        public char symbol; // helps to print visual representation of theatre square after it's covered
    }
}
