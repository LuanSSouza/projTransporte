using System;
using System.Collections.Generic;
using projTransporte.Models;

namespace projTransporte.Controllers
{
    class Viagens
    {
        private List<Viagem> listaViagem;
        private int id;

        public List<Viagem> ListaViagem { get { return listaViagem; } }

        public Viagens() {
            this.listaViagem = new List<Viagem>();
            this.id = 0;
        }

        public void partir(Veiculo veiculo, DateTime dtHr, List<Passageiro> passageiros){
            listaViagem.Add(new Viagem(id, veiculo, dtHr, passageiros));
            id++;
        }

        public Viagem pesquisar(int id) {
            return listaViagem.Find(v => v.Id == id);
        }
    }
}
