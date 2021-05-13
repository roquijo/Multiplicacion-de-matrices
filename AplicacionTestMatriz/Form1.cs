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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        int n = 0;
        ServicioMatriz serv = new ServicioMatriz();

        private void btnCrearMatriz_Click(object sender, EventArgs e)
        {

            ServicioMatriz.setN(Convert.ToInt32(txtN.Text));
            n = ServicioMatriz.getN();
            crearMatriz(matrizA);
            ServicioMatriz.crearMatrizA(n);
            crearMatriz(matrizB);
            ServicioMatriz.crearMatrizB(n);
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

        private void btnLlenarMatriz_Click(object sender, EventArgs e)
        {
            int[,] matTem;

            matTem = ServicioMatriz.llenarMatrizA(n);
            llenarMatriz(matrizA, matTem);

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

            List<Experimentacion> listaExp = serv.experimentacion(Convert.ToInt32(txtM.Text));

            gridTiempos.Rows.Clear();

            foreach (Experimentacion exp in listaExp)
            {
                numFila = gridTiempos.Rows.Add();
                iter++;

                gridTiempos.Rows[numFila].Cells[0].Value = exp.getMatriz();
                gridTiempos.Rows[numFila].Cells[1].Value = exp.getParticion().Elapsed.TotalMilliseconds + " ms";
                gridTiempos.Rows[numFila].Cells[2].Value = exp.getStrassen().Elapsed.TotalMilliseconds + " ms";
                gridTiempos.Rows[numFila].Cells[3].Value = exp.getWinograd().Elapsed.TotalMilliseconds + " ms";
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            List<Experimentacion> listaExp = serv.experimentacion(Convert.ToInt32(txtM.Text));
            Series series = new Series("Particion");
            series.ChartType = SeriesChartType.Line;          

            
            foreach (Experimentacion exp in listaExp)
            {
               // series.Points.
            }

            

            
            grafico.Series.Add(series);
        }
    }
}
