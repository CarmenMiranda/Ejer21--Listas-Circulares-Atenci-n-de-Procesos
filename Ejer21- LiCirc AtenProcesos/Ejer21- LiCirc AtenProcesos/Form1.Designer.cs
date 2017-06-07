namespace Ejer21__LiCirc_AtenProcesos
{
    partial class Form1
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtSumaCiclos = new System.Windows.Forms.TextBox();
            this.lblSumadeCiclosPendientes = new System.Windows.Forms.Label();
            this.txtProcesosPendientes = new System.Windows.Forms.TextBox();
            this.lblProcesosPendientes = new System.Windows.Forms.Label();
            this.txtCiclosColaVacía = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxProcesosFormados = new System.Windows.Forms.TextBox();
            this.lblMaxProcesosFormados = new System.Windows.Forms.Label();
            this.txtProcesosAtendidos = new System.Windows.Forms.TextBox();
            this.lblProcesosAtendidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(252, 232);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(142, 43);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtSumaCiclos
            // 
            this.txtSumaCiclos.Location = new System.Drawing.Point(282, 103);
            this.txtSumaCiclos.Name = "txtSumaCiclos";
            this.txtSumaCiclos.ReadOnly = true;
            this.txtSumaCiclos.Size = new System.Drawing.Size(112, 26);
            this.txtSumaCiclos.TabIndex = 12;
            // 
            // lblSumadeCiclosPendientes
            // 
            this.lblSumadeCiclosPendientes.Location = new System.Drawing.Point(21, 106);
            this.lblSumadeCiclosPendientes.Name = "lblSumadeCiclosPendientes";
            this.lblSumadeCiclosPendientes.Size = new System.Drawing.Size(255, 20);
            this.lblSumadeCiclosPendientes.TabIndex = 11;
            this.lblSumadeCiclosPendientes.Text = "Suma de ciclos pendientes: ";
            this.lblSumadeCiclosPendientes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProcesosPendientes
            // 
            this.txtProcesosPendientes.Location = new System.Drawing.Point(282, 62);
            this.txtProcesosPendientes.Name = "txtProcesosPendientes";
            this.txtProcesosPendientes.ReadOnly = true;
            this.txtProcesosPendientes.Size = new System.Drawing.Size(112, 26);
            this.txtProcesosPendientes.TabIndex = 10;
            // 
            // lblProcesosPendientes
            // 
            this.lblProcesosPendientes.Location = new System.Drawing.Point(21, 65);
            this.lblProcesosPendientes.Name = "lblProcesosPendientes";
            this.lblProcesosPendientes.Size = new System.Drawing.Size(255, 20);
            this.lblProcesosPendientes.TabIndex = 9;
            this.lblProcesosPendientes.Text = "Número de procesos pendientes: ";
            this.lblProcesosPendientes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCiclosColaVacía
            // 
            this.txtCiclosColaVacía.Location = new System.Drawing.Point(282, 23);
            this.txtCiclosColaVacía.Name = "txtCiclosColaVacía";
            this.txtCiclosColaVacía.ReadOnly = true;
            this.txtCiclosColaVacía.Size = new System.Drawing.Size(112, 26);
            this.txtCiclosColaVacía.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número de ciclos con cola vacía:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaxProcesosFormados
            // 
            this.txtMaxProcesosFormados.Location = new System.Drawing.Point(282, 141);
            this.txtMaxProcesosFormados.Name = "txtMaxProcesosFormados";
            this.txtMaxProcesosFormados.ReadOnly = true;
            this.txtMaxProcesosFormados.Size = new System.Drawing.Size(112, 26);
            this.txtMaxProcesosFormados.TabIndex = 15;
            // 
            // lblMaxProcesosFormados
            // 
            this.lblMaxProcesosFormados.Location = new System.Drawing.Point(21, 144);
            this.lblMaxProcesosFormados.Name = "lblMaxProcesosFormados";
            this.lblMaxProcesosFormados.Size = new System.Drawing.Size(255, 20);
            this.lblMaxProcesosFormados.TabIndex = 14;
            this.lblMaxProcesosFormados.Text = "Máximo de procesos formados:";
            this.lblMaxProcesosFormados.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtProcesosAtendidos
            // 
            this.txtProcesosAtendidos.Location = new System.Drawing.Point(282, 189);
            this.txtProcesosAtendidos.Name = "txtProcesosAtendidos";
            this.txtProcesosAtendidos.ReadOnly = true;
            this.txtProcesosAtendidos.Size = new System.Drawing.Size(112, 26);
            this.txtProcesosAtendidos.TabIndex = 17;
            // 
            // lblProcesosAtendidos
            // 
            this.lblProcesosAtendidos.Location = new System.Drawing.Point(21, 174);
            this.lblProcesosAtendidos.Name = "lblProcesosAtendidos";
            this.lblProcesosAtendidos.Size = new System.Drawing.Size(255, 41);
            this.lblProcesosAtendidos.TabIndex = 16;
            this.lblProcesosAtendidos.Text = "Número de procesos atendidos  en su totalidad:";
            this.lblProcesosAtendidos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 290);
            this.Controls.Add(this.txtProcesosAtendidos);
            this.Controls.Add(this.lblProcesosAtendidos);
            this.Controls.Add(this.txtMaxProcesosFormados);
            this.Controls.Add(this.lblMaxProcesosFormados);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtSumaCiclos);
            this.Controls.Add(this.lblSumadeCiclosPendientes);
            this.Controls.Add(this.txtProcesosPendientes);
            this.Controls.Add(this.lblProcesosPendientes);
            this.Controls.Add(this.txtCiclosColaVacía);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtSumaCiclos;
        private System.Windows.Forms.Label lblSumadeCiclosPendientes;
        private System.Windows.Forms.TextBox txtProcesosPendientes;
        private System.Windows.Forms.Label lblProcesosPendientes;
        private System.Windows.Forms.TextBox txtCiclosColaVacía;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxProcesosFormados;
        private System.Windows.Forms.Label lblMaxProcesosFormados;
        private System.Windows.Forms.TextBox txtProcesosAtendidos;
        private System.Windows.Forms.Label lblProcesosAtendidos;
    }
}

