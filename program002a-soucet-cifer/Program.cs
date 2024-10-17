using System; 

class   program{

}
static void main();




// chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("******* Součet a součin cifer *******");
            Console.WriteLine("*************************************");
            Console.WriteLine("*********** Jakub Kumšta *************");
            Console.WriteLine("*************************************\n\n");
            Console.WriteLine();
            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }
            console.WriteLine("****************************");
            console.WriteLine("uživatel zadal: {0}",number);
            console.WriteLine("****************************");

//pokud je číslo záporné, tak - odstraníme
if(number <0 ){
    number = - number;
}

int suma = 0;
int multi = 1
int numberbackup = number;
int digit;

while (numberbackup >=10) {
   digit = number % 10; // % operátor modulo
   number = (number - digit) / 10;
   console.WriteLine("Digit = {0}", digit);
   suma = suma +digit;
   multi = multi * digit;
};
console.WriteLine('Digit = {0}',number)
suma = suma + number;
multi = multi * number

console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberbackup, suma);
console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberbackup, multi);

//opakování programu
console.WriteLine("pro opakování programu stiskněte klávesu a");
again = console.ReadLine();
}