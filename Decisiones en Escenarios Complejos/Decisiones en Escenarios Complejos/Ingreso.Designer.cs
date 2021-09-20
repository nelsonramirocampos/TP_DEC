namespace Decisiones_en_Escenarios_Complejos
{
    partial class Ingreso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_agregar_alternativa = new System.Windows.Forms.Button();
            this.txt_nombre_alternativa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tipo_criterio = new System.Windows.Forms.ComboBox();
            this.btn_agregar_criterio = new System.Windows.Forms.Button();
            this.txt_nombre_criterio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_matriz = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_pesos = new System.Windows.Forms.DataGridView();
            this.btn_continuar_metodo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_metodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_agregar_alternativa);
            this.groupBox1.Controls.Add(this.txt_nombre_alternativa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alternativa";
            // 
            // btn_agregar_alternativa
            // 
            this.btn_agregar_alternativa.Location = new System.Drawing.Point(201, 16);
            this.btn_agregar_alternativa.Name = "btn_agregar_alternativa";
            this.btn_agregar_alternativa.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_alternativa.TabIndex = 4;
            this.btn_agregar_alternativa.Text = "Agregar";
            this.btn_agregar_alternativa.UseVisualStyleBackColor = true;
            this.btn_agregar_alternativa.Click += new System.EventHandler(this.Btn_agregar_alternativa_Click);
            // 
            // txt_nombre_alternativa
            // 
            this.txt_nombre_alternativa.Location = new System.Drawing.Point(76, 18);
            this.txt_nombre_alternativa.Name = "txt_nombre_alternativa";
            this.txt_nombre_alternativa.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_alternativa.TabIndex = 3;
            this.txt_nombre_alternativa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_alternativa_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_tipo_criterio);
            this.groupBox2.Controls.Add(this.btn_agregar_criterio);
            this.groupBox2.Controls.Add(this.txt_nombre_criterio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(340, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criterio";
            // 
            // cb_tipo_criterio
            // 
            this.cb_tipo_criterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo_criterio.FormattingEnabled = true;
            this.cb_tipo_criterio.Location = new System.Drawing.Point(57, 62);
            this.cb_tipo_criterio.Name = "cb_tipo_criterio";
            this.cb_tipo_criterio.Size = new System.Drawing.Size(116, 21);
            this.cb_tipo_criterio.TabIndex = 6;
            // 
            // btn_agregar_criterio
            // 
            this.btn_agregar_criterio.Location = new System.Drawing.Point(198, 60);
            this.btn_agregar_criterio.Name = "btn_agregar_criterio";
            this.btn_agregar_criterio.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_criterio.TabIndex = 4;
            this.btn_agregar_criterio.Text = "Agregar";
            this.btn_agregar_criterio.UseVisualStyleBackColor = true;
            this.btn_agregar_criterio.Click += new System.EventHandler(this.Btn_agregar_criterio_Click);
            // 
            // txt_nombre_criterio
            // 
            this.txt_nombre_criterio.Location = new System.Drawing.Point(73, 26);
            this.txt_nombre_criterio.Name = "txt_nombre_criterio";
            this.txt_nombre_criterio.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_criterio.TabIndex = 3;
            this.txt_nombre_criterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_criterio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_matriz);
            this.panel1.Location = new System.Drawing.Point(12, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 206);
            this.panel1.TabIndex = 6;
            // 
            // dgv_matriz
            // 
            this.dgv_matriz.AllowUserToAddRows = false;
            this.dgv_matriz.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_matriz.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_matriz.Location = new System.Drawing.Point(0, 0);
            this.dgv_matriz.Name = "dgv_matriz";
            this.dgv_matriz.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_matriz.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_matriz.Size = new System.Drawing.Size(618, 206);
            this.dgv_matriz.TabIndex = 0;
            this.dgv_matriz.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_matriz_EditingControlShowing);
            this.dgv_matriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_matriz_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_pesos);
            this.panel2.Location = new System.Drawing.Point(12, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 66);
            this.panel2.TabIndex = 7;
            // 
            // dgv_pesos
            // 
            this.dgv_pesos.AllowUserToAddRows = false;
            this.dgv_pesos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_pesos.Location = new System.Drawing.Point(0, 0);
            this.dgv_pesos.Name = "dgv_pesos";
            this.dgv_pesos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_pesos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pesos.Size = new System.Drawing.Size(618, 66);
            this.dgv_pesos.TabIndex = 0;
            this.dgv_pesos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_pesos_EditingControlShowing);
            this.dgv_pesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dgv_pesos_KeyPress);
            // 
            // btn_continuar_metodo
            // 
            this.btn_continuar_metodo.Location = new System.Drawing.Point(529, 422);
            this.btn_continuar_metodo.Name = "btn_continuar_metodo";
            this.btn_continuar_metodo.Size = new System.Drawing.Size(102, 44);
            this.btn_continuar_metodo.TabIndex = 8;
            this.btn_continuar_metodo.Text = "Continuar";
            this.btn_continuar_metodo.UseVisualStyleBackColor = true;
            this.btn_continuar_metodo.Click += new System.EventHandler(this.Btn_continuar_metodo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarEjemploToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cargarEjemploToolStripMenuItem
            // 
            this.cargarEjemploToolStripMenuItem.Name = "cargarEjemploToolStripMenuItem";
            this.cargarEjemploToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.cargarEjemploToolStripMenuItem.Text = "Cargar Ejemplo";
            this.cargarEjemploToolStripMenuItem.Click += new System.EventHandler(this.CargarEjemploToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.ImportarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.ConfiguraciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_metodo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 51);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione Método";
            // 
            // cb_metodo
            // 
            this.cb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_metodo.FormattingEnabled = true;
            this.cb_metodo.Location = new System.Drawing.Point(76, 19);
            this.cb_metodo.Name = "cb_metodo";
            this.cb_metodo.Size = new System.Drawing.Size(200, 21);
            this.cb_metodo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Metodo:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(12, 433);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 10;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 473);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_continuar_metodo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ingreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Ingreso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matriz)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_agregar_alternativa;
        private System.Windows.Forms.TextBox txt_nombre_alternativa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_tipo_criterio;
        private System.Windows.Forms.Button btn_agregar_criterio;
        private System.Windows.Forms.TextBox txt_nombre_criterio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_matriz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_pesos;
        private System.Windows.Forms.Button btn_continuar_metodo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_metodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.ToolStripMenuItem cargarEjemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
    }
}