// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

{

    Add();
    Add();
    Add();
    Add();
    var result = Add2(20,50);
    Console.WriteLine(result);

    Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7));s



    


    static void Add()
    {
        Console.WriteLine("Added!!!");
    }
    static int Add2(int number1, int number2 = 30) // 30 değeri hiçbir şey yazılmazsa otomatik gelecek (default)
    {
        var result = number1 + number2;
        return result;
    }

    static int Add4(params int[] numbers) // PARAMS AYNI TİPTE BİRDEN FAZLA PARAMETRE GÖNDEREBİLİRİZ.

    {
        return numbers.Sum();
    }
}


