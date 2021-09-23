namespace Decisiones_en_Escenarios_Complejos
{
    partial class AcercaDe
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_docentes = new System.Windows.Forms.Label();
            this.lbl_integrantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trabajo Práctico Integrador - Curso 5K3. - Grupo 1";
            // 
            // lbl_docentes
            // 
            this.lbl_docentes.AutoSize = true;
            this.lbl_docentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docentes.Location = new System.Drawing.Point(566, 73);
            this.lbl_docentes.Name = "lbl_docentes";
            this.lbl_docentes.Size = new System.Drawing.Size(66, 16);
            this.lbl_docentes.TabIndex = 5;
            this.lbl_docentes.Text = "Docentes";
            // 
            // lbl_integrantes
            // 
            this.lbl_integrantes.AutoSize = true;
            this.lbl_integrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_integrantes.Location = new System.Drawing.Point(12, 73);
            this.lbl_integrantes.Name = "lbl_integrantes";
            this.lbl_integrantes.Size = new System.Drawing.Size(74, 16);
            this.lbl_integrantes.TabIndex = 4;
            this.lbl_integrantes.Text = "Integrantes";
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 249);
            this.Controls.Add(this.lbl_docentes);
            this.Controls.Add(this.lbl_integrantes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDe";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_docentes;
        private System.Windows.Forms.Label lbl_integrantes;
    }
}