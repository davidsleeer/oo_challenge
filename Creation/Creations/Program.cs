using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO_Challenge;

namespace Creations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input S for Square and R for Rectangel");
            string input = Console.ReadLine();

            if (input == "R")
            {
                
                
                   

                    try
                    {
                        Rectangle Rec;
                        Console.WriteLine("Input a color");
                        string col = Console.ReadLine();
                        Console.WriteLine("Input a Length:");
                        int len = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input a Widthth:");
                        int wid = int.Parse(Console.ReadLine());
                        Rec = new Rectangle(col, len, wid);
                        if ( len < 1 || wid < 1)
                        {
                            throw new lowerthanoneException();
                        }



                    }
                    catch (FormatException e)
                    {

                        Console.WriteLine("It is not allow!");
                        Console.WriteLine(e.Message);


                    }
                Console.WriteLine("Created");
                    
                    
                
            } else if(input == "S")
            {
                try
                {
                    Square Squ;
                    Console.WriteLine("Input a color");
                    string col = Console.ReadLine();
                    Console.WriteLine("Input a Length:");
                    int len = int.Parse(Console.ReadLine());
                    
                    Squ = new Square(col, len);
                    if (len < 1)
                    {
                        throw new lowerthanoneException();
                    }



                }
                catch (FormatException e)
                {

                    Console.WriteLine("It is not allow!");
                    Console.WriteLine(e.Message);


                }

                Console.WriteLine("Created");

            }
        }


                 class lowerthanoneException : Exception
        {

        }


    }
    }

