using AplicacionTestMatriz.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AplicacionTestMatriz
{
    public partial class GUIOperacionMatrices : Form
    {
        public GUIOperacionMatrices()
        {
            InitializeComponent();
            
        }

        int n = 0;
        ServicioMatriz serv = new ServicioMatriz();
        List<Experimentacion> listaExp = new List<Experimentacion>();

        private void btnCrearMatriz_Click(object sender, EventArgs e)
        {

            ServicioMatriz.setN(Convert.ToInt32(txtN.Text));
            n = ServicioMatriz.getN();            
            ServicioMatriz.crearMatrizA(n);            
            ServicioMatriz.crearMatrizB(n);
            crearMatriz(matrizA);
            crearMatriz(matrizB);
        }

        private void llenarMatriz(DataGridView dgv, int[,] mat)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dgv.Rows[i].Cells[j].Value = mat[i, j];
                }
            }
        }

        private void crearMatriz(DataGridView mat)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            if(n%2 == 1)
            {
                n ++;
                for (int i = 1; i <= n; i++)
                {
                    dt.Columns.Add(new DataColumn("C" + i));
                }

                for (int i = 0; i < n; i++)
                {
                    dr = dt.NewRow();
                    int j = 1;
                    while (j <= n)
                    {
                        dr["C" + j] = "";
                        j++;
                    }
                    dt.Rows.Add(dr);
                }
                mat.DataSource = dt;

                for (int i = 0; i < n; i++)
                {
                    mat.Columns[i].Width = 30;
                }
                n--;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    dt.Columns.Add(new DataColumn("C" + i));
                }

                for (int i = 0; i < n; i++)
                {
                    dr = dt.NewRow();
                    int j = 1;
                    while (j <= n)
                    {
                        dr["C" + j] = "";
                        j++;
                    }
                    dt.Rows.Add(dr);
                }
                mat.DataSource = dt;

                for (int i = 0; i < n; i++)
                {
                    mat.Columns[i].Width = 30;
                }
            }
            
        }

        private void btnLlenarMatriz_Click(object sender, EventArgs e)
        {
            int[,] matTem;

            //matTem = ServicioMatriz.crearMatrizPruebaA();
            matTem = ServicioMatriz.llenarMatrizA(n);
            llenarMatriz(matrizA, matTem);
            //matTem = ServicioMatriz.crearMatrizPruebaB();
            matTem = ServicioMatriz.llenarMatrizB(n);
            llenarMatriz(matrizB, matTem);
        }

        private void btnSumarMatrices_Click(object sender, EventArgs e)
        {
            crearMatriz(matrizC);
            ServicioMatriz.crearMatrizC(n);

            int[,] matTem;

            matTem = ServicioMatriz.llenarSumaMatrizC(n);
            llenarMatriz(matrizC, matTem);
        }

        private void btnMultiplicarMatrices_Click(object sender, EventArgs e)
        {
            crearMatriz(matrizC);
            ServicioMatriz.crearMatrizC(n);

            int[,] matTem;

            matTem = ServicioMatriz.llenarMultiplicacionMatrizC(n);
            llenarMatriz(matrizC, matTem);
        }

        private void btnMultParticion_Click(object sender, EventArgs e)
        {
            crearMatriz(matrizC);
            ServicioMatriz.crearMatrizC(n);

            int[,] matTem;

            matTem = serv.llenarMultiplicacionParticionMatrizC(n);
            llenarMatriz(matrizC, matTem);

            txtParticion.Text = serv.getTiempoParticion().Elapsed.TotalMilliseconds + " ms";
        }

        private void btnStrassen_Click(object sender, EventArgs e)
        {
            crearMatriz(matrizC);
            ServicioMatriz.crearMatrizC(n);

            int[,] matTem;

            matTem = serv.llenarMultiplicacionStrassen(n);
            llenarMatriz(matrizC, matTem);


            txtStrassen.Text = serv.getTiempoStrassen().Elapsed.TotalMilliseconds + " ms";
        }

        private void btnWinograd_Click_1(object sender, EventArgs e)
        {
            crearMatriz(matrizC);
            ServicioMatriz.crearMatrizC(n);

            int[,] matTem;

            matTem = serv.llenarMultiplicacionWinograd(n);
            llenarMatriz(matrizC, matTem);
            txtWinograd.Text = serv.getTiempoWinograd().Elapsed.TotalMilliseconds + " ms";
        }

        private void btnExperimentar_Click_1(object sender, EventArgs e)
        {
                      
            int numFila;
            int iter = 0;

            listaExp.Clear();
            listaExp = serv.experimentacion(Convert.ToInt32(txtM.Text));

            gridTiempos.Rows.Clear();

            foreach (Experimentacion exp in listaExp)
            {
                numFila = gridTiempos.Rows.Add();
                iter++;

                gridTiempos.Rows[numFila].Cells[0].Value = exp.getMatriz();
                gridTiempos.Rows[numFila].Cells[1].Value = exp.getParticion() + " ms";
                gridTiempos.Rows[numFila].Cells[2].Value = exp.getStrassen() + " ms";
                gridTiempos.Rows[numFila].Cells[3].Value = exp.getWinograd() + " ms";
                gridTiempos.Rows[numFila].Cells[4].Value = exp.getRusos() + " ms";
            }            
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            grafico.Series.Clear();         
            Series serieParticion = new Series("Particion");
            serieParticion.ChartType = SeriesChartType.Line;

            Series serieStrassen = new Series("Strassen");
            serieStrassen.ChartType = SeriesChartType.Line;

            Series serieWinograd = new Series("Winograd");
            serieWinograd.ChartType = SeriesChartType.Line;

            Series serieRusos = new Series("Rusos");
            serieRusos.ChartType = SeriesChartType.Line;
            serieRusos.Font = new Font("Arial", 20);

            double[] puntosYParticion = new double[listaExp.Count];
            double[] puntosYStrassen = new double[listaExp.Count];
            double[] puntosYWinograd = new double[listaExp.Count];
            double[] puntosYRusos = new double[listaExp.Count];
            int[] x = new int[listaExp.Count];

            for (int i = 0; i < listaExp.Count; i++)
            {
                puntosYParticion[i] = listaExp.ElementAt(i).getParticion();
                puntosYStrassen[i] = listaExp.ElementAt(i).getStrassen();
                puntosYWinograd[i] = listaExp.ElementAt(i).getWinograd();
                puntosYRusos[i] = listaExp.ElementAt(i).getRusos();
                x[i] = listaExp.ElementAt(i).getMatriz();
            }

            serieParticion.Points.DataBindXY(x, puntosYParticion);
            serieStrassen.Points.DataBindXY(x, puntosYStrassen);
            serieWinograd.Points.DataBindXY(x, puntosYWinograd);
            serieRusos.Points.DataBindXY(x, puntosYRusos);

            grafico.Series.Add(serieParticion);
            grafico.Series.Add(serieStrassen);
            grafico.Series.Add(serieWinograd);
            grafico.Series.Add(serieRusos);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {          
                try
                {
                    ServicioMatriz.setMin(Convert.ToInt32(txtMin.Text));
                    ServicioMatriz.setMax(Convert.ToInt32(txtMax.Text));
                    MessageBox.Show("Valores asignados");
                }
                catch
                {
                    ServicioMatriz.setMin(1);
                    ServicioMatriz.setMax(10);
                MessageBox.Show("Valores por defecto asignados");
                }                         
        }

        private void btnRusos_Click(object sender, EventArgs e)
        {
            crearMatriz(matrizC);
            ServicioMatriz.crearMatrizC(n);

            int[,] matTem;

            matTem = serv.llenarMultiplicacionRusos(n);
            llenarMatriz(matrizC, matTem);
            txtRusos.Text = serv.getTiempoRusos().Elapsed.TotalMilliseconds + " ms";
        }
    }
}
