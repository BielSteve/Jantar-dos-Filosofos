using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BielFilosofos.jantar
{
    class Mesa
    {
        public Mesa(Form1 janela)
        {
            List<Filosofo> filosofos = retornaFilosofo(janela);
            Thread mesaThread = new Thread(new ThreadStart(()=> {
                //List<Thread> filosofosThread = new List<Thread>();
                foreach(Filosofo filosofo in filosofos)
                {
                    Thread filosofoThread = new Thread(new ThreadStart(filosofo.ComecarAJantar));
                    filosofoThread.Start();
                }
            }));
            mesaThread.Start();        
        }

        private List<Filosofo> retornaFilosofo(Form1 janela) {
            List<Filosofo> filosofos = new List<Filosofo>(5);
            for(int i=0; i<5; i++)
            {
                Filosofo filosofo1 = new Filosofo(i, filosofos, janela);
                filosofos.Add(filosofo1);

            }
            foreach (Filosofo filosofo in filosofos)
            {
                filosofo.garfoDireito = new Mao();
                filosofo.garfoEsquerdo = new Mao();
            }
            return filosofos;
        }
    }
}
