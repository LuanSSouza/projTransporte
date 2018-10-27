using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projTransporte.Models;

namespace projTransporte.Controllers
{
    class TerminalController
    {
        private Queue<Veiculo> filaVeiculos;
        private Queue<Passageiro> filaEmbarque;
        private Viagens viagens;
        private DateTime ultimaPartida;

        public Queue<Veiculo> FilaVeiculos { get { return filaVeiculos; } }
        public Queue<Passageiro> FilaEmbarque { get { return filaEmbarque; } }
        public Viagens Viagens { get { return viagens; } }

        public TerminalController() {
            filaVeiculos = new Queue<Veiculo>();
            filaEmbarque = new Queue<Passageiro>();
            viagens = new Viagens();
        }

        public void checkin(int inscricao, string nome) {
            filaEmbarque.Enqueue(new Passageiro(inscricao, nome));
            if (filaEmbarque.Count == filaVeiculos.ToList()[0].Lotacao) partir();
            //else if (DateTime.Now == ultimaPartida.)
        }

        public void cadastrarVeiculo(string placa, string motorista, int lotacao)
        {
            filaVeiculos.Enqueue(new Veiculo(placa, motorista, lotacao));
        }

        private void partir() {
            List<Passageiro> listaPassageiros = new List<Passageiro>();
            while (filaEmbarque.Count > 0) {
                listaPassageiros.Add(filaEmbarque.Dequeue());
            }
            ultimaPartida = DateTime.Now;
            Viagens.partir(filaVeiculos.Dequeue(), DateTime.Now, listaPassageiros);
        }

    }
}
