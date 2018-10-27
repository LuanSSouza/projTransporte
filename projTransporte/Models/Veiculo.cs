using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte.Models
{
    class Veiculo
    {
        private string placa;
        private string motorista;
        private int lotacao;

        public string Placa { get { return this.placa; }  }
        public string Motorista { get { return this.motorista; } set { this.placa = value; } }
        public int Lotacao { get { return this.lotacao; } set { this.lotacao = value; } }

        public Veiculo(string placa, string motorista, int lotacao) {
            this.placa = placa;
            this.motorista = motorista;
            this.lotacao = lotacao;
        }

        public override bool Equals(object obj)
        {
            Veiculo veiculo = (Veiculo)obj;
            return this.placa.Equals(veiculo.placa);
        }

        public override string ToString()
        {
            return Placa + " - " + Motorista + " - " + Lotacao;
        }
    }
}
