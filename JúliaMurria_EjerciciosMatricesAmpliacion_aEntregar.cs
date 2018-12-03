using System;
using System.Text;

namespace Probando
{
    class Program
    {
        #region Ej2
        /*Dado el siguiente código:
            static void Main()
            {
                int[,] m1 = new int[,] { { 1, 3, 5 }, { 2, 4, 6 } };
                int[,] m2 = new int[,] { { 6, 5 }, { 4, 3 }, { 2, 1 } };
                int[,] m3 = MultiplicaMatricesEnteras(m1, m2);
            }
        Implementa el código del método estático:
            static int[,] MultiplicaMatricesEnteras(int[,] m1, int[,] m2);
        Debes tener en cuenta al multiplicar dos matrices lo siguiente:
            [A]m,n · [B]n,p = [C]m,p
        Dada una matriz A de m filas y n columnas y una matriz B de n filas y p columnas,
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
        m1.GetLength(1) me devuelve el número de columnas.*/

        static int[,] MultiplicaMatricesEnteras(int[,] m1, int[,] m2)
        {
            int m1Fila = m1.GetLength(0);
            int m2Columna = m2.GetLength(1);

            int[,] m3 = new int[m1Fila, m2Columna];

            for (int fila = 0; fila < m1.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m2.GetLength(1); columna++)
                {
                    //int[,] m3 = new int[,]
                    //{
                    //    {m1[0,0] * m2[0,0] + m1[0,1] * m2[1,0],     m1[0,0] * m2[0,1] + m1[0,1] * m2[1,1],       m1[0,0] * m2[0,2] + m1[0,1] * m2[1,2] },
                    //    {m1[1,0] * m2[0,0] + m1[1,1] * m2[1,0],     m1[1,0] * m2[0,1] + m1[1,1] * m2[1,1],       m1[1,0] * m2[0,2] + m1[1,1] * m2[1,2] },
                    //    {m1[2,0] * m2[0,0] + m1[2,1] * m2[1,0],     m1[2,0] * m2[0,1] + m1[2,1] * m2[1,1],       m1[2,0] * m2[0,2] + m1[2,1] * m2[1,2] }
                    //};

                    //m3[fila, columna] = 0;
                    //sumes per columna i per fila
                    for (int sumas = 0; sumas < m1.GetLength(1); sumas++)
                    {
                        //[A] m,n · [B] n,p = [C] m,p
                        m3[fila, columna] += m1[fila, sumas] * m2[sumas, columna];
                    }
                }
            }
            return m3;
        }

        static void MostrarMatrizResultado(int[,] m3)
        {
            for (int fila = 0; fila < m3.GetLength(0); fila++)
            {
                for (int columna = 0; columna < m3.GetLength(1); columna++)
                {
                    Console.Write($"{m3[fila, columna],-3}");
                }
                Console.WriteLine("\n");
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

            if (m1.GetLength(1) == m2.GetLength(0))
            {
                int[,] m3 = MultiplicaMatricesEnteras(m1, m2);
                MostrarMatrizResultado(m3);
            }
            else
                Console.WriteLine("Error. No se pueden multiplicar las matrices.");
        }
        #endregion
    }
}
