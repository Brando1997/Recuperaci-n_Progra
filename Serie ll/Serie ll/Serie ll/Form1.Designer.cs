namespace Serie_ll
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
            this.label3 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbsuma = new System.Windows.Forms.RadioButton();
            this.rdbmultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbresta = new System.Windows.Forms.RadioButton();
            this.rdbdividir = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numero 1";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(245, 370);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(144, 70);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(452, 370);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(160, 70);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(328, 64);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(227, 22);
            this.txtnumero1.TabIndex = 3;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(328, 117);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(227, 22);
            this.txtnumero2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero 2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdividir);
            this.groupBox2.Controls.Add(this.rdbresta);
            this.groupBox2.Controls.Add(this.rdbmultiplicar);
            this.groupBox2.Controls.Add(this.rdbsuma);
            this.groupBox2.Location = new System.Drawing.Point(199, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // rdbsuma
            // 
            this.rdbsuma.AutoSize = true;
            this.rdbsuma.Location = new System.Drawing.Point(28, 34);
            this.rdbsuma.Name = "rdbsuma";
            this.rdbsuma.Size = new System.Drawing.Size(67, 20);
            this.rdbsuma.TabIndex = 0;
            this.rdbsuma.TabStop = true;
            this.rdbsuma.Text = "SUMA";
            this.rdbsuma.UseVisualStyleBackColor = true;
            // 
            // rdbmultiplicar
            // 
            this.rdbmultiplicar.AutoSize = true;
            this.rdbmultiplicar.Location = new System.Drawing.Point(25, 76);
            this.rdbmultiplicar.Name = "rdbmultiplicar";
            this.rdbmultiplicar.Size = new System.Drawing.Size(115, 20);
            this.rdbmultiplicar.TabIndex = 1;
            this.rdbmultiplicar.TabStop = true;
            this.rdbmultiplicar.Text = "MULTIPLICAR";
            this.rdbmultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbresta
            // 
            this.rdbresta.AutoSize = true;
            this.rdbresta.Location = new System.Drawing.Point(190, 34);
            this.rdbresta.Name = "rdbresta";
            this.rdbresta.Size = new System.Drawing.Size(74, 20);
            this.rdbresta.TabIndex = 2;
            this.rdbresta.TabStop = true;
            this.rdbresta.Text = "RESTA";
            this.rdbresta.UseVisualStyleBackColor = true;
            // 
            // rdbdividir
            // 
            this.rdbdividir.AutoSize = true;
            this.rdbdividir.Location = new System.Drawing.Point(190, 76);
            this.rdbdividir.Name = "rdbdividir";
            this.rdbdividir.Size = new System.Drawing.Size(76, 20);
            this.rdbdividir.TabIndex = 3;
            this.rdbdividir.TabStop = true;
            this.rdbdividir.Text = "DIVIDIR";
            this.rdbdividir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resultado:";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(347, 473);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(227, 22);
            this.txtresultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(938, 589);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbsuma;
        private System.Windows.Forms.RadioButton rdbdividir;
        private System.Windows.Forms.RadioButton rdbresta;
        private System.Windows.Forms.RadioButton rdbmultiplicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

