using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BielFilosofos.jantar
{
    class Filosofo
    {
        private string nome;
        private int index;
        private List<Filosofo> todosFilosofos;
        private int qtdaComeu = 0;
        private int maxQuePodeComer = 1000;
        public Mao garfoEsquerdo; 
        public Mao garfoDireito;
        private Stopwatch relogio;
        private int qtdaPensou = 0;
        private int qtdaFome = 0;
        public Relatorio relatorio;
        public Filosofo filosofoEsquerda {
            get { 
                if(this.index == 0)
                {
                    return this.todosFilosofos[this.todosFilosofos.Count - 1];
                }
                else
                {
                    return this.todosFilosofos[this.index - 1];
                }
            }
        }
        public Filosofo filosofoDireita
        {
            get
            {
                if (this.index == this.todosFilosofos.Count - 1)
                {
                    return this.todosFilosofos[0];
                }
                else
                {
                    return this.todosFilosofos[this.index + 1];
                }
            }
        }


        public Filosofo(int index, List<Filosofo> todosFilosofos, Relatorio relatorio)
        {
            this.nome = "Filosofo " + (index + 1);

            this.index = index;
            this.todosFilosofos = todosFilosofos;
            this.relatorio = relatorio;
            this.relatorio.adicionaRelatorio(this.nome + " Comer", 0);
            this.relatorio.adicionaRelatorio(this.nome + " Fome", 0);
            this.relatorio.adicionaRelatorio(this.nome + " Pessoa", 0);
            this.relatorio.adicionaRelatorio(this.nome + " Tempo", 0);
            this.relatorio.adicionaStatus(this.nome + " Status", " ");

        }


        private bool PegarGarfos()
        {
            if (!filosofoDireita.garfoEsquerdo.estaOcupado)
            {
                garfoDireito.estaOcupado = true;

                if (!filosofoEsquerda.garfoDireito.estaOcupado)
                {
                    garfoEsquerdo.estaOcupado = true;
                    return true;
                }
                else
                {
                    garfoDireito.estaOcupado = false;
                }
            }

            Console.WriteLine("O " + this.nome + " está pasando fome.");
            this.relatorio.incrementaRelatorio(this.nome + " Fome");
            this.relatorio.atualizaStatus(this.nome + " Status", "Com Fome");

            return false;

        }
        private void Comer()
        {
           // Thread.Sleep(500);
            this.AtualizaStatus("Esta Comendo");
            qtdaComeu++;
            this.relatorio.incrementaRelatorio(this.nome + " Comeu");
            this.relatorio.atualizaStatus(this.nome + " Status", "Esta Comendo");
            Console.WriteLine(this.nome + " Comeu");
            if(this.maxQuePodeComer == qtdaComeu)
            {
                Console.WriteLine("O Filosofo " + nome + "  demorou " + relogio.ElapsedMilliseconds);
            }


        }
      
        private void Pensar()
        {
            //Thread.Sleep(500);
            this.AtualizaStatus("Esta Pensando"); 
            this.relatorio.incrementaRelatorio(this.nome + " Pensou");
            this.relatorio.atualizaStatus(this.nome + " Status", "Esta Pensando");

            Console.WriteLine(this.nome +  " Pensou");
        }
        
        public void ComecarAJantar()
        {
            this.relogio = Stopwatch.StartNew();
            while(this.qtdaComeu < this.maxQuePodeComer)
            {
                Thread.Sleep(400);
                this.Pensar();
                Thread.Sleep(400);
                if (this.PegarGarfos()) {
                    Thread.Sleep(400);
                    this.Comer();
                    this.garfoDireito.estaOcupado = false;
                    this.garfoEsquerdo.estaOcupado = false;
                    
                }
                this.relatorio.atualizaRelatorio(this.nome + " Tempo", this.relogio.ElapsedMilliseconds);
                
            }
            this.relogio.Stop();
        }

        public void AtualizaStatus(string status)
        {
            
            
        }

    }
}
