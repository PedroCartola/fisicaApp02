namespace fisicaApp02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudVelocidade = new NumericUpDown();
            nudDistancia = new NumericUpDown();
            nudTempo = new NumericUpDown();
            btTorricelli = new Button();
            btMovimentoUniforme = new Button();
            btAceleracao = new Button();
            btVelocidadeMedia = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtResultado = new Label();
            label6 = new Label();
            nudAceleracao = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudVelocidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTempo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAceleracao).BeginInit();
            SuspendLayout();
            // 
            // nudVelocidade
            // 
            nudVelocidade.DecimalPlaces = 2;
            nudVelocidade.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudVelocidade.Location = new Point(361, 34);
            nudVelocidade.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudVelocidade.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudVelocidade.Name = "nudVelocidade";
            nudVelocidade.Size = new Size(120, 23);
            nudVelocidade.TabIndex = 0;
            // 
            // nudDistancia
            // 
            nudDistancia.DecimalPlaces = 2;
            nudDistancia.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudDistancia.Location = new Point(361, 74);
            nudDistancia.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudDistancia.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudDistancia.Name = "nudDistancia";
            nudDistancia.Size = new Size(120, 23);
            nudDistancia.TabIndex = 1;
            // 
            // nudTempo
            // 
            nudTempo.DecimalPlaces = 2;
            nudTempo.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudTempo.Location = new Point(361, 119);
            nudTempo.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudTempo.Name = "nudTempo";
            nudTempo.Size = new Size(120, 23);
            nudTempo.TabIndex = 2;
            // 
            // btTorricelli
            // 
            btTorricelli.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btTorricelli.Location = new Point(633, 307);
            btTorricelli.Name = "btTorricelli";
            btTorricelli.Size = new Size(147, 37);
            btTorricelli.TabIndex = 3;
            btTorricelli.Text = "Torricelli";
            btTorricelli.UseVisualStyleBackColor = true;
            btTorricelli.Click += btTorricelli_Click;
            // 
            // btMovimentoUniforme
            // 
            btMovimentoUniforme.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btMovimentoUniforme.Location = new Point(403, 307);
            btMovimentoUniforme.Name = "btMovimentoUniforme";
            btMovimentoUniforme.Size = new Size(209, 37);
            btMovimentoUniforme.TabIndex = 4;
            btMovimentoUniforme.Text = "Movimento uniforme";
            btMovimentoUniforme.UseVisualStyleBackColor = true;
            btMovimentoUniforme.Click += btMovimentoUniforme_Click;
            // 
            // btAceleracao
            // 
            btAceleracao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btAceleracao.Location = new Point(230, 307);
            btAceleracao.Name = "btAceleracao";
            btAceleracao.Size = new Size(147, 37);
            btAceleracao.TabIndex = 5;
            btAceleracao.Text = "Aceleração";
            btAceleracao.UseVisualStyleBackColor = true;
            btAceleracao.Click += btAceleracao_Click;
            // 
            // btVelocidadeMedia
            // 
            btVelocidadeMedia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btVelocidadeMedia.Location = new Point(12, 307);
            btVelocidadeMedia.Name = "btVelocidadeMedia";
            btVelocidadeMedia.Size = new Size(194, 37);
            btVelocidadeMedia.TabIndex = 6;
            btVelocidadeMedia.Text = "Velocidade média";
            btVelocidadeMedia.UseVisualStyleBackColor = true;
            btVelocidadeMedia.Click += btVelocidadeMedia_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(238, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 7;
            label1.Text = "Velocidade (i) :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(238, 74);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 8;
            label2.Text = "Distancia (m)  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(238, 119);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 9;
            label3.Text = "Tempo (s) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 392);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 10;
            label4.Text = "Resultado :";
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(159, 396);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(0, 25);
            txtResultado.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(238, 163);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 13;
            label6.Text = "Aceleração :";
            // 
            // nudAceleracao
            // 
            nudAceleracao.DecimalPlaces = 2;
            nudAceleracao.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudAceleracao.Location = new Point(361, 163);
            nudAceleracao.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudAceleracao.Minimum = new decimal(new int[] { 200, 0, 0, int.MinValue });
            nudAceleracao.Name = "nudAceleracao";
            nudAceleracao.Size = new Size(120, 23);
            nudAceleracao.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudAceleracao);
            Controls.Add(label6);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btVelocidadeMedia);
            Controls.Add(btAceleracao);
            Controls.Add(btMovimentoUniforme);
            Controls.Add(btTorricelli);
            Controls.Add(nudTempo);
            Controls.Add(nudDistancia);
            Controls.Add(nudVelocidade);
            Name = "Form1";
            Text = "Fisica App 2.0";
            ((System.ComponentModel.ISupportInitialize)nudVelocidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTempo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAceleracao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudVelocidade;
        private NumericUpDown nudDistancia;
        private NumericUpDown nudTempo;
        private Button btTorricelli;
        private Button btMovimentoUniforme;
        private Button btAceleracao;
        private Button btVelocidadeMedia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label txtResultado;
        private Label label6;
        private NumericUpDown nudAceleracao;
    }
}
