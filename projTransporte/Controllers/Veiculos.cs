using System.Collections.Generic;
using projTransporte.Models;

namespace projTransporte.Controllers
{
    class Veiculos
    {
        private List<Veiculo> listaVeiculos;

        public List<Veiculo> ListaVeiculos { get { return listaVeiculos; } }
        public Veiculos() {
            listaVeiculos = new List<Veiculo>();
        }

        public void cadastrar(string placa, string motorista, int lotacao) {
            listaVeiculos.Add(new Veiculo(placa, motorista, lotacao));
        }

        public Veiculo pesquisar(string placa) {
            return listaVeiculos.Find(v => v.Equals(new Veiculo(placa, "", 0)));
        }

        public bool remover(string placa) {
            Veiculo v = pesquisar(placa);
            return listaVeiculos.Remove(v);
        }
    }
}
