namespace Decisiones_en_Escenarios_Complejos.Topsis
{
    partial class frm_topsis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_matriz = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_pesos = new System.Windows.Forms.DataGridView();
            this.btn_normalizar = new System.Windows.Forms.Button();
            this.btn_identificar_solucion = new System.Windows.Forms.Button();
            this.btn_calcular_distancia_a_mas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.btn_calcular_distancia_a_menos = new System.Windows.Forms.Button();
            this.btn_ordenar_resultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_matriz);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 208);
            this.panel1.TabIndex = 0;
            // 
            // dgv_matriz
            // 
            this.dgv_matriz.AllowUserToAddRows = false;
            this.dgv_matriz.AllowUserToDeleteRows = false;
            this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_matriz.Location = new System.Drawing.Point(0, 0);
            this.dgv_matriz.Name = "dgv_matriz";
            this.dgv_matriz.ReadOnly = true;
            this.dgv_matriz.RowHeadersVisible = false;
            this.dgv_matriz.Size = new System.Drawing.Size(625, 208);
            this.dgv_matriz.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_pesos);
            this.panel2.Location = new System.Drawing.Point(12, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 100);
            this.panel2.TabIndex = 0;
            // 
            // dgv_pesos
            // 
            this.dgv_pesos.AllowUserToAddRows = false;
            this.dgv_pesos.AllowUserToDeleteRows = false;
            this.dgv_pesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pesos.Location = new System.Drawing.Point(0, 0);
            this.dgv_pesos.Name = "dgv_pesos";
            this.dgv_pesos.ReadOnly = true;
            this.dgv_pesos.RowHeadersVisible = false;
            this.dgv_pesos.Size = new System.Drawing.Size(625, 100);
            this.dgv_pesos.TabIndex = 0;
            // 
            // btn_normalizar
            // 
            this.btn_normalizar.Location = new System.Drawing.Point(12, 75);
            this.btn_normalizar.Name = "btn_normalizar";
            this.btn_normalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_normalizar.TabIndex = 1;
            this.btn_normalizar.Text = "Normalizar";
            this.btn_normalizar.UseVisualStyleBackColor = true;
            this.btn_normalizar.Click += new System.EventHandler(this.Btn_normalizar_Click);
            // 
            // btn_identificar_solucion
            // 
            this.btn_identificar_solucion.Enabled = false;
            this.btn_identificar_solucion.Location = new System.Drawing.Point(139, 75);
            this.btn_identificar_solucion.Name = "btn_identificar_solucion";
            this.btn_identificar_solucion.Size = new System.Drawing.Size(116, 23);
            this.btn_identificar_solucion.TabIndex = 2;
            this.btn_identificar_solucion.Text = "Identificar Solucion";
            this.btn_identificar_solucion.UseVisualStyleBackColor = true;
            this.btn_identificar_solucion.Click += new System.EventHandler(this.Btn_identificar_solucion_Click);
            // 
            // btn_calcular_distancia_a_mas
            // 
            this.btn_calcular_distancia_a_mas.Enabled = false;
            this.btn_calcular_distancia_a_mas.Location = new System.Drawing.Point(306, 75);
            this.btn_calcular_distancia_a_mas.Name = "btn_calcular_distancia_a_mas";
            this.btn_calcular_distancia_a_mas.Size = new System.Drawing.Size(122, 23);
            this.btn_calcular_distancia_a_mas.TabIndex = 3;
            this.btn_calcular_distancia_a_mas.Text = "Calcular Distancia A+";
            this.btn_calcular_distancia_a_mas.UseVisualStyleBackColor = true;
            this.btn_calcular_distancia_a_mas.Click += new System.EventHandler(this.Btn_calcular_distancia_a_mas_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_resultado);
            this.panel3.Location = new System.Drawing.Point(643, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 208);
            this.panel3.TabIndex = 4;
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            this.dgv_resultado.AllowUserToDeleteRows = false;
            this.dgv_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado.Location = new System.Drawing.Point(0, 0);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            this.dgv_resultado.RowHeadersVisible = false;
            this.dgv_resultado.Size = new System.Drawing.Size(229, 208);
            this.dgv_resultado.TabIndex = 0;
            // 
            // btn_calcular_distancia_a_menos
            // 
            this.btn_calcular_distancia_a_menos.Enabled = false;
            this.btn_calcular_distancia_a_menos.Location = new System.Drawing.Point(487, 75);
            this.btn_calcular_distancia_a_menos.Name = "btn_calcular_distancia_a_menos";
            this.btn_calcular_distancia_a_menos.Size = new System.Drawing.Size(122, 23);
            this.btn_calcular_distancia_a_menos.TabIndex = 5;
            this.btn_calcular_distancia_a_menos.Text = "Calcular Distancia A-";
            this.btn_calcular_distancia_a_menos.UseVisualStyleBackColor = true;
            this.btn_calcular_distancia_a_menos.Click += new System.EventHandler(this.Btn_calcular_distancia_a_menos_Click);
            // 
            // btn_ordenar_resultado
            // 
            this.btn_ordenar_resultado.Enabled = false;
            this.btn_ordenar_resultado.Location = new System.Drawing.Point(658, 75);
            this.btn_ordenar_resultado.Name = "btn_ordenar_resultado";
            this.btn_ordenar_resultado.Size = new System.Drawing.Size(117, 23);
            this.btn_ordenar_resultado.TabIndex = 6;
            this.btn_ordenar_resultado.Text = "Ordenar Resultado";
            this.btn_ordenar_resultado.UseVisualStyleBackColor = true;
            this.btn_ordenar_resultado.Click += new System.EventHandler(this.Btn_ordenar_resultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método Topsis";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Enabled = false;
            this.btn_exportar.Location = new System.Drawing.Point(734, 362);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(138, 53);
            this.btn_exportar.TabIndex = 7;
            this.btn_exportar.Text = "Exportar Resultados";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // frm_topsis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 427);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ordenar_resultado);
            this.Controls.Add(this.btn_calcular_distancia_a_menos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_calcular_distancia_a_mas);
            this.Controls.Add(this.btn_identificar_solucion);
            this.Controls.Add(this.btn_normalizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_topsis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo Topsis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_topsis_FormClosing);
            this.Load += new System.EventHandler(this.Frm_topsis_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesos)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_matriz;
        private System.Windows.Forms.DataGridView dgv_pesos;
        private System.Windows.Forms.Button btn_normalizar;
        private System.Windows.Forms.Button btn_identificar_solucion;
        private System.Windows.Forms.Button btn_calcular_distancia_a_mas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.Button btn_calcular_distancia_a_menos;
        private System.Windows.Forms.Button btn_ordenar_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exportar;
    }
}