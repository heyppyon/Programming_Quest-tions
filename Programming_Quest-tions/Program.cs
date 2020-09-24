using System;

namespace Programming_Quest_tions
{
    class Program
    {
        static void Main(string[] args)
        {   //**********************************************//
            //                                              //
            //             Programming Questions            //
            //                                              //
            //            by ppyon    pls no bully          //
            //                                              //
            //**********************************************//

            tier1_UltraEasy tier1 = new tier1_UltraEasy();

            int opcion; do {
                Console.Clear();
                Console.Write("PROGRAMMING QUESTIONS\n\n[ 1 ] - Ultra Easy Questions\n" +
                                                       "[ 2 ] - Very Easy Questions\n" +
                                                       "[ 3 ] - Easy Questions\n" +
                                                       "[ 4 ] - Bonus Questions\n\n" +
                                                       "Zero to exit.\n\n");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion) { 
                case 1: tier1.UltraEasy(); break;
                case 2: break;
                case 3: break;
                case 4: break;
                
            }   } while (opcion != 0);

        }
    }
}
