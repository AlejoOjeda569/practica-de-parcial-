namespace ejerciciodewindomForms
{
    partial class escritorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtGeneratriz = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.bntSalir = new System.Windows.Forms.Button();
            this.btnVolumen = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Radio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el Generatriz";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(177, 34);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(106, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // txtGeneratriz
            // 
            this.txtGeneratriz.Location = new System.Drawing.Point(177, 168);
            this.txtGeneratriz.Name = "txtGeneratriz";
            this.txtGeneratriz.Size = new System.Drawing.Size(106, 20);
            this.txtGeneratriz.TabIndex = 4;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(177, 102);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(106, 20);
            this.txtAltura.TabIndex = 5;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(498, 37);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(101, 43);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // bntSalir
            // 
            this.bntSalir.Location = new System.Drawing.Point(574, 405);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(128, 33);
            this.bntSalir.TabIndex = 12;
            this.bntSalir.Text = "salir";
            this.bntSalir.UseVisualStyleBackColor = true;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Location = new System.Drawing.Point(124, 244);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(127, 76);
            this.btnVolumen.TabIndex = 13;
            this.btnVolumen.Text = "Volumen";
            this.btnVolumen.UseVisualStyleBackColor = true;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(310, 244);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(127, 76);
            this.btnArea.TabIndex = 14;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtGeneratriz);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "escritorio";
            this.Text = "escritorio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.escritorio_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtGeneratriz;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.Button btnVolumen;
        private System.Windows.Forms.Button btnArea;
    }
}

