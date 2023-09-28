using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Semana_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxAsistentes = 0;
            int contadorAsistentes = 0;

            Console.Write("Ingrese un número máximo de personas: ");
            maxAsistentes = int.Parse(Console.ReadLine());

            Console.WriteLine("==============================");
            Console.WriteLine("El número máximo establecido es de {0} personas.", maxAsistentes);
            Console.WriteLine("Presione cualquier tecla para comenzar a contar.");

            Console.ReadKey();

           

                char opcion = Console.ReadKey().KeyChar;

            switch (opcion)
            {
                    case 'I':
                    
                        if (contadorAsistentes < maxAsistentes)
                        {
                            contadorAsistentes++;
                            Console.WriteLine("\nPersona ingresada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("\nSe ha alcanzado el número máximo de asistentes.");
                        }
                        break;
                    case 'S':
                    
                        if (contadorAsistentes > 0)
                        {
                            contadorAsistentes--;
                            Console.WriteLine("\nPersona salida correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personas dentro del local.");
                        }
                        break;
                    case 'X':
                    
                        Console.WriteLine("\nSaliendo del programa...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida, intente nuevamente.");
                        break;


            }
        
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();

            Console.Clear();

            int asistentesActuales = 100;
            int aforoMaximo = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==================================");
                Console.WriteLine("| Asistentes actuales | " + asistentesActuales);
                Console.WriteLine("| Áforo | " + ((double)asistentesActuales / aforoMaximo * 100) + "%");
                Console.WriteLine("| Máximo | " + aforoMaximo + " personas");
                Console.WriteLine("==================================");
                Console.WriteLine("Presione [i] si ingresa una persona");
                Console.WriteLine("Presione [s] si sale una persona");
                Console.WriteLine("Presione [x] para terminar");

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.I)
                {
                    asistentesActuales++;
                }
                else if (key.Key == ConsoleKey.S)
                {
                    asistentesActuales--;
                    if (asistentesActuales < 0)
                    {
                        asistentesActuales = 0;
                    }
                }
                else if (key.Key == ConsoleKey.X)
                {
                    break;
                }


            }
            Console.ReadKey();
            
            Console.Clear();

            int asistentesActuales1 = 0;
            int aforoMaximo1 = 0;
            int totalIngresos = 0;
            int totalSalidas = 0;
            int vecesLleno = 0;
            int vecesVacio = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " + asistentesActuales1);
                Console.WriteLine("| Aforo | " + ((double)asistentesActuales / aforoMaximo1 * 100) + "%");
                Console.WriteLine("| Máximo | " + aforoMaximo + " personas");
                Console.WriteLine("=================================");
                Console.WriteLine("Presione [i] si ingresa una persona");
                Console.WriteLine("Presione [s] si sale una persona");
                Console.WriteLine("Presione [x] para terminar");

                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.I)
                {
                    asistentesActuales++;
                }
                else if (key.Key == ConsoleKey.S)
                {
                    asistentesActuales--;
                    if (asistentesActuales < 0)
                    {
                        asistentesActuales = 0;
                    }
                }
                else if (key.Key == ConsoleKey.X)
                {
                    break;
                }
            }
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(totalIngresos + " personas ingresaron");
            Console.WriteLine(totalSalidas + " personas salieron");
            Console.WriteLine(vecesLleno + " veces se llenó el local");
            Console.WriteLine("Estuvo vacío " + vecesVacio + " veces");

            Console.ReadKey();
        }
    }
}
