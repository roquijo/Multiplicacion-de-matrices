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

        private static int[,] matrizPruebaA = new int[8, 8];
        private static int[,] matrizPruebaB = new int[8, 8];


        private static int[,] matrizExperimentacion;

        private  Stopwatch tiempoParticion = new Stopwatch();

        private  Stopwatch tiempoStrassen = new Stopwatch();

        private  Stopwatch tiempoWinograd = new Stopwatch();

        private Stopwatch tiempoRusos = new Stopwatch();

        private static Random generador = new Random(Environment.TickCount);

        private  List<Experimentacion> listaExperimentacion;

        private static int min = 0;

        private static int max = 2;

        private static int n = 0;

        public static int[,] crearMatrizPruebaB()
        {           

            matrizPruebaB[0, 0] = 1;
            matrizPruebaB[0, 1] = 1;
            matrizPruebaB[0, 2] = 0;
            matrizPruebaB[0, 3] = 1;
            matrizPruebaB[0, 4] = 1;
            matrizPruebaB[0, 5] = 0;
            matrizPruebaB[0, 6] = 0;
            matrizPruebaB[0, 7] = 0;

            matrizPruebaB[1, 0] = 0;
            matrizPruebaB[1, 1] = 0;
            matrizPruebaB[1, 2] = 0;
            matrizPruebaB[1, 3] = 0;
            matrizPruebaB[1, 4] = 1;
            matrizPruebaB[1, 5] = 0;
            matrizPruebaB[1, 6] = 0;
            matrizPruebaB[1, 7] = 1;

            matrizPruebaB[2, 0] = 1;
            matrizPruebaB[2, 1] = 0;
            matrizPruebaB[2, 2] = 0;
            matrizPruebaB[2, 3] = 0;
            matrizPruebaB[2, 4] = 0;
            matrizPruebaB[2, 5] = 0;
            matrizPruebaB[2, 6] = 0;
            matrizPruebaB[2, 7] = 0;

            matrizPruebaB[3, 0] = 0;
            matrizPruebaB[3, 1] = 0;
            matrizPruebaB[3, 2] = 1;
            matrizPruebaB[3, 3] = 0;
            matrizPruebaB[3, 4] = 1;
            matrizPruebaB[3, 5] = 1;
            matrizPruebaB[3, 6] = 1;
            matrizPruebaB[3, 7] = 1;

            matrizPruebaB[4, 0] = 1;
            matrizPruebaB[4, 1] = 1;
            matrizPruebaB[4, 2] = 1;
            matrizPruebaB[4, 3] = 0;
            matrizPruebaB[4, 4] = 0;
            matrizPruebaB[4, 5] = 0;
            matrizPruebaB[4, 6] = 0;
            matrizPruebaB[4, 7] = 0;

            matrizPruebaB[5, 0] = 0;
            matrizPruebaB[5, 1] = 1;
            matrizPruebaB[5, 2] = 1;
            matrizPruebaB[5, 3] = 0;
            matrizPruebaB[5, 4] = 1;
            matrizPruebaB[5, 5] = 0;
            matrizPruebaB[5, 6] = 1;
            matrizPruebaB[5, 7] = 1;

            matrizPruebaB[6, 0] = 0;
            matrizPruebaB[6, 1] = 0;
            matrizPruebaB[6, 2] = 0;
            matrizPruebaB[6, 3] = 0;
            matrizPruebaB[6, 4] = 1;
            matrizPruebaB[6, 5] = 1;
            matrizPruebaB[6, 6] = 1;
            matrizPruebaB[6, 7] = 0;

            matrizPruebaB[7, 0] = 0;
            matrizPruebaB[7, 1] = 1;
            matrizPruebaB[7, 2] = 0;
            matrizPruebaB[7, 3] = 0;
            matrizPruebaB[7, 4] = 1;
            matrizPruebaB[7, 5] = 0;
            matrizPruebaB[7, 6] = 1;
            matrizPruebaB[7, 7] = 0;


            return matrizPruebaB;
        }

        public static int[,] crearMatrizPruebaA()
        {

            matrizPruebaA[0, 0] = 0;
            matrizPruebaA[0, 1] = 0;
            matrizPruebaA[0, 2] = 1;
            matrizPruebaA[0, 3] = 0;
            matrizPruebaA[0, 4] = 0;
            matrizPruebaA[0, 5] = 0;
            matrizPruebaA[0, 6] = 1;
            matrizPruebaA[0, 7] = 0;

            matrizPruebaA[1, 0] = 1;
            matrizPruebaA[1, 1] = 0;
            matrizPruebaA[1, 2] = 0;
            matrizPruebaA[1, 3] = 1;
            matrizPruebaA[1, 4] = 1;
            matrizPruebaA[1, 5] = 0;
            matrizPruebaA[1, 6] = 1;
            matrizPruebaA[1, 7] = 0;

            matrizPruebaA[2, 0] = 1;
            matrizPruebaA[2, 1] = 1;
            matrizPruebaA[2, 2] = 1;
            matrizPruebaA[2, 3] = 1;
            matrizPruebaA[2, 4] = 1;
            matrizPruebaA[2, 5] = 0;
            matrizPruebaA[2, 6] = 1;
            matrizPruebaA[2, 7] = 0;

            matrizPruebaA[3, 0] = 1;
            matrizPruebaA[3, 1] = 0;
            matrizPruebaA[3, 2] = 0;
            matrizPruebaA[3, 3] = 0;
            matrizPruebaA[3, 4] = 1;
            matrizPruebaA[3, 5] = 0;
            matrizPruebaA[3, 6] = 1;
            matrizPruebaA[3, 7] = 0;

            matrizPruebaA[4, 0] = 1;
            matrizPruebaA[4, 1] = 1;
            matrizPruebaA[4, 2] = 0;
            matrizPruebaA[4, 3] = 0;
            matrizPruebaA[4, 4] = 0;
            matrizPruebaA[4, 5] = 0;
            matrizPruebaA[4, 6] = 1;
            matrizPruebaA[4, 7] = 1;

            matrizPruebaA[5, 0] = 1;
            matrizPruebaA[5, 1] = 0;
            matrizPruebaA[5, 2] = 1;
            matrizPruebaA[5, 3] = 1;
            matrizPruebaA[5, 4] = 0;
            matrizPruebaA[5, 5] = 1;
            matrizPruebaA[5, 6] = 0;
            matrizPruebaA[5, 7] = 0;

            matrizPruebaA[6, 0] = 0;
            matrizPruebaA[6, 1] = 0;
            matrizPruebaA[6, 2] = 0;
            matrizPruebaA[6, 3] = 1;
            matrizPruebaA[6, 4] = 0;
            matrizPruebaA[6, 5] = 0;
            matrizPruebaA[6, 6] = 1;
            matrizPruebaA[6, 7] = 0;

            matrizPruebaA[7, 0] = 0;
            matrizPruebaA[7, 1] = 1;
            matrizPruebaA[7, 2] = 1;
            matrizPruebaA[7, 3] = 1;
            matrizPruebaA[7, 4] = 0;
            matrizPruebaA[7, 5] = 1;
            matrizPruebaA[7, 6] = 0;
            matrizPruebaA[7, 7] = 0;


            return matrizPruebaA;
        }


        public static int getN()
        {
            return n;
        }

        public static void setN(int pN)
        {
            n = pN;
        }
        public static int getMin()
        {
            return min;
        }

        public static void setMin(int pMin)
        {
            min = pMin;
        }
        public static int getMax()
        {
            return max;
        }

        public static void setMax(int pMax)
        {
            max = pMax;
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

        public Stopwatch getTiempoRusos()
        {
            return tiempoRusos;
        }

        public static void crearMatrizA(int n)
        {          
                matrizA = new int[n, n];          
        }

        public static void crearMatrizB(int n)
        {
            if(n%2 == 1)
            {
                matrizB = new int[n+1, n+1];
            }
            else
            {
                matrizB = new int[n, n];
            }           
        }

        public static void crearMatrizC(int n)
        {
            if (n % 2 == 1)
            {
                matrizC = new int[n + 1, n + 1];
            }
            else
            {
                matrizC = new int[n, n];
            }
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

        public int[,] llenarMultiplicacionRusos(int n)
        {
            int[,] prueba = multiplicarRusos(n, matrizA, matrizB);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(prueba[i, j] >= 1)
                    {
                        prueba[i, j] = 1;
                    }
                }
            }
            return prueba;
        }

        public static int[,] llenarMatriz(int n, int[,] mat)
        {
            int x;
            
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        x = generador.Next(min, max);
                        mat[i, j] = x;

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

        public int[,] multiplicarRusos(int n, int[,] matA, int[,] matB)
        {
            tiempoRusos.Restart();
                     
            int m = (int)Math.Floor((Math.Log(n,2)));
            
            int iteradorB = 0;            

            int iteradorA = 0;

            int nm = (int)Math.Ceiling(Convert.ToDouble(n)/ Convert.ToDouble(m));
            int dosM = (int)(Math.Pow(2, m));
            
            int[] arregloParaInvertir = new int[nm];
            int[,] c = new int[n, n];

            for (int i = 1; i <= nm; i++)
            {
                int[,] rowsum = new int[dosM, n];

                for (int j = 1; j < dosM; j++)
                {
                    int k = (int)Math.Floor((Math.Log(j, 2))); 

                    int jmenos2k = j - (int)Math.Pow(2, k);

                    if(jmenos2k < 0)
                    {
                        jmenos2k = 0;
                    }
                    iteradorB += k;                  
                    
                    for (int p = 0; p < n; p++)
                    {
                        if(iteradorB >= n)
                        {
                            rowsum[j, p] = rowsum[jmenos2k, p];
                        }
                        else
                        {
                            rowsum[j, p] = rowsum[jmenos2k, p] + matB[iteradorB, p];
                        }                                             
                    }
                    iteradorB -= k;
                }                                
                for (int q = 0; q < n; q++)
                {                                          
                    for (int v = 0; v < nm; v++)
                    {
                        if (iteradorA < n)
                        {                                                      
                            arregloParaInvertir[v] = matA[q, iteradorA];
                            iteradorA++;
                        }
                    }                     
                    iteradorA = iteradorB;
                   
                    int pos = obtenerValor(arregloParaInvertir);                                              
                    
                    for (int w = 0; w < n; w++)
                    {                       
                        if (pos < dosM)
                        {
                            c[q, w] += rowsum[pos, w];
                        }                        
                    }
                    arregloParaInvertir = new int[nm];                 
                }               
                iteradorB += nm;
                iteradorA = iteradorB;
            }            
            tiempoRusos.Stop();
            return c;
        }
        
        public int obtenerValor(int[] arregloParaInvertir)
        {            
            int lengt = arregloParaInvertir.Length;           
            int sum = 0;            
            
            for (int i = 0; i <lengt; i++)
            {
                sum += (arregloParaInvertir[i] * (int)Math.Pow(2, i));                 
            }
                
            return sum;
        }

        public List<Experimentacion> experimentacion(int n)
        {
            Experimentacion exp;
            listaExperimentacion = new List<Experimentacion>();
            double particion, strassen, winograd, rusos;

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

                multiplicarRusos(i, matExp, matExp);
                rusos = tiempoRusos.Elapsed.TotalMilliseconds;

                exp = new Experimentacion(i, particion, strassen, winograd, rusos);
                listaExperimentacion.Add(exp);
            }
            return listaExperimentacion;
        }
    }
}
