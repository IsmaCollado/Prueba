using System;

namespace Programas
{
    class Program
    {
        static void Main()
        {
            #region Ejercicio 1

            /* Una progresión aritmética tiene el siguiente término general an=3*n-2. Se desea un
            programa que pida un número k y calcule los k primeros términos.  */

            //Console.Write("Introduzca un parámetro k para la siguiente progresión aritmética a(n) = 3*n-2 : ");
            //int k = int.Parse(Console.ReadLine());

            //Console.WriteLine("Para k = " + k + " Progresión :");

            //for (int i = 1; i <= k; i++)
            //{
            //    int a = 3 * i - 2;
            //    Console.WriteLine("a(" + i + ") = "+ a);
            //}            

            #endregion

            #region Ejercicio 2

            //Console.Write("Introduce una operación de bit (&, |, ^) : ");
            //char operacionBit = char.Parse(Console.ReadLine());

            //switch (operacionBit)
            //{
            //    case '&':

            //        for (int i = 0; i < 2; i++)
            //        {
            //            for (int j = 0; j < 2; j++)
            //            {
            //                Console.WriteLine($"{i} {operacionBit} {j} = {i * j}");
            //            }
            //        }
            //        break;

            //    case '|':
            //        for (int i = 0; i < 2; i++)
            //        {
            //            for (int j = 0; j < 2; j++)
            //            {
            //                if (j == 0 && i == 0 || j == 1 && i == 1)
            //                    Console.WriteLine($"{i} {operacionBit} {j} = {i * j}");
            //                else
            //                    Console.WriteLine($"{i} {operacionBit} {j} = {i * j + 1}");
            //            }
            //        }
            //        break;

            //    case '^':
            //        for (int i = 0; i < 2; i++)
            //        {
            //            for (int j = 0; j < 2; j++)
            //            {
            //                if (j == 1 && i == 1)
            //                    Console.WriteLine($"{i} {operacionBit} {j} = {i * j - 1}");
            //                else
            //                    Console.WriteLine($"{i} {operacionBit} {j} = {i * j + 1}");
            //            }
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Carácter no válido");
            //        break;
            //}

            #endregion

            #region Ejercicio 3

            /* Escribe un programa que genere la secuencia de números:  */

            //Console.Write("Introduce el límite de la secuencia : ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{               

            //    for (int j = 1; j < i + 1 ; j++)
            //    {
            //        if(j != n)
            //        Console.Write(j + ", ");
            //        else Console.Write(j + ". ");
            //    }


            //}


            #endregion

            #region Ejercicio 4

            /* Un número se dice que es capicúa si leído de derecha a izquierda da el mismo resultado
            que leído de izquierda a derecha. Por ejemplo, los números 22, 343, 5665 o 12321 son
            capicúas. Elabora un programa que lea desde teclado un número entero mayor de 9 y
            devuelva si el número es capicúa o no. */

            //Console.Write("Introduce un número mayor que 9 : ");
            //int numero = int.Parse(Console.ReadLine());
            //int cociente = numero;
            //int resto = 0;            
            //int numeroDeCifras = 0;
            //int sumaCapicua = 0;

            // Calculo cuantas cifras tiene el número
            while (cociente > 10)
            {
                cociente /= 10;
                numeroDeCifras++;
            }
            cociente = numero;


            // Cojo el resto de las divisiones y lo multiplico por 10 hasta conseguir el mismo número pero al reves
            for (int i = 0; cociente > 10; i++)
            {
                resto = cociente % 10;
                cociente /= 10;

                for (int j = 0; j < numeroDeCifras; j++)
                {
                    resto *= 10;
                }

                sumaCapicua += resto;
                if (cociente < 10)
                {
                    sumaCapicua += cociente;
                }

                numeroDeCifras--;
            }

            if (numero == sumaCapicua)
            {
                Console.WriteLine("Es capicua");
            }
            else
            {
                Console.WriteLine("No es capicua");
            }

            #endregion

            #region Ejercicio 5
            /* Crea un programa que muestre en pantalla la siguiente pirámide: 
                            1
                           232
                          34543
                         4567654
                        567898765
                       67890109876
       */
            Console.Write("Introduce la base de la pirámide : ");
            int basePiramide = int.Parse(Console.ReadLine());

            for (int i = 1; i <= basePiramide; i++)
            {
                for (int espacios = 0; espacios < basePiramide - i; espacios++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write((i + j) % 10);
                }

                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write((i + j) % 10);
                }
                Console.Write("\n");
            }


            #endregion

            #region Ejercicio 6

            /* Haz programa de terminal que usando algún tipo de bucle. Determine la ubicación de un
            número mayor que cero (leído del teclado) en una lista de números mayores que cero
            leída del teclado (lista creciente estrictamente y que finalizará con un 0) */

            //Console.Write("Introduce un número para buscar en la lista :");
            //int numeroBuscado = int.Parse(Console.ReadLine());
            //string mensaje = "";
            //string imprimirLista = numeroBuscado + " en ";
            //bool dentroDeLista = false;
            //int primerNumeroLista = 0;
            //int ultimoNumeroLista = 0;
            //int numeroLista = 1;

            //for (int i = 0; numeroLista != 0; i++)
            //{
            //    Console.Write("Introduce números para la lista : ");
            //    numeroLista = int.Parse(Console.ReadLine());
            //    if (i == 0)
            //        primerNumeroLista = numeroLista;
            //    if (numeroLista != 0)
            //        ultimoNumeroLista = numeroLista;
            //    imprimirLista += numeroLista + " ";

            //    if (numeroBuscado == numeroLista)
            //        dentroDeLista = true;
            //}

            //if (dentroDeLista)
            //    mensaje = "En la lista";
            //else if (numeroBuscado > ultimoNumeroLista)
            //    mensaje = "Fuera de lista a la Derecha";
            //else if (numeroBuscado < primerNumeroLista)
            //    mensaje = "Fuera de lista a la Izquierda";
            //else
            //    mensaje = "Fuera de lista a la Intercalado";


            //Console.WriteLine(imprimirLista);
            //Console.WriteLine(mensaje);

            #endregion


        }
    }
}
