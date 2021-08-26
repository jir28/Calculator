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
            double raiz1, raiz2,q,r,angle,q3,r2,x1,x2,x3,evaluar,m,b2,x;


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
                        a = int.Parse(Console.ReadLine()); // Leemos los valores y los convertimos a tipo int 
                        b = int.Parse(Console.ReadLine());
                        c = int.Parse(Console.ReadLine());
                        evaluar = Math.Pow(b, 2) - (4 * a * c); //Evaluamos el discriminante 
                        if (evaluar>=0) //Comparamos si es mayor igual que cero, en caso contrario no hay solucion para esa ecuacion
                        {
                            raiz1 = (-1 * b + Math.Sqrt(evaluar))/(2*a); //Calculamos la raiz 1, abajo 2 y 3 respectivamente
                            raiz2 = (-1 * b - Math.Sqrt(evaluar))/(2*a); 
                            Console.WriteLine("Valor de x1: "+raiz1);
                            Console.WriteLine("Valor de x2: "+raiz2);
                        }
                        else
                        {
                            Console.WriteLine("No hay solucion"); //Esto sucede solo si el discriminante es negativo
                        }
                        break; //Cambio en el menu e indicacion que salga 
                    case 2:
                        Console.WriteLine("Ecuacion de la forma x^3 + ax^2 + bx + c = 0");
                        Console.WriteLine("Ingresa los valores de a, b, c respectivamente");
                        a = int.Parse(Console.ReadLine()); // Leeemos y convertimos los valores ingresados 
                        b = int.Parse(Console.ReadLine());
                        c = int.Parse(Console.ReadLine());
                        q = (Math.Pow(a, 2) - 3 * b) / 9; //Calculamos el valor de q, respectivamente usando el siguiente metodo 'http://aulavirtualitapu.com.ar/fisica/numerico/raices/raiz_cubica.xhtml'
                        r = (2 * Math.Pow(a, 3) - 9 * a * b + 27 * c) / 54;
                        q3 = Math.Pow(q, 3); //Potencia de q con el metodo pow
                        r2 = Math.Pow(r,2);
                        if (r2<q3) //Si la condicion se cumple,habran 3 raices reales
                        {
                            angle = Math.Acos(r / Math.Sqrt(q3)); //Calculamos theta
                            x1 = -2 * Math.Sqrt(q) * Math.Cos(angle / 3) - (a/3); // Calculo de una raiz usando el metodo anteriormente mencionado
                            x2 = -2 * Math.Sqrt(q) * Math.Cos((angle + 2 * Math.PI)/3) - (a/3);
                            x3 = -2 * Math.Sqrt(q) * Math.Cos((angle - 2 * Math.PI)/3) - (a/3);
                            Console.WriteLine("Valor de x1: " + x1);
                            Console.WriteLine("Valor de x2: " + x2);
                            Console.WriteLine("Valor de x3: " + x3);
                        }
                        else // Si a condicion no se cumple, habra raices complejas
                        {
                            Console.WriteLine("Tiene una raiz real y dos complejas tu ecuacion");
                        }
                        break; 
                    case 3:
                        Console.WriteLine("Ingresa los valores de 'm' y 'b' respectivamente");
                        m = double.Parse(Console.ReadLine()); // Lectura de los datos convirtiendolos a double
                        b2 = double.Parse(Console.ReadLine());
                        x = -1 * b2 / m; // Despeje general de x para encontrar la raiz
                        Console.WriteLine("El valor de 'x' es: " + x);
                        break;
                    default: // Alerta de mensaje en caso de digitar una opcion incorrecta del menu
                        Console.WriteLine("Ingresa una opcion correcta");
                        break;
                }
                Console.WriteLine("Presione 1 para intentar de nuevo o 2 para salir"); //Pregunta si se desea salir o hacer otro calculo 
                repeticion = Convert.ToInt32(Console.ReadLine());
            }
            

        }
    }
}