using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Ej 1
        //         int[] numeros = new int[6];

        //         Console.Write("Escribe 6 numeros: ");
        //         for (int i = 0; i < 6; i++)

        //         {
        //             Console.WriteLine();
        //             Console.Write($"Numero {i + 1}: ");
        //             numeros[i] = Convert.ToInt32(Console.ReadLine());

        //         }
        //         Array.Sort(numeros);

        //         Console.WriteLine("Numeros ordenados: ");
        //         for (int i = numeros.Length - 1; i >= 0; i--)
        //         {
        //             Console.Write(numeros[i] + " ");
        //         }

        //     }
        // }

        // Ej2

        //         string[] nombres = new string[100];

        //         Console.WriteLine("Escribe 100 nombres: ");
        //         for (int i = 0; i < 100; i++)
        //         {
        //             Console.WriteLine($"Nombre {i + 1}: ");
        //             nombres[i] = Console.ReadLine();

        //             if (nombres[i] == "stop")
        //             {
        //                 break;
        //             }
        //         }
        //         Console.WriteLine("Nombres Ingresados: ");
        //         foreach (string nombre in nombres)

        //         {
        //             Console.Write(nombre + " ");
        //         }
        //     }
        // }

        // Ej3

        //         Console.WriteLine("Escribe un número del 1 al 12, donde 1 es igual a enero y 12 a diciembre:");
        //         string entrada = Console.ReadLine();

        //         if (int.TryParse(entrada, out int numeroMes) && numeroMes >= 1 && numeroMes <= 12)
        //         {
        //             int diaMes = saberDiaMes(numeroMes);

        //             if (diaMes != -1)
        //             {
        //                 Console.WriteLine($"El mes {nombreMes(numeroMes)} tiene {diaMes} días");
        //             }
        //             else
        //             {
        //                 Console.WriteLine("Número de mes no válido");
        //             }
        //         }
        //         else
        //         {
        //             Console.WriteLine("Entrada no válida. Por favor, introduce un número del 1 al 12.");
        //         }
        //     }

        //     static int saberDiaMes(int numeroMes)
        //     {
        //         switch (numeroMes)
        //         {
        //             case 1:
        //             case 3:
        //             case 5:
        //             case 7:
        //             case 8:
        //             case 10:
        //             case 12:
        //                 return 31;

        //             case 4:
        //             case 6:
        //             case 9:
        //             case 11:
        //                 return 30;

        //             case 2:
        //                 return 28;

        //             default:
        //                 return -1;
        //         }
        //     }

        //     static string nombreMes(int numeroMes)
        //     {
        //         switch (numeroMes)
        //         {
        //             case 1: return "enero";
        //             case 2: return "febrero";
        //             case 3: return "marzo";
        //             case 4: return "abril";
        //             case 5: return "mayo";
        //             case 6: return "junio";
        //             case 7: return "julio";
        //             case 8: return "agosto";
        //             case 9: return "septiembre";
        //             case 10: return "octubre";
        //             case 11: return "noviembre";
        //             case 12: return "diciembre";
        //             default: return "mes no existente";
        //         }
        //     }
        // }

        // EJ4

        //         decimal[] numerosDecimales = new decimal[7];
        //         Console.Write("Ingresa 7 valores decimales: ");
        //         for (int i = 0; i < 7; i++)
        //         {
        //             Console.WriteLine();
        //             Console.Write($"Numero {i + 1}: ");
        //             numerosDecimales[i] = Convert.ToDecimal(Console.ReadLine());
        //         }
        //         Array.Sort(numerosDecimales, (a, b) => b.CompareTo(a));
        //         Console.WriteLine("Numeros ordenados de mayor a menor:");
        //         foreach (decimal numeroDecimal in numerosDecimales)
        //         {
        //             Console.Write(numeroDecimal + " ");
        //         }
        //         Console.ReadLine();
        //     }
        // }

        // Ej5
//         int[] numeros = new int[10];

//         Console.Write("Escribe 10 numeros: ");
//         for (int i = 0; i < 10; i++)

//         {
//             Console.WriteLine();
//             Console.Write($"Numero {i + 1}: ");
//             numeros[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         for (int i = 0; i < 10; i++)
//         {
//             if (numeros[i] % 2 == 0)
//             {
//                 Console.Write($"Decimal: {numeros[i]} ");
//             }
//         }

//         Console.ReadLine();
//     }
// }




