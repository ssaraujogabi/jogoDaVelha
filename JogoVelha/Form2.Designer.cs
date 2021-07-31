namespace JogoVelha
{
    partial class Pontuação
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumeroPartFim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empateFim = new System.Windows.Forms.TextBox();
            this.jogador2fim = new System.Windows.Forms.TextBox();
            this.jogador1fim = new System.Windows.Forms.TextBox();
            this.empateplacar = new System.Windows.Forms.Label();
            this.jogador2placar = new System.Windows.Forms.Label();
            this.Jogador1placar = new System.Windows.Forms.Label();
            this.vitoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NumeroPartFim);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.empateFim);
            this.groupBox2.Controls.Add(this.jogador2fim);
            this.groupBox2.Controls.Add(this.jogador1fim);
            this.groupBox2.Controls.Add(this.empateplacar);
            this.groupBox2.Controls.Add(this.jogador2placar);
            this.groupBox2.Controls.Add(this.Jogador1placar);
            this.groupBox2.Controls.Add(this.vitoria);
            this.groupBox2.Location = new System.Drawing.Point(16, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 307);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // NumeroPartFim
            // 
            this.NumeroPartFim.Location = new System.Drawing.Point(267, 233);
            this.NumeroPartFim.Name = "NumeroPartFim";
            this.NumeroPartFim.Size = new System.Drawing.Size(100, 20);
            this.NumeroPartFim.TabIndex = 9;
            this.NumeroPartFim.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "N° partidas";
            // 
            // empateFim
            // 
            this.empateFim.Location = new System.Drawing.Point(71, 234);
            this.empateFim.Name = "empateFim";
            this.empateFim.Size = new System.Drawing.Size(100, 20);
            this.empateFim.TabIndex = 7;
            this.empateFim.Text = "000";
            // 
            // jogador2fim
            // 
            this.jogador2fim.Location = new System.Drawing.Point(266, 195);
            this.jogador2fim.Name = "jogador2fim";
            this.jogador2fim.Size = new System.Drawing.Size(100, 20);
            this.jogador2fim.TabIndex = 6;
            this.jogador2fim.Text = "000";
            // 
            // jogador1fim
            // 
            this.jogador1fim.Location = new System.Drawing.Point(71, 199);
            this.jogador1fim.Name = "jogador1fim";
            this.jogador1fim.Size = new System.Drawing.Size(100, 20);
            this.jogador1fim.TabIndex = 5;
            this.jogador1fim.Text = "0000";
            this.jogador1fim.TextChanged += new System.EventHandler(this.jogador1placarim_TextChanged);
            // 
            // empateplacar
            // 
            this.empateplacar.AutoSize = true;
            this.empateplacar.Location = new System.Drawing.Point(15, 237);
            this.empateplacar.Name = "empateplacar";
            this.empateplacar.Size = new System.Drawing.Size(43, 13);
            this.empateplacar.TabIndex = 4;
            this.empateplacar.Text = "Empate";
            // 
            // jogador2placar
            // 
            this.jogador2placar.AutoSize = true;
            this.jogador2placar.Location = new System.Drawing.Point(209, 198);
            this.jogador2placar.Name = "jogador2placar";
            this.jogador2placar.Size = new System.Drawing.Size(51, 13);
            this.jogador2placar.TabIndex = 3;
            this.jogador2placar.Text = "Jogador2";
            // 
            // Jogador1placar
            // 
            this.Jogador1placar.AutoSize = true;
            this.Jogador1placar.Location = new System.Drawing.Point(15, 202);
            this.Jogador1placar.Name = "Jogador1placar";
            this.Jogador1placar.Size = new System.Drawing.Size(51, 13);
            this.Jogador1placar.TabIndex = 2;
            this.Jogador1placar.Text = "Jogador1";
            // 
            // vitoria
            // 
            this.vitoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitoria.ForeColor = System.Drawing.Color.Red;
            this.vitoria.Location = new System.Drawing.Point(90, 45);
            this.vitoria.Name = "vitoria";
            this.vitoria.Size = new System.Drawing.Size(185, 104);
            this.vitoria.TabIndex = 0;
            this.vitoria.Text = "1";
            this.vitoria.UseVisualStyleBackColor = true;
            this.vitoria.Click += new System.EventHandler(this.vitoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pontuação";
            // 
            // tempo
            // 
            this.tempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vencedor da Partida";
            // 
            // Pontuação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Pontuação";
            this.Text = "Pontuação";
            this.Load += new System.EventHandler(this.Pontuação_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox empateFim;
        private System.Windows.Forms.TextBox jogador2fim;
        private System.Windows.Forms.TextBox jogador1fim;
        private System.Windows.Forms.Label empateplacar;
        private System.Windows.Forms.Label jogador2placar;
        private System.Windows.Forms.Label Jogador1placar;
        private System.Windows.Forms.Button vitoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroPartFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label label3;
    }
}