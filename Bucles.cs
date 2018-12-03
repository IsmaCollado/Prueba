using System;

namespace Bucles
{
    class Program
    {


        static void Main()
        {
            // Marcelo Adrián Cordero 1º DAM A

            #region Ejercicio 1
            /* Programa que calcula y escribe la suma y el producto de los 10 primeros números naturales. */

            int numero = 1;
            int suma = 0;
            int producto = 1;

            while (numero <= 10)
            {
                suma += numero;
                producto *= numero;
                Console.WriteLine(numero + ".La suma es :" + suma + " y el producto es :" + producto);
                numero++;
            }

            #endregion

            #region Ejercicio 2

            /*  Programa que lee 100 números y cuenta cuántos de ellos son positivos (n > 0). */

            int i = 0;
            int numero;
            int numerosPositivos = 0;

            while (i < 100)
            {
                Console.Write("Introduce un número : ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("Es positivo");
                    numerosPositivos++;
                }
                else
                {
                    Console.WriteLine("Es negativo");
                }
                i++;
            }

            Console.WriteLine("Has introducido " + numerosPositivos + " números positivos");

            #endregion

            #region Ejercicio 3

            /*  Programa que lea números hasta que se de un cero y escriba la media de los números leídos. Ejemplo de ejecución:  */

            int media = 0;
            int i = 0;
            int numero;

            do
            {
                Console.Write("Introduce un número :");
                numero = int.Parse(Console.ReadLine());
                media += numero;

                if (numero != 0)
                {
                    i++;
                }

            } while (numero != 0);

            Console.WriteLine("La media es : " + media / i);

            #endregion

            #region Ejercicio 4

            /*  Programa que lee una secuencia de notas (con valores que van de 0 al 10) que termina con el valor -1 
                y nos dice si hay algún 10 entre ellas.  */

            int nota = 0;
            int i = 0;

            while (nota != -1)
            {
                Console.Write("Introduce la nota : ");
                nota = int.Parse(Console.ReadLine());
                if (nota == 10)
                {
                    i++;
                }

            }

            Console.WriteLine("Has introducido " + i + " dieces");

            #endregion

            #region Ejercicio 5

            /*  Programa que lee una secuencia de 100 números y nos dice cuántos hay positivos y cuántos negativos 
                (Para hacer las pruebas puedes reducir el número de entradas).  */

            int positivos = 0;
            int negativos = 0;
            int i = 0;


            while (i < 10)
            {
                Console.Write("Introduce un número : ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }

                i++;
            }

            Console.WriteLine("Has introducido " + positivos + " números positivos y " + negativos + " negativos");

            #endregion

            #region Ejercicio 6

            /*  Programa que lee una secuencia de números no nulos, terminada con la introducción de un 0, y obtiene e imprime el mayor.  */

            int numero = 1;
            int mayor = MinValue();

            while (numero != 0)
            {
                Console.Write("Introduce un número : ");
                numero = int.Parse(Console.ReadLine());

                if (numero > mayor)
                {
                    mayor = numero;
                }

            }
            Console.WriteLine("El mayor es : " + mayor);

            #endregion

            #region Ejercicio 7

            /*  Programa que lee un número entero positivo y calcula su factorial. */

            Console.Write("Introduce un número : ");
            int numero = int.Parse(Console.ReadLine());
            int i = 1;
            string mensaje = numero + "! = ";
            int resultado = 1;

            while (i < numero)
            {
                mensaje += i + " x ";
                ++i;
                resultado *= i;
            }

            Console.WriteLine(mensaje + numero + " = " + resultado);

            #endregion

            #region Ejercicio 8

            /* Programa que obtenga el producto de dos números enteros positivos mediante sumas sucesivas. 
               Esto es, para calcular 2 x 5 haga 2 + 2 + 2+ 2 + 2  */

            Console.Write("Introduce un número : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número : ");
            int numero2 = int.Parse(Console.ReadLine());
            int i = 1;
            int resultado = numero1;
            string mensaje = "El producto por suma sucesiva es " + numero1;

            while (i < numero2)
            {
                resultado += numero1;
                mensaje += " + " + numero1;
                ++i;
            }

            Console.WriteLine(mensaje + " = " + resultado);

            #endregion

            #region Ejercicio 9

            /* Programa que obtenga el cociente y el resto de dos números enteros positivos
               mediante restas. Esto es, para calcular n / 2 haga n -= 2 mientras n >= 2 y cuente el
               número de restas. */

            Console.Write("Introduce un número : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número : ");
            int numero2 = int.Parse(Console.ReadLine());
            int cociente, resto;
            int i = 0;
            int numero1Guardado = numero1;

            while (numero1 >= numero2)
            {
                numero1 -= numero2;
                ++i;
            }
            cociente = i;
            resto = numero1Guardado - (numero2 * i);

            Console.WriteLine("El cociente es : " + cociente + "\nEl resto es : " + resto);

            #endregion

            #region Ejericio 10

            /* Programa que lee un número n de (1 a 9) e imprime su tabla de multiplicar. */

            Console.Write("Introduce un número : ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }

            #endregion

            #region Ejercicio 11

            /* Programa que te diga si un número, introducido por teclado, es primo. */

            Console.Write("Introduce un número : ");
            int numero = int.Parse(Console.ReadLine());
            string mensaje = "";
            int raizNumero = (int)Math.Round(Math.Sqrt(numero));

            if (numero == 2)
            {
                mensaje = "Es primo";
            }
            else if (numero % 2 == 0)
            {
                mensaje = "No es primo";
            }
            else
            {
                for (int i = 2; i <= raizNumero; i++)
                {
                    if (numero % i == 0)
                    {
                        mensaje = "No es primo";
                        break;
                    }
                    else
                        mensaje = "Es primo";
                }
            }

            Console.WriteLine(mensaje);

            #endregion

            #region Ejercicio 12

            /*  Programa que determina si dos números enteros positivos son amigos. 
                (Dos números son amigos si la suma de los divisores del  primero, 
                excepto él mismo, es igual al segundo, y viceversa).  */

            Console.Write("Introduce un número : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce otro número : ");
            int numero2 = int.Parse(Console.ReadLine());
            int sumaDivisores1 = 0, sumaDivisores2 = 0;

            for (int i = 1; i <= numero1; i++)
            {
                if (numero1 % i == 0)
                {
                    sumaDivisores1 += numero1 / i;
                }


            }

            for (int i = 1; i <= numero2; i++)
            {
                if (numero2 % i == 0)
                {
                    sumaDivisores2 += numero2 / i;
                }
            }

            sumaDivisores1 -= numero1;
            sumaDivisores2 -= numero2;

            if (sumaDivisores1 == numero2 && sumaDivisores2 == numero1)
            {
                Console.WriteLine(numero1 + " y " + numero2 + " SÍ son amigos");
            }
            else
            {
                Console.WriteLine(numero1 + " y " + numero2 + " NO son amigos");
            }

            #endregion

            #region Ejercicio 13

            // Haz un programa que muestre en pantalla la tabla de códigos UTF-8

            Console.WriteLine("------------------- UTF-8 CODE---------------------");

            for (int i = 0; i < 256; i++)
            {
                Console.Write(i + "={0}\t ", (char)i);
            }

            #endregion

            #region Ejercicio 14

            /*  Simulación de una calculadora. Realiza un programa que sea capaz de sumar, restar, multiplicar y dividir. 
                El programa presentará un menú, en un bucle para salir con ESC, con las cuatro operaciones que puede realizar. */

            do
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("                     CALCULADORA                         ");
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Introduce un número : ");
                int numero1 = int.Parse(Console.ReadLine());
                Console.Write("Introduce otro número :");
                int numero2 = int.Parse(Console.ReadLine());
                Console.Write("\n1.Suma\n2.Resta\n3.Producto\n4.División\nElija la operación que quiere realizar: ");
                int operacion = int.Parse(Console.ReadLine().ToLower());
                string mensaje = "";


                switch (operacion)
                {
                    case 1:
                        mensaje += (numero1 + numero2);
                        break;

                    case 2:
                        mensaje += (numero1 - numero2);
                        break;

                    case 3:
                        mensaje += (numero1 * numero2);
                        break;

                    case 4:
                        mensaje += "Cociente : " + (numero1 / numero2) + "\nResto : " + (numero1 % numero2);
                        break;

                    default:
                        mensaje += "No existe esa operación";
                        break;
                }

                Console.WriteLine("Resultado : " + mensaje);
                Console.WriteLine("\nPresion ESC para salir - Presione cualquier tecla para realizar otra operación");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            #endregion

            #region Ejercicio 15

            // Imprimir los múltiplos de 7 que hay entre 7 y 112. 

            string mensaje = "";
            int multiplo = 0;

            for (int i = 1; multiplo < 112; i++)
            {
                multiplo = i * 7;
                if (multiplo == 112)
                    mensaje += multiplo;
                else mensaje += multiplo + ", ";
            }

            Console.WriteLine("Los múltiplos de 7 entre 7 y 112 son : " + mensaje);

            #endregion

            #region Ejercicio 16

            /* Pide un número, por ejemplo el 4, y saca en pantalla 1223334444. (Hazlo con un for). */


            Console.Write("Introduce un número :");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
            }

            #endregion

            #region Ejercicio 17

            //  Lee un número y escribe la suma de sus dígitos.

            Console.Write("Introduce un número : ");
            int numero1 = int.Parse(Console.ReadLine());

            int suma = 0;
            int cociente = numero1;

            for (int i = 0; cociente >= 10; i++)
            {
                suma += cociente % 10;
                cociente /= 10;
            }

            Console.WriteLine("La suma de sus dígitos es : " + (suma + cociente));

            #endregion

            #region Ejercicio 18

            /* Imprimir un tablero de ajedrez y sobre él marcar con * las celdas a las que se puede
            mover un alfil desde una posición dada. */

            Console.Write("Introduce fila (1-8): ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Introduce columna (A-H): ");
            char letraColumna = char.Parse(Console.ReadLine());

            int columna = letraColumna - 'A' + 1;

            Console.Write(" ");
            for (char l = 'A'; l <= 'H'; l++)
            {
                Console.Write(l);

            }

            Console.Write("\n");

            for (int f = 1; f <= 8; f++)
            {

                Console.Write(f);
                for (int c = 1; c <= 8; c++)
                {
                    if (Math.Abs(fila - f) == Math.Abs(columna - c))
                    {
                        if (columna == c && f == fila)
                            Console.Write("A");
                        else
                            Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }


            #endregion

            #region Ejercicio 19

            /* Imprimir un tablero de ajedrez y sobre él marcar con *las celdas a las que se puede
            mover un caballo desde una posición dada. */

            Console.Write("Introduce fila (1-8): ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Introduce columna (A-H): ");
            char letraColumna = char.Parse(Console.ReadLine());

            int columna = letraColumna - 'A' + 1;

            Console.Write(" ");
            for (char l = 'A'; l <= 'H'; l++)
            {
                Console.Write(l);

            }

            Console.Write("\n");

            for (int f = 1; f <= 8; f++)
            {

                Console.Write(f);
                for (int c = 1; c <= 8; c++)
                {

                    if (columna == c && f == fila)
                        Console.Write("C");
                    else if (c == columna - 2 && f == fila - 1 ||
                             c == columna - 2 && f == fila + 1 ||
                             c == columna + 2 && f == fila - 1 ||
                             c == columna + 2 && f == fila + 1 ||
                             c == columna + 1 && f == fila + 2 ||
                             c == columna + 1 && f == fila - 2 ||
                             c == columna - 1 && f == fila + 2 ||
                             c == columna - 1 && f == fila - 2)
                    {

                        Console.Write("*");
                    }

                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }

            #endregion

            #region Ejercicio 20

            // Construir un triángulo de n filas con números

            Console.Write("Número de filas : ");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                for (int j = i; j < 2 * i; j++)
                {
                    Console.Write(j % 10);
                }
                Console.Write("\n");
            }

            #endregion

            #region Ejercicio 21

            // Igual que el anterior pero para este otro triángulo

            Console.Write("Número de filas : ");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                int suma = 1;
                for (int j = i; j < 2 * i; j++)
                {

                    Console.Write((j * 2 + suma) % 10);
                    suma++;
                }
                Console.Write("\n");
            }

            #endregion





        }
    }
}
