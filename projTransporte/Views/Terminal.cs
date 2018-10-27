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
            formPassageiro.passageiros = this.passageiros;
            formPassageiro.ShowDialog();
            txtPassageiros.Text = passageiros.FilaEmbarque.Count.ToString();
        }

        private void btnCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo();
            formVeiculo.veiculos = this.veiculos;
            formVeiculo.ShowDialog();
            txtVeiculos.Text = veiculos.ListaVeiculos.Count.ToString();
        }

        private void btnListarPassageiros_Click(object sender, EventArgs e)
        {
        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();

            for(int i = 0; i < veiculos.ListaVeiculos.Count; i++)
            {
                lbxLista.Items.Add(veiculos.ListaVeiculos[i].ToString());
            }
        }

        private void btnListarViagens_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();

            for (int i = 0; i < viagens.ListaViagem.Count; i++)
            {
                lbxLista.Items.Add(viagens.ListaViagem [i].ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();
        }
    }
}
