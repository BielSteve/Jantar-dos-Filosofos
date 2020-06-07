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
        private int maxQuePodeComer = 100;
        public Mao garfoEsquerdo; 
        public Mao garfoDireito;
        private Stopwatch relogio;
        public Form1 janela;
        private int qtdaPensou = 0;
        private int qtdaFome = 0;
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


        public Filosofo(int index, List<Filosofo> todosFilosofos, Form1 janela)
        {
            this.nome = "Filosofo " + index;
            this.index = index;
            this.todosFilosofos = todosFilosofos;
            this.janela = janela;
            
        }
       
        private bool PegarGarfos()
        {
            garfoDireito.estaOcupado = true;
            garfoEsquerdo.estaOcupado = true;
            if (filosofoDireita.garfoEsquerdo.estaOcupado)
            {
                garfoDireito.estaOcupado = false;
            }
            if (filosofoEsquerda.garfoDireito.estaOcupado)
            {
                garfoEsquerdo.estaOcupado = false;
            }
            if(garfoEsquerdo.estaOcupado && garfoDireito.estaOcupado)
            {
                return true;
            }
            this.AtualizaStatus("Esta com Fome");
            qtdaFome++;
            if (this.index == 0)
            {
                janela.filo1_fome.Text = qtdaFome + "";
            }
            if (this.index == 1)
            {
                janela.filo2_Fome.Text = qtdaFome + "";
            }
            if (this.index == 2)
            {
                janela.filo3_Fome.Text = qtdaFome + "";
            }
            if (this.index == 3)
            {
                janela.filo4_Fome.Text = qtdaFome + "";
            }
            if (this.index == 4)
            {
                janela.filo5_Fome.Text = qtdaFome + "";
            }

            Console.WriteLine(this.nome + " Passou fome");
            return false;

        }
        private void Comer()
        {
           // Thread.Sleep(500);
            this.AtualizaStatus("Esta Comendo");
            qtdaComeu++;
            if(this.index == 0)
            {
                janela.filo1_Comeu.Text = qtdaComeu + "";
            }
            if (this.index == 1)
            {
                janela.filo2_Comeu.Text = qtdaComeu + "";
            }
            if (this.index == 2)
            {
                janela.filo3_Comeu.Text = qtdaComeu + "";
            }
            if (this.index == 3)
            {
                janela.filo4_Comeu.Text = qtdaComeu + "";
            }
            if (this.index == 4)
            {
                janela.filo5_Comeu.Text = qtdaComeu + "";
            }
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
            qtdaPensou++; 
            if (this.index == 0)
            {
                janela.filo1_pensou.Text = qtdaPensou + "";
            }
            if (this.index == 1)
            {
                janela.filo2_Pensou.Text = qtdaPensou + "";
            }
            if (this.index == 2)
            {
                janela.filo3_Pensou.Text = qtdaPensou + "";
            }
            if (this.index == 3)
            {
                janela.filo4_Pensou.Text = qtdaPensou + "";
            }
            if (this.index == 4)
            {
                janela.filo5_Pensou.Text = qtdaPensou + "";
            }
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
                
                if (this.index == 0)
                {
                    janela.filo1_Tempo.Text = relogio.ElapsedMilliseconds + "";
                }
                if (this.index == 1)
                {
                    janela.filo2_Tempo.Text = relogio.ElapsedMilliseconds + "";

                }
                if (this.index == 2)
                {
                    janela.filo3_Tempo.Text = relogio.ElapsedMilliseconds + "";

                }
                if (this.index == 3)
                {
                    janela.filo4_Tempo.Text = relogio.ElapsedMilliseconds + "";

                }
                if (this.index == 4)
                {
                    janela.filo5_Tempo.Text = relogio.ElapsedMilliseconds + "";

                }
            }
            this.relogio.Stop();
        }

        public void AtualizaStatus(string status)
        {
            if (this.index == 0)
            {
                janela.filo1_Status.Text = status;
            }
            if (this.index == 1)
            {
                janela.filo2_Status.Text = status;


            }
            if (this.index == 2)
            {
                janela.filo3_Status.Text = status;


            }
            if (this.index == 3)
            {
                janela.filo4_Status.Text = status;


            }
            if (this.index == 4)
            {
                janela.filo5_Status.Text = status;


            }
        }

    }
}
