using System;

class   program{

}
static void main();




//chci aby se program opakoval po stisku klávesy "a"
string again = "a";
while (again == "a") ;
Console.Clear();
Console.WriteLine("**************");
Console.WriteLine("****** Výpis řady ***********");
Console.WriteLine("**************");
Console.WriteLine("****** Jakub Kumšta *********\n");
Console.WriteLine();

// Vstup uživatele - špatná varianta
//Console.Write("Zadejte první číslo řady: ");
//int first = int.Parse(Console.ReadLine());

// Logika pro výpis řady - lepší varianta
Console.Write("Zadejte první číslo řady(celé číslo): ");
int first;
while(!int.TryParse(Console.ReadLine(), out first)) {
    Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady(celé číslo): ");
}
Console.Write("Zadejte poslední číslo řady(celé číslo): ");
int last;
while(!int.TryParse(Console.ReadLine(), out last)) {
    Console.Write("Nezadali jste celé číslo. Zadejte znovu první číslo řady(celé číslo): ");
}
Console.Write("Zadejte diferenci(celé číslo): ");
int step;
while(!int.TryParse(Console.ReadLine(), out step)) {
    Console.Write("Nezadali jste celé číslo. Zadejte znovu diference(celé číslo): ");
}
Console.WriteLine("poslední číslo řady: {0}");
Console.WriteLine("diference: {0}");
Console.WriteLine();
Console.WriteLine();

//logika pro výpis řady - TO DO
int current = first;
while(current <= last){
    Console.WriteLine(current);
    current = current + step;
}

// Opakování programu
Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'");
again = Console.ReadLine();
