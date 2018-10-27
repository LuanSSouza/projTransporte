using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTransporte.Models
{
    class Passageiro
    {
        private int inscricao;
        private string nome;

        public int Inscricao { get { return this.inscricao; } }
        public string Nome { get { return this.nome; } set { this.nome = value; } }

        public Passageiro(int inscricao, string nome) {
            this.inscricao = inscricao;
            this.nome = nome;
        }

        public override bool Equals(object obj)
        {
            Passageiro passageiro = (Passageiro)obj; 
            return this.inscricao.Equals(passageiro.inscricao);
        }

        public override string ToString()
        {
            return Inscricao + " - " + Nome;
        }
    }
}
