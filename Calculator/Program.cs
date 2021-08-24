using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de variables
            int opcion;
            int pot = 2;
            int repeticion = 1; //Varible para iniciar ciclo While
            double a, b, c, raiz1, raiz2,pb;


            //Inicio del programa con while
            while (repeticion== 1)
            {
                //Presentamos las opciones
                Console.WriteLine("Calculadora de raices");
                Console.WriteLine("Escoge una opcion");
                Console.WriteLine("1) Ecuacion cuadratica");
                Console.WriteLine("2) Ecuacion cubica");
                Console.WriteLine("3) Recta");
                
                //Convertimos la opcion a tipo numerico para que sea identificado por el switch
                opcion = Convert.ToInt32(Console.ReadLine());

                //Inicia la funcion switch
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa los valores de 'a', 'b' y 'c' respectivamente");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        c = Convert.ToDouble(Console.ReadLine());
                        pb = Math.Pow(a, pot);
                        raiz1 = Math.Sqrt(pb-(4*(a*c)));
                        
                        Console.WriteLine(raiz1);
                        break;
                    case 2:
                        Console.WriteLine("Has elegido 2");
                        break; 
                    case 3:
                        Console.WriteLine("has elegido 3");
                        break;
                    default:
                        Console.WriteLine("Escoge un numero entre 1-3");
                        break;
                }
                
                
                
                Console.WriteLine("Presione 1 para intentar de nuevo o 2 para salir");
                repeticion = Convert.ToInt32(Console.ReadLine());
            }
            
            

        }
    }
}