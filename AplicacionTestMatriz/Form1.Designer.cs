namespace AplicacionTestMatriz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.matrizA = new System.Windows.Forms.DataGridView();
            this.matrizB = new System.Windows.Forms.DataGridView();
            this.matrizC = new System.Windows.Forms.DataGridView();
            this.btnCrearMatriz = new System.Windows.Forms.Button();
            this.btnLlenarMatriz = new System.Windows.Forms.Button();
            this.btnSumarMatrices = new System.Windows.Forms.Button();
            this.btnMultiplicarMatrices = new System.Windows.Forms.Button();
            this.Numer = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnMultParticion = new System.Windows.Forms.Button();
            this.btnStrassen = new System.Windows.Forms.Button();
            this.btnWinograd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParticion = new System.Windows.Forms.TextBox();
            this.txtStrassen = new System.Windows.Forms.TextBox();
            this.txtWinograd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.btnExperimentar = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.gridTiempos = new System.Windows.Forms.DataGridView();
            this.Matriz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strassen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Winograd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrizA
            // 
            this.matrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizA.Location = new System.Drawing.Point(25, 49);
            this.matrizA.Name = "matrizA";
            this.matrizA.Size = new System.Drawing.Size(240, 150);
            this.matrizA.TabIndex = 0;
            // 
            // matrizB
            // 
            this.matrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizB.Location = new System.Drawing.Point(291, 49);
            this.matrizB.Name = "matrizB";
            this.matrizB.Size = new System.Drawing.Size(240, 150);
            this.matrizB.TabIndex = 1;
            // 
            // matrizC
            // 
            this.matrizC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizC.Location = new System.Drawing.Point(562, 49);
            this.matrizC.Name = "matrizC";
            this.matrizC.Size = new System.Drawing.Size(240, 150);
            this.matrizC.TabIndex = 2;
            // 
            // btnCrearMatriz
            // 
            this.btnCrearMatriz.Location = new System.Drawing.Point(25, 220);
            this.btnCrearMatriz.Name = "btnCrearMatriz";
            this.btnCrearMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMatriz.TabIndex = 3;
            this.btnCrearMatriz.Text = "Crear Matriz";
            this.btnCrearMatriz.UseVisualStyleBackColor = true;
            this.btnCrearMatriz.Click += new System.EventHandler(this.btnCrearMatriz_Click);
            // 
            // btnLlenarMatriz
            // 
            this.btnLlenarMatriz.Location = new System.Drawing.Point(130, 220);
            this.btnLlenarMatriz.Name = "btnLlenarMatriz";
            this.btnLlenarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnLlenarMatriz.TabIndex = 4;
            this.btnLlenarMatriz.Text = "Llenar Matriz";
            this.btnLlenarMatriz.UseVisualStyleBackColor = true;
            this.btnLlenarMatriz.Click += new System.EventHandler(this.btnLlenarMatriz_Click);
            // 
            // btnSumarMatrices
            // 
            this.btnSumarMatrices.Location = new System.Drawing.Point(231, 220);
            this.btnSumarMatrices.Name = "btnSumarMatrices";
            this.btnSumarMatrices.Size = new System.Drawing.Size(96, 23);
            this.btnSumarMatrices.TabIndex = 5;
            this.btnSumarMatrices.Text = "Sumar Matrices";
            this.btnSumarMatrices.UseVisualStyleBackColor = true;
            this.btnSumarMatrices.Click += new System.EventHandler(this.btnSumarMatrices_Click);
            // 
            // btnMultiplicarMatrices
            // 
            this.btnMultiplicarMatrices.Location = new System.Drawing.Point(360, 220);
            this.btnMultiplicarMatrices.Name = "btnMultiplicarMatrices";
            this.btnMultiplicarMatrices.Size = new System.Drawing.Size(118, 23);
            this.btnMultiplicarMatrices.TabIndex = 6;
            this.btnMultiplicarMatrices.Text = "Multiplicar Matrices";
            this.btnMultiplicarMatrices.UseVisualStyleBackColor = true;
            this.btnMultiplicarMatrices.Click += new System.EventHandler(this.btnMultiplicarMatrices_Click);
            // 
            // Numer
            // 
            this.Numer.AutoSize = true;
            this.Numer.Location = new System.Drawing.Point(26, 17);
            this.Numer.Name = "Numer";
            this.Numer.Size = new System.Drawing.Size(22, 13);
            this.Numer.TabIndex = 7;
            this.Numer.Text = "n =";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(54, 14);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(90, 20);
            this.txtN.TabIndex = 8;
            // 
            // btnMultParticion
            // 
            this.btnMultParticion.Location = new System.Drawing.Point(511, 220);
            this.btnMultParticion.Name = "btnMultParticion";
            this.btnMultParticion.Size = new System.Drawing.Size(70, 23);
            this.btnMultParticion.TabIndex = 9;
            this.btnMultParticion.Text = "Partición";
            this.btnMultParticion.UseVisualStyleBackColor = true;
            this.btnMultParticion.Click += new System.EventHandler(this.btnMultParticion_Click);
            // 
            // btnStrassen
            // 
            this.btnStrassen.Location = new System.Drawing.Point(618, 220);
            this.btnStrassen.Name = "btnStrassen";
            this.btnStrassen.Size = new System.Drawing.Size(75, 23);
            this.btnStrassen.TabIndex = 10;
            this.btnStrassen.Text = "Strassen";
            this.btnStrassen.UseVisualStyleBackColor = true;
            this.btnStrassen.Click += new System.EventHandler(this.btnStrassen_Click);
            // 
            // btnWinograd
            // 
            this.btnWinograd.Location = new System.Drawing.Point(727, 220);
            this.btnWinograd.Name = "btnWinograd";
            this.btnWinograd.Size = new System.Drawing.Size(75, 23);
            this.btnWinograd.TabIndex = 11;
            this.btnWinograd.Text = "Winograd";
            this.btnWinograd.UseVisualStyleBackColor = true;
            this.btnWinograd.Click += new System.EventHandler(this.btnWinograd_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tiempo Particion = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(845, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tiempo Strassen = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(840, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tiempo Winograd = ";
            // 
            // txtParticion
            // 
            this.txtParticion.Location = new System.Drawing.Point(949, 49);
            this.txtParticion.Name = "txtParticion";
            this.txtParticion.Size = new System.Drawing.Size(100, 20);
            this.txtParticion.TabIndex = 15;
            // 
            // txtStrassen
            // 
            this.txtStrassen.Location = new System.Drawing.Point(949, 112);
            this.txtStrassen.Name = "txtStrassen";
            this.txtStrassen.Size = new System.Drawing.Size(100, 20);
            this.txtStrassen.TabIndex = 16;
            // 
            // txtWinograd
            // 
            this.txtWinograd.Location = new System.Drawing.Point(949, 179);
            this.txtWinograd.Name = "txtWinograd";
            this.txtWinograd.Size = new System.Drawing.Size(100, 20);
            this.txtWinograd.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "m = ";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(45, 19);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(90, 20);
            this.txtM.TabIndex = 20;
            // 
            // btnExperimentar
            // 
            this.btnExperimentar.Location = new System.Drawing.Point(141, 16);
            this.btnExperimentar.Name = "btnExperimentar";
            this.btnExperimentar.Size = new System.Drawing.Size(79, 23);
            this.btnExperimentar.TabIndex = 21;
            this.btnExperimentar.Text = "Experimentar";
            this.btnExperimentar.UseVisualStyleBackColor = true;
            this.btnExperimentar.Click += new System.EventHandler(this.btnExperimentar_Click_1);
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(494, 60);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(581, 316);
            this.grafico.TabIndex = 18;
            this.grafico.Text = "chart1";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(767, 394);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 22;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // gridTiempos
            // 
            this.gridTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTiempos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matriz,
            this.Particion,
            this.Strassen,
            this.Winograd});
            this.gridTiempos.Location = new System.Drawing.Point(8, 60);
            this.gridTiempos.Name = "gridTiempos";
            this.gridTiempos.Size = new System.Drawing.Size(439, 307);
            this.gridTiempos.TabIndex = 23;
            // 
            // Matriz
            // 
            this.Matriz.HeaderText = "Matriz";
            this.Matriz.Name = "Matriz";
            // 
            // Particion
            // 
            this.Particion.HeaderText = "Particion";
            this.Particion.Name = "Particion";
            // 
            // Strassen
            // 
            this.Strassen.HeaderText = "Strassen";
            this.Strassen.Name = "Strassen";
            // 
            // Winograd
            // 
            this.Winograd.HeaderText = "Winograd";
            this.Winograd.Name = "Winograd";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.matrizC);
            this.panel1.Controls.Add(this.matrizA);
            this.panel1.Controls.Add(this.matrizB);
            this.panel1.Controls.Add(this.btnCrearMatriz);
            this.panel1.Controls.Add(this.btnLlenarMatriz);
            this.panel1.Controls.Add(this.btnSumarMatrices);
            this.panel1.Controls.Add(this.btnMultiplicarMatrices);
            this.panel1.Controls.Add(this.txtWinograd);
            this.panel1.Controls.Add(this.Numer);
            this.panel1.Controls.Add(this.txtStrassen);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.txtParticion);
            this.panel1.Controls.Add(this.btnMultParticion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnStrassen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnWinograd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 258);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtM);
            this.panel2.Controls.Add(this.gridTiempos);
            this.panel2.Controls.Add(this.grafico);
            this.panel2.Controls.Add(this.btnGraficar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnExperimentar);
            this.panel2.Location = new System.Drawing.Point(20, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 426);
            this.panel2.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 742);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Operaciones con Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiempos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrizA;
        private System.Windows.Forms.DataGridView matrizB;
        private System.Windows.Forms.DataGridView matrizC;
        private System.Windows.Forms.Button btnCrearMatriz;
        private System.Windows.Forms.Button btnLlenarMatriz;
        private System.Windows.Forms.Button btnSumarMatrices;
        private System.Windows.Forms.Button btnMultiplicarMatrices;
        private System.Windows.Forms.Label Numer;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnMultParticion;
        private System.Windows.Forms.Button btnStrassen;
        private System.Windows.Forms.Button btnWinograd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParticion;
        private System.Windows.Forms.TextBox txtStrassen;
        private System.Windows.Forms.TextBox txtWinograd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Button btnExperimentar;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataGridView gridTiempos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strassen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Winograd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

