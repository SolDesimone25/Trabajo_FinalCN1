using System;

namespace TPFinal_Desimone
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que permita ingresar una lista de números 
            que corta cuando se ingresa un cero. A partir de dichos datos informar:
                a. El mayor de los números pares.
                b. La cantidad de números impares.
                c. El menor de los números primos.
            
            Nota: evaluar el uso de una función que analice si un número dado es 
            primo o no y que devuelva true o false según corresponda.*/

            int N, MayorPAR = 0, Impar = 0, MenorPrimo = 0;
            bool BanderaPAR = true, BanderaPRIMO = true;
            

            Console.WriteLine("Ingrese un numeros por favor: ");
            N = int.Parse(Console.ReadLine());
            
            while (N != 0)
            {
                
                
                if (N % 2 == 0)
                {
                    if (BanderaPAR)
                    {
                        MayorPAR = N;
                        BanderaPAR = false;
                    }
                    else if (N > MayorPAR){
                        MayorPAR = N;
                    }
                }
                else
                    Impar++;

                if(Primos(N))
                    if(BanderaPRIMO)
                    {    
                        MenorPrimo = N;
                        BanderaPRIMO = false;
                    }
                    else if (N < MenorPrimo)
                        MenorPrimo = N;
                
                
                Console.WriteLine("Ingrese otro numero por favor: ");
                N = int.Parse(Console.ReadLine());

            
            }

            Console.WriteLine("El mayor de los numeros PARES es: " + MayorPAR);
            Console.WriteLine("Se ingresaron en total la cantidad de " + Impar + " numeros IMPARES");
            Console.WriteLine("El Menor de los PRIMOS es: " + MenorPrimo);

        }


        static bool Primos (int A)
        {
            int con = 0;

            for (int X = 1; X <= A; X++)
            {
                if (A % X == 0)
                    con++;
            }
            if (con == 2)
                return true;
            else
                return false;
        }

    }
}
