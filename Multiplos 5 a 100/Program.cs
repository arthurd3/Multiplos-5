//Elabore um programa em C# que mostre todos os números múltiplos de 5 de 100 até 0.





using System;

class Program{

    public static void Main(string[] args)
    {

        int num = 5 , resultado = 0 , multiplo =0;
        
        while(resultado < 100){
            resultado = num * multiplo;
            Console.WriteLine($"Multiplos De 5 : {resultado}");
            multiplo++;
        }


        for (int i = 100 ; i >= 0 ; i-= 5){
            Console.WriteLine($"Multiplos De 5 : {i}");
        }


    }

}