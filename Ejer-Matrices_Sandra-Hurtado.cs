using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Matrices
{
    class Program
    {
        #region EJERCICIO1
        static void MostrarMatriz(int[,] bidimensional)
        {
            for (int fila = 0; fila < bidimensional.GetLength(0); fila++)
            {
                for (int columna = 0; columna < bidimensional.GetLength(1); columna++)
                {
                    Console.Write($"{bidimensional[fila, columna]}");
                }
                Console.Write("\n");
            }
        }
        static void Main()
        {
            int[,] bidimensional = new int[10, 10];

            for (int fila = 0; fila < bidimensional.GetLength(0); fila++)
            {

                for (int columna = 0; columna < bidimensional.GetLength(1); columna++)
                {
                    if (fila % 2 == 0)
                    {
                        bidimensional[fila, columna] = 1;
                    }
                    else
                    {
                        bidimensional[fila, columna] = 0;
                    }
                }

            }
            MostrarMatriz(bidimensional);
        }
        #endregion

        #region EJERCICIO2
        static int[,] CrearMatriz()
        {
            int[,] bidimensional = new int[5, 5];

            return bidimensional;
        }

        static int[,] RellenarMatriz(int[,] bidimensional)
        {
            for (int fila = 0; fila < bidimensional.GetLength(0); fila++)
            {
                for (int columna = 0; columna < bidimensional.GetLength(1); columna++)
                {
                    if (fila == columna)
                    {
                        bidimensional[fila, columna] = 1;
                    }

                }
            }
            return bidimensional;
        }

        static void MostrarMatriz(int[,] bidimensional)
        {
            for (int i = 0; i < bidimensional.GetLength(0); i++)
            {
                for (int j = 0; j < bidimensional.GetLength(1); j++)
                {
                    Console.Write($"{bidimensional[i, j]}" + " ");
                }
                Console.Write("\n");
            }
        }

        static void Main()
        {
            int[,] crearMatriz = CrearMatriz();
            int[,] bidimensional = CrearMatriz();
            int[,] rellenarMatriz = RellenarMatriz(bidimensional);

            MostrarMatriz(rellenarMatriz);
        }
        #endregion

        #region EJERCICIO5
        static void MostrarArrayMayor(int[][] m)
        {
            int mayor = 0;
            int[] arrayMasLargo = new int[mayor];
            foreach (int[] fila in m)
            {
                if (fila.Length > arrayMasLargo.Length)
                {
                    arrayMasLargo = fila;
                }
            }
            Console.Write("La fila con mayor elementos es: ");
            foreach (int elementos in arrayMasLargo)
            {
                Console.Write($"{elementos}" + " ");
            }
            Console.Write("\n");
        }
        static void Main()
        {
            int[][] m = new int[][]
            {
              new int [] {1,2,3,4},
              new int [] {5,6,7},
              new int [] {9,10,11,12,5},
              new int [] {9,10}
            };
            MostrarArrayMayor(m);
        }
        #endregion

        #region EJERCICIO6
        static void MostrarMatriz(int[][][] tabla)
        {
            foreach (int[][] elementos in tabla)
            {

                foreach (int[] elementos2 in elementos)
                {
                    foreach (int elementos3 in elementos2)
                    {
                        Console.Write($"{elementos3}" + " ");
                    }
                    Console.Write("\n");
                }
            }

            //for (int i = 0; i < tabla.Length; i++)
            //{
            //    for (int j = 0; j < tabla[i].Length; j++)
            //    {
            //        for (int k = 0; k < tabla[i][j].Length; k++)
            //        {
            //            Console.Write($"{tabla[i][j][k]}" + " ");

            //        }


            //    }
            //    Console.Write("\n");
            //    Console.Write("\t");
            //}

        }

        static void Main()
        {
            int[][][] tabla = new int[][][]
            {
                new int [][]
                {
                    new int [] {1,2,3,4},
                    new int [] {5,6,7},
                    new int [] {9,10,11,12}
                },
                new int [][]
                {
                    new int [] {13,14,15,16},
                    new int [] {17,18,19,20},
                    new int [] {21,22}
                },
            };
            MostrarMatriz(tabla);
            
        }
        #endregion

        #region EJERCICIO7
        static int[][] InicializarTabla()
        {
            int aforoSalaA = 200;
            int aforoSalaB = 150;
            int aforoSalaC = 125;

            int[][] cine = new int[][]
            {
                new int[]
                {
                    aforoSalaA, aforoSalaA, aforoSalaA
                },
                new int[]
                {
                    aforoSalaB, aforoSalaB, aforoSalaB
                },
                new int[]
                {
                    aforoSalaC, aforoSalaC, aforoSalaC
                }
            };

            return cine;
        }
        static void Menu()
        {
            Console.WriteLine("1. Venta de entradas");
            Console.WriteLine("2. Estadística de aforo");
        }
        static void ElegirOpcion(int[][] cine)
        {

            Console.WriteLine("Selecciona alguna de estas opciones: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    VentaDeEntradas(cine);
                    break;
                case 2:
                    EstadisticaAforo(cine);
                    break;
            }
        }
        static int[][] VentaDeEntradas(int[][] cine)
        {

            Console.Write("Introduce el número de entradas a comprar: ");
            int numEntradas = int.Parse(Console.ReadLine());
            Console.Write("Introduce la sala a la que va a asistir (1, 2, 3): ");
            int sala = int.Parse(Console.ReadLine());
            Console.Write("Introduce a qué sesión quiere asistir (1, 2, 3): ");
            int sesion = int.Parse(Console.ReadLine());


            cine[sala - 1][sesion - 1] -= numEntradas;

            return cine;
        }

        static void EstadisticaAforo(int[][] cine)
        {
            Console.Write($"{" ",7}");
            for (int sesion = 0; sesion < cine[0].Length; sesion++)
            {
                Console.Write($"{"Sesion" + (sesion + 1),-9}");
            }
            Console.Write("\n");

            for (int fila = 0; fila < cine.Length; fila++)
            {
                Console.Write($"{"Sala" + (fila + 1),-7}");

                for (int columna = 0; columna < cine[fila].Length; columna++)
                {
                    Console.Write($"{cine[fila][columna],-9}");
                }
                Console.Write("\n");
            }
        }
        static void Main()
        {
            int[][] cine = InicializarTabla();
            do
            {
                Menu();
                ElegirOpcion(cine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        #endregion

        #region EJERCICIO8
        static char[][] CrearTabla()
        {
            char[][] paises = new char[][]
            {
                "España".ToCharArray(),
                "Venezuela".ToCharArray(),
                "Portugal".ToCharArray(),
                "Belgica".ToCharArray(),
                "Marruecos".ToCharArray(),
                "Italia".ToCharArray(),
                "Uruguay".ToCharArray(),
                "Argelia".ToCharArray(),
                "China".ToCharArray(),
                "Japon".ToCharArray(),
                "Grecia".ToCharArray(),
                "Islandia".ToCharArray(),
                "Noruega".ToCharArray(),
                "Rusia".ToCharArray(),
                "Turquia".ToCharArray(),
                "Estados Unidos".ToCharArray(),
                "Inglaterra".ToCharArray(),
                "Canada".ToCharArray(),
                "Andorra".ToCharArray(),
                "Suiza".ToCharArray()
            };
            return paises;
        }
        static int EncuentraPais(char[][] paises, char[] paisConvertidoAChar)
        {
            int indice = -1;
            bool encontrado = false;

            for (int i = 0; i < paises.Length; i++)
            {
                if (paisConvertidoAChar.Length == paises[i].Length)
                {
                    for (int j = 0; j < paises[i].Length; j++)
                    {
                        if (paises[i][j] == paisConvertidoAChar[j])
                        {
                            encontrado = true;
                            indice = i;
                        }
                        else
                        {
                            encontrado = false;
                            break;
                        }
                    }
                }
                if (encontrado)
                    break;
            }
            if (!encontrado)
            {
                Console.WriteLine("País no encontrado");
            }

            return indice;
        }
        static void AñadirPrefijoAPais(char[][] paises, int indice)
        {
            if (indice >= 0)
            {
                Console.Write("Introduce el prefijo: ");
                string prefijo = Console.ReadLine();
                prefijo = "\0" + prefijo;

                string paisesMasPrefijo = new string(paises[indice]) + new string(prefijo.ToCharArray());

                paises[indice] = paisesMasPrefijo.ToCharArray();
            }

        }
        static int Compara(char[] v1, char[] v2)
        {
            int comparacion;
            int lV1 = v1.Length;
            int lV2 = v2.Length;

            int lMin = Math.Min(lV1, lV2);

            comparacion = 0;
            for (int i = 0; i < lMin; i++)
            {
                if (v1[i] != v2[i])
                {
                    comparacion = v1[i] - v2[i];
                    break;
                }
            }
            if (comparacion == 0)
                comparacion = lV1 - lV2;

            return comparacion;
        }
        static char[][] Ordena(char[][] paises)
        {
            char[][] paisesOrdenados = new char[paises.Length][];
            for (int i = 0; i < paises.Length; i++)
            {
                paisesOrdenados[i] = new char[paises[i].Length];
                Array.Copy(paises[i], paisesOrdenados[i], paises[i].Length);
            }

            for (int i = 0; i < paisesOrdenados.Length - 1; i++)
            {
                for (int j = 1; j < paisesOrdenados.Length - i; j++)
                {
                    if (Compara(paisesOrdenados[j - 1], paisesOrdenados[j]) > 0)
                    {
                        char[] swap = paisesOrdenados[j];
                        paisesOrdenados[j] = paisesOrdenados[j - 1];
                        paisesOrdenados[j - 1] = swap;
                    }
                }
            }
            return paisesOrdenados;
        }

        static void Main()
        {
            char[][] paises = CrearTabla();

            char salir = 's';
            do
            {
                Console.Write("Introduce el país a buscar: ");
                string pais = Console.ReadLine();
                char[] paisConvertidoAChar = pais.ToCharArray();

                int indice = EncuentraPais(paises, paisConvertidoAChar);
                AñadirPrefijoAPais(paises, indice);

                Console.Write("¿Quieres salir del programa? (S/N)");
                salir = char.Parse(Console.ReadLine());
            } while (salir != 's');

            char[][] ordena = Ordena(paises);
            for (int i = 0; i < ordena.Length; i++)
            {
                for (int j = 0; j < ordena[i].Length; j++)
                {
                    Console.Write(ordena[i][j]);
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region EJERCICIO9
        static int[][][] CrearTablaDentada(int filas)
        {

            int[][][] elementos = new int[][][]
            {
                new int[filas][],

                new int[filas][],
            };

            for (int i = 0; i < elementos.Length; i++)
            {
                for (int j = 0; j < elementos[i].Length; j++)
                {
                    elementos[i][j] = new int[elementosPorFila];
                }
            }
            foreach (int[][] f in elementos)
            {
                foreach (int[] c in f)
                {
                    foreach (int fc in c)
                    {
                        Console.Write(fc);
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
            return elementos;
        }
        static void RellenarTablaConElementosAleatorios(int[][][] tabla)
        {
            Random seed = new Random();
            for (int i = 0; i < tabla.Length; i++)
            {
                for (int j = 0; j < tabla[i].Length; j++)
                {
                    for (int k = 0; k < tabla[i][j].Length; k++)
                    {
                        tabla[i][j][k] = seed.Next(0, 100);
                    }
                }
            }
        }
        static int PedirElementosPorFila()
        {
            Console.Write("Introduce el número de elementos por fila: ");
            int elementosPorFila = int.Parse(Console.ReadLine());
            return elementosPorFila;
        }
        static void Main()
        {
            Console.Write("Introduce el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            CrearTablaDentada(filas);


        }
        #endregion
        static void Main()
        {
            
        }
    }
}
