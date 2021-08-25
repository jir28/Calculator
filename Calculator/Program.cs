using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de variables
            int opcion;
            int a,b,c;
            int repeticion = 1; //Varible para iniciar ciclo While
            double raiz1, raiz2,q,r,angle,q3,r2,x1,x2,x3,evaluar;


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
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = int.Parse(Console.ReadLine());
                        evaluar = Math.Pow(b, 2) - (4 * a * c);
                        if (evaluar>=0)
                        {
                            raiz1 = (-1 * b + Math.Sqrt(evaluar))/(2*a); 
                            raiz2 = (-1 * b - Math.Sqrt(evaluar))/(2*a); 
                            Console.WriteLine("Valor de x1: "+raiz1);
                            Console.WriteLine("Valor de x2: "+raiz2);
                        }
                        else
                        {
                            Console.WriteLine("No hay solucion");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ecuacion de la forma x^3 + ax^2 + bx + c = 0");
                        Console.WriteLine("Ingresa los valores de a, b, c respectivamente");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        c = int.Parse(Console.ReadLine());
                        q = (Math.Pow(a, 2) - 3 * b) / 9;
                        r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;
                        q3 = Math.Pow(q, 3);
                        r2 = Math.Pow(r,2);
                        if (r2<q3)
                        {
                            angle = Math.Acos(r / Math.Sqrt(q3));
                            x1 = -2 * Math.Sqrt(q) * Math.Cos(angle / 3) - (a/3);
                            x2 = -2 * Math.Sqrt(q) * Math.Cos((angle + 2 * Math.PI)/3) - (a/3);
                            x3 = -2 * Math.Sqrt(q) * Math.Cos((angle - 2 * Math.PI)/3) - (a/3);
                            Console.WriteLine("Valor de x1: " + x1);
                            Console.WriteLine("Valor de x2: " + x2);
                            Console.WriteLine("Valor de x3: " + x3);
                        }
                        else
                        {
                            Console.WriteLine("Tiene una raiz real y dos complejas tu ecuacion");
                        }
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