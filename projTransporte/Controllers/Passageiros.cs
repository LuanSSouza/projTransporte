using System.Collections.Generic;
using projTransporte.Models;

namespace projTransporte.Controllers
{
    class Passageiros
    {
        private Queue<Passageiro> filaEmbarque;
        private int inscricao;

        public Queue<Passageiro> FilaEmbarque { get { return filaEmbarque; } }

        public Passageiros() {
            filaEmbarque = new Queue<Passageiro>();
            inscricao = 0;
        }

        public void adicionar(string nome) {
            filaEmbarque.Enqueue(new Passageiro(this.inscricao, nome));
            inscricao++;
        }

        public Passageiro embarcar() {
            return filaEmbarque.Dequeue();
        }
    }
}
