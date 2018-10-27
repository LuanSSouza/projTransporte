namespace projTransporte.Views
{
    partial class Terminal
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
            this.pnlPassageiro = new System.Windows.Forms.Panel();
            this.btnListarPassageiros = new System.Windows.Forms.Button();
            this.btnCadastrarPassageiros = new System.Windows.Forms.Button();
            this.txtPassageiros = new System.Windows.Forms.TextBox();
            this.lblPassageiros = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListarVeiculos = new System.Windows.Forms.Button();
            this.btnCadastrarVeiculos = new System.Windows.Forms.Button();
            this.txtVeiculos = new System.Windows.Forms.TextBox();
            this.lblVeiculos = new System.Windows.Forms.Label();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListarViagens = new System.Windows.Forms.Button();
            this.btnDetalhar = new System.Windows.Forms.Button();
            this.lblViagens = new System.Windows.Forms.Label();
            this.txtViagem = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlPassageiro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPassageiro
            // 
            this.pnlPassageiro.Controls.Add(this.btnListarPassageiros);
            this.pnlPassageiro.Controls.Add(this.btnCadastrarPassageiros);
            this.pnlPassageiro.Controls.Add(this.txtPassageiros);
            this.pnlPassageiro.Controls.Add(this.lblPassageiros);
            this.pnlPassageiro.Location = new System.Drawing.Point(12, 12);
            this.pnlPassageiro.Name = "pnlPassageiro";
            this.pnlPassageiro.Size = new System.Drawing.Size(247, 90);
            this.pnlPassageiro.TabIndex = 0;
            // 
            // btnListarPassageiros
            // 
            this.btnListarPassageiros.Location = new System.Drawing.Point(146, 49);
            this.btnListarPassageiros.Name = "btnListarPassageiros";
            this.btnListarPassageiros.Size = new System.Drawing.Size(75, 23);
            this.btnListarPassageiros.TabIndex = 3;
            this.btnListarPassageiros.Text = "Listar";
            this.btnListarPassageiros.UseVisualStyleBackColor = true;
            this.btnListarPassageiros.Click += new System.EventHandler(this.btnListarPassageiros_Click);
            // 
            // btnCadastrarPassageiros
            // 
            this.btnCadastrarPassageiros.Location = new System.Drawing.Point(33, 49);
            this.btnCadastrarPassageiros.Name = "btnCadastrarPassageiros";
            this.btnCadastrarPassageiros.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarPassageiros.TabIndex = 2;
            this.btnCadastrarPassageiros.Text = "Cadastrar";
            this.btnCadastrarPassageiros.UseVisualStyleBackColor = true;
            this.btnCadastrarPassageiros.Click += new System.EventHandler(this.btnCadastrarPassageiros_Click);
            // 
            // txtPassageiros
            // 
            this.txtPassageiros.Enabled = false;
            this.txtPassageiros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassageiros.Location = new System.Drawing.Point(131, 7);
            this.txtPassageiros.Name = "txtPassageiros";
            this.txtPassageiros.Size = new System.Drawing.Size(101, 26);
            this.txtPassageiros.TabIndex = 1;
            // 
            // lblPassageiros
            // 
            this.lblPassageiros.AutoSize = true;
            this.lblPassageiros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassageiros.Location = new System.Drawing.Point(15, 10);
            this.lblPassageiros.Name = "lblPassageiros";
            this.lblPassageiros.Size = new System.Drawing.Size(110, 19);
            this.lblPassageiros.TabIndex = 0;
            this.lblPassageiros.Text = "Passageiros:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListarVeiculos);
            this.panel1.Controls.Add(this.btnCadastrarVeiculos);
            this.panel1.Controls.Add(this.txtVeiculos);
            this.panel1.Controls.Add(this.lblVeiculos);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 90);
            this.panel1.TabIndex = 4;
            // 
            // btnListarVeiculos
            // 
            this.btnListarVeiculos.Location = new System.Drawing.Point(146, 49);
            this.btnListarVeiculos.Name = "btnListarVeiculos";
            this.btnListarVeiculos.Size = new System.Drawing.Size(75, 23);
            this.btnListarVeiculos.TabIndex = 3;
            this.btnListarVeiculos.Text = "Listar";
            this.btnListarVeiculos.UseVisualStyleBackColor = true;
            this.btnListarVeiculos.Click += new System.EventHandler(this.btnListarVeiculos_Click);
            // 
            // btnCadastrarVeiculos
            // 
            this.btnCadastrarVeiculos.Location = new System.Drawing.Point(33, 49);
            this.btnCadastrarVeiculos.Name = "btnCadastrarVeiculos";
            this.btnCadastrarVeiculos.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarVeiculos.TabIndex = 2;
            this.btnCadastrarVeiculos.Text = "Cadastrar";
            this.btnCadastrarVeiculos.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculos.Click += new System.EventHandler(this.btnCadastrarVeiculos_Click);
            // 
            // txtVeiculos
            // 
            this.txtVeiculos.Enabled = false;
            this.txtVeiculos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeiculos.Location = new System.Drawing.Point(131, 7);
            this.txtVeiculos.Name = "txtVeiculos";
            this.txtVeiculos.Size = new System.Drawing.Size(101, 26);
            this.txtVeiculos.TabIndex = 1;
            // 
            // lblVeiculos
            // 
            this.lblVeiculos.AutoSize = true;
            this.lblVeiculos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeiculos.Location = new System.Drawing.Point(29, 10);
            this.lblVeiculos.Name = "lblVeiculos";
            this.lblVeiculos.Size = new System.Drawing.Size(80, 19);
            this.lblVeiculos.TabIndex = 0;
            this.lblVeiculos.Text = "Veículos:";
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(276, 12);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(224, 251);
            this.lbxLista.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListarViagens);
            this.panel2.Controls.Add(this.btnDetalhar);
            this.panel2.Controls.Add(this.txtViagem);
            this.panel2.Controls.Add(this.lblViagens);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 90);
            this.panel2.TabIndex = 6;
            // 
            // btnListarViagens
            // 
            this.btnListarViagens.Location = new System.Drawing.Point(146, 49);
            this.btnListarViagens.Name = "btnListarViagens";
            this.btnListarViagens.Size = new System.Drawing.Size(75, 23);
            this.btnListarViagens.TabIndex = 3;
            this.btnListarViagens.Text = "Listar";
            this.btnListarViagens.UseVisualStyleBackColor = true;
            this.btnListarViagens.Click += new System.EventHandler(this.btnListarViagens_Click);
            // 
            // btnDetalhar
            // 
            this.btnDetalhar.Location = new System.Drawing.Point(33, 49);
            this.btnDetalhar.Name = "btnDetalhar";
            this.btnDetalhar.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhar.TabIndex = 2;
            this.btnDetalhar.Text = "Detalhar";
            this.btnDetalhar.UseVisualStyleBackColor = true;
            // 
            // lblViagens
            // 
            this.lblViagens.AutoSize = true;
            this.lblViagens.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViagens.Location = new System.Drawing.Point(32, 10);
            this.lblViagens.Name = "lblViagens";
            this.lblViagens.Size = new System.Drawing.Size(77, 19);
            this.lblViagens.TabIndex = 0;
            this.lblViagens.Text = "Viagens:";
            // 
            // txtViagem
            // 
            this.txtViagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViagem.Location = new System.Drawing.Point(131, 7);
            this.txtViagem.Name = "txtViagem";
            this.txtViagem.Size = new System.Drawing.Size(101, 26);
            this.txtViagem.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(349, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 305);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlPassageiro);
            this.Name = "Terminal";
            this.Text = "Terminal";
            this.pnlPassageiro.ResumeLayout(false);
            this.pnlPassageiro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPassageiro;
        private System.Windows.Forms.Button btnListarPassageiros;
        private System.Windows.Forms.Button btnCadastrarPassageiros;
        private System.Windows.Forms.TextBox txtPassageiros;
        private System.Windows.Forms.Label lblPassageiros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarVeiculos;
        private System.Windows.Forms.Button btnCadastrarVeiculos;
        private System.Windows.Forms.TextBox txtVeiculos;
        private System.Windows.Forms.Label lblVeiculos;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnListarViagens;
        private System.Windows.Forms.Button btnDetalhar;
        private System.Windows.Forms.TextBox txtViagem;
        private System.Windows.Forms.Label lblViagens;
        private System.Windows.Forms.Button btnLimpar;
    }
}