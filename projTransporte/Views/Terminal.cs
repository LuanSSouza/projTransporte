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

    public partial class Terminal : Form
    {
        Passageiros passageiros;
        Veiculos veiculos;
        Viagens viagens;

        public Terminal()
        {
            InitializeComponent();

            passageiros = new Passageiros();
            veiculos = new Veiculos();
            viagens = new Viagens();
        }

        private void btnCadastrarPassageiros_Click(object sender, EventArgs e)
        {
            FormPassageiro formPassageiro = new FormPassageiro();
            formPassageiro.ShowDialog();
        }

        private void btnCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo();
            formVeiculo.ShowDialog();
        }
    }
}
