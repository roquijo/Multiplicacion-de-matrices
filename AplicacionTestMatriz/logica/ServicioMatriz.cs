using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTestMatriz.logica
{
    class ServicioMatriz
    {
        private static int[,] matrizA;

        private static int[,] matrizB;

        private static int[,] matrizC;

        private static Random generador = new Random(Environment.TickCount);

        private static int n = 0;

        public static int getN()
        {
            return n;
        }

        public static void setN(int pN)
        {
            n = pN;
        }

        public static void crearMatrizA(int n)
        {
            matrizA = new int[n, n];
        }

        public static void crearMatrizB(int n)
        {
            matrizB = new int[n, n];
        }

        public static void crearMatrizC(int n)
        {
            matrizC = new int[n, n];
        }

        public static int[,] llenarMatrizA(int n)
        {
            
            return llenarMatriz(n, matrizA);
        }

        public static int[,] llenarMatrizB(int n)
        {          
            return llenarMatriz(n, matrizB);
        }
        
        public static int[,] llenarSumaMatrizC(int n)
        {
           return sumarMatriz(n, matrizA,matrizB);
        }

        public static int[,] llenarMultiplicacionMatrizC(int n)
        {
            return multiplicarMatriz(n, matrizA, matrizB);
        }

        public static int[,] llenarMultiplicacionParticionMatrizC(int n)
        {
            return multiplicarMatrizParticion(n, matrizA, matrizB);
        }

        public static int[,] llenarMatriz(int n, int[,] mat)
        {
            int x;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x = generador.Next(1, 10);
                    mat[i,j] = x;
                }
            }
            return mat;
        }

        public static int[,] sumarMatriz(int n, int[,] matA, int[,] matB)
        {
            int x;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x = matA[i, j] + matB[i, j];
                    matrizC[i, j] = x;
                }
            }
            return matrizC;
        }

        public static int[,] multiplicarMatriz(int n, int[,] matA, int[,] matB)
        {
            int x;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x = 0;
                    int iter = 0;
                    while(iter < n)
                    {
                        x += matA[i, iter] * matB[iter, j];
                        iter++;
                    }                   
                    matrizC[i, j] = x;
                }
            }
            return matrizC;
        }

        public static int[,] multiplicarMatrizParticion(int n, int[,] matA, int[,] matB)
        {
            int a, b, c, d, e, f, g, h, r = 0, s = 0, t = 0, u = 0;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-1; j+=2)
                {
                    a = matA[i, j];
                    b = matA[i, j + 1];
                    c = matA[i + 1, j];
                    d = matA[i + 1, j + 1];

                    e = matB[j, i];
                    f = matB[j, i + 1];
                    g = matB[j + 1, i];
                    h = matB[j + 1, i + 1];

                    r += (a * e) + (b * g);
                    s += (a * f) + (b * h);
                    t += (c * e) + (d * g);
                    u += (c * f) + (d * h);

                    if (j > 0 && j % 2 == 0)
                    {
                        matrizC[i, i] = r;
                        matrizC[i, i+1] = s;
                        matrizC[i+1, i] = t;
                        matrizC[i+1, i+1] = u;

                        r = 0; s = 0; t = 0; u = 0;
                    }
                }             
                
            }
            return matrizC;
        }
    }
}
