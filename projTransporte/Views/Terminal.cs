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
        TerminalController terminal;

        public Terminal()
        {
            InitializeComponent();

            terminal = new TerminalController();
        }

        private void btnCadastrarPassageiros_Click(object sender, EventArgs e)
        {
            FormPassageiro formPassageiro = new FormPassageiro();
            formPassageiro.terminal = terminal;
            formPassageiro.ShowDialog();
            txtPassageiros.Text = terminal.FilaEmbarque.Count.ToString();
            txtVeiculos.Text = terminal.FilaVeiculos.Count.ToString();
        }

        private void btnCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo();
            formVeiculo.terminal = terminal;
            formVeiculo.ShowDialog();
            txtVeiculos.Text = terminal.FilaVeiculos.Count.ToString();
        }

        private void btnListarPassageiros_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();

            terminal.FilaEmbarque.ToList().ForEach( p =>  lbxLista.Items.Add(p.ToString()));
        }

        private void btnListarVeiculos_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();

            terminal.FilaVeiculos.ToList().ForEach( v => lbxLista.Items.Add(v.ToString()));
        }

        private void btnListarViagens_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();

            terminal.Viagens.ListaViagem.ForEach(v => lbxLista.Items.Add(v.ToString()));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();
        }

        private void btnDetalhar_Click(object sender, EventArgs e)
        {
            lbxLista.Items.Clear();
            int id = Int32.Parse(txtViagem.Text);
            string viagem = terminal.Viagens.pesquisar(id).ToString();
            lbxLista.Items.Add(viagem);
            lbxLista.Items.Add("Passageiros: ");
            terminal.Viagens.pesquisar(id).Passageiros.ForEach(p => lbxLista.Items.Add(p.ToString()));
        }
    }
}
