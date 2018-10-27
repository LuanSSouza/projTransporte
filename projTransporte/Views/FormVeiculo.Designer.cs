namespace projTransporte.Views
{
    partial class FormVeiculo
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblMotorista = new System.Windows.Forms.Label();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.txtLotacao = new System.Windows.Forms.TextBox();
            this.lblLotacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(12, 24);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(46, 20);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(89, 24);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(132, 22);
            this.txtPlaca.TabIndex = 1;
            // 
            // lblMotorista
            // 
            this.lblMotorista.AutoSize = true;
            this.lblMotorista.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotorista.Location = new System.Drawing.Point(12, 60);
            this.lblMotorista.Name = "lblMotorista";
            this.lblMotorista.Size = new System.Drawing.Size(67, 20);
            this.lblMotorista.TabIndex = 2;
            this.lblMotorista.Text = "Motorista:";
            // 
            // txtMotorista
            // 
            this.txtMotorista.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotorista.Location = new System.Drawing.Point(89, 60);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(132, 22);
            this.txtMotorista.TabIndex = 3;
            // 
            // txtLotacao
            // 
            this.txtLotacao.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotacao.Location = new System.Drawing.Point(89, 97);
            this.txtLotacao.Name = "txtLotacao";
            this.txtLotacao.Size = new System.Drawing.Size(132, 22);
            this.txtLotacao.TabIndex = 5;
            // 
            // lblLotacao
            // 
            this.lblLotacao.AutoSize = true;
            this.lblLotacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotacao.Location = new System.Drawing.Point(12, 97);
            this.lblLotacao.Name = "lblLotacao";
            this.lblLotacao.Size = new System.Drawing.Size(60, 20);
            this.lblLotacao.TabIndex = 4;
            this.lblLotacao.Text = "Lotação:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(89, 133);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 168);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtLotacao);
            this.Controls.Add(this.lblLotacao);
            this.Controls.Add(this.txtMotorista);
            this.Controls.Add(this.lblMotorista);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblMotorista;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.TextBox txtLotacao;
        private System.Windows.Forms.Label lblLotacao;
        private System.Windows.Forms.Button btnSalvar;
    }
}