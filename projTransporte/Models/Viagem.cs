using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte.Models
{
    class Viagem
    {
        private int id;
        private Veiculo veiculoViagem;
        private DateTime dataHora;
        private List<Passageiro> passageiros;
        private double valor;

        public int Id { get { return this.id; } }
        public Veiculo VeiculoViagem { get { return this.veiculoViagem; } }
        public DateTime DataHora { get { return this.dataHora; } }
        public List<Passageiro> Passageiros { get { return this.passageiros; } }
        public double Valor { get { return this.valor; } }

        public Viagem(int id, Veiculo veiculo, DateTime dataHora, List<Passageiro> passageiros) {
            this.id = id;
            this.veiculoViagem = veiculo;
            this.dataHora = dataHora;
            this.passageiros = passageiros;
            this.valor = this.passageiros.Count * 5.0;
        }
        
        public override bool Equals(object obj)
        {
            Viagem viagem = (Viagem)obj;
            return this.id.Equals(viagem.id);
        }

        public override string ToString()
        {
            return Id +" - " + VeiculoViagem.Placa + " - " + DataHora + " - " + Passageiros.Count;
        }
    }
}
