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
            int result = theatre.findAndFill(t_Square, height: h, width: w, side: a);
            
            //theatre.printStatus(t_Square, height: h, width: w);
            Console.WriteLine("We can represent the theatre square covered by tiles of side length {0} as", a);

            theatre.printSymbols(t_Square, height: h, width: w);

            Console.WriteLine("Showing that we can cover the square using {0} tiles.", result);
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
                    Console.Write("  {0}  ", t_square[i][j].covered);
                }

                Console.WriteLine("");
            }

            
        }

        public int findAndFill (unit[][] t_square, int height, int width, int side)
        {
            int symbolIndex = 0;
            int tileCount = 0;
            for (int m = 0; m < height; m++)
            {
            	for (int n = 0; n < width; n++)
                {
                    if(t_square[m][n].covered == false)
                    {
                        fill(t_square, height, width, side, m, n, symbolIndex);
                        tileCount++;
                        symbolIndex++;
                        if(symbolIndex == 7) symbolIndex = 0;
                    }
                }
            }
            
            return tileCount;
        }

        public void fill (unit[][] t_square, int height, int width, int side, int startingHeight, int startingWidth, int index)
        {
             
            for (int i = startingHeight; i < height && i < startingHeight + side; i++)
            {
                //Console.WriteLine("height ran");
                for (int j = startingWidth; j < width && j < startingWidth + side; j++)
                {
                    t_square[i][j].covered = true;

                    t_square[i][j].symbol = makeSymbol(index);
                    //Console.WriteLine("width ran");
                }

                
            }
            
            //printStatus(t_square, height, width);
               
        }

        public char makeSymbol (int index)
        {
            switch (index)
            {
                case 0:
                    return 'A';
                    
                case 1:
                    return 'B';
                    
                case 2:
                    return 'C';
                    
                case 3:
                    return 'D';
                    
                case 4:
                    return 'E';
                    
                case 5:
                    return 'F';
                    
                case 6:
                    return 'G';
                    
                default:
                    return 'm';
                    
            }
        }

        public void printSymbols (unit[][] t_square, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("{0} ", t_square[i][j].symbol);
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
