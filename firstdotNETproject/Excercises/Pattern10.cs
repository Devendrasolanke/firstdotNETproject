using System;
using System.Collections.Generic;
using System.Text;

namespace firstdotNETproject.Excercises
{
    class Pattern10
    {
        /*
         
              *
             **
            ***    Drow this pattern
           ****
          *****
         ******

         */

        static void Main(string[] args)
        {
            int row, col, spaces;
            for (row=5; row>=1; row--)
            {
                for (spaces=1; spaces<row; spaces++)
                {
                    Console.Write(" ");
                }
                for (col=5; col>=row; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern11
    {
        /*
         
                *
               ***
              *****      Drow this pattern
             *******
            *********

         */
        static void Main(string[] args)
        {
            int row, col, spaces;
            for (row = 11; row >= 1; row--)
            {
                for(spaces=1; spaces<row; spaces++)
                {
                    Console.Write(" ");
                }
                for (col=11; col>=(row*2)-1; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern12
    {
        /*
         
        *
        **
        ***         Drow this pattern
        ****
        *****
        ******

         */
        static void Pattern(int num)
        {
            int row, col;
            for(row=1; row<=num; row++)
            {
                for(col=1; col<=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is the Pattern");
            Console.WriteLine();
            Pattern(num);
        }
    }
    class Pattern13
    {
        /*
         
        *******
        ******
        *****               Drow this pattern
        ****           
        ***
        **
        *

         */
        static void Pattern(int num)
        {
            int row, col;
            for(row=num; row>=1; row--)
            {
                for(col=row; col>=1; col--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is the pattern");
            Console.WriteLine();
            Pattern(num);
            
        }
    }
    class Pattern14
    {
        /*
         
        *******
         ******
          *****          Drow this pattern
           ****
            ***
             **
              *

         */
        static void Pattern(int num)
        {
            int row, col, spaces;
            for(row=num; row>=1; row--)
            {
                for(spaces=row; spaces<num; spaces++)
                {
                    Console.Write(" ");
                }
                for(col=1; col<=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is pattern");
            Console.WriteLine();
            Pattern14.Pattern(num);
        }
    }
    class Pattern15
    {
        /*
         
              *
             **
            ***       drow this pattern
           ****
          *****

         */
        static void Pattern(int num)
        {
            int row, col, spaces;
            for (row=1; row<=num; row++)
            {
                for (spaces=row; spaces<num; spaces++)
                {
                    Console.Write(" ");
                }
                for (col=1; col<=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the rows");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is pattern");
            Console.WriteLine();
            Pattern15.Pattern(num);
        }
    }
    class Pattern16
    {
        /*
         
         * 
         * *
         * * *
         * * * *   Drow this Pattern 
         * * *
         * *
         * 
         
         */
        static void Main(string[] args)
        {
            int row, col;
            for(row=1; row<=5; row++)
            {
                for(col=1; col<=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(row=4; row>=1; row--)
            {
                for(col=row; col>=1; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern17
    {
        /*
         
        *****
        ****
        ***
        **
        *         Drow this pattern
        **
        ***
        ****
        *****

         */
        static void Main(string[] args)
        {
            int row, col;
            for (row=5; row>=1; row--)
            {
                for(col=row; col>=1; col--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(row=2; row<=5; row++)
            {
                for(col=1; col<=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern18
    {
        /*
         
                *
               ***
              *****
             *******    Drow this Pattern
              *****
               ***
                *

         */
        static void Main(string[] args)
        {
            int row, col, spaces;
            for(row=1; row<=5; row++)
            {
                for(spaces=row; spaces<5; spaces++)
                {
                    Console.Write(" ");
                }
                for(col=1; col<=(row*2)-1 ; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for(row=4; row>=1; row--)
            {
                for(spaces=row; spaces<=4; spaces++)
                {
                    Console.Write(" ");
                }
                for(col=1; col<=(row*2)-1; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Pattern19
    {
        /*
         
         *****
         *   *
         *   *       Drow this pattern
         *   *
         *****

         */
        static void Main(string[] args)
        {
            int row, col;
            for(row=1; row<=9; row++)
            {
                if(row==1 || row == 9)
                {
                    for(col=1; col<=6; col++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for(col=1; col<=6; col++)
                    {
                        if(col==1 || col == 6)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
