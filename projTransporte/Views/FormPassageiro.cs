using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projTransporte.Controllers;

namespace projTransporte.Views
{
    partial class FormPassageiro : Form
    {
        public TerminalController terminal;

        public FormPassageiro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int inscricao = Int32.Parse(txtInscricao.Text);
            string nome = txtNome.Text;
            // Adicionando passageiros a fila de Embarque
            this.terminal.checkin(inscricao, nome);

            MessageBox.Show("Veículo cadastrado!", "Sucesso!");

            // Fechando janela e liberando recursos
            this.Dispose();
        }
    }
}
