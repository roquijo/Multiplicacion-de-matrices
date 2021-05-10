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
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).BeginInit();
            this.SuspendLayout();
            // 
            // matrizA
            // 
            this.matrizA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizA.Location = new System.Drawing.Point(11, 54);
            this.matrizA.Name = "matrizA";
            this.matrizA.Size = new System.Drawing.Size(240, 150);
            this.matrizA.TabIndex = 0;
            // 
            // matrizB
            // 
            this.matrizB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizB.Location = new System.Drawing.Point(277, 54);
            this.matrizB.Name = "matrizB";
            this.matrizB.Size = new System.Drawing.Size(240, 150);
            this.matrizB.TabIndex = 1;
            // 
            // matrizC
            // 
            this.matrizC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrizC.Location = new System.Drawing.Point(548, 54);
            this.matrizC.Name = "matrizC";
            this.matrizC.Size = new System.Drawing.Size(240, 150);
            this.matrizC.TabIndex = 2;
            // 
            // btnCrearMatriz
            // 
            this.btnCrearMatriz.Location = new System.Drawing.Point(11, 236);
            this.btnCrearMatriz.Name = "btnCrearMatriz";
            this.btnCrearMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMatriz.TabIndex = 3;
            this.btnCrearMatriz.Text = "Crear Matriz";
            this.btnCrearMatriz.UseVisualStyleBackColor = true;
            this.btnCrearMatriz.Click += new System.EventHandler(this.btnCrearMatriz_Click);
            // 
            // btnLlenarMatriz
            // 
            this.btnLlenarMatriz.Location = new System.Drawing.Point(116, 236);
            this.btnLlenarMatriz.Name = "btnLlenarMatriz";
            this.btnLlenarMatriz.Size = new System.Drawing.Size(75, 23);
            this.btnLlenarMatriz.TabIndex = 4;
            this.btnLlenarMatriz.Text = "Llenar Matriz";
            this.btnLlenarMatriz.UseVisualStyleBackColor = true;
            this.btnLlenarMatriz.Click += new System.EventHandler(this.btnLlenarMatriz_Click);
            // 
            // btnSumarMatrices
            // 
            this.btnSumarMatrices.Location = new System.Drawing.Point(217, 236);
            this.btnSumarMatrices.Name = "btnSumarMatrices";
            this.btnSumarMatrices.Size = new System.Drawing.Size(96, 23);
            this.btnSumarMatrices.TabIndex = 5;
            this.btnSumarMatrices.Text = "Sumar Matrices";
            this.btnSumarMatrices.UseVisualStyleBackColor = true;
            this.btnSumarMatrices.Click += new System.EventHandler(this.btnSumarMatrices_Click);
            // 
            // btnMultiplicarMatrices
            // 
            this.btnMultiplicarMatrices.Location = new System.Drawing.Point(339, 236);
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
            this.Numer.Location = new System.Drawing.Point(13, 13);
            this.Numer.Name = "Numer";
            this.Numer.Size = new System.Drawing.Size(22, 13);
            this.Numer.TabIndex = 7;
            this.Numer.Text = "n =";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(41, 13);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 8;
            // 
            // btnMultParticion
            // 
            this.btnMultParticion.Location = new System.Drawing.Point(472, 236);
            this.btnMultParticion.Name = "btnMultParticion";
            this.btnMultParticion.Size = new System.Drawing.Size(166, 23);
            this.btnMultParticion.TabIndex = 9;
            this.btnMultParticion.Text = "Multiplicar Matrices Particion";
            this.btnMultParticion.UseVisualStyleBackColor = true;
            this.btnMultParticion.Click += new System.EventHandler(this.btnMultParticion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 275);
            this.Controls.Add(this.btnMultParticion);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.Numer);
            this.Controls.Add(this.btnMultiplicarMatrices);
            this.Controls.Add(this.btnSumarMatrices);
            this.Controls.Add(this.btnLlenarMatriz);
            this.Controls.Add(this.btnCrearMatriz);
            this.Controls.Add(this.matrizC);
            this.Controls.Add(this.matrizB);
            this.Controls.Add(this.matrizA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación Operaciones con Matrices";
            ((System.ComponentModel.ISupportInitialize)(this.matrizA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrizC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

