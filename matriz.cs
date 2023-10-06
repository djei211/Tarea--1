using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareamatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int SumarEsquinas(int[,] matriz)
                {
                    int filas = matriz.GetLength(0);
                    int columnas = matriz.GetLength(1);

                    if (filas < 2 || columnas < 2)
                    {
                        // La matriz no tiene suficientes elementos para tener esquinas.
                        return 0;
                    }

                    int esquinaSuperiorIzquierda = matriz[0, 0];
                    int esquinaSuperiorDerecha = matriz[0, columnas - 1];
                    int esquinaInferiorIzquierda = matriz[filas - 1, 0];
                    int esquinaInferiorDerecha = matriz[filas - 1, columnas - 1];

                    int sumaEsquinas = esquinaSuperiorIzquierda + esquinaSuperiorDerecha + esquinaInferiorIzquierda + esquinaInferiorDerecha;
                    return sumaEsquinas;
                }

                {
                    int[,] matrizEjemplo = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

                    int sumaEsquinas = SumarEsquinas(matrizEjemplo);
                    Console.WriteLine("La suma de las esquinas de la matriz es: " + sumaEsquinas);
                }
            }
           















        }
    }
}
