using System;
using System.Collections.Generic;
using System.IO;
using Section10_Exercicio_Proposto.Entities;

namespace Section10_Exercicio_Proposto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n   Eóq of Section10 proposed exercise");

            Console.Write("\n\n   Enter the number of products: ");
            int NProd = int.Parse(Console.ReadLine());            

            List<Product> PList = new List<Product>();

            for(int i = 1; i <= NProd; i++)
            {
                Console.Write("\n   Is this product common, used or imported? Type c to common, u to used or i to imported: ");
                char Answer = char.Parse(Console.ReadLine());

                while(Answer != 'c' && Answer != 'u' && Answer != 'i')
                {
                    Console.WriteLine("\n   You've entered a wrong answer, please, try it again! ");
                    Console.Write("   Is this product common, used or imported? Type c to common, u to used or i to imported");
                    Answer = char.Parse(Console.ReadLine());
                }

                Console.Write("   Enter the product name: ");
                string PName = Console.ReadLine();

                Console.Write("   Enter the product price: ");
                double PPrice = double.Parse(Console.ReadLine());

                if(Answer == 'u')
                {
                    Console.Write("   Enter the product manufacture date (MM/DD/YYY): ");
                    DateTime PMDate= DateTime.Parse(Console.ReadLine());

                    PList.Add(new UsedProduct(PName, PPrice, PMDate));
                }
                else if(Answer == 'i')
                {
                    Console.Write("   Enter the product custom fee: ");
                    double PCFee = double.Parse(Console.ReadLine());

                    PList.Add(new ImportedProduct(PName, PPrice, PCFee));
                }
                else
                {
                    PList.Add(new Product(PName, PPrice));
                }
            }

            List<string> SCont = new List<string>();
            foreach(Product prd in PList)
            {
                Console.WriteLine(prd.PriceTag());
                SCont.Add(prd.PriceTag().ToString());
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"G:\CS TXT Files\Section10 Proposed Exercise\Relatory " + PList.Count + ".txt"))
            foreach (string line in SCont)
            {
               file.WriteLine(line);
            }            

            // FIRST QUESTION

            Console.Write("\n\n   Do you want to add new products? Type y to yes or n to no: ");
            char Answer2 = char.Parse(Console.ReadLine());

            while(Answer2 != 'y' && Answer2 != 'Y' && Answer2 != 'n' && Answer2 != 'N')
            {
                Console.WriteLine("\n   You've entered a wrong answer, please, try it again! ");
                Console.Write("   Do you want to add new products? Type y to yes or n to no: ");
                Answer2 = char.Parse(Console.ReadLine());
            }

            if(Answer2 == 'y' || Answer2 == 'Y')
            {
                Console.WriteLine();
                Operations(PList);                
            }
            else
            {
                Console.WriteLine("\n   The end ");
                Console.WriteLine();
            }

            // DIVISION

            static void Operations(List<Product> thatPList)
            {
                bool KeepIt = true;
                while (KeepIt)
                {
                    Console.Write("\n   Enter the number of products: ");
                    int NProd = int.Parse(Console.ReadLine());                    
                    
                    for (int i = 1; i <= NProd; i++)
                    {
                        Console.Write("\n   Is this product common, used or imported? Type c to common, u to used or i to imported: ");
                        char Answer = char.Parse(Console.ReadLine());

                        while (Answer != 'c' && Answer != 'u' && Answer != 'i')
                        {
                            Console.WriteLine("\n   You've entered a wrong answer, please, try it again! ");
                            Console.Write("   Is this product common, used or imported? Type c to common, u to used or i to imported");
                            Answer = char.Parse(Console.ReadLine());
                        }

                        Console.Write("   Enter the product name: ");
                        string PName = Console.ReadLine();

                        Console.Write("   Enter the product price: ");
                        double PPrice = double.Parse(Console.ReadLine());

                        if (Answer == 'u')
                        {
                            Console.Write("   Enter the product manufacture date (MM/DD/YYY): ");
                            DateTime PMDate = DateTime.Parse(Console.ReadLine());

                            thatPList.Add(new UsedProduct(PName, PPrice, PMDate));
                        }
                        else if (Answer == 'i')
                        {
                            Console.Write("   Enter the product custom fee: ");
                            double PCFee = double.Parse(Console.ReadLine());

                            thatPList.Add(new ImportedProduct(PName, PPrice, PCFee));
                        }
                        else
                        {
                            thatPList.Add(new Product(PName, PPrice));
                        }
                    }

                    List<string> SCont = new List<string>();
                    foreach (Product prd in thatPList)
                    {
                        Console.WriteLine(prd.PriceTag());
                        SCont.Add(prd.PriceTag().ToString());
                    }

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"G:\CS TXT Files\Section10 Proposed Exercise\InsideMethod\Relatory " + thatPList.Count + ".txt"))
                        foreach (string line in SCont)
                        {
                            file.WriteLine(line);
                        }

                    // LOOP QUESTION

                    Console.Write("\n\n   Do you want to add new products? Type y to yes or n to no: ");
                    char Answer2 = char.Parse(Console.ReadLine());

                    while (Answer2 != 'y' && Answer2 != 'Y' && Answer2 != 'n' && Answer2 != 'N')
                    {
                        Console.WriteLine("\n   You've entered a wrong answer, please, try it again! ");
                        Console.Write("   Do you want to add new products? Type y to yes or n to no: ");
                        Answer2 = char.Parse(Console.ReadLine());
                    }

                    if (Answer2 == 'y' || Answer2 == 'Y')
                    {
                        Console.WriteLine();                        
                    }
                    else
                    {
                        KeepIt = false;
                        Console.WriteLine("\n   The end ");
                        Console.WriteLine();
                    }
                }
            }                
        }
    }
}
