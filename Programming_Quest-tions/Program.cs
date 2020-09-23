using System;

namespace Programming_Quest_tions
{
    class Program
    {
        static void Main(string[] args)
        {   //**********************************************//
            //                                              //
            // Programming Questions - Ultra Easy Questions //
            //                                              //
            //            by ppyon    pls no bully          //
            //                                              //
            //**********************************************//

            //1.- Print out your name on the screen.
            Console.Write("José Alonso Valle Martinez"); fin();

            //2.- Count down from 700 to 200 in decrements of 3.
            dos(); void dos(int x = 700) { if (x >= 200) { Console.WriteLine(x); dos(x - 3); } }
            fin();

            //3.- An array of integers has 10 elements. Print the second element of that array.
            string[] arreglo = { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez" };
            Console.WriteLine(arreglo[1]); fin();

            //4.- Sum all the integers from 0 -> 1000. Sum all integers from [x] -> [y], assuming that "x" is smaller that "y".
            int a = 0; for (int i = 0; i <= 1000; i++) { Console.WriteLine(a = a + i); }
            fin();

            int x = int.Parse(Console.ReadLine()); int y = int.Parse(Console.ReadLine());
            if (x < y) { for (int i = 0; i <= y; i++) { Console.WriteLine(x = x + i); } }
            else { Console.WriteLine("'x' isn't smaller than 'y'"); }
            fin();

            //5.- Let the user input their [name], and check if it is "Jack". If it is "Jack", print out "Hi, Jack!". Otherwise, print out "Hello [name]".
            string name; name = Console.ReadLine();
            if (name == "Jack") { Console.WriteLine($"Hi Jack!"); }
            else { Console.WriteLine($"Hello, {name}"); }
            fin();

            //6.- Using the modolus operator, label all the even and odd numbers from 0-100. Do it again without the modulus operator.
            //    and a third time without if / else / switch.
            for (int i = 1; i <= 100; i++)
            { if (i % 2 == 0) { Console.WriteLine($"{i} - Número Par"); } else { Console.WriteLine($"{i} - Número imPar"); } }
            fin();

            for (int i = 1; i <= 100; i++)
            { if ((i / 2) * 2 == i) { Console.WriteLine($"{i} - Even"); } else { Console.WriteLine($"{i} - Odd"); } }
            fin(); //No MOD

            for (int i = 1; i <= 100; i++) { } //@ A @ <( me dio sueño, menas noches! )


            //7.- Print the 12 x 12 multiplication table. (Challenge: Use only a single loop.)
            for (int i = 0; i <= 12; i++) { Console.WriteLine($"12 x {i} = " + 12 * i); }

            //8.- Assume that the user will enter a moderatly long (10+ words) sencence as input. Split this sentence into words,
            //    then display it as one word per line.

            //9.- Generate three random integers, each between 0-20. Fin the largest, smallest, and average of the three.

            //10.- For a certain school class, you are given one test and an optional project. For the test, if you score below 50
            //     (out of a 100), you get an F. 50-69 is C, 70-89 is B, and 90-100 is A. If you submit the optional project, you 
            //     raise your grade by one letter. Let the user input their marks (0-100), and whether they submitted the project
            //     (y/n), and give them their grade.


            //////////////////////////////////////////////////////////
            /**/void fin() { Console.ReadKey(); Console.Clear(); }/**/
            //////////////////////////////////////////////////////////
        }
    }
}
