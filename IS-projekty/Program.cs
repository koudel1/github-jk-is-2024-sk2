// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

using System;

class program {
    
    static void Main() {




//chci aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a");
            Console.Clear();
            Console.WriteLine("**************");
            Console.WriteLine("****** Výpis řady ***********");
            Console.WriteLine("**************");
            Console.WriteLine("****** Jakub Kumšta *********\n");
            Console.WriteLine();

            // Vstup uživatele - TO DO

            // Logika pro výpis řady - TO DO

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'");
            again = Console.ReadLine();



    }
}