namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresto = new System.Windows.Forms.Button();
            this.btnsustrae = new System.Windows.Forms.Button();
            this.btnpotencia = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnlimpia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(122, 26);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 0;
            this.txtnumero1.TextChanged += new System.EventHandler(this.txtnumero1_TextChanged);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(122, 68);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 1;
            this.txtnumero2.TextChanged += new System.EventHandler(this.txtnumero2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2";
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(247, 22);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnresto
            // 
            this.btnresto.Location = new System.Drawing.Point(247, 51);
            this.btnresto.Name = "btnresto";
            this.btnresto.Size = new System.Drawing.Size(75, 23);
            this.btnresto.TabIndex = 5;
            this.btnresto.Text = "%";
            this.btnresto.UseVisualStyleBackColor = true;
            this.btnresto.Click += new System.EventHandler(this.btnresto_Click);
            // 
            // btnsustrae
            // 
            this.btnsustrae.Location = new System.Drawing.Point(328, 22);
            this.btnsustrae.Name = "btnsustrae";
            this.btnsustrae.Size = new System.Drawing.Size(75, 23);
            this.btnsustrae.TabIndex = 6;
            this.btnsustrae.Text = "-";
            this.btnsustrae.UseVisualStyleBackColor = true;
            this.btnsustrae.Click += new System.EventHandler(this.btnsustrae_Click);
            // 
            // btnpotencia
            // 
            this.btnpotencia.Location = new System.Drawing.Point(328, 51);
            this.btnpotencia.Name = "btnpotencia";
            this.btnpotencia.Size = new System.Drawing.Size(75, 23);
            this.btnpotencia.TabIndex = 7;
            this.btnpotencia.Text = "^";
            this.btnpotencia.UseVisualStyleBackColor = true;
            this.btnpotencia.Click += new System.EventHandler(this.btnpotencia_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(247, 80);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 23);
            this.btndivide.TabIndex = 8;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(328, 80);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(75, 23);
            this.btnraiz.TabIndex = 9;
            this.btnraiz.Text = "Raiz";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // btnlimpia
            // 
            this.btnlimpia.Location = new System.Drawing.Point(247, 109);
            this.btnlimpia.Name = "btnlimpia";
            this.btnlimpia.Size = new System.Drawing.Size(75, 23);
            this.btnlimpia.TabIndex = 10;
            this.btnlimpia.Text = "C";
            this.btnlimpia.UseVisualStyleBackColor = true;
            this.btnlimpia.Click += new System.EventHandler(this.btnlimpia_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 141);
            this.Controls.Add(this.btnlimpia);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnpotencia);
            this.Controls.Add(this.btnsustrae);
            this.Controls.Add(this.btnresto);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresto;
        private System.Windows.Forms.Button btnsustrae;
        private System.Windows.Forms.Button btnpotencia;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnlimpia;
    }
}

