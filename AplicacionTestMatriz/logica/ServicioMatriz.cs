using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private static int[,] matrizExperimentacion;

        private  Stopwatch tiempoParticion = new Stopwatch();

        private  Stopwatch tiempoStrassen = new Stopwatch();

        private  Stopwatch tiempoWinograd = new Stopwatch();       

        private static Random generador = new Random(Environment.TickCount);

        private  List<Experimentacion> listaExperimentacion;



        private static int n = 0;

        public static int getN()
        {
            return n;
        }

        public static void setN(int pN)
        {
            n = pN;
        }

        public  Stopwatch getTiempoParticion()
        {
            return tiempoParticion;
        }
        public  Stopwatch getTiempoStrassen()
        {
            return tiempoStrassen;
        }
        public  Stopwatch getTiempoWinograd()
        {
            return tiempoWinograd;
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
        public static int[,] crearMatrizExperimentacion(int n)
        {
            matrizExperimentacion = new int[n, n];
            return llenarMatriz(n, matrizExperimentacion);
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
            return sumarMatriz(n, matrizA, matrizB);
        }

        public static int[,] llenarMultiplicacionMatrizC(int n)
        {
            return multiplicarMatriz(n, matrizA, matrizB);
        }

        public int[,] llenarMultiplicacionParticionMatrizC(int n)
        {
            return multiplicarMatrizParticion(n, matrizA, matrizB);
        }
        public int[,] llenarMultiplicacionStrassen(int n)
        {
            return multiplicarMatrizStrassen(n, matrizA, matrizB);
        }
        public int[,] llenarMultiplicacionWinograd(int n)
        {
            return multiplicarMatrizWinograd(n, matrizA, matrizB);
        }

        public static int[,] llenarMatriz(int n, int[,] mat)
        {
            int x;

            if (n % 2 == 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        x = generador.Next(1, 10);
                        mat[i, j] = x;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        x = generador.Next(1, 10);
                        mat[i, j] = x;

                    }
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
                    while (iter < n)
                    {
                        x += matA[i, iter] * matB[iter, j];
                        iter++;
                    }
                    matrizC[i, j] = x;
                }
            }
            return matrizC;
        }

        public int[,] multiplicarMatrizParticion(int n, int[,] matA, int[,] matB)
        {
            tiempoParticion.Restart();

            int a, b, c, d, e, f, g, h, r = 0, s = 0, t = 0, u = 0;

            if(n%2 == 1)
            {
                n -= 1;
            }

            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < n; j += 2)
                {
                    for (int k = 0; k < n; k += 2)
                    {
                        a = matA[j, k];
                        b = matA[j, k + 1];
                        c = matA[j + 1, k];
                        d = matA[j + 1, k + 1];

                        e = matB[k, i];
                        f = matB[k, i + 1];
                        g = matB[k + 1, i];
                        h = matB[k + 1, i + 1];

                        r += (a * e) + (b * g);
                        s += (a * f) + (b * h);
                        t += (c * e) + (d * g);
                        u += (c * f) + (d * h);

                        if ((n == 2) || (k > 0 && k % (n - 2) == 0))
                        {
                            matrizC[j, i] = r;
                            matrizC[j, i + 1] = s;
                            matrizC[j + 1, i] = t;
                            matrizC[j + 1, i + 1] = u;

                            r = 0; s = 0; t = 0; u = 0;
                        }
                    }
                }
            }
            tiempoParticion.Stop();
            return matrizC;
        }

        public int[,] multiplicarMatrizStrassen(int n, int[,] matA, int[,] matB)
        {
            tiempoStrassen.Restart();

            int a, b, c, d, e, f, g, h, r = 0, s = 0, t = 0, u = 0, p1, p2, p3, p4, p5, p6, p7;

            if (n % 2 == 1)
            {
                n -= 1;
            }

            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < n; j += 2)
                {
                    for (int k = 0; k < n; k += 2)
                    {
                        a = matA[j, k];
                        b = matA[j, k + 1];
                        c = matA[j + 1, k];
                        d = matA[j + 1, k + 1];

                        e = matB[k, i];
                        f = matB[k, i + 1];
                        g = matB[k + 1, i];
                        h = matB[k + 1, i + 1];

                        p1 = a * (f - h);
                        p2 = (a + b) * h;
                        p3 = (c + d) * e;
                        p4 = d * (g - e);
                        p5 = (a + d) * (e + h);
                        p6 = (b - d) * (g + h);
                        p7 = (a - c) * (e + f);

                        r += p5 + p6 + p4 - p2;
                        s += p1 + p2;
                        t += p3 + p4;
                        u += p1 - p7 - p3 + p5;

                        if ((n == 2) || (k > 0 && k % (n - 2) == 0))
                        {
                            matrizC[j, i] = r;
                            matrizC[j, i + 1] = s;
                            matrizC[j + 1, i] = t;
                            matrizC[j + 1, i + 1] = u;

                            r = 0; s = 0; t = 0; u = 0;
                        }
                    }
                }
            }
            tiempoStrassen.Stop();
            return matrizC;
        }

        public  int[,] multiplicarMatrizWinograd(int n, int[,] matA, int[,] matB)
        {
            tiempoWinograd.Restart();           

            int a, b, c, d, e, f, g, h, r = 0, s = 0, t = 0, u = 0, p1, p2, p3, p4, p5, p6, p7;

            if (n % 2 == 1)
            {
                n -= 1;
            }

            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < n; j += 2)
                {
                    for (int k = 0; k < n; k += 2)
                    {
                        a = matA[j, k];
                        b = matA[j, k + 1];
                        c = matA[j + 1, k];
                        d = matA[j + 1, k + 1];

                        e = matB[k, i];
                        f = matB[k, i + 1];
                        g = matB[k + 1, i];
                        h = matB[k + 1, i + 1];

                        p1 = (c + d - a) * (h - f + e);
                        p2 = a * e;
                        p3 = b * g;
                        p4 = (a - c) * (h - f);
                        p5 = (c + d) * (f - e);
                        p6 = (b - c + a - d) * h;
                        p7 = d * (g - h + f - e);

                        r += p2 + p3;
                        s += p1 + p2 + p5 + p6;
                        t += p1 + p2 + p4 + p7;
                        u += p1 + p2 + p4 + p5;

                        if ((n == 2) || (k > 0 && k % (n - 2) == 0))
                        {
                            matrizC[j, i] = r;
                            matrizC[j, i + 1] = s;
                            matrizC[j + 1, i] = t;
                            matrizC[j + 1, i + 1] = u;

                            r = 0; s = 0; t = 0; u = 0;
                        }
                    }
                }
            }
            tiempoWinograd.Stop();
            return matrizC;
        }

        public  List<Experimentacion> experimentacion(int n)
        {
            Experimentacion exp;
            listaExperimentacion = new List<Experimentacion>();
            double particion, strassen, winograd;
            

            for (int i = 2; i <= n; i++)
            {
                crearMatrizC(i);
                int[,] matExp = crearMatrizExperimentacion(i);
                              
                multiplicarMatrizParticion(i, matExp, matExp);
                particion = tiempoParticion.Elapsed.TotalMilliseconds;
                            
                multiplicarMatrizStrassen(i, matExp, matExp); 
                strassen = tiempoStrassen.Elapsed.TotalMilliseconds;

                multiplicarMatrizWinograd(i, matExp, matExp); 
                winograd = tiempoWinograd.Elapsed.TotalMilliseconds;

                exp = new Experimentacion(i, particion, strassen, winograd);
                listaExperimentacion.Add(exp);
            }
            return listaExperimentacion;
        }
    }
}
