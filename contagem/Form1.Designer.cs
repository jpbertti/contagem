namespace contagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular1 = new System.Windows.Forms.Button();
            this.btnCalcular10 = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbResultado2 = new System.Windows.Forms.ListBox();
            this.lsbResultado1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(62, 384);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(88, 41);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(406, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 41);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular1
            // 
            this.btnCalcular1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular1.Location = new System.Drawing.Point(124, 269);
            this.btnCalcular1.Name = "btnCalcular1";
            this.btnCalcular1.Size = new System.Drawing.Size(88, 41);
            this.btnCalcular1.TabIndex = 2;
            this.btnCalcular1.Text = "Calcular";
            this.btnCalcular1.UseVisualStyleBackColor = true;
            this.btnCalcular1.Click += new System.EventHandler(this.btnCalcular1_Click);
            // 
            // btnCalcular10
            // 
            this.btnCalcular10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular10.Location = new System.Drawing.Point(348, 269);
            this.btnCalcular10.Name = "btnCalcular10";
            this.btnCalcular10.Size = new System.Drawing.Size(88, 41);
            this.btnCalcular10.TabIndex = 3;
            this.btnCalcular10.Text = "Calcular";
            this.btnCalcular10.UseVisualStyleBackColor = true;
            this.btnCalcular10.Click += new System.EventHandler(this.btnCalcular10_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(76, 37);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(181, 20);
            this.lblTitulo1.TabIndex = 4;
            this.lblTitulo1.Text = "Contagem de 1 a 100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contagem de 10 a 1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "de 10 em 10";
            // 
            // lsbResultado2
            // 
            this.lsbResultado2.FormattingEnabled = true;
            this.lsbResultado2.Location = new System.Drawing.Point(311, 93);
            this.lsbResultado2.Name = "lsbResultado2";
            this.lsbResultado2.Size = new System.Drawing.Size(167, 160);
            this.lsbResultado2.TabIndex = 7;
            // 
            // lsbResultado1
            // 
            this.lsbResultado1.FormattingEnabled = true;
            this.lsbResultado1.Location = new System.Drawing.Point(90, 93);
            this.lsbResultado1.Name = "lsbResultado1";
            this.lsbResultado1.Size = new System.Drawing.Size(167, 160);
            this.lsbResultado1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.lsbResultado1);
            this.Controls.Add(this.lsbResultado2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.btnCalcular10);
            this.Controls.Add(this.btnCalcular1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular1;
        private System.Windows.Forms.Button btnCalcular10;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbResultado2;
        private System.Windows.Forms.ListBox lsbResultado1;
    }
}

