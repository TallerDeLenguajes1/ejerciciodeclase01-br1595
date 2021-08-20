using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            string Respuesta = "";
            var NumeroCulquiera = random.Next(101);
            var Ingreso = -1;
            int intento = 0;


            Console.WriteLine("Ingrese un numero entre 0 y 100");
            do
            {
                try
                {
                    Ingreso = Convert.ToInt32(Console.ReadLine());
                    if (Ingreso < NumeroCulquiera)
                    {
                        Respuesta = "El numero ingresado es menor al numero aleatorio";
                    }
                    else
                    {
                        if (Ingreso > NumeroCulquiera)
                        {
                            Respuesta = "El numero ingresado es mayor al numero aleatorio";
                        }
                    } 
                }
                catch (FormatException)
                {
                    Ingreso = -1;
                    Console.WriteLine("Error en el ingreso de datos\n");
                }
                if (Ingreso != NumeroCulquiera)
                {
                    Console.WriteLine(Respuesta);
                    Console.WriteLine("Intente nuevamente");
                }
                intento++;


            } while (Ingreso != NumeroCulquiera);

            Console.WriteLine("\n\nNúmero aleatorio: " + NumeroCulquiera);
            Console.WriteLine("Cantidad de intentos: " + intento);

        }
    }
}
