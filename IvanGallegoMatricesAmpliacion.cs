using System;

namespace Programa
{
	class Program
	{
		#region Ejercicio1
        /* Introduce en una tabla dentada cinco provincias.Introduce en una matriz los códigos de
        las provincias(5 caracteres). Ordena alfabéticamente por nombre de provincia y visualiza
        (nombre y código). Ordena por código de provincia y visualiza(nombre y código). Utiliza
        las funciones necesarias para que el código quede claro. */
        static int Compara(char[] v1, char[] v2)
        {
            string c1 = new string(v1);
            string c2 = new string(v2);
            return c1.CompareTo(c2);
        }

        static char[][] Ordena(char[][] v)
        {
            char[][] o = new char[v.Length][];
            for (int i = 0; i < o.Length; i++)
            {
                o[i] = new char[v[i].Length];
                Array.Copy(v[i], o[i], v[i].Length);
            }
            for (int i = 0; i < o.Length - 1; i++)
            {
                for (int j = 1; j < o.Length - i; j++)
                {
                    if (Compara(o[j - 1],o[j]) > 0)
                    {
                        char[] aux = o[j];
                        o[j] = o[j - 1];
                        o[j - 1] = aux;
                    }
                }
            }
            return o;
        }

        static string MostrarFila(char[][] v, int indice)
        {
            string mensaje = "";
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < v[i].Length; j++)
                {
                    if (i == indice)
                    {
                        mensaje += $"{v[i][j]}";
                    }
                }
            }
            return mensaje;
        }

        static void MostrarMatrices(char[][] v1, char[][] v2)
        {
            for (int i = 0; i < v1.Length; i++)
            {
                string mensaje1 = MostrarFila(v1, i);
                string mensaje2 = MostrarFila(v2, i);
                Console.WriteLine($"{mensaje1,-15}{mensaje2}");
            }
        }
        static void Main()
        {
            char[][] provincias = new char[][]
            {
                "Madrid".ToCharArray(),
                "Alicante".ToCharArray(),
                "Valencia".ToCharArray(),
                "Castellón".ToCharArray(),
                "Murcia".ToCharArray()
            };
            char[][] codigos = new char[][]
            {
                "MADRD".ToCharArray(),
                "ALCNT".ToCharArray(),
                "VLNCA".ToCharArray(),
                "CSTLN".ToCharArray(),
                "MRCIA".ToCharArray()
            };
            char[][] provinciasO = Ordena(provincias);
            char[][] codigosO = Ordena(codigos);
            Console.WriteLine("Provincias ordenadas y códigos.");
            MostrarMatrices(provinciasO, codigos);
            Console.WriteLine("\nProvincias y códigos ordenados.");
            MostrarMatrices(provincias, codigosO);
        }
        #endregion
		#region Ejercicio2
        /* Dado el siguiente código:
        static void Main()
        {
            int[,] m1 = new int[,] { { 1, 3, 5 }, { 2, 4, 6 } };
            int[,] m2 = new int[,] { { 6, 5 }, { 4, 3 }, { 2, 1 } };
            int[,] m3 = MultiplicaMatricesEnteras(m1, m2);
        }
        Implementa el código del método estático:
        static int[,] MultiplicaMatricesEnteras(int[,] m1, int[,] m2);
        Dada una matriz A de m filas y n columnas y el y una matriz B de n filas y p columnas,
        para poder multiplicarse el número de columnas de la primera debe coincidir con el
        número de filas de la segunda, como es el caso, de no ser así mostraremos el siguiente
        mensaje de error:
        No se pueden multiplicar las matrices.
        Además el resultado será una matriz C de m filas y p columnas (las filas de A y las
        columnas de B) de tal manera que Cij (fila i-ésima y columna j-ésima de C) se obtiene de
        sumar los productos de los elementos correspondientes a la fila i-ésima de la primera
        matriz (A), por los de la columna j-ésima de la segunda matriz (B).
        Para solucionar el ejercicio debes tener en cuenta que el método
        m1.GetLength(dimension) devuelve el número de elementos de m1 en la dimensión
        especificada, de tal manera que m1.Getlength(0) me devuelve el número de filas de m1 y
        m1.GetLength(1) me devuelve el número de columnas. */
        static bool Multiplicables(int[,] m1, int[,] m2, out string mensajeInformativo)
        {
            bool multiplicable = m1.GetLength(1) == m2.GetLength(0);
            mensajeInformativo = multiplicable ? "" : "No se pueden multiplicar las matrices\n";
            return multiplicable;
        }

        static int[] ObtenerFilaDeMatriz(int[,] m, int indice)
        {
            int[] fila = new int[m.GetLength(1)];
            for (int i = 0; i < fila.Length; i++)
                fila[i] = m[indice, i];
            return fila;
        }

        static int[] ObtenerColumnaDeMatriz(int[,] m, int indice)
        {
            int[] columna = new int[m.GetLength(0)];
            for (int i = 0; i < columna.Length; i++)
                columna[i] = m[i, indice];
            return columna;
        }

        static int ColumnaPorFilaMasElementos(int[] v1, int[] v2)
        {
            int resultado = 0;
            for (int i = 0; i < v1.Length; i++)
                resultado += v1[i] * v2[i];
            return resultado;
        }

        static int[,] MultiplicaMatricesEnteras(int[,] m1, int[,] m2)
        {
            int[,] m3 = new int[m1.GetLength(0), m2.GetLength(1)];
            for (int i = 0; i < m3.GetLength(0); i++)
            {
                for (int j = 0; j < m3.GetLength(1); j++)
                {
                    int[] fila = ObtenerFilaDeMatriz(m1, i);
                    int[] columna = ObtenerColumnaDeMatriz(m2, j);
                    m3[i, j] = ColumnaPorFilaMasElementos(fila, columna);
                }
            }
            return m3;
        }

        static void MostrarMatriz(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write($"{m[i, j],-4}");
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[,] m1 = new int[,]
            {
                { 1, 3, 5 },
                { 2, 4, 6 }
            };
            int[,] m2 = new int[,]
            {
                { 6, 5 },
                { 4, 3 },
                { 2, 1 }
            };
            bool matricesMultiplicables = Multiplicables(m1, m2, out string mensajeInformativo);
            Console.Write(mensajeInformativo);
            if (matricesMultiplicables)
            {
                int[,] m3 = MultiplicaMatricesEnteras(m1, m2);
                MostrarMatriz(m3);
            }
        }
        #endregion
	}
}